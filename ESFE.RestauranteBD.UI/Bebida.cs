using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ESFE.RestauranteBD.UI
{
    public partial class Bebida : Form
    {
        private List<ESFE.RestauranteBD.EN.Bebida> listaBebidas = new List<ESFE.RestauranteBD.EN.Bebida>();
        public Bebida()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDBebida.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor complete todos los cambios.", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Ingrese un precio valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ESFE.RestauranteBD.EN.Bebida nuevaBebida = new ESFE.RestauranteBD.EN.Bebida
            {
                IdBebida = txtIDBebida.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Precio = precio
            };

            // Guardar en la lista y refrescar el DataGridView
            listaBebidas.Add(nuevaBebida);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaBebidas;

            Limpiar();
            MessageBox.Show("Bebida guardada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- EVENTO BOTÓN LIMPIAR ---
        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        // Método auxiliar para limpiar las cajas de texto
        private void Limpiar()
        {
            txtIDBebida.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtIDBebida.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

