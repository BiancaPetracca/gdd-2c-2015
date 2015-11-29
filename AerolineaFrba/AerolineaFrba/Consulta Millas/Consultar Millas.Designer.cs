namespace AerolineaFrba.Consulta_Millas
{
    partial class Consultar_Millas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.millas = new System.Windows.Forms.DataGridView();
            this.limpiar = new System.Windows.Forms.Button();
            this.consultar = new AerolineaFrba.SuperControls.SuperButton();
            this.dni = new AerolineaFrba.SuperControls.SuperTextBox();
            this.superLabel1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.col_tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_prod_u_origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cant_o_destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_millas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_dni = new AerolineaFrba.SuperControls.SuperLabel();
            this.tipo = new AerolineaFrba.SuperControls.SuperComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.millas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tipo);
            this.groupBox1.Controls.Add(this.tipo_dni);
            this.groupBox1.Controls.Add(this.limpiar);
            this.groupBox1.Controls.Add(this.superLabel1);
            this.groupBox1.Controls.Add(this.dni);
            this.groupBox1.Controls.Add(this.consultar);
            this.groupBox1.Controls.Add(this.millas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(864, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar millas";
            // 
            // millas
            // 
            this.millas.AllowUserToAddRows = false;
            this.millas.AllowUserToDeleteRows = false;
            this.millas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.millas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.millas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_tipo,
            this.col_fecha,
            this.col_prod_u_origen,
            this.col_cant_o_destino,
            this.col_millas});
            this.millas.Location = new System.Drawing.Point(24, 76);
            this.millas.Name = "millas";
            this.millas.Size = new System.Drawing.Size(807, 310);
            this.millas.TabIndex = 0;
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(605, 28);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 1;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // consultar
            // 
            this.consultar.Location = new System.Drawing.Point(449, 28);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(116, 23);
            this.consultar.TabIndex = 1;
            this.consultar.Text = "Consultar millas";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(296, 30);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(100, 20);
            this.dni.TabIndex = 2;
            this.dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dni_KeyPress);
            // 
            // superLabel1
            // 
            this.superLabel1.AutoSize = true;
            this.superLabel1.Location = new System.Drawing.Point(227, 33);
            this.superLabel1.Name = "superLabel1";
            this.superLabel1.Size = new System.Drawing.Size(26, 13);
            this.superLabel1.TabIndex = 3;
            this.superLabel1.Text = "DNI";
            // 
            // col_tipo
            // 
            this.col_tipo.HeaderText = "Tipo ";
            this.col_tipo.Name = "col_tipo";
            this.col_tipo.ReadOnly = true;
            // 
            // col_fecha
            // 
            this.col_fecha.HeaderText = "Fecha";
            this.col_fecha.Name = "col_fecha";
            this.col_fecha.ReadOnly = true;
            // 
            // col_prod_u_origen
            // 
            this.col_prod_u_origen.HeaderText = "Producto / Origen";
            this.col_prod_u_origen.Name = "col_prod_u_origen";
            this.col_prod_u_origen.ReadOnly = true;
            // 
            // col_cant_o_destino
            // 
            this.col_cant_o_destino.HeaderText = "Cantidad / Destino";
            this.col_cant_o_destino.Name = "col_cant_o_destino";
            this.col_cant_o_destino.ReadOnly = true;
            // 
            // col_millas
            // 
            this.col_millas.HeaderText = "Millas gastadas / obtenidas";
            this.col_millas.Name = "col_millas";
            // 
            // tipo_dni
            // 
            this.tipo_dni.AutoSize = true;
            this.tipo_dni.Location = new System.Drawing.Point(34, 33);
            this.tipo_dni.Name = "tipo_dni";
            this.tipo_dni.Size = new System.Drawing.Size(32, 13);
            this.tipo_dni.TabIndex = 4;
            this.tipo_dni.Text = "TIPO";
            // 
            // tipo
            // 
            this.tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipo.FormattingEnabled = true;
            this.tipo.Items.AddRange(new object[] {
            "DNI",
            "LC",
            "LI"});
            this.tipo.Location = new System.Drawing.Point(89, 28);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(85, 21);
            this.tipo.TabIndex = 5;
            // 
            // Consultar_Millas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 462);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consultar_Millas";
            this.Text = "Consultar millas";
            this.Load += new System.EventHandler(this.Consultar_Millas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.millas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.DataGridView millas;
        private SuperControls.SuperLabel superLabel1;
        private SuperControls.SuperTextBox dni;
        private SuperControls.SuperButton consultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_prod_u_origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cant_o_destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_millas;
        private SuperControls.SuperComboBox tipo;
        private SuperControls.SuperLabel tipo_dni;
    }
}