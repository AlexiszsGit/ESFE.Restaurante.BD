using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ESFE.RestauranteBD.UI;
using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmMenu : Form
    {
        private readonly MenuLN menuLN;

        public FrmMenu()
        {
            InitializeComponent();
            menuLN = new MenuLN();
        }

        // Método auxiliar para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtIdPedido.Clear();
            txtIdCategoria.Clear();
            txtIdPostre.Clear();
            txtIdProducto.Clear();
            txtIdBebida.Clear();
            txtIdPedido.Focus();
        }

        // Método auxiliar para obtener la entidad cargada con los datos de la pantalla
        private MenuEN ObtenerDatosFormulario()
        {
            return new MenuEN
            {
                IdPedido = string.IsNullOrWhiteSpace(txtIdPedido.Text) ? null : txtIdPedido.Text.Trim(),
                IdCategoria = string.IsNullOrWhiteSpace(txtIdCategoria.Text) ? null : txtIdCategoria.Text.Trim(),
                IdPostre = string.IsNullOrWhiteSpace(txtIdPostre.Text) ? null : txtIdPostre.Text.Trim(),
                IdProducto = string.IsNullOrWhiteSpace(txtIdProducto.Text) ? null : txtIdProducto.Text.Trim(),
                IdBebida = string.IsNullOrWhiteSpace(txtIdBebida.Text) ? null : txtIdBebida.Text.Trim()
            };
        }

        // Evento Botón Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                MenuEN menu = ObtenerDatosFormulario();

                if (menuLN.agregar(menu))
                {
                    MessageBox.Show("Registro guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento Botón Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MenuEN pMenu = ObtenerDatosFormulario();
                List<MenuEN> lista = menuLN.Buscar(pMenu);

                dgvMenu.DataSource = null;
                dgvMenu.DataSource = lista;

                dgvMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (lista.Count == 0)
                {
                    MessageBox.Show("No se encontraron registros.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento Botón Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdPedido.Text))
                {
                    MessageBox.Show("Debe ingresar un IdPedido para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirmacion = MessageBox.Show(
                    "¿Está seguro de que desea eliminar este registro?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacion == DialogResult.Yes)
                {
                    MenuEN menu = ObtenerDatosFormulario();

                    if (menuLN.Eliminar(menu))
                    {
                        MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();

                        // Limpia el DataGridView tras la eliminación
                        dgvMenu.DataSource = null;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el registro o no se pudo eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evento Botón Limpiar
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            dgvMenu.DataSource = null;
        }

        // Evento opcional para cargar los campos al hacer clic sobre la tabla (DataGridView)
        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvMenu.CurrentRow != null)
            {
                txtIdPedido.Text = dgvMenu.CurrentRow.Cells["IdPedido"].Value?.ToString();
                txtIdCategoria.Text = dgvMenu.CurrentRow.Cells["IdCategoria"].Value?.ToString();
                txtIdPostre.Text = dgvMenu.CurrentRow.Cells["IdPostre"].Value?.ToString();
                txtIdProducto.Text = dgvMenu.CurrentRow.Cells["IdProducto"].Value?.ToString();
                txtIdBebida.Text = dgvMenu.CurrentRow.Cells["IdBebida"].Value?.ToString();
            }
        }
    }
}