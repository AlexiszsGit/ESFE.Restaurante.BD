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
            lblFechaDePago = new Label();
            lblMetodoPago = new Label();
            lblEstado = new Label();
            lblMonto = new Label();
            lblPedido = new Label();
            lblId = new Label();
            grbMetodo = new GroupBox();
            txtId = new TextBox();
            cboMetodoPago = new ComboBox();
            cboPedido = new ComboBox();
            nudMonto = new NumericUpDown();
            dtpFechaPago = new DateTimePicker();
            cboEstado = new ComboBox();
            grbMetodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
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
            // lblMetodoPago
            // 
            lblMetodoPago.AutoSize = true;
            lblMetodoPago.Location = new Point(26, 135);
            lblMetodoPago.Name = "lblMetodoPago";
            lblMetodoPago.Size = new Size(98, 15);
            lblMetodoPago.TabIndex = 1;
            lblMetodoPago.Text = "Metodo de pago ";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(395, 135);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "Estado:";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(395, 46);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(52, 15);
            lblMonto.TabIndex = 3;
            lblMonto.Text = "Monto$:";
            lblMonto.Click += label4_Click;
            // 
            // lblPedido
            // 
            lblPedido.AutoSize = true;
            lblPedido.Location = new Point(15, 89);
            lblPedido.Name = "lblPedido";
            lblPedido.Size = new Size(47, 15);
            lblPedido.TabIndex = 4;
            lblPedido.Text = "Pedido:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(15, 41);
            lblId.Name = "lblId";
            lblId.Size = new Size(20, 15);
            lblId.TabIndex = 5;
            lblId.Text = "Id:";
            lblId.Click += label1_Click;
            // 
            // grbMetodo
            // 
            grbMetodo.Controls.Add(cboEstado);
            grbMetodo.Controls.Add(dtpFechaPago);
            grbMetodo.Controls.Add(nudMonto);
            grbMetodo.Controls.Add(cboPedido);
            grbMetodo.Controls.Add(lblEstado);
            grbMetodo.Controls.Add(lblMonto);
            grbMetodo.Controls.Add(lblFechaDePago);
            grbMetodo.Controls.Add(cboMetodoPago);
            grbMetodo.Controls.Add(txtId);
            grbMetodo.Controls.Add(lblId);
            grbMetodo.Controls.Add(lblPedido);
            grbMetodo.Controls.Add(lblMetodoPago);
            grbMetodo.Location = new Point(43, 68);
            grbMetodo.Name = "grbMetodo";
            grbMetodo.Size = new Size(714, 224);
            grbMetodo.TabIndex = 6;
            grbMetodo.TabStop = false;
            grbMetodo.Text = "Datos del Pago";
            // 
            // txtId
            // 
            txtId.Location = new Point(172, 38);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 6;
            // 
            // cboMetodoPago
            // 
            cboMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMetodoPago.FormattingEnabled = true;
            cboMetodoPago.Location = new Point(172, 127);
            cboMetodoPago.Name = "cboMetodoPago";
            cboMetodoPago.Size = new Size(121, 23);
            cboMetodoPago.TabIndex = 7;
            // 
            // cboPedido
            // 
            cboPedido.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPedido.FormattingEnabled = true;
            cboPedido.Location = new Point(172, 81);
            cboPedido.Name = "cboPedido";
            cboPedido.Size = new Size(121, 23);
            cboPedido.TabIndex = 8;
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
            // dtpFechaPago
            // 
            dtpFechaPago.Format = DateTimePickerFormat.Short;
            dtpFechaPago.Location = new Point(493, 83);
            dtpFechaPago.Name = "dtpFechaPago";
            dtpFechaPago.RightToLeftLayout = true;
            dtpFechaPago.Size = new Size(200, 23);
            dtpFechaPago.TabIndex = 10;
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(507, 137);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(121, 23);
            cboEstado.TabIndex = 11;
            // 
            // FrmPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grbMetodo);
            Name = "FrmPago";
            Text = "Mantenimiento de pagos";
            Load += FrmPago_Load;
            grbMetodo.ResumeLayout(false);
            grbMetodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblFechaDePago;
        private Label lblMetodoPago;
        private Label lblEstado;
        private Label lblMonto;
        private Label lblPedido;
        private Label lblId;
        private GroupBox grbMetodo;
        private TextBox txtId;
        private ComboBox cboPedido;
        private ComboBox cboMetodoPago;
        private ComboBox cboEstado;
        private DateTimePicker dtpFechaPago;
        private NumericUpDown nudMonto;
    }
}