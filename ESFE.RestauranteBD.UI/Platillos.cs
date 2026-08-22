using System;
using System.Windows.Forms;
using ESFE.RestauranteBD.DAL;
using ESFE.RestauranteBD.EN;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmPlatillos : Form
    {
        private PlatillosDAL platilloDAL = new PlatillosDAL();

        public FrmPlatillos()
        {
            InitializeComponent();
            RefrescarGrid();

            // Asignar evento de clic en el DataGridView
            if (dgvPlatillos != null)
            {
                dgvPlatillos.CellClick += dgvPlatillos_CellClick;
            }
        }

        private void RefrescarGrid()
        {
            try
            {
                // Busca el DataGridView del formulario y refresca los datos desde SQL
                foreach (Control c in this.Controls)
                {
                    if (c is DataGridView dgv)
                    {
                        dgv.DataSource = null;
                        dgv.DataSource = platilloDAL.ObtenerPlatillos();
                        dgv.Refresh();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtProducto.Clear();
            txtNombre.Clear();
            nudPrecio.Value = 0;
            cmbCategoria.SelectedIndex = -1;
            txtDescuento.Clear();
            txtProducto.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el ID del producto y el nombre.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Platillo p = new Platillo
            {
                IdProducto = txtProducto.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Precio = nudPrecio.Value,
                IdCategoria = string.IsNullOrWhiteSpace(cmbCategoria.Text) ? null : cmbCategoria.Text.Trim(),
                IdDescuento = string.IsNullOrWhiteSpace(txtDescuento.Text) ? null : txtDescuento.Text.Trim()
            };

            try
            {
                if (platilloDAL.Insertar(p))
                {
                    MessageBox.Show("Guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarGrid();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo insertar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR SQL: " + ex.Message, "Error en Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MessageBox.Show("Seleccione o ingrese el ID del platillo que desea modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Platillo p = new Platillo
            {
                IdProducto = txtProducto.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Precio = nudPrecio.Value,
                IdCategoria = string.IsNullOrWhiteSpace(cmbCategoria.Text) ? null : cmbCategoria.Text.Trim(),
                IdDescuento = string.IsNullOrWhiteSpace(txtDescuento.Text) ? null : txtDescuento.Text.Trim()
            };

            try
            {
                if (platilloDAL.Modificar(p))
                {
                    MessageBox.Show("Modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarGrid();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún platillo con el ID especificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR SQL: " + ex.Message, "Error al Modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MessageBox.Show("Seleccione un registro de la tabla para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Desea eliminar el platillo '" + txtProducto.Text.Trim() + "'?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (platilloDAL.Eliminar(txtProducto.Text.Trim()))
                    {
                        MessageBox.Show("Eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefrescarGrid();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR SQL: " + ex.Message, "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvPlatillos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && sender is DataGridView dgv)
            {
                DataGridViewRow fila = dgv.Rows[e.RowIndex];
                txtProducto.Text = fila.Cells["id_producto"].Value?.ToString();
                txtNombre.Text = fila.Cells["nombre"].Value?.ToString();

                if (decimal.TryParse(fila.Cells["precio"].Value?.ToString(), out decimal precio))
                {
                    nudPrecio.Value = precio;
                }

                cmbCategoria.Text = fila.Cells["id_categoria"].Value?.ToString();
                txtDescuento.Text = fila.Cells["id_descuento"].Value?.ToString();
            }
        }
    }
}