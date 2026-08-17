using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
        
            private void btnNuevo_Click(object sender, EventArgs e)
        {
            // 1. Limpiar los campos de texto
            txtNombre.Clear();
            txtDescripcion.Clear();

            // 2. Si este botón fuera para abrir otro formulario (ej. Mesas):
            // FrmMesa frm = new FrmMesa();
            // frm.Show(); 
        }

        private void nudPrecio_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

