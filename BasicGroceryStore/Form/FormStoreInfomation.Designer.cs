namespace BasicGroceryStore
{
    partial class FormStoreInfomation
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
            this.lblTabShow = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtYoutube = new System.Windows.Forms.TextBox();
            this.lblLink_ut = new System.Windows.Forms.Label();
            this.txtLinkedIn = new System.Windows.Forms.TextBox();
            this.lblLink_linkedin = new System.Windows.Forms.Label();
            this.txtInstagram = new System.Windows.Forms.TextBox();
            this.lblLink_ig = new System.Windows.Forms.Label();
            this.txtFacebook = new System.Windows.Forms.TextBox();
            this.lblLink_fb = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMap = new System.Windows.Forms.TextBox();
            this.lblLink_map = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlMove.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMove
            // 
            this.pnlMove.BackColor = System.Drawing.Color.OrangeRed;
            this.pnlMove.Controls.Add(this.lblTabShow);
            this.pnlMove.Controls.Add(this.btnMinimize);
            this.pnlMove.Location = new System.Drawing.Point(0, 0);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(600, 40);
            this.pnlMove.TabIndex = 6;
            this.pnlMove.Tag = "";
            this.pnlMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMove_MouseDown);
            this.pnlMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMove_MouseMove);
            this.pnlMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlMove_MouseUp);
            // 
            // lblTabShow
            // 
            this.lblTabShow.AutoSize = true;
            this.lblTabShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTabShow.Location = new System.Drawing.Point(12, 9);
            this.lblTabShow.Name = "lblTabShow";
            this.lblTabShow.Size = new System.Drawing.Size(192, 24);
            this.lblTabShow.TabIndex = 4;
            this.lblTabShow.Text = "Thông tin cửa hàng";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::BasicGroceryStore.Properties.Resources.subtract_26px;
            this.btnMinimize.Location = new System.Drawing.Point(525, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(63, 40);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlMain.Controls.Add(this.txtPhone);
            this.pnlMain.Controls.Add(this.txtYoutube);
            this.pnlMain.Controls.Add(this.lblLink_ut);
            this.pnlMain.Controls.Add(this.txtLinkedIn);
            this.pnlMain.Controls.Add(this.lblLink_linkedin);
            this.pnlMain.Controls.Add(this.txtInstagram);
            this.pnlMain.Controls.Add(this.lblLink_ig);
            this.pnlMain.Controls.Add(this.txtFacebook);
            this.pnlMain.Controls.Add(this.lblLink_fb);
            this.pnlMain.Controls.Add(this.txtAddress);
            this.pnlMain.Controls.Add(this.txtEmail);
            this.pnlMain.Controls.Add(this.txtMap);
            this.pnlMain.Controls.Add(this.lblLink_map);
            this.pnlMain.Controls.Add(this.lblPhone);
            this.pnlMain.Controls.Add(this.lblEmail);
            this.pnlMain.Controls.Add(this.lblAddress);
            this.pnlMain.Controls.Add(this.btnCancel);
            this.pnlMain.Controls.Add(this.btnSave);
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 40);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(600, 400);
            this.pnlMain.TabIndex = 7;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(189, 152);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(399, 26);
            this.txtPhone.TabIndex = 53;
            // 
            // txtYoutube
            // 
            this.txtYoutube.Location = new System.Drawing.Point(189, 312);
            this.txtYoutube.Name = "txtYoutube";
            this.txtYoutube.Size = new System.Drawing.Size(399, 26);
            this.txtYoutube.TabIndex = 52;
            // 
            // lblLink_ut
            // 
            this.lblLink_ut.AutoSize = true;
            this.lblLink_ut.Location = new System.Drawing.Point(18, 315);
            this.lblLink_ut.Name = "lblLink_ut";
            this.lblLink_ut.Size = new System.Drawing.Size(70, 20);
            this.lblLink_ut.TabIndex = 51;
            this.lblLink_ut.Text = "Youtube";
            // 
            // txtLinkedIn
            // 
            this.txtLinkedIn.Location = new System.Drawing.Point(189, 280);
            this.txtLinkedIn.Name = "txtLinkedIn";
            this.txtLinkedIn.Size = new System.Drawing.Size(399, 26);
            this.txtLinkedIn.TabIndex = 50;
            // 
            // lblLink_linkedin
            // 
            this.lblLink_linkedin.AutoSize = true;
            this.lblLink_linkedin.Location = new System.Drawing.Point(18, 283);
            this.lblLink_linkedin.Name = "lblLink_linkedin";
            this.lblLink_linkedin.Size = new System.Drawing.Size(70, 20);
            this.lblLink_linkedin.TabIndex = 49;
            this.lblLink_linkedin.Text = "LinkedIn";
            // 
            // txtInstagram
            // 
            this.txtInstagram.Location = new System.Drawing.Point(189, 248);
            this.txtInstagram.Name = "txtInstagram";
            this.txtInstagram.Size = new System.Drawing.Size(399, 26);
            this.txtInstagram.TabIndex = 48;
            // 
            // lblLink_ig
            // 
            this.lblLink_ig.AutoSize = true;
            this.lblLink_ig.Location = new System.Drawing.Point(18, 251);
            this.lblLink_ig.Name = "lblLink_ig";
            this.lblLink_ig.Size = new System.Drawing.Size(81, 20);
            this.lblLink_ig.TabIndex = 47;
            this.lblLink_ig.Text = "Instagram";
            // 
            // txtFacebook
            // 
            this.txtFacebook.Location = new System.Drawing.Point(189, 216);
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.Size = new System.Drawing.Size(399, 26);
            this.txtFacebook.TabIndex = 46;
            // 
            // lblLink_fb
            // 
            this.lblLink_fb.AutoSize = true;
            this.lblLink_fb.Location = new System.Drawing.Point(18, 219);
            this.lblLink_fb.Name = "lblLink_fb";
            this.lblLink_fb.Size = new System.Drawing.Size(80, 20);
            this.lblLink_fb.TabIndex = 45;
            this.lblLink_fb.Text = "Facebook";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(16, 32);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(572, 82);
            this.txtAddress.TabIndex = 43;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(189, 120);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(399, 26);
            this.txtEmail.TabIndex = 42;
            // 
            // txtMap
            // 
            this.txtMap.Location = new System.Drawing.Point(189, 184);
            this.txtMap.Name = "txtMap";
            this.txtMap.Size = new System.Drawing.Size(399, 26);
            this.txtMap.TabIndex = 41;
            // 
            // lblLink_map
            // 
            this.lblLink_map.AutoSize = true;
            this.lblLink_map.Location = new System.Drawing.Point(18, 187);
            this.lblLink_map.Name = "lblLink_map";
            this.lblLink_map.Size = new System.Drawing.Size(91, 20);
            this.lblLink_map.TabIndex = 40;
            this.lblLink_map.Text = "Link bản đồ";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(18, 155);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(102, 20);
            this.lblPhone.TabIndex = 39;
            this.lblPhone.Text = "Số điện thoại";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(18, 123);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 38;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(18, 9);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 20);
            this.lblAddress.TabIndex = 37;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(391, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(197, 31);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(189, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(196, 31);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Lưu thông tin";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormStoreInfomation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 440);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlMove);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormStoreInfomation";
            this.Text = "FormStoreInfomation";
            this.pnlMove.ResumeLayout(false);
            this.pnlMove.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Label lblTabShow;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMap;
        private System.Windows.Forms.Label lblLink_map;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtYoutube;
        private System.Windows.Forms.Label lblLink_ut;
        private System.Windows.Forms.TextBox txtLinkedIn;
        private System.Windows.Forms.Label lblLink_linkedin;
        private System.Windows.Forms.TextBox txtInstagram;
        private System.Windows.Forms.Label lblLink_ig;
        private System.Windows.Forms.TextBox txtFacebook;
        private System.Windows.Forms.Label lblLink_fb;
        private System.Windows.Forms.MaskedTextBox txtPhone;
    }
}