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
    public partial class MainForm : Form
    {
        #region Properties
        private Point firstPoint;
        private bool mouseIsDown = false;
        #endregion

        public MainForm()
        {
            InitializeComponent();
            AddTabToControl();
            timer.Start();
        }

        private void ShowTabUsing(string tabName)
        {
            lblTabShow.Text = $"Tab đang hiển thị: {tabName}";
        }

        private void AddTabToControl()
        {
            pnlMain.Controls.Add(UCHomePage.Instance);
            ShowTabUsing(btnHomePage.Text);
        }

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
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnProduct.Text);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnOrder.Text);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnImport.Text);
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnStatistic.Text);
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnHomePage.Text);
            UCHomePage.Instance.BringToFront();
        }

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
    }
}
