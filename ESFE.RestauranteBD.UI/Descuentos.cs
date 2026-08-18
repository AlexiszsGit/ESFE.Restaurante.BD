using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;

namespace ESFE.RestauranteBD.UI
{
    public partial class Descuentos : Form
    {
        private readonly DescuentosLN descuentosLN;

        public Descuentos()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            descuentosLN = new DescuentosLN();

            CargarDescuentos();
        }

        private void CargarDescuentos()
        {
            try
            {
                List<ESFE.RestauranteBD.EN.Descuentos> lista =
                    descuentosLN.Buscar("");

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
                        "Ingrese el nombre o descripción del descuento.",
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

                ESFE.RestauranteBD.EN.Descuentos descuento =
                    new ESFE.RestauranteBD.EN.Descuentos
                    {
                        IdDescuento = txtIdDescuento.Text.Trim(),
                        Nombre = txtNombre.Text.Trim(),
                        Porcentaje = numPorcentaje.Value
                    };

                bool resultado = descuentosLN.Insertar(descuento);

                if (resultado)
                {
                    MessageBox.Show(
                        "¡Descuento guardado correctamente!",
                        "Guardar Descuento",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarDescuentos();
                    LimpiarCampos();
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
                if (string.IsNullOrWhiteSpace(txtIdDescuento.Text))
                {
                    MessageBox.Show(
                        "Seleccione un descuento del DataGridView.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre o descripción del descuento.",
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

                ESFE.RestauranteBD.EN.Descuentos descuento =
                    new ESFE.RestauranteBD.EN.Descuentos
                    {
                        IdDescuento = txtIdDescuento.Text.Trim(),
                        Nombre = txtNombre.Text.Trim(),
                        Porcentaje = numPorcentaje.Value
                    };

                bool resultado = descuentosLN.Actualizar(descuento);

                if (resultado)
                {
                    MessageBox.Show(
                        "¡Descuento actualizado correctamente!",
                        "Actualizar Descuento",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarDescuentos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo actualizar el descuento.",
                        "Actualizar Descuento",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar el descuento:\n\n" + ex.Message,
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
                        "Seleccione un descuento.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar el descuento?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    bool resultado =
                        descuentosLN.Eliminar(
                            txtIdDescuento.Text.Trim());

                    if (resultado)
                    {
                        MessageBox.Show(
                            "Descuento eliminado correctamente.",
                            "Eliminar Descuento",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        LimpiarCampos();
                        CargarDescuentos();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se pudo eliminar el descuento.",
                            "Eliminar Descuento",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
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
            numPorcentaje.Value = 0;

            txtIdDescuento.Focus();
        }

        private void dgvDescuentos_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila =
                    dgvDescuentos.Rows[e.RowIndex];

                txtIdDescuento.Text =
                    fila.Cells["IdDescuento"].Value?.ToString() ?? "";

                txtNombre.Text =
                    fila.Cells["Nombre"].Value?.ToString() ?? "";

                if (fila.Cells["Porcentaje"].Value != null)
                {
                    decimal porcentaje =
                        Convert.ToDecimal(
                            fila.Cells["Porcentaje"].Value);

                    if (porcentaje >= numPorcentaje.Minimum &&
                        porcentaje <= numPorcentaje.Maximum)
                    {
                        numPorcentaje.Value = porcentaje;
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
        {
                string nombre = txtNombre.Text.Trim();

                List<ESFE.RestauranteBD.EN.Descuentos> lista =
                    descuentosLN.BuscarPorNombre(nombre);

                dgvDescuentos.DataSource = null;
                dgvDescuentos.DataSource = lista;
                dgvDescuentos.Refresh();

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
}
