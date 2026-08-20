using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmCliente : Form
    {
        private readonly ClienteLN clienteLN;

        public FrmCliente()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            clienteLN = new ClienteLN();

            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                List<ESFE.RestauranteBD.EN.Cliente> lista =
                    clienteLN.Buscar("");

                dgvClientes.DataSource = null;
                dgvClientes.DataSource = lista;
                dgvClientes.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los clientes:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdCliente.Text))
                {
                    MessageBox.Show(
                        "Ingrese el ID del cliente.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtIdCliente.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre del cliente.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return;
                }

                ESFE.RestauranteBD.EN.Cliente cliente =
                    new ESFE.RestauranteBD.EN.Cliente
                    {
                        IdCliente = txtIdCliente.Text.Trim(),
                        Nombre = txtNombre.Text.Trim(),
                        Telefono = txtTelefono.Text.Trim()
                    };

                bool resultado = clienteLN.Insertar(cliente);

                if (resultado)
                {
                    MessageBox.Show(
                        "¡Cliente guardado correctamente!",
                        "Guardar Cliente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarClientes();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el cliente:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btmModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdCliente.Text))
                {
                    MessageBox.Show(
                        "Seleccione un cliente del DataGridView.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre del cliente.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return;
                }

                ESFE.RestauranteBD.EN.Cliente cliente =
                    new ESFE.RestauranteBD.EN.Cliente
                    {
                        IdCliente = txtIdCliente.Text.Trim(),
                        Nombre = txtNombre.Text.Trim(),
                        Telefono = txtTelefono.Text.Trim()
                    };

                bool resultado = clienteLN.Actualizar(cliente);

                if (resultado)
                {
                    MessageBox.Show(
                        "¡Cliente actualizado correctamente!",
                        "Actualizar Cliente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarClientes();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo actualizar el cliente.",
                        "Actualizar Cliente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar el cliente:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdCliente.Text))
                {
                    MessageBox.Show(
                        "Seleccione un cliente.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar el cliente?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    bool resultado =
                        clienteLN.Eliminar(txtIdCliente.Text.Trim());

                    if (resultado)
                    {
                        MessageBox.Show(
                            "Cliente eliminado correctamente.",
                            "Eliminar Cliente",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        LimpiarCampos();
                        CargarClientes();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se pudo eliminar el cliente.",
                            "Eliminar Cliente",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el cliente:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtIdCliente.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();

            txtIdCliente.Focus();
        }

        private void dgvClientes_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

                txtIdCliente.Text =
                    fila.Cells["IdCliente"].Value?.ToString() ?? "";

                txtNombre.Text =
                    fila.Cells["Nombre"].Value?.ToString() ?? "";

                txtTelefono.Text =
                    fila.Cells["Telefono"].Value?.ToString() ?? "";
            }
        }

        private void txtTelefono_MaskInputRejected(
            object sender,
            MaskInputRejectedEventArgs e)
        {
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }
    }
}