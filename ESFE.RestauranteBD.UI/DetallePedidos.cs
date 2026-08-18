using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ESFE.RestauranteBD.LN;

namespace ESFE.RestauranteBD.UI
{
    public partial class DetallePedidos : Form
    {
        private readonly DetallePedidosLN detallePedidosLN;

        public DetallePedidos()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            detallePedidosLN = new DetallePedidosLN();

            CargarDetallePedidos();
        }

        private void CargarDetallePedidos()
        {
            try
            {
                List<ESFE.RestauranteBD.EN.DetallePedidos> lista =
                    detallePedidosLN.Buscar("");

                dgvDetallePedidos.DataSource = null;
                dgvDetallePedidos.DataSource = lista;
                dgvDetallePedidos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los detalles de pedidos:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdDetalle.Text))
                {
                    MessageBox.Show(
                        "Ingrese el ID del detalle.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtIdDetalle.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtIdPedido.Text))
                {
                    MessageBox.Show(
                        "Ingrese el ID del pedido.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtIdPedido.Focus();
                    return;
                }

                if (numCantidad.Value <= 0)
                {
                    MessageBox.Show(
                        "La cantidad debe ser mayor que 0.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    numCantidad.Focus();
                    return;
                }

                ESFE.RestauranteBD.EN.DetallePedidos detalle =
                    new ESFE.RestauranteBD.EN.DetallePedidos
                    {
                        IdDetalle = txtIdDetalle.Text.Trim(),
                        IdPedido = txtIdPedido.Text.Trim(),
                        Cantidad = Convert.ToInt32(numCantidad.Value)
                    };

                bool resultado = detallePedidosLN.Insertar(detalle);

                if (resultado)
                {
                    MessageBox.Show(
                        "¡Detalle de pedido guardado correctamente!",
                        "Guardar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarDetallePedidos();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el detalle:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btmModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdDetalle.Text))
                {
                    MessageBox.Show(
                        "Seleccione un detalle del DataGridView.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (string.IsNullOrWhiteSpace(txtIdPedido.Text))
                {
                    MessageBox.Show(
                        "Ingrese el ID del pedido.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtIdPedido.Focus();
                    return;
                }

                if (numCantidad.Value <= 0)
                {
                    MessageBox.Show(
                        "La cantidad debe ser mayor que 0.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    numCantidad.Focus();
                    return;
                }

                ESFE.RestauranteBD.EN.DetallePedidos detalle =
                    new ESFE.RestauranteBD.EN.DetallePedidos
                    {
                        IdDetalle = txtIdDetalle.Text.Trim(),
                        IdPedido = txtIdPedido.Text.Trim(),
                        Cantidad = Convert.ToInt32(numCantidad.Value)
                    };

                bool resultado = detallePedidosLN.Actualizar(detalle);

                if (resultado)
                {
                    MessageBox.Show(
                        "¡Detalle de pedido actualizado correctamente!",
                        "Actualizar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarDetallePedidos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo actualizar el detalle.",
                        "Actualizar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar el detalle:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdDetalle.Text))
                {
                    MessageBox.Show(
                        "Seleccione un detalle.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar este detalle?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    bool resultado =
                        detallePedidosLN.Eliminar(
                            txtIdDetalle.Text.Trim());

                    if (resultado)
                    {
                        MessageBox.Show(
                            "Detalle eliminado correctamente.",
                            "Eliminar",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        LimpiarCampos();
                        CargarDetallePedidos();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se pudo eliminar el detalle.",
                            "Eliminar",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el detalle:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtIdDetalle.Clear();
            txtIdPedido.Clear();
            numCantidad.Value = 1;

            lblNombreProducto.Text = "[ Nombre del Producto ]";

            txtIdDetalle.Focus();
        }

        private void dgvDetallePedidos_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila =
                    dgvDetallePedidos.Rows[e.RowIndex];

                txtIdDetalle.Text =
                    fila.Cells["IdDetalle"].Value?.ToString() ?? "";

                txtIdPedido.Text =
                    fila.Cells["IdPedido"].Value?.ToString() ?? "";

                if (fila.Cells["Cantidad"].Value != null)
                {
                    int cantidad =
                        Convert.ToInt32(
                            fila.Cells["Cantidad"].Value);

                    if (cantidad >= numCantidad.Minimum &&
                        cantidad <= numCantidad.Maximum)
                    {
                        numCantidad.Value = cantidad;
                    }
                }
            }
        }

        private void DetallePedidos_Load(object sender, EventArgs e)
        {
            CargarDetallePedidos();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void lblNombreProducto_Click(object sender, EventArgs e)
        {
        }
    }
}