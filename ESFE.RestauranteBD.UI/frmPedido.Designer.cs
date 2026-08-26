namespace ESFE.RestauranteBD.UI
{
    partial class FrmPedido
    {
        /// <summary>
        /// Variable necesaria para el diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberar recursos utilizados.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador

        private void InitializeComponent()
        {
            txtIdPedido = new TextBox();
            txtIdCliente = new TextBox();

            cboEmpleado = new ComboBox();
            cboMesa = new ComboBox();
            cboEstado = new ComboBox();

            dtpFecha = new DateTimePicker();

            dgvPedido = new DataGridView();

            btnBuscar = new Button();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();

            ((System.ComponentModel.ISupportInitialize)
                dgvPedido).BeginInit();

            SuspendLayout();

            // =====================================================
            // txtIdPedido
            // =====================================================

            txtIdPedido.Location =
                new Point(0, 0);

            txtIdPedido.Name =
                "txtIdPedido";

            txtIdPedido.Size =
                new Size(200, 27);

            txtIdPedido.TabIndex =
                0;

            // =====================================================
            // txtIdCliente
            // =====================================================

            txtIdCliente.Location =
                new Point(0, 0);

            txtIdCliente.Name =
                "txtIdCliente";

            txtIdCliente.Size =
                new Size(200, 27);

            txtIdCliente.TabIndex =
                1;

            // =====================================================
            // cboEmpleado
            // =====================================================

            cboEmpleado.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboEmpleado.FormattingEnabled =
                true;

            cboEmpleado.Name =
                "cboEmpleado";

            cboEmpleado.Size =
                new Size(200, 28);

            cboEmpleado.TabIndex =
                2;

            // =====================================================
            // cboMesa
            // =====================================================

            cboMesa.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboMesa.FormattingEnabled =
                true;

            cboMesa.Name =
                "cboMesa";

            cboMesa.Size =
                new Size(200, 28);

            cboMesa.TabIndex =
                3;

            // =====================================================
            // cboEstado
            // =====================================================

            cboEstado.DropDownStyle =
                ComboBoxStyle.DropDownList;

            cboEstado.FormattingEnabled =
                true;

            cboEstado.Name =
                "cboEstado";

            cboEstado.Size =
                new Size(200, 28);

            cboEstado.TabIndex =
                4;

            // =====================================================
            // dtpFecha
            // =====================================================

            dtpFecha.Format =
                DateTimePickerFormat.Short;

            dtpFecha.Name =
                "dtpFecha";

            dtpFecha.Size =
                new Size(200, 27);

            dtpFecha.TabIndex =
                5;

            // =====================================================
            // dgvPedido
            // =====================================================

            dgvPedido.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            dgvPedido.Name =
                "dgvPedido";

            dgvPedido.Size =
                new Size(1000, 300);

            dgvPedido.TabIndex =
                6;

            // =====================================================
            // btnBuscar
            // =====================================================

            btnBuscar.Name =
                "btnBuscar";

            btnBuscar.Size =
                new Size(180, 48);

            btnBuscar.TabIndex =
                7;

            btnBuscar.Text =
                "Buscar";

            btnBuscar.UseVisualStyleBackColor =
                false;

            btnBuscar.Click +=
                btnBuscar_Click;

            // =====================================================
            // btnAgregar
            // =====================================================

            btnAgregar.Name =
                "btnAgregar";

            btnAgregar.Size =
                new Size(180, 48);

            btnAgregar.TabIndex =
                8;

            btnAgregar.Text =
                "Agregar";

            btnAgregar.UseVisualStyleBackColor =
                false;

            btnAgregar.Click +=
                btnAgregar_Click;

            // =====================================================
            // btnEliminar
            // =====================================================

            btnEliminar.Name =
                "btnEliminar";

            btnEliminar.Size =
                new Size(180, 48);

            btnEliminar.TabIndex =
                9;

            btnEliminar.Text =
                "Eliminar";

            btnEliminar.UseVisualStyleBackColor =
                false;

            btnEliminar.Click +=
                btnEliminar_Click;

            // =====================================================
            // btnLimpiar
            // =====================================================

            btnLimpiar.Name =
                "btnLimpiar";

            btnLimpiar.Size =
                new Size(180, 48);

            btnLimpiar.TabIndex =
                10;

            btnLimpiar.Text =
                "Limpiar";

            btnLimpiar.UseVisualStyleBackColor =
                false;

            btnLimpiar.Click +=
                btnLimpiar_Click;

            // =====================================================
            // FrmPedido
            // =====================================================

            AutoScaleDimensions =
                new SizeF(
                    7F,
                    15F);

            AutoScaleMode =
                AutoScaleMode.Font;

            BackColor =
                Color.FromArgb(
                    10,
                    10,
                    10);

            ClientSize =
                new Size(
                    1150,
                    700);

            Controls.Add(
                txtIdPedido);

            Controls.Add(
                txtIdCliente);

            Controls.Add(
                cboEmpleado);

            Controls.Add(
                cboMesa);

            Controls.Add(
                cboEstado);

            Controls.Add(
                dtpFecha);

            Controls.Add(
                dgvPedido);

            Controls.Add(
                btnBuscar);

            Controls.Add(
                btnAgregar);

            Controls.Add(
                btnEliminar);

            Controls.Add(
                btnLimpiar);

            Name =
                "FrmPedido";

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "RESTAURANTEBD | Pedidos";

            Load +=
                frmPedido_Load;

            ((System.ComponentModel.ISupportInitialize)
                dgvPedido).EndInit();

            ResumeLayout(false);
        }

        #endregion

        // =========================================================
        // CONTROLES DEL DISEÑADOR
        // =========================================================

        private TextBox txtIdPedido;
        private TextBox txtIdCliente;

        private ComboBox cboEmpleado;
        private ComboBox cboMesa;
        private ComboBox cboEstado;

        private DateTimePicker dtpFecha;

        private DataGridView dgvPedido;

        private Button btnBuscar;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnLimpiar;
    }
}