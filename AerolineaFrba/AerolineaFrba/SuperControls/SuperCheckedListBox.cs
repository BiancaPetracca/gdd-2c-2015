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
    public partial class SuperCheckedListBox : CheckedListBox, AerolineaFrba.SuperControls.ISuperControls
    {
        public SuperCheckedListBox()
        {
            InitializeComponent();
        }
        public List<String> value
        {
            get
            {
                List<String> list = new List<String>();
                foreach (var chk in this.CheckedItems)
                {
                    list.Add(chk.ToString());
                }
                return list;
            }

        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public Boolean valid() { return this.CheckedItems.Count != 0; }

        public void clean()
        {
            for (int i = 0;i < this.Items.Count; i++)
            {
                this.SetItemChecked(this.Items.IndexOf(this.Items[i].ToString()), false);
            }
        }
        // esto esta horrible lo tengo que arreglar  TODO 

        public void whenCheckedMakeVisible(String checkedItem, params Control[] controls)
        {
            bool isChecked = this.SelectedItem.Equals(checkedItem);
            foreach (var ctr in controls)
            {
                ctr.Visible = isChecked;
            }
        }
        public void whenCheckedMakeVisible(String checkedItem, params DataGridViewColumn[] cols)
        {
            bool isChecked = this.SelectedItem.Equals(checkedItem);
            foreach (DataGridViewColumn dgc in cols)
            {
                dgc.Visible = isChecked;
            }
        }

        public void check(List<String> checkedItems) {
            ObjectCollection items = this.Items; // paralelo, para que no me modifique el resto 
            for (int i = 0; i < items.Count; i++)
            {
                if (checkedItems.Contains(items[i].ToString()))
                {
                    this.SetItemChecked(this.Items.IndexOf(items[i].ToString()), true);
                }
                else
                {
                    this.SetItemChecked(this.Items.IndexOf(items[i].ToString()), false);
                }
            }
        }



    }
}