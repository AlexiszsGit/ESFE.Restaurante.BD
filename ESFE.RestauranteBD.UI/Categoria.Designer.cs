namespace ESFE.RestauranteBD.UI
{
    partial class Categoria
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
            txtIdCategoria = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            dgvCategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 84);
            label1.Name = "label1";
            label1.Size = new Size(146, 32);
            label1.TabIndex = 0;
            label1.Text = "ID Categoria";
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Location = new Point(110, 136);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.Size = new Size(200, 39);
            txtIdCategoria.TabIndex = 1;
            txtIdCategoria.TextChanged += txtIdCategoria_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 224);
            label2.Name = "label2";
            label2.Size = new Size(245, 32);
            label2.TabIndex = 2;
            label2.Text = "Nombre de Categoria";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(110, 274);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 39);
            txtNombre.TabIndex = 3;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(110, 391);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 46);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(306, 391);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 46);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(110, 490);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 46);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(716, 69);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.RowHeadersWidth = 82;
            dgvCategorias.Size = new Size(1526, 1089);
            dgvCategorias.TabIndex = 7;
            // 
            // Categoria
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2254, 1195);
            Controls.Add(dgvCategorias);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtIdCategoria);
            Controls.Add(label1);
            Name = "Categoria";
            Text = "Categoria";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdCategoria;
        private Label label2;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dgvCategorias;
    }
}