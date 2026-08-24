using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ESFE.RestauranteBD.UI
{
    partial class FrmMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvMenu = new DataGridView();
            lblIdPostre = new Label();
            labelIdPostre = new Label();
            lblIdBebida = new Label();
            lblIdCategoria = new Label();
            lblIdProducto = new Label();
            txtIdCategoria = new TextBox();
            txtIdProducto = new TextBox();
            txtIdBebida = new TextBox();
            txtIdPostre = new TextBox();
            txtIdPedido = new TextBox();
            btnLimpiar = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            btnBuscar = new Button();
            ((ISupportInitialize)dgvMenu).BeginInit();
            SuspendLayout();
            // 
            // dgvMenu
            // 
            dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Location = new Point(682, 0);
            dgvMenu.Name = "dgvMenu";
            dgvMenu.Size = new Size(287, 510);
            dgvMenu.TabIndex = 0;
            // 
            // lblIdPostre
            // 
            lblIdPostre.AutoSize = true;
            lblIdPostre.Location = new Point(34, 43);
            lblIdPostre.Name = "lblIdPostre";
            lblIdPostre.Size = new Size(47, 15);
            lblIdPostre.TabIndex = 1;
            lblIdPostre.Text = "Pedido ";
            // 
            // labelIdPostre
            // 
            labelIdPostre.AutoSize = true;
            labelIdPostre.Location = new Point(34, 231);
            labelIdPostre.Name = "labelIdPostre";
            labelIdPostre.Size = new Size(40, 15);
            labelIdPostre.TabIndex = 2;
            labelIdPostre.Text = "Postre";
            // 
            // lblIdBebida
            // 
            lblIdBebida.AutoSize = true;
            lblIdBebida.Location = new Point(34, 427);
            lblIdBebida.Name = "lblIdBebida";
            lblIdBebida.Size = new Size(43, 15);
            lblIdBebida.TabIndex = 3;
            lblIdBebida.Text = "Bebida";
            // 
            // lblIdCategoria
            // 
            lblIdCategoria.AutoSize = true;
            lblIdCategoria.Location = new Point(364, 43);
            lblIdCategoria.Name = "lblIdCategoria";
            lblIdCategoria.Size = new Size(61, 15);
            lblIdCategoria.TabIndex = 4;
            lblIdCategoria.Text = "Categoria ";
            // 
            // lblIdProducto
            // 
            lblIdProducto.AutoSize = true;
            lblIdProducto.Location = new Point(381, 231);
            lblIdProducto.Name = "lblIdProducto";
            lblIdProducto.Size = new Size(56, 15);
            lblIdProducto.TabIndex = 5;
            lblIdProducto.Text = "Producto";
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Location = new Point(480, 40);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.Size = new Size(100, 23);
            txtIdCategoria.TabIndex = 6;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(480, 228);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(100, 23);
            txtIdProducto.TabIndex = 7;
            // 
            // txtIdBebida
            // 
            txtIdBebida.Location = new Point(119, 424);
            txtIdBebida.Name = "txtIdBebida";
            txtIdBebida.Size = new Size(100, 23);
            txtIdBebida.TabIndex = 8;
            // 
            // txtIdPostre
            // 
            txtIdPostre.Location = new Point(119, 228);
            txtIdPostre.Name = "txtIdPostre";
            txtIdPostre.Size = new Size(100, 23);
            txtIdPostre.TabIndex = 9;
            // 
            // txtIdPedido
            // 
            txtIdPedido.Location = new Point(119, 40);
            txtIdPedido.Name = "txtIdPedido";
            txtIdPedido.Size = new Size(100, 23);
            txtIdPedido.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(534, 419);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(534, 336);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(280, 424);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(280, 336);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmMenu
            // 
            ClientSize = new Size(967, 507);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Controls.Add(txtIdPedido);
            Controls.Add(txtIdPostre);
            Controls.Add(txtIdBebida);
            Controls.Add(txtIdProducto);
            Controls.Add(txtIdCategoria);
            Controls.Add(lblIdProducto);
            Controls.Add(lblIdCategoria);
            Controls.Add(lblIdBebida);
            Controls.Add(labelIdPostre);
            Controls.Add(lblIdPostre);
            Controls.Add(dgvMenu);
            Name = "FrmMenu";
            ((ISupportInitialize)dgvMenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Label lblIdPostre;
        private System.Windows.Forms.Label labelIdPostre;
        private System.Windows.Forms.Label lblIdBebida;
        private System.Windows.Forms.Label lblIdCategoria;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.TextBox txtIdCategoria;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtIdBebida;
        private System.Windows.Forms.TextBox txtIdPostre;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
    }
}