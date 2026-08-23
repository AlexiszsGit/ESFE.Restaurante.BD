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
            lblNombre = new Label();
            lblTipoEmpleado = new Label();
            txtNombre = new TextBox();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnGuardar = new Button();
            dgvEmpleados = new DataGridView();
            lblIdEmpleado = new Label();
            txtIdEmpleado = new TextBox();
            lblTitulo2 = new Label();
            cmbTipoEmpleado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(159, 192);
            lblNombre.Margin = new Padding(5, 0, 5, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(107, 32);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblTipoEmpleado
            // 
            lblTipoEmpleado.AutoSize = true;
            lblTipoEmpleado.ForeColor = Color.White;
            lblTipoEmpleado.Location = new Point(159, 346);
            lblTipoEmpleado.Margin = new Padding(5, 0, 5, 0);
            lblTipoEmpleado.Name = "lblTipoEmpleado";
            lblTipoEmpleado.Size = new Size(179, 32);
            lblTipoEmpleado.TabIndex = 4;
            lblTipoEmpleado.Text = "Tipo Empleado:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(384, 192);
            txtNombre.Margin = new Padding(5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(573, 39);
            txtNombre.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(128, 128, 255);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(728, 642);
            btnLimpiar.Margin = new Padding(5);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(153, 46);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(520, 642);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 46);
            btnEliminar.TabIndex = 20;
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
            btnModificar.Location = new Point(318, 642);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 46);
            btnModificar.TabIndex = 19;
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
            btnGuardar.Location = new Point(124, 642);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 46);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(1047, 192);
            dgvEmpleados.Margin = new Padding(5);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(845, 531);
            dgvEmpleados.TabIndex = 21;
            dgvEmpleados.CellClick += dataGridView1_CellClick;
            dgvEmpleados.CellContentClick += dataGridView1_CellClick;
            // 
            // lblIdEmpleado
            // 
            lblIdEmpleado.AutoSize = true;
            lblIdEmpleado.ForeColor = Color.White;
            lblIdEmpleado.Location = new Point(159, 478);
            lblIdEmpleado.Margin = new Padding(5, 0, 5, 0);
            lblIdEmpleado.Name = "lblIdEmpleado";
            lblIdEmpleado.Size = new Size(147, 32);
            lblIdEmpleado.TabIndex = 22;
            lblIdEmpleado.Text = "Id Empleado";
            // 
            // txtIdEmpleado
            // 
            txtIdEmpleado.Location = new Point(384, 471);
            txtIdEmpleado.Margin = new Padding(5);
            txtIdEmpleado.Name = "txtIdEmpleado";
            txtIdEmpleado.Size = new Size(573, 39);
            txtIdEmpleado.TabIndex = 23;
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.BackColor = Color.Black;
            lblTitulo2.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo2.ForeColor = Color.Gold;
            lblTitulo2.Location = new Point(33, 41);
            lblTitulo2.Margin = new Padding(5, 0, 5, 0);
            lblTitulo2.Name = "lblTitulo2";
            lblTitulo2.Size = new Size(340, 50);
            lblTitulo2.TabIndex = 27;
            lblTitulo2.Text = "RESTAURANTEBD ";
            // 
            // cmbTipoEmpleado
            // 
            cmbTipoEmpleado.DisplayMember = "nombre";
            cmbTipoEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoEmpleado.FormattingEnabled = true;
            cmbTipoEmpleado.Location = new Point(384, 338);
            cmbTipoEmpleado.Name = "cmbTipoEmpleado";
            cmbTipoEmpleado.Size = new Size(573, 40);
            cmbTipoEmpleado.TabIndex = 28;
            cmbTipoEmpleado.ValueMember = "IdTipo";
            // 
            // FrmEmpleado
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1924, 829);
            Controls.Add(cmbTipoEmpleado);
            Controls.Add(lblTitulo2);
            Controls.Add(txtIdEmpleado);
            Controls.Add(lblIdEmpleado);
            Controls.Add(dgvEmpleados);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(btnLimpiar);
            Controls.Add(txtNombre);
            Controls.Add(lblTipoEmpleado);
            Controls.Add(lblNombre);
            Margin = new Padding(5);
            Name = "FrmEmpleado";
            Text = "Empleado";
            Load += FrmEmpleado_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNombre;
        private Label lblTipoEmpleado;
        private TextBox txtNombre;
        private Button btnLimpiar;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
        private DataGridView dgvEmpleados;
        private Label lblIdEmpleado;
        private TextBox txtIdEmpleado;
        private Label lblTitulo2;
        private ComboBox cmbTipoEmpleado;
    }
}