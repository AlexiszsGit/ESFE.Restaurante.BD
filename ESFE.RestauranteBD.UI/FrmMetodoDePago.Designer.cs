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
            btnNuevo = new Button();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvMetodosDePago = new DataGridView();
            lblTitulo = new Label();
            grp = new GroupBox();
            lblNombe = new Label();
            lblDescripcion = new Label();
            txbNombre = new TextBox();
            txtDescricion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMetodosDePago).BeginInit();
            grp.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(94, 259);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(215, 259);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar ";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(334, 259);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(571, 259);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(433, 259);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
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
            grp.Controls.Add(lblDescripcion);
            grp.Controls.Add(lblNombe);
            grp.Location = new Point(12, 68);
            grp.Name = "grp";
            grp.Size = new Size(709, 169);
            grp.TabIndex = 11;
            grp.TabStop = false;
            grp.Text = "metodo de pagos ";
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
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(23, 99);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripcion ";
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(134, 49);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(100, 23);
            txbNombre.TabIndex = 2;
            // 
            // txtDescricion
            // 
            txtDescricion.Location = new Point(134, 99);
            txtDescricion.Name = "txtDescricion";
            txtDescricion.Size = new Size(100, 23);
            txtDescricion.TabIndex = 3;
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
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(btnNuevo);
            Name = "frmMetodoDePago";
            Text = "Mantenimiento de Métodos de Pago";
            ((System.ComponentModel.ISupportInitialize)dgvMetodosDePago).EndInit();
            grp.ResumeLayout(false);
            grp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNuevo;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button button1;
        private Button btnLimpiar;
        private DataGridView dgvMetodosDePago;
        private Label lblTitulo;
        private GroupBox grp;
        private Label label4;
        private Label label3;
        private Label lblDescripcion;
        private Label lblNombe;
        private TextBox txtDescricion;
        private TextBox txbNombre;
    }
}