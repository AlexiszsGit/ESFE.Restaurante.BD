namespace ESFE.RestauranteBD.UI
{
    partial class DetallePedidos
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
            label1 = new Label();
            label2 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePedidos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 232);
            label1.Name = "label1";
            label1.Size = new Size(140, 37);
            label1.TabIndex = 0;
            label1.Text = "ID Detalle:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 342);
            label2.Name = "label2";
            label2.Size = new Size(139, 37);
            label2.TabIndex = 1;
            label2.Text = "ID Pedido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(43, 455);
            label3.Name = "label3";
            label3.Size = new Size(131, 37);
            label3.TabIndex = 2;
            label3.Text = "Cantidad:";
            // 
            // txtIdDetalle
            // 
            txtIdDetalle.Location = new Point(209, 230);
            txtIdDetalle.Name = "txtIdDetalle";
            txtIdDetalle.Size = new Size(200, 39);
            txtIdDetalle.TabIndex = 3;
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(209, 340);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(200, 39);
            txtIdPedido.TabIndex = 4;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(209, 453);
            numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(240, 39);
            numCantidad.TabIndex = 5;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(79, 694);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 46);
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
            btmModificar.Location = new Point(392, 694);
            btmModificar.Name = "btmModificar";
            btmModificar.Size = new Size(150, 46);
            btmModificar.TabIndex = 7;
            btmModificar.Text = "Modificar";
            btmModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(232, 847);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 46);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgvDetallePedidos
            // 
            dgvDetallePedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetallePedidos.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgvDetallePedidos.BorderStyle = BorderStyle.None;
            dgvDetallePedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetallePedidos.Location = new Point(768, 104);
            dgvDetallePedidos.Name = "dgvDetallePedidos";
            dgvDetallePedidos.RowHeadersWidth = 82;
            dgvDetallePedidos.Size = new Size(1424, 984);
            dgvDetallePedidos.TabIndex = 9;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.ForeColor = Color.Cyan;
            lblNombreProducto.Location = new Point(431, 237);
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
            // DetallePedidos
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(2248, 1149);
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
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DetallePedidos";
            Text = "DetallePedidos";
            Load += DetallePedidos_Load;
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
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
    }
}