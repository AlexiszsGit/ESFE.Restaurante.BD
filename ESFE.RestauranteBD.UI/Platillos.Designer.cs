namespace ESFE.RestauranteBD.UI
{
    partial class FrmPlatillos
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
            lblPrecio = new Label();
            lblCategoria = new Label();
            txtNombre = new TextBox();
            nudPrecio = new NumericUpDown();
            cmbCategoria = new ComboBox();
            chkDisponible = new CheckBox();
            btnEliminar = new Button();
            dgvPlatillos = new DataGridView();
            button2 = new Button();
            btmModificar = new Button();
            button3 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlatillos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.ActiveCaptionText;
            lblTitulo.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Gold;
            lblTitulo.Location = new Point(442, 56);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(307, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "MANTENIMIENTO DE PLATILLOS";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.ActiveCaptionText;
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(50, 177);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = SystemColors.ActiveCaptionText;
            lblPrecio.ForeColor = Color.White;
            lblPrecio.Location = new Point(50, 246);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = SystemColors.ActiveCaptionText;
            lblCategoria.ForeColor = Color.White;
            lblCategoria.Location = new Point(50, 333);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 20);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Categoria:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(163, 170);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 4;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(163, 247);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(150, 27);
            nudPrecio.TabIndex = 5;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(163, 325);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(151, 28);
            cmbCategoria.TabIndex = 6;
            // 
            // chkDisponible
            // 
            chkDisponible.AutoSize = true;
            chkDisponible.BackColor = SystemColors.ActiveCaptionText;
            chkDisponible.ForeColor = Color.White;
            chkDisponible.Location = new Point(50, 397);
            chkDisponible.Name = "chkDisponible";
            chkDisponible.Size = new Size(103, 24);
            chkDisponible.TabIndex = 7;
            chkDisponible.Text = "Disponible";
            chkDisponible.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(0, 0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "btnEliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvPlatillos
            // 
            dgvPlatillos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlatillos.Location = new Point(408, 111);
            dgvPlatillos.Name = "dgvPlatillos";
            dgvPlatillos.RowHeadersWidth = 51;
            dgvPlatillos.Size = new Size(591, 323);
            dgvPlatillos.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(231, 495);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(92, 29);
            button2.TabIndex = 32;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            // 
            // btmModificar
            // 
            btmModificar.BackColor = Color.RoyalBlue;
            btmModificar.FlatAppearance.BorderSize = 0;
            btmModificar.FlatStyle = FlatStyle.Flat;
            btmModificar.ForeColor = Color.White;
            btmModificar.Location = new Point(120, 495);
            btmModificar.Margin = new Padding(2);
            btmModificar.Name = "btmModificar";
            btmModificar.Size = new Size(92, 29);
            btmModificar.TabIndex = 31;
            btmModificar.Text = "Modificar";
            btmModificar.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.ForestGreen;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(11, 495);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(92, 29);
            button3.TabIndex = 30;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(348, 495);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 29;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = false;
            // 
            // FrmPlatillos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1026, 568);
            Controls.Add(button2);
            Controls.Add(btmModificar);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dgvPlatillos);
            Controls.Add(chkDisponible);
            Controls.Add(cmbCategoria);
            Controls.Add(nudPrecio);
            Controls.Add(txtNombre);
            Controls.Add(lblTitulo);
            Controls.Add(lblNombre);
            Controls.Add(lblPrecio);
            Controls.Add(lblCategoria);
            Name = "FrmPlatillos";
            Text = "Platillos";
            Load += Platillos_Load;
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPlatillos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblCategoria;
        private TextBox txtNombre;
        private NumericUpDown nudPrecio;
        private ComboBox cmbCategoria;
        private CheckBox chkDisponible;
        private Button btnEliminar;
        private DataGridView dgvPlatillos;
        private Button button2;
        private Button btmModificar;
        private Button button3;
        private Button button1;
    }
}