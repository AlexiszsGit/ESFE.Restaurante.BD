using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmTipoEmpleado : Form
    {
        private TipoEmpleadoLN tipoEmpleadoLN = new TipoEmpleadoLN();
        private string idViejo = "";

        public FrmTipoEmpleado()
        {
            InitializeComponent();
        }

        private void FrmTipoEmpleado_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CargarGrid()
        {
            dataGridView1.DataSource = tipoEmpleadoLN.Buscar("");
        }

        private void VaciarCampos()
        {
            txtIdTipo.Clear();
            txtNombre.Clear();

            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;

            idViejo = string.Empty;
            txtNombre.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];

                txtIdTipo.Text = fila.Cells[0].Value?.ToString().Trim();
                txtNombre.Text = fila.Cells[1].Value?.ToString().Trim();

                idViejo = txtIdTipo.Text;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                TipoEmpleado tipo = new TipoEmpleado
                {
                    IdTipo = txtIdTipo.Text.Trim(),
                    Nombre = txtNombre.Text.Trim()
                };

                if (tipoEmpleadoLN.Insertar(tipo))
                {
                    MessageBox.Show("Guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                    VaciarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(idViejo))
                {
                    MessageBox.Show("Seleccione un registro de la tabla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TipoEmpleado tipo = new TipoEmpleado
                {
                    IdTipo = txtIdTipo.Text.Trim(),
                    Nombre = txtNombre.Text.Trim()
                };

                if (tipoEmpleadoLN.Actualizar(tipo, idViejo))
                {
                    MessageBox.Show("Modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrid();
                    VaciarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdTipo.Text))
                {
                    MessageBox.Show("Seleccione un registro de la tabla para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("¿Está seguro de eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (tipoEmpleadoLN.Eliminar(txtIdTipo.Text.Trim()))
                    {
                        MessageBox.Show("Eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                        VaciarCampos();
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
            VaciarCampos();
        }
    }
}

