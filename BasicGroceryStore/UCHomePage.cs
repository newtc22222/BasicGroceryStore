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
    }
}
