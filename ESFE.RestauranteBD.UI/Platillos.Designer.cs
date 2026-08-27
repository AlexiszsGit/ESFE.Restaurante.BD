namespace ESFE.RestauranteBD.UI
{
    partial class FrmPlatillos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitulo5 = new Label();
            lblsubtitulo = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            lblProducto = new Label();
            txtProducto = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblPrecio = new Label();
            nudPrecio = new NumericUpDown();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            lblDescuento = new Label();
            cmbDescuento = new ComboBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar2 = new Button();
            btnLinpiar = new Button();
            dgvPlatillos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlatillos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo5
            // 
            lblTitulo5.AutoSize = true;
            lblTitulo5.BackColor = Color.Transparent;
            lblTitulo5.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTitulo5.ForeColor = Color.FromArgb(212, 175, 55);
            lblTitulo5.Location = new Point(43, 16);
            lblTitulo5.Margin = new Padding(2, 0, 2, 0);
            lblTitulo5.Name = "lblTitulo5";
            lblTitulo5.Size = new Size(452, 60);
            lblTitulo5.TabIndex = 0;
            lblTitulo5.Text = "✦  RESTAURANTEBD";
            // 
            // lblsubtitulo
            // 
            lblsubtitulo.AutoSize = true;
            lblsubtitulo.BackColor = Color.Transparent;
            lblsubtitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblsubtitulo.ForeColor = Color.FromArgb(170, 170, 170);
            lblsubtitulo.Location = new Point(892, 25);
            lblsubtitulo.Margin = new Padding(2, 0, 2, 0);
            lblsubtitulo.Name = "lblsubtitulo";
            lblsubtitulo.Size = new Size(323, 32);
            lblsubtitulo.TabIndex = 1;
            lblsubtitulo.Text = "Mantenimiento de Platillos";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(35, 35, 35);
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 11F);
            txtBuscar.ForeColor = Color.FromArgb(245, 245, 245);
            txtBuscar.Location = new Point(43, 78);
            txtBuscar.Margin = new Padding(2, 2, 2, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por ID o nombre...";
            txtBuscar.Size = new Size(912, 32);
            txtBuscar.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(212, 175, 55);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Location = new Point(966, 76);
            btnBuscar.Margin = new Padding(2, 2, 2, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(111, 26);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.BackColor = Color.Transparent;
            lblProducto.ForeColor = Color.FromArgb(170, 170, 170);
            lblProducto.Location = new Point(43, 128);
            lblProducto.Margin = new Padding(2, 0, 2, 0);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(91, 20);
            lblProducto.TabIndex = 4;
            lblProducto.Text = "ID Producto:";
            // 
            // txtProducto
            // 
            txtProducto.BackColor = Color.FromArgb(35, 35, 35);
            txtProducto.BorderStyle = BorderStyle.FixedSingle;
            txtProducto.Font = new Font("Segoe UI", 11F);
            txtProducto.ForeColor = Color.FromArgb(245, 245, 245);
            txtProducto.Location = new Point(43, 150);
            txtProducto.Margin = new Padding(2, 2, 2, 2);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(155, 32);
            txtProducto.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.ForeColor = Color.FromArgb(170, 170, 170);
            lblNombre.Location = new Point(222, 128);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(35, 35, 35);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 11F);
            txtNombre.ForeColor = Color.FromArgb(245, 245, 245);
            txtNombre.Location = new Point(222, 150);
            txtNombre.Margin = new Padding(2, 2, 2, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(185, 32);
            txtNombre.TabIndex = 7;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.ForeColor = Color.FromArgb(170, 170, 170);
            lblPrecio.Location = new Point(431, 128);
            lblPrecio.Margin = new Padding(2, 0, 2, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio:";
            // 
            // nudPrecio
            // 
            nudPrecio.BackColor = Color.FromArgb(35, 35, 35);
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.ForeColor = Color.FromArgb(245, 245, 245);
            nudPrecio.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrecio.Location = new Point(431, 150);
            nudPrecio.Margin = new Padding(2, 2, 2, 2);
            nudPrecio.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(135, 27);
            nudPrecio.TabIndex = 9;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.Transparent;
            lblCategoria.ForeColor = Color.FromArgb(170, 170, 170);
            lblCategoria.Location = new Point(591, 128);
            lblCategoria.Margin = new Padding(2, 0, 2, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 20);
            lblCategoria.TabIndex = 10;
            lblCategoria.Text = "Categoría:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.BackColor = Color.FromArgb(35, 35, 35);
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FlatStyle = FlatStyle.Flat;
            cmbCategoria.Font = new Font("Segoe UI", 11F);
            cmbCategoria.ForeColor = Color.FromArgb(245, 245, 245);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(591, 150);
            cmbCategoria.Margin = new Padding(2, 2, 2, 2);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(162, 33);
            cmbCategoria.TabIndex = 11;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.BackColor = Color.Transparent;
            lblDescuento.ForeColor = Color.FromArgb(170, 170, 170);
            lblDescuento.Location = new Point(775, 128);
            lblDescuento.Margin = new Padding(2, 0, 2, 0);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(82, 20);
            lblDescuento.TabIndex = 12;
            lblDescuento.Text = "Descuento:";
            // 
            // cmbDescuento
            // 
            cmbDescuento.BackColor = Color.FromArgb(35, 35, 35);
            cmbDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDescuento.FlatStyle = FlatStyle.Flat;
            cmbDescuento.Font = new Font("Segoe UI", 11F);
            cmbDescuento.ForeColor = Color.FromArgb(245, 245, 245);
            cmbDescuento.FormattingEnabled = true;
            cmbDescuento.Location = new Point(775, 150);
            cmbDescuento.Margin = new Padding(2, 2, 2, 2);
            cmbDescuento.Name = "cmbDescuento";
            cmbDescuento.Size = new Size(162, 33);
            cmbDescuento.TabIndex = 13;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(212, 175, 55);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(43, 197);
            btnGuardar.Margin = new Padding(2, 2, 2, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(98, 30);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(45, 90, 125);
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(154, 197);
            btnModificar.Margin = new Padding(2, 2, 2, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(98, 30);
            btnModificar.TabIndex = 15;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar2
            // 
            btnEliminar2.BackColor = Color.FromArgb(155, 45, 45);
            btnEliminar2.FlatAppearance.BorderSize = 0;
            btnEliminar2.FlatStyle = FlatStyle.Flat;
            btnEliminar2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEliminar2.ForeColor = Color.White;
            btnEliminar2.Location = new Point(265, 197);
            btnEliminar2.Margin = new Padding(2, 2, 2, 2);
            btnEliminar2.Name = "btnEliminar2";
            btnEliminar2.Size = new Size(98, 30);
            btnEliminar2.TabIndex = 16;
            btnEliminar2.Text = "Eliminar";
            btnEliminar2.UseVisualStyleBackColor = false;
            btnEliminar2.Click += btnEliminar2_Click;
            // 
            // btnLinpiar
            // 
            btnLinpiar.BackColor = Color.FromArgb(55, 105, 85);
            btnLinpiar.FlatAppearance.BorderSize = 0;
            btnLinpiar.FlatStyle = FlatStyle.Flat;
            btnLinpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLinpiar.ForeColor = Color.White;
            btnLinpiar.Location = new Point(375, 197);
            btnLinpiar.Margin = new Padding(2, 2, 2, 2);
            btnLinpiar.Name = "btnLinpiar";
            btnLinpiar.Size = new Size(98, 30);
            btnLinpiar.TabIndex = 17;
            btnLinpiar.Text = "Limpiar";
            btnLinpiar.UseVisualStyleBackColor = false;
            btnLinpiar.Click += btnLimpiar_Click;
            // 
            // dgvPlatillos
            // 
            dgvPlatillos.AllowUserToAddRows = false;
            dgvPlatillos.AllowUserToDeleteRows = false;
            dgvPlatillos.AllowUserToResizeRows = false;
            dgvPlatillos.BackgroundColor = Color.FromArgb(24, 24, 24);
            dgvPlatillos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(212, 175, 55);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPlatillos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPlatillos.ColumnHeadersHeight = 48;
            dgvPlatillos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(24, 24, 24);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(245, 245, 245);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(80, 68, 30);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPlatillos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPlatillos.EnableHeadersVisualStyles = false;
            dgvPlatillos.GridColor = Color.FromArgb(55, 55, 55);
            dgvPlatillos.Location = new Point(43, 247);
            dgvPlatillos.Margin = new Padding(2, 2, 2, 2);
            dgvPlatillos.MultiSelect = false;
            dgvPlatillos.Name = "dgvPlatillos";
            dgvPlatillos.ReadOnly = true;
            dgvPlatillos.RowHeadersVisible = false;
            dgvPlatillos.RowHeadersWidth = 51;
            dgvPlatillos.RowTemplate.Height = 44;
            dgvPlatillos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPlatillos.Size = new Size(1034, 256);
            dgvPlatillos.TabIndex = 18;
            dgvPlatillos.CellClick += dgvPlatillos_CellClick;
            // 
            // FrmPlatillos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(1270, 531);
            Controls.Add(lblTitulo5);
            Controls.Add(lblsubtitulo);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(lblProducto);
            Controls.Add(txtProducto);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblPrecio);
            Controls.Add(nudPrecio);
            Controls.Add(lblCategoria);
            Controls.Add(cmbCategoria);
            Controls.Add(lblDescuento);
            Controls.Add(cmbDescuento);
            Controls.Add(btnGuardar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar2);
            Controls.Add(btnLinpiar);
            Controls.Add(dgvPlatillos);
            Name = "FrmPlatillos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RESTAURANTEBD | Platillos";
            Load += FrmPlatillos_Load;
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlatillos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo5;
        private Label lblsubtitulo;

        private TextBox txtBuscar;
        private Button btnBuscar;

        private Label lblProducto;
        private TextBox txtProducto;

        private Label lblNombre;
        private TextBox txtNombre;

        private Label lblPrecio;
        private NumericUpDown nudPrecio;

        private Label lblCategoria;
        private ComboBox cmbCategoria;

        private Label lblDescuento;
        private ComboBox cmbDescuento;

        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar2;
        private Button btnLinpiar;

        private DataGridView dgvPlatillos;
    }
}