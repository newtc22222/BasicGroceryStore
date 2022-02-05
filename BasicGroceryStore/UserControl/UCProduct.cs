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
    public partial class UCProduct : UserControl
    {
        static UCProduct _obj;
        public static UCProduct Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCProduct();
                }
                return _obj;
            }
        }
        public UCProduct()
        {
            InitializeComponent();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            new FormProduct().ShowDialog();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new FormProduct().ShowDialog();
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            new FormSupplier().ShowDialog();
        }

        private void btnSeeMoreSupplier_Click(object sender, EventArgs e)
        {
            new FormSupplierSynthetic().ShowDialog();
        }
    }
}
