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
            ((System.ComponentModel.ISupportInitialize)dgvMetodosDePago).BeginInit();
            grp.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(94, 259);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(253, 259);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar ";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(571, 259);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(433, 259);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvMetodosDePago
            // 
            dgvMetodosDePago.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMetodosDePago.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMetodosDePago.Location = new Point(3, 288);
            dgvMetodosDePago.Name = "dgvMetodosDePago";
            dgvMetodosDePago.ReadOnly = true;
            dgvMetodosDePago.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMetodosDePago.Size = new Size(799, 184);
            dgvMetodosDePago.TabIndex = 9;
            dgvMetodosDePago.CellContentClick += dgvMetodosDePago_CellContentClick;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Bernard MT Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(334, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(126, 22);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "Metodo de pago";
            // 
            // grp
            // 
            grp.Controls.Add(txtDescricion);
            grp.Controls.Add(txbNombre);
            grp.Controls.Add(lblIdMetodo);
            grp.Controls.Add(lblNombe);
            grp.Location = new Point(12, 68);
            grp.Name = "grp";
            grp.Size = new Size(709, 169);
            grp.TabIndex = 11;
            grp.TabStop = false;
            grp.Text = "metodo de pagos ";
            grp.Enter += grp_Enter;
            // 
            // txtDescricion
            // 
            txtDescricion.Location = new Point(134, 99);
            txtDescricion.Name = "txtDescricion";
            txtDescricion.Size = new Size(100, 23);
            txtDescricion.TabIndex = 3;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(134, 49);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(100, 23);
            txbNombre.TabIndex = 2;
            // 
            // lblIdMetodo
            // 
            lblIdMetodo.AutoSize = true;
            lblIdMetodo.Location = new Point(23, 99);
            lblIdMetodo.Name = "lblIdMetodo";
            lblIdMetodo.Size = new Size(98, 15);
            lblIdMetodo.TabIndex = 1;
            lblIdMetodo.Text = "Metodo de pago:";
            // 
            // lblNombe
            // 
            lblNombe.AutoSize = true;
            lblNombe.Location = new Point(23, 49);
            lblNombe.Name = "lblNombe";
            lblNombe.Size = new Size(54, 15);
            lblNombe.TabIndex = 0;
            lblNombe.Text = "Nombre ";
            // 
            // frmMetodoDePago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grp);
            Controls.Add(lblTitulo);
            Controls.Add(dgvMetodosDePago);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Name = "frmMetodoDePago";
            Text = "Mantenimiento de Métodos de Pago";
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
    }
}