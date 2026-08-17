namespace ESFE.RestauranteBD.UI
{
    partial class Bebida
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtIDBebida = new TextBox();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(84, 288);
            label1.Name = "label1";
            label1.Size = new Size(150, 54);
            label1.TabIndex = 0;
            label1.Text = "ID Bebida:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(84, 390);
            label2.Name = "label2";
            label2.Size = new Size(121, 37);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(84, 482);
            label3.Name = "label3";
            label3.Size = new Size(134, 37);
            label3.TabIndex = 2;
            label3.Text = "Precio ($):";
            label3.Click += label3_Click;
            // 
            // txtIDBebida
            // 
            txtIDBebida.Location = new Point(266, 298);
            txtIDBebida.Name = "txtIDBebida";
            txtIDBebida.Size = new Size(201, 39);
            txtIDBebida.TabIndex = 3;
            txtIDBebida.TextChanged += textBox1_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(266, 387);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(201, 39);
            txtNombre.TabIndex = 4;
            txtNombre.TextChanged += textBox2_TextChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(266, 480);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(201, 39);
            txtPrecio.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(64, 64, 64);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(585, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1313, 914);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(46, 24);
            label5.Name = "label5";
            label5.Size = new Size(518, 50);
            label5.TabIndex = 12;
            label5.Text = "RESTAURANTEBD - BEBIDAS";
            label5.Click += label5_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(84, 650);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 46);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Crimson;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(315, 650);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 46);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(962, 58);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(514, 39);
            txtBuscar.TabIndex = 15;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.ForestGreen;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(1510, 54);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(150, 46);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // Bebida
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1924, 1054);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(txtIDBebida);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bebida";
            Text = "Bebida";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIDBebida;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private DataGridView dataGridView1;
        private Label label5;
        private Button btnGuardar;
        private Button btnLimpiar;
        private TextBox txtBuscar;
        private Button btnBuscar;
    }
}