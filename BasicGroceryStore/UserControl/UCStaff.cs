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
    public partial class UCStaff : UserControl
    {
        #region Properties
        private bool flagSpells;
        #endregion

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
            UpdateComboboxInfor();
        }

        private void UpdateComboboxInfor()
        {
            cbTypeWork.DataSource = Enum.GetValues(typeof(GroceryStore.TypeWork));
            cbSpells.DataSource = Enum.GetValues(typeof(GroceryStore.Spells));
            cbDateContract.DataSource = Enum.GetValues(typeof(GroceryStore.StatusOfConstract));
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
            if (cbTypeWork.SelectedItem.ToString() == GroceryStore.TypeWork.fulltime.ToString())
            {
                flagSpells = false;
            }
            chbSpells.Checked = flagSpells;
            chbSpells.Enabled = flagSpells;
        }
        #endregion
    }
}
