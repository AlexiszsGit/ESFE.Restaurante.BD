namespace ESFE.RestauranteBD.UI
{
    partial class FrmDetallePedidos
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
            lblIdDetalle = new Label();
            lblIdPedido = new Label();
            label3 = new Label();
            txtIdDetalle = new TextBox();
            txtIdPedido = new TextBox();
            numCantidad = new NumericUpDown();
            btnGuardar = new Button();
            btmModificar = new Button();
            btnEliminar = new Button();
            dgvDetallePedidos = new DataGridView();
            lblNombreProducto = new Label();
            label5 = new Label();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            btnLimpiar = new Button();
            txtIdProducto = new TextBox();
            lblIdProducto = new Label();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePedidos).BeginInit();
            SuspendLayout();
            // 
            // lblIdDetalle
            // 
            lblIdDetalle.AutoSize = true;
            lblIdDetalle.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdDetalle.ForeColor = Color.White;
            lblIdDetalle.Location = new Point(42, 255);
            lblIdDetalle.Name = "lblIdDetalle";
            lblIdDetalle.Size = new Size(140, 37);
            lblIdDetalle.TabIndex = 0;
            lblIdDetalle.Text = "ID Detalle:";
            lblIdDetalle.Click += label1_Click;
            // 
            // lblIdPedido
            // 
            lblIdPedido.AutoSize = true;
            lblIdPedido.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdPedido.ForeColor = Color.White;
            lblIdPedido.Location = new Point(43, 342);
            lblIdPedido.Name = "lblIdPedido";
            lblIdPedido.Size = new Size(139, 37);
            lblIdPedido.TabIndex = 1;
            lblIdPedido.Text = "ID Pedido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(42, 521);
            label3.Name = "label3";
            label3.Size = new Size(131, 37);
            label3.TabIndex = 2;
            label3.Text = "Cantidad:";
            // 
            // txtIdDetalle
            // 
            txtIdDetalle.Location = new Point(300, 260);
            txtIdDetalle.Name = "txtIdDetalle";
            txtIdDetalle.Size = new Size(200, 39);
            txtIdDetalle.TabIndex = 3;
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(300, 340);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(346, 39);
            txtIdPedido.TabIndex = 4;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(300, 519);
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(334, 39);
            numCantidad.TabIndex = 5;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(33, 953);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(132, 47);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btmModificar
            // 
            btmModificar.BackColor = Color.RoyalBlue;
            btmModificar.FlatAppearance.BorderSize = 0;
            btmModificar.FlatStyle = FlatStyle.Flat;
            btmModificar.ForeColor = Color.White;
            btmModificar.Location = new Point(181, 952);
            btmModificar.Name = "btmModificar";
            btmModificar.Size = new Size(132, 46);
            btmModificar.TabIndex = 7;
            btmModificar.Text = "Modificar";
            btmModificar.UseVisualStyleBackColor = false;
            btmModificar.Click += btmModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(332, 951);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(132, 49);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvDetallePedidos
            // 
            dgvDetallePedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetallePedidos.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgvDetallePedidos.BorderStyle = BorderStyle.None;
            dgvDetallePedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallePedidos.Location = new Point(783, 255);
            dgvDetallePedidos.Name = "dgvDetallePedidos";
            dgvDetallePedidos.RowHeadersWidth = 82;
            dgvDetallePedidos.Size = new Size(1409, 833);
            dgvDetallePedidos.TabIndex = 9;
            dgvDetallePedidos.CellClick += dgvDetallePedidos_CellClick;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.ForeColor = Color.Cyan;
            lblNombreProducto.Location = new Point(501, 260);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(273, 32);
            lblNombreProducto.TabIndex = 10;
            lblNombreProducto.Text = "[ Nombre del Producto ]";
            lblNombreProducto.Click += lblNombreProducto_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(34, 37);
            label5.Name = "label5";
            label5.Size = new Size(740, 50);
            label5.TabIndex = 11;
            label5.Text = "RESTAURANTEBD - DETALLE DE PEDIDOS";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Green;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ImageAlign = ContentAlignment.TopCenter;
            btnBuscar.Location = new Point(1770, 137);
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(146, 48);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(1111, 137);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar pedido";
            txtBuscar.Size = new Size(627, 48);
            txtBuscar.TabIndex = 19;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Purple;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(483, 951);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(132, 47);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(300, 428);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(346, 39);
            txtIdProducto.TabIndex = 23;
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdProducto.ForeColor = Color.White;
            lblIdProducto.Location = new Point(42, 430);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(164, 37);
            lblIdProducto.TabIndex = 25;
            lblIdProducto.Text = "ID Producto:";
            // 
            // FrmDetallePedidos
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(2248, 1149);
            Controls.Add(lblIdProducto);
            Controls.Add(txtIdProducto);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label5);
            Controls.Add(lblNombreProducto);
            Controls.Add(dgvDetallePedidos);
            Controls.Add(btnEliminar);
            Controls.Add(btmModificar);
            Controls.Add(btnGuardar);
            Controls.Add(numCantidad);
            Controls.Add(txtIdPedido);
            Controls.Add(txtIdDetalle);
            Controls.Add(label3);
            Controls.Add(lblIdPedido);
            Controls.Add(lblIdDetalle);
            Name = "FrmDetallePedidos";
            Text = "DetallePedidos";
            Load += DetallePedidos_Load;
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIdDetalle;
        private Label lblIdPedido;
        private Label label3;
        private TextBox txtIdDetalle;
        private TextBox txtIdPedido;
        private NumericUpDown numCantidad;
        private Button btnGuardar;
        private Button btmModificar;
        private Button btnEliminar;
        private DataGridView dgvDetallePedidos;
        private Label lblNombreProducto;
        private Label label5;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnLimpiar;
        private TextBox txtIdProducto;
        private Label lblIdProducto;
    }
}