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
            lblId = new Label();
            lblCliente = new Label();
            lblEmpleado = new Label();
            lblMesa = new Label();
            lblFecha = new Label();
            lblTotal = new Label();
            lblEstado = new Label();
            txtId = new TextBox();
            cboCliente = new ComboBox();
            cboEmpleado = new ComboBox();
            cboMesa = new ComboBox();
            dtpFecha = new DateTimePicker();
            nudTotal = new NumericUpDown();
            cboEstado = new ComboBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
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
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(19, 36);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
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
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Location = new Point(19, 105);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(60, 15);
            lblEmpleado.TabIndex = 2;
            lblEmpleado.Text = "Empleado";
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
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(495, 36);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha";
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
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(495, 146);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado ";
            // 
            // txtId
            // 
            txtId.Location = new Point(112, 33);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 7;
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
            // cboEmpleado
            // 
            cboEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEmpleado.FormattingEnabled = true;
            cboEmpleado.Location = new Point(102, 105);
            cboEmpleado.Name = "cboEmpleado";
            cboEmpleado.Size = new Size(121, 23);
            cboEmpleado.TabIndex = 9;
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
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(560, 33);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 11;
            // 
            // nudTotal
            // 
            nudTotal.Location = new Point(580, 98);
            nudTotal.Name = "nudTotal";
            nudTotal.ReadOnly = true;
            nudTotal.Size = new Size(120, 23);
            nudTotal.TabIndex = 12;
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
            // frmPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}