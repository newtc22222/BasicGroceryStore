using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BasicGroceryStore
{
    public partial class UCHomePage : UserControl
    {
        private string link_map, link_fb, link_ig, link_linkedin, link_ut;
        public Staff staff_using = null;

        static UCHomePage _obj;
        public static UCHomePage Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCHomePage();
                }
                return _obj;
            }
        }
        public UCHomePage()
        {
            InitializeComponent();
            Thread thread = new Thread(LoadStoreInformation);
            thread.Start();
            LoadCustomerData();
            LoadStaffData();
        }

        #region ButtonControl
        private void btnChangeCustomerInfor_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeStoreInfor_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeYourInfor_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnReloadValue_Click(object sender, EventArgs e)
        {
            LoadIncomeData();
        }
        #endregion

        #region PictureBox_Link

        private void picYoutube_Click(object sender, EventArgs e)
        {
            Process.Start(link_ut);
        }

        private void picFace_Click(object sender, EventArgs e)
        {
            Process.Start(link_fb);
        }

        private void picInsta_Click(object sender, EventArgs e)
        {
            Process.Start(link_ig);
        }

        private void picLinkedIn_Click(object sender, EventArgs e)
        {
            Process.Start(link_linkedin);
        }

        private void picStoreLocation_Click(object sender, EventArgs e)
        {
            Process.Start(link_map);
        }

        private void pictContact_Click(object sender, EventArgs e)
        {

        }
        #endregion


        public void LoadStoreInformation()
        {
            DAO_Information dao = new DAO_Information("StoreInformation.xml");
            List<string> data = dao.loadInformation();

            lblAddress.Text = "Địa chỉ: " + data[0];
            lblAddress.MaximumSize = new Size(560, 0);
            lblAddress.AutoSize = true;

            lblEmail.Text = "Email: " + data[1];
            lblPhone.Text = "Số điện thoại: " + data[2];

            link_map = data[3];
            link_fb = data[4];
            link_ig = data[5];
            link_linkedin = data[6];
            link_ut = data[7];
        }

        public void LoadCustomerData()
        {
            dgvCustomer.DataSource =  BLL.Instance.getAllCustomerMember();
        }

        public void LoadStaffData()
        {
            if (staff_using != null)
            {
                lblYourName.Text = $"Họ tên: {staff_using.Name}";
                lblYourGender.Text = $"Giới tính: {staff_using.Gender}";
                lblYourEmail.Text = $"Email: {staff_using.Email}";
                lblYourPhone.Text = $"Số điện thoại: {staff_using.Phone}";
                picStaff.Image = staff_using.Images;
            }
            else
            {
                lblYourName.Text = "Họ tên: ";
                lblYourGender.Text = "Giới tính: ";
                lblYourEmail.Text = "Email: ";
                lblYourPhone.Text = "Số điện thoại: ";
                picStaff.Image = null;
            }
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCustomer.CurrentCell.RowIndex == dgvCustomer.RowCount - 1)
                return;

            txtCustomerName.Text = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
            txtCustomerPhone.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
            dtCustomerDateJoin.Value = (DateTime)dgvCustomer.CurrentRow.Cells[2].Value;
            txtCustomerValue.Text = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
            picCustomerLevel.BackgroundImage = LoadLevelCustomer(dgvCustomer.CurrentRow.Cells[4].Value.ToString());
        }

        public void LoadIncomeData()
        {
            txtIncomeDay.Text = BLL.Instance.getTotalSellValue_DAY(DateTime.Today).ToString();
            txtSpendingDay.Text = BLL.Instance.getTotalBuyValue_DAY(DateTime.Today).ToString();

            double income = BLL.Instance.getTotalValueOfOrdered_All(); // Thu nhap
            double spending = BLL.Instance.getTotalValueOfImported_All(); // Chi tra
            txtTotalIncome.Text = income.ToString();
            txtTotalSpending.Text = spending.ToString();
            txtProfit.Text = ((income - spending) / spending * 100).ToString() + " %";
        }

        private Image LoadLevelCustomer(string level)
        {
            string path = Path.GetDirectoryName(Directory.GetCurrentDirectory());
            path = path.Replace("bin", "Resources/") + level.Trim() + ".png";
            return Image.FromFile(path);
        }

        private void btnReloadCustomer_Click(object sender, EventArgs e)
        {
            LoadCustomerData();
        }
    }
}
