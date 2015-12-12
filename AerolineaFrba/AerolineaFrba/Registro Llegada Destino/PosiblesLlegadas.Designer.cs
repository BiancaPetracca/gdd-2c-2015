namespace AerolineaFrba.Registro_Llegada_Destino
{
    partial class PosiblesLlegadas
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
            this.registros = new System.Windows.Forms.DataGridView();
            this.seleccionar = new AerolineaFrba.SuperControls.SuperButton();
            this.col_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_matricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_salida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_llegada_estimada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.registros)).BeginInit();
            this.SuspendLayout();
            // 
            // registros
            // 
            this.registros.AllowUserToAddRows = false;
            this.registros.AllowUserToDeleteRows = false;
            this.registros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_codigo,
            this.col_matricula,
            this.col_origen,
            this.col_destino,
            this.col_salida,
            this.col_llegada_estimada});
            this.registros.Location = new System.Drawing.Point(41, 34);
            this.registros.MultiSelect = false;
            this.registros.Name = "registros";
            this.registros.ReadOnly = true;
            this.registros.Size = new System.Drawing.Size(812, 205);
            this.registros.TabIndex = 12;
            // 
            // seleccionar
            // 
            this.seleccionar.Location = new System.Drawing.Point(726, 262);
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Size = new System.Drawing.Size(127, 23);
            this.seleccionar.TabIndex = 13;
            this.seleccionar.Text = "Seleccionar llegada";
            this.seleccionar.UseVisualStyleBackColor = true;
            this.seleccionar.Click += new System.EventHandler(this.seleccionar_Click);
            // 
            // col_codigo
            // 
            this.col_codigo.HeaderText = "Codigo del viaje";
            this.col_codigo.Name = "col_codigo";
            this.col_codigo.ReadOnly = true;
            // 
            // col_matricula
            // 
            this.col_matricula.HeaderText = "Matrícula";
            this.col_matricula.Name = "col_matricula";
            this.col_matricula.ReadOnly = true;
            // 
            // col_origen
            // 
            this.col_origen.HeaderText = "Origen";
            this.col_origen.Name = "col_origen";
            this.col_origen.ReadOnly = true;
            // 
            // col_destino
            // 
            this.col_destino.HeaderText = "Destino";
            this.col_destino.Name = "col_destino";
            this.col_destino.ReadOnly = true;
            // 
            // col_salida
            // 
            this.col_salida.HeaderText = "Salida";
            this.col_salida.Name = "col_salida";
            this.col_salida.ReadOnly = true;
            // 
            // col_llegada_estimada
            // 
            this.col_llegada_estimada.HeaderText = "Llegada estimada";
            this.col_llegada_estimada.Name = "col_llegada_estimada";
            this.col_llegada_estimada.ReadOnly = true;
            // 
            // PosiblesLlegadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 319);
            this.Controls.Add(this.seleccionar);
            this.Controls.Add(this.registros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PosiblesLlegadas";
            this.Text = "PosiblesLlegadas";
            this.Load += new System.EventHandler(this.PosiblesLlegadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView registros;
        private SuperControls.SuperButton seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_matricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_salida;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_llegada_estimada;
    }
}