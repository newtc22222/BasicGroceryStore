using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicGroceryStore
{
    public partial class UCStatistic : UserControl
    {
        static UCStatistic _obj;
        public static UCStatistic Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCStatistic();
                }
                return _obj;
            }
        }
        public UCStatistic()
        {
            InitializeComponent();
        }

        private void radReportToday_CheckedChanged(object sender, EventArgs e)
        {
            chbReportIncome.Enabled = chbReportIncome.Checked = !radReportToday.Checked;
            chbReportSpending.Enabled = chbReportSpending.Checked = !radReportToday.Checked;
        }

        private void dgvSellingHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Ordered bill = new Ordered();
            bill.ID = dgvSellingHistory.CurrentRow.Cells[0].Value.ToString();
            bill.DateCreate = (DateTime)dgvSellingHistory.CurrentRow.Cells[1].Value;
            bill.Value = float.Parse(dgvSellingHistory.CurrentRow.Cells[2].Value.ToString());           
            bill.StaffID = dgvSellingHistory.CurrentRow.Cells[4].Value.ToString();
            
            bill.CustomerName = dgvSellingHistory.CurrentRow.Cells[3].Value.ToString();

            new FormBill(bill).Show();
        }

        private void dgvImportHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Imported bill = new Imported();
            bill.ID = dgvImportHistory.CurrentRow.Cells[0].Value.ToString();
            bill.DateCreate = (DateTime)dgvImportHistory.CurrentRow.Cells[1].Value;
            bill.Value = float.Parse(dgvImportHistory.CurrentRow.Cells[2].Value.ToString());
            bill.StaffID = dgvImportHistory.CurrentRow.Cells[3].Value.ToString();

            new FormBill(bill).Show();
        }

        private void btnReloadSellingHistory_Click(object sender, EventArgs e)
        {
            dgvSellingHistory.Controls.Clear();
            dgvSellingHistory.DataSource = BLL.Instance.getAllOrdered();
            dgvSellingHistory.Columns[0].Visible = false;
        }

        private void btnEditSellingHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnReloadImportHistory_Click(object sender, EventArgs e)
        {
            dgvImportHistory.Controls.Clear();
            dgvImportHistory.DataSource = BLL.Instance.getAllImported();
            dgvImportHistory.Columns[0].Visible = false;
        }

        private void btnEditImportHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateChart_Click(object sender, EventArgs e)
        {
            chartSales.Series["Thu nhập"].Points.Clear();
            chartSales.Series["Chi tiêu"].Points.Clear();

            if (rad7days.Checked)
            {
                DateTime now = DateTime.Today;
                DateTime last = now.AddDays(-6);

                for (DateTime date = last; date <= now; date = date.AddDays(1))
                {
                    double spending = BLL.Instance.getTotalBuyValue_DAY(date);
                    chartSales.Series["Chi tiêu"].Points.AddXY(date.Day + "-" + date.Month, spending / 1000);

                    double income = BLL.Instance.getTotalSellValue_DAY(date);
                    chartSales.Series["Thu nhập"].Points.AddXY(date.Day + "-" + date.Month, income / 1000);
                }
            } 
            else if (rad6months.Checked)
            {
                DateTime now = DateTime.Today;
                DateTime last = now.AddMonths(-5);

                for (DateTime date = last; date <= now; date = date.AddMonths(1))
                {
                    double spending = BLL.Instance.getTotalBuyValue_MONTH(date);
                    chartSales.Series["Chi tiêu"].Points.AddXY(date.Month + "-" + date.Year, spending / 1000000);

                    double income = BLL.Instance.getTotalSellValue_MONTH(date);
                    chartSales.Series["Thu nhập"].Points.AddXY(date.Month + "-" + date.Year, income / 1000000);
                }
            }
            else if (rad5years.Checked)
            {
                DateTime now = DateTime.Today;
                DateTime last = now.AddYears(-4);

                for (DateTime date = last; date <= now; date = date.AddYears(1))
                {
                    double spending = 0, income = 0;
                    for(int i = 1; i <= 12; i++)
                    {
                        DateTime new_date = new DateTime(date.Year, i, 1);
                        
                        spending += BLL.Instance.getTotalBuyValue_MONTH(new_date);
                        income += BLL.Instance.getTotalSellValue_MONTH(new_date);
                    }
                    chartSales.Series["Chi tiêu"].Points.AddXY(date.Year, spending / 1000000);
                    chartSales.Series["Thu nhập"].Points.AddXY(date.Year, income / 1000000);
                }
            }
        }
    }
}
