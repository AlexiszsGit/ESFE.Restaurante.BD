namespace ESFE.RestauranteBD.UI
{
    partial class FrmPostres
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
            lblPostres = new Label();
            txtNombre = new TextBox();
            nudPrecio = new NumericUpDown();
            dgvPostres = new DataGridView();
            button2 = new Button();
            btmModificar = new Button();
            btnGuardar = new Button();
            button1 = new Button();
            txtIdPostre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPostres).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.ActiveCaptionText;
            lblTitulo.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Gold;
            lblTitulo.Location = new Point(346, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(291, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "MANTENIMIENTO DE POSTRES";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = SystemColors.ActiveCaptionText;
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(27, 175);
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
            lblPrecio.Location = new Point(31, 237);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio:";
            // 
            // lblPostres
            // 
            lblPostres.AutoSize = true;
            lblPostres.BackColor = SystemColors.ActiveCaptionText;
            lblPostres.ForeColor = Color.White;
            lblPostres.Location = new Point(27, 111);
            lblPostres.Name = "lblPostres";
            lblPostres.Size = new Size(69, 20);
            lblPostres.TabIndex = 3;
            lblPostres.Text = "Id Postre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(129, 172);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 27);
            txtNombre.TabIndex = 4;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(129, 230);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(150, 27);
            nudPrecio.TabIndex = 5;
            // 
            // dgvPostres
            // 
            dgvPostres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPostres.Location = new Point(308, 78);
            dgvPostres.Name = "dgvPostres";
            dgvPostres.RowHeadersWidth = 51;
            dgvPostres.Size = new Size(443, 276);
            dgvPostres.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(251, 392);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(92, 29);
            button2.TabIndex = 36;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btmModificar
            // 
            btmModificar.BackColor = Color.RoyalBlue;
            btmModificar.FlatAppearance.BorderSize = 0;
            btmModificar.FlatStyle = FlatStyle.Flat;
            btmModificar.ForeColor = Color.White;
            btmModificar.Location = new Point(140, 392);
            btmModificar.Margin = new Padding(2);
            btmModificar.Name = "btmModificar";
            btmModificar.Size = new Size(92, 29);
            btmModificar.TabIndex = 35;
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
            btnGuardar.Location = new Point(31, 392);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(92, 29);
            btnGuardar.TabIndex = 34;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(368, 392);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 33;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtIdPostre
            // 
            txtIdPostre.Location = new Point(129, 104);
            txtIdPostre.Name = "txtIdPostre";
            txtIdPostre.Size = new Size(150, 27);
            txtIdPostre.TabIndex = 37;
            // 
            // FrmPostres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIdPostre);
            Controls.Add(button2);
            Controls.Add(btmModificar);
            Controls.Add(btnGuardar);
            Controls.Add(button1);
            Controls.Add(dgvPostres);
            Controls.Add(nudPrecio);
            Controls.Add(txtNombre);
            Controls.Add(lblPrecio);
            Controls.Add(lblPostres);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "FrmPostres";
            Text = "Postres";
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPostres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombre;
        private Label lblPrecio;
        private Label lblTipoPostre;
        private TextBox txtNombre;
        private NumericUpDown nudPrecio;
        private ComboBox cmbTipoPostre;
        private CheckBox chkDisponible;

        public FrmPostres(CheckBox chkDisponible)
        {
            this.chkDisponible = chkDisponible;
        }

        private DataGridView dgvPostres;
        private Button button2;
        private Button btmModificar;
        private Button btnGuardar;
        private Button button1;
        private Label lblPostres;
        private TextBox txtIdPostre;
    }
}