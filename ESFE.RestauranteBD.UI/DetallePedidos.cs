using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ESFE.RestauranteBD.LN;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmDetallePedidos : Form
    {
        private readonly DetallePedidosLN detallePedidosLN;

        // Colores
        private readonly Color Fondo = Color.FromArgb(10, 10, 10);
        private readonly Color Panel = Color.FromArgb(24, 24, 24);
        private readonly Color Campo = Color.FromArgb(35, 35, 35);
        private readonly Color Dorado = Color.FromArgb(212, 175, 55);
        private readonly Color DoradoClaro = Color.FromArgb(235, 210, 130);
        private readonly Color Blanco = Color.FromArgb(245, 245, 245);
        private readonly Color Gris = Color.FromArgb(170, 170, 170);
        private readonly Color Borde = Color.FromArgb(55, 55, 55);
        private readonly Color Rojo = Color.FromArgb(155, 45, 45);

        private Panel panelCabecera;
        private Panel panelBusqueda;
        private Panel panelInformacion;
        private Panel panelAcciones;
        private Panel panelTabla;

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblBusqueda;
        private Label lblInformacion;
        private Label lblRegistros;

        private Label lblDetalle;
        private Label lblPedido;
        private Label lblProducto;
        private Label lblCantidad;

        private Label lblProductoNombre;

        public FrmDetallePedidos()
        {
            InitializeComponent();

            detallePedidosLN = new DetallePedidosLN();

            ConfigurarFormulario();
            PrepararControles();
            CrearInterfaz();
            AplicarEstilos();
            CargarDetallePedidos();

            Resize += FrmDetallePedidos_Resize;
        }

        private void ConfigurarFormulario()
        {
            Text = "RESTAURANTEBD | Detalle de pedido";

            StartPosition = FormStartPosition.CenterScreen;

            FormBorderStyle = FormBorderStyle.Sizable;

            MaximizeBox = true;
            MinimizeBox = true;

            WindowState = FormWindowState.Maximized;

            MinimumSize = new Size(1250, 800);

            BackColor = Fondo;

            Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Regular);
        }

        private void PrepararControles()
        {
            OcultarLabels(this);

            RemoverControl(txtBuscar);
            RemoverControl(btnBuscar);

            RemoverControl(txtIdDetalle);
            RemoverControl(txtIdPedido);
            RemoverControl(txtIdProducto);
            RemoverControl(numCantidad);
            RemoverControl(lblNombreProducto);

            RemoverControl(btnGuardar);
            RemoverControl(btmModificar);
            RemoverControl(btnEliminar);
            RemoverControl(btnLimpiar);

            RemoverControl(dgvDetallePedidos);
        }

        private void RemoverControl(Control control)
        {
            if (control != null && control.Parent != null)
            {
                control.Parent.Controls.Remove(control);
            }
        }

        private void OcultarLabels(Control control)
        {
            foreach (Control elemento in control.Controls)
            {
                if (elemento is Label)
                {
                    elemento.Visible = false;
                }

                if (elemento.HasChildren)
                {
                    OcultarLabels(elemento);
                }
            }
        }

        private void CrearInterfaz()
        {
            CrearPaneles();
            CrearTitulos();
            AgregarControles();
            DistribuirInterfaz();
        }

        private void CrearPaneles()
        {
            panelCabecera = CrearPanel();
            panelBusqueda = CrearPanel();
            panelInformacion = CrearPanel();
            panelAcciones = CrearPanel();
            panelTabla = CrearPanel();

            Controls.Add(panelCabecera);
            Controls.Add(panelBusqueda);
            Controls.Add(panelInformacion);
            Controls.Add(panelAcciones);
            Controls.Add(panelTabla);
        }

        private Panel CrearPanel()
        {
            return new Panel
            {
                BackColor = Panel,
                BorderStyle = BorderStyle.None
            };
        }

        private Label CrearEtiqueta(
            string texto,
            float tamaño,
            Color color,
            bool negrita = false)
        {
            return new Label
            {
                Text = texto,
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = color,
                Font = new Font(
                    "Segoe UI",
                    tamaño,
                    negrita
                        ? FontStyle.Bold
                        : FontStyle.Regular)
            };
        }

        private void CrearTitulos()
        {
            lblTitulo = CrearEtiqueta(
                "✦  RESTAURANTEBD",
                28F,
                Dorado,
                true);

            lblSubtitulo = CrearEtiqueta(
                "Detalle de pedido",
                15F,
                Gris,
                true);

            lblBusqueda = CrearEtiqueta(
                "BUSCAR DETALLE",
                13F,
                Dorado,
                true);

            lblInformacion = CrearEtiqueta(
                "INFORMACIÓN DEL PEDIDO",
                13F,
                Dorado,
                true);

            lblRegistros = CrearEtiqueta(
                "DETALLES REGISTRADOS",
                13F,
                Dorado,
                true);

            lblDetalle = CrearEtiqueta(
                "ID DEL DETALLE",
                10F,
                Gris,
                true);

            lblPedido = CrearEtiqueta(
                "ID DEL PEDIDO",
                10F,
                Gris,
                true);

            lblProducto = CrearEtiqueta(
                "ID DEL PRODUCTO",
                10F,
                Gris,
                true);

            lblCantidad = CrearEtiqueta(
                "CANTIDAD",
                10F,
                Gris,
                true);

            lblProductoNombre = CrearEtiqueta(
                "Producto: --",
                12F,
                DoradoClaro,
                true);

            panelCabecera.Controls.Add(lblTitulo);
            panelCabecera.Controls.Add(lblSubtitulo);

            panelBusqueda.Controls.Add(lblBusqueda);

            panelInformacion.Controls.Add(lblInformacion);
            panelInformacion.Controls.Add(lblDetalle);
            panelInformacion.Controls.Add(lblPedido);
            panelInformacion.Controls.Add(lblProducto);
            panelInformacion.Controls.Add(lblCantidad);
            panelInformacion.Controls.Add(lblProductoNombre);

            panelTabla.Controls.Add(lblRegistros);
        }

        private void AgregarControles()
        {
            panelBusqueda.Controls.Add(txtBuscar);
            panelBusqueda.Controls.Add(btnBuscar);

            panelInformacion.Controls.Add(txtIdDetalle);
            panelInformacion.Controls.Add(txtIdPedido);
            panelInformacion.Controls.Add(txtIdProducto);
            panelInformacion.Controls.Add(numCantidad);
            panelInformacion.Controls.Add(lblNombreProducto);

            panelAcciones.Controls.Add(btnGuardar);
            panelAcciones.Controls.Add(btmModificar);
            panelAcciones.Controls.Add(btnEliminar);
            panelAcciones.Controls.Add(btnLimpiar);

            panelTabla.Controls.Add(dgvDetallePedidos);
        }

        private void DistribuirInterfaz()
        {
            int ancho = ClientSize.Width;
            int alto = ClientSize.Height;

            int margen = 60;

            panelCabecera.Location = new Point(0, 0);
            panelCabecera.Size = new Size(ancho, 135);

            lblTitulo.Location = new Point(55, 27);
            lblSubtitulo.Location = new Point(59, 78);

            panelBusqueda.Location = new Point(
                margen,
                165);

            panelBusqueda.Size = new Size(
                ancho - margen * 2,
                125);

            lblBusqueda.Location = new Point(
                32,
                22);

            txtBuscar.Location = new Point(
                32,
                62);

            txtBuscar.Size = new Size(
                panelBusqueda.Width - 270,
                42);

            btnBuscar.Location = new Point(
                panelBusqueda.Width - 205,
                62);

            btnBuscar.Size = new Size(
                175,
                42);

            panelInformacion.Location = new Point(
                margen,
                315);

            panelInformacion.Size = new Size(
                ancho - margen * 2,
                235);

            lblInformacion.Location = new Point(
                32,
                22);

            int separacion =
                (panelInformacion.Width - 64) / 4;

            int campoAncho =
                separacion - 32;

            int x1 = 32;
            int x2 = x1 + separacion;
            int x3 = x2 + separacion;
            int x4 = x3 + separacion;

            lblDetalle.Location =
                new Point(x1, 70);

            lblPedido.Location =
                new Point(x2, 70);

            lblProducto.Location =
                new Point(x3, 70);

            lblCantidad.Location =
                new Point(x4, 70);

            txtIdDetalle.Location =
                new Point(x1, 103);

            txtIdDetalle.Size =
                new Size(campoAncho, 43);

            txtIdPedido.Location =
                new Point(x2, 103);

            txtIdPedido.Size =
                new Size(campoAncho, 43);

            txtIdProducto.Location =
                new Point(x3, 103);

            txtIdProducto.Size =
                new Size(campoAncho, 43);

            numCantidad.Location =
                new Point(x4, 103);

            numCantidad.Size =
                new Size(campoAncho, 43);

            lblProductoNombre.Location =
                new Point(32, 175);

            lblNombreProducto.Location =
                new Point(32, 175);

            panelAcciones.Location = new Point(
                margen,
                575);

            panelAcciones.Size = new Size(
                ancho - margen * 2,
                100);

            int botonAncho = 190;
            int botonAlto = 48;
            int separacionBotones = 28;

            int anchoTotal =
                (botonAncho * 4) +
                (separacionBotones * 3);

            int inicio =
                (panelAcciones.Width - anchoTotal) / 2;

            btnGuardar.Location =
                new Point(
                    inicio,
                    26);

            btnGuardar.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            btmModificar.Location =
                new Point(
                    inicio +
                    botonAncho +
                    separacionBotones,
                    26);

            btmModificar.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            btnEliminar.Location =
                new Point(
                    inicio +
                    (botonAncho +
                    separacionBotones) * 2,
                    26);

            btnEliminar.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            btnLimpiar.Location =
                new Point(
                    inicio +
                    (botonAncho +
                    separacionBotones) * 3,
                    26);

            btnLimpiar.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            panelTabla.Location = new Point(
                margen,
                700);

            panelTabla.Size = new Size(
                ancho - margen * 2,
                Math.Max(
                    260,
                    alto - 730));

            lblRegistros.Location =
                new Point(32, 22);

            dgvDetallePedidos.Location =
                new Point(32, 62);

            dgvDetallePedidos.Size =
                new Size(
                    panelTabla.Width - 64,
                    panelTabla.Height - 82);
        }

        private void FrmDetallePedidos_Resize(
            object sender,
            EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                DistribuirInterfaz();
            }
        }

        private void AplicarEstilos()
        {
            EstilizarTextBox(txtBuscar);
            EstilizarTextBox(txtIdDetalle);
            EstilizarTextBox(txtIdPedido);
            EstilizarTextBox(txtIdProducto);

            numCantidad.BackColor = Campo;
            numCantidad.ForeColor = Blanco;
            numCantidad.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Regular);

            numCantidad.BorderStyle =
                BorderStyle.FixedSingle;

            EstilizarBoton(
                btnBuscar,
                Dorado,
                Color.Black);

            EstilizarBoton(
                btnGuardar,
                Dorado,
                Color.Black);

            EstilizarBoton(
                btmModificar,
                Color.FromArgb(55, 55, 55),
                Blanco);

            EstilizarBoton(
                btnEliminar,
                Rojo,
                Blanco);

            EstilizarBoton(
                btnLimpiar,
                Color.FromArgb(55, 55, 55),
                Blanco);

            lblNombreProducto.BackColor =
                Campo;

            lblNombreProducto.ForeColor =
                DoradoClaro;

            lblNombreProducto.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Bold);

            lblNombreProducto.AutoSize = false;

            lblNombreProducto.TextAlign =
                ContentAlignment.MiddleLeft;

            lblNombreProducto.Padding =
                new Padding(14, 0, 14, 0);

            EstilizarTabla();
        }

        private void EstilizarTextBox(
            TextBox caja)
        {
            caja.BackColor = Campo;
            caja.ForeColor = Blanco;

            caja.BorderStyle =
                BorderStyle.FixedSingle;

            caja.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Regular);

            caja.Margin =
                new Padding(5);

            caja.Multiline = false;
        }

        private void EstilizarBoton(
            Button boton,
            Color fondo,
            Color texto)
        {
            boton.BackColor = fondo;
            boton.ForeColor = texto;

            boton.FlatStyle =
                FlatStyle.Flat;

            boton.FlatAppearance.BorderSize = 0;

            boton.Font =
                new Font(
                    "Segoe UI Semibold",
                    11F,
                    FontStyle.Bold);

            boton.Cursor =
                Cursors.Hand;

            boton.UseVisualStyleBackColor = false;
        }

        private void EstilizarTabla()
        {
            dgvDetallePedidos.BackgroundColor =
                Panel;

            dgvDetallePedidos.BorderStyle =
                BorderStyle.None;

            dgvDetallePedidos.EnableHeadersVisualStyles =
                false;

            dgvDetallePedidos.GridColor = Borde;

            dgvDetallePedidos.ColumnHeadersDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = Dorado,
                    ForeColor = Color.Black,
                    Font =
                        new Font(
                            "Segoe UI Semibold",
                            11F,
                            FontStyle.Bold),
                    Alignment =
                        DataGridViewContentAlignment.MiddleCenter
                };

            dgvDetallePedidos.DefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = Panel,
                    ForeColor = Blanco,
                    Font =
                        new Font(
                            "Segoe UI",
                            11F),
                    SelectionBackColor =
                        Color.FromArgb(
                            80,
                            68,
                            30),
                    SelectionForeColor = Blanco,
                    Alignment =
                        DataGridViewContentAlignment.MiddleCenter
                };

            dgvDetallePedidos.AlternatingRowsDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor =
                        Color.FromArgb(
                            20,
                            20,
                            20),
                    ForeColor = Blanco,
                    SelectionBackColor =
                        Color.FromArgb(
                            80,
                            68,
                            30),
                    SelectionForeColor = Blanco
                };

            dgvDetallePedidos.ColumnHeadersHeight = 48;
            dgvDetallePedidos.RowTemplate.Height = 44;

            dgvDetallePedidos.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvDetallePedidos.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvDetallePedidos.MultiSelect = false;
            dgvDetallePedidos.ReadOnly = true;
            dgvDetallePedidos.AllowUserToAddRows = false;
            dgvDetallePedidos.AllowUserToDeleteRows = false;
            dgvDetallePedidos.AllowUserToResizeRows = false;
            dgvDetallePedidos.RowHeadersVisible = false;
        }

        private void CargarDetallePedidos()
        {
            try
            {
                List<ESFE.RestauranteBD.EN.DetallePedidos> lista =
                    detallePedidosLN.Buscar("");

                dgvDetallePedidos.DataSource = null;
                dgvDetallePedidos.DataSource = lista;

                ConfigurarColumnas();

                dgvDetallePedidos.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los detalles:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ConfigurarColumnas()
        {
            if (dgvDetallePedidos.Columns.Count == 0)
            {
                return;
            }

            if (dgvDetallePedidos.Columns["IdDetalle"] != null)
            {
                dgvDetallePedidos.Columns["IdDetalle"]
                    .HeaderText = "ID DETALLE";
            }

            if (dgvDetallePedidos.Columns["IdPedido"] != null)
            {
                dgvDetallePedidos.Columns["IdPedido"]
                    .HeaderText = "ID PEDIDO";
            }

            if (dgvDetallePedidos.Columns["IdProducto"] != null)
            {
                dgvDetallePedidos.Columns["IdProducto"]
                    .HeaderText = "ID PRODUCTO";
            }

            if (dgvDetallePedidos.Columns["Cantidad"] != null)
            {
                dgvDetallePedidos.Columns["Cantidad"]
                    .HeaderText = "CANTIDAD";
            }

            if (dgvDetallePedidos.Columns["NombreProducto"] != null)
            {
                dgvDetallePedidos.Columns["NombreProducto"]
                    .HeaderText = "PRODUCTO";
            }
        }

        private void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                {
                    return;
                }

                ESFE.RestauranteBD.EN.DetallePedidos detalle =
                    CrearDetalle();

                bool resultado =
                    detallePedidosLN.Insertar(detalle);

                if (resultado)
                {
                    MessageBox.Show(
                        "Detalle guardado correctamente.",
                        "Guardar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarCampos();
                    CargarDetallePedidos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btmModificar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    txtIdDetalle.Text))
                {
                    MessageBox.Show(
                        "Seleccione un detalle.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!ValidarCampos())
                {
                    return;
                }

                ESFE.RestauranteBD.EN.DetallePedidos detalle =
                    CrearDetalle();

                bool resultado =
                    detallePedidosLN.Actualizar(detalle);

                if (resultado)
                {
                    MessageBox.Show(
                        "Detalle actualizado correctamente.",
                        "Modificar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarCampos();
                    CargarDetallePedidos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al modificar:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    txtIdDetalle.Text))
                {
                    MessageBox.Show(
                        "Seleccione un detalle.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult respuesta =
                    MessageBox.Show(
                        "¿Desea eliminar el detalle " +
                        txtIdDetalle.Text.Trim() +
                        "?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (respuesta != DialogResult.Yes)
                {
                    return;
                }

                bool resultado =
                    detallePedidosLN.Eliminar(
                        txtIdDetalle.Text.Trim());

                if (resultado)
                {
                    MessageBox.Show(
                        "Detalle eliminado correctamente.",
                        "Eliminar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarCampos();
                    CargarDetallePedidos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(
            object sender,
            EventArgs e)
        {
            BuscarDetalle();
        }

        private void txtBuscar_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarDetalle();
                e.SuppressKeyPress = true;
            }
        }

        private void BuscarDetalle()
        {
            try
            {
                string texto =
                    txtBuscar.Text.Trim();

                List<ESFE.RestauranteBD.EN.DetallePedidos> lista =
                    detallePedidosLN.Buscar(texto);

                dgvDetallePedidos.DataSource = null;
                dgvDetallePedidos.DataSource = lista;

                ConfigurarColumnas();

                dgvDetallePedidos.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            txtBuscar.Clear();

            LimpiarCampos();

            CargarDetallePedidos();
        }

        private void LimpiarCampos()
        {
            txtIdDetalle.Clear();
            txtIdPedido.Clear();
            txtIdProducto.Clear();

            numCantidad.Value = 1;

            lblProductoNombre.Text =
                "Producto: --";

            if (lblNombreProducto != null)
            {
                lblNombreProducto.Text =
                    "Producto: --";
            }

            dgvDetallePedidos.ClearSelection();

            txtIdDetalle.Focus();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(
                txtIdDetalle.Text))
            {
                MessageBox.Show(
                    "Ingrese el ID del detalle.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtIdDetalle.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(
                txtIdPedido.Text))
            {
                MessageBox.Show(
                    "Ingrese el ID del pedido.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtIdPedido.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(
                txtIdProducto.Text))
            {
                MessageBox.Show(
                    "Ingrese el ID del producto.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtIdProducto.Focus();

                return false;
            }

            if (numCantidad.Value <= 0)
            {
                MessageBox.Show(
                    "La cantidad debe ser mayor que 0.",
                    "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                numCantidad.Focus();

                return false;
            }

            return true;
        }

        private ESFE.RestauranteBD.EN.DetallePedidos CrearDetalle()
        {
            return new ESFE.RestauranteBD.EN.DetallePedidos
            {
                IdDetalle =
                    txtIdDetalle.Text.Trim(),

                IdPedido =
                    txtIdPedido.Text.Trim(),

                IdProducto =
                    txtIdProducto.Text.Trim(),

                Cantidad =
                    Convert.ToInt32(
                        numCantidad.Value)
            };
        }

        private void dgvDetallePedidos_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila =
                dgvDetallePedidos.Rows[e.RowIndex];

            if (fila.Cells["IdDetalle"].Value != null)
            {
                txtIdDetalle.Text =
                    fila.Cells["IdDetalle"]
                        .Value.ToString();
            }

            if (fila.Cells["IdPedido"].Value != null)
            {
                txtIdPedido.Text =
                    fila.Cells["IdPedido"]
                        .Value.ToString();
            }

            if (dgvDetallePedidos.Columns["IdProducto"] != null)
            {
                if (fila.Cells["IdProducto"].Value != null)
                {
                    txtIdProducto.Text =
                        fila.Cells["IdProducto"]
                            .Value.ToString();
                }
            }

            if (fila.Cells["Cantidad"].Value != null)
            {
                int cantidad =
                    Convert.ToInt32(
                        fila.Cells["Cantidad"]
                            .Value);

                if (cantidad >= numCantidad.Minimum &&
                    cantidad <= numCantidad.Maximum)
                {
                    numCantidad.Value = cantidad;
                }
            }

            if (dgvDetallePedidos.Columns["NombreProducto"] != null)
            {
                if (fila.Cells["NombreProducto"].Value != null)
                {
                    lblProductoNombre.Text =
                        "Producto: " +
                        fila.Cells["NombreProducto"]
                            .Value.ToString();
                }
            }
        }

        private void DetallePedidos_Load(
            object sender,
            EventArgs e)
        {
            DistribuirInterfaz();
        }

        private void label1_Click(
            object sender,
            EventArgs e)
        {
        }

        private void lblNombreProducto_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}