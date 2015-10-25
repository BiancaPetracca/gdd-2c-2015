using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using AerolineaFrba.SuperControls.ISuperControls; 


namespace AerolineaFrba.SuperControls
{
    public partial class SuperTextBox : TextBox, AerolineaFrba.SuperControls.ISuperControls
    {
        public SuperTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public Boolean valid()
        {
            return this.Text != String.Empty;
        }
    }
}
