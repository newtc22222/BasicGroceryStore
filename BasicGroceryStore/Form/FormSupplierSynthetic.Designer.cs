
namespace BasicGroceryStore
{
    partial class FormSupplierSynthetic
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMove = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.dgvProductOfSupplier = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbTypeProduct = new System.Windows.Forms.ComboBox();
            this.txtNameFilter = new System.Windows.Forms.TextBox();
            this.chbTypeProduct = new System.Windows.Forms.CheckBox();
            this.chbName = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.lblTabShow = new System.Windows.Forms.Label();
            this.pnlMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOfSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMove
            // 
            this.pnlMove.BackColor = System.Drawing.Color.OrangeRed;
            this.pnlMove.Controls.Add(this.lblTabShow);
            this.pnlMove.Controls.Add(this.btnMinimize);
            this.pnlMove.Controls.Add(this.btnClose);
            this.pnlMove.Location = new System.Drawing.Point(0, 0);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(700, 40);
            this.pnlMove.TabIndex = 6;
            this.pnlMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMove_MouseDown);
            this.pnlMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMove_MouseMove);
            this.pnlMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlMove_MouseUp);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::BasicGroceryStore.Properties.Resources.subtract_26px;
            this.btnMinimize.Location = new System.Drawing.Point(564, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(63, 40);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::BasicGroceryStore.Properties.Resources.Close_26px;
            this.btnClose.Location = new System.Drawing.Point(634, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(63, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Location = new System.Drawing.Point(11, 466);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(245, 36);
            this.btnEditSupplier.TabIndex = 39;
            this.btnEditSupplier.Text = "Điều chỉnh thông tin";
            this.btnEditSupplier.UseVisualStyleBackColor = true;
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierAddress.Location = new System.Drawing.Point(215, 96);
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Size = new System.Drawing.Size(476, 27);
            this.txtSupplierAddress.TabIndex = 44;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(216, 55);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(476, 27);
            this.txtSupplierName.TabIndex = 42;
            // 
            // dgvProductOfSupplier
            // 
            this.dgvProductOfSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductOfSupplier.Location = new System.Drawing.Point(11, 267);
            this.dgvProductOfSupplier.Name = "dgvProductOfSupplier";
            this.dgvProductOfSupplier.Size = new System.Drawing.Size(678, 193);
            this.dgvProductOfSupplier.TabIndex = 49;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(506, 466);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 36);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Xóa thông tin";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(506, 225);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(183, 36);
            this.btnFind.TabIndex = 50;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(506, 508);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(183, 36);
            this.btnExit.TabIndex = 52;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // cbTypeProduct
            // 
            this.cbTypeProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeProduct.FormattingEnabled = true;
            this.cbTypeProduct.Location = new System.Drawing.Point(215, 178);
            this.cbTypeProduct.Name = "cbTypeProduct";
            this.cbTypeProduct.Size = new System.Drawing.Size(475, 30);
            this.cbTypeProduct.TabIndex = 56;
            // 
            // txtNameFilter
            // 
            this.txtNameFilter.Location = new System.Drawing.Point(216, 137);
            this.txtNameFilter.Name = "txtNameFilter";
            this.txtNameFilter.Size = new System.Drawing.Size(475, 27);
            this.txtNameFilter.TabIndex = 55;
            // 
            // chbTypeProduct
            // 
            this.chbTypeProduct.AutoSize = true;
            this.chbTypeProduct.Checked = true;
            this.chbTypeProduct.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTypeProduct.Location = new System.Drawing.Point(12, 180);
            this.chbTypeProduct.Name = "chbTypeProduct";
            this.chbTypeProduct.Size = new System.Drawing.Size(145, 26);
            this.chbTypeProduct.TabIndex = 54;
            this.chbTypeProduct.Text = "Loại sản phẩm";
            this.chbTypeProduct.UseVisualStyleBackColor = true;
            // 
            // chbName
            // 
            this.chbName.AutoSize = true;
            this.chbName.Checked = true;
            this.chbName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbName.Location = new System.Drawing.Point(12, 139);
            this.chbName.Name = "chbName";
            this.chbName.Size = new System.Drawing.Size(142, 26);
            this.chbName.TabIndex = 53;
            this.chbName.Text = "Tên sản phẩm";
            this.chbName.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 98);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(197, 26);
            this.checkBox1.TabIndex = 58;
            this.checkBox1.Text = "Địa chỉ nhà cung cấp";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(12, 57);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(172, 26);
            this.checkBox2.TabIndex = 57;
            this.checkBox2.Text = "Tên nhà cung cấp";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(11, 225);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(183, 36);
            this.btnReload.TabIndex = 59;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(317, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 36);
            this.btnClear.TabIndex = 60;
            this.btnClear.Text = "Làm trống";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(12, 508);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(245, 36);
            this.btnAddNew.TabIndex = 61;
            this.btnAddNew.Text = "Thêm nhà cung cấp";
            this.btnAddNew.UseVisualStyleBackColor = true;
            // 
            // lblTabShow
            // 
            this.lblTabShow.AutoSize = true;
            this.lblTabShow.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTabShow.Location = new System.Drawing.Point(12, 6);
            this.lblTabShow.Name = "lblTabShow";
            this.lblTabShow.Size = new System.Drawing.Size(261, 26);
            this.lblTabShow.TabIndex = 4;
            this.lblTabShow.Text = "Tổng hợp nhà cung cấp";
            // 
            // FormSupplierSynthetic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(700, 552);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.cbTypeProduct);
            this.Controls.Add(this.txtNameFilter);
            this.Controls.Add(this.chbTypeProduct);
            this.Controls.Add(this.chbName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dgvProductOfSupplier);
            this.Controls.Add(this.btnEditSupplier);
            this.Controls.Add(this.pnlMove);
            this.Controls.Add(this.txtSupplierAddress);
            this.Controls.Add(this.txtSupplierName);
            this.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormSupplierSynthetic";
            this.Text = "FormSupplierSynthetic";
            this.pnlMove.ResumeLayout(false);
            this.pnlMove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOfSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.DataGridView dgvProductOfSupplier;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbTypeProduct;
        private System.Windows.Forms.TextBox txtNameFilter;
        private System.Windows.Forms.CheckBox chbTypeProduct;
        private System.Windows.Forms.CheckBox chbName;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblTabShow;
    }
}