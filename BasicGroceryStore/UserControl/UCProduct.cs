using System;
using System.Data;
using System.Windows.Forms;

namespace BasicGroceryStore
{
    public partial class UCProduct : UserControl
    {
        private Product _product;
        private Supplier _supplier = null;

        static UCProduct _obj;
        public static UCProduct Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCProduct();
                }
                return _obj;
            }
        }
        public UCProduct()
        {
            InitializeComponent();
            _product = new Product();
            LoadData();
        }

        #region Function
        public void LoadData()
        {
            ClearProductDataForm();
            ClearSupplierForm();

            cbTypeProduct.DataSource = BLL.Instance.getAllTypeOfProduct();

            dgvProduct.Controls.Clear();
            dgvProduct.DataSource = BLL.Instance.getAllProduct();

            dgvProduct.Columns[0].Visible = false;
            dgvProduct.Columns[5].Visible = false;
            dgvProduct.Columns[8].Visible = false;
        }

        private void ClearProductDataForm()
        {
            txtName.Clear();
            txtTypeProduct.Clear();
            txtUnit.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();

            picRepresent.Image = null;
        }

        private void ClearSupplierForm()
        {
            _supplier = null;

            txtSupplierID.Clear();
            txtSupplierName.Clear();
            txtSupplierAddress.Clear();
            txtSupplierEmail.Clear();
            txtSupplierPhone.Clear();

            dgvProductOfSupplier.Controls.Clear();
            dgvProductOfSupplier.DataSource = null;
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
        #endregion

        #region Control
        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if(_product.Name != "")
            {
                new FormProduct(_product).ShowDialog();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new FormProduct().ShowDialog();
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            if(_supplier != null)
                new FormSupplier(_supplier).ShowDialog();
        }

        private void btnSeeMoreSupplier_Click(object sender, EventArgs e)
        {
            new FormSupplierSynthetic().ShowDialog();
        }

        private void btnLoadSupplier_Click(object sender, EventArgs e)
        {
            _supplier = BLL.Instance.getSupplier(_product.SupplierID);

            txtSupplierID.Text = _supplier.ID;
            txtSupplierName.Text = _supplier.Name;
            txtSupplierAddress.Text = _supplier.Address;
            txtSupplierEmail.Text = _supplier.Email;
            txtSupplierPhone.Text = _supplier.Contact;

            dgvProductOfSupplier.DataSource = BLL.Instance.getAllProductOfSupplier(_supplier.ID);
            dgvProductOfSupplier.Columns[0].Visible = false;
            dgvProductOfSupplier.Columns[5].Visible = false;
            dgvProductOfSupplier.Columns[8].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Bạn có muốn xóa sản phẩm {_product.Name}?", "CẢNH BÁO", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (BLL.Instance.deleteProduct(_product.ID))
                {
                    MessageBox.Show("Đã xóa thông tin sản phẩm!", "THÔNG BÁO");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa thông tin sản phẩm không thành công!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNameFilter.Clear();
            numUDFrom.Value = 1;
            numUDTo.Value = 50;
            txtSupplierFilter.Clear();
            txtTypeProduct.Clear();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DataTable table = null;
            DataTable table_filter;

            if (!chbName.Checked && !chbPrice.Checked && !chbSupplier.Checked && !chbTypeProduct.Checked)
                return;

            if(chbName.Checked)
            {
                table_filter = BLL.Instance.FindProductByName(txtNameFilter.Text.Trim());
                table = getTableFilter(table, table_filter);
            }
            if (chbPrice.Checked)
            {
                float from = (float)numUDFrom.Value * 1000;
                float to = (float)numUDTo.Value * 1000;
                
                if(from > to)
                {
                    MessageBox.Show("Giá trị bắt đầu phải lớn hơn hoặc bằng giá trị kết thúc!", "THÔNG BÁO");
                    return;
                }

                table_filter = BLL.Instance.FindProductByPriceRange(from, to);
                table = getTableFilter(table, table_filter);
            }
            if (chbSupplier.Checked)
            {
                table_filter = BLL.Instance.FindProductBySupplier(txtSupplierFilter.Text.Trim());
                table = getTableFilter(table, table_filter);
            }
            if (chbTypeProduct.Checked)
            {
                table_filter = BLL.Instance.FindProductByTypeProduct(cbTypeProduct.Text.Trim());
                table = getTableFilter(table, table_filter);
            }

            dgvProduct.Controls.Clear();
            dgvProduct.DataSource = table;
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduct.CurrentCell.RowIndex == dgvProduct.RowCount - 1)
                return;

            ClearSupplierForm();

            _product.ID =  dgvProduct.CurrentRow.Cells[0].Value.ToString();
            _product.Name = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            _product.TypeProduct = dgvProduct.CurrentRow.Cells[2].Value.ToString();
            _product.Unit = dgvProduct.CurrentRow.Cells[3].Value.ToString();
            _product.Quantity = int.Parse(dgvProduct.CurrentRow.Cells[4].Value.ToString());

            if (dgvProduct.CurrentRow.Cells[5].Value != DBNull.Value)
                _product.Image = AdditionalFunctions.ConvertByteArrayToImage((byte[])dgvProduct.CurrentRow.Cells[5].Value);
            else
                _product.Image = null;

            _product.Note = dgvProduct.CurrentRow.Cells[6].Value.ToString();
            _product.Price = float.Parse(dgvProduct.CurrentRow.Cells[7].Value.ToString());
            _product.SupplierID = dgvProduct.CurrentRow.Cells[8].Value.ToString();     
            

            txtName.Text = _product.Name;
            txtTypeProduct.Text = _product.TypeProduct;
            txtUnit.Text = _product.Unit;
            txtQuantity.Text = _product.Quantity.ToString();
            txtPrice.Text = _product.Price.ToString();
            txtNote.Text = _product.Note;
            picRepresent.Image = _product.Image;
        }

        private void dgvProductOfSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductOfSupplier.CurrentCell.RowIndex == dgvProductOfSupplier.RowCount - 1)
                return;

            _product.ID = dgvProductOfSupplier.CurrentRow.Cells[0].Value.ToString();
            _product.Name = dgvProductOfSupplier.CurrentRow.Cells[1].Value.ToString();
            _product.TypeProduct = dgvProductOfSupplier.CurrentRow.Cells[2].Value.ToString();
            _product.Unit = dgvProductOfSupplier.CurrentRow.Cells[3].Value.ToString();
            _product.Quantity = int.Parse(dgvProductOfSupplier.CurrentRow.Cells[4].Value.ToString());

            if (dgvProductOfSupplier.CurrentRow.Cells[5].Value != DBNull.Value)
                _product.Image = AdditionalFunctions.ConvertByteArrayToImage((byte[])dgvProductOfSupplier.CurrentRow.Cells[5].Value);
            else
                _product.Image = null;

            _product.Note = dgvProductOfSupplier.CurrentRow.Cells[6].Value.ToString();
            _product.Price = float.Parse(dgvProductOfSupplier.CurrentRow.Cells[7].Value.ToString());


            txtName.Text = _product.Name;
            txtTypeProduct.Text = _product.TypeProduct;
            txtUnit.Text = _product.Unit;
            txtQuantity.Text = _product.Quantity.ToString();
            txtPrice.Text = _product.Price.ToString();
            txtNote.Text = _product.Note;
            picRepresent.Image = _product.Image;
        }

        private void chbName_CheckedChanged(object sender, EventArgs e)
        {
            txtNameFilter.Enabled = chbName.Checked;
        }

        private void chbPrice_CheckedChanged(object sender, EventArgs e)
        {
            numUDFrom.Enabled = chbPrice.Checked;
            numUDTo.Enabled = chbPrice.Checked;
        }

        private void chbSupplier_CheckedChanged(object sender, EventArgs e)
        {
            txtSupplierFilter.Enabled = chbSupplier.Checked;
        }

        private void chbTypeProduct_CheckedChanged(object sender, EventArgs e)
        {
            cbTypeProduct.Enabled = chbTypeProduct.Checked;
        }

        #endregion
    }
}
