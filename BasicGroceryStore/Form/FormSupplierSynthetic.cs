using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicGroceryStore
{
    public partial class FormSupplierSynthetic : Form
    {
        #region Properties
        private Point firstPoint;
        private bool mouseIsDown = false;
        private Supplier supplier_choosing;
        #endregion

        public FormSupplierSynthetic()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            dgvSupplier.Controls.Clear();
            cbTypeProductFilter.DataSource = BLL.Instance.getAllTypeOfProduct();

            dgvSupplier.DataSource = BLL.Instance.getAllSupplier();
            supplier_choosing = new Supplier();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(supplier_choosing != null)
            {
                if( MessageBox.Show($"Bạn có thực sự muốn xóa nhà cung cấp {supplier_choosing.Name} không?", "CẢNH BÁO", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (BLL.Instance.deleteSupplier(supplier_choosing.ID))
                    {
                        supplier_choosing = null;
                        MessageBox.Show("Đã xóa thông tin thành công!", "THÔNG BÁO");
                    } 
                    else
                    {
                        MessageBox.Show("Xóa thông tin không thành công!\nVui lòng kiểm tra lại các sản phẩm của nhà cung cấp này!", "LỖI",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSupplierNameFilter.Clear();
            txtSupplierAddressFilter.Clear();
            txtProductNameFilter.Clear();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new FormSupplier().ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            new FormSupplier(supplier_choosing).ShowDialog();
        }

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSupplier.CurrentCell.RowIndex == dgvSupplier.RowCount - 1)
                return;

            supplier_choosing.ID = dgvSupplier.CurrentRow.Cells[0].Value.ToString();
            supplier_choosing.Name = dgvSupplier.CurrentRow.Cells[1].Value.ToString();
            supplier_choosing.Address = dgvSupplier.CurrentRow.Cells[2].Value.ToString();
            supplier_choosing.Email = dgvSupplier.CurrentRow.Cells[3].Value.ToString();
            supplier_choosing.Contact = dgvSupplier.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }
    }
}
