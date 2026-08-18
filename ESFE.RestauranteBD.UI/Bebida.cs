using ESFE.RestauranteBD.LN;

namespace ESFE.RestauranteBD.UI
{
    public partial class Bebida : Form
    {
        private readonly BebidaLN bebidaLN;

        public Bebida()
        {
            InitializeComponent();

            // Configuración del formulario
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Inicializar LN
            bebidaLN = new BebidaLN();

            // Cargar bebidas
            CargarBebidas();
        }

        private void CargarBebidas()
        {
            try
            {
                List<ESFE.RestauranteBD.EN.Bebida> lista =
                    bebidaLN.Buscar("");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las bebidas:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar ID
                if (string.IsNullOrWhiteSpace(txtIDBebida.Text))
                {
                    MessageBox.Show(
                        "Ingrese el ID de la bebida.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtIDBebida.Focus();
                    return;
                }

                // Validar nombre
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre de la bebida.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return;
                }

                // Validar precio
                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                {
                    MessageBox.Show(
                        "Ingrese un precio válido.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtPrecio.Focus();
                    return;
                }

                // Crear objeto Bebida
                ESFE.RestauranteBD.EN.Bebida bebida =
                    new ESFE.RestauranteBD.EN.Bebida
                    {
                        IdBebida = txtIDBebida.Text.Trim(),
                        Nombre = txtNombre.Text.Trim(),
                        Precio = precio
                    };

                // Insertar en la base de datos
                bool resultado = bebidaLN.Insertar(bebida);

                if (resultado)
                {
                    MessageBox.Show(
                        "¡Bebida guardada correctamente!",
                        "Guardar Bebida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Actualizar DataGridView
                    CargarBebidas();

                    // Limpiar campos
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo guardar la bebida.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar la bebida:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtIDBebida.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();

            txtIDBebida.Focus();
        }

       
        private void dataGridView1_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                // Verificar que sea una fila válida
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila =
                        dataGridView1.Rows[e.RowIndex];

                    txtIDBebida.Text =
                        fila.Cells["IdBebida"].Value?.ToString() ?? "";

                    txtNombre.Text =
                        fila.Cells["Nombre"].Value?.ToString() ?? "";

                    txtPrecio.Text =
                        fila.Cells["Precio"].Value?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al seleccionar la bebida:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();

                List<ESFE.RestauranteBD.EN.Bebida> lista =
                    bebidaLN.BuscarPorNombre(nombre);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;
                dataGridView1.Refresh();

                if (lista.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron bebidas con ese nombre.",
                        "Búsqueda",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar la bebida:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar ID
                if (string.IsNullOrWhiteSpace(txtIDBebida.Text))
                {
                    MessageBox.Show(
                        "Seleccione una bebida del DataGridView.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Validar nombre
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre de la bebida.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return;
                }

                // Validar precio
                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                {
                    MessageBox.Show(
                        "Ingrese un precio válido.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtPrecio.Focus();
                    return;
                }

                // Crear objeto
                ESFE.RestauranteBD.EN.Bebida bebida =
                    new ESFE.RestauranteBD.EN.Bebida
                    {
                        IdBebida = txtIDBebida.Text.Trim(),
                        Nombre = txtNombre.Text.Trim(),
                        Precio = precio
                    };

                // Actualizar
                bool resultado = bebidaLN.Actualizar(bebida);

                if (resultado)
                {
                    MessageBox.Show(
                        "¡Bebida actualizada correctamente!",
                        "Actualizar Bebida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarBebidas();

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo actualizar la bebida.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar la bebida:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar ID
                if (string.IsNullOrWhiteSpace(txtIDBebida.Text))
                {
                    MessageBox.Show(
                        "Seleccione una bebida.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Confirmar eliminación
                DialogResult respuesta = MessageBox.Show(
                    "¿Está seguro de eliminar la bebida?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    bool resultado =
                        bebidaLN.Eliminar(txtIDBebida.Text.Trim());

                    if (resultado)
                    {
                        MessageBox.Show(
                            "Bebida eliminada correctamente.",
                            "Eliminar Bebida",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        Limpiar();

                        CargarBebidas();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se pudo eliminar la bebida.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar la bebida:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

       
        private void Bebida_Load(object sender, EventArgs e)
        {
            CargarBebidas();
        }

      
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }
    }
}