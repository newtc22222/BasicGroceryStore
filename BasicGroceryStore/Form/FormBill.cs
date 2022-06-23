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
    public partial class FormBill : Form
    {
        #region Properties
        private Point firstPoint;
        private bool mouseIsDown = false;
        #endregion

        public FormBill(Ordered bill)
        {
            InitializeComponent();
            LoadData(bill);
        }

        public FormBill(Imported bill)
        {
            InitializeComponent();
            LoadData(bill);
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

        private void LoadData(Ordered bill)
        {
            txtBillID.Text = bill.ID;
            txtDateCreate.Text = bill.DateCreate.ToString();
            txtTotalPrice.Text = bill.Value.ToString();
            
            if (bill.StaffID != "")
                txtStaffName.Text = BLL.Instance.getStaff(bill.StaffID).Name;

            txtCustomerName.Text = bill.CustomerName;

            dgvBillDetails.DataSource = BLL.Instance.getOrderedDetails(bill);
        }

        private void LoadData(Imported bill)
        {
            txtBillID.Text = bill.ID;
            txtDateCreate.Text = bill.DateCreate.ToString();
            txtTotalPrice.Text = bill.Value.ToString();

            if (bill.StaffID != "")
                txtStaffName.Text = BLL.Instance.getStaff(bill.StaffID).Name;

            lblCustomerName.Visible = false;
            txtCustomerName.Visible = false;

            dgvBillDetails.DataSource = BLL.Instance.getImportedDetails(bill);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
