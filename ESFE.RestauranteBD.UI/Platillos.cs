using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ESFE.RestauranteBD.DAL;
using ESFE.RestauranteBD.EN;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmPlatillos : Form
    {
        private readonly PlatillosDAL platilloDAL =
            new PlatillosDAL();

        // =========================================================
        // COLORES
        // =========================================================

        private readonly Color Fondo =
            Color.FromArgb(10, 10, 10);

        private readonly Color Panel =
            Color.FromArgb(24, 24, 24);

        private readonly Color Campo =
            Color.FromArgb(35, 35, 35);

        private readonly Color Dorado =
            Color.FromArgb(212, 175, 55);

        private readonly Color Blanco =
            Color.FromArgb(245, 245, 245);

        private readonly Color Gris =
            Color.FromArgb(170, 170, 170);

        private readonly Color Borde =
            Color.FromArgb(55, 55, 55);

        private readonly Color Rojo =
            Color.FromArgb(155, 45, 45);

        private readonly Color AzulModificar =
            Color.FromArgb(45, 90, 125);

        private readonly Color VerdeLimpiar =
            Color.FromArgb(55, 105, 85);

        // =========================================================
        // PANELES
        // =========================================================

        private Panel panelCabecera;
        private Panel panelBusqueda;
        private Panel panelInformacion;
        private Panel panelAcciones;
        private Panel panelTabla;

        // =========================================================
        // LABELS PROPIOS DEL DISEÑO
        // Se usa UI al final para no chocar con los labels
        // que ya existen en Platillos.Designer.cs.
        // =========================================================

        private Label lblTituloUI;
        private Label lblSubtituloUI;
        private Label lblBusquedaUI;
        private Label lblInformacionUI;
        private Label lblRegistrosUI;

        private Label lblIdProductoUI;
        private Label lblNombreUI;
        private Label lblPrecioUI;
        private Label lblCategoriaUI;
        private Label lblDescuentoUI;

        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public FrmPlatillos()
        {
            // Fuerza el punto como separador decimal.
            // Así 0.50 permanece como 0.50 y no se convierte en 50.00.
            CultureInfo cultura =
                (CultureInfo)CultureInfo.InvariantCulture.Clone();

            cultura.NumberFormat.NumberDecimalSeparator = ".";
            cultura.NumberFormat.NumberGroupSeparator = ",";

            Thread.CurrentThread.CurrentCulture = cultura;
            Thread.CurrentThread.CurrentUICulture = cultura;

            InitializeComponent();

            ConfigurarFormulario();
            PrepararControles();
            CrearInterfaz();
            AplicarDiseno();

            CargarCategorias();
            CargarDescuentos();
            CargarPlatillos();

            Resize += FrmPlatillos_Resize;
        }

        // =========================================================
        // CONFIGURACIÓN DEL FORMULARIO
        // =========================================================

        private void ConfigurarFormulario()
        {
            Text = "RESTAURANTEBD | Platillos";

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
        // PREPARAR CONTROLES
        // =========================================================

        private void PrepararControles()
        {
            OcultarLabels(this);

            OcultarControl<Button>("btnEliminar");
        }

        private void OcultarLabels(Control control)
        {
            foreach (Control elemento in control.Controls)
            {
                if (elemento is Label)
                    elemento.Visible = false;

                if (elemento.HasChildren)
                    OcultarLabels(elemento);
            }
        }

        private void OcultarControl<T>(string nombre)
            where T : Control
        {
            T control =
                ObtenerControl<T>(nombre);

            if (control != null)
                control.Visible = false;
        }

        private T ObtenerControl<T>(string nombre)
            where T : Control
        {
            return Controls
                .Find(nombre, true)
                .FirstOrDefault() as T;
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
        // LABELS
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
            lblTituloUI =
                CrearEtiqueta(
                    "✦  RESTAURANTEBD",
                    28F,
                    Dorado,
                    true);

            lblSubtituloUI =
                CrearEtiqueta(
                    "Gestión de platillos",
                    15F,
                    Gris,
                    true);

            lblBusquedaUI =
                CrearEtiqueta(
                    "BUSCAR PLATILLO",
                    13F,
                    Dorado,
                    true);

            lblInformacionUI =
                CrearEtiqueta(
                    "INFORMACIÓN DEL PLATILLO",
                    13F,
                    Dorado,
                    true);

            lblRegistrosUI =
                CrearEtiqueta(
                    "PLATILLOS REGISTRADOS",
                    13F,
                    Dorado,
                    true);

            lblIdProductoUI =
                CrearEtiqueta(
                    "ID DE PRODUCTO",
                    10F,
                    Gris,
                    true);

            lblNombreUI =
                CrearEtiqueta(
                    "NOMBRE",
                    10F,
                    Gris,
                    true);

            lblPrecioUI =
                CrearEtiqueta(
                    "PRECIO",
                    10F,
                    Gris,
                    true);

            lblCategoriaUI =
                CrearEtiqueta(
                    "CATEGORÍA",
                    10F,
                    Gris,
                    true);

            lblDescuentoUI =
                CrearEtiqueta(
                    "DESCUENTO",
                    10F,
                    Gris,
                    true);

            panelCabecera.Controls.Add(
                lblTituloUI);

            panelCabecera.Controls.Add(
                lblSubtituloUI);

            panelBusqueda.Controls.Add(
                lblBusquedaUI);

            panelInformacion.Controls.Add(
                lblInformacionUI);

            panelInformacion.Controls.Add(
                lblIdProductoUI);

            panelInformacion.Controls.Add(
                lblNombreUI);

            panelInformacion.Controls.Add(
                lblPrecioUI);

            panelInformacion.Controls.Add(
                lblCategoriaUI);

            panelInformacion.Controls.Add(
                lblDescuentoUI);

            panelTabla.Controls.Add(
                lblRegistrosUI);
        }

        // =========================================================
        // AGREGAR CONTROLES
        // =========================================================

        private void AgregarControles()
        {
            TextBox txtBuscar =
                ObtenerControl<TextBox>(
                    "txtBuscar");

            Button btnBuscar =
                ObtenerControl<Button>(
                    "btnBuscar");

            TextBox txtProducto =
                ObtenerControl<TextBox>(
                    "txtProducto");

            TextBox txtNombre =
                ObtenerControl<TextBox>(
                    "txtNombre");

            NumericUpDown nudPrecio =
                ObtenerControl<NumericUpDown>(
                    "nudPrecio");

            ComboBox cmbCategoria =
                ObtenerControl<ComboBox>(
                    "cmbCategoria");

            ComboBox cmbDescuento =
                ObtenerControl<ComboBox>(
                    "cmbDescuento");

            Button btnGuardar =
                ObtenerControl<Button>(
                    "btnGuardar");

            Button btnModificar =
                ObtenerControl<Button>(
                    "btnModificar");

            Button btnEliminar =
                ObtenerControl<Button>(
                    "btnEliminar2");

            Button btnLimpiar =
                ObtenerControl<Button>(
                    "btnLinpiar");

            DataGridView dgv =
                ObtenerControl<DataGridView>(
                    "dgvPlatillos");

            if (txtBuscar != null)
                panelBusqueda.Controls.Add(txtBuscar);

            if (btnBuscar != null)
                panelBusqueda.Controls.Add(btnBuscar);

            if (txtProducto != null)
                panelInformacion.Controls.Add(txtProducto);

            if (txtNombre != null)
                panelInformacion.Controls.Add(txtNombre);

            if (nudPrecio != null)
                panelInformacion.Controls.Add(nudPrecio);

            if (cmbCategoria != null)
                panelInformacion.Controls.Add(cmbCategoria);

            if (cmbDescuento != null)
                panelInformacion.Controls.Add(cmbDescuento);

            if (btnGuardar != null)
                panelAcciones.Controls.Add(btnGuardar);

            if (btnModificar != null)
                panelAcciones.Controls.Add(btnModificar);

            if (btnEliminar != null)
                panelAcciones.Controls.Add(btnEliminar);

            if (btnLimpiar != null)
                panelAcciones.Controls.Add(btnLimpiar);

            if (dgv != null)
                panelTabla.Controls.Add(dgv);
        }

        // =========================================================
        // DISTRIBUCIÓN
        // =========================================================

        private void DistribuirInterfaz()
        {
            int ancho = ClientSize.Width;
            int alto = ClientSize.Height;

            int margen = 60;

            // CABECERA
            panelCabecera.Location =
                new Point(0, 0);

            panelCabecera.Size =
                new Size(ancho, 135);

            lblTituloUI.Location =
                new Point(55, 27);

            // SUBTÍTULO EN LA ESQUINA CONTRARIA
            lblSubtituloUI.Location =
                new Point(
                    ancho -
                    lblSubtituloUI.Width -
                    60,
                    82);

            // BÚSQUEDA
            panelBusqueda.Location =
                new Point(margen, 165);

            panelBusqueda.Size =
                new Size(
                    ancho - margen * 2,
                    125);

            lblBusquedaUI.Location =
                new Point(32, 22);

            TextBox txtBuscar =
                ObtenerControl<TextBox>(
                    "txtBuscar");

            Button btnBuscar =
                ObtenerControl<Button>(
                    "btnBuscar");

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

            // INFORMACIÓN
            panelInformacion.Location =
                new Point(margen, 315);

            panelInformacion.Size =
                new Size(
                    ancho - margen * 2,
                    260);

            lblInformacionUI.Location =
                new Point(32, 22);

            int columnas = 5;

            int espacio =
                (panelInformacion.Width - 64) /
                columnas;

            int campoAncho =
                espacio - 22;

            int x1 = 32;
            int x2 = x1 + espacio;
            int x3 = x2 + espacio;
            int x4 = x3 + espacio;
            int x5 = x4 + espacio;

            lblIdProductoUI.Location =
                new Point(x1, 75);

            lblNombreUI.Location =
                new Point(x2, 75);

            lblPrecioUI.Location =
                new Point(x3, 75);

            lblCategoriaUI.Location =
                new Point(x4, 75);

            lblDescuentoUI.Location =
                new Point(x5, 75);

            TextBox txtProducto =
                ObtenerControl<TextBox>(
                    "txtProducto");

            TextBox txtNombre =
                ObtenerControl<TextBox>(
                    "txtNombre");

            NumericUpDown nudPrecio =
                ObtenerControl<NumericUpDown>(
                    "nudPrecio");

            ComboBox cmbCategoria =
                ObtenerControl<ComboBox>(
                    "cmbCategoria");

            ComboBox cmbDescuento =
                ObtenerControl<ComboBox>(
                    "cmbDescuento");

            if (txtProducto != null)
            {
                txtProducto.Location =
                    new Point(x1, 108);

                txtProducto.Size =
                    new Size(
                        campoAncho,
                        43);
            }

            if (txtNombre != null)
            {
                txtNombre.Location =
                    new Point(x2, 108);

                txtNombre.Size =
                    new Size(
                        campoAncho,
                        43);
            }

            if (nudPrecio != null)
            {
                nudPrecio.Location =
                    new Point(x3, 108);

                nudPrecio.Size =
                    new Size(
                        campoAncho,
                        43);

                ConfigurarPrecio(nudPrecio);
            }

            if (cmbCategoria != null)
            {
                cmbCategoria.Location =
                    new Point(x4, 108);

                cmbCategoria.Size =
                    new Size(
                        campoAncho,
                        43);
            }

            if (cmbDescuento != null)
            {
                cmbDescuento.Location =
                    new Point(x5, 108);

                cmbDescuento.Size =
                    new Size(
                        campoAncho,
                        43);
            }

            // BOTONES
            panelAcciones.Location =
                new Point(margen, 595);

            panelAcciones.Size =
                new Size(
                    ancho - margen * 2,
                    105);

            Button btnGuardar =
                ObtenerControl<Button>(
                    "btnGuardar");

            Button btnModificar =
                ObtenerControl<Button>(
                    "btnModificar");

            Button btnEliminar =
                ObtenerControl<Button>(
                    "btnEliminar2");

            Button btnLimpiar =
                ObtenerControl<Button>(
                    "btnLinpiar");

            int botonAncho = 190;
            int botonAlto = 48;
            int separacion = 28;

            int anchoTotal =
                (botonAncho * 4) +
                (separacion * 3);

            int inicio =
                (panelAcciones.Width -
                 anchoTotal) / 2;

            if (btnGuardar != null)
            {
                btnGuardar.Visible = true;

                btnGuardar.Location =
                    new Point(inicio, 27);

                btnGuardar.Size =
                    new Size(
                        botonAncho,
                        botonAlto);

                btnGuardar.Text =
                    "Guardar";
            }

            if (btnModificar != null)
            {
                btnModificar.Visible = true;

                btnModificar.Location =
                    new Point(
                        inicio +
                        botonAncho +
                        separacion,
                        27);

                btnModificar.Size =
                    new Size(
                        botonAncho,
                        botonAlto);

                btnModificar.Text =
                    "Modificar";
            }

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
            }

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
            }

            // TABLA
            panelTabla.Location =
                new Point(margen, 730);

            panelTabla.Size =
                new Size(
                    ancho - margen * 2,
                    Math.Max(
                        260,
                        alto - 760));

            lblRegistrosUI.Location =
                new Point(32, 22);

            DataGridView dgv =
                ObtenerControl<DataGridView>(
                    "dgvPlatillos");

            if (dgv != null)
            {
                dgv.Location =
                    new Point(32, 62);

                dgv.Size =
                    new Size(
                        panelTabla.Width - 64,
                        panelTabla.Height - 82);
            }
        }

        private void FrmPlatillos_Resize(
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
                ObtenerControl<TextBox>(
                    "txtBuscar"));

            EstilizarTextBox(
                ObtenerControl<TextBox>(
                    "txtProducto"));

            EstilizarTextBox(
                ObtenerControl<TextBox>(
                    "txtNombre"));

            NumericUpDown nudPrecio =
                ObtenerControl<NumericUpDown>(
                    "nudPrecio");

            EstilizarNumericUpDown(
                nudPrecio);

            EstilizarComboBox(
                ObtenerControl<ComboBox>(
                    "cmbCategoria"));

            EstilizarComboBox(
                ObtenerControl<ComboBox>(
                    "cmbDescuento"));

            EstilizarBoton(
                ObtenerControl<Button>(
                    "btnBuscar"),
                Dorado,
                Color.Black);

            EstilizarBoton(
                ObtenerControl<Button>(
                    "btnGuardar"),
                Dorado,
                Color.Black);

            EstilizarBoton(
                ObtenerControl<Button>(
                    "btnModificar"),
                AzulModificar,
                Blanco);

            EstilizarBoton(
                ObtenerControl<Button>(
                    "btnEliminar2"),
                Rojo,
                Blanco);

            EstilizarBoton(
                ObtenerControl<Button>(
                    "btnLinpiar"),
                VerdeLimpiar,
                Blanco);

            EstilizarTabla(
                ObtenerControl<DataGridView>(
                    "dgvPlatillos"));
        }

        // =========================================================
        // PRECIO
        // =========================================================

        private void ConfigurarPrecio(
            NumericUpDown control)
        {
            if (control == null)
                return;

            control.DecimalPlaces = 2;
            control.Increment = 0.01M;
            control.Minimum = 0M;
            control.Maximum = 9999999.99M;

            control.ThousandsSeparator = false;

            control.TextAlign =
                HorizontalAlignment.Left;

            control.Value = 0M;

            // El NumericUpDown contiene internamente
            // un TextBox. Aquí se controla la entrada.
            TextBox cajaInterna =
                control.Controls
                    .OfType<TextBox>()
                    .FirstOrDefault();

            if (cajaInterna != null)
            {
                cajaInterna.TextAlign =
                    HorizontalAlignment.Left;

                cajaInterna.KeyPress -=
                    Precio_KeyPress;

                cajaInterna.KeyPress +=
                    Precio_KeyPress;
            }
        }

        private void Precio_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            TextBox caja =
                sender as TextBox;

            if (caja == null)
                return;

            // Permitir teclas de control
            if (char.IsControl(e.KeyChar))
                return;

            // Convertir coma a punto
            if (e.KeyChar == ',')
            {
                e.Handled = true;

                int posicion =
                    caja.SelectionStart;

                if (!caja.Text.Contains("."))
                {
                    caja.Text =
                        caja.Text.Insert(
                            posicion,
                            ".");

                    caja.SelectionStart =
                        posicion + 1;
                }

                return;
            }

            // Permitir solamente números
            // y un único punto decimal.
            if (e.KeyChar == '.')
            {
                if (caja.Text.Contains("."))
                    e.Handled = true;

                return;
            }

            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void EstilizarNumericUpDown(
            NumericUpDown control)
        {
            if (control == null)
                return;

            control.BackColor = Campo;
            control.ForeColor = Blanco;

            control.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Regular);

            ConfigurarPrecio(control);
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

            caja.Multiline = false;
        }

        // =========================================================
        // COMBOBOX
        // =========================================================

        private void EstilizarComboBox(
            ComboBox combo)
        {
            if (combo == null)
                return;

            combo.BackColor = Campo;
            combo.ForeColor = Blanco;

            combo.FlatStyle =
                FlatStyle.Flat;

            combo.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Regular);
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

            boton.UseVisualStyleBackColor = false;
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
                DataGridViewSelectionMode
                    .FullRowSelect;

            tabla.MultiSelect = false;
            tabla.ReadOnly = true;

            tabla.AllowUserToAddRows = false;
            tabla.AllowUserToDeleteRows = false;
            tabla.AllowUserToResizeRows = false;

            tabla.RowHeadersVisible = false;
        }

        // =========================================================
        // CATEGORÍAS
        // =========================================================

        private void CargarCategorias()
        {
            try
            {
                DataTable tabla =
                    platilloDAL.ObtenerCategorias();

                cmbCategoria.DataSource = null;

                if (tabla != null &&
                    tabla.Rows.Count > 0)
                {
                    cmbCategoria.DisplayMember =
                        "nombre";

                    cmbCategoria.ValueMember =
                        "id_categoria";

                    cmbCategoria.DataSource =
                        tabla;

                    cmbCategoria.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las categorías:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // DESCUENTOS
        // =========================================================

        private void CargarDescuentos()
        {
            try
            {
                DataTable tabla =
                    platilloDAL.ObtenerDescuentos();

                cmbDescuento.DataSource = null;

                if (tabla != null &&
                    tabla.Rows.Count > 0)
                {
                    cmbDescuento.DisplayMember =
                        "descripcion";

                    cmbDescuento.ValueMember =
                        "id_descuento";

                    cmbDescuento.DataSource =
                        tabla;

                    cmbDescuento.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar la lista de descuentos:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // CARGAR PLATILLOS
        // =========================================================

        private void CargarPlatillos()
        {
            try
            {
                DataTable tabla =
                    platilloDAL.ObtenerPlatillos();

                dgvPlatillos.DataSource = null;
                dgvPlatillos.DataSource = tabla;

                dgvPlatillos.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los platillos:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // LIMPIAR
        // =========================================================

        private void Limpiar()
        {
            txtProducto.Clear();
            txtNombre.Clear();

            nudPrecio.Value = 0M;

            cmbCategoria.SelectedIndex = -1;
            cmbDescuento.SelectedIndex = -1;

            txtBuscar.Clear();

            txtProducto.Focus();
        }

        private void btnLinpiar_Click(
            object sender,
            EventArgs e)
        {
            Limpiar();
            CargarPlatillos();
        }

        private void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            Limpiar();
            CargarPlatillos();
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
                    txtProducto.Text))
                {
                    MessageBox.Show(
                        "Ingrese el ID del producto.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (string.IsNullOrWhiteSpace(
                    txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre del platillo.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Platillo platillo =
                    new Platillo
                    {
                        IdProducto =
                            txtProducto.Text.Trim(),

                        Nombre =
                            txtNombre.Text.Trim(),

                        Precio =
                            nudPrecio.Value,

                        IdCategoria =
                            cmbCategoria.SelectedValue == null ||
                            cmbCategoria.SelectedIndex < 0
                                ? null
                                : cmbCategoria.SelectedValue
                                    .ToString(),

                        IdDescuento =
                            cmbDescuento.SelectedValue == null ||
                            cmbDescuento.SelectedIndex < 0
                                ? null
                                : cmbDescuento.SelectedValue
                                    .ToString()
                    };

                if (platilloDAL.Insertar(
                    platillo))
                {
                    MessageBox.Show(
                        "Platillo guardado correctamente.",
                        "Guardar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Limpiar();
                    CargarPlatillos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo guardar el platillo.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el platillo:\n\n" +
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
                    txtProducto.Text))
                {
                    MessageBox.Show(
                        "Seleccione un platillo.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Platillo platillo =
                    new Platillo
                    {
                        IdProducto =
                            txtProducto.Text.Trim(),

                        Nombre =
                            txtNombre.Text.Trim(),

                        Precio =
                            nudPrecio.Value,

                        IdCategoria =
                            cmbCategoria.SelectedValue == null ||
                            cmbCategoria.SelectedIndex < 0
                                ? null
                                : cmbCategoria.SelectedValue
                                    .ToString(),

                        IdDescuento =
                            cmbDescuento.SelectedValue == null ||
                            cmbDescuento.SelectedIndex < 0
                                ? null
                                : cmbDescuento.SelectedValue
                                    .ToString()
                    };

                if (platilloDAL.Modificar(
                    platillo))
                {
                    MessageBox.Show(
                        "Platillo modificado correctamente.",
                        "Modificar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Limpiar();
                    CargarPlatillos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo modificar el platillo.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
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

        // =========================================================
        // ELIMINAR
        // =========================================================

        private void btnEliminar2_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    txtProducto.Text))
                {
                    MessageBox.Show(
                        "Seleccione un platillo.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (MessageBox.Show(
                    "¿Está seguro de eliminar el platillo?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                    != DialogResult.Yes)
                {
                    return;
                }

                if (platilloDAL.Eliminar(
                    txtProducto.Text.Trim()))
                {
                    MessageBox.Show(
                        "Platillo eliminado correctamente.",
                        "Eliminar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Limpiar();
                    CargarPlatillos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo eliminar el platillo.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
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

        // =========================================================
        // BUSCAR
        // =========================================================

        private void btnBuscar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                string termino =
                    txtBuscar.Text.Trim();

                if (string.IsNullOrWhiteSpace(
                    termino))
                {
                    CargarPlatillos();
                    return;
                }

                DataTable tabla =
                    platilloDAL.BuscarTabla(
                        termino);

                dgvPlatillos.DataSource = null;
                dgvPlatillos.DataSource = tabla;

                dgvPlatillos.ClearSelection();

                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron platillos.",
                        "Búsqueda",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al realizar la búsqueda:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // SELECCIONAR FILA
        // =========================================================

        private void dgvPlatillos_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow fila =
                    dgvPlatillos.Rows[e.RowIndex];

                if (fila.Cells["id_producto"].Value != null)
                {
                    txtProducto.Text =
                        fila.Cells["id_producto"]
                            .Value
                            .ToString();
                }

                if (fila.Cells["nombre"].Value != null)
                {
                    txtNombre.Text =
                        fila.Cells["nombre"]
                            .Value
                            .ToString();
                }

                if (fila.Cells["precio"].Value != null &&
                    fila.Cells["precio"].Value != DBNull.Value)
                {
                    decimal precio =
                        Convert.ToDecimal(
                            fila.Cells["precio"].Value,
                            CultureInfo.InvariantCulture);

                    if (precio >= nudPrecio.Minimum &&
                        precio <= nudPrecio.Maximum)
                    {
                        nudPrecio.Value = precio;
                    }
                }

                if (fila.Cells["id_categoria"].Value != null &&
                    fila.Cells["id_categoria"].Value != DBNull.Value)
                {
                    cmbCategoria.SelectedValue =
                        fila.Cells["id_categoria"]
                            .Value
                            .ToString();
                }
                else
                {
                    cmbCategoria.SelectedIndex = -1;
                }

                if (fila.Cells["id_descuento"].Value != null &&
                    fila.Cells["id_descuento"].Value != DBNull.Value)
                {
                    cmbDescuento.SelectedValue =
                        fila.Cells["id_descuento"]
                            .Value
                            .ToString();
                }
                else
                {
                    cmbDescuento.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al seleccionar el platillo:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // LOAD
        // =========================================================

        private void FrmPlatillos_Load(
            object sender,
            EventArgs e)
        {
            AplicarDiseno();
            DistribuirInterfaz();

            CargarCategorias();
            CargarDescuentos();
            CargarPlatillos();
        }
    }
}