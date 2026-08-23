namespace ESFE.RestauranteBD.UI
{
    partial class FrmMesa
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
            lblTituloMesa = new Label();
            btnNumeroMesa = new Label();
            lblCapacidad = new Label();
            lblEstado = new Label();
            txtNumeroMesa = new TextBox();
            nudCapacidad = new NumericUpDown();
            cmbEstado = new ComboBox();
            dgvMesa = new DataGridView();
            btnEliminar = new Button();
            btmModificar = new Button();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            lblTitulo6 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMesa).BeginInit();
            SuspendLayout();
            // 
            // lblTituloMesa
            // 
            lblTituloMesa.AutoSize = true;
            lblTituloMesa.BackColor = SystemColors.ActiveCaptionText;
            lblTituloMesa.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloMesa.ForeColor = Color.Gold;
            lblTituloMesa.Location = new Point(1163, 21);
            lblTituloMesa.Margin = new Padding(5, 0, 5, 0);
            lblTituloMesa.Name = "lblTituloMesa";
            lblTituloMesa.Size = new Size(435, 37);
            lblTituloMesa.TabIndex = 0;
            lblTituloMesa.Text = "MANTENIMIETO DE MESAS";
            // 
            // btnNumeroMesa
            // 
            btnNumeroMesa.AutoSize = true;
            btnNumeroMesa.BackColor = SystemColors.ActiveCaptionText;
            btnNumeroMesa.ForeColor = Color.White;
            btnNumeroMesa.Location = new Point(76, 198);
            btnNumeroMesa.Margin = new Padding(5, 0, 5, 0);
            btnNumeroMesa.Name = "btnNumeroMesa";
            btnNumeroMesa.Size = new Size(215, 32);
            btnNumeroMesa.TabIndex = 1;
            btnNumeroMesa.Text = "Numero de Mesas:";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.BackColor = SystemColors.ActiveCaptionText;
            lblCapacidad.ForeColor = Color.White;
            lblCapacidad.Location = new Point(76, 282);
            lblCapacidad.Margin = new Padding(5, 0, 5, 0);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(129, 32);
            lblCapacidad.TabIndex = 2;
            lblCapacidad.Text = "Capacidad:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = SystemColors.ActiveCaptionText;
            lblEstado.ForeColor = Color.White;
            lblEstado.Location = new Point(76, 368);
            lblEstado.Margin = new Padding(5, 0, 5, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(89, 32);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Estado:";
            // 
            // txtNumeroMesa
            // 
            txtNumeroMesa.Location = new Point(327, 187);
            txtNumeroMesa.Margin = new Padding(5);
            txtNumeroMesa.Name = "txtNumeroMesa";
            txtNumeroMesa.Size = new Size(201, 39);
            txtNumeroMesa.TabIndex = 4;
            // 
            // nudCapacidad
            // 
            nudCapacidad.DecimalPlaces = 1;
            nudCapacidad.Location = new Point(327, 270);
            nudCapacidad.Margin = new Padding(5);
            nudCapacidad.Name = "nudCapacidad";
            nudCapacidad.Size = new Size(244, 39);
            nudCapacidad.TabIndex = 5;
            nudCapacidad.ValueChanged += nudCapacidad_ValueChanged;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(327, 355);
            cmbEstado.Margin = new Padding(5);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(243, 40);
            cmbEstado.TabIndex = 6;
            // 
            // dgvMesa
            // 
            dgvMesa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMesa.Location = new Point(750, 214);
            dgvMesa.Margin = new Padding(5);
            dgvMesa.Name = "dgvMesa";
            dgvMesa.RowHeadersWidth = 51;
            dgvMesa.Size = new Size(847, 475);
            dgvMesa.TabIndex = 11;
            dgvMesa.CellClick += dgvMesa_CellClick;
            dgvMesa.CellContentClick += dgvMesa_CellContentClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(406, 643);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 46);
            btnEliminar.TabIndex = 28;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btmModificar
            // 
            btmModificar.BackColor = Color.RoyalBlue;
            btmModificar.FlatAppearance.BorderSize = 0;
            btmModificar.FlatStyle = FlatStyle.Flat;
            btmModificar.ForeColor = Color.White;
            btmModificar.Location = new Point(224, 643);
            btmModificar.Name = "btmModificar";
            btmModificar.Size = new Size(150, 46);
            btmModificar.TabIndex = 27;
            btmModificar.Text = "Modificar";
            btmModificar.UseVisualStyleBackColor = false;
            btmModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(36, 643);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 46);
            btnGuardar.TabIndex = 26;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(128, 128, 255);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(587, 643);
            btnLimpiar.Margin = new Padding(5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(153, 46);
            btnLimpiar.TabIndex = 25;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblTitulo6
            // 
            lblTitulo6.AutoSize = true;
            lblTitulo6.BackColor = Color.Transparent;
            lblTitulo6.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitulo6.ForeColor = Color.FromArgb(212, 175, 55);
            lblTitulo6.Location = new Point(12, 6);
            lblTitulo6.Name = "lblTitulo6";
            lblTitulo6.Size = new Size(718, 93);
            lblTitulo6.TabIndex = 29;
            lblTitulo6.Text = "✦  RESTAURANTEBD";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(35, 35, 35);
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 11F);
            txtBuscar.ForeColor = Color.FromArgb(245, 245, 245);
            txtBuscar.Location = new Point(-28, 107);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por ID o nombre...";
            txtBuscar.Size = new Size(1480, 47);
            txtBuscar.TabIndex = 30;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(212, 175, 55);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(1442, 107);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(180, 42);
            btnBuscar.TabIndex = 31;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmMesa
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1612, 768);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(lblTitulo6);
            Controls.Add(btnEliminar);
            Controls.Add(btmModificar);
            Controls.Add(btnGuardar);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvMesa);
            Controls.Add(cmbEstado);
            Controls.Add(nudCapacidad);
            Controls.Add(txtNumeroMesa);
            Controls.Add(lblEstado);
            Controls.Add(lblCapacidad);
            Controls.Add(btnNumeroMesa);
            Controls.Add(lblTituloMesa);
            Margin = new Padding(5);
            Name = "FrmMesa";
            Text = "Mesa";
            Load += Mesa_Load;
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMesa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloMesa;
        private Label btnNumeroMesa;
        private Label lblCapacidad;
        private Label lblEstado;
        private TextBox txtNumeroMesa;
        private NumericUpDown nudCapacidad;
        private ComboBox cmbEstado;
        private DataGridView dgvMesa;
        private Button btnEliminar;
        private Button btmModificar;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Label lblTitulo6;
        private TextBox txtBuscar;
        private Button btnBuscar;
    }
}