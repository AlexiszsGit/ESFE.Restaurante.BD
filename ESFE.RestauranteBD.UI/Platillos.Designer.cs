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

            // =====================================================
            // TITULO PRINCIPAL
            // =====================================================

            lblTitulo5.AutoSize = true;
            lblTitulo5.BackColor = Color.Transparent;
            lblTitulo5.Font = new System.Drawing.Font(
                "Segoe UI",
                26F,
                FontStyle.Bold,
                GraphicsUnit.Point);

            lblTitulo5.ForeColor =
                Color.FromArgb(212, 175, 55);

            lblTitulo5.Location =
                new Point(70, 25);

            lblTitulo5.Name = "lblTitulo5";

            lblTitulo5.Size =
                new Size(400, 47);

            lblTitulo5.TabIndex = 0;

            lblTitulo5.Text =
                "✦  RESTAURANTEBD";

            // =====================================================
            // SUBTITULO
            // =====================================================

            lblsubtitulo.AutoSize = true;
            lblsubtitulo.BackColor = Color.Transparent;

            lblsubtitulo.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    14F,
                    FontStyle.Bold,
                    GraphicsUnit.Point);

            lblsubtitulo.ForeColor =
                Color.FromArgb(170, 170, 170);

            // SUBTITULO EN LA ESQUINA DERECHA
            lblsubtitulo.Location =
                new Point(1450, 40);

            lblsubtitulo.Name =
                "lblsubtitulo";

            lblsubtitulo.Size =
                new Size(280, 25);

            lblsubtitulo.TabIndex = 1;

            lblsubtitulo.Text =
                "Mantenimiento de Platillos";

            // =====================================================
            // BUSQUEDA
            // =====================================================

            txtBuscar.BackColor =
                Color.FromArgb(35, 35, 35);

            txtBuscar.BorderStyle =
                BorderStyle.FixedSingle;

            txtBuscar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Regular,
                    GraphicsUnit.Point);

            txtBuscar.ForeColor =
                Color.FromArgb(245, 245, 245);

            txtBuscar.Location =
                new Point(70, 125);

            txtBuscar.Name =
                "txtBuscar";

            txtBuscar.PlaceholderText =
                "Buscar por ID o nombre...";

            txtBuscar.Size =
                new Size(1480, 32);

            txtBuscar.TabIndex = 2;

            // =====================================================
            // BOTON BUSCAR
            // =====================================================

            btnBuscar.BackColor =
                Color.FromArgb(212, 175, 55);

            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;

            btnBuscar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold,
                    GraphicsUnit.Point);

            btnBuscar.ForeColor =
                Color.Black;

            btnBuscar.Location =
                new Point(1570, 121);

            btnBuscar.Name =
                "btnBuscar";

            btnBuscar.Size =
                new Size(180, 42);

            btnBuscar.TabIndex = 3;

            btnBuscar.Text =
                "Buscar";

            btnBuscar.UseVisualStyleBackColor = false;

            btnBuscar.Click += btnBuscar_Click;

            // =====================================================
            // ID PRODUCTO
            // =====================================================

            lblProducto.AutoSize = true;
            lblProducto.BackColor = Color.Transparent;

            lblProducto.ForeColor =
                Color.FromArgb(170, 170, 170);

            lblProducto.Location =
                new Point(70, 205);

            lblProducto.Name =
                "lblProducto";

            lblProducto.Size =
                new Size(120, 23);

            lblProducto.TabIndex = 4;

            lblProducto.Text =
                "ID Producto:";

            txtProducto.BackColor =
                Color.FromArgb(35, 35, 35);

            txtProducto.BorderStyle =
                BorderStyle.FixedSingle;

            txtProducto.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F);

            txtProducto.ForeColor =
                Color.FromArgb(245, 245, 245);

            txtProducto.Location =
                new Point(70, 240);

            txtProducto.Name =
                "txtProducto";

            txtProducto.Size =
                new Size(250, 32);

            txtProducto.TabIndex = 5;

            // =====================================================
            // NOMBRE
            // =====================================================

            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;

            lblNombre.ForeColor =
                Color.FromArgb(170, 170, 170);

            lblNombre.Location =
                new Point(360, 205);

            lblNombre.Name =
                "lblNombre";

            lblNombre.Size =
                new Size(75, 23);

            lblNombre.TabIndex = 6;

            lblNombre.Text =
                "Nombre:";

            txtNombre.BackColor =
                Color.FromArgb(35, 35, 35);

            txtNombre.BorderStyle =
                BorderStyle.FixedSingle;

            txtNombre.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F);

            txtNombre.ForeColor =
                Color.FromArgb(245, 245, 245);

            txtNombre.Location =
                new Point(360, 240);

            txtNombre.Name =
                "txtNombre";

            txtNombre.Size =
                new Size(300, 32);

            txtNombre.TabIndex = 7;

            // =====================================================
            // PRECIO
            // =====================================================

            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;

            lblPrecio.ForeColor =
                Color.FromArgb(170, 170, 170);

            lblPrecio.Location =
                new Point(700, 205);

            lblPrecio.Name =
                "lblPrecio";

            lblPrecio.Size =
                new Size(60, 23);

            lblPrecio.TabIndex = 8;

            lblPrecio.Text =
                "Precio:";

            nudPrecio.BackColor =
                Color.FromArgb(35, 35, 35);

            nudPrecio.DecimalPlaces = 2;

            nudPrecio.ForeColor =
                Color.FromArgb(245, 245, 245);

            nudPrecio.Increment =
                0.01M;

            nudPrecio.Location =
                new Point(700, 240);

            nudPrecio.Maximum =
                99999M;

            nudPrecio.Minimum =
                0M;

            nudPrecio.Name =
                "nudPrecio";

            nudPrecio.Size =
                new Size(220, 32);

            nudPrecio.TabIndex = 9;

            // IMPORTANTE:
            // Evita que 0.50 sea interpretado como 50
            nudPrecio.ThousandsSeparator = false;

            nudPrecio.Value =
                0.00M;

            // =====================================================
            // CATEGORIA
            // =====================================================

            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.Transparent;

            lblCategoria.ForeColor =
                Color.FromArgb(170, 170, 170);

            lblCategoria.Location =
                new Point(960, 205);

            lblCategoria.Name =
                "lblCategoria";

            lblCategoria.Size =
                new Size(90, 23);

            lblCategoria.TabIndex = 10;

            lblCategoria.Text =
                "Categoría:";

            cmbCategoria.BackColor =
                Color.FromArgb(35, 35, 35);

            cmbCategoria.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbCategoria.FlatStyle =
                FlatStyle.Flat;

            cmbCategoria.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F);

            cmbCategoria.ForeColor =
                Color.FromArgb(245, 245, 245);

            cmbCategoria.FormattingEnabled = true;

            cmbCategoria.Location =
                new Point(960, 240);

            cmbCategoria.Name =
                "cmbCategoria";

            cmbCategoria.Size =
                new Size(260, 32);

            cmbCategoria.TabIndex = 11;

            // =====================================================
            // DESCUENTO
            // =====================================================

            lblDescuento.AutoSize = true;
            lblDescuento.BackColor = Color.Transparent;

            lblDescuento.ForeColor =
                Color.FromArgb(170, 170, 170);

            lblDescuento.Location =
                new Point(1260, 205);

            lblDescuento.Name =
                "lblDescuento";

            lblDescuento.Size =
                new Size(100, 23);

            lblDescuento.TabIndex = 12;

            lblDescuento.Text =
                "Descuento:";

            cmbDescuento.BackColor =
                Color.FromArgb(35, 35, 35);

            cmbDescuento.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cmbDescuento.FlatStyle =
                FlatStyle.Flat;

            cmbDescuento.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    11F);

            cmbDescuento.ForeColor =
                Color.FromArgb(245, 245, 245);

            cmbDescuento.FormattingEnabled = true;

            cmbDescuento.Location =
                new Point(1260, 240);

            cmbDescuento.Name =
                "cmbDescuento";

            cmbDescuento.Size =
                new Size(260, 32);

            cmbDescuento.TabIndex = 13;

            // =====================================================
            // GUARDAR
            // =====================================================

            btnGuardar.BackColor =
                Color.FromArgb(212, 175, 55);

            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;

            btnGuardar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold,
                    GraphicsUnit.Point);

            btnGuardar.ForeColor =
                Color.Black;

            btnGuardar.Location =
                new Point(70, 315);

            btnGuardar.Name =
                "btnGuardar";

            btnGuardar.Size =
                new Size(160, 48);

            btnGuardar.TabIndex = 14;

            btnGuardar.Text =
                "Guardar";

            btnGuardar.UseVisualStyleBackColor = false;

            btnGuardar.Click += btnGuardar_Click;

            // =====================================================
            // MODIFICAR
            // =====================================================

            btnModificar.BackColor =
                Color.FromArgb(45, 90, 125);

            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;

            btnModificar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold,
                    GraphicsUnit.Point);

            btnModificar.ForeColor =
                Color.White;

            btnModificar.Location =
                new Point(250, 315);

            btnModificar.Name =
                "btnModificar";

            btnModificar.Size =
                new Size(160, 48);

            btnModificar.TabIndex = 15;

            btnModificar.Text =
                "Modificar";

            btnModificar.UseVisualStyleBackColor = false;

            btnModificar.Click += btnModificar_Click;

            // =====================================================
            // ELIMINAR
            // =====================================================

            btnEliminar2.BackColor =
                Color.FromArgb(155, 45, 45);

            btnEliminar2.FlatAppearance.BorderSize = 0;
            btnEliminar2.FlatStyle = FlatStyle.Flat;

            btnEliminar2.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold,
                    GraphicsUnit.Point);

            btnEliminar2.ForeColor =
                Color.White;

            btnEliminar2.Location =
                new Point(430, 315);

            btnEliminar2.Name =
                "btnEliminar2";

            btnEliminar2.Size =
                new Size(160, 48);

            btnEliminar2.TabIndex = 16;

            btnEliminar2.Text =
                "Eliminar";

            btnEliminar2.UseVisualStyleBackColor = false;

            btnEliminar2.Click += btnEliminar2_Click;

            // =====================================================
            // LIMPIAR
            // =====================================================

            btnLinpiar.BackColor =
                Color.FromArgb(55, 105, 85);

            btnLinpiar.FlatAppearance.BorderSize = 0;
            btnLinpiar.FlatStyle = FlatStyle.Flat;

            btnLinpiar.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold,
                    GraphicsUnit.Point);

            btnLinpiar.ForeColor =
                Color.White;

            btnLinpiar.Location =
                new Point(610, 315);

            btnLinpiar.Name =
                "btnLinpiar";

            btnLinpiar.Size =
                new Size(160, 48);

            btnLinpiar.TabIndex = 17;

            btnLinpiar.Text =
                "Limpiar";

            btnLinpiar.UseVisualStyleBackColor = false;

            btnLinpiar.Click += btnLimpiar_Click;

            // =====================================================
            // TABLA
            // =====================================================

            dgvPlatillos.AllowUserToAddRows = false;
            dgvPlatillos.AllowUserToDeleteRows = false;
            dgvPlatillos.AllowUserToResizeRows = false;

            dgvPlatillos.BackgroundColor =
                Color.FromArgb(24, 24, 24);

            dgvPlatillos.BorderStyle =
                BorderStyle.None;

            dgvPlatillos.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(212, 175, 55);

            dgvPlatillos.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.Black;

            dgvPlatillos.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            dgvPlatillos.ColumnHeadersHeight = 48;

            dgvPlatillos.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgvPlatillos.EnableHeadersVisualStyles = false;

            dgvPlatillos.GridColor =
                Color.FromArgb(55, 55, 55);

            dgvPlatillos.DefaultCellStyle.BackColor =
                Color.FromArgb(24, 24, 24);

            dgvPlatillos.DefaultCellStyle.ForeColor =
                Color.FromArgb(245, 245, 245);

            dgvPlatillos.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(80, 68, 30);

            dgvPlatillos.DefaultCellStyle.SelectionForeColor =
                Color.White;

            dgvPlatillos.Location =
                new Point(70, 395);

            dgvPlatillos.Name =
                "dgvPlatillos";

            dgvPlatillos.ReadOnly = true;

            dgvPlatillos.RowHeadersVisible = false;

            dgvPlatillos.RowTemplate.Height = 44;

            dgvPlatillos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvPlatillos.MultiSelect = false;

            dgvPlatillos.Size =
                new Size(1680, 410);

            dgvPlatillos.TabIndex = 18;

            dgvPlatillos.CellClick +=
                dgvPlatillos_CellClick;

            // =====================================================
            // FORMULARIO
            // =====================================================

            AutoScaleDimensions =
                new SizeF(13F, 32F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.FromArgb(10, 10, 10);

            ClientSize =
                new Size(1800, 850);

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

            Margin =
                new Padding(5);

            Name =
                "FrmPlatillos";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "RESTAURANTEBD | Platillos";

            Load +=
                FrmPlatillos_Load;

            ((System.ComponentModel.ISupportInitialize)
                nudPrecio).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                dgvPlatillos).EndInit();

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