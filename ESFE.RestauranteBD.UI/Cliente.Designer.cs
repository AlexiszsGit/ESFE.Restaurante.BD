namespace ESFE.RestauranteBD.UI
{
    partial class FrmCliente
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
            txtIdCliente = new TextBox();
            txtNombre = new TextBox();
            dgvClientes = new DataGridView();
            txtTelefono = new MaskedTextBox();
            btnEliminar = new Button();
            btmModificar = new Button();
            btnGuardar = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(82, 270);
            label1.Name = "label1";
            label1.Size = new Size(139, 37);
            label1.TabIndex = 0;
            label1.Text = "ID Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(82, 370);
            label2.Name = "label2";
            label2.Size = new Size(246, 37);
            label2.TabIndex = 1;
            label2.Text = "Nombre Completo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(82, 484);
            label3.Name = "label3";
            label3.Size = new Size(124, 37);
            label3.TabIndex = 2;
            label3.Text = "Telefono:";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(345, 268);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(200, 39);
            txtIdCliente.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(345, 368);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 39);
            txtNombre.TabIndex = 4;
            // 
            // dgvClientes
            // 
            dgvClientes.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(631, 104);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 82;
            dgvClientes.Size = new Size(1490, 1020);
            dgvClientes.TabIndex = 9;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(345, 482);
            txtTelefono.Mask = "0000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 39);
            txtTelefono.TabIndex = 10;
            txtTelefono.MaskInputRejected += txtTelefono_MaskInputRejected;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(225, 774);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 46);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btmModificar
            // 
            btmModificar.BackColor = Color.RoyalBlue;
            btmModificar.FlatAppearance.BorderSize = 0;
            btmModificar.FlatStyle = FlatStyle.Flat;
            btmModificar.ForeColor = Color.White;
            btmModificar.Location = new Point(384, 655);
            btmModificar.Name = "btmModificar";
            btmModificar.Size = new Size(150, 46);
            btmModificar.TabIndex = 13;
            btmModificar.Text = "Modificar";
            btmModificar.UseVisualStyleBackColor = false;
            btmModificar.Click += btmModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(71, 655);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 46);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(50, 59);
            label5.Name = "label5";
            label5.Size = new Size(510, 50);
            label5.TabIndex = 15;
            label5.Text = "RESTAURANTEBD - CLIENTE";
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(2226, 1231);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(btmModificar);
            Controls.Add(btnGuardar);
            Controls.Add(txtTelefono);
            Controls.Add(dgvClientes);
            Controls.Add(txtNombre);
            Controls.Add(txtIdCliente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCliente";
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIdCliente;
        private TextBox txtNombre;
        private DataGridView dgvClientes;
        private MaskedTextBox txtTelefono;
        private Button btnEliminar;
        private Button btmModificar;
        private Button btnGuardar;
        private Label label5;
    }
}