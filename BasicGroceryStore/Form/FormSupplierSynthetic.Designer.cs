﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.lblTabShow = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.txtSupplierAddressFilter = new System.Windows.Forms.TextBox();
            this.txtSupplierNameFilter = new System.Windows.Forms.TextBox();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cbTypeProductFilter = new System.Windows.Forms.ComboBox();
            this.txtProductNameFilter = new System.Windows.Forms.TextBox();
            this.chbTypeProduct = new System.Windows.Forms.CheckBox();
            this.chbName = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pnlMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
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
            // lblTabShow
            // 
            this.lblTabShow.AutoSize = true;
            this.lblTabShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTabShow.Location = new System.Drawing.Point(12, 6);
            this.lblTabShow.Name = "lblTabShow";
            this.lblTabShow.Size = new System.Drawing.Size(235, 24);
            this.lblTabShow.TabIndex = 4;
            this.lblTabShow.Text = "Tổng hợp nhà cung cấp";
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
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // txtSupplierAddressFilter
            // 
            this.txtSupplierAddressFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierAddressFilter.Location = new System.Drawing.Point(215, 96);
            this.txtSupplierAddressFilter.Name = "txtSupplierAddressFilter";
            this.txtSupplierAddressFilter.Size = new System.Drawing.Size(476, 26);
            this.txtSupplierAddressFilter.TabIndex = 44;
            // 
            // txtSupplierNameFilter
            // 
            this.txtSupplierNameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierNameFilter.Location = new System.Drawing.Point(216, 55);
            this.txtSupplierNameFilter.Name = "txtSupplierNameFilter";
            this.txtSupplierNameFilter.Size = new System.Drawing.Size(476, 26);
            this.txtSupplierNameFilter.TabIndex = 42;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSupplier.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSupplier.EnableHeadersVisualStyles = false;
            this.dgvSupplier.Location = new System.Drawing.Point(11, 267);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.Size = new System.Drawing.Size(678, 193);
            this.dgvSupplier.TabIndex = 49;
            this.dgvSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSupplier_CellClick);
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
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
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
            // cbTypeProductFilter
            // 
            this.cbTypeProductFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeProductFilter.FormattingEnabled = true;
            this.cbTypeProductFilter.Location = new System.Drawing.Point(215, 178);
            this.cbTypeProductFilter.Name = "cbTypeProductFilter";
            this.cbTypeProductFilter.Size = new System.Drawing.Size(475, 28);
            this.cbTypeProductFilter.TabIndex = 56;
            // 
            // txtProductNameFilter
            // 
            this.txtProductNameFilter.Location = new System.Drawing.Point(216, 137);
            this.txtProductNameFilter.Name = "txtProductNameFilter";
            this.txtProductNameFilter.Size = new System.Drawing.Size(475, 26);
            this.txtProductNameFilter.TabIndex = 55;
            // 
            // chbTypeProduct
            // 
            this.chbTypeProduct.AutoSize = true;
            this.chbTypeProduct.Checked = true;
            this.chbTypeProduct.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTypeProduct.Location = new System.Drawing.Point(12, 180);
            this.chbTypeProduct.Name = "chbTypeProduct";
            this.chbTypeProduct.Size = new System.Drawing.Size(132, 24);
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
            this.chbName.Size = new System.Drawing.Size(129, 24);
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
            this.checkBox1.Size = new System.Drawing.Size(176, 24);
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
            this.checkBox2.Size = new System.Drawing.Size(155, 24);
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
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(317, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 36);
            this.btnClear.TabIndex = 60;
            this.btnClear.Text = "Làm trống";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(12, 508);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(245, 36);
            this.btnAddNew.TabIndex = 61;
            this.btnAddNew.Text = "Thêm nhà cung cấp";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // FormSupplierSynthetic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(700, 552);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.cbTypeProductFilter);
            this.Controls.Add(this.txtProductNameFilter);
            this.Controls.Add(this.chbTypeProduct);
            this.Controls.Add(this.chbName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.btnEditSupplier);
            this.Controls.Add(this.pnlMove);
            this.Controls.Add(this.txtSupplierAddressFilter);
            this.Controls.Add(this.txtSupplierNameFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormSupplierSynthetic";
            this.Text = "FormSupplierSynthetic";
            this.pnlMove.ResumeLayout(false);
            this.pnlMove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.TextBox txtSupplierAddressFilter;
        private System.Windows.Forms.TextBox txtSupplierNameFilter;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cbTypeProductFilter;
        private System.Windows.Forms.TextBox txtProductNameFilter;
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