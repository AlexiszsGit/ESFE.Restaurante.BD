namespace ESFE.RestauranteBD.UI
{
    partial class FrmEmpleado
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
            btnLimpiar = new Button();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btmModificar = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Gold;
            lblTitulo.Location = new Point(296, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(239, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTION DE EMPLEADOS";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(98, 120);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = SystemColors.ActiveCaptionText;
            lblApellido.ForeColor = Color.White;
            lblApellido.Location = new Point(448, 120);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.ForeColor = Color.White;
            lblTelefono.Location = new Point(98, 255);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.ForeColor = Color.White;
            lblTipo.Location = new Point(448, 255);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(114, 20);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo Empleado:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(260, 113);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(621, 113);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(260, 248);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 6;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(128, 128, 255);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(448, 401);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(621, 248);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(769, 252);
            button1.Name = "button1";
            button1.Size = new Size(40, 26);
            button1.TabIndex = 0;
            button1.Text = "....";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(320, 401);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(92, 29);
            button2.TabIndex = 20;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            // 
            // btmModificar
            // 
            btmModificar.BackColor = Color.RoyalBlue;
            btmModificar.FlatAppearance.BorderSize = 0;
            btmModificar.FlatStyle = FlatStyle.Flat;
            btmModificar.ForeColor = Color.White;
            btmModificar.Location = new Point(196, 401);
            btmModificar.Margin = new Padding(2);
            btmModificar.Name = "btmModificar";
            btmModificar.Size = new Size(92, 29);
            btmModificar.TabIndex = 19;
            btmModificar.Text = "Modificar";
            btmModificar.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.ForestGreen;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(76, 401);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(92, 29);
            button3.TabIndex = 18;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = false;
            // 
            // FrmEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1184, 659);
            Controls.Add(button2);
            Controls.Add(btmModificar);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(btnLimpiar);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblTipo);
            Controls.Add(lblTelefono);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "FrmEmpleado";
            Text = "Empleado";
            Load += Empleado_Load;
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
        private Button btnLimpiar;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button btmModificar;
        private Button button3;
    }
}