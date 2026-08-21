using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmDescuentos : Form
    {
        private readonly DescuentosLN descuentosLN;

        // Guarda el ID original para poder modificarlo
        private string idAnterior = "";

        public FrmDescuentos()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            descuentosLN = new DescuentosLN();

            // Eventos del buscador
            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
            txtBuscar.KeyDown += txtBuscar_KeyDown;

            txtBuscar.Text = "Buscar descuentos";
            txtBuscar.ForeColor = Color.Gray;
        }

        private void FrmDescuentos_Load(object sender, EventArgs e)
        {
            CargarDescuentos();
        }

        private void CargarDescuentos()
        {
            try
            {
                List<Descuentos> lista = descuentosLN.Buscar("");

                dgvDescuentos.DataSource = null;
                dgvDescuentos.DataSource = lista;
                dgvDescuentos.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los descuentos:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdDescuento.Text))
                {
                    MessageBox.Show(
                        "Ingrese el ID del descuento.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtIdDescuento.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre del descuento.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return;
                }

                if (numPorcentaje.Value <= 0)
                {
                    MessageBox.Show(
                        "El porcentaje debe ser mayor que 0.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    numPorcentaje.Focus();
                    return;
                }

                Descuentos descuento = new Descuentos();

                descuento.IdDescuento = txtIdDescuento.Text.Trim();
                descuento.Nombre = txtNombre.Text.Trim();
                descuento.Porcentaje = numPorcentaje.Value;

                bool resultado = descuentosLN.Insertar(descuento);

                if (resultado)
                {
                    MessageBox.Show(
                        "Descuento guardado correctamente.",
                        "Guardar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarDescuentos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo guardar el descuento.",
                        "Guardar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el descuento:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(idAnterior))
                {
                    MessageBox.Show(
                        "Seleccione un descuento de la tabla antes de modificar.",
                        "Modificar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (string.IsNullOrWhiteSpace(txtIdDescuento.Text))
                {
                    MessageBox.Show(
                        "Ingrese el ID del descuento.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtIdDescuento.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre del descuento.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return;
                }

                if (numPorcentaje.Value <= 0)
                {
                    MessageBox.Show(
                        "El porcentaje debe ser mayor que 0.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    numPorcentaje.Focus();
                    return;
                }

                Descuentos descuento = new Descuentos();

                descuento.IdDescuento = txtIdDescuento.Text.Trim();
                descuento.Nombre = txtNombre.Text.Trim();
                descuento.Porcentaje = numPorcentaje.Value;

                bool resultado =
                    descuentosLN.Actualizar(descuento, idAnterior);

                if (resultado)
                {
                    MessageBox.Show(
                        "Descuento modificado correctamente.",
                        "Modificar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarDescuentos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo modificar el descuento.",
                        "Modificar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al modificar el descuento:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdDescuento.Text))
                {
                    MessageBox.Show(
                        "Seleccione un descuento para eliminar.",
                        "Eliminar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string idEliminar = txtIdDescuento.Text.Trim();

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar el descuento?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    bool resultado =
                        descuentosLN.Eliminar(idEliminar);

                    if (resultado)
                    {
                        MessageBox.Show(
                            "Descuento eliminado correctamente.",
                            "Eliminar",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        CargarDescuentos();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se pudo eliminar el descuento.",
                            "Eliminar",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el descuento:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtIdDescuento.Clear();
            txtNombre.Clear();

            numPorcentaje.Value = numPorcentaje.Minimum;

            idAnterior = "";

            txtIdDescuento.Focus();
        }

        private void dgvDescuentos_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow fila =
                    dgvDescuentos.Rows[e.RowIndex];

                txtIdDescuento.Text =
                    fila.Cells["IdDescuento"].Value?.ToString() ?? "";

                txtNombre.Text =
                    fila.Cells["Nombre"].Value?.ToString() ?? "";

                if (fila.Cells["Porcentaje"].Value != null)
                {
                    numPorcentaje.Value =
                        Convert.ToDecimal(
                            fila.Cells["Porcentaje"].Value);
                }

                // Guardamos el ID original
                idAnterior = txtIdDescuento.Text.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al seleccionar el descuento:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txtBuscar.Text.Trim();

                if (texto == "Buscar descuentos")
                {
                    texto = "";
                }

                List<Descuentos> lista =
                    descuentosLN.BuscarPorNombre(texto);

                dgvDescuentos.DataSource = null;
                dgvDescuentos.DataSource = lista;
                dgvDescuentos.Refresh();

                // Limpia lo escrito y vuelve a poner el placeholder
                txtBuscar.Text = "Buscar descuentos";
                txtBuscar.ForeColor = Color.Gray;

                if (lista.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron descuentos.",
                        "Búsqueda",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar el descuento:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar descuentos")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Buscar descuentos";
                txtBuscar.ForeColor = Color.Gray;
            }
        }

        private void txtBuscar_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(sender, e);

                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}