namespace ESFE.RestauranteBD.UI
{
    partial class FrmMesa
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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            btmModificar = new Button();
            button3 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.ActiveCaptionText;
            lblTitulo.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Gold;
            lblTitulo.Location = new Point(316, 32);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(254, 24);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "MANTENIMIETO DE MESAS";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.BackColor = SystemColors.ActiveCaptionText;
            lblNumero.ForeColor = Color.White;
            lblNumero.Location = new Point(47, 124);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(132, 20);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Numero de Mesas:";
            // 
            // lblCapacidad
            // 
            lblCapacidad.AutoSize = true;
            lblCapacidad.BackColor = SystemColors.ActiveCaptionText;
            lblCapacidad.ForeColor = Color.White;
            lblCapacidad.Location = new Point(47, 176);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(83, 20);
            lblCapacidad.TabIndex = 2;
            lblCapacidad.Text = "Capacidad:";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BackColor = SystemColors.ActiveCaptionText;
            lblEstado.ForeColor = Color.White;
            lblEstado.Location = new Point(47, 230);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 20);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Estado:";
            // 
            // txtNumeroMesa
            // 
            txtNumeroMesa.Location = new Point(201, 117);
            txtNumeroMesa.Name = "txtNumeroMesa";
            txtNumeroMesa.Size = new Size(125, 27);
            txtNumeroMesa.TabIndex = 4;
            // 
            // nudCapacidad
            // 
            nudCapacidad.DecimalPlaces = 1;
            nudCapacidad.Location = new Point(201, 169);
            nudCapacidad.Name = "nudCapacidad";
            nudCapacidad.Size = new Size(150, 27);
            nudCapacidad.TabIndex = 5;
            nudCapacidad.ValueChanged += nudCapacidad_ValueChanged;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(201, 222);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(151, 28);
            cmbEstado.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(447, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(521, 297);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(250, 402);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(92, 29);
            button2.TabIndex = 28;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button3_Click;
            // 
            // btmModificar
            // 
            btmModificar.BackColor = Color.RoyalBlue;
            btmModificar.FlatAppearance.BorderSize = 0;
            btmModificar.FlatStyle = FlatStyle.Flat;
            btmModificar.ForeColor = Color.White;
            btmModificar.Location = new Point(138, 402);
            btmModificar.Margin = new Padding(2);
            btmModificar.Name = "btmModificar";
            btmModificar.Size = new Size(92, 29);
            btmModificar.TabIndex = 27;
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
            button3.Location = new Point(22, 402);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(92, 29);
            button3.TabIndex = 26;
            button3.Text = "Guardar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(361, 402);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 25;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnLimpiar_Click;
            // 
            // FrmMesa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(992, 480);
            Controls.Add(button2);
            Controls.Add(btmModificar);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(cmbEstado);
            Controls.Add(nudCapacidad);
            Controls.Add(txtNumeroMesa);
            Controls.Add(lblEstado);
            Controls.Add(lblCapacidad);
            Controls.Add(lblNumero);
            Controls.Add(lblTitulo);
            Name = "FrmMesa";
            Text = "Mesa";
            Load += Mesa_Load;
            ((System.ComponentModel.ISupportInitialize)nudCapacidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
        private Button button2;
        private Button btmModificar;
        private Button button3;
        private Button button1;
    }
}