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
            lblIdPedido = new Label();
            lblIdPostre = new Label();
            lblIdBebida = new Label();
            label4 = new Label();
            label5 = new Label();
            grpDatosMenu = new GroupBox();
            txtProducto = new TextBox();
            txtCategoria = new TextBox();
            lblIdCategoria = new Label();
            lblIdProducto = new Label();
            txtBebida = new TextBox();
            txtPostre = new TextBox();
            txtPedido = new TextBox();
            lblTitulo = new Label();
            pnlBotones = new Panel();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnBuscar = new Button();
            dgvMenu = new DataGridView();
            grpDatosMenu.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            SuspendLayout();
            // 
            // lblIdPedido
            // 
            lblIdPedido.AutoSize = true;
            lblIdPedido.BackColor = SystemColors.ControlDarkDark;
            lblIdPedido.ForeColor = SystemColors.ControlLightLight;
            lblIdPedido.Location = new Point(37, 30);
            lblIdPedido.Name = "lblIdPedido";
            lblIdPedido.Size = new Size(47, 15);
            lblIdPedido.TabIndex = 0;
            lblIdPedido.Text = "Pedido:";
            lblIdPedido.Click += lblId_Click;
            // 
            // lblIdPostre
            // 
            lblIdPostre.AutoSize = true;
            lblIdPostre.ForeColor = SystemColors.ControlLightLight;
            lblIdPostre.Location = new Point(37, 66);
            lblIdPostre.Name = "lblIdPostre";
            lblIdPostre.Size = new Size(43, 15);
            lblIdPostre.TabIndex = 1;
            lblIdPostre.Text = "Postre:";
            // 
            // lblIdBebida
            // 
            lblIdBebida.AutoSize = true;
            lblIdBebida.ForeColor = SystemColors.ControlLightLight;
            lblIdBebida.Location = new Point(37, 110);
            lblIdBebida.Name = "lblIdBebida";
            lblIdBebida.Size = new Size(46, 15);
            lblIdBebida.TabIndex = 2;
            lblIdBebida.Text = "Bebida:";
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
            grpDatosMenu.BackColor = SystemColors.ControlDarkDark;
            grpDatosMenu.Controls.Add(txtProducto);
            grpDatosMenu.Controls.Add(txtCategoria);
            grpDatosMenu.Controls.Add(lblIdCategoria);
            grpDatosMenu.Controls.Add(lblIdProducto);
            grpDatosMenu.Controls.Add(txtBebida);
            grpDatosMenu.Controls.Add(txtPostre);
            grpDatosMenu.Controls.Add(txtPedido);
            grpDatosMenu.Controls.Add(lblIdPedido);
            grpDatosMenu.Controls.Add(lblIdBebida);
            grpDatosMenu.Controls.Add(lblIdPostre);
            grpDatosMenu.Location = new Point(12, 47);
            grpDatosMenu.Name = "grpDatosMenu";
            grpDatosMenu.Size = new Size(751, 170);
            grpDatosMenu.TabIndex = 5;
            grpDatosMenu.TabStop = false;
            grpDatosMenu.Text = "Datos del menu";
            grpDatosMenu.Enter += groupBox1_Enter;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(503, 27);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(165, 23);
            txtProducto.TabIndex = 9;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(503, 66);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(165, 23);
            txtCategoria.TabIndex = 8;
            // 
            // lblIdCategoria
            // 
            lblIdCategoria.AutoSize = true;
            lblIdCategoria.ForeColor = SystemColors.ControlLightLight;
            lblIdCategoria.Location = new Point(415, 66);
            lblIdCategoria.Name = "lblIdCategoria";
            lblIdCategoria.Size = new Size(61, 15);
            lblIdCategoria.TabIndex = 7;
            lblIdCategoria.Text = "Categoria ";
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.ForeColor = SystemColors.ControlLightLight;
            lblIdProducto.Location = new Point(415, 26);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(59, 15);
            lblIdProducto.TabIndex = 6;
            lblIdProducto.Text = "Producto:";
            // 
            // txtBebida
            // 
            txtBebida.Location = new Point(131, 110);
            txtBebida.Name = "txtBebida";
            txtBebida.Size = new Size(165, 23);
            txtBebida.TabIndex = 3;
            // 
            // txtPostre
            // 
            txtPostre.Location = new Point(131, 66);
            txtPostre.Name = "txtPostre";
            txtPostre.Size = new Size(165, 23);
            txtPostre.TabIndex = 2;
            // 
            // txtPedido
            // 
            txtPedido.Location = new Point(109, 30);
            txtPedido.Multiline = true;
            txtPedido.Name = "txtPedido";
            txtPedido.Size = new Size(165, 23);
            txtPedido.TabIndex = 1;
            txtPedido.TextChanged += txtId_TextChanged;
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
            pnlBotones.Controls.Add(btnAgregar);
            pnlBotones.Controls.Add(btnBuscar);
            pnlBotones.Location = new Point(12, 234);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(764, 83);
            pnlBotones.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(574, 25);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(414, 25);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(52, 25);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(237, 25);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvMenu
            // 
            dgvMenu.AllowUserToAddRows = false;
            dgvMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Location = new Point(12, 323);
            dgvMenu.Name = "dgvMenu";
            dgvMenu.ReadOnly = true;
            dgvMenu.RowHeadersWidth = 51;
            dgvMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenu.Size = new Size(764, 134);
            dgvMenu.TabIndex = 8;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvMenu);
            Controls.Add(pnlBotones);
            Controls.Add(lblTitulo);
            Controls.Add(grpDatosMenu);
            Controls.Add(label5);
            Controls.Add(label4);
            Name = "FrmMenu";
            grpDatosMenu.ResumeLayout(false);
            grpDatosMenu.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdPedido;
        private Label lblIdPostre;
        private Label lblIdBebida;
        private Label label4;
        private Label label5;
        private GroupBox grpDatosMenu;
        private TextBox txtBebida;
        private TextBox txtPostre;
        private TextBox txtPedido;
        private Label lblTitulo;
        private Label lblIdCategoria;
        private Label lblIdProducto;
        private Panel pnlBotones;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnAgregar;
        private Button btnBuscar;
        private DataGridView dgvMenu;
        private TextBox txtProducto;
        private TextBox txtCategoria;
    }
}