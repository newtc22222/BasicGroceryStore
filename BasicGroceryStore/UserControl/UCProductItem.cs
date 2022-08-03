using System;
using System.Windows.Forms;

namespace BasicGroceryStore
{
    public partial class UCProductItem : UserControl
    {
        #region properties
        private FlowLayoutPanel _container;
        private TextBox _txtTotalPrice;

        public string product_id;
        public string product_name;
        public float product_price;
        public int product_quantity;
        public double total_value;
        #endregion

        /// <summary>
        /// Using to show item in Order and Import
        /// </summary>
        /// <param name="container"></param>
        /// <param name="txtTotalPrice"></param>
        /// <param name="product_id"></param>
        /// <param name="product_name"></param>
        /// <param name="product_price"></param>
        public UCProductItem(FlowLayoutPanel container, TextBox txtTotalPrice,
            string product_id, string product_name, float product_price)
        {
            InitializeComponent();

            this._container = container;
            this._txtTotalPrice = txtTotalPrice;

            this.product_id = product_id;
            this.product_name = product_name;
            this.product_price = product_price;
            this.product_quantity = 1;
        }

        /// <summary>
        /// Change total bill when bill control has a change
        /// </summary>
        public void CalculateTotalPrice()
        {
            double bill_sum = 0;

            foreach (UCProductItem item in _container.Controls)
            {
                bill_sum += item.total_value;
            }

            _txtTotalPrice.Text = bill_sum.ToString();
        }

        private void IncreaseQuantity()
        {
            numUDQuantity.Value += 1;
        }

        public void SettingMaxQuantity(int max_quantity)
        {
            numUDQuantity.Maximum = max_quantity;
        }

        public int FindThisItemInContainer()
        {
            foreach(UCProductItem item in _container.Controls)
            {
                if (item.product_id == this.product_id)
                {
                    return _container.Controls.GetChildIndex(item);
                }
            }
            return -1;
        }

        /// <summary>
        /// Add new item or increase if they was availabled
        /// </summary>
        public void SettingItem()
        {
            int index = FindThisItemInContainer();
            if (index == -1) // New
            {
                lblProductName.Text = product_name;
                lblProductPrice.Text = GetFormatString.GetCurrencyString(product_price);
                txtProductValue.Text = product_price.ToString();
                total_value = product_price;

                _container.Controls.Add(this);
            }
            else
            {
                ((UCProductItem)_container.Controls[index]).IncreaseQuantity();
            }
            CalculateTotalPrice();
        }

        private void numUDQuantity_ValueChanged(object sender, EventArgs e)
        {
            product_quantity = (int)numUDQuantity.Value;
            total_value = product_quantity * product_price;
            txtProductValue.Text = total_value.ToString();
            CalculateTotalPrice();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _container.Controls.Remove(this);
            CalculateTotalPrice();
        }
    }
}
