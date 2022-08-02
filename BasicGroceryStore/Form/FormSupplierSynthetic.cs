using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BasicGroceryStore
{
    public partial class FormSupplierSynthetic : Form
    {
        private BUS_Product bus_product;
        private BUS_Supplier bus_supplier;
        private Supplier supplier_choosing;

        public FormSupplierSynthetic()
        {
            InitializeComponent();

            bus_product = new BUS_Product();
            bus_supplier = new BUS_Supplier();
            LoadData();
        }

        private void LoadData()
        {
            dgvSupplier.Controls.Clear();
            cbTypeProductFilter.DataSource = bus_product.GetAllTypeOfProduct();

            dgvSupplier.DataSource = bus_supplier.GetAllSupplier();
            dgvSupplier.Columns[0].Visible = false;

            supplier_choosing = new Supplier();
        }

        private DataTable getTableFilter(DataTable table, DataTable table_filter)
        {
            DataTable dataTable;
            if (table == null)
            {
                table = table_filter;
                table.PrimaryKey = new DataColumn[] { table.Columns["ID"] };
                dataTable = table;
            }
            else
            {
                dataTable = table.Clone();
                foreach (DataRow row in table_filter.Rows)
                {
                    if (table.Rows.Contains(row[0]))
                    {
                        dataTable.ImportRow(row);
                    }
                }
            }
            return dataTable;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(supplier_choosing != null)
            {
                if( MessageBox.Show($"Bạn có thực sự muốn xóa nhà cung cấp {supplier_choosing.Name} không?", "CẢNH BÁO", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (bus_supplier.Delete(supplier_choosing))
                    {
                        supplier_choosing = null;
                        MessageBox.Show("Đã xóa thông tin thành công!", "THÔNG BÁO");
                        LoadData();
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
            DataTable table = null;
            DataTable table_filter;

            if (!chbSupplierName.Checked && !chbSupplierAddress.Checked && !chbTypeProduct.Checked)
                return;

            if (chbSupplierName.Checked)
            {
                table_filter = bus_supplier.FindSupplierByName(txtSupplierNameFilter.Text.Trim());
                table = getTableFilter(table, table_filter);
            }
            if (chbSupplierAddress.Checked)
            {
                table_filter = bus_supplier.FindSupplierByAddress(txtSupplierAddressFilter.Text.Trim());
                table = getTableFilter(table, table_filter);
            }
            if (chbTypeProduct.Checked)
            {
                table_filter = bus_supplier.FindSupplierByTypeProduct(cbTypeProductFilter.Text);
                table = getTableFilter(table, table_filter);
            }

            dgvSupplier.Controls.Clear();
            dgvSupplier.DataSource = table;
        }

        private void chbSupplierName_CheckedChanged(object sender, EventArgs e)
        {
            txtSupplierNameFilter.Enabled = chbSupplierName.Checked;
        }

        private void chbSupplierAddress_CheckedChanged(object sender, EventArgs e)
        {
            txtSupplierAddressFilter.Enabled = chbSupplierAddress.Checked;
        }

        private void chbTypeProduct_CheckedChanged(object sender, EventArgs e)
        {
            cbTypeProductFilter.Enabled = chbTypeProduct.Checked;
        }
    }
}
