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
    public partial class SuperComboBox : ComboBox, AerolineaFrba.SuperControls.ISuperControls
    {
        public SuperComboBox()
        {
            InitializeComponent();
        }

        public String value
        {
            get
            {
                try
                {
                    return this.SelectedItem.ToString();
                }
                catch { return null; }
            }
        }

        public Boolean isValid { get { return valid(); } }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public Boolean valid()
        { 
            return (this.SelectedIndex != -1);
        }

        public void AddAll<T>(List<T> list){ 
           foreach(T elem in list){
               this.Items.Add(elem);
    }
        }

        public void clean() {
            this.Items.Clear();
        }

        public void setItem(String item)
        {
            this.SelectedIndex = this.FindString(item);
        }

        public void clearSelection() {
           this.SelectedIndex = -1;
        }

    }
}
