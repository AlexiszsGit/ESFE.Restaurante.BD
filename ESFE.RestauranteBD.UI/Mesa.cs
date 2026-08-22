using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.BL;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmMesa : Form
    {
        private MesaLN mesaLN = new MesaLN();

        public FrmMesa()
        {
            InitializeComponent();
        }

        private void Mesa_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CargarGrid()
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = mesaLN.Buscar("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las mesas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Guardar (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNumeroMesa.Text))
                {
                    MessageBox.Show("Ingrese el número o identificador de la mesa.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Mesa mesa = new Mesa();

                // Mapeo a las propiedades de tu Entidad
                // SI ESTAS TRES LÍNEAS MARCAN ROJO, MIRA EL PASO 2 ABAJO
                mesa.IdMesa = txtNumeroMesa.Text.Trim();
                mesa.Capacidad = Convert.ToInt32(nudCapacidad.Value);

                string estado = cmbEstado.SelectedItem != null ? cmbEstado.SelectedItem.ToString().ToUpper() : "SI";
                mesa.Disponible = (estado.StartsWith("L") || estado == "SI") ? "SI" : "NO";

                bool resultado = mesaLN.Insertar(mesa);

                if (resultado)
                {
                    MessageBox.Show("Mesa guardada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                    LimpiarFormulario();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Eliminar (button3)
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNumeroMesa.Text))
                {
                    MessageBox.Show("Seleccione una mesa para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("¿Desea eliminar la mesa seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool resultado = mesaLN.Eliminar(txtNumeroMesa.Text.Trim());

                    if (resultado)
                    {
                        MessageBox.Show("Mesa eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                        LimpiarFormulario();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNumeroMesa.Text))
                {
                    MessageBox.Show("Seleccione una mesa primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Mesa mesa = new Mesa();
                mesa.IdMesa = txtNumeroMesa.Text.Trim();
                mesa.Capacidad = Convert.ToInt32(nudCapacidad.Value);

                string estado = cmbEstado.Text.Trim().ToUpper();
                mesa.Disponible = (estado == "SI" || estado == "LIBRE") ? "SI" : "NO";

                // 1. Guarda los cambios en SQL Server
                mesaLN.Actualizar(mesa);
                // 2. Refresca la tabla en pantalla (esto es lo que carga los datos)
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = mesaLN.Buscar(""); // <-- REVISA ESTO ABAJO
                dataGridView1.Refresh();
                // 3. Limpia los campos
                LimpiarFormulario();

                MessageBox.Show("¡Mesa modificada correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void LimpiarFormulario()
        {
            txtNumeroMesa.Clear();
            nudCapacidad.Value = 1; // Resetea el control numérico a 1

            if (cmbEstado.Items.Count > 0)
            {
                cmbEstado.SelectedIndex = 0; // Vuelve al primer elemento (ej. 'Libre' / 'SI')
            }
            else
            {
                cmbEstado.Text = ""; // Si es texto libre, lo borra
            }

            txtNumeroMesa.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                // Asigna el ID quitando espacios
                txtNumeroMesa.Text = fila.Cells[0].Value?.ToString().Trim();

                if (fila.Cells[1].Value != null)
                {
                    nudCapacidad.Value = Convert.ToDecimal(fila.Cells[1].Value);
                }

                string disp = fila.Cells[2].Value?.ToString().Trim().ToUpper();

                // Asignamos directamente SI o NO para no confundir la lógica
                cmbEstado.Text = (disp == "SI" || disp == "LIBRE") ? "SI" : "NO";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    
    private void nudCapacidad_ValueChanged(object sender, EventArgs e)
        {
          
        }
    }
}
    
