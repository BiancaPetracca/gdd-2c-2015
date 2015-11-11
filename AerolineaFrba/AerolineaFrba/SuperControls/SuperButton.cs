using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AerolineaFrba.SuperControls;

namespace AerolineaFrba.SuperControls
{
    public partial class SuperButton : Button, AerolineaFrba.SuperControls.ISuperControls
    {
        public SuperButton()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public Boolean valid() { return true; }

        public void clean() { }
 

    }
}
