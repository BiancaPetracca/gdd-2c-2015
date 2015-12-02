using System;
namespace AerolineaFrba.Abm_Aeronave
{
    partial class ReemplazarOCancelar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.superLabel1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.CancelarViajes = new AerolineaFrba.SuperControls.SuperButton();
            this.ReasignarViajes = new AerolineaFrba.SuperControls.SuperButton();
            this.superLabel2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.SuspendLayout();
            // 
            // superLabel1
            // 
            this.superLabel1.AutoSize = true;
            this.superLabel1.Location = new System.Drawing.Point(30, 24);
            this.superLabel1.Name = "superLabel1";
            this.superLabel1.Size = new System.Drawing.Size(295, 13);
            this.superLabel1.TabIndex = 0;
            this.superLabel1.Text = "La aeronave que intenta dar de baja posee viajes asignados.";
            // 
            // CancelarViajes
            // 
            this.CancelarViajes.Location = new System.Drawing.Point(33, 93);
            this.CancelarViajes.Name = "CancelarViajes";
            this.CancelarViajes.Size = new System.Drawing.Size(75, 23);
            this.CancelarViajes.TabIndex = 1;
            this.CancelarViajes.Text = "Cancelarlos";
            this.CancelarViajes.UseVisualStyleBackColor = true;
            this.CancelarViajes.Click += new System.EventHandler(this.CancelarViajes_Click);
            // 
            // ReasignarViajes
            // 
            this.ReasignarViajes.Location = new System.Drawing.Point(167, 93);
            this.ReasignarViajes.Name = "ReasignarViajes";
            this.ReasignarViajes.Size = new System.Drawing.Size(178, 23);
            this.ReasignarViajes.TabIndex = 2;
            this.ReasignarViajes.Text = "Reasignar viajes a otra aeronave";
            this.ReasignarViajes.UseVisualStyleBackColor = true;
            this.ReasignarViajes.Click += new System.EventHandler(this.ReasignarViajes_Click);
            // 
            // superLabel2
            // 
            this.superLabel2.AutoSize = true;
            this.superLabel2.Location = new System.Drawing.Point(33, 52);
            this.superLabel2.Name = "superLabel2";
            this.superLabel2.Size = new System.Drawing.Size(146, 13);
            this.superLabel2.TabIndex = 3;
            this.superLabel2.Text = "¿Qué desea hacer con ellos?";
            // 
            // ReemplazarOCancelar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 142);
            this.Controls.Add(this.superLabel2);
            this.Controls.Add(this.ReasignarViajes);
            this.Controls.Add(this.CancelarViajes);
            this.Controls.Add(this.superLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReemplazarOCancelar";
            this.Text = "Elija una acción";
      
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperControls.SuperLabel superLabel1;
        private SuperControls.SuperButton CancelarViajes;
        private SuperControls.SuperButton ReasignarViajes;
        private SuperControls.SuperLabel superLabel2;
        private int tipoDeBaja;
        private String matricula;
        private DateTime fechaBaja;
        private DateTime fechaReinicio;
    }
}