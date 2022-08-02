using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicGroceryStore
{
    public partial class FormCustomer : Form
    {
        private BUS_Customer bus;
        private Customer _customer;
        private bool isNewCustomer;

        public FormCustomer()
        {
            InitializeComponent();

            bus = new BUS_Customer();
            _customer = new Customer();
            isNewCustomer = true;

            LoadData();
        }

        public FormCustomer(Customer customer)
        {
            InitializeComponent();

            bus = new BUS_Customer();
            _customer = customer;
            isNewCustomer = false;

            LoadData();
        }


        private bool isValidData()
        {
            if (!int.TryParse(txtCustomerValue.Text, out int a))
            {
                return false;
            }
            if (dtPickDateJoin.Value > DateTime.Now)
            {
                return false;
            }
            return true;
        }

        private void LoadData()
        {
            txtName.Text = _customer.Name;
            dtPickDateJoin.Value = _customer.DateJoin;
            txtPhone.Text = _customer.Phone;
            txtCustomerValue.Text = _customer.Value.ToString();
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isValidData())
            {
                _customer.Name = txtName.Text.Trim();
                _customer.DateJoin = dtPickDateJoin.Value;
                _customer.Phone = txtPhone.Text.Trim();
            }
            else
            {
                MessageBox.Show("Có thông tin chưa hợp lệ!\nVui lòng kiểm tra tên khách hàng và ngày tham gia!", "LỖI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (isNewCustomer)
            {
                if (bus.Create(_customer))
                {
                    MessageBox.Show("Tạo khách hàng mới thành công!", "THÔNG BÁO");
                    UCHomePage.Instance.LoadCustomerData();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm thông tin khách hàng!\nVui lòng kiểm tra lại tên khách hàng!", "LỖI");
                }
            }
            else
            {
                if (bus.Update(_customer))
                {
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "THÔNG BÁO");
                    UCHomePage.Instance.LoadCustomerData();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi cập nhật thông tin khách hàng!\nVui lòng kiểm tra lại tên khách hàng!", "LỖI");
                }
            }
        }
    }
}
