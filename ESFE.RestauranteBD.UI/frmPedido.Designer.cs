namespace ESFE.RestauranteBD.UI
{
    partial class FrmPedido
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
            grpDatos = new GroupBox();
            txtIdCliente = new TextBox();
            cboEstado = new ComboBox();
            dtpFecha = new DateTimePicker();
            cboMesa = new ComboBox();
            cboEmpleado = new ComboBox();
            txtIdPedido = new TextBox();
            lblEstado = new Label();
            lblFecha = new Label();
            lblIdMesa = new Label();
            lblIdEmpleado = new Label();
            lblIdCliente = new Label();
            lblIdPedido = new Label();
            dgvPedido = new DataGridView();
            label1 = new Label();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnBuscar = new Button();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).BeginInit();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(txtIdCliente);
            grpDatos.Controls.Add(cboEstado);
            grpDatos.Controls.Add(dtpFecha);
            grpDatos.Controls.Add(cboMesa);
            grpDatos.Controls.Add(cboEmpleado);
            grpDatos.Controls.Add(txtIdPedido);
            grpDatos.Controls.Add(lblEstado);
            grpDatos.Controls.Add(lblFecha);
            grpDatos.Controls.Add(lblIdMesa);
            grpDatos.Controls.Add(lblIdEmpleado);
            grpDatos.Controls.Add(lblIdCliente);
            grpDatos.Controls.Add(lblIdPedido);
            grpDatos.Location = new Point(12, 81);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(776, 215);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos ";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(112, 68);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(100, 23);
            txtIdCliente.TabIndex = 14;
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(560, 87);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(121, 23);
            cboEstado.TabIndex = 13;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(560, 33);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 11;
            // 
            // cboMesa
            // 
            cboMesa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMesa.FormattingEnabled = true;
            cboMesa.Location = new Point(102, 146);
            cboMesa.Name = "cboMesa";
            cboMesa.Size = new Size(121, 23);
            cboMesa.TabIndex = 10;
            // 
            // cboEmpleado
            // 
            cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpleado.FormattingEnabled = true;
            cboEmpleado.Location = new Point(102, 105);
            cboEmpleado.Name = "cboEmpleado";
            cboEmpleado.Size = new Size(121, 23);
            cboEmpleado.TabIndex = 9;
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(112, 33);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(100, 23);
            txtIdPedido.TabIndex = 7;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(495, 95);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado ";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(495, 36);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha:";
            // 
            // lblIdMesa
            // 
            lblIdMesa.AutoSize = true;
            lblIdMesa.Location = new Point(19, 146);
            lblIdMesa.Name = "lblIdMesa";
            lblIdMesa.Size = new Size(38, 15);
            lblIdMesa.TabIndex = 3;
            lblIdMesa.Text = "Mesa:";
            // 
            // lblIdEmpleado
            // 
            lblIdEmpleado.AutoSize = true;
            lblIdEmpleado.Location = new Point(19, 105);
            lblIdEmpleado.Name = "lblIdEmpleado";
            lblIdEmpleado.Size = new Size(63, 15);
            lblIdEmpleado.TabIndex = 2;
            lblIdEmpleado.Text = "Empleado:";
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Location = new Point(19, 68);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(47, 15);
            lblIdCliente.TabIndex = 1;
            lblIdCliente.Text = "Cliente:";
            // 
            // lblIdPedido
            // 
            lblIdPedido.AutoSize = true;
            lblIdPedido.Location = new Point(19, 36);
            lblIdPedido.Name = "lblIdPedido";
            lblIdPedido.Size = new Size(47, 15);
            lblIdPedido.TabIndex = 0;
            lblIdPedido.Text = "Pedido:";
            // 
            // dgvPedido
            // 
            dgvPedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedido.Location = new Point(31, 323);
            dgvPedido.Name = "dgvPedido";
            dgvPedido.Size = new Size(741, 115);
            dgvPedido.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 48);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(626, 285);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(482, 285);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(312, 284);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(114, 285);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 12;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Controls.Add(dgvPedido);
            Controls.Add(grpDatos);
            Name = "FrmPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedidos";
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpDatos;
        private Label lblEstado;
        private Label lblFecha;
        private Label lblIdMesa;
        private Label lblIdEmpleado;
        private Label lblIdCliente;
        private Label lblIdPedido;
        private TextBox txtId;
        private ComboBox cboEstado;
        private DateTimePicker dtpFecha;
        private ComboBox cboMesa;
        private ComboBox cboEmpleado;
        private DataGridView dgvPedido;
        private Label label1;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private Button btnBuscar;
        private TextBox txtIdCliente;
        private TextBox txtIdPedido;
    }
}