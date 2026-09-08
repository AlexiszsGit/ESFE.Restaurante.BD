namespace ESFE.RestauranteBD.UI
{
    partial class frmMetodoDePago
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
            btnBuscar = new Button();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvMetodosDePago = new DataGridView();
            lblTitulo = new Label();
            grp = new GroupBox();
            txtDescricion = new TextBox();
            txbNombre = new TextBox();
            lblIdMetodo = new Label();
            lblNombe = new Label();
            btnModificar1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMetodosDePago).BeginInit();
            grp.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(175, 553);
            btnBuscar.Margin = new Padding(6);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(139, 49);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(470, 553);
            btnAgregar.Margin = new Padding(6);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(139, 49);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar ";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(1060, 553);
            btnEliminar.Margin = new Padding(6);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 49);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(804, 553);
            btnLimpiar.Margin = new Padding(6);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(139, 49);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvMetodosDePago
            // 
            dgvMetodosDePago.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMetodosDePago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMetodosDePago.Location = new Point(6, 556);
            dgvMetodosDePago.Margin = new Padding(6);
            dgvMetodosDePago.Name = "dgvMetodosDePago";
            dgvMetodosDePago.ReadOnly = true;
            dgvMetodosDePago.RowHeadersWidth = 82;
            dgvMetodosDePago.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMetodosDePago.Size = new Size(1484, 393);
            dgvMetodosDePago.TabIndex = 9;
            dgvMetodosDePago.CellClick += dgvMetodosDePago_CellClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(620, 58);
            lblTitulo.Margin = new Padding(6, 0, 6, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(292, 44);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "Metodo de pago";
            // 
            // grp
            // 
            grp.Controls.Add(txtDescricion);
            grp.Controls.Add(txbNombre);
            grp.Controls.Add(lblIdMetodo);
            grp.Controls.Add(lblNombe);
            grp.Location = new Point(22, 145);
            grp.Margin = new Padding(6);
            grp.Name = "grp";
            grp.Padding = new Padding(6);
            grp.Size = new Size(1317, 361);
            grp.TabIndex = 11;
            grp.TabStop = false;
            grp.Text = "metodo de pagos ";
            grp.Enter += grp_Enter;
            // 
            // txtDescricion
            // 
            txtDescricion.Location = new Point(249, 211);
            txtDescricion.Margin = new Padding(6);
            txtDescricion.Name = "txtDescricion";
            txtDescricion.Size = new Size(182, 39);
            txtDescricion.TabIndex = 3;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(249, 105);
            txbNombre.Margin = new Padding(6);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(182, 39);
            txbNombre.TabIndex = 2;
            // 
            // lblIdMetodo
            // 
            lblIdMetodo.AutoSize = true;
            lblIdMetodo.Location = new Point(43, 211);
            lblIdMetodo.Margin = new Padding(6, 0, 6, 0);
            lblIdMetodo.Name = "lblIdMetodo";
            lblIdMetodo.Size = new Size(199, 32);
            lblIdMetodo.TabIndex = 1;
            lblIdMetodo.Text = "Metodo de pago:";
            // 
            // lblNombe
            // 
            lblNombe.AutoSize = true;
            lblNombe.Location = new Point(43, 105);
            lblNombe.Margin = new Padding(6, 0, 6, 0);
            lblNombe.Name = "lblNombe";
            lblNombe.Size = new Size(109, 32);
            lblNombe.TabIndex = 0;
            lblNombe.Text = "Nombre ";
            // 
            // btnModificar1
            // 
            btnModificar1.Location = new Point(633, 556);
            btnModificar1.Name = "btnModificar1";
            btnModificar1.Size = new Size(150, 46);
            btnModificar1.TabIndex = 12;
            btnModificar1.Text = "Modificar";
            btnModificar1.UseVisualStyleBackColor = true;
            btnModificar1.Click += btnModificar_Click;
            // 
            // frmMetodoDePago
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(btnModificar1);
            Controls.Add(grp);
            Controls.Add(lblTitulo);
            Controls.Add(dgvMetodosDePago);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Margin = new Padding(6);
            Name = "frmMetodoDePago";
            Text = "Mantenimiento de Métodos de Pago";
            Load += frmMetodoDePago_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMetodosDePago).EndInit();
            grp.ResumeLayout(false);
            grp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBuscar;
        private Button btnAgregar;
        private Button btnEliminar;
        //private Button button1;
        private Button btnLimpiar;
        private DataGridView dgvMetodosDePago;
        private Label lblTitulo;
        private GroupBox grp;
        //private Label label4;
        //private Label label3;
        private Label lblIdMetodo;
        private Label lblNombe;
        private TextBox txtDescricion;
        private TextBox txbNombre;
        private Button btnModificar1;
    }
}