using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicGroceryStore
{
    public partial class UCHomePage : UserControl
    {
        static UCHomePage _obj;
        public static UCHomePage Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCHomePage();
                }
                return _obj;
            }
        }
        public UCHomePage()
        {
            InitializeComponent();
        }

        #region ButtonControl
        private void btnChangeCustomerInfor_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeStoreInfor_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeYourInfor_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnReloadValue_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region PictureBox_Link
        private void picYoutube_Click(object sender, EventArgs e)
        {

        }

        private void picFace_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/phi.f1n3/");
        }

        private void picInsta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/phi_fine_174/");
        }

        private void picLinkedIn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/f1-fine-5005a821b/");
        }

        private void picStoreLocation_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://goo.gl/maps/vo8q51C3nzS5srxW9");
        }

        private void pictContact_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
