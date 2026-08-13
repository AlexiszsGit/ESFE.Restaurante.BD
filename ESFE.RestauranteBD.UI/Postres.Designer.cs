namespace ESFE.RestauranteBD.UI
{
    partial class Postres
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
            lblTipoPostre = new Label();
            txtNombre = new TextBox();
            nudPrecio = new NumericUpDown();
            cmbTipoPostre = new ComboBox();
            chkDisponible = new CheckBox();
            dgvPostres = new DataGridView();
            button2 = new Button();
            btmModificar = new Button();
            button3 = new Button();
            button1 = new Button();
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
            lblNombre.Location = new Point(27, 101);
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
            lblPrecio.Location = new Point(27, 175);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio:";
            // 
            // lblTipoPostre
            // 
            lblTipoPostre.AutoSize = true;
            lblTipoPostre.BackColor = SystemColors.ActiveCaptionText;
            lblTipoPostre.ForeColor = Color.White;
            lblTipoPostre.Location = new Point(27, 245);
            lblTipoPostre.Name = "lblTipoPostre";
            lblTipoPostre.Size = new Size(82, 20);
            lblTipoPostre.TabIndex = 3;
            lblTipoPostre.Text = "TipoPostre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(128, 94);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 4;
            // 
            // nudPrecio
            // 
            nudPrecio.Location = new Point(128, 168);
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(150, 27);
            nudPrecio.TabIndex = 5;
            // 
            // cmbTipoPostre
            // 
            cmbTipoPostre.FormattingEnabled = true;
            cmbTipoPostre.Location = new Point(128, 237);
            cmbTipoPostre.Name = "cmbTipoPostre";
            cmbTipoPostre.Size = new Size(151, 28);
            cmbTipoPostre.TabIndex = 6;
            // 
            // chkDisponible
            // 
            chkDisponible.AutoSize = true;
            chkDisponible.BackColor = SystemColors.ActiveCaptionText;
            chkDisponible.ForeColor = Color.White;
            chkDisponible.Location = new Point(27, 306);
            chkDisponible.Name = "chkDisponible";
            chkDisponible.Size = new Size(103, 24);
            chkDisponible.TabIndex = 7;
            chkDisponible.Text = "Disponible";
            chkDisponible.UseVisualStyleBackColor = false;
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
            // 
            // button3
            // 
            button3.BackColor = Color.ForestGreen;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(31, 392);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(92, 29);
            button3.TabIndex = 34;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = false;
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
            // 
            // Postres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btmModificar);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dgvPostres);
            Controls.Add(chkDisponible);
            Controls.Add(cmbTipoPostre);
            Controls.Add(nudPrecio);
            Controls.Add(txtNombre);
            Controls.Add(lblPrecio);
            Controls.Add(lblTipoPostre);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Name = "Postres";
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
        private DataGridView dgvPostres;
        private Button button2;
        private Button btmModificar;
        private Button button3;
        private Button button1;
    }
}