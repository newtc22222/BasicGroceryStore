using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BasicGroceryStore
{
    public partial class FormLogin : Form
    {
        private BUS_Account bus_account;
        private BUS_Staff bus_staff;

        public FormLogin()
        {
            InitializeComponent();

            bus_account = new BUS_Account();
            bus_staff = new BUS_Staff();
            LoadAccount();
        }

        private void LoadAccount()
        {
            DAO_Information dao = new DAO_Information("Account.xml");
            List<object> data = dao.LoadSaveAccount();
            txtUsername.Text = data[1].ToString();
            txtPassword.Text = data[2].ToString();
            chbRemember.Checked = Boolean.Parse(data[3].ToString());
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region MoveForm
        private Point firstPoint;
        private bool mouseIsDown = false;

        private void pnlMove_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;
        }
        private void pnlMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }
        private void pnlMove_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }
        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string staff_id = bus_account.CheckLogin(username, password);

            if (staff_id != "")
            {
                Account main_login = new Account(staff_id, username, password);
                bus_account.SaveAccount(main_login, chbRemember.Checked);

                MainForm.staff_using = bus_staff.GetStaff(staff_id);
                UCHomePage.Instance.LoadStaffData(MainForm.staff_using);
                this.Close();
            } 
            else
            {
                MessageBox.Show("Tài khoản không hợp lệ!\nVui lòng liên hệ với bên hỗ trợ hoặc tắt biểu mẫu này\nđể hoạt động ứng dụng bình thường!", "THÔNG BÁO", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa có thông tin!", "THÔNG BÁO HỖ TRỢ", MessageBoxButtons.OK);
        }
    }
}
