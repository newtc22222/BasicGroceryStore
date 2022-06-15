using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicGroceryStore
{
    public partial class FormSupplier : Form
    {
        #region Properties
        private Point firstPoint;
        private bool mouseIsDown = false;
        #endregion

        public FormSupplier()
        {
            InitializeComponent();
            LoadSupplier(new Supplier());
        }

        public FormSupplier(Supplier supplier)
        {
            InitializeComponent();
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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
