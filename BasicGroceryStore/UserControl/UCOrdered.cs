using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BasicGroceryStore
{
    public partial class UCOrdered : UserControl
    {
        private Ordered _order;
        private List<OrderedDetail> _orderedDetails;
        private DataTable table;

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
        }

        public void LoadData()
        {
            cbTypeProduct.DataSource = BLL.Instance.getAllTypeOfProduct();

            dgvProduct.Controls.Clear();
            dgvProduct.DataSource = BLL.Instance.getAllProduct();

            dgvProduct.Columns[0].Visible = false;
            dgvProduct.Columns[5].Visible = false;
            dgvProduct.Columns[8].Visible = false;
        }

        public void settingStaffInformation()
        {
            if (UCHomePage.Instance.staff_using != null)
                txtStaffName.Text = UCHomePage.Instance.staff_using.Name;
            else
                txtStaffName.Clear();
        }

        private Ordered settingInformation()
        {
            Ordered order = new Ordered();
            txtBillID.Text = order.ID;
            dtPickDateCreate.Value = order.DateCreate;
            txtTotalPrice.Text = order.Value.ToString();

            settingStaffInformation();

            return order;
        }

        private void clearInformation()
        {
            txtBillID.Clear();
            txtStaffName.Clear();
            txtTotalPrice.Clear();
            txtCustomerName.Clear();

            dgvOrderedDetails.DataSource = null;
            dgvOrderedDetails.Controls.Clear();

            _orderedDetails.Clear();
            _order = null;
        }

        private void createTableBillDetails()
        {
            table = new DataTable();

            table.Columns.Add("ProductID", typeof(string));
            table.Columns.Add("Tên", typeof(string));
            table.Columns.Add("Đơn vị", typeof(string));
            table.Columns.Add("Giá", typeof(float));
            table.Columns.Add("Số lượng", typeof(int));
            table.Columns.Add("Tổng", typeof(float));
            table.PrimaryKey = new DataColumn[] { table.Columns["ProductID"] };
        }

        private void changeBills(DataTable tb)
        {
            float bill_sum = 0;

            for (int i = 0; i < tb.Rows.Count; i++)
            {
                bill_sum += float.Parse(tb.Rows[i][5].ToString());
            }

            txtTotalPrice.Text = bill_sum.ToString();

            dgvOrderedDetails.Controls.Clear();
            dgvOrderedDetails.DataSource = tb; 
            dgvOrderedDetails.Columns[0].Visible = false;
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
            switch(MessageBox.Show("Bạn có muốn in hóa đơn không?", "THÔNG BÁO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    for (int i = 1; i < table.Rows.Count; i++)
                    {
                        _orderedDetails.Add(new OrderedDetail(i, _order.ID, table.Rows[i][0].ToString(),
                            float.Parse(table.Rows[i][3].ToString()), int.Parse(table.Rows[i][4].ToString())));
                    }

                    _order.StaffID = UCHomePage.Instance.staff_using.ID;
                    _order.Value = float.Parse(txtTotalPrice.Text);

                    if (BLL.Instance.createOrdered(_order))
                    {
                        foreach (OrderedDetail item in _orderedDetails)
                        {
                            if (!BLL.Instance.createOrderedDetail(item))
                            {
                                BLL.Instance.deleteOrdered(_order.ID);
                                MessageBox.Show("Có sản phẩm không đủ hàng!\nVui lòng kiểm tra lại!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        MessageBox.Show("Đã lưu thông tin hóa đơn!", "THÔNG BÁO");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xử lý hóa đơn", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    clearInformation();
                    break;
                default:
                    break;
            }
        }

        private void btnChooseProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnUseScanMachine_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng này đang được phát triển!");
        }

        private void btnCheckCustomer_Click(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProduct.CurrentCell.RowIndex == dgvProduct.RowCount - 1)
                return;

            if (dgvOrderedDetails.DataSource == null)
            {
                _order = settingInformation();
                _orderedDetails = new List<OrderedDetail>();
                createTableBillDetails();
            }

            string product_id = dgvProduct.CurrentRow.Cells[0].Value.ToString();
            string name = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            string unit = dgvProduct.CurrentRow.Cells[3].Value.ToString();
            float price = float.Parse(dgvProduct.CurrentRow.Cells[7].Value.ToString());

            int store_quantity = int.Parse(dgvProduct.CurrentRow.Cells[4].Value.ToString());

            if (table.Rows.Contains(product_id))
            {
                DataRow[] row = table.Select("ProductID = " + product_id);
                int new_quantity = int.Parse(table.Rows[table.Rows.IndexOf(row[0])][4].ToString()) + 1;

                if(new_quantity > store_quantity)
                {
                    MessageBox.Show("Không đủ số lượng trong kho!", "THÔNG BÁO", MessageBoxButtons.OK);
                    return;
                }

                table.Rows[table.Rows.IndexOf(row[0])][4] = new_quantity;
                table.Rows[table.Rows.IndexOf(row[0])][5] = new_quantity * price;
            }
            else if (store_quantity > 0)
            {
                table.Rows.Add(product_id, name, unit, price, 1, price * 1);
            }
            else
            {
                MessageBox.Show("Không đủ số lượng trong kho!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }
            
            changeBills(table);
        }

        private void dgvOrderDetails_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrderedDetails.CurrentCell.RowIndex == dgvOrderedDetails.RowCount - 1)
                return;

            DataRowView currentDataRowView = (DataRowView)dgvOrderedDetails.CurrentRow.DataBoundItem;
            DataRow row = currentDataRowView.Row;

            int quantity = int.Parse(row[4].ToString());
            if (quantity > 1)
            {
                int new_quantity = quantity - 1;
                float price = float.Parse(table.Rows[table.Rows.IndexOf(row)][3].ToString());
                table.Rows[table.Rows.IndexOf(row)][4] = new_quantity;
                table.Rows[table.Rows.IndexOf(row)][5] = new_quantity * price;
            }
            else
            {
                table.Rows.Remove(row);
            }

            changeBills(table);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DataTable table = null;
            DataTable table_filter;

            if (!chbName.Checked && !chbPrice.Checked && !chbSupplier.Checked && !chbTypeProduct.Checked)
                return;

            if (chbName.Checked)
            {
                table_filter = BLL.Instance.FindProductByName(txtNameFilter.Text.Trim());
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
    }
}
