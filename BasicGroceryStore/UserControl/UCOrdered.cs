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
    public partial class UCOrdered : UserControl
    {
        static UCOrdered _obj;
        public static UCOrdered Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCOrdered();
                }
                return _obj;
            }
        }
        public UCOrdered()
        {
            InitializeComponent();
        }
    }
}
