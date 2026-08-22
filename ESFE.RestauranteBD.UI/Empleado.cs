using System;
using System.Windows.Forms;
using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmEmpleado : Form
    {
        string idViejo = "";
        private EmpleadoLN empleadoLN = new EmpleadoLN();
        private string idEmpleadoSeleccionado = "";

        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        // Método central para recargar la tabla al instante
        private void CargarGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = empleadoLN.Buscar("");
            dataGridView1.Refresh();
        }

        // Limpia las cajas de texto y resetea la selección
        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtTipoEmpleado.Clear(); // O el nombre exacto de tu TextBox de id_tipo
            idEmpleadoSeleccionado = "";
            txtNombre.Focus();
        }

        // ================= BOTÓN GUARDAR =================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Ingrese el nombre del empleado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Empleado emp = new Empleado();
                // Generamos un ID o tomamos el que ingreses (ej: E001 o autogenerado)
                emp.IdEmpleado = txtIdEmpleado.Text.Trim();
                emp.Nombre = txtNombre.Text.Trim();
                emp.IdTipo = txtTipoEmpleado.Text.Trim();

                empleadoLN.Insertar(emp);

                CargarGrid();
                LimpiarFormulario();

                MessageBox.Show("Empleado guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= BOTÓN MODIFICAR =================
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdEmpleado.Text))
                {
                    MessageBox.Show("Seleccione un empleado de la tabla para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Empleado emp = new Empleado();
                emp.IdEmpleado = txtIdEmpleado.Text.Trim();
                emp.Nombre = txtNombre.Text.Trim();
                emp.IdTipo = txtTipoEmpleado.Text.Trim();

                empleadoLN.Actualizar(emp, idViejo);

                CargarGrid();
                VaciarCampos();
                MessageBox.Show("¡Empleado modificado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= BOTÓN ELIMINAR =================
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdEmpleado.Text))
                {
                    MessageBox.Show("Seleccione un empleado de la tabla para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de que desea eliminar el empleado " + txtIdEmpleado.Text + "?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    empleadoLN.Eliminar(txtIdEmpleado.Text.Trim());

                    CargarGrid();
                    LimpiarFormulario();
                    MessageBox.Show("¡Empleado eliminado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // 1. MÉTODO QUE LIMPIA LOS CAMPOS
        private void VaciarCampos()
        {
            // Vaciamos los cuadros de texto
            txtIdEmpleado.Clear();
            txtNombre.Clear();
            txtTipoEmpleado.Clear();

            // Quitamos la selección del DataGridView para que no recargue la fila
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;

            // Reiniciamos el ID de control
            idViejo = string.Empty;

            txtNombre.Focus();
        }

        // 2. EVENTO DEL BOTÓN LIMPIAR
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            VaciarCampos();
        }

        // ================= EVENTO AL HACER CLIC EN LA TABLA =================
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                txtIdEmpleado.Text = fila.Cells[0].Value?.ToString().Trim();
                txtNombre.Text = fila.Cells[1].Value?.ToString().Trim();
                txtTipoEmpleado.Text = fila.Cells[2].Value?.ToString().Trim();

                // LÍNEA NUEVA: Guardamos el ID original antes de que lo edites
                idViejo = txtIdEmpleado.Text;
            }
        }

    }
}

