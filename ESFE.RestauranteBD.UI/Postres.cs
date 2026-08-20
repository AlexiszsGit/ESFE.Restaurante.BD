using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ESFE.RestauranteBD.DAL;
using ESFE.RestauranteBD.LN;
using ESFE.RestauranteBD.EN;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmPostres : Form
    {
        public FrmPostres()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }






        private void btnGuardar_Click(object sender, EventArgs e)



        {
            try
            {
                // Validar que el ID del postre no esté vacío
                if (string.IsNullOrWhiteSpace(txtIdPostre.Text))
                {
                    MessageBox.Show("Ingrese el ID del postre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIdPostre.Focus();
                    return;
                }

                // Validar que el Nombre no esté vacío
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Ingrese el nombre del postre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return;
                }

                // Crear el objeto Postre con los 3 valores
                Postre postre = new Postre
                {
                    IdPostre = txtIdPostre.Text.Trim(),
                    Nombre = txtNombre.Text.Trim(),
                    Precio = nudPrecio.Value
                };

                PostreDAL postreDAL = new PostreDAL();
                bool resultado = postreDAL.Insertar(postre);

                if (resultado)
                {
                    MessageBox.Show("¡Postre guardado correctamente en la base de datos!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                    // Limpiar controles
                    txtIdPostre.Clear();
                    txtNombre.Clear();
                    nudPrecio.Value = 0;
                    txtIdPostre.Focus();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el postre.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de SQL:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void CargarGrid()
        {

            {
                try
                {
                    PostreDAL postreDAL = new PostreDAL();
                    // Pasamos una cadena vacía "" a Buscar para que obtenga todos los registros
                    dgvPostres.DataSource = postreDAL.Buscar("");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la lista de postres:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvPostres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            {
                // Verifica que el clic haya sido sobre una fila válida y no en los encabezados
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvPostres.Rows[e.RowIndex];

                    // Copia los datos de la fila seleccionada a los controles del formulario
                    txtIdPostre.Text = fila.Cells["IdPostre"].Value?.ToString();
                    txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();

                    // Convierte y asigna el precio al NumericUpDown
                    if (decimal.TryParse(fila.Cells["Precio"].Value?.ToString(), out decimal precio))
                    {
                        nudPrecio.Value = precio;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)


        {
            txtIdPostre.Clear();
            txtNombre.Clear();
            nudPrecio.Value = 0;
            dgvPostres.ClearSelection(); // Desmarca la fila seleccionada en la tabla
            txtIdPostre.Focus();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            // 1. Validar que haya algo seleccionado (que el ID no esté vacío)
            if (string.IsNullOrWhiteSpace(txtIdPostre.Text))
            {
                MessageBox.Show("Por favor, selecciona un registro de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Confirmación antes de borrar
            DialogResult confirmacion = MessageBox.Show("¿Estás seguro de eliminar este postre?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                // 3. Llamar a la capa de datos
                PostreDAL postreDAL = new PostreDAL();
                bool resultado = postreDAL.Eliminar(txtIdPostre.Text.Trim());

                if (resultado)
                {
                    MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid(); // Recargar la tabla para ver los cambios
                    button1_Click(sender, e); // Limpiar las cajas
                }
                else
                {
                    MessageBox.Show("Error al intentar eliminar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btmModificar_Click(object sender, EventArgs e)
        
        {
            // 1. Validar que haya datos
            if (string.IsNullOrWhiteSpace(txtIdPostre.Text))
            {
                MessageBox.Show("Selecciona un postre de la tabla para modificar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Crear el objeto con los datos actuales de las cajas de texto
            Postre postreActualizado = new Postre();
            postreActualizado.IdPostre = txtIdPostre.Text.Trim();
            postreActualizado.Nombre = txtNombre.Text.Trim();
            postreActualizado.Precio = nudPrecio.Value;

            // 3. Llamar a la capa de datos
            PostreDAL postreDAL = new PostreDAL();
            bool resultado = postreDAL.Actualizar(postreActualizado); // Asegúrate que en tu DAL se llame igual

            if (resultado)
            {
                MessageBox.Show("Registro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrid(); // Recargar la tabla
                button1_Click(sender, e); // Limpiar las cajas
            }
            else
            {
                MessageBox.Show("Error al intentar actualizar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}







