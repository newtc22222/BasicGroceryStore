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
    public partial class UCStatistic : UserControl
    {
        static UCStatistic _obj;
        public static UCStatistic Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCStatistic();
                }
                return _obj;
            }
        }
        public UCStatistic()
        {
            InitializeComponent();
        }

        private void radReportToday_CheckedChanged(object sender, EventArgs e)
        {
            chbReportIncome.Enabled = !radReportToday.Checked;
            chbReportSpending.Enabled = !radReportToday.Checked;
        }
    }
}
