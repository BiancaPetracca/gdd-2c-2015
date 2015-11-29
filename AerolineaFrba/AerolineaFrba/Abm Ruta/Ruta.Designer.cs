namespace AerolineaFrba.Abm_Ruta
{
    partial class Ruta
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
            this.buscar = new System.Windows.Forms.GroupBox();
            this.darDeBaja = new AerolineaFrba.SuperControls.SuperButton();
            this.modificar = new AerolineaFrba.SuperControls.SuperButton();
            this.Cerrar = new System.Windows.Forms.Button();
            this.filtros = new System.Windows.Forms.GroupBox();
            this.superLabel2 = new AerolineaFrba.SuperControls.SuperLabel();
            this.superLabel1 = new AerolineaFrba.SuperControls.SuperLabel();
            this.limpiar = new AerolineaFrba.SuperControls.SuperButton();
            this.superButton1 = new AerolineaFrba.SuperControls.SuperButton();
            this.destino = new AerolineaFrba.SuperControls.SuperComboBox();
            this.origen = new AerolineaFrba.SuperControls.SuperComboBox();
            this.Agregar = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.DataGridView();
            this.col_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_habilitada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pb_kg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pb_pasaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscar.SuspendLayout();
            this.filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.SuspendLayout();
            // 
            // buscar
            // 
            this.buscar.Controls.Add(this.darDeBaja);
            this.buscar.Controls.Add(this.modificar);
            this.buscar.Controls.Add(this.Cerrar);
            this.buscar.Controls.Add(this.filtros);
            this.buscar.Controls.Add(this.Agregar);
            this.buscar.Controls.Add(this.lista);
            this.buscar.Location = new System.Drawing.Point(12, 12);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(1110, 473);
            this.buscar.TabIndex = 5;
            this.buscar.TabStop = false;
            this.buscar.Text = "Rutas";
            this.buscar.Enter += new System.EventHandler(this.buscar_Enter);
            // 
            // darDeBaja
            // 
            this.darDeBaja.Location = new System.Drawing.Point(854, 435);
            this.darDeBaja.Name = "darDeBaja";
            this.darDeBaja.Size = new System.Drawing.Size(75, 23);
            this.darDeBaja.TabIndex = 8;
            this.darDeBaja.Text = "Dar de baja";
            this.darDeBaja.UseVisualStyleBackColor = true;
            this.darDeBaja.Click += new System.EventHandler(this.darDeBaja_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(773, 435);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 7;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(1023, 435);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 6;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // filtros
            // 
            this.filtros.Controls.Add(this.superLabel2);
            this.filtros.Controls.Add(this.superLabel1);
            this.filtros.Controls.Add(this.limpiar);
            this.filtros.Controls.Add(this.superButton1);
            this.filtros.Controls.Add(this.destino);
            this.filtros.Controls.Add(this.origen);
            this.filtros.Location = new System.Drawing.Point(16, 19);
            this.filtros.Name = "filtros";
            this.filtros.Size = new System.Drawing.Size(1082, 100);
            this.filtros.TabIndex = 5;
            this.filtros.TabStop = false;
            this.filtros.Text = "Filtros";
            // 
            // superLabel2
            // 
            this.superLabel2.AutoSize = true;
            this.superLabel2.Location = new System.Drawing.Point(45, 60);
            this.superLabel2.Name = "superLabel2";
            this.superLabel2.Size = new System.Drawing.Size(66, 13);
            this.superLabel2.TabIndex = 5;
            this.superLabel2.Text = "Con destino:";
            // 
            // superLabel1
            // 
            this.superLabel1.AutoSize = true;
            this.superLabel1.Location = new System.Drawing.Point(45, 27);
            this.superLabel1.Name = "superLabel1";
            this.superLabel1.Size = new System.Drawing.Size(61, 13);
            this.superLabel1.TabIndex = 4;
            this.superLabel1.Text = "Con origen:";
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(403, 57);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 3;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click_1);
            // 
            // superButton1
            // 
            this.superButton1.Location = new System.Drawing.Point(403, 17);
            this.superButton1.Name = "superButton1";
            this.superButton1.Size = new System.Drawing.Size(75, 23);
            this.superButton1.TabIndex = 2;
            this.superButton1.Text = "Buscar";
            this.superButton1.UseVisualStyleBackColor = true;
            this.superButton1.Click += new System.EventHandler(this.buscar_Click);
            // 
            // destino
            // 
            this.destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destino.FormattingEnabled = true;
            this.destino.Location = new System.Drawing.Point(167, 60);
            this.destino.Name = "destino";
            this.destino.Size = new System.Drawing.Size(139, 21);
            this.destino.TabIndex = 1;
            // 
            // origen
            // 
            this.origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.origen.FormattingEnabled = true;
            this.origen.Location = new System.Drawing.Point(167, 20);
            this.origen.Name = "origen";
            this.origen.Size = new System.Drawing.Size(139, 21);
            this.origen.TabIndex = 0;
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(935, 435);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 2;
            this.Agregar.Text = "Agregar";
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // lista
            // 
            this.lista.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.lista.AllowUserToAddRows = false;
            this.lista.AllowUserToDeleteRows = false;
            this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_codigo,
            this.col_origen,
            this.col_destino,
            this.col_servicio,
            this.col_habilitada,
            this.col_pb_kg,
            this.col_pb_pasaje});
            this.lista.Location = new System.Drawing.Point(16, 137);
            this.lista.Name = "lista";
            this.lista.ReadOnly = true;
            this.lista.Size = new System.Drawing.Size(1082, 279);
            this.lista.TabIndex = 5;
            // 
            // col_codigo
            // 
            this.col_codigo.HeaderText = "Codigo";
            this.col_codigo.Name = "col_codigo";
            this.col_codigo.ReadOnly = true;
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
            // col_servicio
            // 
            this.col_servicio.HeaderText = "Servicio";
            this.col_servicio.Name = "col_servicio";
            this.col_servicio.ReadOnly = true;
            // 
            // col_habilitada
            // 
            this.col_habilitada.HeaderText = "Habilitada";
            this.col_habilitada.Name = "col_habilitada";
            this.col_habilitada.ReadOnly = true;
            // 
            // col_pb_kg
            // 
            this.col_pb_kg.HeaderText = "Precio Base KG";
            this.col_pb_kg.Name = "col_pb_kg";
            this.col_pb_kg.ReadOnly = true;
            // 
            // col_pb_pasaje
            // 
            this.col_pb_pasaje.HeaderText = "Precio Base Pasaje";
            this.col_pb_pasaje.Name = "col_pb_pasaje";
            this.col_pb_pasaje.ReadOnly = true;
            // 
            // Ruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 497);
            this.Controls.Add(this.buscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ruta";
            this.Text = "Ruta";
            this.Load += new System.EventHandler(this.Ruta_Load);
            this.buscar.ResumeLayout(false);
            this.filtros.ResumeLayout(false);
            this.filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox buscar;
        private System.Windows.Forms.GroupBox filtros;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.Button Cerrar;
        private SuperControls.SuperButton darDeBaja;
        private SuperControls.SuperButton modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_habilitada;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pb_kg;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pb_pasaje;
        private SuperControls.SuperButton superButton1;
        private SuperControls.SuperComboBox destino;
        private SuperControls.SuperComboBox origen;
        private SuperControls.SuperButton limpiar;
        private SuperControls.SuperLabel superLabel2;
        private SuperControls.SuperLabel superLabel1;
    }
}