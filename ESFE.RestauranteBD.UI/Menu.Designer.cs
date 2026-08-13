namespace ESFE.RestauranteBD.UI
{
    partial class Menu
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
            lblId = new Label();
            lblNombre = new Label();
            lblDescripcion = new Label();
            label4 = new Label();
            label5 = new Label();
            grpDatosMenu = new GroupBox();
            cboEstado = new ComboBox();
            nudPrecio = new NumericUpDown();
            cboCategoria = new ComboBox();
            lblEstado = new Label();
            lblPrecio = new Label();
            lblCategoria = new Label();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            txtId = new TextBox();
            lblTitulo = new Label();
            pnlBotones = new Panel();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            btnNuevo = new Button();
            dataGridView1 = new DataGridView();
            grpDatosMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(37, 30);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(37, 66);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(37, 110);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 234);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(405, 242);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            label5.Click += label5_Click;
            // 
            // grpDatosMenu
            // 
            grpDatosMenu.Controls.Add(cboEstado);
            grpDatosMenu.Controls.Add(nudPrecio);
            grpDatosMenu.Controls.Add(cboCategoria);
            grpDatosMenu.Controls.Add(lblEstado);
            grpDatosMenu.Controls.Add(lblPrecio);
            grpDatosMenu.Controls.Add(lblCategoria);
            grpDatosMenu.Controls.Add(txtDescripcion);
            grpDatosMenu.Controls.Add(txtNombre);
            grpDatosMenu.Controls.Add(txtId);
            grpDatosMenu.Controls.Add(lblId);
            grpDatosMenu.Controls.Add(lblDescripcion);
            grpDatosMenu.Controls.Add(lblNombre);
            grpDatosMenu.Location = new Point(12, 47);
            grpDatosMenu.Name = "grpDatosMenu";
            grpDatosMenu.Size = new Size(751, 170);
            grpDatosMenu.TabIndex = 5;
            grpDatosMenu.TabStop = false;
            grpDatosMenu.Text = "Datos del menu";
            grpDatosMenu.Enter += groupBox1_Enter;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(519, 115);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(121, 23);
            cboEstado.TabIndex = 6;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(520, 66);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(120, 23);
            nudPrecio.TabIndex = 5;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(519, 30);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(121, 23);
            cboCategoria.TabIndex = 4;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(415, 118);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 8;
            lblEstado.Text = "Estado:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(415, 66);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(415, 26);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "Categoría:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(131, 110);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(165, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(131, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(165, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(109, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(165, 23);
            txtId.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(313, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(139, 15);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Mantenimiento de Menu";
            // 
            // pnlBotones
            // 
            pnlBotones.BorderStyle = BorderStyle.FixedSingle;
            pnlBotones.Controls.Add(btnLimpiar);
            pnlBotones.Controls.Add(btnEliminar);
            pnlBotones.Controls.Add(btnActualizar);
            pnlBotones.Controls.Add(btnAgregar);
            pnlBotones.Controls.Add(btnNuevo);
            pnlBotones.Location = new Point(12, 234);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(764, 83);
            pnlBotones.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(610, 25);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(466, 25);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(319, 25);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar ";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(186, 24);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(36, 24);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 323);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(764, 134);
            dataGridView1.TabIndex = 8;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(pnlBotones);
            Controls.Add(lblTitulo);
            Controls.Add(grpDatosMenu);
            Controls.Add(label5);
            Controls.Add(label4);
            Name = "Menu";
            grpDatosMenu.ResumeLayout(false);
            grpDatosMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNombre;
        private Label lblDescripcion;
        private Label label4;
        private Label label5;
        private GroupBox grpDatosMenu;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label lblTitulo;
        private Label lblEstado;
        private Label lblPrecio;
        private Label lblCategoria;
        private ComboBox cboEstado;
        private NumericUpDown nudPrecio;
        private ComboBox cboCategoria;
        private Panel pnlBotones;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private Button btnNuevo;
        private DataGridView dataGridView1;
    }
}