namespace ESFE.RestauranteBD.UI
{
    partial class FrmMenu
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
            cbEstado = new ComboBox();
            numPrecio = new NumericUpDown();
            cbCategoria = new ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(68, 64);
            lblId.Margin = new Padding(5, 0, 5, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(39, 32);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(68, 141);
            lblNombre.Margin = new Padding(5, 0, 5, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(107, 32);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(68, 235);
            lblDescripcion.Margin = new Padding(5, 0, 5, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(143, 32);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(738, 499);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 32);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(752, 517);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 4;
            label5.Click += label5_Click;
            // 
            // grpDatosMenu
            // 
            grpDatosMenu.BackColor = SystemColors.ControlDarkDark;
            grpDatosMenu.Controls.Add(cbEstado);
            grpDatosMenu.Controls.Add(numPrecio);
            grpDatosMenu.Controls.Add(cbCategoria);
            grpDatosMenu.Controls.Add(lblEstado);
            grpDatosMenu.Controls.Add(lblPrecio);
            grpDatosMenu.Controls.Add(lblCategoria);
            grpDatosMenu.Controls.Add(txtDescripcion);
            grpDatosMenu.Controls.Add(txtNombre);
            grpDatosMenu.Controls.Add(txtId);
            grpDatosMenu.Controls.Add(lblId);
            grpDatosMenu.Controls.Add(lblDescripcion);
            grpDatosMenu.Controls.Add(lblNombre);
            grpDatosMenu.Location = new Point(23, 101);
            grpDatosMenu.Margin = new Padding(5, 6, 5, 6);
            grpDatosMenu.Name = "grpDatosMenu";
            grpDatosMenu.Padding = new Padding(5, 6, 5, 6);
            grpDatosMenu.Size = new Size(1394, 363);
            grpDatosMenu.TabIndex = 5;
            grpDatosMenu.TabStop = false;
            grpDatosMenu.Text = "Datos del menu";
            grpDatosMenu.Enter += groupBox1_Enter;
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Location = new Point(964, 245);
            cbEstado.Margin = new Padding(5, 6, 5, 6);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(222, 40);
            cbEstado.TabIndex = 6;
            // 
            // numPrecio
            // 
            numPrecio.Location = new Point(965, 141);
            numPrecio.Margin = new Padding(5, 6, 5, 6);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(223, 39);
            numPrecio.TabIndex = 5;
            numPrecio.ValueChanged += numPrecio_ValueChanged;
            // 
            // cbCategoria
            // 
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(964, 64);
            cbCategoria.Margin = new Padding(5, 6, 5, 6);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(222, 40);
            cbCategoria.TabIndex = 4;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(770, 251);
            lblEstado.Margin = new Padding(5, 0, 5, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(89, 32);
            lblEstado.TabIndex = 8;
            lblEstado.Text = "Estado:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(770, 141);
            lblPrecio.Margin = new Padding(5, 0, 5, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(84, 32);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "Precio:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(770, 56);
            lblCategoria.Margin = new Padding(5, 0, 5, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(121, 32);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "Categoría:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(244, 235);
            txtDescripcion.Margin = new Padding(5, 6, 5, 6);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(303, 39);
            txtDescripcion.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(244, 141);
            txtNombre.Margin = new Padding(5, 6, 5, 6);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(303, 39);
            txtNombre.TabIndex = 2;
            // 
            // txtId
            // 
            txtId.Location = new Point(203, 64);
            txtId.Margin = new Padding(5, 6, 5, 6);
            txtId.Name = "txtId";
            txtId.Size = new Size(303, 39);
            txtId.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(582, 18);
            lblTitulo.Margin = new Padding(5, 0, 5, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(283, 32);
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
            pnlBotones.Location = new Point(23, 499);
            pnlBotones.Margin = new Padding(5, 6, 5, 6);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(1417, 175);
            pnlBotones.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(1133, 53);
            btnLimpiar.Margin = new Padding(5, 6, 5, 6);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(140, 50);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(866, 53);
            btnEliminar.Margin = new Padding(5, 6, 5, 6);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 50);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(593, 53);
            btnActualizar.Margin = new Padding(5, 6, 5, 6);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(140, 50);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar ";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(346, 51);
            btnAgregar.Margin = new Padding(5, 6, 5, 6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(140, 50);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(67, 51);
            btnNuevo.Margin = new Padding(5, 6, 5, 6);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(140, 50);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 690);
            dataGridView1.Margin = new Padding(5, 6, 5, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1419, 286);
            dataGridView1.TabIndex = 8;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1485, 960);
            Controls.Add(dataGridView1);
            Controls.Add(pnlBotones);
            Controls.Add(lblTitulo);
            Controls.Add(grpDatosMenu);
            Controls.Add(label5);
            Controls.Add(label4);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmMenu";
            Load += FrmMenu_Load;
            grpDatosMenu.ResumeLayout(false);
            grpDatosMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
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
        private ComboBox cbEstado;
        private NumericUpDown numPrecio;
        private ComboBox cbCategoria;
        private Panel pnlBotones;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private Button btnNuevo;
        private DataGridView dataGridView1;
    }
}