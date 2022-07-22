using System;
using System.Windows.Forms;

namespace BasicGroceryStore
{
    public partial class UCStaff : UserControl
    {
        private BUS_Staff bus_staff;
        private BUS_Account bus_account;
        private BUS_Contract bus_contract;

        private bool flagSpells;
        private Staff _staff;

        static UCStaff _obj;
        public static UCStaff Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCStaff();
                }
                return _obj;
            }
        }

        public UCStaff()
        {
            InitializeComponent();

            bus_staff = new BUS_Staff();
            bus_account = new BUS_Account();
            bus_contract = new BUS_Contract();
            LoadContentCombobox();

            LoadData();
            _staff = new Staff();
        }

        private void LoadData()
        {
            ClearInformation();
            dgvStaff.Controls.Clear();

            dgvStaff.DataSource = bus_staff.GetAllStaff();
            dgvStaff.Columns[0].Visible = false;
            dgvStaff.Columns[4].Visible = false;
            dgvStaff.Columns[7].Visible = false;
            dgvStaff.Columns[8].Visible = false;
        }

        private void ClearInformation()
        {
            picRepresent.Image = null;
            txtName.Clear();
            txtGender.Clear();
            txtCitizenID.Clear();
            txtAddress.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            ClearStaffSecretInformation();
        }

        private void ClearStaffSecretInformation()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            dgvContracts.Controls.Clear();
            dgvContracts.DataSource = null;
        }

        private void LoadContentCombobox()
        {
            cbTypeWork.DataSource = Enum.GetValues(typeof(TypeWork));
            cbSpells.DataSource = Enum.GetValues(typeof(Spells));
            cbDateContract.DataSource = Enum.GetValues(typeof(StatusOfContract));
        }

        #region Filter_Change
        private void chbTypeWork_CheckedChanged(object sender, EventArgs e)
        {
            cbTypeWork.Enabled = !cbTypeWork.Enabled;
        }

        private void chbSpells_CheckedChanged(object sender, EventArgs e)
        {
            cbSpells.Enabled = !cbSpells.Enabled;
        }

        private void chbDateContract_CheckedChanged(object sender, EventArgs e)
        {
            cbDateContract.Enabled = !cbDateContract.Enabled;
        }

        private void chbGender_CheckedChanged(object sender, EventArgs e)
        {
            cbGenderFilter.Enabled = !cbGenderFilter.Enabled;
        }

        private void chbAddress_CheckedChanged(object sender, EventArgs e)
        {
            txtAddressFilter.Enabled = !txtAddressFilter.Enabled;
        }

        private void chbAge_CheckedChanged(object sender, EventArgs e)
        {
            numUDFrom.Enabled = !numUDFrom.Enabled;
            numUDTo.Enabled = !numUDTo.Enabled;
        }

        private void chbName_CheckedChanged(object sender, EventArgs e)
        {
            txtNameFilter.Enabled = !txtNameFilter.Enabled;
        }
       
        private void cbTypeWork_SelectedIndexChanged(object sender, EventArgs e)
        {
            flagSpells = true;
            if (cbTypeWork.SelectedItem.ToString() == TypeWork.fulltime.ToString())
            {
                flagSpells = false;
            }
            chbSpells.Checked = flagSpells;
            chbSpells.Enabled = flagSpells;
        }
        #endregion

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new FormStaff(new Staff()).ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNameFilter.Clear();
            txtAddressFilter.Clear();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            btnShowPassword.Text = (btnShowPassword.Text == "Hiện mật khẩu") ? "Ẩn mật khẩu" : "Hiện mật khẩu";
            txtPassword.PasswordChar = (txtPassword.PasswordChar == '*') ? '\0' : '*';
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

        }

        private void btnEditStaffInfor_Click(object sender, EventArgs e)
        {
            if (_staff.Name != "")
                new FormStaff(_staff).ShowDialog();
        }

        private void btnMakeContract_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show($"Xóa thông tin nhân viên {_staff.Name}?", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (bus_staff.Delete(_staff))
                {
                    MessageBox.Show($"Xóa thông tin nhân viên {_staff.Name} thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                    _staff = new Staff();
                }
                else
                {
                    MessageBox.Show($"Xóa thông tin nhân viên {_staff.Name} không thành công!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearStaffSecretInformation();

            _staff.ID = dgvStaff.CurrentRow.Cells[0].Value.ToString();
            _staff.Name = dgvStaff.CurrentRow.Cells[1].Value.ToString();
            _staff.Gender = dgvStaff.CurrentRow.Cells[2].Value.ToString();
            _staff.DateOfBirth = (DateTime)dgvStaff.CurrentRow.Cells[3].Value;
            _staff.CitizenID = dgvStaff.CurrentRow.Cells[4].Value.ToString();
            _staff.Address = dgvStaff.CurrentRow.Cells[5].Value.ToString();
            _staff.Phone = dgvStaff.CurrentRow.Cells[6].Value.ToString();
            _staff.Email = dgvStaff.CurrentRow.Cells[7].Value.ToString();

            if (dgvStaff.CurrentRow.Cells[8].Value != DBNull.Value)
                _staff.Images = Convert.ByteArrayToImage((byte[])dgvStaff.CurrentRow.Cells[8].Value);
            else
                _staff.Images = null;

            txtName.Text = _staff.Name;
            txtGender.Text = _staff.Gender;
            dtPickDoB.Value = _staff.DateOfBirth;
            txtCitizenID.Text = _staff.CitizenID;
            txtAddress.Text = _staff.Address;
            txtEmail.Text = _staff.Email;
            txtPhone.Text = _staff.Phone;

            picRepresent.Image = _staff.Images;
        }

        private void btnLoadStaffInfor_Click(object sender, EventArgs e)
        {
            Account acc = bus_account.GetAccountByStaffID(_staff.ID);
            txtUsername.Text = acc.Username;
            txtPassword.Text = acc.Password;

            dgvContracts.DataSource = bus_contract.GetAllContractOfStaff(_staff.ID);
        }
    }
}
