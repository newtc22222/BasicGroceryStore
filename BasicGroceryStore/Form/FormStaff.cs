﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BasicGroceryStore
{
    public partial class FormStaff : Form
    {
        #region Properties
        private Point firstPoint;
        private bool mouseIsDown = false;
        private Staff staff = null;
        #endregion
  

        public FormStaff(Staff staff)
        {
            InitializeComponent();
            LoadContentCombobox();
            this.staff = staff;

            LoadData();
        }

        private void LoadData()
        {
            txtName.Text = staff.Name;
            txtID.Text = staff.ID;
            dtPickDoB.Value = staff.DateOfBirth;
            txtAddress.Text = staff.Address;
            cbGender.Text = staff.Gender;
            txtCitizenID.Text = staff.CitizenID;
            txtEmail.Text = staff.Email;
            txtPhone.Text = staff.Phone;

            picRepresent.Image = staff.Images;
        }

        private bool isValid(Staff staff)
        {
            if (staff.Name == "" || staff.Address == "" || staff.CitizenID == "")
                return false;
            if (!staff.Email.Contains("@"))
                return false;
            if(staff.DateOfBirth >= DateTime.Now)
                return false;
            return true;
        }

        private void LoadContentCombobox()
        {
            cbGender.DataSource = new List<string>() { "nam", "nữ", "khác" };
            cbTypeWork.DataSource = Enum.GetValues(typeof(TypeWork));
            cbSpells.DataSource = Enum.GetValues(typeof(Spells));
        }

        #region MoveForm
        private void pnlMove_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;
        }
        private void pnlMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }
        private void pnlMove_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }
        #endregion

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picRepresent.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            staff.Name = txtName.Text;
            staff.Gender = cbGender.Text;
            staff.DateOfBirth = dtPickDoB.Value;
            staff.Address = txtAddress.Text;
            staff.CitizenID = txtCitizenID.Text;
            staff.Email = txtEmail.Text;
            staff.Phone = txtPhone.Text;

            staff.Images = picRepresent.Image;

            if (isValid(staff))
            {
                if(BLL.Instance.getStaff(staff.ID) == null) // new Staff
                {
                    if (BLL.Instance.createStaff(staff))
                    {
                        MessageBox.Show("Bổ sung nhân viên thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm thông tin!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (BLL.Instance.updateStaff(staff))
                    {
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Không thể điều chỉnh thông tin!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Thông tin chưa hợp lệ!\nVui lòng điều chỉnh lại!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
