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
    public partial class SuperComboBox : ComboBox, ISuperControls
    {
        public SuperComboBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public Boolean valid()
        { 
            return (this.SelectedIndex != -1);
        }
    }
}
