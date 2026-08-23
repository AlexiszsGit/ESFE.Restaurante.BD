using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmCliente : Form
    {
        private readonly ClienteLN clienteLN;
        private string idClienteOriginal = "";

        // =========================================================
        // COLORES DEL DISEÑO
        // =========================================================

        private readonly Color Fondo = Color.FromArgb(10, 10, 10);
        private readonly Color Panel = Color.FromArgb(24, 24, 24);
        private readonly Color Campo = Color.FromArgb(35, 35, 35);

        private readonly Color Dorado = Color.FromArgb(212, 175, 55);
        private readonly Color Blanco = Color.FromArgb(245, 245, 245);
        private readonly Color Gris = Color.FromArgb(170, 170, 170);
        private readonly Color Borde = Color.FromArgb(55, 55, 55);

        private readonly Color Rojo = Color.FromArgb(155, 45, 45);
        private readonly Color AzulModificar = Color.FromArgb(45, 90, 125);
        private readonly Color VerdeLimpiar = Color.FromArgb(55, 105, 85);

        // =========================================================
        // PANELES
        // =========================================================

        private Panel panelCabecera;
        private Panel panelBusqueda;
        private Panel panelInformacion;
        private Panel panelAcciones;
        private Panel panelTabla;

        // =========================================================
        // ETIQUETAS
        // =========================================================

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblBusqueda;
        private Label lblInformacion;
        private Label lblRegistros;

        private Label lblIdCliente;
        private Label lblNombre;
        private Label lblTelefono;

        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public FrmCliente()
        {
            InitializeComponent();

            clienteLN = new ClienteLN();

            ConfigurarFormulario();
            PrepararControles();
            CrearInterfaz();
            AplicarDiseno();
            CargarClientes();

            Resize += FrmCliente_Resize;
        }

        // =========================================================
        // CONFIGURACIÓN
        // =========================================================

        private void ConfigurarFormulario()
        {
            Text = "RESTAURANTEBD | Clientes";

            StartPosition =
                FormStartPosition.CenterScreen;

            FormBorderStyle =
                FormBorderStyle.Sizable;

            MaximizeBox = true;
            MinimizeBox = true;

            WindowState =
                FormWindowState.Maximized;

            MinimumSize =
                new Size(1250, 800);

            BackColor = Fondo;

            Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Regular);
        }

        // =========================================================
        // OCULTAR DISEÑO ORIGINAL
        // =========================================================

        private void PrepararControles()
        {
            OcultarControles(this);
        }

        private void OcultarControles(Control control)
        {
            foreach (Control elemento in control.Controls)
            {
                elemento.Visible = false;

                if (elemento.HasChildren)
                {
                    OcultarControles(elemento);
                }
            }
        }

        // =========================================================
        // OBTENER CONTROLES
        // =========================================================

        private T ObtenerControl<T>(string nombre)
            where T : Control
        {
            return Controls
                .Find(nombre, true)
                .FirstOrDefault() as T;
        }

        // =========================================================
        // BOTÓN MODIFICAR
        // =========================================================

        private Button ObtenerBotonModificar()
        {
            Button boton =
                ObtenerControl<Button>("btmModificar");

            if (boton != null)
            {
                boton.Visible = true;
                return boton;
            }

            boton =
                ObtenerControl<Button>("btnModificar");

            if (boton != null)
            {
                boton.Visible = true;
                return boton;
            }

            boton = new Button();

            boton.Name = "btmModificar";
            boton.Text = "Modificar";

            boton.Click += btnModificar_Click;

            Controls.Add(boton);

            boton.Visible = true;

            return boton;
        }

        // =========================================================
        // CREAR INTERFAZ
        // =========================================================

        private void CrearInterfaz()
        {
            CrearPaneles();
            CrearTitulos();
            AgregarControles();
            DistribuirInterfaz();
        }

        // =========================================================
        // PANELES
        // =========================================================

        private void CrearPaneles()
        {
            panelCabecera =
                CrearPanel("panelCabecera");

            panelBusqueda =
                CrearPanel("panelBusqueda");

            panelInformacion =
                CrearPanel("panelInformacion");

            panelAcciones =
                CrearPanel("panelAcciones");

            panelTabla =
                CrearPanel("panelTabla");

            Controls.Add(panelCabecera);
            Controls.Add(panelBusqueda);
            Controls.Add(panelInformacion);
            Controls.Add(panelAcciones);
            Controls.Add(panelTabla);

            panelCabecera.BringToFront();
            panelBusqueda.BringToFront();
            panelInformacion.BringToFront();
            panelAcciones.BringToFront();
            panelTabla.BringToFront();
        }

        private Panel CrearPanel(string nombre)
        {
            return new Panel
            {
                Name = nombre,
                BackColor = Panel,
                BorderStyle = BorderStyle.None
            };
        }

        // =========================================================
        // TÍTULOS
        // =========================================================

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
                Font =
                    new Font(
                        "Segoe UI",
                        tamaño,
                        negrita
                            ? FontStyle.Bold
                            : FontStyle.Regular)
            };
        }

        private void CrearTitulos()
        {
            lblTitulo =
                CrearEtiqueta(
                    "✦  RESTAURANTEBD",
                    28F,
                    Dorado,
                    true);

            lblSubtitulo =
                CrearEtiqueta(
                    "Gestión de clientes",
                    15F,
                    Gris,
                    true);

            lblBusqueda =
                CrearEtiqueta(
                    "BUSCAR CLIENTE",
                    13F,
                    Dorado,
                    true);

            lblInformacion =
                CrearEtiqueta(
                    "INFORMACIÓN DEL CLIENTE",
                    13F,
                    Dorado,
                    true);

            lblRegistros =
                CrearEtiqueta(
                    "CLIENTES REGISTRADOS",
                    13F,
                    Dorado,
                    true);

            lblIdCliente =
                CrearEtiqueta(
                    "ID DE CLIENTE",
                    10F,
                    Gris,
                    true);

            lblNombre =
                CrearEtiqueta(
                    "NOMBRE",
                    10F,
                    Gris,
                    true);

            lblTelefono =
                CrearEtiqueta(
                    "TELÉFONO",
                    10F,
                    Gris,
                    true);

            panelCabecera.Controls.Add(lblTitulo);
            panelCabecera.Controls.Add(lblSubtitulo);

            panelBusqueda.Controls.Add(lblBusqueda);

            panelInformacion.Controls.Add(lblInformacion);
            panelInformacion.Controls.Add(lblIdCliente);
            panelInformacion.Controls.Add(lblNombre);
            panelInformacion.Controls.Add(lblTelefono);

            panelTabla.Controls.Add(lblRegistros);
        }

        // =========================================================
        // AGREGAR CONTROLES ORIGINALES
        // =========================================================

        private void AgregarControles()
        {
            TextBox txtBuscar =
                ObtenerControl<TextBox>("txtBuscar");

            Button btnBuscar =
                ObtenerControl<Button>("btnBuscar");

            TextBox txtIdCliente =
                ObtenerControl<TextBox>("txtIdCliente");

            TextBox txtNombre =
                ObtenerControl<TextBox>("txtNombre");

            Control txtTelefono =
                ObtenerControl<MaskedTextBox>("txtTelefono");

            if (txtTelefono == null)
            {
                txtTelefono =
                    ObtenerControl<TextBox>("txtTelefono");
            }

            Button btnGuardar =
                ObtenerControl<Button>("btnGuardar");

            Button btmModificar =
                ObtenerBotonModificar();

            Button btnEliminar =
                ObtenerControl<Button>("btnEliminar");

            Button btnLimpiar =
                ObtenerControl<Button>("btnLimpiar");

            DataGridView dgvClientes =
                ObtenerControl<DataGridView>("dgvClientes");

            if (txtBuscar != null)
            {
                txtBuscar.Visible = true;
                panelBusqueda.Controls.Add(txtBuscar);
            }

            if (btnBuscar != null)
            {
                btnBuscar.Visible = true;
                panelBusqueda.Controls.Add(btnBuscar);
            }

            if (txtIdCliente != null)
            {
                txtIdCliente.Visible = true;
                panelInformacion.Controls.Add(txtIdCliente);
            }

            if (txtNombre != null)
            {
                txtNombre.Visible = true;
                panelInformacion.Controls.Add(txtNombre);
            }

            if (txtTelefono != null)
            {
                txtTelefono.Visible = true;
                panelInformacion.Controls.Add(txtTelefono);
            }

            if (btnGuardar != null)
            {
                btnGuardar.Visible = true;
                panelAcciones.Controls.Add(btnGuardar);
            }

            if (btmModificar != null)
            {
                btmModificar.Visible = true;
                panelAcciones.Controls.Add(btmModificar);
            }

            if (btnEliminar != null)
            {
                btnEliminar.Visible = true;
                panelAcciones.Controls.Add(btnEliminar);
            }

            if (btnLimpiar != null)
            {
                btnLimpiar.Visible = true;
                panelAcciones.Controls.Add(btnLimpiar);
            }

            if (dgvClientes != null)
            {
                dgvClientes.Visible = true;
                panelTabla.Controls.Add(dgvClientes);
            }
        }

        // =========================================================
        // DISTRIBUCIÓN
        // =========================================================

        private void DistribuirInterfaz()
        {
            int ancho = ClientSize.Width;
            int alto = ClientSize.Height;

            int margen = 60;

            // =====================================================
            // CABECERA
            // =====================================================

            panelCabecera.Location =
                new Point(0, 0);

            panelCabecera.Size =
                new Size(ancho, 135);

            lblTitulo.Location =
                new Point(55, 27);

            lblSubtitulo.Location =
                new Point(59, 78);

            // =====================================================
            // BÚSQUEDA
            // =====================================================

            panelBusqueda.Location =
                new Point(margen, 165);

            panelBusqueda.Size =
                new Size(
                    ancho - margen * 2,
                    125);

            lblBusqueda.Location =
                new Point(32, 22);

            TextBox txtBuscar =
                ObtenerControl<TextBox>("txtBuscar");

            Button btnBuscar =
                ObtenerControl<Button>("btnBuscar");

            if (txtBuscar != null)
            {
                txtBuscar.Location =
                    new Point(32, 62);

                txtBuscar.Size =
                    new Size(
                        panelBusqueda.Width - 270,
                        42);
            }

            if (btnBuscar != null)
            {
                btnBuscar.Location =
                    new Point(
                        panelBusqueda.Width - 205,
                        62);

                btnBuscar.Size =
                    new Size(175, 42);
            }

            // =====================================================
            // INFORMACIÓN
            // =====================================================

            panelInformacion.Location =
                new Point(margen, 315);

            panelInformacion.Size =
                new Size(
                    ancho - margen * 2,
                    210);

            lblInformacion.Location =
                new Point(32, 22);

            int espacio =
                (panelInformacion.Width - 64) / 3;

            int campoAncho =
                espacio - 32;

            int x1 = 32;
            int x2 = x1 + espacio;
            int x3 = x2 + espacio;

            lblIdCliente.Location =
                new Point(x1, 70);

            lblNombre.Location =
                new Point(x2, 70);

            lblTelefono.Location =
                new Point(x3, 70);

            TextBox txtIdCliente =
                ObtenerControl<TextBox>("txtIdCliente");

            TextBox txtNombre =
                ObtenerControl<TextBox>("txtNombre");

            Control txtTelefono =
                ObtenerControl<MaskedTextBox>("txtTelefono");

            if (txtTelefono == null)
            {
                txtTelefono =
                    ObtenerControl<TextBox>("txtTelefono");
            }

            if (txtIdCliente != null)
            {
                txtIdCliente.Location =
                    new Point(x1, 103);

                txtIdCliente.Size =
                    new Size(campoAncho, 43);
            }

            if (txtNombre != null)
            {
                txtNombre.Location =
                    new Point(x2, 103);

                txtNombre.Size =
                    new Size(campoAncho, 43);
            }

            if (txtTelefono != null)
            {
                txtTelefono.Location =
                    new Point(x3, 103);

                txtTelefono.Size =
                    new Size(campoAncho, 43);
            }

            // =====================================================
            // BOTONES
            // =====================================================

            panelAcciones.Location =
                new Point(margen, 550);

            panelAcciones.Size =
                new Size(
                    ancho - margen * 2,
                    105);

            Button btnGuardar =
                ObtenerControl<Button>("btnGuardar");

            Button btmModificar =
                ObtenerBotonModificar();

            Button btnEliminar =
                ObtenerControl<Button>("btnEliminar");

            Button btnLimpiar =
                ObtenerControl<Button>("btnLimpiar");

            int botonAncho = 190;
            int botonAlto = 48;
            int separacion = 28;

            int anchoTotal =
                (botonAncho * 4) +
                (separacion * 3);

            int inicio =
                (panelAcciones.Width -
                 anchoTotal) / 2;

            // GUARDAR
            if (btnGuardar != null)
            {
                btnGuardar.Visible = true;

                btnGuardar.Location =
                    new Point(
                        inicio,
                        27);

                btnGuardar.Size =
                    new Size(
                        botonAncho,
                        botonAlto);

                btnGuardar.Text =
                    "Guardar";

                btnGuardar.BringToFront();
            }

            // MODIFICAR
            if (btmModificar != null)
            {
                btmModificar.Visible = true;

                btmModificar.Location =
                    new Point(
                        inicio +
                        botonAncho +
                        separacion,
                        27);

                btmModificar.Size =
                    new Size(
                        botonAncho,
                        botonAlto);

                btmModificar.Text =
                    "Modificar";

                btmModificar.BringToFront();
            }

            // ELIMINAR
            if (btnEliminar != null)
            {
                btnEliminar.Visible = true;

                btnEliminar.Location =
                    new Point(
                        inicio +
                        ((botonAncho +
                          separacion) * 2),
                        27);

                btnEliminar.Size =
                    new Size(
                        botonAncho,
                        botonAlto);

                btnEliminar.Text =
                    "Eliminar";

                btnEliminar.BringToFront();
            }

            // LIMPIAR
            if (btnLimpiar != null)
            {
                btnLimpiar.Visible = true;

                btnLimpiar.Location =
                    new Point(
                        inicio +
                        ((botonAncho +
                          separacion) * 3),
                        27);

                btnLimpiar.Size =
                    new Size(
                        botonAncho,
                        botonAlto);

                btnLimpiar.Text =
                    "Limpiar";

                btnLimpiar.BringToFront();
            }

            // =====================================================
            // TABLA
            // =====================================================

            panelTabla.Location =
                new Point(margen, 685);

            panelTabla.Size =
                new Size(
                    ancho - margen * 2,
                    Math.Max(
                        260,
                        alto - 715));

            lblRegistros.Location =
                new Point(32, 22);

            DataGridView dgvClientes =
                ObtenerControl<DataGridView>("dgvClientes");

            if (dgvClientes != null)
            {
                dgvClientes.Location =
                    new Point(32, 62);

                dgvClientes.Size =
                    new Size(
                        panelTabla.Width - 64,
                        panelTabla.Height - 82);

                dgvClientes.BringToFront();
            }
        }

        private void FrmCliente_Resize(
            object sender,
            EventArgs e)
        {
            if (WindowState !=
                FormWindowState.Minimized)
            {
                DistribuirInterfaz();
            }
        }

        // =========================================================
        // DISEÑO
        // =========================================================

        private void AplicarDiseno()
        {
            EstilizarTextBox(
                ObtenerControl<TextBox>("txtBuscar"));

            EstilizarTextBox(
                ObtenerControl<TextBox>("txtIdCliente"));

            EstilizarTextBox(
                ObtenerControl<TextBox>("txtNombre"));

            EstilizarControl(
                ObtenerControl<MaskedTextBox>("txtTelefono"));

            Button btnBuscar =
                ObtenerControl<Button>("btnBuscar");

            Button btnGuardar =
                ObtenerControl<Button>("btnGuardar");

            Button btmModificar =
                ObtenerBotonModificar();

            Button btnEliminar =
                ObtenerControl<Button>("btnEliminar");

            Button btnLimpiar =
                ObtenerControl<Button>("btnLimpiar");

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
                AzulModificar,
                Blanco);

            EstilizarBoton(
                btnEliminar,
                Rojo,
                Blanco);

            EstilizarBoton(
                btnLimpiar,
                VerdeLimpiar,
                Blanco);

            EstilizarTabla(
                ObtenerControl<DataGridView>("dgvClientes"));
        }

        // =========================================================
        // TEXTBOX
        // =========================================================

        private void EstilizarTextBox(
            TextBox caja)
        {
            if (caja == null)
                return;

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
            caja.Visible = true;
        }

        // =========================================================
        // MASKED TEXTBOX
        // =========================================================

        private void EstilizarControl(
            MaskedTextBox caja)
        {
            if (caja == null)
                return;

            caja.BackColor = Campo;
            caja.ForeColor = Blanco;

            caja.BorderStyle =
                BorderStyle.FixedSingle;

            caja.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Regular);

            caja.Visible = true;
        }

        // =========================================================
        // BOTONES
        // =========================================================

        private void EstilizarBoton(
            Button boton,
            Color fondo,
            Color texto)
        {
            if (boton == null)
                return;

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

            boton.UseVisualStyleBackColor =
                false;

            boton.Visible = true;
        }

        // =========================================================
        // TABLA
        // =========================================================

        private void EstilizarTabla(
            DataGridView tabla)
        {
            if (tabla == null)
                return;

            tabla.BackgroundColor = Panel;

            tabla.BorderStyle =
                BorderStyle.None;

            tabla.EnableHeadersVisualStyles =
                false;

            tabla.GridColor = Borde;

            tabla.ColumnHeadersDefaultCellStyle =
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
                        DataGridViewContentAlignment
                            .MiddleCenter
                };

            tabla.DefaultCellStyle =
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
                        DataGridViewContentAlignment
                            .MiddleCenter
                };

            tabla.AlternatingRowsDefaultCellStyle =
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

            tabla.ColumnHeadersHeight = 48;
            tabla.RowTemplate.Height = 44;

            tabla.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            tabla.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            tabla.MultiSelect = false;
            tabla.ReadOnly = true;

            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToDeleteRows = false;
            tabla.AllowUserToResizeRows = false;

            tabla.RowHeadersVisible = false;

            tabla.Visible = true;
        }

        // =========================================================
        // CARGAR CLIENTES
        // =========================================================

        private void CargarClientes()
        {
            try
            {
                List<ESFE.RestauranteBD.EN.Cliente> lista =
                    clienteLN.Buscar("");

                DataGridView dgvClientes =
                    ObtenerControl<DataGridView>("dgvClientes");

                if (dgvClientes != null)
                {
                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = lista;
                    dgvClientes.Refresh();
                    dgvClientes.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los clientes:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // GUARDAR
        // =========================================================

        private void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    txtIdCliente.Text))
                {
                    MessageBox.Show(
                        "Ingrese el ID del cliente.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtIdCliente.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(
                    txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre del cliente.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return;
                }

                Cliente cliente =
                    new Cliente
                    {
                        IdCliente =
                            txtIdCliente.Text.Trim(),

                        Nombre =
                            txtNombre.Text.Trim(),

                        Telefono =
                            txtTelefono.Text.Trim()
                    };

                bool resultado =
                    clienteLN.Insertar(cliente);

                if (resultado)
                {
                    MessageBox.Show(
                        "¡Cliente guardado correctamente!",
                        "Guardar Cliente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarClientes();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el cliente:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // MODIFICAR
        // =========================================================

        private void btnModificar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    idClienteOriginal))
                {
                    MessageBox.Show(
                        "Primero seleccione un cliente de la tabla.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (string.IsNullOrWhiteSpace(
                    txtIdCliente.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nuevo ID del cliente.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtIdCliente.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(
                    txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre del cliente.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return;
                }

                Cliente cliente =
                    new Cliente
                    {
                        IdCliente =
                            txtIdCliente.Text.Trim(),

                        Nombre =
                            txtNombre.Text.Trim(),

                        Telefono =
                            txtTelefono.Text.Trim()
                    };

                bool resultado =
                    clienteLN.Actualizar(
                        cliente,
                        idClienteOriginal);

                if (resultado)
                {
                    MessageBox.Show(
                        "Cliente modificado correctamente.",
                        "Modificar Cliente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    idClienteOriginal = "";

                    CargarClientes();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró el cliente para modificar.",
                        "Modificar Cliente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al modificar el cliente:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // EVENTO btmModificar
        // =========================================================

        private void btmModificar_Click(
            object sender,
            EventArgs e)
        {
            btnModificar_Click(sender, e);
        }

        // =========================================================
        // ELIMINAR
        // =========================================================

        private void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    txtIdCliente.Text))
                {
                    MessageBox.Show(
                        "Seleccione un cliente para eliminar.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult confirmar =
                    MessageBox.Show(
                        "¿Está seguro de eliminar este cliente?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (confirmar !=
                    DialogResult.Yes)
                {
                    return;
                }

                bool resultado =
                    clienteLN.Eliminar(
                        txtIdCliente.Text.Trim());

                if (resultado)
                {
                    MessageBox.Show(
                        "Cliente eliminado correctamente.",
                        "Eliminar Cliente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarClientes();
                    LimpiarCampos();

                    idClienteOriginal = "";
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo eliminar el cliente.",
                        "Eliminar Cliente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el cliente:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // LIMPIAR
        // =========================================================

        private void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtIdCliente.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();

            idClienteOriginal = "";

            txtIdCliente.Focus();
        }

        // =========================================================
        // SELECCIONAR CLIENTE
        // =========================================================

        private void dgvClientes_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow fila =
                    dgvClientes.Rows[e.RowIndex];

                txtIdCliente.Text =
                    Convert.ToString(
                        fila.Cells["IdCliente"].Value) ?? "";

                txtNombre.Text =
                    Convert.ToString(
                        fila.Cells["Nombre"].Value) ?? "";

                txtTelefono.Text =
                    Convert.ToString(
                        fila.Cells["Telefono"].Value) ?? "";

                idClienteOriginal =
                    txtIdCliente.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al seleccionar el cliente:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // BUSCAR
        // =========================================================

        private void btnBuscar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                string texto =
                    txtBuscar.Text.Trim();

                if (string.IsNullOrWhiteSpace(texto))
                {
                    CargarClientes();
                    return;
                }

                List<Cliente> resultados =
                    clienteLN.Buscar(texto);

                dgvClientes.DataSource = null;
                dgvClientes.DataSource = resultados;
                dgvClientes.Refresh();
                dgvClientes.ClearSelection();

                if (resultados.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron clientes.",
                        "Búsqueda",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                txtBuscar.Clear();
                txtBuscar.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar cliente:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // LOAD
        // =========================================================

        private void Cliente_Load(
            object sender,
            EventArgs e)
        {
            AplicarDiseno();
            DistribuirInterfaz();
            CargarClientes();
        }

        private void FrmCliente_Load(
            object sender,
            EventArgs e)
        {
            AplicarDiseno();
            DistribuirInterfaz();
            CargarClientes();
        }

        // =========================================================
        // EVENTO DEL MASKEDTEXTBOX
        // =========================================================

        private void txtTelefono_MaskInputRejected(
            object sender,
            MaskInputRejectedEventArgs e)
        {
        }
    }
}