using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BasicGroceryStore
{
    public partial class UCOrdered : UserControl
    {
        private BUS_Product bus_product;
        private BUS_Ordered bus_order;
        private BUS_Ordered_Item bus_item;

        private Ordered _order;
        private List<Ordered_Item> _orderedDetails;

        static UCOrdered _obj;
        public static UCOrdered Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCOrdered();
                }
                return _obj;
            }
        }
        public UCOrdered()
        {
            InitializeComponent();

            bus_product = new BUS_Product();
            bus_order = new BUS_Ordered();
            bus_item = new BUS_Ordered_Item();
        }

        public void LoadData()
        {
            cbTypeProduct.DataSource = bus_product.GetAllTypeOfProduct();

            dgvProduct.Controls.Clear();
            dgvProduct.DataSource = bus_product.GetAllProduct();

            dgvProduct.Columns[0].Visible = false; //Hide ID Column
        }

        public void settingStaffInformation()
        {
            if (MainForm.staff_using != null)
                txtStaffName.Text = MainForm.staff_using.Name;
            else
                txtStaffName.Clear();
        }

        private Ordered settingInformation()
        {
            Ordered order = new Ordered();
            txtBillID.Text = order.ID;
            dtPickDateCreate.Value = order.DateCreate;

            settingStaffInformation();

            return order;
        }

        private void clearInformation()
        {
            txtBillID.Clear();
            txtStaffName.Clear();
            txtTotalPrice.Clear();
            txtCustomerName.Clear();

            flowpnl_Item.Controls.Clear();

            _orderedDetails.Clear();
            _order = null;
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

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCancelBill_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hủy toàn bộ phiếu bán hàng?", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                clearInformation();
        }

        private void btnMakeBills_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Bạn có muốn in hóa đơn không?", "THÔNG BÁO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    {
                        break;
                    }
                case DialogResult.No:
                    {
                        for (int i = 0; i < flowpnl_Item.Controls.Count; i++)
                        {
                            UCProductItem item = (UCProductItem)flowpnl_Item.Controls[i];
                            _orderedDetails.Add(new Ordered_Item(
                                iD: i + 1,
                                billID: _order.ID,
                                productID: item.product_id,
                                price: item.product_price,
                                quantity: item.product_quantity)
                                );
                        }

                        if (MainForm.staff_using != null)
                            _order.StaffID = MainForm.staff_using.ID;
                        else
                            _order.StaffID = "";

                        _order.CustomerName = txtCustomerName.Text.Trim();
                        _order.Value = float.Parse(txtTotalPrice.Text);

                        if (bus_order.Create(_order, _order.CustomerName))
                        {
                            foreach (Ordered_Item item in _orderedDetails)
                            {
                                if (!bus_item.Create(item))
                                {
                                    bus_order.Delete(_order);
                                    MessageBox.Show("Có sản phẩm không đủ hàng!\nVui lòng kiểm tra lại!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                            MessageBox.Show("Đã lưu thông tin hóa đơn!", "THÔNG BÁO");

                            MainForm.LoadData.Invoke();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi xử lý hóa đơn", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        clearInformation();
                        break;
                    }
                default: //Cancel
                    break;
            }
        }

        private void btnChooseProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckHistory_Click(object sender, EventArgs e)
        {
            UCStatistic.Instance.BringToFront();
        }

        private void btnUseScanMachine_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng này đang được phát triển!");
        }

        private void btnCheckCustomer_Click(object sender, EventArgs e)
        {
            UCHomePage.Instance.BringToFront();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DataTable table = null;
            DataTable table_filter;

            if (!chbName.Checked && !chbPrice.Checked && !chbSupplier.Checked && !chbTypeProduct.Checked)
                return;

            if (chbName.Checked)
            {
                table_filter = bus_product.FindProductByName(txtNameFilter.Text.Trim());
                table = getTableFilter(table, table_filter);
            }
            if (chbPrice.Checked)
            {
                float from = (float)numUDFrom.Value * 1000;
                float to = (float)numUDTo.Value * 1000;

                if (from > to)
                {
                    MessageBox.Show("Giá trị bắt đầu phải lớn hơn hoặc bằng giá trị kết thúc!", "THÔNG BÁO");
                    return;
                }

                table_filter = bus_product.FindProductByPriceRange(from, to);
                table = getTableFilter(table, table_filter);
            }
            if (chbSupplier.Checked)
            {
                table_filter = bus_product.FindProductBySupplier(txtSupplierFilter.Text.Trim());
                table = getTableFilter(table, table_filter);
            }
            if (chbTypeProduct.Checked)
            {
                table_filter = bus_product.FindProductByTypeProduct(cbTypeProduct.Text.Trim());
                table = getTableFilter(table, table_filter);
            }

            dgvProduct.Controls.Clear();
            dgvProduct.DataSource = table;
        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduct.CurrentCell.RowIndex == dgvProduct.RowCount - 1)
                return;

            if (_order == null)
            {
                _order = settingInformation();
            }
            _orderedDetails = new List<Ordered_Item>();

            int store_quantity = int.Parse(dgvProduct.CurrentRow.Cells[4].Value.ToString());

            string product_id = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            string name = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            float price = float.Parse(dgvProduct.CurrentRow.Cells[6].Value.ToString());

            UCProductItem item = new UCProductItem(flowpnl_Item, txtTotalPrice, product_id, name, price);
            if(store_quantity < 1)
            {
                MessageBox.Show("Vui lòng nhập thêm sản phẩm!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int index = item.FindThisItemInContainer();
                if((index != -1) && store_quantity == ((UCProductItem)flowpnl_Item.Controls[index]).product_quantity)
                {
                    MessageBox.Show("Không đủ số lượng hàng trong kho!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    item.SettingMaxQuantity(store_quantity);
                    item.SettingItem();
                }
            }
        }
    }
}
