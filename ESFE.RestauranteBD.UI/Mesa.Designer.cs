namespace ESFE.RestauranteBD.UI
{
    partial class Mesa
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
            lblTitulo = new Label();
            lblNumero = new Label();
            lblCapacidad = new Label();
            lblEstado = new Label();
            txtNumeroMesa = new TextBox();
            nudCapacidad = new NumericUpDown();
            cmbEstado = new ComboBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(316, 32);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(191, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "MANTENIMIETO DE MESAS";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(186, 124);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(132, 20);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Numero de Mesas:";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.Location = new Point(186, 183);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(83, 20);
            lblCapacidad.TabIndex = 2;
            lblCapacidad.Text = "Capacidad:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(186, 238);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 20);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Estado:";
            // 
            // txtNumeroMesa
            // 
            txtNumeroMesa.Location = new Point(342, 124);
            txtNumeroMesa.Name = "txtNumeroMesa";
            txtNumeroMesa.Size = new Size(125, 27);
            txtNumeroMesa.TabIndex = 4;
            // 
            // nudCapacidad
            // 
            nudCapacidad.DecimalPlaces = 1;
            nudCapacidad.Location = new Point(342, 176);
            nudCapacidad.Name = "nudCapacidad";
            nudCapacidad.Size = new Size(150, 27);
            nudCapacidad.TabIndex = 5;
            nudCapacidad.ValueChanged += nudCapacidad_ValueChanged;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(342, 230);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(151, 28);
            cmbEstado.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(85, 393);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(201, 393);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(316, 393);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(429, 393);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Mesa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 480);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbEstado);
            Controls.Add(nudCapacidad);
            Controls.Add(txtNumeroMesa);
            Controls.Add(lblEstado);
            Controls.Add(lblCapacidad);
            Controls.Add(lblNumero);
            Controls.Add(lblTitulo);
            Name = "Mesa";
            Text = "Mesa";
            Load += Mesa_Load;
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNumero;
        private Label lblCapacidad;
        private Label lblEstado;
        private TextBox txtNumeroMesa;
        private NumericUpDown nudCapacidad;
        private ComboBox cmbEstado;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
    }
}