namespace AerolineaFrba.Abm_Aeronave
{
    partial class Aeronave
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
            this.Agregar = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.VerButacas = new System.Windows.Forms.Button();
            this.Modificar = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.filtros = new System.Windows.Forms.GroupBox();
            this.HabilitadasFiltro = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PorFabricante = new System.Windows.Forms.Label();
            this.MatriculaFiltro = new System.Windows.Forms.TextBox();
            this.FabricanteFiltro = new System.Windows.Forms.TextBox();
            this.ServicioFiltro = new System.Windows.Forms.ComboBox();
            this.limpiar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.Button();
            this.PorMatricula = new System.Windows.Forms.Label();
            this.lista = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scroll_ = new System.Windows.Forms.ScrollableControl();
            this.groupBox.SuspendLayout();
            this.filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.lista.SuspendLayout();
            this.SuspendLayout();
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(604, 394);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(75, 23);
            this.Agregar.TabIndex = 2;
            this.Agregar.Text = "Agregar";
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Borrar
            // 
            this.Borrar.Location = new System.Drawing.Point(694, 394);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(75, 23);
            this.Borrar.TabIndex = 1;
            this.Borrar.Text = "Dar de baja";
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // groupBox
            // 
            this.groupBox.AutoSize = true;
            this.groupBox.Controls.Add(this.VerButacas);
            this.groupBox.Controls.Add(this.Modificar);
            this.groupBox.Controls.Add(this.Cerrar);
            this.groupBox.Controls.Add(this.filtros);
            this.groupBox.Controls.Add(this.Borrar);
            this.groupBox.Controls.Add(this.Agregar);
            this.groupBox.Controls.Add(this.lista);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(976, 436);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Aeronaves";
            // 
            // VerButacas
            // 
            this.VerButacas.Location = new System.Drawing.Point(518, 394);
            this.VerButacas.Name = "VerButacas";
            this.VerButacas.Size = new System.Drawing.Size(75, 23);
            this.VerButacas.TabIndex = 8;
            this.VerButacas.Text = "Ver butacas";
            this.VerButacas.UseVisualStyleBackColor = true;
            this.VerButacas.Click += new System.EventHandler(this.VerButacas_Click);
            // 
            // Modificar
            // 
            this.Modificar.Location = new System.Drawing.Point(784, 394);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(75, 23);
            this.Modificar.TabIndex = 7;
            this.Modificar.Text = "Modificar";
            this.Modificar.UseVisualStyleBackColor = true;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.Location = new System.Drawing.Point(871, 394);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 23);
            this.Cerrar.TabIndex = 6;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // filtros
            // 
            this.filtros.Controls.Add(this.HabilitadasFiltro);
            this.filtros.Controls.Add(this.label1);
            this.filtros.Controls.Add(this.PorFabricante);
            this.filtros.Controls.Add(this.MatriculaFiltro);
            this.filtros.Controls.Add(this.FabricanteFiltro);
            this.filtros.Controls.Add(this.ServicioFiltro);
            this.filtros.Controls.Add(this.limpiar);
            this.filtros.Controls.Add(this.buscar);
            this.filtros.Controls.Add(this.PorMatricula);
            this.filtros.Location = new System.Drawing.Point(16, 19);
            this.filtros.Name = "filtros";
            this.filtros.Size = new System.Drawing.Size(930, 116);
            this.filtros.TabIndex = 5;
            this.filtros.TabStop = false;
            this.filtros.Text = "Filtros";
            // 
            // HabilitadasFiltro
            // 
            this.HabilitadasFiltro.AutoSize = true;
            this.HabilitadasFiltro.Location = new System.Drawing.Point(380, 72);
            this.HabilitadasFiltro.Name = "HabilitadasFiltro";
            this.HabilitadasFiltro.Size = new System.Drawing.Size(100, 17);
            this.HabilitadasFiltro.TabIndex = 13;
            this.HabilitadasFiltro.Text = "Sólo habilitadas";
            this.HabilitadasFiltro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(377, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Servicio";
            // 
            // PorFabricante
            // 
            this.PorFabricante.Location = new System.Drawing.Point(57, 31);
            this.PorFabricante.Name = "PorFabricante";
            this.PorFabricante.Size = new System.Drawing.Size(100, 23);
            this.PorFabricante.TabIndex = 11;
            this.PorFabricante.Text = "Por fabricante";
            // 
            // MatriculaFiltro
            // 
            this.MatriculaFiltro.Location = new System.Drawing.Point(163, 70);
            this.MatriculaFiltro.Name = "MatriculaFiltro";
            this.MatriculaFiltro.Size = new System.Drawing.Size(161, 20);
            this.MatriculaFiltro.TabIndex = 0;
            this.MatriculaFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatriculaFiltro_KeyPress);
            // 
            // FabricanteFiltro
            // 
            this.FabricanteFiltro.Location = new System.Drawing.Point(163, 28);
            this.FabricanteFiltro.MaxLength = 255;
            this.FabricanteFiltro.Name = "FabricanteFiltro";
            this.FabricanteFiltro.Size = new System.Drawing.Size(161, 20);
            this.FabricanteFiltro.TabIndex = 1;
            this.FabricanteFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FabricanteFiltro_KeyPress);
            // 
            // ServicioFiltro
            // 
            this.ServicioFiltro.Location = new System.Drawing.Point(456, 27);
            this.ServicioFiltro.Name = "ServicioFiltro";
            this.ServicioFiltro.Size = new System.Drawing.Size(219, 21);
            this.ServicioFiltro.TabIndex = 5;
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(768, 28);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(75, 23);
            this.limpiar.TabIndex = 6;
            this.limpiar.Text = "Limpiar";
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(768, 68);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 7;
            this.buscar.Text = "Buscar";
            // 
            // PorMatricula
            // 
            this.PorMatricula.Location = new System.Drawing.Point(57, 73);
            this.PorMatricula.Name = "PorMatricula";
            this.PorMatricula.Size = new System.Drawing.Size(100, 23);
            this.PorMatricula.TabIndex = 10;
            this.PorMatricula.Text = "Por matrícula";
            // 
            // lista
            // 
            this.lista.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.lista.AllowUserToAddRows = false;
            this.lista.AllowUserToDeleteRows = false;
            this.lista.AllowUserToResizeRows = false;
            this.lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column8,
            this.Column4,
            this.Column5,
            this.Column9,
            this.Column6,
            this.Servicio});
            this.lista.Controls.Add(this.scroll_);
            this.lista.Location = new System.Drawing.Point(16, 153);
            this.lista.Name = "lista";
            this.lista.ReadOnly = true;
            this.lista.Size = new System.Drawing.Size(930, 221);
            this.lista.TabIndex = 5;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Matrícula";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fabricante";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Butacas";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Kgs. Encomienda";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Vida Útil";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Estado";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Fecha de baja";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Fecha reinicio";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Servicio
            // 
            this.Servicio.HeaderText = "Servicio";
            this.Servicio.Name = "Servicio";
            this.Servicio.ReadOnly = true;
            // 
            // scroll_
            // 
            this.scroll_.Location = new System.Drawing.Point(0, 0);
            this.scroll_.Name = "scroll_";
            this.scroll_.Size = new System.Drawing.Size(0, 0);
            this.scroll_.TabIndex = 2;
            // 
            // Aeronave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Aeronave";
            this.Text = "Aeronave";
            this.groupBox.ResumeLayout(false);
            this.filtros.ResumeLayout(false);
            this.filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.lista.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridCell listado;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox MatriculaFiltro;
        private System.Windows.Forms.TextBox FabricanteFiltro;
        private System.Windows.Forms.ComboBox ServicioFiltro; 
        private System.Windows.Forms.GroupBox filtros;

        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1;

        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Borrar;

        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.Label PorMatricula;
        private System.Windows.Forms.Label PorFabricante;
        private System.Windows.Forms.ScrollableControl scroll_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cerrar;
        private GD2C2015DataSet gD2C2015DataSet;
        private System.Windows.Forms.BindingSource maestraBindingSource;
        private GD2C2015DataSetTableAdapters.MaestraTableAdapter maestraTableAdapter;
        private System.Windows.Forms.Button VerButacas;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;
        private System.Windows.Forms.CheckBox HabilitadasFiltro;

    }
}