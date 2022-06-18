using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicGroceryStore
{
    public partial class FormProduct : Form
    {
        #region Properties
        private Point firstPoint;
        private bool mouseIsDown = false;
        private bool isNewProduct;
        #endregion

        public FormProduct()
        {
            InitializeComponent();
            isNewProduct = true;

            LoadDataCombobox();
            LoadProductInformation(new Product());
        }

        public FormProduct(Product product)
        {
            InitializeComponent();
            isNewProduct = false;

            LoadDataCombobox();
            LoadProductInformation(product);
        }

        private void LoadDataCombobox()
        {
            cbTypeProduct.DataSource = BLL.Instance.getAllTypeOfProduct();
            cbUnit.DataSource = BLL.Instance.getAllUnit();
            
            cbSupplier.DataSource = new BindingSource(BLL.Instance.getDictionarySupplier(), null);
            cbSupplier.DisplayMember = "Value";
            cbSupplier.ValueMember = "Key";
        }

        private void LoadProductInformation(Product product)
        {
            txtProductID.Text = product.ID;
            txtName.Text = product.Name;
            txtPrice.Text = product.Price.ToString();
            txtNote.Text = product.Note;
            txtQuantity.Text = product.Quantity.ToString();

            cbTypeProduct.Text = product.TypeProduct;
            cbUnit.Text = product.Unit;
            
            if(product.SupplierID != "")
                cbSupplier.SelectedValue = product.SupplierID;

            picRepresent.Image = product.Image;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picRepresent.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            new FormSupplier().ShowDialog();
            LoadDataCombobox();
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
                int x = Location.X - xDiff;
                int y = Location.Y - yDiff;
                Location = new Point(x, y);
            }
        }
        private void pnlMove_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }
        #endregion

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isValid())
                return;

            Product product = new Product();
            product.ID = txtProductID.Text;
            product.Name = txtName.Text;
            product.TypeProduct = cbTypeProduct.Text;
            product.Unit = cbUnit.Text;
            product.SupplierID = cbSupplier.SelectedValue.ToString();
            product.Image = picRepresent.Image;
            product.Quantity = int.Parse(txtQuantity.Text);
            product.Note = txtNote.Text;
            product.Price = float.Parse(txtPrice.Text);

            if (isNewProduct)
            {
                if (BLL.Instance.createProduct(product))
                {
                    MessageBox.Show("Thêm sản phẩm mới thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình thêm!\n Vui lòng kiểm tra lại dữ liệu!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (BLL.Instance.updateProduct(product))
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình sửa!\n Vui lòng kiểm tra lại dữ liệu!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private bool isValid()
        {
            if(txtName.Text == "")
                return false;
            if (picRepresent.Image == null)
                return false;
            return true;
        }
    }
}
