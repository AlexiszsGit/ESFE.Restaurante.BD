namespace ESFE.RestauranteBD.UI
{
    partial class Cliente
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
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            dgvClientes = new DataGridView();
            txtTelefono = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 82);
            label1.Name = "label1";
            label1.Size = new Size(124, 32);
            label1.TabIndex = 0;
            label1.Text = "ID Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 182);
            label2.Name = "label2";
            label2.Size = new Size(219, 32);
            label2.TabIndex = 1;
            label2.Text = "Nombre Completo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 296);
            label3.Name = "label3";
            label3.Size = new Size(112, 32);
            label3.TabIndex = 2;
            label3.Text = "Telefono:";
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(329, 82);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(200, 39);
            txtIdCliente.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(329, 182);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 39);
            txtNombre.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(92, 416);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 46);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(329, 416);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 46);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(207, 528);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 46);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(631, 104);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 82;
            dgvClientes.Size = new Size(1490, 1020);
            dgvClientes.TabIndex = 9;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(329, 296);
            txtTelefono.Mask = "0000-0000";
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(200, 39);
            txtTelefono.TabIndex = 10;
            txtTelefono.MaskInputRejected += txtTelefono_MaskInputRejected;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2226, 1231);
            Controls.Add(txtTelefono);
            Controls.Add(dgvClientes);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(txtIdCliente);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cliente";
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
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dgvClientes;
        private MaskedTextBox txtTelefono;
    }
}