using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BasicGroceryStore
{
    public partial class FormStoreInfomation : Form
    {
        DAO_Information dao;

        public FormStoreInfomation()
        {
            InitializeComponent();

            dao = new DAO_Information("StoreInformation.xml");
            LoadInformation();
        }

        #region MoveForm
        private Point firstPoint;
        private bool mouseIsDown = false;

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

        private void LoadInformation()
        {
            Dictionary<string, string> data = dao.LoadStoreInformation();

            txtAddress.Text = data["address"];
            txtEmail.Text = data["email"];
            txtPhone.Text = data["phone"];

            txtMap.Text = data["link_map"];
            txtFacebook.Text = data["link_fb"];
            txtInstagram.Text = data["link_ig"];
            txtLinkedIn.Text = data["link_linkedin"];
            txtYoutube.Text = data["link_ut"];
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> new_data = new Dictionary<string, string>();

            new_data.Add("address", txtAddress.Text);
            new_data.Add("email", txtEmail.Text);
            new_data.Add("phone", txtPhone.Text);

            new_data.Add("link_map", txtMap.Text);
            new_data.Add("link_fb", txtFacebook.Text);
            new_data.Add("link_ig", txtInstagram.Text);
            new_data.Add("link_linkedin", txtLinkedIn.Text);
            new_data.Add("link_ut", txtYoutube.Text);

            dao.UpdateInformation(new_data);

            UCHomePage.Instance.LoadStoreInformation();
            this.Close();
        }

        private void FormStoreInfomation_FormClosed(object sender, FormClosedEventArgs e)
        {
            UCHomePage.Instance.LoadStoreInformation();
        }
    }
}
