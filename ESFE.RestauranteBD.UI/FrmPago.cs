using ESFE.RestauranteBD.DAL;
using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmPago : Form
    {
        PagoLN pagoLN = new PagoLN();
        public FrmPago()
        {
            InitializeComponent();
        }

        private void FrmPago_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Pago pago = new Pago
                {
                    IdPago = txtIdPago.Text.Trim(),
                    IdPedido = txtIdPedido.Text.Trim(),
                    IdMetodo = txtIdMetodoPago.Text.Trim()
                };

                List<Pago> resultados = pagoLN.Buscar(pago);

                if (resultados.Count > 0)
                {
                    dgvPago.DataSource = resultados;
                }
                else
                {
                    dgvPago.DataSource = null;
                    MessageBox.Show("No se encontraron registros de pago que coincidan con la búsqueda.",
                                    "Búsqueda sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar registros:\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos vacíos principales
                if (string.IsNullOrWhiteSpace(txtIdPago.Text) ||
                    string.IsNullOrWhiteSpace(txtIdPedido.Text) ||
                    string.IsNullOrWhiteSpace(txtIdMetodoPago.Text))
                {
                    MessageBox.Show("Por favor, completa los campos requeridos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Pago pago = new Pago
                {
                    IdPago = txtIdPago.Text.Trim(),
                    total = nudMonto.Value,
                    fechaPago = dtpFechaPago.Value,
                    IdPedido = txtIdPedido.Text.Trim(),
                    IdMetodo = txtIdMetodoPago.Text.Trim()
                };

                int resultado = pagoLN.Agregar(pago);

                if (resultado > 0)
                {
                    MessageBox.Show("Pago guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBuscar_Click(sender, e); // Recarga la grilla con el nuevo registro
                }
                else
                {
                    MessageBox.Show("No se pudo registrar el pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar pago: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string idPago = txtIdPago.Text.Trim();

                if (string.IsNullOrWhiteSpace(idPago))
                {
                    MessageBox.Show("Por favor, ingresa el ID del pago que deseas eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult respuesta = MessageBox.Show($"¿Deseas eliminar el pago {idPago}?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    int filasAfectadas = pagoLN.Eliminar(idPago);

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Pago eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnBuscar_Click(sender, e); // Refresca la lista
                    }
                    else
                    {
                        MessageBox.Show("No se encontró ningún registro con ese ID. Revisa si falta el guion bajo (Ejemplo: PG_06).", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            // Limpia las cajas de texto
            txtIdPago.Clear();
            txtIdPedido.Clear();
            txtIdMetodoPago.Clear();

            // Restablece el valor numérico a cero y borra su texto
            nudMonto.Value = 0;
            nudMonto.Text = "";

            // Deja visualmente vacía la fecha
            dtpFechaPago.Format = DateTimePickerFormat.Custom;
            dtpFechaPago.CustomFormat = " ";

            // Limpia las filas del DataGridView
            if (dgvPago.DataSource != null)
            {
                dgvPago.DataSource = null;
            }
            else
            {
                dgvPago.Rows.Clear();
            }

            // Coloca el foco de escritura en el primer campo
            txtIdPago.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dtpFechaPago_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaPago.Format = DateTimePickerFormat.Short;
        }
    }

}
