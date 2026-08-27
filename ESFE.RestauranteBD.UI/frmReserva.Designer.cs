namespace ESFE.RestauranteBD.UI
{
    partial class frmReserva
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
            lbldReserva = new Label();
            lblFecha = new Label();
            lblNombre = new Label();
            lblIdCliente = new Label();
            lblPersonas = new Label();
            lblIdMesa = new Label();
            txtIdReserva = new TextBox();
            dtpFecha = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            numPersonas = new NumericUpDown();
            txtMesa = new TextBox();
            txtIdcliente = new TextBox();
            dgvReserva = new DataGridView();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            btnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)numPersonas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReserva).BeginInit();
            SuspendLayout();
            // 
            // lbldReserva
            // 
            lbldReserva.AutoSize = true;
            lbldReserva.Location = new Point(52, 70);
            lbldReserva.Margin = new Padding(6, 0, 6, 0);
            lbldReserva.Name = "lbldReserva";
            lbldReserva.Size = new Size(100, 32);
            lbldReserva.TabIndex = 0;
            lbldReserva.Text = "Reserva:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(52, 156);
            lblFecha.Margin = new Padding(6, 0, 6, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(81, 32);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(52, 256);
            lblNombre.Margin = new Padding(6, 0, 6, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(70, 32);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Hora:";
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Location = new Point(860, 156);
            lblIdCliente.Margin = new Padding(6, 0, 6, 0);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(94, 32);
            lblIdCliente.TabIndex = 3;
            lblIdCliente.Text = "Cliente:";
            // 
            // lblPersonas
            // 
            lblPersonas.AutoSize = true;
            lblPersonas.Location = new Point(860, 70);
            lblPersonas.Margin = new Padding(6, 0, 6, 0);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.Size = new Size(112, 32);
            lblPersonas.TabIndex = 4;
            lblPersonas.Text = "Personas:";
            // 
            // lblIdMesa
            // 
            lblIdMesa.AutoSize = true;
            lblIdMesa.Location = new Point(858, 256);
            lblIdMesa.Margin = new Padding(6, 0, 6, 0);
            lblIdMesa.Name = "lblIdMesa";
            lblIdMesa.Size = new Size(76, 32);
            lblIdMesa.TabIndex = 5;
            lblIdMesa.Text = "Mesa:";
            // 
            // txtIdReserva
            // 
            txtIdReserva.Location = new Point(227, 64);
            txtIdReserva.Margin = new Padding(6);
            txtIdReserva.Name = "txtIdReserva";
            txtIdReserva.Size = new Size(182, 39);
            txtIdReserva.TabIndex = 6;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(169, 156);
            dtpFecha.Margin = new Padding(6);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(271, 39);
            dtpFecha.TabIndex = 7;
            dtpFecha.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(169, 243);
            dateTimePicker2.Margin = new Padding(6);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(162, 39);
            dateTimePicker2.TabIndex = 8;
            // 
            // numPersonas
            // 
            numPersonas.Location = new Point(1007, 66);
            numPersonas.Margin = new Padding(6);
            numPersonas.Name = "numPersonas";
            numPersonas.Size = new Size(215, 39);
            numPersonas.TabIndex = 9;
            // 
            // txtMesa
            // 
            txtMesa.Location = new Point(1007, 256);
            txtMesa.Margin = new Padding(6);
            txtMesa.Name = "txtMesa";
            txtMesa.Size = new Size(182, 39);
            txtMesa.TabIndex = 10;
            // 
            // txtIdcliente
            // 
            txtIdcliente.Location = new Point(1007, 156);
            txtIdcliente.Margin = new Padding(6);
            txtIdcliente.Name = "txtIdcliente";
            txtIdcliente.Size = new Size(182, 39);
            txtIdcliente.TabIndex = 11;
            // 
            // dgvReserva
            // 
            dgvReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReserva.Location = new Point(119, 527);
            dgvReserva.Margin = new Padding(6);
            dgvReserva.Name = "dgvReserva";
            dgvReserva.RowHeadersWidth = 82;
            dgvReserva.Size = new Size(1244, 354);
            dgvReserva.TabIndex = 12;
            dgvReserva.CellClick += dgvReserva_CellClick;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(1185, 384);
            btnLimpiar.Margin = new Padding(6);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(139, 49);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(917, 384);
            btnEliminar.Margin = new Padding(6);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 49);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(644, 384);
            btnActualizar.Margin = new Padding(6);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(139, 49);
            btnActualizar.TabIndex = 19;
            btnActualizar.Text = "Actualizar ";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(397, 382);
            btnAgregar.Margin = new Padding(6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(139, 49);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(119, 382);
            btnNuevo.Margin = new Padding(6);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(139, 49);
            btnNuevo.TabIndex = 17;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // frmReserva
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(btnNuevo);
            Controls.Add(dgvReserva);
            Controls.Add(txtIdcliente);
            Controls.Add(txtMesa);
            Controls.Add(numPersonas);
            Controls.Add(dateTimePicker2);
            Controls.Add(dtpFecha);
            Controls.Add(txtIdReserva);
            Controls.Add(lblIdMesa);
            Controls.Add(lblPersonas);
            Controls.Add(lblIdCliente);
            Controls.Add(lblNombre);
            Controls.Add(lblFecha);
            Controls.Add(lbldReserva);
            Margin = new Padding(6);
            Name = "frmReserva";
            Text = "Reserva";
            Load += frmReserva_Load;
            ((System.ComponentModel.ISupportInitialize)numPersonas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReserva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbldReserva;
        private Label lblFecha;
        private Label lblNombre;
        private Label lblIdCliente;
        private Label lblPersonas;
        private Label lblIdMesa;
        private TextBox txtIdReserva;
        private DateTimePicker dtpFecha;
        private DateTimePicker dateTimePicker2;
        private NumericUpDown numPersonas;
        private TextBox txtMesa;
        private TextBox txtIdcliente;
        private DataGridView dgvReserva;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private Button btnNuevo;
    }
}