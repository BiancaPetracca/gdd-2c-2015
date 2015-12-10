using AerolineaFrba.SuperControls;
namespace AerolineaFrba.Abm_Aeronave
{
    partial class Alta 
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
            this.elegirButacas = new AerolineaFrba.SuperControls.SuperButton();
            this.fabricante = new AerolineaFrba.SuperControls.SuperComboBox();
            this.modelo = new AerolineaFrba.SuperControls.SuperComboBox();
            this.matriculaNumeros = new AerolineaFrba.SuperControls.SuperTextBox();
            this.superLabel3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.matriculaLetras = new AerolineaFrba.SuperControls.SuperTextBox();
            this.superLabel2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.kgsEncomiendas = new AerolineaFrba.SuperControls.SuperNumericUpDown();
            this.servicio = new AerolineaFrba.SuperControls.SuperComboBox();
            this.lab_servicio = new AerolineaFrba.SuperControls.SuperLabel();
            this.lab_matricula = new AerolineaFrba.SuperControls.SuperLabel();
            this.label3 = new AerolineaFrba.SuperControls.SuperLabel();
            this.label2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.label1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.Aceptar = new AerolineaFrba.SuperControls.SuperButton();
            this.Cancelar = new AerolineaFrba.SuperControls.SuperButton();
            ((System.ComponentModel.ISupportInitialize)(this.kgsEncomiendas)).BeginInit();
            this.SuspendLayout();
            // 
            // elegirButacas
            // 
            this.elegirButacas.Location = new System.Drawing.Point(134, 254);
            this.elegirButacas.Name = "elegirButacas";
            this.elegirButacas.Size = new System.Drawing.Size(92, 23);
            this.elegirButacas.TabIndex = 32;
            this.elegirButacas.Text = "Elegir butacas";
            this.elegirButacas.UseVisualStyleBackColor = true;
            this.elegirButacas.Click += new System.EventHandler(this.elegirButacas_Click);
            // 
            // fabricante
            // 
            this.fabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fabricante.FormattingEnabled = true;
            this.fabricante.Location = new System.Drawing.Point(134, 72);
            this.fabricante.Name = "fabricante";
            this.fabricante.Size = new System.Drawing.Size(121, 21);
            this.fabricante.TabIndex = 31;
            this.fabricante.SelectedIndexChanged += new System.EventHandler(this.fabricante_SelectedIndexChanged);
            // 
            // modelo
            // 
            this.modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelo.FormattingEnabled = true;
            this.modelo.Location = new System.Drawing.Point(134, 32);
            this.modelo.Name = "modelo";
            this.modelo.Size = new System.Drawing.Size(121, 21);
            this.modelo.TabIndex = 30;
            // 
            // matriculaNumeros
            // 
            this.matriculaNumeros.AccessibleDescription = "Numeros de la matricula";
            this.matriculaNumeros.Location = new System.Drawing.Point(200, 113);
            this.matriculaNumeros.MaxLength = 3;
            this.matriculaNumeros.Name = "matriculaNumeros";
            this.matriculaNumeros.Size = new System.Drawing.Size(46, 20);
            this.matriculaNumeros.TabIndex = 29;
            this.matriculaNumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matriculaNumeros_KeyPress);
            // 
            // superLabel3
            // 
            this.superLabel3.AutoSize = true;
            this.superLabel3.Location = new System.Drawing.Point(184, 116);
            this.superLabel3.Name = "superLabel3";
            this.superLabel3.Size = new System.Drawing.Size(10, 13);
            this.superLabel3.TabIndex = 28;
            this.superLabel3.Text = "-";
            // 
            // matriculaLetras
            // 
            this.matriculaLetras.AccessibleDescription = "Letras de la matrícula";
            this.matriculaLetras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.matriculaLetras.Location = new System.Drawing.Point(134, 113);
            this.matriculaLetras.MaxLength = 3;
            this.matriculaLetras.Name = "matriculaLetras";
            this.matriculaLetras.Size = new System.Drawing.Size(44, 20);
            this.matriculaLetras.TabIndex = 27;
            this.matriculaLetras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.matriculaLetras_KeyPress);
            // 
            // superLabel2
            // 
            this.superLabel2.AccessibleDescription = "Límite de encomiendas";
            this.superLabel2.Location = new System.Drawing.Point(28, 198);
            this.superLabel2.Name = "superLabel2";
            this.superLabel2.Size = new System.Drawing.Size(70, 29);
            this.superLabel2.TabIndex = 26;
            this.superLabel2.Text = "Límite encomiendas";
            // 
            // kgsEncomiendas
            // 
            this.kgsEncomiendas.AccessibleDescription = "Límite de encomiendas";
            this.kgsEncomiendas.Location = new System.Drawing.Point(135, 198);
            this.kgsEncomiendas.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.kgsEncomiendas.Name = "kgsEncomiendas";
            this.kgsEncomiendas.Size = new System.Drawing.Size(46, 20);
            this.kgsEncomiendas.TabIndex = 25;
            this.kgsEncomiendas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kgsEncomiendas_KeyPress);
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
            // lab_servicio
            // 
            this.lab_servicio.AccessibleDescription = "Servicio";
            this.lab_servicio.Location = new System.Drawing.Point(28, 151);
            this.lab_servicio.Name = "lab_servicio";
            this.lab_servicio.Size = new System.Drawing.Size(100, 23);
            this.lab_servicio.TabIndex = 21;
            this.lab_servicio.Text = "Servicio";
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
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(28, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 29);
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
            this.Aceptar.AccessibleDescription = "Letras de la matricula";
            this.Aceptar.Location = new System.Drawing.Point(277, 344);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Aceptar.TabIndex = 11;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.AccessibleDescription = "Letras de la matricula";
            this.Cancelar.Location = new System.Drawing.Point(163, 344);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 12;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 389);
            this.Controls.Add(this.elegirButacas);
            this.Controls.Add(this.fabricante);
            this.Controls.Add(this.modelo);
            this.Controls.Add(this.matriculaNumeros);
            this.Controls.Add(this.superLabel3);
            this.Controls.Add(this.matriculaLetras);
            this.Controls.Add(this.superLabel2);
            this.Controls.Add(this.kgsEncomiendas);
            this.Controls.Add(this.servicio);
            this.Controls.Add(this.lab_servicio);
            this.Controls.Add(this.lab_matricula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Aceptar);
            this.Controls.Add(this.Cancelar);
            this.Name = "Alta";
            this.Text = "Nueva aeronave";
            this.Load += new System.EventHandler(this.Alta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kgsEncomiendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SuperLabel label1;
        private SuperLabel label2;
        private SuperLabel label3;
        private SuperButton Aceptar;
        private SuperButton Cancelar;
        private SuperLabel lab_matricula;
        private SuperLabel lab_servicio;
        private SuperComboBox servicio;
        private SuperLabel superLabel2;
        private SuperNumericUpDown kgsEncomiendas;
        private SuperTextBox matriculaNumeros;
        private SuperLabel superLabel3;
        private SuperTextBox matriculaLetras;
        private SuperComboBox modelo;
        private SuperComboBox fabricante;
        private SuperButton elegirButacas;
    }
}