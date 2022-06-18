
namespace BasicGroceryStore
{
    partial class UCProduct
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
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.btnLoadSupplier = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.gbSupplier = new System.Windows.Forms.GroupBox();
            this.btnSeeMoreSupplier = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.gbProductOfSupplier = new System.Windows.Forms.GroupBox();
            this.dgvProductOfSupplier = new System.Windows.Forms.DataGridView();
            this.txtSupplierPhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSupplierEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTypeProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picRepresent = new System.Windows.Forms.PictureBox();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numUDTo = new System.Windows.Forms.NumericUpDown();
            this.numUDFrom = new System.Windows.Forms.NumericUpDown();
            this.cbTypeProduct = new System.Windows.Forms.ComboBox();
            this.txtSupplierFilter = new System.Windows.Forms.TextBox();
            this.txtNameFilter = new System.Windows.Forms.TextBox();
            this.chbTypeProduct = new System.Windows.Forms.CheckBox();
            this.chbSupplier = new System.Windows.Forms.CheckBox();
            this.chbPrice = new System.Windows.Forms.CheckBox();
            this.chbName = new System.Windows.Forms.CheckBox();
            this.pnlMain.SuspendLayout();
            this.gbDetail.SuspendLayout();
            this.gbSupplier.SuspendLayout();
            this.gbProductOfSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOfSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepresent)).BeginInit();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pnlMain.Controls.Add(this.gbDetail);
            this.pnlMain.Controls.Add(this.gbFilter);
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1350, 860);
            this.pnlMain.TabIndex = 2;
            // 
            // gbDetail
            // 
            this.gbDetail.BackColor = System.Drawing.Color.SpringGreen;
            this.gbDetail.Controls.Add(this.btnLoadSupplier);
            this.gbDetail.Controls.Add(this.btnEditProduct);
            this.gbDetail.Controls.Add(this.gbSupplier);
            this.gbDetail.Controls.Add(this.label7);
            this.gbDetail.Controls.Add(this.txtNote);
            this.gbDetail.Controls.Add(this.txtPrice);
            this.gbDetail.Controls.Add(this.label6);
            this.gbDetail.Controls.Add(this.txtQuantity);
            this.gbDetail.Controls.Add(this.label5);
            this.gbDetail.Controls.Add(this.txtUnit);
            this.gbDetail.Controls.Add(this.label4);
            this.gbDetail.Controls.Add(this.txtTypeProduct);
            this.gbDetail.Controls.Add(this.label3);
            this.gbDetail.Controls.Add(this.txtName);
            this.gbDetail.Controls.Add(this.label2);
            this.gbDetail.Controls.Add(this.picRepresent);
            this.gbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetail.Location = new System.Drawing.Point(706, 3);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(641, 854);
            this.gbDetail.TabIndex = 3;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Thông tin sản phẩm và nhà cung cấp";
            // 
            // btnLoadSupplier
            // 
            this.btnLoadSupplier.Location = new System.Drawing.Point(336, 315);
            this.btnLoadSupplier.Name = "btnLoadSupplier";
            this.btnLoadSupplier.Size = new System.Drawing.Size(299, 36);
            this.btnLoadSupplier.TabIndex = 38;
            this.btnLoadSupplier.Text = "Tải thông tin nhà cung cấp";
            this.btnLoadSupplier.UseVisualStyleBackColor = true;
            this.btnLoadSupplier.Click += new System.EventHandler(this.btnLoadSupplier_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(6, 315);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(298, 36);
            this.btnEditProduct.TabIndex = 32;
            this.btnEditProduct.Text = "Chỉnh sửa thông tin sản phẩm";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // gbSupplier
            // 
            this.gbSupplier.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.gbSupplier.Controls.Add(this.btnSeeMoreSupplier);
            this.gbSupplier.Controls.Add(this.btnEditSupplier);
            this.gbSupplier.Controls.Add(this.gbProductOfSupplier);
            this.gbSupplier.Controls.Add(this.txtSupplierPhone);
            this.gbSupplier.Controls.Add(this.label12);
            this.gbSupplier.Controls.Add(this.txtSupplierEmail);
            this.gbSupplier.Controls.Add(this.label11);
            this.gbSupplier.Controls.Add(this.txtSupplierAddress);
            this.gbSupplier.Controls.Add(this.label10);
            this.gbSupplier.Controls.Add(this.txtSupplierName);
            this.gbSupplier.Controls.Add(this.label9);
            this.gbSupplier.Controls.Add(this.txtSupplierID);
            this.gbSupplier.Controls.Add(this.label8);
            this.gbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSupplier.Location = new System.Drawing.Point(6, 357);
            this.gbSupplier.Name = "gbSupplier";
            this.gbSupplier.Size = new System.Drawing.Size(629, 491);
            this.gbSupplier.TabIndex = 37;
            this.gbSupplier.TabStop = false;
            this.gbSupplier.Text = "Thông tin về nhà cung cấp";
            // 
            // btnSeeMoreSupplier
            // 
            this.btnSeeMoreSupplier.Location = new System.Drawing.Point(324, 449);
            this.btnSeeMoreSupplier.Name = "btnSeeMoreSupplier";
            this.btnSeeMoreSupplier.Size = new System.Drawing.Size(299, 36);
            this.btnSeeMoreSupplier.TabIndex = 50;
            this.btnSeeMoreSupplier.Text = "Xem thêm nhà cung cấp khác";
            this.btnSeeMoreSupplier.UseVisualStyleBackColor = true;
            this.btnSeeMoreSupplier.Click += new System.EventHandler(this.btnSeeMoreSupplier_Click);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Location = new System.Drawing.Point(7, 449);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(299, 36);
            this.btnEditSupplier.TabIndex = 39;
            this.btnEditSupplier.Text = "Điều chỉnh thông tin";
            this.btnEditSupplier.UseVisualStyleBackColor = true;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // gbProductOfSupplier
            // 
            this.gbProductOfSupplier.Controls.Add(this.dgvProductOfSupplier);
            this.gbProductOfSupplier.Location = new System.Drawing.Point(7, 223);
            this.gbProductOfSupplier.Name = "gbProductOfSupplier";
            this.gbProductOfSupplier.Size = new System.Drawing.Size(616, 220);
            this.gbProductOfSupplier.TabIndex = 49;
            this.gbProductOfSupplier.TabStop = false;
            this.gbProductOfSupplier.Text = "Các sản phẩm đang cung cấp";
            // 
            // dgvProductOfSupplier
            // 
            this.dgvProductOfSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductOfSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductOfSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductOfSupplier.EnableHeadersVisualStyles = false;
            this.dgvProductOfSupplier.Location = new System.Drawing.Point(6, 26);
            this.dgvProductOfSupplier.Name = "dgvProductOfSupplier";
            this.dgvProductOfSupplier.ReadOnly = true;
            this.dgvProductOfSupplier.Size = new System.Drawing.Size(604, 188);
            this.dgvProductOfSupplier.TabIndex = 0;
            this.dgvProductOfSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductOfSupplier_CellClick);
            // 
            // txtSupplierPhone
            // 
            this.txtSupplierPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierPhone.Location = new System.Drawing.Point(135, 175);
            this.txtSupplierPhone.Name = "txtSupplierPhone";
            this.txtSupplierPhone.ReadOnly = true;
            this.txtSupplierPhone.Size = new System.Drawing.Size(290, 26);
            this.txtSupplierPhone.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 16);
            this.label12.TabIndex = 47;
            this.label12.Text = "Số điện thoại";
            // 
            // txtSupplierEmail
            // 
            this.txtSupplierEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierEmail.Location = new System.Drawing.Point(136, 140);
            this.txtSupplierEmail.Name = "txtSupplierEmail";
            this.txtSupplierEmail.ReadOnly = true;
            this.txtSupplierEmail.Size = new System.Drawing.Size(481, 26);
            this.txtSupplierEmail.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 16);
            this.label11.TabIndex = 45;
            this.label11.Text = "Email";
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierAddress.Location = new System.Drawing.Point(135, 105);
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.ReadOnly = true;
            this.txtSupplierAddress.Size = new System.Drawing.Size(481, 26);
            this.txtSupplierAddress.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "Địa chỉ kho";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(136, 70);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.ReadOnly = true;
            this.txtSupplierName.Size = new System.Drawing.Size(481, 26);
            this.txtSupplierName.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Tên đại diện";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierID.Location = new System.Drawing.Point(136, 35);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.ReadOnly = true;
            this.txtSupplierID.Size = new System.Drawing.Size(290, 26);
            this.txtSupplierID.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Mã định danh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(563, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ghi chú";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(6, 239);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ReadOnly = true;
            this.txtNote.Size = new System.Drawing.Size(629, 70);
            this.txtNote.TabIndex = 35;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(326, 202);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(311, 22);
            this.txtPrice.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Giá niêm yết";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(326, 164);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.Size = new System.Drawing.Size(311, 22);
            this.txtQuantity.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Số lượng kho";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(326, 127);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.ReadOnly = true;
            this.txtUnit.Size = new System.Drawing.Size(311, 22);
            this.txtUnit.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Đơn vị";
            // 
            // txtTypeProduct
            // 
            this.txtTypeProduct.Location = new System.Drawing.Point(326, 90);
            this.txtTypeProduct.Name = "txtTypeProduct";
            this.txtTypeProduct.ReadOnly = true;
            this.txtTypeProduct.Size = new System.Drawing.Size(311, 22);
            this.txtTypeProduct.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Loại sản phẩm";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(325, 33);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(311, 51);
            this.txtName.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên sản phẩm";
            // 
            // picRepresent
            // 
            this.picRepresent.BackColor = System.Drawing.Color.Linen;
            this.picRepresent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRepresent.Location = new System.Drawing.Point(6, 43);
            this.picRepresent.Name = "picRepresent";
            this.picRepresent.Size = new System.Drawing.Size(180, 180);
            this.picRepresent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRepresent.TabIndex = 1;
            this.picRepresent.TabStop = false;
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.SpringGreen;
            this.gbFilter.Controls.Add(this.dgvProduct);
            this.gbFilter.Controls.Add(this.btnAddNew);
            this.gbFilter.Controls.Add(this.btnReload);
            this.gbFilter.Controls.Add(this.btnDelete);
            this.gbFilter.Controls.Add(this.btnFind);
            this.gbFilter.Controls.Add(this.btnClear);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.numUDTo);
            this.gbFilter.Controls.Add(this.numUDFrom);
            this.gbFilter.Controls.Add(this.cbTypeProduct);
            this.gbFilter.Controls.Add(this.txtSupplierFilter);
            this.gbFilter.Controls.Add(this.txtNameFilter);
            this.gbFilter.Controls.Add(this.chbTypeProduct);
            this.gbFilter.Controls.Add(this.chbSupplier);
            this.gbFilter.Controls.Add(this.chbPrice);
            this.gbFilter.Controls.Add(this.chbName);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(697, 854);
            this.gbFilter.TabIndex = 2;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Lọc thông tin";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Location = new System.Drawing.Point(15, 281);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.Size = new System.Drawing.Size(661, 525);
            this.dgvProduct.TabIndex = 31;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(15, 812);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(183, 36);
            this.btnAddNew.TabIndex = 30;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(15, 239);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(183, 36);
            this.btnReload.TabIndex = 29;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(493, 812);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 36);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Xóa thông tin";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(493, 239);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(183, 36);
            this.btnFind.TabIndex = 27;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(304, 239);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 36);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Làm trống";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
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
            this.numUDTo.Size = new System.Drawing.Size(107, 22);
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
            this.numUDFrom.Size = new System.Drawing.Size(107, 22);
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
            this.cbTypeProduct.Size = new System.Drawing.Size(475, 24);
            this.cbTypeProduct.TabIndex = 22;
            // 
            // txtSupplierFilter
            // 
            this.txtSupplierFilter.Location = new System.Drawing.Point(201, 139);
            this.txtSupplierFilter.Name = "txtSupplierFilter";
            this.txtSupplierFilter.Size = new System.Drawing.Size(475, 22);
            this.txtSupplierFilter.TabIndex = 21;
            // 
            // txtNameFilter
            // 
            this.txtNameFilter.Location = new System.Drawing.Point(201, 43);
            this.txtNameFilter.Name = "txtNameFilter";
            this.txtNameFilter.Size = new System.Drawing.Size(475, 22);
            this.txtNameFilter.TabIndex = 20;
            // 
            // chbTypeProduct
            // 
            this.chbTypeProduct.AutoSize = true;
            this.chbTypeProduct.Checked = true;
            this.chbTypeProduct.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTypeProduct.Location = new System.Drawing.Point(15, 189);
            this.chbTypeProduct.Name = "chbTypeProduct";
            this.chbTypeProduct.Size = new System.Drawing.Size(114, 20);
            this.chbTypeProduct.TabIndex = 19;
            this.chbTypeProduct.Text = "Loại sản phẩm";
            this.chbTypeProduct.UseVisualStyleBackColor = true;
            this.chbTypeProduct.CheckedChanged += new System.EventHandler(this.chbTypeProduct_CheckedChanged);
            // 
            // chbSupplier
            // 
            this.chbSupplier.AutoSize = true;
            this.chbSupplier.Checked = true;
            this.chbSupplier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSupplier.Location = new System.Drawing.Point(15, 141);
            this.chbSupplier.Name = "chbSupplier";
            this.chbSupplier.Size = new System.Drawing.Size(103, 20);
            this.chbSupplier.TabIndex = 18;
            this.chbSupplier.Text = "Nhà sản xuất";
            this.chbSupplier.UseVisualStyleBackColor = true;
            this.chbSupplier.CheckedChanged += new System.EventHandler(this.chbSupplier_CheckedChanged);
            // 
            // chbPrice
            // 
            this.chbPrice.AutoSize = true;
            this.chbPrice.Checked = true;
            this.chbPrice.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbPrice.Location = new System.Drawing.Point(15, 93);
            this.chbPrice.Name = "chbPrice";
            this.chbPrice.Size = new System.Drawing.Size(90, 20);
            this.chbPrice.TabIndex = 17;
            this.chbPrice.Text = "Giá (nghìn)";
            this.chbPrice.UseVisualStyleBackColor = true;
            this.chbPrice.CheckedChanged += new System.EventHandler(this.chbPrice_CheckedChanged);
            // 
            // chbName
            // 
            this.chbName.AutoSize = true;
            this.chbName.Checked = true;
            this.chbName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbName.Location = new System.Drawing.Point(15, 45);
            this.chbName.Name = "chbName";
            this.chbName.Size = new System.Drawing.Size(112, 20);
            this.chbName.TabIndex = 16;
            this.chbName.Text = "Tên sản phẩm";
            this.chbName.UseVisualStyleBackColor = true;
            this.chbName.CheckedChanged += new System.EventHandler(this.chbName_CheckedChanged);
            // 
            // UCProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UCProduct";
            this.Size = new System.Drawing.Size(1350, 860);
            this.pnlMain.ResumeLayout(false);
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.gbSupplier.ResumeLayout(false);
            this.gbSupplier.PerformLayout();
            this.gbProductOfSupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOfSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepresent)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUDTo;
        private System.Windows.Forms.NumericUpDown numUDFrom;
        private System.Windows.Forms.ComboBox cbTypeProduct;
        private System.Windows.Forms.TextBox txtSupplierFilter;
        private System.Windows.Forms.TextBox txtNameFilter;
        private System.Windows.Forms.CheckBox chbTypeProduct;
        private System.Windows.Forms.CheckBox chbSupplier;
        private System.Windows.Forms.CheckBox chbPrice;
        private System.Windows.Forms.CheckBox chbName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox picRepresent;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTypeProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoadSupplier;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.GroupBox gbSupplier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnSeeMoreSupplier;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.GroupBox gbProductOfSupplier;
        private System.Windows.Forms.TextBox txtSupplierPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSupplierEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvProductOfSupplier;
    }
}
