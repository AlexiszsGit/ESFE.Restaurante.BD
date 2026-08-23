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
            lblTitulo1 = new Label();
            lblNombre = new Label();
            lblIdTipo = new Label();
            txtNombre = new TextBox();
            dgvTipoEmpleado = new DataGridView();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            txtIdTipo = new TextBox();
            lblTitulo1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTipoEmpleado).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo1
            // 
            lblTitulo1.AutoSize = true;
            lblTitulo1.BackColor = Color.Black;
            lblTitulo1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo1.ForeColor = Color.Gold;
            lblTitulo1.Location = new Point(12, 59);
            lblTitulo1.Margin = new Padding(5, 0, 5, 0);
            lblTitulo1.Name = "lblTitulo1";
            lblTitulo1.Size = new Size(557, 37);
            lblTitulo1.TabIndex = 0;
            lblTitulo1 .Text = "GESTION DE TIPOS DE EMPLEADO";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.ActiveCaptionText;
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(270, 213);
            lblNombre.Margin = new Padding(5, 0, 5, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(107, 32);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblIdTipo
            // 
            lblIdTipo.AutoSize = true;
            lblIdTipo.BackColor = SystemColors.ActiveCaptionText;
            lblIdTipo.ForeColor = Color.White;
            lblIdTipo.Location = new Point(270, 344);
            lblIdTipo.Margin = new Padding(5, 0, 5, 0);
            lblIdTipo.Name = "lblIdTipo";
            lblIdTipo.Size = new Size(88, 32);
            lblIdTipo.TabIndex = 2;
            lblIdTipo.Text = "Id Tipo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(518, 202);
            txtNombre.Margin = new Padding(5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(201, 39);
            txtNombre.TabIndex = 3;
            // 
            // dgvTipoEmpleado
            // 
            dgvTipoEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTipoEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoEmpleado.Location = new Point(897, 78);
            dgvTipoEmpleado.Margin = new Padding(5);
            dgvTipoEmpleado.Name = "dgvTipoEmpleado";
            dgvTipoEmpleado.RowHeadersWidth = 51;
            dgvTipoEmpleado.Size = new Size(939, 702);
            dgvTipoEmpleado.TabIndex = 9;
            dgvTipoEmpleado.CellClick += dataGridView1_CellClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(466, 691);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 46);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.RoyalBlue;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(297, 691);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 46);
            btnModificar.TabIndex = 23;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(125, 691);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 46);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(128, 128, 255);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(634, 691);
            btnLimpiar.Margin = new Padding(5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(153, 46);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtIdTipo
            // 
            txtIdTipo.Location = new Point(518, 333);
            txtIdTipo.Margin = new Padding(5);
            txtIdTipo.Name = "txtIdTipo";
            txtIdTipo.Size = new Size(201, 39);
            txtIdTipo.TabIndex = 25;
            // 
            // lblTitulo1
            // 
            lblTitulo1.AutoSize = true;
            lblTitulo1.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo1.ForeColor = Color.Gold;
            lblTitulo1.Location = new Point(12, 9);
            lblTitulo1.Name = "lblTitulo1";
            lblTitulo1.Size = new Size(340, 50);
            lblTitulo1.TabIndex = 26;
            lblTitulo1.Text = "RESTAURANTEBD ";
            // 
            // FrmTipoEmpleado
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1924, 990);
            Controls.Add(lblTitulo1);
            Controls.Add(txtIdTipo);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvTipoEmpleado);
            Controls.Add(txtNombre);
            Controls.Add(lblIdTipo);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo1);
            Margin = new Padding(5);
            Name = "FrmTipoEmpleado";
            Text = "Tipo_empleado";
            Load += FrmTipoEmpleado_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTipoEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblIdTipo;
        private TextBox txtNombre;
        private DataGridView dgvTipoEmpleado;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private Button btnLimpiar;
        private TextBox txtIdTipo;
        private Label lblTitulo1;
    }
}