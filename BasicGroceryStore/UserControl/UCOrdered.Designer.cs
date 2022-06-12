
namespace BasicGroceryStore
{
    partial class UCOrdered
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gbMakeBill = new System.Windows.Forms.GroupBox();
            this.btnMakeBills = new System.Windows.Forms.Button();
            this.btnCancelBill = new System.Windows.Forms.Button();
            this.gbListProduct = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtPickDateCreate = new System.Windows.Forms.DateTimePicker();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtBillID = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnUseScanMachine = new System.Windows.Forms.Button();
            this.btnCheckCustomer = new System.Windows.Forms.Button();
            this.btnChooseProduct = new System.Windows.Forms.Button();
            this.btnCheckHistory = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numUDTo = new System.Windows.Forms.NumericUpDown();
            this.numUDFrom = new System.Windows.Forms.NumericUpDown();
            this.cbTypeProduct = new System.Windows.Forms.ComboBox();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chbTypeProduct = new System.Windows.Forms.CheckBox();
            this.chbSupplier = new System.Windows.Forms.CheckBox();
            this.chbPrice = new System.Windows.Forms.CheckBox();
            this.chbName = new System.Windows.Forms.CheckBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.pnlMain.SuspendLayout();
            this.gbMakeBill.SuspendLayout();
            this.gbListProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(105)))), ((int)(((byte)(122)))));
            this.pnlMain.Controls.Add(this.gbMakeBill);
            this.pnlMain.Controls.Add(this.gbFilter);
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1350, 860);
            this.pnlMain.TabIndex = 2;
            // 
            // gbMakeBill
            // 
            this.gbMakeBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(144)))), ((int)(((byte)(158)))));
            this.gbMakeBill.Controls.Add(this.btnMakeBills);
            this.gbMakeBill.Controls.Add(this.btnCancelBill);
            this.gbMakeBill.Controls.Add(this.gbListProduct);
            this.gbMakeBill.Controls.Add(this.dtPickDateCreate);
            this.gbMakeBill.Controls.Add(this.txtStaffName);
            this.gbMakeBill.Controls.Add(this.txtBillID);
            this.gbMakeBill.Controls.Add(this.txtTotalPrice);
            this.gbMakeBill.Controls.Add(this.txtCustomerName);
            this.gbMakeBill.Controls.Add(this.label5);
            this.gbMakeBill.Controls.Add(this.label6);
            this.gbMakeBill.Controls.Add(this.label4);
            this.gbMakeBill.Controls.Add(this.label3);
            this.gbMakeBill.Controls.Add(this.label2);
            this.gbMakeBill.Location = new System.Drawing.Point(706, 3);
            this.gbMakeBill.Name = "gbMakeBill";
            this.gbMakeBill.Size = new System.Drawing.Size(641, 854);
            this.gbMakeBill.TabIndex = 4;
            this.gbMakeBill.TabStop = false;
            this.gbMakeBill.Text = "Tạo hóa đơn bán hàng";
            // 
            // btnMakeBills
            // 
            this.btnMakeBills.Location = new System.Drawing.Point(452, 812);
            this.btnMakeBills.Name = "btnMakeBills";
            this.btnMakeBills.Size = new System.Drawing.Size(183, 36);
            this.btnMakeBills.TabIndex = 38;
            this.btnMakeBills.Text = "Tạo hóa đơn";
            this.btnMakeBills.UseVisualStyleBackColor = true;
            // 
            // btnCancelBill
            // 
            this.btnCancelBill.Location = new System.Drawing.Point(6, 812);
            this.btnCancelBill.Name = "btnCancelBill";
            this.btnCancelBill.Size = new System.Drawing.Size(183, 36);
            this.btnCancelBill.TabIndex = 32;
            this.btnCancelBill.Text = "Hủy hóa đơn";
            this.btnCancelBill.UseVisualStyleBackColor = true;
            // 
            // gbListProduct
            // 
            this.gbListProduct.Controls.Add(this.dataGridView1);
            this.gbListProduct.Location = new System.Drawing.Point(6, 281);
            this.gbListProduct.Name = "gbListProduct";
            this.gbListProduct.Size = new System.Drawing.Size(629, 525);
            this.gbListProduct.TabIndex = 37;
            this.gbListProduct.TabStop = false;
            this.gbListProduct.Text = "Danh sách sản phẩm và in hóa đơn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 489);
            this.dataGridView1.TabIndex = 32;
            // 
            // dtPickDateCreate
            // 
            this.dtPickDateCreate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPickDateCreate.Enabled = false;
            this.dtPickDateCreate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickDateCreate.Location = new System.Drawing.Point(189, 138);
            this.dtPickDateCreate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtPickDateCreate.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtPickDateCreate.Name = "dtPickDateCreate";
            this.dtPickDateCreate.Size = new System.Drawing.Size(351, 29);
            this.dtPickDateCreate.TabIndex = 36;
            this.dtPickDateCreate.Value = new System.DateTime(2022, 2, 4, 0, 0, 0, 0);
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(189, 43);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(446, 29);
            this.txtStaffName.TabIndex = 35;
            // 
            // txtBillID
            // 
            this.txtBillID.Location = new System.Drawing.Point(189, 90);
            this.txtBillID.Name = "txtBillID";
            this.txtBillID.ReadOnly = true;
            this.txtBillID.Size = new System.Drawing.Size(351, 29);
            this.txtBillID.TabIndex = 34;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(189, 187);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(351, 29);
            this.txtTotalPrice.TabIndex = 33;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(189, 231);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(446, 29);
            this.txtCustomerName.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày tạo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhân viên";
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(144)))), ((int)(((byte)(158)))));
            this.gbFilter.Controls.Add(this.dgvProduct);
            this.gbFilter.Controls.Add(this.btnReload);
            this.gbFilter.Controls.Add(this.btnUseScanMachine);
            this.gbFilter.Controls.Add(this.btnCheckCustomer);
            this.gbFilter.Controls.Add(this.btnChooseProduct);
            this.gbFilter.Controls.Add(this.btnCheckHistory);
            this.gbFilter.Controls.Add(this.btnFind);
            this.gbFilter.Controls.Add(this.btnClear);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.numUDTo);
            this.gbFilter.Controls.Add(this.numUDFrom);
            this.gbFilter.Controls.Add(this.cbTypeProduct);
            this.gbFilter.Controls.Add(this.txtSupplier);
            this.gbFilter.Controls.Add(this.txtName);
            this.gbFilter.Controls.Add(this.chbTypeProduct);
            this.gbFilter.Controls.Add(this.chbSupplier);
            this.gbFilter.Controls.Add(this.chbPrice);
            this.gbFilter.Controls.Add(this.chbName);
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(697, 854);
            this.gbFilter.TabIndex = 3;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Lọc thông tin";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(15, 239);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(183, 36);
            this.btnReload.TabIndex = 33;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnUseScanMachine
            // 
            this.btnUseScanMachine.Location = new System.Drawing.Point(15, 770);
            this.btnUseScanMachine.Name = "btnUseScanMachine";
            this.btnUseScanMachine.Size = new System.Drawing.Size(275, 36);
            this.btnUseScanMachine.TabIndex = 32;
            this.btnUseScanMachine.Text = "Dùng máy quét";
            this.btnUseScanMachine.UseVisualStyleBackColor = true;
            // 
            // btnCheckCustomer
            // 
            this.btnCheckCustomer.Location = new System.Drawing.Point(15, 812);
            this.btnCheckCustomer.Name = "btnCheckCustomer";
            this.btnCheckCustomer.Size = new System.Drawing.Size(275, 36);
            this.btnCheckCustomer.TabIndex = 30;
            this.btnCheckCustomer.Text = "Kiểm tra thông tin khách";
            this.btnCheckCustomer.UseVisualStyleBackColor = true;
            // 
            // btnChooseProduct
            // 
            this.btnChooseProduct.Location = new System.Drawing.Point(401, 770);
            this.btnChooseProduct.Name = "btnChooseProduct";
            this.btnChooseProduct.Size = new System.Drawing.Size(275, 36);
            this.btnChooseProduct.TabIndex = 29;
            this.btnChooseProduct.Text = "Chọn sản phẩm";
            this.btnChooseProduct.UseVisualStyleBackColor = true;
            // 
            // btnCheckHistory
            // 
            this.btnCheckHistory.Location = new System.Drawing.Point(401, 812);
            this.btnCheckHistory.Name = "btnCheckHistory";
            this.btnCheckHistory.Size = new System.Drawing.Size(275, 36);
            this.btnCheckHistory.TabIndex = 28;
            this.btnCheckHistory.Text = "Lịch sử bán hàng";
            this.btnCheckHistory.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(493, 239);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(183, 36);
            this.btnFind.TabIndex = 27;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(304, 239);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 36);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Làm trống";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "đến";
            // 
            // numUDTo
            // 
            this.numUDTo.Location = new System.Drawing.Point(403, 91);
            this.numUDTo.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numUDTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDTo.Name = "numUDTo";
            this.numUDTo.Size = new System.Drawing.Size(107, 29);
            this.numUDTo.TabIndex = 24;
            this.numUDTo.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numUDFrom
            // 
            this.numUDFrom.Location = new System.Drawing.Point(201, 91);
            this.numUDFrom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUDFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDFrom.Name = "numUDFrom";
            this.numUDFrom.Size = new System.Drawing.Size(107, 29);
            this.numUDFrom.TabIndex = 23;
            this.numUDFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbTypeProduct
            // 
            this.cbTypeProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeProduct.FormattingEnabled = true;
            this.cbTypeProduct.Location = new System.Drawing.Point(201, 187);
            this.cbTypeProduct.Name = "cbTypeProduct";
            this.cbTypeProduct.Size = new System.Drawing.Size(475, 32);
            this.cbTypeProduct.TabIndex = 22;
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(201, 139);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(475, 29);
            this.txtSupplier.TabIndex = 21;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(201, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(475, 29);
            this.txtName.TabIndex = 20;
            // 
            // chbTypeProduct
            // 
            this.chbTypeProduct.AutoSize = true;
            this.chbTypeProduct.Checked = true;
            this.chbTypeProduct.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTypeProduct.Location = new System.Drawing.Point(15, 189);
            this.chbTypeProduct.Name = "chbTypeProduct";
            this.chbTypeProduct.Size = new System.Drawing.Size(152, 28);
            this.chbTypeProduct.TabIndex = 19;
            this.chbTypeProduct.Text = "Loại sản phẩm";
            this.chbTypeProduct.UseVisualStyleBackColor = true;
            // 
            // chbSupplier
            // 
            this.chbSupplier.AutoSize = true;
            this.chbSupplier.Checked = true;
            this.chbSupplier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSupplier.Location = new System.Drawing.Point(15, 141);
            this.chbSupplier.Name = "chbSupplier";
            this.chbSupplier.Size = new System.Drawing.Size(139, 28);
            this.chbSupplier.TabIndex = 18;
            this.chbSupplier.Text = "Nhà sản xuất";
            this.chbSupplier.UseVisualStyleBackColor = true;
            // 
            // chbPrice
            // 
            this.chbPrice.AutoSize = true;
            this.chbPrice.Checked = true;
            this.chbPrice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbPrice.Location = new System.Drawing.Point(15, 93);
            this.chbPrice.Name = "chbPrice";
            this.chbPrice.Size = new System.Drawing.Size(122, 28);
            this.chbPrice.TabIndex = 17;
            this.chbPrice.Text = "Giá (nghìn)";
            this.chbPrice.UseVisualStyleBackColor = true;
            // 
            // chbName
            // 
            this.chbName.AutoSize = true;
            this.chbName.Checked = true;
            this.chbName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbName.Location = new System.Drawing.Point(15, 45);
            this.chbName.Name = "chbName";
            this.chbName.Size = new System.Drawing.Size(151, 28);
            this.chbName.TabIndex = 16;
            this.chbName.Text = "Tên sản phẩm";
            this.chbName.UseVisualStyleBackColor = true;
            // 
            // dgvProduct
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Location = new System.Drawing.Point(15, 281);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.Size = new System.Drawing.Size(661, 483);
            this.dgvProduct.TabIndex = 34;
            // 
            // UCOrdered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UCOrdered";
            this.Size = new System.Drawing.Size(1350, 860);
            this.pnlMain.ResumeLayout(false);
            this.gbMakeBill.ResumeLayout(false);
            this.gbMakeBill.PerformLayout();
            this.gbListProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnCheckCustomer;
        private System.Windows.Forms.Button btnChooseProduct;
        private System.Windows.Forms.Button btnCheckHistory;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUDTo;
        private System.Windows.Forms.NumericUpDown numUDFrom;
        private System.Windows.Forms.ComboBox cbTypeProduct;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chbTypeProduct;
        private System.Windows.Forms.CheckBox chbSupplier;
        private System.Windows.Forms.CheckBox chbPrice;
        private System.Windows.Forms.CheckBox chbName;
        private System.Windows.Forms.GroupBox gbMakeBill;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtBillID;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPickDateCreate;
        private System.Windows.Forms.Button btnMakeBills;
        private System.Windows.Forms.Button btnCancelBill;
        private System.Windows.Forms.GroupBox gbListProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUseScanMachine;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.DataGridView dgvProduct;
    }
}
