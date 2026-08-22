namespace ESFE.RestauranteBD.UI
{
    partial class FrmPlatillos
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
            lblTitulo = new Label();
            lblNombre = new Label();
            lblPrecio = new Label();
            lblCategoria = new Label();
            txtNombre = new TextBox();
            nudPrecio = new NumericUpDown();
            cmbCategoria = new ComboBox();
            btnEliminar = new Button();
            dgvPlatillos = new DataGridView();
            button2 = new Button();
            btmModificar = new Button();
            btnGuardar = new Button();
            btnLinpiar = new Button();
            lblDescuento = new Label();
            lblProducto = new Label();
            txtDescuento = new TextBox();
            txtProducto = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlatillos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.ActiveCaptionText;
            lblTitulo.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Gold;
            lblTitulo.Location = new Point(442, 56);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(307, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "MANTENIMIENTO DE PLATILLOS";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.ActiveCaptionText;
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(50, 118);
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
            lblPrecio.Location = new Point(50, 182);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = SystemColors.ActiveCaptionText;
            lblCategoria.ForeColor = Color.White;
            lblCategoria.Location = new Point(50, 249);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(94, 20);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Id Categoria:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(163, 111);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(151, 27);
            txtNombre.TabIndex = 4;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(163, 175);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(150, 27);
            nudPrecio.TabIndex = 5;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Postres", "Bebidas", "Platillos" });
            cmbCategoria.Location = new Point(163, 241);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(151, 28);
            cmbCategoria.TabIndex = 6;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(0, 0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "btnEliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvPlatillos
            // 
            dgvPlatillos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlatillos.Location = new Point(348, 111);
            dgvPlatillos.Name = "dgvPlatillos";
            dgvPlatillos.RowHeadersWidth = 51;
            dgvPlatillos.Size = new Size(809, 323);
            dgvPlatillos.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(231, 495);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(92, 29);
            button2.TabIndex = 32;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnEliminar_Click;
            // 
            // btmModificar
            // 
            btmModificar.BackColor = Color.RoyalBlue;
            btmModificar.FlatAppearance.BorderSize = 0;
            btmModificar.FlatStyle = FlatStyle.Flat;
            btmModificar.ForeColor = Color.White;
            btmModificar.Location = new Point(120, 495);
            btmModificar.Margin = new Padding(2);
            btmModificar.Name = "btmModificar";
            btmModificar.Size = new Size(92, 29);
            btmModificar.TabIndex = 31;
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
            btnGuardar.Location = new Point(11, 495);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(92, 29);
            btnGuardar.TabIndex = 30;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLinpiar
            // 
            btnLinpiar.BackColor = Color.FromArgb(128, 128, 255);
            btnLinpiar.FlatStyle = FlatStyle.Flat;
            btnLinpiar.ForeColor = Color.White;
            btnLinpiar.Location = new Point(348, 495);
            btnLinpiar.Name = "btnLinpiar";
            btnLinpiar.Size = new Size(94, 29);
            btnLinpiar.TabIndex = 29;
            btnLinpiar.Text = "Limpiar";
            btnLinpiar.UseVisualStyleBackColor = false;
            btnLinpiar.Click += btnLimpiar_Click;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.ForeColor = Color.White;
            lblDescuento.Location = new Point(50, 309);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(96, 20);
            lblDescuento.TabIndex = 33;
            lblDescuento.Text = "Id Descuento";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.ForeColor = Color.White;
            lblProducto.Location = new Point(50, 375);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(86, 20);
            lblProducto.TabIndex = 34;
            lblProducto.Text = "Id Producto";
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(162, 302);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(151, 27);
            txtDescuento.TabIndex = 35;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(162, 368);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(151, 27);
            txtProducto.TabIndex = 36;
            // 
            // FrmPlatillos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1192, 568);
            Controls.Add(txtProducto);
            Controls.Add(txtDescuento);
            Controls.Add(lblProducto);
            Controls.Add(lblDescuento);
            Controls.Add(button2);
            Controls.Add(btmModificar);
            Controls.Add(btnGuardar);
            Controls.Add(btnLinpiar);
            Controls.Add(dgvPlatillos);
            Controls.Add(cmbCategoria);
            Controls.Add(nudPrecio);
            Controls.Add(txtNombre);
            Controls.Add(lblTitulo);
            Controls.Add(lblNombre);
            Controls.Add(lblPrecio);
            Controls.Add(lblCategoria);
            Name = "FrmPlatillos";
            Text = "Platillos";
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlatillos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblCategoria;
        private TextBox txtNombre;
        private NumericUpDown nudPrecio;
        private ComboBox cmbCategoria;
        private CheckBox chkDisponible;
        private Button btnEliminar;
        private DataGridView dgvPlatillos;
        private Button button2;
        private Button btmModificar;
        private Button btnGuardar;
        private Button btnLinpiar;
        private Label lblDescuento;
        private Label lblProducto;
        private TextBox txtDescuento;
        private TextBox txtProducto;
    }
}