
namespace BasicGroceryStore
{
    partial class FormStaff
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
            this.btnClose = new System.Windows.Forms.Button();
            this.dtPickDoB = new System.Windows.Forms.DateTimePicker();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtCitizenID = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picRepresent = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtContractID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtPickStart = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtPickEnd = new System.Windows.Forms.DateTimePicker();
            this.cbTypeWork = new System.Windows.Forms.ComboBox();
            this.cbSpells = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.gbContract = new System.Windows.Forms.GroupBox();
            this.pnlMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRepresent)).BeginInit();
            this.gbContract.SuspendLayout();
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
            this.pnlMove.Size = new System.Drawing.Size(705, 40);
            this.pnlMove.TabIndex = 2;
            this.pnlMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMove_MouseDown);
            this.pnlMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMove_MouseMove);
            this.pnlMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlMove_MouseUp);
            // 
            // lblTabShow
            // 
            this.lblTabShow.AutoSize = true;
            this.lblTabShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTabShow.Location = new System.Drawing.Point(12, 7);
            this.lblTabShow.Name = "lblTabShow";
            this.lblTabShow.Size = new System.Drawing.Size(197, 24);
            this.lblTabShow.TabIndex = 4;
            this.lblTabShow.Text = "Thông tin nhân viên";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Image = global::BasicGroceryStore.Properties.Resources.subtract_26px;
            this.btnMinimize.Location = new System.Drawing.Point(580, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(58, 40);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Image = global::BasicGroceryStore.Properties.Resources.Close_26px;
            this.btnClose.Location = new System.Drawing.Point(644, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // dtPickDoB
            // 
            this.dtPickDoB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickDoB.Location = new System.Drawing.Point(349, 169);
            this.dtPickDoB.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtPickDoB.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtPickDoB.Name = "dtPickDoB";
            this.dtPickDoB.Size = new System.Drawing.Size(186, 29);
            this.dtPickDoB.TabIndex = 44;
            this.dtPickDoB.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(349, 126);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(187, 32);
            this.cbGender.TabIndex = 38;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(349, 289);
            this.txtPhone.Mask = "0000-000-000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(187, 29);
            this.txtPhone.TabIndex = 43;
            // 
            // txtCitizenID
            // 
            this.txtCitizenID.Location = new System.Drawing.Point(349, 209);
            this.txtCitizenID.Mask = "000000000000";
            this.txtCitizenID.Name = "txtCitizenID";
            this.txtCitizenID.Size = new System.Drawing.Size(187, 29);
            this.txtCitizenID.TabIndex = 42;
            this.txtCitizenID.ValidatingType = typeof(int);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(349, 329);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(338, 29);
            this.txtEmail.TabIndex = 41;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(349, 249);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(338, 29);
            this.txtAddress.TabIndex = 40;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(349, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(338, 29);
            this.txtName.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 24);
            this.label8.TabIndex = 37;
            this.label8.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 36;
            this.label5.Text = "Điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 35;
            this.label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 24);
            this.label7.TabIndex = 34;
            this.label7.Text = "CCCD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Giới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "Họ tên";
            // 
            // picRepresent
            // 
            this.picRepresent.BackColor = System.Drawing.Color.Linen;
            this.picRepresent.Location = new System.Drawing.Point(13, 55);
            this.picRepresent.Name = "picRepresent";
            this.picRepresent.Size = new System.Drawing.Size(168, 224);
            this.picRepresent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRepresent.TabIndex = 30;
            this.picRepresent.TabStop = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Location = new System.Drawing.Point(13, 290);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(168, 45);
            this.btnChooseImage.TabIndex = 45;
            this.btnChooseImage.Text = "Chọn ảnh";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(349, 47);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(338, 29);
            this.txtID.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mã nhân viên";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(504, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(168, 34);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(504, 140);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 34);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "Lưu thông tin";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 24);
            this.label9.TabIndex = 51;
            this.label9.Text = "Mã hợp đồng";
            // 
            // txtContractID
            // 
            this.txtContractID.Location = new System.Drawing.Point(173, 34);
            this.txtContractID.Name = "txtContractID";
            this.txtContractID.ReadOnly = true;
            this.txtContractID.Size = new System.Drawing.Size(499, 29);
            this.txtContractID.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 24);
            this.label10.TabIndex = 51;
            this.label10.Text = "Ngày bắt đầu";
            // 
            // dtPickStart
            // 
            this.dtPickStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickStart.Location = new System.Drawing.Point(173, 70);
            this.dtPickStart.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtPickStart.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtPickStart.Name = "dtPickStart";
            this.dtPickStart.Size = new System.Drawing.Size(258, 29);
            this.dtPickStart.TabIndex = 52;
            this.dtPickStart.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 24);
            this.label11.TabIndex = 53;
            this.label11.Text = "Ngày kết thúc";
            // 
            // dtPickEnd
            // 
            this.dtPickEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickEnd.Location = new System.Drawing.Point(173, 106);
            this.dtPickEnd.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtPickEnd.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtPickEnd.Name = "dtPickEnd";
            this.dtPickEnd.Size = new System.Drawing.Size(258, 29);
            this.dtPickEnd.TabIndex = 54;
            this.dtPickEnd.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // cbTypeWork
            // 
            this.cbTypeWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeWork.FormattingEnabled = true;
            this.cbTypeWork.Location = new System.Drawing.Point(173, 142);
            this.cbTypeWork.Name = "cbTypeWork";
            this.cbTypeWork.Size = new System.Drawing.Size(258, 32);
            this.cbTypeWork.TabIndex = 55;
            this.cbTypeWork.SelectedIndexChanged += new System.EventHandler(this.cbTypeWork_SelectedIndexChanged);
            // 
            // cbSpells
            // 
            this.cbSpells.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpells.FormattingEnabled = true;
            this.cbSpells.Location = new System.Drawing.Point(173, 181);
            this.cbSpells.Name = "cbSpells";
            this.cbSpells.Size = new System.Drawing.Size(258, 32);
            this.cbSpells.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 24);
            this.label12.TabIndex = 51;
            this.label12.Text = "Dạng công việc";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 24);
            this.label13.TabIndex = 57;
            this.label13.Text = "Buổi làm việc";
            // 
            // gbContract
            // 
            this.gbContract.BackColor = System.Drawing.Color.PaleGreen;
            this.gbContract.Controls.Add(this.btnCancel);
            this.gbContract.Controls.Add(this.btnSave);
            this.gbContract.Controls.Add(this.label13);
            this.gbContract.Controls.Add(this.label12);
            this.gbContract.Controls.Add(this.cbSpells);
            this.gbContract.Controls.Add(this.cbTypeWork);
            this.gbContract.Controls.Add(this.dtPickEnd);
            this.gbContract.Controls.Add(this.label11);
            this.gbContract.Controls.Add(this.dtPickStart);
            this.gbContract.Controls.Add(this.label10);
            this.gbContract.Controls.Add(this.txtContractID);
            this.gbContract.Controls.Add(this.label9);
            this.gbContract.Location = new System.Drawing.Point(15, 367);
            this.gbContract.Name = "gbContract";
            this.gbContract.Size = new System.Drawing.Size(678, 224);
            this.gbContract.TabIndex = 48;
            this.gbContract.TabStop = false;
            this.gbContract.Text = "Chi tiết hợp đồng hiện tại";
            // 
            // FormStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(705, 600);
            this.Controls.Add(this.gbContract);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChooseImage);
            this.Controls.Add(this.dtPickDoB);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCitizenID);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picRepresent);
            this.Controls.Add(this.pnlMove);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormStaff";
            this.Text = "FormStaff";
            this.pnlMove.ResumeLayout(false);
            this.pnlMove.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRepresent)).EndInit();
            this.gbContract.ResumeLayout(false);
            this.gbContract.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DateTimePicker dtPickDoB;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.MaskedTextBox txtCitizenID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picRepresent;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTabShow;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtContractID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtPickStart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtPickEnd;
        private System.Windows.Forms.ComboBox cbTypeWork;
        private System.Windows.Forms.ComboBox cbSpells;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbContract;
    }
}