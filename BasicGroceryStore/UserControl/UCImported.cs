﻿using System;
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
    public partial class UCImported : UserControl
    {
        static UCImported _obj;
        public static UCImported Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UCImported();
                }
                return _obj;
            }
        }
        public UCImported()
        {
            InitializeComponent();
        }
    }
}
