using System;
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
    public partial class SuperNumericUpDown : NumericUpDown, AerolineaFrba.SuperControls.ISuperControls
    {
        public SuperNumericUpDown()
        {
            InitializeComponent();
        }

        public Boolean isValid { get { return valid(); } }
        public Decimal value
        {
            get { return this.Value; }
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        public Boolean valid() { return 0 != Decimal.Round(Value, 0);  }

        public void clean() { this.Value = 0; }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
