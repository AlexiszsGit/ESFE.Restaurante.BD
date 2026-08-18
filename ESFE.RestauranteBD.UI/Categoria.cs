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
    public partial class Categoria : Form
    {
        private readonly CategoriaLN categoriaLN;

        public Categoria()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            categoriaLN = new CategoriaLN();

            CargarCategorias();
        }

        private void CargarCategorias()
        {
            try
            {
                List<ESFE.RestauranteBD.EN.Categoria> lista =
                    categoriaLN.Buscar("");

                dgvCategorias.DataSource = null;
                dgvCategorias.DataSource = lista;
                dgvCategorias.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las categorías:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdCategoria.Text))
                {
                    MessageBox.Show(
                        "Ingrese el ID de la categoría.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtIdCategoria.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre de la categoría.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return;
                }

                ESFE.RestauranteBD.EN.Categoria categoria =
                    new ESFE.RestauranteBD.EN.Categoria
                    {
                        IdCategoria = txtIdCategoria.Text.Trim(),
                        Nombre = txtNombre.Text.Trim()
                    };

                bool resultado = categoriaLN.Insertar(categoria);

                if (resultado)
                {
                    MessageBox.Show(
                        "Categoría guardada correctamente.",
                        "Guardar categoría",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarCategorias();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar la categoría:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdCategoria.Text))
                {
                    MessageBox.Show(
                        "Seleccione una categoría.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre de la categoría.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return;
                }

                ESFE.RestauranteBD.EN.Categoria categoria =
                    new ESFE.RestauranteBD.EN.Categoria
                    {
                        IdCategoria = txtIdCategoria.Text.Trim(),
                        Nombre = txtNombre.Text.Trim()
                    };

                bool resultado = categoriaLN.Actualizar(categoria);

                if (resultado)
                {
                    MessageBox.Show(
                        "Categoría actualizada correctamente.",
                        "Actualizar categoría",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarCategorias();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo actualizar la categoría.",
                        "Actualizar categoría",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar la categoría:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdCategoria.Text))
                {
                    MessageBox.Show(
                        "Seleccione una categoría.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar la categoría?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    bool resultado =
                        categoriaLN.Eliminar(txtIdCategoria.Text.Trim());

                    if (resultado)
                    {
                        MessageBox.Show(
                            "Categoría eliminada correctamente.",
                            "Eliminar categoría",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        LimpiarCampos();
                        CargarCategorias();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se pudo eliminar la categoría.",
                            "Eliminar categoría",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar la categoría:\n\n" + ex.Message,
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
            txtIdCategoria.Clear();
            txtNombre.Clear();
            txtIdCategoria.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();

                List<ESFE.RestauranteBD.EN.Categoria> lista =
                    categoriaLN.BuscarPorNombre(nombre);

                dgvCategorias.DataSource = null;
                dgvCategorias.DataSource = lista;
                dgvCategorias.Refresh();

                if (lista.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron categorías con ese nombre.",
                        "Búsqueda",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar la categoría:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void Categoria_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void dgvCategoria_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvCategorias.Rows[e.RowIndex];

                txtIdCategoria.Text =
                    fila.Cells["IdCategoria"].Value?.ToString() ?? "";

                txtNombre.Text =
                    fila.Cells["Nombre"].Value?.ToString() ?? "";
            }
        }

        private void txtIdCategoria_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
        }
    }
}