using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicGroceryStore
{
    public partial class FormBill : Form
    {
        private BUS_Staff bus_staff;
        private BUS_Imported bus_imported;
        private BUS_Ordered bus_ordered;

        private Bill bill;
        private string typeBill;

        public FormBill(Ordered bill)
        {
            InitializeComponent();

            bus_staff = new BUS_Staff();
            bus_ordered = new BUS_Ordered();

            this.bill = bill;
            this.typeBill = "Ordered";            

            LoadData(bill);
        }

        public FormBill(Imported bill)
        {
            InitializeComponent();

            bus_staff = new BUS_Staff();
            bus_imported = new BUS_Imported();

            this.bill = bill;
            this.typeBill = "Imported";

            LoadData(bill);
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

        private void LoadData(Ordered bill)
        {
            txtBillID.Text = bill.ID;
            txtDateCreate.Text = bill.DateCreate.ToString();
            txtTotalPrice.Text = GetFormatString.GetCurrencyString(bill.Value);
            
            if (bill.StaffID != "")
                txtStaffName.Text = bus_staff.GetStaff(bill.StaffID).Name;

            txtCustomerName.Text = bill.CustomerName;

            dgvBillDetails.DataSource = bus_ordered.GetAllItemInBill(bill.ID);
        }

        private void LoadData(Imported bill)
        {
            txtBillID.Text = bill.ID;
            txtDateCreate.Text = bill.DateCreate.ToString();
            txtTotalPrice.Text = GetFormatString.GetCurrencyString(bill.Value);

            if (bill.StaffID != "")
                txtStaffName.Text = bus_staff.GetStaff(bill.StaffID).Name;

            lblCustomerName.Visible = false;
            txtCustomerName.Visible = false;

            dgvBillDetails.DataSource = bus_imported.GetAllItemInBill(bill.ID);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            if (typeBill == "Ordered")
            {
                if(MessageBox.Show("Bạn có muốn xóa đơn hàng này không?", "CẢNH BÁO", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (bus_ordered.Delete(bill))
                    {
                        MessageBox.Show("Đã xóa thông tin hóa đơn!", "THÔNG BÁO", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa thông tin hóa đơn!", "THÔNG BÁO", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa đơn hàng này không?", "CẢNH BÁO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (bus_imported.Delete(bill))
                    {
                        MessageBox.Show("Đã xóa thông tin hóa đơn!", "THÔNG BÁO", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa thông tin hóa đơn!", "THÔNG BÁO", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
