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
    public partial class pruebasupers : TemplateForm
    {
        public pruebasupers()
        {
            InitializeComponent();
        }

        private void pruebasupers_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            validateAll(this.groupBox1.Controls);
        }

    }
}
