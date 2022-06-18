using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BasicGroceryStore
{
    public partial class MainForm : Form
    {
        #region Properties
        private Point firstPoint;
        private bool mouseIsDown = false;
        public static List<string> choosing = new List<string>() { "LOGIN", "LOGOUT", "SUPPORT", "INFORMATION", "EXIT" };
        #endregion

        public MainForm()
        {
            InitializeComponent();
            //new Thread(AddTabToControl).Start();
            AddTabToControl();
            timer.Start();
        }

        private void ShowTabUsing(string tabName)
        {
            lblTabShow.Text = $"Tab đang hiển thị: {tabName}";
        }

        private void AddTabToControl()
        {
            cbSetting.DataSource = choosing;
            pnlMain.Controls.Add(UCHomePage.Instance);
            pnlMain.Controls.Add(UCImported.Instance);
            pnlMain.Controls.Add(UCOrdered.Instance);
            pnlMain.Controls.Add(UCProduct.Instance);
            pnlMain.Controls.Add(UCStatistic.Instance);
            pnlMain.Controls.Add(UCStaff.Instance);
            //pnlMain.Controls.Add(UCBrowser.Instance);
            pnlMain.Controls.Add(UCCalendar.Instance);
            ShowTabUsing(btnHomePage.Text);
        }

        #region ButtonControl
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnStaff.Text);
            UCStaff.Instance.BringToFront();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnProduct.Text);
            UCProduct.Instance.BringToFront();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnOrder.Text);
            UCOrdered.Instance.BringToFront();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnImport.Text);
            UCImported.Instance.BringToFront();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnStatistic.Text);
            UCStatistic.Instance.BringToFront();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnHomePage.Text);
            UCHomePage.Instance.BringToFront();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            //ShowTabUsing(btnBrowser.Text);
            //UCBrowser.Instance.BringToFront();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnCalendar.Text);
            UCCalendar.Instance.BringToFront();
        }
        #endregion

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        #region MoveForm
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

        private void cbSetting_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if(cbSetting.SelectedItem.ToString() == "LOGIN" && UCHomePage.Instance.staff_using == null)
            {
                new FormLogin().ShowDialog();
                UCOrdered.Instance.settingStaffInformation();
                UCImported.Instance.settingStaffInformation();
            }
            if(cbSetting.SelectedItem.ToString() == "LOGOUT")
            {
                if (UCHomePage.Instance.staff_using == null)
                    return;

                if(MessageBox.Show("Bạn có muốn kết thúc phiên đăng nhập không?", "THÔNG BÁO", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UCHomePage.Instance.staff_using = null;
                    UCHomePage.Instance.LoadStaffData();
                    UCOrdered.Instance.settingStaffInformation();
                    UCImported.Instance.settingStaffInformation();
                }
            }
            if(cbSetting.SelectedItem.ToString() == "SUPPORT")
            {

            }
            if(cbSetting.SelectedItem.ToString() == "INFORMATION")
            {

            }
            if (cbSetting.SelectedItem.ToString() == "EXIT")
            {
                if (MessageBox.Show("Bạn có muốn tắt ứng dụng không?", "THÔNG BÁO", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
    }
}
