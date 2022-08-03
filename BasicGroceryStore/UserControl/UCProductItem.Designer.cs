
namespace BasicGroceryStore
{
    partial class UCProductItem
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.txtProductValue = new System.Windows.Forms.TextBox();
            this.numUDQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlMain.Controls.Add(this.btnDelete);
            this.pnlMain.Controls.Add(this.pnlControl);
            this.pnlMain.Controls.Add(this.lblProductName);
            this.pnlMain.Controls.Add(this.lblProductPrice);
            this.pnlMain.Location = new System.Drawing.Point(3, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(547, 44);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.txtProductValue);
            this.pnlControl.Controls.Add(this.numUDQuantity);
            this.pnlControl.Location = new System.Drawing.Point(289, 12);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(216, 29);
            this.pnlControl.TabIndex = 2;
            // 
            // txtProductValue
            // 
            this.txtProductValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductValue.Location = new System.Drawing.Point(77, 3);
            this.txtProductValue.Name = "txtProductValue";
            this.txtProductValue.Size = new System.Drawing.Size(133, 22);
            this.txtProductValue.TabIndex = 1;
            // 
            // numUDQuantity
            // 
            this.numUDQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDQuantity.Location = new System.Drawing.Point(3, 3);
            this.numUDQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUDQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDQuantity.Name = "numUDQuantity";
            this.numUDQuantity.Size = new System.Drawing.Size(68, 22);
            this.numUDQuantity.TabIndex = 0;
            this.numUDQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDQuantity.ValueChanged += new System.EventHandler(this.numUDQuantity_ValueChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(3, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(45, 16);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Name";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(3, 30);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(52, 13);
            this.lblProductPrice.TabIndex = 0;
            this.lblProductPrice.Text = "Price vnd";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(511, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(33, 37);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // UCProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pnlMain);
            this.Name = "UCProductItem";
            this.Size = new System.Drawing.Size(554, 50);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.TextBox txtProductValue;
        private System.Windows.Forms.NumericUpDown numUDQuantity;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Button btnDelete;
    }
}
