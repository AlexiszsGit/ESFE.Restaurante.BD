namespace ESFE.RestauranteBD.UI
{
    partial class FrmTipoEmpleado
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
            lblIdTipo = new Label();
            txtNombre = new TextBox();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            btmModificar = new Button();
            button3 = new Button();
            button1 = new Button();
            txtIdTipo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Black;
            lblTitulo.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Gold;
            lblTitulo.Location = new Point(138, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(320, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTION DE TIPOS DE EMPLEADO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.ActiveCaptionText;
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(166, 133);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblIdTipo
            // 
            lblIdTipo.AutoSize = true;
            lblIdTipo.BackColor = SystemColors.ActiveCaptionText;
            lblIdTipo.ForeColor = Color.White;
            lblIdTipo.Location = new Point(166, 215);
            lblIdTipo.Name = "lblIdTipo";
            lblIdTipo.Size = new Size(56, 20);
            lblIdTipo.TabIndex = 2;
            lblIdTipo.Text = "Id Tipo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(319, 126);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(552, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(578, 439);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(287, 432);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(92, 29);
            button2.TabIndex = 24;
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
            btmModificar.Location = new Point(183, 432);
            btmModificar.Margin = new Padding(2);
            btmModificar.Name = "btmModificar";
            btmModificar.Size = new Size(92, 29);
            btmModificar.TabIndex = 23;
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
            button3.Location = new Point(77, 432);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(92, 29);
            button3.TabIndex = 22;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += btnGuardar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(390, 432);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 21;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnLimpiar_Click;
            // 
            // txtIdTipo
            // 
            txtIdTipo.Location = new Point(319, 208);
            txtIdTipo.Name = "txtIdTipo";
            txtIdTipo.Size = new Size(125, 27);
            txtIdTipo.TabIndex = 25;
            // 
            // FrmTipoEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1184, 619);
            Controls.Add(txtIdTipo);
            Controls.Add(button2);
            Controls.Add(btmModificar);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtNombre);
            Controls.Add(lblIdTipo);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "FrmTipoEmpleado";
            Text = "Tipo_empleado";
            Load += FrmTipoEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblIdTipo;
        private TextBox txtNombre;
        private DataGridView dataGridView1;
        private Button button2;
        private Button btmModificar;
        private Button button3;
        private Button button1;
        private TextBox txtIdTipo;
    }
}