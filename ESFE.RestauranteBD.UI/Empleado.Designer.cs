namespace ESFE.RestauranteBD.UI
{
    partial class Empleado
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
            lblNombre = new Label();
            lblApellido = new Label();
            lblTelefono = new Label();
            lblTipo = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            cmbTipo = new ComboBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(481, 54);
            lblTitulo.Margin = new Padding(5, 0, 5, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(286, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTION DE EMPLEADOS";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(159, 192);
            lblNombre.Margin = new Padding(5, 0, 5, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(107, 32);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(728, 192);
            lblApellido.Margin = new Padding(5, 0, 5, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(107, 32);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(159, 408);
            lblTelefono.Margin = new Padding(5, 0, 5, 0);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(112, 32);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(728, 408);
            lblTipo.Margin = new Padding(5, 0, 5, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(179, 32);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo Empleado:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(422, 181);
            txtNombre.Margin = new Padding(5, 5, 5, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(201, 39);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(1009, 181);
            txtApellido.Margin = new Padding(5, 5, 5, 5);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(201, 39);
            txtApellido.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(422, 397);
            txtTelefono.Margin = new Padding(5, 5, 5, 5);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(201, 39);
            txtTelefono.TabIndex = 6;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(1009, 397);
            cmbTipo.Margin = new Padding(5, 5, 5, 5);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(243, 40);
            cmbTipo.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(159, 626);
            btnGuardar.Margin = new Padding(5, 5, 5, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(153, 46);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(390, 626);
            btnModificar.Margin = new Padding(5, 5, 5, 5);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(153, 46);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(590, 626);
            btnEliminar.Margin = new Padding(5, 5, 5, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(153, 46);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(812, 626);
            btnLimpiar.Margin = new Padding(5, 5, 5, 5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(153, 46);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // Empleado
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2073, 1366);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(cmbTipo);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblTipo);
            Controls.Add(lblTelefono);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Empleado";
            Text = "Empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblTelefono;
        private Label lblTipo;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private ComboBox cmbTipo;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnLimpiar;
    }
}