namespace ESFE.RestauranteBD.UI
{
    partial class frmReserva
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
            lbldReserva = new Label();
            lblFecha = new Label();
            lblNombre = new Label();
            lblIdCliente = new Label();
            lblPersonas = new Label();
            lblIdMesa = new Label();
            txtIdReserva = new TextBox();
            dtpFecha = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            txtMesa = new TextBox();
            txtIdcliente = new TextBox();
            dataGridView1 = new DataGridView();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            btnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbldReserva
            // 
            lbldReserva.AutoSize = true;
            lbldReserva.Location = new Point(28, 33);
            lbldReserva.Name = "lbldReserva";
            lbldReserva.Size = new Size(50, 15);
            lbldReserva.TabIndex = 0;
            lbldReserva.Text = "Reserva:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(28, 73);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(41, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(28, 120);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(36, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Hora:";
            // 
            // lblIdCliente
            // 
            lblIdCliente.AutoSize = true;
            lblIdCliente.Location = new Point(463, 73);
            lblIdCliente.Name = "lblIdCliente";
            lblIdCliente.Size = new Size(47, 15);
            lblIdCliente.TabIndex = 3;
            lblIdCliente.Text = "Cliente:";
            // 
            // lblPersonas
            // 
            lblPersonas.AutoSize = true;
            lblPersonas.Location = new Point(463, 33);
            lblPersonas.Name = "lblPersonas";
            lblPersonas.Size = new Size(57, 15);
            lblPersonas.TabIndex = 4;
            lblPersonas.Text = "Personas:";
            // 
            // lblIdMesa
            // 
            lblIdMesa.AutoSize = true;
            lblIdMesa.Location = new Point(462, 120);
            lblIdMesa.Name = "lblIdMesa";
            lblIdMesa.Size = new Size(38, 15);
            lblIdMesa.TabIndex = 5;
            lblIdMesa.Text = "Mesa:";
            // 
            // txtIdReserva
            // 
            txtIdReserva.Location = new Point(122, 30);
            txtIdReserva.Name = "txtIdReserva";
            txtIdReserva.Size = new Size(100, 23);
            txtIdReserva.TabIndex = 6;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(91, 73);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(148, 23);
            dtpFecha.TabIndex = 7;
            dtpFecha.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(91, 114);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(89, 23);
            dateTimePicker2.TabIndex = 8;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(542, 31);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(116, 23);
            numericUpDown1.TabIndex = 9;
            // 
            // txtMesa
            // 
            txtMesa.Location = new Point(542, 120);
            txtMesa.Name = "txtMesa";
            txtMesa.Size = new Size(100, 23);
            txtMesa.TabIndex = 10;
            // 
            // txtIdcliente
            // 
            txtIdcliente.Location = new Point(542, 73);
            txtIdcliente.Name = "txtIdcliente";
            txtIdcliente.Size = new Size(100, 23);
            txtIdcliente.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(64, 247);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(670, 166);
            dataGridView1.TabIndex = 12;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(638, 180);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(494, 180);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(347, 180);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 19;
            btnActualizar.Text = "Actualizar ";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(214, 179);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(64, 179);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 17;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // frmReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(btnNuevo);
            Controls.Add(dataGridView1);
            Controls.Add(txtIdcliente);
            Controls.Add(txtMesa);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dtpFecha);
            Controls.Add(txtIdReserva);
            Controls.Add(lblIdMesa);
            Controls.Add(lblPersonas);
            Controls.Add(lblIdCliente);
            Controls.Add(lblNombre);
            Controls.Add(lblFecha);
            Controls.Add(lbldReserva);
            Name = "frmReserva";
            Text = "Reserva";
            Load += frmReserva_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbldReserva;
        private Label lblFecha;
        private Label lblNombre;
        private Label lblIdCliente;
        private Label lblPersonas;
        private Label lblIdMesa;
        private TextBox txtIdReserva;
        private DateTimePicker dtpFecha;
        private DateTimePicker dateTimePicker2;
        private NumericUpDown numericUpDown1;
        private TextBox txtMesa;
        private TextBox txtIdcliente;
        private DataGridView dataGridView1;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnActualizar;
        private Button btnAgregar;
        private Button btnNuevo;
    }
}