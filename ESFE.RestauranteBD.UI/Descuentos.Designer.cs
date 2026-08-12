namespace ESFE.RestauranteBD.UI
{
    partial class Descuentos
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
            brnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            dgvDescuentos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numPorcentaje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDescuentos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 156);
            label1.Name = "label1";
            label1.Size = new Size(163, 32);
            label1.TabIndex = 0;
            label1.Text = "ID Descuento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 255);
            label2.Name = "label2";
            label2.Size = new Size(268, 32);
            label2.TabIndex = 1;
            label2.Text = "Nombre del Descuento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 364);
            label3.Name = "label3";
            label3.Size = new Size(171, 32);
            label3.TabIndex = 2;
            label3.Text = "Porcentaje (%):";
            // 
            // txtIdDescuento
            // 
            txtIdDescuento.Location = new Point(364, 149);
            txtIdDescuento.Name = "txtIdDescuento";
            txtIdDescuento.Size = new Size(200, 39);
            txtIdDescuento.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(364, 248);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 39);
            txtNombre.TabIndex = 4;
            // 
            // numPorcentaje
            // 
            numPorcentaje.Location = new Point(364, 357);
            numPorcentaje.Name = "numPorcentaje";
            numPorcentaje.Size = new Size(240, 39);
            numPorcentaje.TabIndex = 5;
            numPorcentaje.ValueChanged += numPorcentaje_ValueChanged;
            // 
            // brnGuardar
            // 
            brnGuardar.Location = new Point(71, 533);
            brnGuardar.Name = "brnGuardar";
            brnGuardar.Size = new Size(150, 46);
            brnGuardar.TabIndex = 6;
            brnGuardar.Text = "Guardar";
            brnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(364, 533);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 46);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(218, 639);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 46);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // dgvDescuentos
            // 
            dgvDescuentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDescuentos.Location = new Point(674, 120);
            dgvDescuentos.Name = "dgvDescuentos";
            dgvDescuentos.RowHeadersWidth = 82;
            dgvDescuentos.Size = new Size(1485, 974);
            dgvDescuentos.TabIndex = 9;
            // 
            // Descuentos
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2226, 1267);
            Controls.Add(dgvDescuentos);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(brnGuardar);
            Controls.Add(numPorcentaje);
            Controls.Add(txtNombre);
            Controls.Add(txtIdDescuento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Descuentos";
            Text = "Descuentos";
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
        private Button brnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private DataGridView dgvDescuentos;
    }
}