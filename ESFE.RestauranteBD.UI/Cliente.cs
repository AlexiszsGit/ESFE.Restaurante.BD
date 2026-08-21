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
        private string idClienteOriginal = "";

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

        private void btnModificar_Click(
    object sender,
    EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(idClienteOriginal))
                {
                    MessageBox.Show(
                        "Primero seleccione un cliente de la tabla.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtIdCliente.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nuevo ID del cliente.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre del cliente.");
                    return;
                }

                Cliente cliente = new Cliente();

                cliente.IdCliente =
                    txtIdCliente.Text.Trim();

                cliente.Nombre =
                    txtNombre.Text.Trim();

                cliente.Telefono =
                    txtTelefono.Text.Trim();

                bool resultado = clienteLN.Actualizar(
                    cliente,
                    idClienteOriginal);

                if (resultado)
                {
                    MessageBox.Show(
                        "Cliente modificado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    idClienteOriginal = "";

                    CargarClientes();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró el cliente para modificar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al modificar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdCliente.Text))
                {
                    MessageBox.Show("Seleccione un cliente para eliminar.");
                    return;
                }

                DialogResult confirmar = MessageBox.Show(
                    "¿Está seguro de eliminar este cliente?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirmar != DialogResult.Yes)
                    return;

                bool resultado = clienteLN.Eliminar(txtIdCliente.Text.Trim());

                if (resultado)
                {
                    MessageBox.Show(
                        "Cliente eliminado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarClientes();
                    LimpiarCampos();

                    idClienteOriginal = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar: " + ex.Message,
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

        private void dgvClientes_CellClick(
     object sender,
     DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila =
                        dgvClientes.Rows[e.RowIndex];

                    txtIdCliente.Text =
                        Convert.ToString(
                            fila.Cells["IdCliente"].Value) ?? "";

                    txtNombre.Text =
                        Convert.ToString(
                            fila.Cells["Nombre"].Value) ?? "";

                    txtTelefono.Text =
                        Convert.ToString(
                            fila.Cells["Telefono"].Value) ?? "";

                    // Guardamos el ID original
                    idClienteOriginal = txtIdCliente.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al seleccionar el cliente: " + ex.Message);
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

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txtBuscar.Text.Trim();

                if (string.IsNullOrWhiteSpace(texto))
                {
                    CargarClientes();
                    return;
                }

                List<Cliente> resultados = clienteLN.Buscar(texto);

                dgvClientes.DataSource = null;
                dgvClientes.DataSource = resultados;

                if (resultados.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron clientes.",
                        "Búsqueda",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                // Borra automáticamente lo escrito en la búsqueda
                txtBuscar.Clear();

                // Regresa el cursor al campo de búsqueda
                txtBuscar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar cliente: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


    }
    }
