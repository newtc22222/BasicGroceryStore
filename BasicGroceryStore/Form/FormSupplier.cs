using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicGroceryStore
{
    public partial class FormSupplier : Form
    {
        private BUS_Supplier bus_supplier;

        public FormSupplier()
        {
            InitializeComponent();

            bus_supplier = new BUS_Supplier();
            LoadSupplier(new Supplier());
        }

        public FormSupplier(Supplier supplier)
        {
            InitializeComponent();

            bus_supplier = new BUS_Supplier();
            LoadSupplier(supplier);
        }

        private void LoadSupplier(Supplier supplier)
        {
            txtSupplierID.Text = supplier.ID;
            txtSupplierName.Text = supplier.Name;
            txtSupplierEmail.Text = supplier.Email;
            txtSupplierAddress.Text = supplier.Address;
            txtPhone.Text = supplier.Contact;
        }

        private bool checkInformation(Supplier supplier)
        {
            if (supplier.Name == "" || supplier.Address == "")
                return false;
            if(supplier.Contact == "" || supplier.Contact.Length < 10)
                return false;
            if(!Checking.IsValidEmail(supplier.Email))
                return false;
            return true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            Supplier _supplier = new Supplier();
            _supplier.ID = txtSupplierID.Text;
            _supplier.Name = txtSupplierName.Text.Trim();
            _supplier.Address = txtSupplierAddress.Text.Trim();
            _supplier.Email = txtSupplierEmail.Text.Trim();
            _supplier.Contact = txtPhone.Text.Trim();

            if (checkInformation(_supplier))
            {
                if(bus_supplier.GetSupplier(_supplier.ID) == null) // new Supplier
                {
                    if (bus_supplier.Create(_supplier))
                    {
                        MessageBox.Show("Thêm thông tin Nhà cung cấp thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin Nhà cung cấp không thành công!", "LỖI", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
                else
                {
                    if (bus_supplier.Update(_supplier))
                    {
                        MessageBox.Show("Cập nhật thông tin Nhà cung cấp thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra trong quá trình cập nhật!", "LỖI",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } 
            else
            {
                MessageBox.Show("Thông tin chưa phù hợp!\nVui lòng điều chỉnh lại!", "LỖI", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
