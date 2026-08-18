namespace ESFE.RestauranteBD.UI
{
    partial class frmPedido
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
            cboEstado = new ComboBox();
            nudTotal = new NumericUpDown();
            dtpFecha = new DateTimePicker();
            cboMesa = new ComboBox();
            cboEmpleado = new ComboBox();
            cboCliente = new ComboBox();
            txtId = new TextBox();
            lblEstado = new Label();
            lblTotal = new Label();
            lblFecha = new Label();
            lblMesa = new Label();
            lblEmpleado = new Label();
            lblCliente = new Label();
            lblId = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            btnNuevo = new Button();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(cboEstado);
            grpDatos.Controls.Add(nudTotal);
            grpDatos.Controls.Add(dtpFecha);
            grpDatos.Controls.Add(cboMesa);
            grpDatos.Controls.Add(cboEmpleado);
            grpDatos.Controls.Add(cboCliente);
            grpDatos.Controls.Add(txtId);
            grpDatos.Controls.Add(lblEstado);
            grpDatos.Controls.Add(lblTotal);
            grpDatos.Controls.Add(lblFecha);
            grpDatos.Controls.Add(lblMesa);
            grpDatos.Controls.Add(lblEmpleado);
            grpDatos.Controls.Add(lblCliente);
            grpDatos.Controls.Add(lblId);
            grpDatos.Location = new Point(12, 81);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(776, 215);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos ";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(566, 141);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(121, 23);
            cboEstado.TabIndex = 13;
            // 
            // nudTotal
            // 
            nudTotal.Location = new Point(580, 98);
            nudTotal.Name = "nudTotal";
            nudTotal.ReadOnly = true;
            nudTotal.Size = new Size(120, 23);
            nudTotal.TabIndex = 12;
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
            // cboCliente
            // 
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.FormattingEnabled = true;
            cboCliente.Location = new Point(102, 68);
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(121, 23);
            cboCliente.TabIndex = 8;
            // 
            // txtId
            // 
            txtId.Location = new Point(112, 33);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 7;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(495, 146);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(495, 93);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(33, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(495, 36);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha";
            // 
            // lblMesa
            // 
            lblMesa.AutoSize = true;
            lblMesa.Location = new Point(19, 146);
            lblMesa.Name = "lblMesa";
            lblMesa.Size = new Size(38, 15);
            lblMesa.TabIndex = 3;
            lblMesa.Text = "Mesa ";
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Location = new Point(19, 105);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(60, 15);
            lblEmpleado.TabIndex = 2;
            lblEmpleado.Text = "Empleado";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(19, 68);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(19, 36);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 323);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(741, 115);
            dataGridView1.TabIndex = 1;
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
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(482, 285);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(335, 285);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Actualizar ";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(202, 284);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(52, 284);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 12;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // frmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(btnNuevo);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(grpDatos);
            Name = "frmPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pedidos";
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpDatos;
        private Label lblEstado;
        private Label lblTotal;
        private Label lblFecha;
        private Label lblMesa;
        private Label lblEmpleado;
        private Label lblCliente;
        private Label lblId;
        private ComboBox cboCliente;
        private TextBox txtId;
        private ComboBox cboEstado;
        private NumericUpDown nudTotal;
        private DateTimePicker dtpFecha;
        private ComboBox cboMesa;
        private ComboBox cboEmpleado;
        private DataGridView dataGridView1;
        private Label label1;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private Button btnNuevo;
    }
}