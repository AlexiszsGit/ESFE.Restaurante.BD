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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar Nombre
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre del postre.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return;
                }

                // 2. Crear el objeto con los datos del formulario
                Postre postre = new Postre
                {
                    Nombre = txtNombre.Text.Trim(),
                    Precio = nudPrecio.Value
                };

                // 3. Instanciar DAL y ejecutar el método de inserción
                PostreDAL postreDAL = new PostreDAL();
                bool resultado = postreDAL.Insertar(postre);

                // 4. Confirmar y limpiar
                if (resultado)
                {
                    MessageBox.Show(
                        "¡Postre guardado correctamente!",
                        "Guardar Postre",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el postre:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    } //Cirre el metodo button3_Click
}  //Cirre la clase FrmPostres