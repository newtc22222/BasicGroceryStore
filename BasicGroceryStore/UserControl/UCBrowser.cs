using System;
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
