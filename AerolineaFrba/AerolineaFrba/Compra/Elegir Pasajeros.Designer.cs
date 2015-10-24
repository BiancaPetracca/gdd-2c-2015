using AerolineaFrba.SuperControls;
namespace AerolineaFrba.Compra
{
    partial class Elegir_Pasajeros
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
            this.DatosPasajes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Siguiente = new AerolineaFrba.SuperControls.SuperButton();
            this.Cancelar = new AerolineaFrba.SuperControls.SuperButton();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeleccionarButaca = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NumeroButaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoButaca = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.KgsEncomienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DatosPasajes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatosPasajes
            // 
            this.DatosPasajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosPasajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.DNI,
            this.Direccion,
            this.Telefono,
            this.Mail,
            this.FechaNacimiento,
            this.SeleccionarButaca,
            this.NumeroButaca,
            this.TipoButaca,
            this.KgsEncomienda});
            this.DatosPasajes.Location = new System.Drawing.Point(19, 30);
            this.DatosPasajes.Name = "DatosPasajes";
            this.DatosPasajes.Size = new System.Drawing.Size(843, 322);
            this.DatosPasajes.TabIndex = 0;
            this.DatosPasajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatosPasajes_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DatosPasajes);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(882, 383);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elegir Pasajeros / Datos Encomienda";
            // 
            // Siguiente
            // 
            this.Siguiente.Location = new System.Drawing.Point(787, 411);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(75, 23);
            this.Siguiente.TabIndex = 2;
            this.Siguiente.Text = "Siguiente";
            this.Siguiente.UseVisualStyleBackColor = true;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(677, 411);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            // 
            // Mail
            // 
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.FechaNacimiento.Name = "FechaNacimiento";
            // 
            // SeleccionarButaca
            // 
            this.SeleccionarButaca.HeaderText = "Seleccionar Butaca";
            this.SeleccionarButaca.Name = "SeleccionarButaca";
            this.SeleccionarButaca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SeleccionarButaca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SeleccionarButaca.ToolTipText = "SeleccionarButaca";
            this.SeleccionarButaca.UseColumnTextForButtonValue = true;
            // 
            // NumeroButaca
            // 
            this.NumeroButaca.HeaderText = "Numero de Butaca";
            this.NumeroButaca.Name = "NumeroButaca";
            this.NumeroButaca.ReadOnly = true;
            // 
            // TipoButaca
            // 
            this.TipoButaca.HeaderText = "Tipo";
            this.TipoButaca.Name = "TipoButaca";
            this.TipoButaca.ReadOnly = true;
            this.TipoButaca.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TipoButaca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // KgsEncomienda
            // 
            this.KgsEncomienda.HeaderText = "Kgs. Encomienda";
            this.KgsEncomienda.Name = "KgsEncomienda";
            // 
            // Elegir_Pasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 455);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Elegir_Pasajeros";
            this.Text = "Elegir Pasajeros";
            this.Click += new System.EventHandler(this.SeleccionarButaca_Click);
            ((System.ComponentModel.ISupportInitialize)(this.DatosPasajes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.DataGridView DatosPasajes;
        private System.Windows.Forms.GroupBox groupBox1;
        private SuperButton Siguiente;
        private SuperButton Cancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewButtonColumn SeleccionarButaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroButaca;
        private System.Windows.Forms.DataGridViewComboBoxColumn TipoButaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn KgsEncomienda;
    }
}