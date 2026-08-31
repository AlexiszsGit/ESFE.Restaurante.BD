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
            lblTituloPostres.Location = new Point(394, 9);
            lblTituloPostres.Margin = new Padding(5, 0, 5, 0);
            lblTituloPostres.Name = "lblTituloPostres";
            lblTituloPostres.Size = new Size(499, 37);
            lblTituloPostres.TabIndex = 0;
            lblTituloPostres.Text = "MANTENIMIENTO DE POSTRES";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.ActiveCaptionText;
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(44, 280);
            lblNombre.Margin = new Padding(5, 0, 5, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(107, 32);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = SystemColors.ActiveCaptionText;
            lblPrecio.ForeColor = Color.White;
            lblPrecio.Location = new Point(50, 379);
            lblPrecio.Margin = new Padding(5, 0, 5, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(84, 32);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio:";
            // 
            // lblPostres
            // 
            lblPostres.AutoSize = true;
            lblPostres.BackColor = SystemColors.ActiveCaptionText;
            lblPostres.ForeColor = Color.White;
            lblPostres.Location = new Point(44, 178);
            lblPostres.Margin = new Padding(5, 0, 5, 0);
            lblPostres.Name = "lblPostres";
            lblPostres.Size = new Size(111, 32);
            lblPostres.TabIndex = 3;
            lblPostres.Text = "Id Postre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(210, 275);
            txtNombre.Margin = new Padding(5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(241, 39);
            txtNombre.TabIndex = 4;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(210, 368);
            nudPrecio.Margin = new Padding(5);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(244, 39);
            nudPrecio.TabIndex = 5;
            // 
            // dgvPostres
            // 
            dgvPostres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPostres.Location = new Point(500, 125);
            dgvPostres.Margin = new Padding(5);
            dgvPostres.Name = "dgvPostres";
            dgvPostres.RowHeadersWidth = 51;
            dgvPostres.Size = new Size(720, 442);
            dgvPostres.TabIndex = 12;
            dgvPostres.CellClick += dgvPostres_CellContentClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(408, 627);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 46);
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
            btnModificar.Location = new Point(228, 627);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 46);
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
            btnGuardar.Location = new Point(50, 627);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 46);
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
            btnLimpiar.Location = new Point(598, 627);
            btnLimpiar.Margin = new Padding(5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(153, 46);
            btnLimpiar.TabIndex = 33;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtIdPostre
            // 
            txtIdPostre.Location = new Point(210, 166);
            txtIdPostre.Margin = new Padding(5);
            txtIdPostre.Name = "txtIdPostre";
            txtIdPostre.Size = new Size(241, 39);
            txtIdPostre.TabIndex = 37;
            // 
            // lblTitulo4
            // 
            lblTitulo4.AutoSize = true;
            lblTitulo4.BackColor = Color.Black;
            lblTitulo4.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo4.ForeColor = Color.Gold;
            lblTitulo4.Location = new Point(44, 21);
            lblTitulo4.Margin = new Padding(5, 0, 5, 0);
            lblTitulo4.Name = "lblTitulo4";
            lblTitulo4.Size = new Size(340, 50);
            lblTitulo4.TabIndex = 38;
            lblTitulo4.Text = "RESTAURANTEBD ";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.ForestGreen;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(1066, 45);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(150, 46);
            btnBuscar.TabIndex = 40;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(518, 49);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(514, 39);
            txtBuscar.TabIndex = 39;
            // 
            // FrmPostres
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1300, 720);
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
            Margin = new Padding(5);
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