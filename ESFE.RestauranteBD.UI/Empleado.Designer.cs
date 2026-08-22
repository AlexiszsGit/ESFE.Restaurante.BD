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
            lblTipo = new Label();
            txtNombre = new TextBox();
            btnLimpiar = new Button();
            txtTipoEmpleado = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btmModificar = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            lblIdEmpleado = new Label();
            txtIdEmpleado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.ForeColor = Color.White;
            lblTipo.Location = new Point(98, 216);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(114, 20);
            lblTipo.TabIndex = 4;
            lblTipo.Text = "Tipo Empleado:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(236, 120);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(354, 27);
            txtNombre.TabIndex = 5;
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
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtTipoEmpleado
            // 
            txtTipoEmpleado.Location = new Point(236, 209);
            txtTipoEmpleado.Name = "txtTipoEmpleado";
            txtTipoEmpleado.Size = new Size(176, 27);
            txtTipoEmpleado.TabIndex = 13;
            // 
            // button1
            // 
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(436, 213);
            button1.Name = "button1";
            button1.Size = new Size(40, 26);
            button1.TabIndex = 0;
            button1.Text = "....";
            button1.UseVisualStyleBackColor = true;
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
            button2.Click += btnEliminar_Click;
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
            btmModificar.Click += btnModificar_Click;
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
            button3.Click += btnGuardar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(632, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(520, 332);
            dataGridView1.TabIndex = 21;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // lblIdEmpleado
            // 
            lblIdEmpleado.AutoSize = true;
            lblIdEmpleado.ForeColor = Color.White;
            lblIdEmpleado.Location = new Point(98, 299);
            lblIdEmpleado.Name = "lblIdEmpleado";
            lblIdEmpleado.Size = new Size(94, 20);
            lblIdEmpleado.TabIndex = 22;
            lblIdEmpleado.Text = "Id Empleado";
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.Location = new Point(236, 292);
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.Size = new Size(176, 27);
            txtIdEmpleado.TabIndex = 23;
            // 
            // FrmEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1184, 518);
            Controls.Add(txtIdEmpleado);
            Controls.Add(lblIdEmpleado);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(btmModificar);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(txtTipoEmpleado);
            Controls.Add(btnLimpiar);
            Controls.Add(txtNombre);
            Controls.Add(lblTipo);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "FrmEmpleado";
            Text = "Empleado";
            
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblTipo;
        private TextBox txtNombre;
        private Button btnLimpiar;
        private TextBox txtTipoEmpleado;
        private Button button1;
        private Button button2;
        private Button btmModificar;
        private Button button3;
        private DataGridView dataGridView1;
        private Label lblIdEmpleado;
        private TextBox txtIdEmpleado;
    }
}