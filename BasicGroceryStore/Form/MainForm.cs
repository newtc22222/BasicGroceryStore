using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicGroceryStore
{
    public partial class MainForm : Form
    {
        public static Action LoadData;
        public static Staff staff_using;

        public MainForm()
        {
            InitializeComponent();

            // Setting menu
            cbSetting.DataSource = Enum.GetValues(typeof(SettingControl));

            AddTabToControl();
            SettingCallForLoadData();

            LoadData.Invoke();

            timer.Start();
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

        private void ShowTabUsing(string tabName)
        {
            lblTabShow.Text = $"Tab đang hiển thị: {tabName}";
        }

        private void AddTabToControl()
        {
            pnlMain.Controls.Add(UCHomePage.Instance);
            pnlMain.Controls.Add(UCImported.Instance);
            pnlMain.Controls.Add(UCOrdered.Instance);
            pnlMain.Controls.Add(UCProduct.Instance);
            pnlMain.Controls.Add(UCStatistic.Instance);
            pnlMain.Controls.Add(UCStaff.Instance);
            //pnlMain.Controls.Add(UCBrowser.Instance);
            //pnlMain.Controls.Add(UCCalendar.Instance);

            ShowTabUsing(btnHomePage.Text);
        }

        private static void SettingCallForLoadData()
        {
            LoadData = UCProduct.Instance.LoadData;
            LoadData += UCImported.Instance.LoadData;
            LoadData += UCOrdered.Instance.LoadData;
        }

        #region TabControl
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
            //ShowTabUsing(btnCalendar.Text);
            //UCCalendar.Instance.BringToFront();
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

        private void cbSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((SettingControl)cbSetting.SelectedIndex)
            {
                case SettingControl.LOGIN:
                    {
                        if (staff_using == null)
                        {
                            new FormLogin().ShowDialog();
                            UCHomePage.Instance.LoadStaffData(staff_using);
                        }                        
                        break;
                    }
                case SettingControl.LOGOUT:
                    {
                        if (staff_using == null)
                            return;

                        if (MessageBox.Show("Bạn có muốn kết thúc phiên đăng nhập không?", "THÔNG BÁO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            staff_using = null;
                            UCHomePage.Instance.LoadStaffData(staff_using);
                        }
                        break;
                    }
                case SettingControl.SUPPORT:
                    {
                        break;
                    }
                case SettingControl.INFORMATION:
                    {
                        MessageBox.Show(@"Ứng dụng này là dự án cá nhân nhỏ của Võ Nhật Phi!\nMọi thông tin muốn tìm hiểu thêm vui lòng liên hệ 0947679570!");
                        break;
                    }
                case SettingControl.EXIT:
                    {
                        if (MessageBox.Show("Bạn có muốn tắt ứng dụng không?", "THÔNG BÁO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Application.Exit();
                        }
                        break;
                    }
            }
        }
    }
}
