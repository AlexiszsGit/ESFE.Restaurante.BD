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
            lblFechaDePago.Location = new Point(395, 84);
            lblFechaDePago.Name = "lblFechaDePago";
            lblFechaDePago.Size = new Size(41, 15);
            lblFechaDePago.TabIndex = 0;
            lblFechaDePago.Text = "Fecha:";
            // 
            // lblIdMetodo
            // 
            lblIdMetodo.AutoSize = true;
            lblIdMetodo.Location = new Point(26, 135);
            lblIdMetodo.Name = "lblIdMetodo";
            lblIdMetodo.Size = new Size(98, 15);
            lblIdMetodo.TabIndex = 1;
            lblIdMetodo.Text = "Metodo de pago:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(395, 46);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(36, 15);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total:";
            lblTotal.Click += label4_Click;
            // 
            // lblIdPedido
            // 
            lblIdPedido.AutoSize = true;
            lblIdPedido.Location = new Point(15, 89);
            lblIdPedido.Name = "lblIdPedido";
            lblIdPedido.Size = new Size(47, 15);
            lblIdPedido.TabIndex = 4;
            lblIdPedido.Text = "Pedido:";
            // 
            // lblIdPago
            // 
            lblIdPago.AutoSize = true;
            lblIdPago.Location = new Point(15, 41);
            lblIdPago.Name = "lblIdPago";
            lblIdPago.Size = new Size(37, 15);
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
            grbMetodo.Location = new Point(43, 68);
            grbMetodo.Name = "grbMetodo";
            grbMetodo.Size = new Size(714, 181);
            grbMetodo.TabIndex = 6;
            grbMetodo.TabStop = false;
            grbMetodo.Text = "Datos del Pago";
            // 
            // txtIdPago
            // 
            txtIdPago.Location = new Point(144, 33);
            txtIdPago.Name = "txtIdPago";
            txtIdPago.Size = new Size(100, 23);
            txtIdPago.TabIndex = 13;
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(144, 81);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(100, 23);
            txtIdPedido.TabIndex = 12;
            // 
            // txtIdMetodoPago
            // 
            txtIdMetodoPago.Location = new Point(144, 127);
            txtIdMetodoPago.Name = "txtIdMetodoPago";
            txtIdMetodoPago.Size = new Size(100, 23);
            txtIdMetodoPago.TabIndex = 11;
            // 
            // dtpFechaPago
            // 
            dtpFechaPago.Checked = false;
            dtpFechaPago.Format = DateTimePickerFormat.Short;
            dtpFechaPago.Location = new Point(493, 83);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.RightToLeftLayout = true;
            dtpFechaPago.ShowCheckBox = true;
            dtpFechaPago.Size = new Size(200, 23);
            dtpFechaPago.TabIndex = 10;
            dtpFechaPago.ValueChanged += dtpFechaPago_ValueChanged;
            // 
            // nudMonto
            // 
            nudMonto.DecimalPlaces = 2;
            nudMonto.Location = new Point(522, 45);
            nudMonto.Maximum = new decimal(new int[] { 999999, 0, 0, 131072 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(120, 23);
            nudMonto.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(682, 255);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(454, 255);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(261, 255);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(58, 255);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgvPago
            // 
            dgvPago.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPago.Location = new Point(12, 298);
            dgvPago.Name = "dgvPago";
            dgvPago.Size = new Size(776, 140);
            dgvPago.TabIndex = 17;
            // 
            // FrmPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPago);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Controls.Add(grbMetodo);
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