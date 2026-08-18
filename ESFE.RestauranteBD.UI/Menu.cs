using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmMenu : Form
    {
        // Instancia de la Capa de Negocio
        private PlatillosLN platillosLN = new PlatillosLN();

        public FrmMenu()
        {
            InitializeComponent();
        }

        // Botón AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Platillo platillo = new Platillo();

                // Asignamos las propiedades desde las cajas de texto y controles
                platillo.IdProducto = txtId.Text.Trim();
                platillo.Nombre = txtNombre.Text.Trim();
                platillo.Precio = numPrecio.Value; // NumericUpDown de precio
                platillo.IdCategoria = cbCategoria.Text.Trim(); // ComboBox de categoría

                bool resultado = platillosLN.Insertar(platillo);

                if (resultado)
                {
                    MessageBox.Show("Platillo guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón ACTUALIZAR
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Platillo platillo = new Platillo();
                platillo.IdProducto = txtId.Text.Trim();
                platillo.Nombre = txtNombre.Text.Trim();
                platillo.Precio = numPrecio.Value;
                platillo.IdCategoria = cbCategoria.Text.Trim();

                bool resultado = platillosLN.Actualizar(platillo);

                if (resultado)
                {
                    MessageBox.Show("Platillo actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtId.Text))
                {
                    bool resultado = platillosLN.Eliminar(txtId.Text.Trim());

                    if (resultado)
                    {
                        MessageBox.Show("Platillo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese o seleccione un ID.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón LIMPIAR / NUEVO
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Método auxiliar para limpiar las cajas de texto
        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            numPrecio.Value = 0;
            cbCategoria.SelectedIndex = -1;
            cbEstado.SelectedIndex = -1;
            txtId.Focus();
        }


        private void label5_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void numPrecio_ValueChanged(object sender, EventArgs e) { }
        private void btnNuevo_Click_1(object sender, EventArgs e) { }
    }
}

    