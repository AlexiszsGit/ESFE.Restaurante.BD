namespace ESFE.RestauranteBD.UI
{
    partial class FrmPostres
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
            lblTituloPostres = new Label();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblPostres = new Label();
            txtNombre = new TextBox();
            nudPrecio = new NumericUpDown();
            dgvPostres = new DataGridView();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            txtIdPostre = new TextBox();
            lblTitulo4 = new Label();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPostres).BeginInit();
            SuspendLayout();
            // 
            // lblTituloPostres
            // 
            lblTituloPostres.AutoSize = true;
            lblTituloPostres.BackColor = SystemColors.ActiveCaptionText;
            lblTituloPostres.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloPostres.ForeColor = Color.Gold;
            lblTituloPostres.Location = new Point(242, 6);
            lblTituloPostres.Name = "lblTituloPostres";
            lblTituloPostres.Size = new Size(313, 25);
            lblTituloPostres.TabIndex = 0;
            lblTituloPostres.Text = "MANTENIMIENTO DE POSTRES";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.ActiveCaptionText;
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(27, 175);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = SystemColors.ActiveCaptionText;
            lblPrecio.ForeColor = Color.White;
            lblPrecio.Location = new Point(31, 237);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio:";
            // 
            // lblPostres
            // 
            lblPostres.AutoSize = true;
            lblPostres.BackColor = SystemColors.ActiveCaptionText;
            lblPostres.ForeColor = Color.White;
            lblPostres.Location = new Point(27, 111);
            lblPostres.Name = "lblPostres";
            lblPostres.Size = new Size(69, 20);
            lblPostres.TabIndex = 3;
            lblPostres.Text = "Id Postre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(129, 172);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 27);
            txtNombre.TabIndex = 4;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(129, 230);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(150, 27);
            nudPrecio.TabIndex = 5;
            // 
            // dgvPostres
            // 
            dgvPostres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPostres.Location = new Point(308, 78);
            dgvPostres.Name = "dgvPostres";
            dgvPostres.RowHeadersWidth = 51;
            dgvPostres.Size = new Size(443, 276);
            dgvPostres.TabIndex = 12;
            dgvPostres.CellClick += dgvPostres_CellContentClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(251, 392);
            btnEliminar.Margin = new Padding(2, 2, 2, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(92, 29);
            btnEliminar.TabIndex = 36;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.RoyalBlue;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(140, 392);
            btnModificar.Margin = new Padding(2, 2, 2, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(92, 29);
            btnModificar.TabIndex = 35;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(31, 392);
            btnGuardar.Margin = new Padding(2, 2, 2, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(92, 29);
            btnGuardar.TabIndex = 34;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(128, 128, 255);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(368, 392);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 33;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtIdPostre
            // 
            txtIdPostre.Location = new Point(129, 104);
            txtIdPostre.Name = "txtIdPostre";
            txtIdPostre.Size = new Size(150, 27);
            txtIdPostre.TabIndex = 37;
            // 
            // lblTitulo4
            // 
            lblTitulo4.AutoSize = true;
            lblTitulo4.BackColor = Color.Black;
            lblTitulo4.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo4.ForeColor = Color.Gold;
            lblTitulo4.Location = new Point(27, 13);
            lblTitulo4.Name = "lblTitulo4";
            lblTitulo4.Size = new Size(221, 32);
            lblTitulo4.TabIndex = 38;
            lblTitulo4.Text = "RESTAURANTEBD ";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.ForestGreen;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(656, 28);
            btnBuscar.Margin = new Padding(2, 2, 2, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(92, 29);
            btnBuscar.TabIndex = 40;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(319, 31);
            txtBuscar.Margin = new Padding(2, 2, 2, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(318, 27);
            txtBuscar.TabIndex = 39;
            // 
            // FrmPostres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(lblTitulo4);
            Controls.Add(txtIdPostre);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvPostres);
            Controls.Add(nudPrecio);
            Controls.Add(txtNombre);
            Controls.Add(lblPrecio);
            Controls.Add(lblPostres);
            Controls.Add(lblNombre);
            Controls.Add(lblTituloPostres);
            Name = "FrmPostres";
            Text = "Postres";
            Load += FrmPostres_Load;
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPostres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloPostres;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblTipoPostre;
        private TextBox txtNombre;
        private NumericUpDown nudPrecio;
        private ComboBox cmbTipoPostre;
        private CheckBox chkDisponible;

        public FrmPostres(CheckBox chkDisponible)
        {
            this.chkDisponible = chkDisponible;
        }

        private DataGridView dgvPostres;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Label lblPostres;
        private TextBox txtIdPostre;
        private Label lblTitulo4;
        private Button btnBuscar;
        private TextBox txtBuscar;
    }
}