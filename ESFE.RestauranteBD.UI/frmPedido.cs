using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmPedido : Form
    {
        private pedidoLN _pedidoLN = new pedidoLN();

        public FrmPedido()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtIdPedido.Clear();
            txtIdCliente.Clear();
            if (cboEmpleado.Items.Count > 0) cboEmpleado.SelectedIndex = 0;
            if (cboMesa.Items.Count > 0) cboMesa.SelectedIndex = 0;
            if (cboEstado.Items.Count > 0) cboEstado.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Now;
            dgvPedido.DataSource = null;
            txtIdPedido.Focus();
        }

        private void frmPedido_Load(object sender, EventArgs e)
        {
            CargarComboBoxes();
        }

        private void CargarComboBoxes()
        {
            // Opciones para Empleado
            cboEmpleado.Items.Clear();
            cboEmpleado.Items.Add("IDE_1");
            cboEmpleado.Items.Add("IDE_2");
            cboEmpleado.Items.Add("IDE_3");
            cboEmpleado.Items.Add("IDE_4");

            // Opciones para Mesa
            cboMesa.Items.Clear();
            cboMesa.Items.Add("M_01");
            cboMesa.Items.Add("M_02");
            cboMesa.Items.Add("M_03");
            cboMesa.Items.Add("M_04");

            // Opciones para Estado
            cboEstado.Items.Clear();
            cboEstado.Items.Add("ES_01");
            cboEstado.Items.Add("ES_02");
            cboEstado.Items.Add("ES_03");
            cboEstado.Items.Add("ES_04");

            // Seleccionar la primera opción por defecto
            if (cboEmpleado.Items.Count > 0) cboEmpleado.SelectedIndex = 0;
            if (cboMesa.Items.Count > 0) cboMesa.SelectedIndex = 0;
            if (cboEstado.Items.Count > 0) cboEstado.SelectedIndex = 0;
        }

     
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string idPedido = txtIdPedido.Text.Trim();
                List<Pedido> lista = _pedidoLN.Buscar(idPedido);
                dgvPedido.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdPedido.Text) || string.IsNullOrWhiteSpace(txtIdCliente.Text))
                {
                    MessageBox.Show("Por favor completa los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Pedido pedido = new Pedido
                {
                    IdPedido = txtIdPedido.Text.Trim(),
                    fecha = dtpFecha.Value,
                    IDCliente = txtIdCliente.Text.Trim(),
                    IdEmpleado = cboEmpleado.Text.Trim(),
                    IdMesa = cboMesa.Text.Trim(),
                    IdEstado = cboEstado.Text.Trim()
                };

                bool resultado = _pedidoLN.Insertar(pedido);

                if (resultado)
                {
                    MessageBox.Show("Pedido guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBuscar_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string idPedido = txtIdPedido.Text.Trim();

                if (string.IsNullOrWhiteSpace(idPedido))
                {
                    MessageBox.Show("Ingresa el ID del pedido a eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show($"¿Deseas eliminar el pedido {idPedido}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool resultado = _pedidoLN.Eliminar(idPedido);

                    if (resultado)
                    {
                        MessageBox.Show("Pedido eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}