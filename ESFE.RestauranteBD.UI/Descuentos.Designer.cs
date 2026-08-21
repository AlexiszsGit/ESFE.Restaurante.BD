namespace ESFE.RestauranteBD.UI
{
    partial class FrmDescuentos
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
            txtIdDescuento = new TextBox();
            txtNombre = new TextBox();
            numPorcentaje = new NumericUpDown();
            dgvDescuentos = new DataGridView();
            btnEliminar = new Button();
            btmModificar = new Button();
            btnGuardar = new Button();
            label5 = new Label();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)numPorcentaje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDescuentos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(92, 286);
            label1.Name = "label1";
            label1.Size = new Size(181, 37);
            label1.TabIndex = 0;
            label1.Text = "ID Descuento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(92, 385);
            label2.Name = "label2";
            label2.Size = new Size(297, 37);
            label2.TabIndex = 1;
            label2.Text = "Nombre del Descuento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(92, 494);
            label3.Name = "label3";
            label3.Size = new Size(192, 37);
            label3.TabIndex = 2;
            label3.Text = "Porcentaje (%):";
            // 
            // txtIdDescuento
            // 
            txtIdDescuento.Location = new Point(414, 284);
            txtIdDescuento.Name = "txtIdDescuento";
            txtIdDescuento.PlaceholderText = "Agregar ID de Descuento";
            txtIdDescuento.Size = new Size(331, 39);
            txtIdDescuento.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(414, 383);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Agregar Nombre del Descuento";
            txtNombre.Size = new Size(331, 39);
            txtNombre.TabIndex = 4;
            // 
            // numPorcentaje
            // 
            numPorcentaje.ImeMode = ImeMode.Off;
            numPorcentaje.Location = new Point(414, 482);
            numPorcentaje.Name = "numPorcentaje";
            numPorcentaje.Size = new Size(331, 39);
            numPorcentaje.TabIndex = 5;
            // 
            // dgvDescuentos
            // 
            dgvDescuentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDescuentos.BackgroundColor = Color.FromArgb(64, 64, 64);
            dgvDescuentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDescuentos.Location = new Point(818, 307);
            dgvDescuentos.Name = "dgvDescuentos";
            dgvDescuentos.RowHeadersWidth = 82;
            dgvDescuentos.Size = new Size(1360, 888);
            dgvDescuentos.TabIndex = 9;
            dgvDescuentos.CellClick += dgvDescuentos_CellClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Crimson;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(92, 826);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 46);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btmModificar
            // 
            btmModificar.BackColor = Color.RoyalBlue;
            btmModificar.FlatAppearance.BorderSize = 0;
            btmModificar.FlatStyle = FlatStyle.Flat;
            btmModificar.ForeColor = Color.White;
            btmModificar.Location = new Point(405, 704);
            btmModificar.Name = "btmModificar";
            btmModificar.Size = new Size(150, 46);
            btmModificar.TabIndex = 16;
            btmModificar.Text = "Modificar";
            btmModificar.UseVisualStyleBackColor = false;
            btmModificar.Click += btnModificar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(92, 704);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 46);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(54, 65);
            label5.Name = "label5";
            label5.Size = new Size(602, 50);
            label5.TabIndex = 18;
            label5.Text = "RESTAURANTEBD - DESCUENTOS";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Green;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.ImageAlign = ContentAlignment.TopCenter;
            btnBuscar.Location = new Point(1813, 148);
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(146, 48);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(1154, 148);
            txtBuscar.Multiline = true;
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar descuentos ";
            txtBuscar.Size = new Size(627, 48);
            txtBuscar.TabIndex = 19;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Purple;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(405, 826);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 46);
            btnLimpiar.TabIndex = 21;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FrmDescuentos
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(2226, 1267);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label5);
            Controls.Add(btnEliminar);
            Controls.Add(btmModificar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvDescuentos);
            Controls.Add(numPorcentaje);
            Controls.Add(txtNombre);
            Controls.Add(txtIdDescuento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmDescuentos";
            Text = "Descuentos";
            Load += FrmDescuentos_Load;
            ((System.ComponentModel.ISupportInitialize)numPorcentaje).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDescuentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIdDescuento;
        private TextBox txtNombre;
        private NumericUpDown numPorcentaje;
        private DataGridView dgvDescuentos;
        private Button btnEliminar;
        private Button btmModificar;
        private Button btnGuardar;
        private Label label5;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Button btnLimpiar;
    }
}