namespace ESFE.RestauranteBD.UI
{
    partial class FrmPago
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
            components = new System.ComponentModel.Container();
            lblFechaDePago = new Label();
            lblIdMetodo = new Label();
            lblTotal = new Label();
            lblIdPedido = new Label();
            lblIdPago = new Label();
            grbMetodo = new GroupBox();
            txtIdPago = new TextBox();
            txtIdPedido = new TextBox();
            txtIdMetodoPago = new TextBox();
            dtpFechaPago = new DateTimePicker();
            nudMonto = new NumericUpDown();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnBuscar = new Button();
            dgvPago = new DataGridView();
            grbMetodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPago).BeginInit();
            SuspendLayout();
            // 
            // lblFechaDePago
            // 
            lblFechaDePago.AutoSize = true;
            lblFechaDePago.Location = new Point(734, 179);
            lblFechaDePago.Margin = new Padding(6, 0, 6, 0);
            lblFechaDePago.Name = "lblFechaDePago";
            lblFechaDePago.Size = new Size(81, 32);
            lblFechaDePago.TabIndex = 0;
            lblFechaDePago.Text = "Fecha:";
            // 
            // lblIdMetodo
            // 
            lblIdMetodo.AutoSize = true;
            lblIdMetodo.Location = new Point(48, 288);
            lblIdMetodo.Margin = new Padding(6, 0, 6, 0);
            lblIdMetodo.Name = "lblIdMetodo";
            lblIdMetodo.Size = new Size(199, 32);
            lblIdMetodo.TabIndex = 1;
            lblIdMetodo.Text = "Metodo de pago:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(734, 98);
            lblTotal.Margin = new Padding(6, 0, 6, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(70, 32);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total:";
            lblTotal.Click += label4_Click;
            // 
            // lblIdPedido
            // 
            lblIdPedido.AutoSize = true;
            lblIdPedido.Location = new Point(28, 190);
            lblIdPedido.Margin = new Padding(6, 0, 6, 0);
            lblIdPedido.Name = "lblIdPedido";
            lblIdPedido.Size = new Size(92, 32);
            lblIdPedido.TabIndex = 4;
            lblIdPedido.Text = "Pedido:";
            // 
            // lblIdPago
            // 
            lblIdPago.AutoSize = true;
            lblIdPago.Location = new Point(28, 87);
            lblIdPago.Margin = new Padding(6, 0, 6, 0);
            lblIdPago.Name = "lblIdPago";
            lblIdPago.Size = new Size(71, 32);
            lblIdPago.TabIndex = 5;
            lblIdPago.Text = "Pago:";
            lblIdPago.Click += label1_Click;
            // 
            // grbMetodo
            // 
            grbMetodo.Controls.Add(txtIdPago);
            grbMetodo.Controls.Add(txtIdPedido);
            grbMetodo.Controls.Add(txtIdMetodoPago);
            grbMetodo.Controls.Add(dtpFechaPago);
            grbMetodo.Controls.Add(nudMonto);
            grbMetodo.Controls.Add(lblTotal);
            grbMetodo.Controls.Add(lblFechaDePago);
            grbMetodo.Controls.Add(lblIdPago);
            grbMetodo.Controls.Add(lblIdPedido);
            grbMetodo.Controls.Add(lblIdMetodo);
            grbMetodo.Location = new Point(80, 145);
            grbMetodo.Margin = new Padding(6);
            grbMetodo.Name = "grbMetodo";
            grbMetodo.Padding = new Padding(6);
            grbMetodo.Size = new Size(1326, 386);
            grbMetodo.TabIndex = 6;
            grbMetodo.TabStop = false;
            grbMetodo.Text = "Datos del Pago";
            grbMetodo.Enter += grbMetodo_Enter;
            // 
            // txtIdPago
            // 
            txtIdPago.Location = new Point(267, 70);
            txtIdPago.Margin = new Padding(6);
            txtIdPago.Name = "txtIdPago";
            txtIdPago.Size = new Size(182, 39);
            txtIdPago.TabIndex = 13;
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(267, 173);
            txtIdPedido.Margin = new Padding(6);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(182, 39);
            txtIdPedido.TabIndex = 12;
            // 
            // txtIdMetodoPago
            // 
            txtIdMetodoPago.Location = new Point(267, 271);
            txtIdMetodoPago.Margin = new Padding(6);
            txtIdMetodoPago.Name = "txtIdMetodoPago";
            txtIdMetodoPago.Size = new Size(182, 39);
            txtIdMetodoPago.TabIndex = 11;
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Checked = false;
            dtpFechaPago.Format = DateTimePickerFormat.Short;
            dtpFechaPago.Location = new Point(916, 177);
            dtpFechaPago.Margin = new Padding(6);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.RightToLeftLayout = true;
            dtpFechaPago.ShowCheckBox = true;
            dtpFechaPago.Size = new Size(368, 39);
            dtpFechaPago.TabIndex = 10;
            dtpFechaPago.ValueChanged += dtpFechaPago_ValueChanged;
            // 
            // nudMonto
            // 
            nudMonto.DecimalPlaces = 2;
            nudMonto.Location = new Point(969, 96);
            nudMonto.Margin = new Padding(6);
            nudMonto.Maximum = new decimal(new int[] { 999999, 0, 0, 131072 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(223, 39);
            nudMonto.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(1267, 544);
            btnLimpiar.Margin = new Padding(6);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(139, 49);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(843, 544);
            btnEliminar.Margin = new Padding(6);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 49);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(485, 544);
            btnAgregar.Margin = new Padding(6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(139, 49);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(108, 544);
            btnBuscar.Margin = new Padding(6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(139, 49);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvPago
            // 
            dgvPago.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPago.Location = new Point(22, 636);
            dgvPago.Margin = new Padding(6);
            dgvPago.Name = "dgvPago";
            dgvPago.RowHeadersWidth = 82;
            dgvPago.Size = new Size(1441, 299);
            dgvPago.TabIndex = 17;
            dgvPago.CellClick += dgvPago_CellClick;
            dgvPago.CellContentClick += dgvPago_CellClick;
            // 
            // FrmPago
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(dgvPago);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Controls.Add(grbMetodo);
            Margin = new Padding(6);
            Name = "FrmPago";
            Text = "Mantenimiento de pagos";
            Load += FrmPago_Load;
            grbMetodo.ResumeLayout(false);
            grbMetodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPago).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblFechaDePago;
        private Label lblIdMetodo;
        private Label lblTotal;
        private Label lblIdPedido;
        private Label lblIdPago;
        private GroupBox grbMetodo;
        private DateTimePicker dtpFechaPago;
        private NumericUpDown nudMonto;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnAgregar;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnBuscar;
        private DataGridView dgvPago;
        private TextBox txtIdPago;
        private TextBox txtIdPedido;
        private TextBox txtIdMetodoPago;
    }
}