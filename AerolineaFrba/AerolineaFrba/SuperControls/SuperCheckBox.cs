﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineaFrba.SuperControls
{
    public partial class SuperCheckBox : CheckBox, AerolineaFrba.SuperControls.ISuperControls
    {
        public SuperCheckBox()
        {
            InitializeComponent();
        }

        public Boolean isValid { get { return valid(); } }
        public Boolean value
        {
            get
            {
                return this.Checked;
            }
        }


        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public Boolean valid() { return true; }

        public void clean() { this.Checked = false; }


    }
}
