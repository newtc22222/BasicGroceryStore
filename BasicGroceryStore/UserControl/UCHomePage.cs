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
        private BUS_Customer bus_customer;
        private BUS_Imported bus_imported;
        private BUS_Ordered bus_ordered;

        private Dictionary<string, string> link;

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

            link = new Dictionary<string, string>();

            bus_customer = new BUS_Customer();
            bus_imported = new BUS_Imported();
            bus_ordered = new BUS_Ordered();

            new Thread(LoadStoreInformation).Start();
            LoadCustomerData();
        }

        #region ButtonControl
        private void btnChangeCustomerInfor_Click(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "")
                return;

            new FormCustomer(new Customer(
                name: txtCustomerName.Text,
                phone: txtCustomerPhone.Text,
                dateJoin: dtCustomerDateJoin.Value,
                value: float.Parse(txtCustomerValue.Text),
                e_level: dgvCustomer.CurrentRow.Cells[4].Value.ToString())).ShowDialog();
        }

        private void btnChangeStoreInfor_Click(object sender, EventArgs e)
        {
            new FormStoreInfomation().ShowDialog();
        }

        private void btnChangeYourInfor_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            new FormCustomer().ShowDialog();
        }

        private void btnReloadValue_Click(object sender, EventArgs e)
        {
            LoadIncomeData();
        }
        #endregion

        #region PictureBox_Link

        private void picYoutube_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(link["youtube"]);
            } 
            catch(Exception)
            {
                MessageBox.Show("Địa chỉ được lưu không hợp lệ, vui lòng kiểm tra!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void picFace_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(link["facebook"]);
            }
            catch (Exception)
            {
                MessageBox.Show("Địa chỉ được lưu không hợp lệ, vui lòng kiểm tra!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picInsta_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(link["instagram"]);
            }
            catch (Exception)
            {
                MessageBox.Show("Địa chỉ được lưu không hợp lệ, vui lòng kiểm tra!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picLinkedIn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(link["linkedin"]);
            }
            catch (Exception)
            {
                MessageBox.Show("Địa chỉ được lưu không hợp lệ, vui lòng kiểm tra!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picStoreLocation_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(link["map"]);
            }
            catch (Exception)
            {
                MessageBox.Show("Địa chỉ được lưu không hợp lệ, vui lòng kiểm tra!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictContact_Click(object sender, EventArgs e)
        {

        }
        #endregion


        public void LoadStoreInformation()
        {
            DAO_Information dao = new DAO_Information("StoreInformation.xml");
            Dictionary<string, string> data = dao.LoadStoreInformation();

            lblAddress.Text = "Địa chỉ: " + data["address"];
            lblAddress.MaximumSize = new Size(560, 0);
            lblAddress.AutoSize = true;

            lblEmail.Text = "Email: " + data["email"];
            lblPhone.Text = "Số điện thoại: " + data["phone"];

            link.Clear();
            link.Add("map", data["link_map"]);
            link.Add("facebook", data["link_fb"]);
            link.Add("instagram", data["link_ig"]);
            link.Add("linkedin", data["link_linkedin"]);
            link.Add("youtube", data["link_ut"]);
        }

        public void LoadCustomerData()
        {
            dgvCustomer.DataSource =  bus_customer.GetAllCustomer();
        }

        /// <summary>
        /// Setting staff data to form
        /// </summary>
        /// <param name="staff"></param>
        public void LoadStaffData(Staff staff)
        {
            if (staff != null)
            {
                lblYourName.Text = $"Họ tên: {staff.Name}";
                lblYourGender.Text = $"Giới tính: {staff.Gender}";
                lblYourEmail.Text = $"Email: {staff.Email}";
                lblYourPhone.Text = $"Số điện thoại: {staff.Phone}";
                picStaff.Image = staff.Images;
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
            double income_day = bus_ordered.GetValueOfAllBills_Day(DateTime.Today).Value;
            txtIncomeDay.Text = GetFormatString.GetCurrencyString(income_day);
            double income = bus_ordered.GetValueOfAllBills().Value; // Thu nhap
            txtTotalIncome.Text = GetFormatString.GetCurrencyString(income);

            double spending_day = bus_imported.GetValueOfAllBills_Day(DateTime.Today).Value;
            txtSpendingDay.Text = GetFormatString.GetCurrencyString(spending_day);
            double spending = bus_imported.GetValueOfAllBills().Value; // Chi tra
            txtTotalSpending.Text = GetFormatString.GetCurrencyString(spending);


            txtProfit.Text = ((income - spending) / spending * 100).ToString("N3") + " %";
        }

        /// <summary>
        /// Show image of customer's level
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
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
