using System;
using System.Drawing;
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

        public void LoadData()
        {
            dgvProduct.Controls.Clear();
            dgvProduct.DataSource = BLL.Instance.getAllProduct();

            dgvProduct.Columns[0].Visible = false;
            dgvProduct.Columns[5].Visible = false;
            dgvProduct.Columns[8].Visible = false;
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
            Supplier sup = BLL.Instance.getSupplier(_product.SupplierID);

            txtSupplierID.Text = sup.ID;
            txtSupplierName.Text = sup.Name;
            txtSupplierAddress.Text = sup.Address;
            txtSupplierEmail.Text = sup.Email;
            txtSupplierPhone.Text = sup.Contact;

            dgvProductOfSupplier.DataSource = BLL.Instance.getAllProductOfSupplier(sup.ID);
            dgvProductOfSupplier.Columns[0].Visible = false;
            dgvProductOfSupplier.Columns[5].Visible = false;
            dgvProductOfSupplier.Columns[8].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

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

        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
    }
}
