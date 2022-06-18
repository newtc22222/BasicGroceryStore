
namespace BasicGroceryStore
{
    partial class UCStaff
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
            this.components = new System.ComponentModel.Container();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbDateContract = new System.Windows.Forms.ComboBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.btnLoadStaffInfor = new System.Windows.Forms.Button();
            this.btnEditStaffInfor = new System.Windows.Forms.Button();
            this.btnMakeContract = new System.Windows.Forms.Button();
            this.gbContractsAndAccount = new System.Windows.Forms.GroupBox();
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.dtPickDoB = new System.Windows.Forms.DateTimePicker();
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numUDTo = new System.Windows.Forms.NumericUpDown();
            this.numUDFrom = new System.Windows.Forms.NumericUpDown();
            this.cbSpells = new System.Windows.Forms.ComboBox();
            this.cbTypeWork = new System.Windows.Forms.ComboBox();
            this.cbGenderFilter = new System.Windows.Forms.ComboBox();
            this.txtAddressFilter = new System.Windows.Forms.TextBox();
            this.txtNameFilter = new System.Windows.Forms.TextBox();
            this.chbSpells = new System.Windows.Forms.CheckBox();
            this.chbTypeWork = new System.Windows.Forms.CheckBox();
            this.chbDateContract = new System.Windows.Forms.CheckBox();
            this.chbGender = new System.Windows.Forms.CheckBox();
            this.chbAddress = new System.Windows.Forms.CheckBox();
            this.chbAge = new System.Windows.Forms.CheckBox();
            this.chbName = new System.Windows.Forms.CheckBox();
            this.pnlMain.SuspendLayout();
            this.gbDetail.SuspendLayout();
            this.gbContractsAndAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepresent)).BeginInit();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDateContract
            // 
            this.cbDateContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDateContract.FormattingEnabled = true;
            this.cbDateContract.Location = new System.Drawing.Point(205, 176);
            this.cbDateContract.Name = "cbDateContract";
            this.cbDateContract.Size = new System.Drawing.Size(306, 24);
            this.cbDateContract.TabIndex = 16;
            this.toolTip.SetToolTip(this.cbDateContract, "Unexpired: Còn hạn\r\nExpiration soon: Sắp hết hạn\r\nExpired: Hết hạn\r\n");
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Peru;
            this.pnlMain.Controls.Add(this.gbDetail);
            this.pnlMain.Controls.Add(this.gbFilter);
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1350, 860);
            this.pnlMain.TabIndex = 1;
            // 
            // gbDetail
            // 
            this.gbDetail.BackColor = System.Drawing.Color.LightSalmon;
            this.gbDetail.Controls.Add(this.txtGender);
            this.gbDetail.Controls.Add(this.btnLoadStaffInfor);
            this.gbDetail.Controls.Add(this.btnEditStaffInfor);
            this.gbDetail.Controls.Add(this.btnMakeContract);
            this.gbDetail.Controls.Add(this.gbContractsAndAccount);
            this.gbDetail.Controls.Add(this.dtPickDoB);
            this.gbDetail.Controls.Add(this.txtPhone);
            this.gbDetail.Controls.Add(this.txtCitizenID);
            this.gbDetail.Controls.Add(this.txtEmail);
            this.gbDetail.Controls.Add(this.txtAddress);
            this.gbDetail.Controls.Add(this.txtName);
            this.gbDetail.Controls.Add(this.label8);
            this.gbDetail.Controls.Add(this.label5);
            this.gbDetail.Controls.Add(this.label6);
            this.gbDetail.Controls.Add(this.label7);
            this.gbDetail.Controls.Add(this.label4);
            this.gbDetail.Controls.Add(this.label3);
            this.gbDetail.Controls.Add(this.label2);
            this.gbDetail.Controls.Add(this.picRepresent);
            this.gbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetail.Location = new System.Drawing.Point(706, 3);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(641, 854);
            this.gbDetail.TabIndex = 1;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Thông tin nhân viên và hợp đồng";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(297, 79);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(187, 22);
            this.txtGender.TabIndex = 33;
            // 
            // btnLoadStaffInfor
            // 
            this.btnLoadStaffInfor.Location = new System.Drawing.Point(297, 812);
            this.btnLoadStaffInfor.Name = "btnLoadStaffInfor";
            this.btnLoadStaffInfor.Size = new System.Drawing.Size(162, 36);
            this.btnLoadStaffInfor.TabIndex = 32;
            this.btnLoadStaffInfor.Text = "Tải thông tin";
            this.btnLoadStaffInfor.UseVisualStyleBackColor = true;
            this.btnLoadStaffInfor.Click += new System.EventHandler(this.btnLoadStaffInfor_Click);
            // 
            // btnEditStaffInfor
            // 
            this.btnEditStaffInfor.Location = new System.Drawing.Point(16, 812);
            this.btnEditStaffInfor.Name = "btnEditStaffInfor";
            this.btnEditStaffInfor.Size = new System.Drawing.Size(231, 36);
            this.btnEditStaffInfor.TabIndex = 31;
            this.btnEditStaffInfor.Text = "Sửa thông tin nhân viên";
            this.btnEditStaffInfor.UseVisualStyleBackColor = true;
            this.btnEditStaffInfor.Click += new System.EventHandler(this.btnEditStaffInfor_Click);
            // 
            // btnMakeContract
            // 
            this.btnMakeContract.Location = new System.Drawing.Point(465, 812);
            this.btnMakeContract.Name = "btnMakeContract";
            this.btnMakeContract.Size = new System.Drawing.Size(170, 36);
            this.btnMakeContract.TabIndex = 24;
            this.btnMakeContract.Text = "Tạo hợp đồng";
            this.btnMakeContract.UseVisualStyleBackColor = true;
            this.btnMakeContract.Click += new System.EventHandler(this.btnMakeContract_Click);
            // 
            // gbContractsAndAccount
            // 
            this.gbContractsAndAccount.BackColor = System.Drawing.Color.Salmon;
            this.gbContractsAndAccount.Controls.Add(this.dgvContracts);
            this.gbContractsAndAccount.Controls.Add(this.label11);
            this.gbContractsAndAccount.Controls.Add(this.btnShowPassword);
            this.gbContractsAndAccount.Controls.Add(this.btnChangePassword);
            this.gbContractsAndAccount.Controls.Add(this.label10);
            this.gbContractsAndAccount.Controls.Add(this.label9);
            this.gbContractsAndAccount.Controls.Add(this.txtPassword);
            this.gbContractsAndAccount.Controls.Add(this.txtUsername);
            this.gbContractsAndAccount.Location = new System.Drawing.Point(6, 332);
            this.gbContractsAndAccount.Name = "gbContractsAndAccount";
            this.gbContractsAndAccount.Size = new System.Drawing.Size(629, 474);
            this.gbContractsAndAccount.TabIndex = 30;
            this.gbContractsAndAccount.TabStop = false;
            this.gbContractsAndAccount.Text = "Thông tin hợp đồng và tài khoản";
            // 
            // dgvContracts
            // 
            this.dgvContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Location = new System.Drawing.Point(11, 207);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.Size = new System.Drawing.Size(612, 261);
            this.dgvContracts.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(281, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Danh sách hợp đồng với cửa hàng";
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Location = new System.Drawing.Point(289, 125);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(164, 33);
            this.btnShowPassword.TabIndex = 35;
            this.btnShowPassword.Text = "Hiện mật khẩu";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(459, 125);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(164, 33);
            this.btnChangePassword.TabIndex = 32;
            this.btnChangePassword.Text = "Đổi mật khẩu";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Mật khẩu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Tài khoản";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(179, 86);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(444, 22);
            this.txtPassword.TabIndex = 33;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(179, 42);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(444, 22);
            this.txtUsername.TabIndex = 32;
            // 
            // dtPickDoB
            // 
            this.dtPickDoB.Enabled = false;
            this.dtPickDoB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickDoB.Location = new System.Drawing.Point(297, 119);
            this.dtPickDoB.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtPickDoB.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtPickDoB.Name = "dtPickDoB";
            this.dtPickDoB.Size = new System.Drawing.Size(186, 22);
            this.dtPickDoB.TabIndex = 29;
            this.dtPickDoB.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(297, 243);
            this.txtPhone.Mask = "0000-000-000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(187, 22);
            this.txtPhone.TabIndex = 28;
            // 
            // txtCitizenID
            // 
            this.txtCitizenID.Location = new System.Drawing.Point(297, 161);
            this.txtCitizenID.Mask = "000000000000";
            this.txtCitizenID.Name = "txtCitizenID";
            this.txtCitizenID.ReadOnly = true;
            this.txtCitizenID.Size = new System.Drawing.Size(187, 22);
            this.txtCitizenID.TabIndex = 27;
            this.txtCitizenID.ValidatingType = typeof(int);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(297, 284);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(338, 22);
            this.txtEmail.TabIndex = 26;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(297, 202);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(338, 22);
            this.txtAddress.TabIndex = 25;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(297, 37);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(338, 22);
            this.txtName.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "CCCD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // picRepresent
            // 
            this.picRepresent.BackColor = System.Drawing.Color.Linen;
            this.picRepresent.Location = new System.Drawing.Point(6, 41);
            this.picRepresent.Name = "picRepresent";
            this.picRepresent.Size = new System.Drawing.Size(168, 224);
            this.picRepresent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRepresent.TabIndex = 0;
            this.picRepresent.TabStop = false;
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.LightSalmon;
            this.gbFilter.Controls.Add(this.dgvStaff);
            this.gbFilter.Controls.Add(this.btnAddNew);
            this.gbFilter.Controls.Add(this.btnReload);
            this.gbFilter.Controls.Add(this.btnDelete);
            this.gbFilter.Controls.Add(this.btnFind);
            this.gbFilter.Controls.Add(this.btnClear);
            this.gbFilter.Controls.Add(this.cbDateContract);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.numUDTo);
            this.gbFilter.Controls.Add(this.numUDFrom);
            this.gbFilter.Controls.Add(this.cbSpells);
            this.gbFilter.Controls.Add(this.cbTypeWork);
            this.gbFilter.Controls.Add(this.cbGenderFilter);
            this.gbFilter.Controls.Add(this.txtAddressFilter);
            this.gbFilter.Controls.Add(this.txtNameFilter);
            this.gbFilter.Controls.Add(this.chbSpells);
            this.gbFilter.Controls.Add(this.chbTypeWork);
            this.gbFilter.Controls.Add(this.chbDateContract);
            this.gbFilter.Controls.Add(this.chbGender);
            this.gbFilter.Controls.Add(this.chbAddress);
            this.gbFilter.Controls.Add(this.chbAge);
            this.gbFilter.Controls.Add(this.chbName);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(3, 3);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(697, 854);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Lọc thông tin";
            // 
            // dgvStaff
            // 
            this.dgvStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(19, 345);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Size = new System.Drawing.Size(661, 461);
            this.dgvStaff.TabIndex = 23;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(19, 812);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(183, 36);
            this.btnAddNew.TabIndex = 21;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(19, 303);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(183, 37);
            this.btnReload.TabIndex = 20;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(497, 812);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 36);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Xóa thông tin";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(497, 303);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(183, 36);
            this.btnFind.TabIndex = 18;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(308, 303);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 36);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Làm trống";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "đến";
            // 
            // numUDTo
            // 
            this.numUDTo.Location = new System.Drawing.Point(404, 71);
            this.numUDTo.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numUDTo.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numUDTo.Name = "numUDTo";
            this.numUDTo.Size = new System.Drawing.Size(107, 22);
            this.numUDTo.TabIndex = 14;
            this.numUDTo.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numUDFrom
            // 
            this.numUDFrom.Location = new System.Drawing.Point(205, 71);
            this.numUDFrom.Maximum = new decimal(new int[] {
            35,
            0,
            0,
            0});
            this.numUDFrom.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numUDFrom.Name = "numUDFrom";
            this.numUDFrom.Size = new System.Drawing.Size(107, 22);
            this.numUDFrom.TabIndex = 13;
            this.numUDFrom.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // cbSpells
            // 
            this.cbSpells.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpells.FormattingEnabled = true;
            this.cbSpells.Location = new System.Drawing.Point(205, 250);
            this.cbSpells.Name = "cbSpells";
            this.cbSpells.Size = new System.Drawing.Size(306, 24);
            this.cbSpells.TabIndex = 12;
            // 
            // cbTypeWork
            // 
            this.cbTypeWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeWork.FormattingEnabled = true;
            this.cbTypeWork.Location = new System.Drawing.Point(205, 213);
            this.cbTypeWork.Name = "cbTypeWork";
            this.cbTypeWork.Size = new System.Drawing.Size(306, 24);
            this.cbTypeWork.TabIndex = 11;
            this.cbTypeWork.SelectedIndexChanged += new System.EventHandler(this.cbTypeWork_SelectedIndexChanged);
            // 
            // cbGenderFilter
            // 
            this.cbGenderFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenderFilter.FormattingEnabled = true;
            this.cbGenderFilter.Items.AddRange(new object[] {
            "nam",
            "nữ",
            "khác"});
            this.cbGenderFilter.Location = new System.Drawing.Point(205, 139);
            this.cbGenderFilter.Name = "cbGenderFilter";
            this.cbGenderFilter.Size = new System.Drawing.Size(176, 24);
            this.cbGenderFilter.TabIndex = 10;
            // 
            // txtAddressFilter
            // 
            this.txtAddressFilter.Location = new System.Drawing.Point(205, 105);
            this.txtAddressFilter.Name = "txtAddressFilter";
            this.txtAddressFilter.Size = new System.Drawing.Size(475, 22);
            this.txtAddressFilter.TabIndex = 9;
            // 
            // txtNameFilter
            // 
            this.txtNameFilter.Location = new System.Drawing.Point(205, 37);
            this.txtNameFilter.Name = "txtNameFilter";
            this.txtNameFilter.Size = new System.Drawing.Size(475, 22);
            this.txtNameFilter.TabIndex = 8;
            // 
            // chbSpells
            // 
            this.chbSpells.AutoSize = true;
            this.chbSpells.Checked = true;
            this.chbSpells.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSpells.Location = new System.Drawing.Point(19, 255);
            this.chbSpells.Name = "chbSpells";
            this.chbSpells.Size = new System.Drawing.Size(106, 20);
            this.chbSpells.TabIndex = 7;
            this.chbSpells.Text = "Buổi làm việc";
            this.chbSpells.UseVisualStyleBackColor = true;
            this.chbSpells.CheckedChanged += new System.EventHandler(this.chbSpells_CheckedChanged);
            // 
            // chbTypeWork
            // 
            this.chbTypeWork.AutoSize = true;
            this.chbTypeWork.Checked = true;
            this.chbTypeWork.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTypeWork.Location = new System.Drawing.Point(19, 219);
            this.chbTypeWork.Name = "chbTypeWork";
            this.chbTypeWork.Size = new System.Drawing.Size(120, 20);
            this.chbTypeWork.TabIndex = 5;
            this.chbTypeWork.Text = "Dạng công việc";
            this.chbTypeWork.UseVisualStyleBackColor = true;
            this.chbTypeWork.CheckedChanged += new System.EventHandler(this.chbTypeWork_CheckedChanged);
            // 
            // chbDateContract
            // 
            this.chbDateContract.AutoSize = true;
            this.chbDateContract.Checked = true;
            this.chbDateContract.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDateContract.Location = new System.Drawing.Point(19, 183);
            this.chbDateContract.Name = "chbDateContract";
            this.chbDateContract.Size = new System.Drawing.Size(111, 20);
            this.chbDateContract.TabIndex = 4;
            this.chbDateContract.Text = "Hạn hợp đồng";
            this.chbDateContract.UseVisualStyleBackColor = true;
            this.chbDateContract.CheckedChanged += new System.EventHandler(this.chbDateContract_CheckedChanged);
            // 
            // chbGender
            // 
            this.chbGender.AutoSize = true;
            this.chbGender.Checked = true;
            this.chbGender.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbGender.Location = new System.Drawing.Point(19, 147);
            this.chbGender.Name = "chbGender";
            this.chbGender.Size = new System.Drawing.Size(73, 20);
            this.chbGender.TabIndex = 3;
            this.chbGender.Text = "Giới tính";
            this.chbGender.UseVisualStyleBackColor = true;
            this.chbGender.CheckedChanged += new System.EventHandler(this.chbGender_CheckedChanged);
            // 
            // chbAddress
            // 
            this.chbAddress.AutoSize = true;
            this.chbAddress.Checked = true;
            this.chbAddress.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAddress.Location = new System.Drawing.Point(19, 111);
            this.chbAddress.Name = "chbAddress";
            this.chbAddress.Size = new System.Drawing.Size(66, 20);
            this.chbAddress.TabIndex = 2;
            this.chbAddress.Text = "Địa chỉ";
            this.chbAddress.UseVisualStyleBackColor = true;
            this.chbAddress.CheckedChanged += new System.EventHandler(this.chbAddress_CheckedChanged);
            // 
            // chbAge
            // 
            this.chbAge.AutoSize = true;
            this.chbAge.Checked = true;
            this.chbAge.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAge.Location = new System.Drawing.Point(19, 75);
            this.chbAge.Name = "chbAge";
            this.chbAge.Size = new System.Drawing.Size(67, 20);
            this.chbAge.TabIndex = 1;
            this.chbAge.Text = "Độ tuổi";
            this.chbAge.UseVisualStyleBackColor = true;
            this.chbAge.CheckedChanged += new System.EventHandler(this.chbAge_CheckedChanged);
            // 
            // chbName
            // 
            this.chbName.AutoSize = true;
            this.chbName.Checked = true;
            this.chbName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbName.Location = new System.Drawing.Point(19, 39);
            this.chbName.Name = "chbName";
            this.chbName.Size = new System.Drawing.Size(110, 20);
            this.chbName.TabIndex = 0;
            this.chbName.Text = "Tên nhân viên";
            this.chbName.UseVisualStyleBackColor = true;
            this.chbName.CheckedChanged += new System.EventHandler(this.chbName_CheckedChanged);
            // 
            // UCStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UCStaff";
            this.Size = new System.Drawing.Size(1350, 860);
            this.pnlMain.ResumeLayout(false);
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.gbContractsAndAccount.ResumeLayout(false);
            this.gbContractsAndAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRepresent)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbDateContract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUDTo;
        private System.Windows.Forms.NumericUpDown numUDFrom;
        private System.Windows.Forms.ComboBox cbSpells;
        private System.Windows.Forms.ComboBox cbTypeWork;
        private System.Windows.Forms.ComboBox cbGenderFilter;
        private System.Windows.Forms.TextBox txtAddressFilter;
        private System.Windows.Forms.TextBox txtNameFilter;
        private System.Windows.Forms.CheckBox chbSpells;
        private System.Windows.Forms.CheckBox chbTypeWork;
        private System.Windows.Forms.CheckBox chbDateContract;
        private System.Windows.Forms.CheckBox chbGender;
        private System.Windows.Forms.CheckBox chbAddress;
        private System.Windows.Forms.CheckBox chbAge;
        private System.Windows.Forms.CheckBox chbName;
        private System.Windows.Forms.PictureBox picRepresent;
        private System.Windows.Forms.DateTimePicker dtPickDoB;
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
        private System.Windows.Forms.Button btnEditStaffInfor;
        private System.Windows.Forms.Button btnMakeContract;
        private System.Windows.Forms.GroupBox gbContractsAndAccount;
        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLoadStaffInfor;
        private System.Windows.Forms.TextBox txtGender;
    }
}
