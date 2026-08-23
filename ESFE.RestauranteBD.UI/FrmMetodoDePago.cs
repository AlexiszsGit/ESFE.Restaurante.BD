using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;

namespace ESFE.RestauranteBD.UI
{
    public partial class frmMetodoDePago : Form
    {
        private MetodoPagoLN metodoPagoLN = new MetodoPagoLN();

        public frmMetodoDePago()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtDescricion.Clear();
            txbNombre.Clear();
            dgvMetodosDePago.DataSource = null;
            txtDescricion.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                MetodoDePago metodo = new MetodoDePago
                {
                    IdMetodoDePago = txtDescricion.Text.Trim(),
                    Nombre = txbNombre.Text.Trim()
                };

                List<MetodoDePago> lista = metodoPagoLN.Buscar(metodo);
                dgvMetodosDePago.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar registros: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDescricion.Text) || string.IsNullOrWhiteSpace(txbNombre.Text))
                {
                    MessageBox.Show("Por favor, completa todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MetodoDePago metodo = new MetodoDePago
                {
                    IdMetodoDePago = txtDescricion.Text.Trim(),
                    Nombre = txbNombre.Text.Trim()
                };

                int resultado = metodoPagoLN.Agregar(metodo);

                if (resultado > 0)
                {
                    MessageBox.Show("Método de pago registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBuscar_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string idMetodo = txtDescricion.Text.Trim();

                if (string.IsNullOrWhiteSpace(idMetodo))
                {
                    MessageBox.Show("Ingresa el ID del método de pago a eliminar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show($"¿Deseas eliminar el registro {idMetodo}?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int resultado = metodoPagoLN.Eliminar(idMetodo);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnBuscar_Click(sender, e);
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
            LimpiarCampos();
        }

        // METODOS REQUERIDOS POR EL DESIGNER PARA QUITAR LOS ERRORES:
        private void dgvMetodosDePago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void grp_Enter(object sender, EventArgs e)
        {
        }
    }
}