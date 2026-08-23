using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmMenu : Form
    {
        // Instancia de la Capa de Negocio
        private MenuLN menuLN = new MenuLN(); // Usamos MenuLN para el módulo de menú

        public FrmMenu()
        {
            InitializeComponent();
            CargarMenus(); // Se llama aquí para cargar la tabla al abrir el formulario
        }

        // Método para llenar el DataGridView
        private void CargarMenus()
        {
            dgvMenu.DataSource = menuLN.Buscar(string.Empty);
        }

        // Botón AGREGAR
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPedido.Text))
                {
                    MessageBox.Show(
                        "Ingrese el ID del Pedido.",
                        "Validación de Campos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtPedido.Focus();
                    return;
                }

                MenuEN menu = new MenuEN
                {
                    IdPedido = txtPedido.Text.Trim(),
                    IdPostre = string.IsNullOrWhiteSpace(txtPostre.Text) ? null : txtPostre.Text.Trim(),
                    IdBebida = string.IsNullOrWhiteSpace(txtBebida.Text) ? null : txtBebida.Text.Trim(),
                    IdProducto = string.IsNullOrWhiteSpace(txtProducto.Text) ? null : txtProducto.Text.Trim(),
                    IdCategoria = string.IsNullOrWhiteSpace(txtCategoria.Text) ? null : txtCategoria.Text.Trim()
                };

                bool resultado = menuLN.Insertar(menu);

                if (resultado)
                {
                    MessageBox.Show(
                        "¡Registro guardado exitosamente!",
                        "Operación Exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarMenus();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo guardar el registro en la base de datos.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al intentar guardar:\n\n" + ex.Message,
                    "Error del Sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //// Botón ACTUALIZAR
        //private void btnActualizar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        Platillo platillo = new Platillo();
        //        platillo.IdProducto = txtPedido.Text.Trim();
        //        platillo.Nombre = txtPostre.Text.Trim();
        //        platillo.Precio = txtCategoria.Text.Convert.ToDecimal();
        //        platillo.IdCategoria = txtProducto.Text.Trim();

        //        bool resultado = platillosLN.Actualizar(platillo);

        //        if (resultado)
        //        {
        //            MessageBox.Show("Platillo actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            LimpiarCampos();
        //        }
        //        else
        //        {
        //            MessageBox.Show("No se pudo actualizar el registro.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al actualizar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //// Botón ELIMINAR
        //private void btnEliminar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (!string.IsNullOrEmpty(txtPedido.Text))
        //        {
        //           // bool resultado = platillosLN.Eliminar(txtPedido.Text.Trim());

        //           // if (resultado)
        //            {
        //                MessageBox.Show("Platillo eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                LimpiarCampos();
        //            }
        //            else
        //            {
        //                MessageBox.Show("No se pudo eliminar el registro.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("Por favor ingrese o seleccione un ID.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        // Botón LIMPIAR / NUEVO
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // Método auxiliar para limpiar las cajas de texto
        private void LimpiarCampos()
        {
            // Limpieza de cajas de texto
            txtPedido.Clear();
            txtPostre.Clear();
            txtBebida.Clear();
            txtCategoria.Clear();
            txtProducto.Clear();

            // Limpieza de selección o datos de la tabla
            if (dgvMenu.DataSource != null)
            {
                dgvMenu.DataSource = null; // Quita los datos del DataGridView
            }

            // Posicionar el cursor listo para escribir
            txtPedido.Focus();
        }

        private void label5_Click(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void numPrecio_ValueChanged(object sender, EventArgs e) { }


        private void lblId_Click(object sender, EventArgs e)
        {

        }

     

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtenemos el texto ingresado en el campo Pedido
                string idPedido = txtPedido.Text.Trim();

                // 2. Realizamos la búsqueda a través de la capa LN
                // Si 'idPedido' lleva texto, filtrará por ese id; si está vacío (""), traerá todos los registros.
                List<MenuEN> lista = menuLN.Buscar(idPedido);

                // 3. Limpiamos y asignamos la nueva lista al DataGridView
                dgvMenu.DataSource = null;
                dgvMenu.DataSource = lista;
                dgvMenu.Refresh();

                // 4. Si no se encontraron coincidencias, mostramos un mensaje informativo
                if (lista == null || lista.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron registros de menú que coincidan con la búsqueda.",
                        "Búsqueda sin Resultados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al realizar la búsqueda:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMenu.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, selecciona una fila en la tabla para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Recuperamos los datos de la fila seleccionada
                MenuEN menuSeleccionado = (MenuEN)dgvMenu.CurrentRow.DataBoundItem;

                DialogResult respuesta = MessageBox.Show($"¿Deseas eliminar el registro del Pedido: {menuSeleccionado.IdPedido}?",
                                                         "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    bool eliminado = menuLN.Eliminar(menuSeleccionado);

                    if (eliminado)
                    {
                        MessageBox.Show("Registro eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnBuscar_Click(sender, e); // Refresca la tabla
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }

}

    