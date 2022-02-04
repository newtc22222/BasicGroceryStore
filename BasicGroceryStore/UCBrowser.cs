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
    public partial class UCBrowser : UserControl
    {
        static UCBrowser _obj;
        public static UCBrowser Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCBrowser();
                }
                return _obj;
            }
        }
        public UCBrowser()
        {
            InitializeComponent();
        }
    }
}
