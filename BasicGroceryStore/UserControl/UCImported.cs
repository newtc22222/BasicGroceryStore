using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BasicGroceryStore
{
    public partial class UCImported : UserControl
    {
        private BUS_Product bus_product;
        private BUS_Imported bus_imported;
        private BUS_Imported_Item bus_item;

        private Imported _import;
        private List<Imported_Item> _importedDetails;

        static UCImported _obj;
        public static UCImported Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCImported();
                }
                return _obj;
            }
        }

        public UCImported()
        {
            InitializeComponent();

            bus_product = new BUS_Product();
            bus_imported = new BUS_Imported();
            bus_item = new BUS_Imported_Item();
        }

        public void LoadData()
        {
            cbTypeProduct.DataSource = bus_product.GetAllTypeOfProduct();

            dgvProduct.Controls.Clear();
            dgvProduct.DataSource = bus_product.GetAllProduct();
            

            dgvProduct.Columns[0].Visible = false; // Hide ID Column
        }

        public void settingStaffInformation()
        {
            if (MainForm.staff_using != null)
                txtStaffName.Text = MainForm.staff_using.Name;
            else
                txtStaffName.Clear();
        }

        private Imported settingInformation()
        {
            Imported import = new Imported();
            txtBillID.Text = import.ID;
            dtPickDateCreate.Value = import.DateCreate;
            txtTotalPrice.Text = import.Value.ToString();

            settingStaffInformation();

            return import;
        }

        private void clearInformation()
        {
            txtBillID.Clear();
            txtStaffName.Clear();
            txtTotalPrice.Clear();

            flowpnl_Item.Controls.Clear();

            _importedDetails.Clear();
            _import = null;
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
            if(MessageBox.Show("Hủy toàn bộ phiếu nhập hàng?", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                            _importedDetails.Add(new Imported_Item(
                                iD: i + 1,
                                billID: _import.ID,
                                productID: item.product_id,
                                price: item.product_price,
                                quantity: item.product_quantity)
                                );
                        }

                        if (MainForm.staff_using != null)
                            _import.StaffID = MainForm.staff_using.ID;
                        else
                            _import.StaffID = "";

                        _import.Value = float.Parse(txtTotalPrice.Text);

                        if (bus_imported.Create(_import))
                        {
                            foreach (Imported_Item item in _importedDetails)
                            {
                                bus_item.Create(item);
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
                default:
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

        private void btnMakeNewProduct_Click(object sender, EventArgs e)
        {
            new FormProduct().ShowDialog();
        }

        private void btnCheckSupplier_Click(object sender, EventArgs e)
        {
            new FormSupplierSynthetic().ShowDialog();
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

            if (_import == null)
            {
                _import = settingInformation();
            }
            _importedDetails = new List<Imported_Item>();

            string product_id = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            string name = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            float price = float.Parse(dgvProduct.CurrentRow.Cells[6].Value.ToString());

            UCProductItem item = new UCProductItem(flowpnl_Item, txtTotalPrice, product_id, name, price);
            item.SettingItem();
        }
    }
}
