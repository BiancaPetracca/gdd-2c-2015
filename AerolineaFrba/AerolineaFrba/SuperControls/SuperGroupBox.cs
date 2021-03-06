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
    public partial class SuperGroupBox : GroupBox, AerolineaFrba.SuperControls.ISuperControls
    {
        public SuperGroupBox()
        {
            InitializeComponent();
        }
        public Boolean isValid { get { return valid(); } }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public Boolean valid() {
            
           return this.Controls.AsParallel().Cast<ISuperControls>().All(cont => cont.valid());
        
        }

        public void clean() {
            foreach (Control ctr in this.Controls) {
                ((ISuperControls)ctr).clean();
            }
        }
    }
}
