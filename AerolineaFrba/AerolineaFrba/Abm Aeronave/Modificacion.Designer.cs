using AerolineaFrba.SuperControls;
namespace AerolineaFrba.Abm_Aeronave
{
    partial class Modificacion
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
            this.label3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.label2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.matriculaLetras = new AerolineaFrba.SuperControls.SuperTextBox();
            this.label1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.Aceptar = new AerolineaFrba.SuperControls.SuperButton();
            this.Cancelar = new AerolineaFrba.SuperControls.SuperButton();
            this.lab_matricula = new AerolineaFrba.SuperControls.SuperLabel();
            this.lab_servicio = new AerolineaFrba.SuperControls.SuperLabel();
            this.servicio = new AerolineaFrba.SuperControls.SuperComboBox();
            this.kgsEncomiendas = new AerolineaFrba.SuperControls.SuperNumericUpDown();
            this.superLabel2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.superLabel3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.matriculaNumeros = new AerolineaFrba.SuperControls.SuperTextBox();
            this.modelo = new AerolineaFrba.SuperControls.SuperComboBox();
            this.fabricante = new AerolineaFrba.SuperControls.SuperComboBox();
            this.elegirButacas = new AerolineaFrba.SuperControls.SuperButton();
            ((System.ComponentModel.ISupportInitialize)(this.kgsEncomiendas)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(28, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Butacas";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fabricante";
            // 
            // matriculaLetras
            // 
            this.matriculaLetras.AccessibleDescription = "matriculaLetras";
            this.matriculaLetras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.matriculaLetras.Location = new System.Drawing.Point(134, 116);
            this.matriculaLetras.MaxLength = 3;
            this.matriculaLetras.Name = "matriculaLetras";
            this.matriculaLetras.Size = new System.Drawing.Size(44, 20);
            this.matriculaLetras.TabIndex = 0;
            this.matriculaLetras.TextChanged += new System.EventHandler(this.matriculaLetras_TextChanged);
            this.matriculaLetras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matriculaLetras_KeyPress);
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "Modelo";
            this.label1.Location = new System.Drawing.Point(28, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modelo";
            // 
            // Aceptar
            // 
            this.Aceptar.Location = new System.Drawing.Point(285, 315);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 11;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(171, 315);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 12;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // lab_matricula
            // 
            this.lab_matricula.AccessibleDescription = "Matrícula";
            this.lab_matricula.Location = new System.Drawing.Point(28, 116);
            this.lab_matricula.Name = "lab_matricula";
            this.lab_matricula.Size = new System.Drawing.Size(100, 23);
            this.lab_matricula.TabIndex = 19;
            this.lab_matricula.Text = "Matrícula";
            // 
            // lab_servicio
            // 
            this.lab_servicio.AccessibleDescription = "Servicio";
            this.lab_servicio.Location = new System.Drawing.Point(28, 151);
            this.lab_servicio.Name = "lab_servicio";
            this.lab_servicio.Size = new System.Drawing.Size(100, 23);
            this.lab_servicio.TabIndex = 21;
            this.lab_servicio.Text = "Servicio";
            // 
            // servicio
            // 
            this.servicio.AccessibleDescription = "Servicio";
            this.servicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.servicio.FormattingEnabled = true;
            this.servicio.Items.AddRange(new object[] {
            "Ejecutivo",
            "Turista",
            "Primera Clase"});
            this.servicio.Location = new System.Drawing.Point(134, 151);
            this.servicio.Name = "servicio";
            this.servicio.Size = new System.Drawing.Size(121, 21);
            this.servicio.TabIndex = 22;
            // 
            // kgsEncomiendas
            // 
            this.kgsEncomiendas.AccessibleDescription = "Límite de encomiendas";
            this.kgsEncomiendas.Location = new System.Drawing.Point(135, 202);
            this.kgsEncomiendas.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.kgsEncomiendas.Name = "kgsEncomiendas";
            this.kgsEncomiendas.Size = new System.Drawing.Size(46, 20);
            this.kgsEncomiendas.TabIndex = 23;
            // 
            // superLabel2
            // 
            this.superLabel2.AccessibleDescription = "Límite de encomiendas";
            this.superLabel2.Location = new System.Drawing.Point(28, 202);
            this.superLabel2.Name = "superLabel2";
            this.superLabel2.Size = new System.Drawing.Size(70, 29);
            this.superLabel2.TabIndex = 24;
            this.superLabel2.Text = "Límite encomiendas";
            // 
            // superLabel3
            // 
            this.superLabel3.AutoSize = true;
            this.superLabel3.Location = new System.Drawing.Point(184, 119);
            this.superLabel3.Name = "superLabel3";
            this.superLabel3.Size = new System.Drawing.Size(10, 13);
            this.superLabel3.TabIndex = 25;
            this.superLabel3.Text = "-";
            // 
            // matriculaNumeros
            // 
            this.matriculaNumeros.AccessibleDescription = "Matricula numeros";
            this.matriculaNumeros.Location = new System.Drawing.Point(200, 116);
            this.matriculaNumeros.MaxLength = 3;
            this.matriculaNumeros.Name = "matriculaNumeros";
            this.matriculaNumeros.Size = new System.Drawing.Size(46, 20);
            this.matriculaNumeros.TabIndex = 26;
            this.matriculaNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matriculaNumeros_KeyPress);
            // 
            // modelo
            // 
            this.modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelo.FormattingEnabled = true;
            this.modelo.Location = new System.Drawing.Point(134, 32);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(121, 21);
            this.modelo.TabIndex = 27;
            // 
            // fabricante
            // 
            this.fabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fabricante.FormattingEnabled = true;
            this.fabricante.Location = new System.Drawing.Point(134, 75);
            this.fabricante.Name = "fabricante";
            this.fabricante.Size = new System.Drawing.Size(121, 21);
            this.fabricante.TabIndex = 28;
            this.fabricante.SelectedIndexChanged += new System.EventHandler(this.fabricante_SelectedIndexChanged);
            // 
            // elegirButacas
            // 
            this.elegirButacas.Location = new System.Drawing.Point(134, 259);
            this.elegirButacas.Name = "elegirButacas";
            this.elegirButacas.Size = new System.Drawing.Size(92, 23);
            this.elegirButacas.TabIndex = 33;
            this.elegirButacas.Text = "Elegir butacas";
            this.elegirButacas.UseVisualStyleBackColor = true;
            this.elegirButacas.Click += new System.EventHandler(this.elegirButacas_Click);
            // 
            // Modificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 396);
            this.Controls.Add(this.elegirButacas);
            this.Controls.Add(this.fabricante);
            this.Controls.Add(this.modelo);
            this.Controls.Add(this.matriculaNumeros);
            this.Controls.Add(this.superLabel3);
            this.Controls.Add(this.superLabel2);
            this.Controls.Add(this.kgsEncomiendas);
            this.Controls.Add(this.servicio);
            this.Controls.Add(this.lab_servicio);
            this.Controls.Add(this.lab_matricula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matriculaLetras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Modificacion";
            this.Text = "Modificar aeronave";
            this.Load += new System.EventHandler(this.Modificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kgsEncomiendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperTextBox matriculaLetras;
        private SuperLabel label1;
        private SuperLabel label2;
        private SuperLabel label3;
        private SuperButton Aceptar;
        private SuperButton Cancelar;
        private SuperLabel lab_matricula;
        private SuperLabel lab_servicio;
        private SuperComboBox servicio;
        private SuperNumericUpDown kgsEncomiendas;
        private SuperLabel superLabel2;
        private SuperLabel superLabel3;
        private SuperTextBox matriculaNumeros;
        private SuperComboBox modelo;
        private SuperComboBox fabricante;
        private SuperButton elegirButacas;
    }
}