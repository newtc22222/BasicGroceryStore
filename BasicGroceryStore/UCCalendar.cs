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
    public partial class UCCalendar : UserControl
    {
        static UCCalendar _obj;

        public static UCCalendar Instance
        {
            get
            {
                if(_obj == null)
                {
                    _obj = new UCCalendar();
                }
                return _obj;
            }
        }

        public UCCalendar()
        {
            InitializeComponent();
        }
    }
}
