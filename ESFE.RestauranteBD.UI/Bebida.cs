using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmBebida : Form
    {
        private readonly BebidaLN bebidaLN;

        // =========================================================
        // COLORES DEL DISEÑO
        // =========================================================

        private readonly Color Fondo = Color.FromArgb(10, 10, 10);
        private readonly Color Panel = Color.FromArgb(24, 24, 24);
        private readonly Color Campo = Color.FromArgb(35, 35, 35);

        private readonly Color Dorado = Color.FromArgb(212, 175, 55);
        private readonly Color DoradoClaro = Color.FromArgb(235, 210, 130);

        private readonly Color Blanco = Color.FromArgb(245, 245, 245);
        private readonly Color Gris = Color.FromArgb(170, 170, 170);
        private readonly Color Borde = Color.FromArgb(55, 55, 55);

        private readonly Color Rojo = Color.FromArgb(155, 45, 45);

        // COLORES DE BOTONES
        private readonly Color AzulModificar =
            Color.FromArgb(45, 90, 125);

        private readonly Color VerdeLimpiar =
            Color.FromArgb(55, 105, 85);

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

        private Label lblIdBebida;
        private Label lblNombre;
        private Label lblPrecio;

        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public FrmBebida()
        {
            InitializeComponent();

            bebidaLN = new BebidaLN();

            ConfigurarFormulario();
            PrepararControles();
            CrearInterfaz();
            AplicarDiseno();
            CargarBebidas();

            Resize += FrmBebida_Resize;
        }

        // =========================================================
        // CONFIGURACIÓN DEL FORMULARIO
        // =========================================================

        private void ConfigurarFormulario()
        {
            Text = "RESTAURANTEBD | Bebidas";

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

        // =========================================================
        // PREPARAR CONTROLES
        // =========================================================

        private void PrepararControles()
        {
            OcultarLabels(this);

            OcultarControl<Button>("button1");
            OcultarControl<Button>("button2");
        }

        private void OcultarControl<T>(
            string nombre) where T : Control
        {
            T control = ObtenerControl<T>(nombre);

            if (control != null)
            {
                control.Visible = false;
            }
        }

        private T ObtenerControl<T>(
            string nombre) where T : Control
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
            Button btnModificar =
                ObtenerControl<Button>("btnActualizar");

            if (btnModificar != null)
            {
                btnModificar.Visible = true;
                return btnModificar;
            }

            btnModificar =
                ObtenerControl<Button>("btnModificar");

            if (btnModificar != null)
            {
                btnModificar.Visible = true;
                return btnModificar;
            }

            btnModificar = new Button();

            btnModificar.Name = "btnModificar";
            btnModificar.Text = "Modificar";

            btnModificar.Click += btnModificar_Click;

            Controls.Add(btnModificar);

            btnModificar.Visible = true;

            return btnModificar;
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
            panelCabecera = CrearPanel("panelCabecera");
            panelBusqueda = CrearPanel("panelBusqueda");
            panelInformacion = CrearPanel("panelInformacion");
            panelAcciones = CrearPanel("panelAcciones");
            panelTabla = CrearPanel("panelTabla");

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
                "Gestión de bebidas",
                15F,
                Gris,
                true);

            lblBusqueda = CrearEtiqueta(
                "BUSCAR BEBIDA",
                13F,
                Dorado,
                true);

            lblInformacion = CrearEtiqueta(
                "INFORMACIÓN DE LA BEBIDA",
                13F,
                Dorado,
                true);

            lblRegistros = CrearEtiqueta(
                "BEBIDAS REGISTRADAS",
                13F,
                Dorado,
                true);

            lblIdBebida = CrearEtiqueta(
                "ID DE BEBIDA",
                10F,
                Gris,
                true);

            lblNombre = CrearEtiqueta(
                "NOMBRE",
                10F,
                Gris,
                true);

            lblPrecio = CrearEtiqueta(
                "PRECIO",
                10F,
                Gris,
                true);

            panelCabecera.Controls.Add(lblTitulo);
            panelCabecera.Controls.Add(lblSubtitulo);

            panelBusqueda.Controls.Add(lblBusqueda);

            panelInformacion.Controls.Add(lblInformacion);
            panelInformacion.Controls.Add(lblIdBebida);
            panelInformacion.Controls.Add(lblNombre);
            panelInformacion.Controls.Add(lblPrecio);

            panelTabla.Controls.Add(lblRegistros);
        }

        // =========================================================
        // AGREGAR CONTROLES
        // =========================================================

        private void AgregarControles()
        {
            TextBox txtBuscar =
                ObtenerControl<TextBox>("txtBuscar");

            Button btnBuscar =
                ObtenerControl<Button>("btnBuscar");

            TextBox txtIDBebida =
                ObtenerControl<TextBox>("txtIDBebida");

            TextBox txtNombre =
                ObtenerControl<TextBox>("txtNombre");

            TextBox txtPrecio =
                ObtenerControl<TextBox>("txtPrecio");

            Button btnGuardar =
                ObtenerControl<Button>("btnGuardar");

            if (btnGuardar == null)
            {
                btnGuardar =
                    ObtenerControl<Button>("button1");
            }

            Button btnModificar =
                ObtenerBotonModificar();

            Button btnEliminar =
                ObtenerControl<Button>("btnEliminar");

            Button btnLimpiar =
                ObtenerControl<Button>("btnLimpiar");

            if (btnLimpiar == null)
            {
                btnLimpiar =
                    ObtenerControl<Button>("button2");
            }

            DataGridView dgv =
                ObtenerControl<DataGridView>("dgvBebidas");

            if (txtBuscar != null)
                panelBusqueda.Controls.Add(txtBuscar);

            if (btnBuscar != null)
                panelBusqueda.Controls.Add(btnBuscar);

            if (txtIDBebida != null)
                panelInformacion.Controls.Add(txtIDBebida);

            if (txtNombre != null)
                panelInformacion.Controls.Add(txtNombre);

            if (txtPrecio != null)
                panelInformacion.Controls.Add(txtPrecio);

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

            // =====================================================
            // CABECERA
            // =====================================================

            panelCabecera.Location = new Point(0, 0);

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

            lblIdBebida.Location =
                new Point(x1, 70);

            lblNombre.Location =
                new Point(x2, 70);

            lblPrecio.Location =
                new Point(x3, 70);

            TextBox txtIDBebida =
                ObtenerControl<TextBox>("txtIDBebida");

            TextBox txtNombre =
                ObtenerControl<TextBox>("txtNombre");

            TextBox txtPrecio =
                ObtenerControl<TextBox>("txtPrecio");

            if (txtIDBebida != null)
            {
                txtIDBebida.Location =
                    new Point(x1, 103);

                txtIDBebida.Size =
                    new Size(campoAncho, 43);
            }

            if (txtNombre != null)
            {
                txtNombre.Location =
                    new Point(x2, 103);

                txtNombre.Size =
                    new Size(campoAncho, 43);
            }

            if (txtPrecio != null)
            {
                txtPrecio.Location =
                    new Point(x3, 103);

                txtPrecio.Size =
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

            if (btnGuardar == null)
            {
                btnGuardar =
                    ObtenerControl<Button>("button1");
            }

            Button btnModificar =
                ObtenerBotonModificar();

            Button btnEliminar =
                ObtenerControl<Button>("btnEliminar");

            Button btnLimpiar =
                ObtenerControl<Button>("btnLimpiar");

            if (btnLimpiar == null)
            {
                btnLimpiar =
                    ObtenerControl<Button>("button2");
            }

            // =====================================================
            // LOS CUATRO BOTONES
            //
            // Guardar | Modificar | Eliminar | Limpiar
            // =====================================================

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

                btnGuardar.Text = "Guardar";

                btnGuardar.BringToFront();
            }

            // =====================================================
            // MODIFICAR
            // =====================================================

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

                btnModificar.Text = "Modificar";

                btnModificar.BringToFront();
            }

            // ELIMINAR
            if (btnEliminar != null)
            {
                btnEliminar.Visible = true;

                btnEliminar.Location =
                    new Point(
                        inicio +
                        ((botonAncho + separacion) * 2),
                        27);

                btnEliminar.Size =
                    new Size(
                        botonAncho,
                        botonAlto);

                btnEliminar.Text = "Eliminar";

                btnEliminar.BringToFront();
            }

            // LIMPIAR
            if (btnLimpiar != null)
            {
                btnLimpiar.Visible = true;

                btnLimpiar.Location =
                    new Point(
                        inicio +
                        ((botonAncho + separacion) * 3),
                        27);

                btnLimpiar.Size =
                    new Size(
                        botonAncho,
                        botonAlto);

                btnLimpiar.Text = "Limpiar";

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

            DataGridView dgv =
                ObtenerControl<DataGridView>("dgvBebidas");

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

        private void FrmBebida_Resize(
            object sender,
            EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
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
                ObtenerControl<TextBox>("txtIDBebida"));

            EstilizarTextBox(
                ObtenerControl<TextBox>("txtNombre"));

            EstilizarTextBox(
                ObtenerControl<TextBox>("txtPrecio"));

            Button btnBuscar =
                ObtenerControl<Button>("btnBuscar");

            Button btnGuardar =
                ObtenerControl<Button>("btnGuardar");

            if (btnGuardar == null)
            {
                btnGuardar =
                    ObtenerControl<Button>("button1");
            }

            Button btnModificar =
                ObtenerBotonModificar();

            Button btnEliminar =
                ObtenerControl<Button>("btnEliminar");

            Button btnLimpiar =
                ObtenerControl<Button>("btnLimpiar");

            if (btnLimpiar == null)
            {
                btnLimpiar =
                    ObtenerControl<Button>("button2");
            }

            // =====================================================
            // BOTÓN BUSCAR
            // =====================================================

            EstilizarBoton(
                btnBuscar,
                Dorado,
                Color.Black);

            // =====================================================
            // BOTÓN GUARDAR
            // =====================================================

            EstilizarBoton(
                btnGuardar,
                Dorado,
                Color.Black);

            // =====================================================
            // BOTÓN MODIFICAR
            // Azul elegante
            // =====================================================

            EstilizarBoton(
                btnModificar,
                AzulModificar,
                Blanco);

            // =====================================================
            // BOTÓN ELIMINAR
            // Rojo elegante
            // =====================================================

            EstilizarBoton(
                btnEliminar,
                Rojo,
                Blanco);

            // =====================================================
            // BOTÓN LIMPIAR
            // Verde elegante
            // =====================================================

            EstilizarBoton(
                btnLimpiar,
                VerdeLimpiar,
                Blanco);

            EstilizarTabla(
                ObtenerControl<DataGridView>(
                    "dgvBebidas"));
        }

        private void EstilizarTextBox(TextBox caja)
        {
            if (caja == null)
                return;

            caja.BackColor = Campo;
            caja.ForeColor = Blanco;
            caja.BorderStyle = BorderStyle.FixedSingle;

            caja.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Regular);

            caja.Margin = new Padding(5);
            caja.Multiline = false;
        }

        private void EstilizarBoton(
            Button boton,
            Color fondo,
            Color texto)
        {
            if (boton == null)
                return;

            boton.BackColor = fondo;
            boton.ForeColor = texto;

            boton.FlatStyle = FlatStyle.Flat;

            boton.FlatAppearance.BorderSize = 0;

            boton.Font =
                new Font(
                    "Segoe UI Semibold",
                    11F,
                    FontStyle.Bold);

            boton.Cursor = Cursors.Hand;

            boton.UseVisualStyleBackColor = false;

            boton.Visible = true;
        }

        private void EstilizarTabla(DataGridView tabla)
        {
            if (tabla == null)
                return;

            tabla.BackgroundColor = Panel;
            tabla.BorderStyle = BorderStyle.None;

            tabla.EnableHeadersVisualStyles = false;

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
        }

        // =========================================================
        // CARGAR BEBIDAS
        // =========================================================

        private void CargarBebidas()
        {
            try
            {
                List<ESFE.RestauranteBD.EN.Bebida> lista =
                    bebidaLN.Buscar("");

                var dgv =
                    ObtenerControl<DataGridView>(
                        "dgvBebidas");

                if (dgv != null)
                {
                    dgv.DataSource = null;
                    dgv.DataSource = lista;
                    dgv.Refresh();
                    dgv.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las bebidas:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // GUARDAR
        // =========================================================

        private void button1_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                var txtIDBebida =
                    ObtenerControl<TextBox>(
                        "txtIDBebida");

                var txtNombre =
                    ObtenerControl<TextBox>(
                        "txtNombre");

                var txtPrecio =
                    ObtenerControl<TextBox>(
                        "txtPrecio");

                if (txtIDBebida == null ||
                    string.IsNullOrWhiteSpace(
                        txtIDBebida.Text))
                {
                    MessageBox.Show(
                        "Ingrese el ID de la bebida.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtIDBebida?.Focus();
                    return;
                }

                if (txtNombre == null ||
                    string.IsNullOrWhiteSpace(
                        txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre de la bebida.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre?.Focus();
                    return;
                }

                if (txtPrecio == null ||
                    !decimal.TryParse(
                        txtPrecio.Text,
                        out decimal precio))
                {
                    MessageBox.Show(
                        "Ingrese un precio válido.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtPrecio?.Focus();
                    return;
                }

                ESFE.RestauranteBD.EN.Bebida bebida =
                    new ESFE.RestauranteBD.EN.Bebida
                    {
                        IdBebida =
                            txtIDBebida.Text.Trim(),

                        Nombre =
                            txtNombre.Text.Trim(),

                        Precio = precio
                    };

                if (bebidaLN.Insertar(bebida))
                {
                    MessageBox.Show(
                        "¡Bebida guardada correctamente!",
                        "Guardar Bebida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarBebidas();
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
                    "Error al guardar la bebida:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            button1_Click(sender, e);
        }

        // =========================================================
        // LIMPIAR
        // =========================================================

        private void button2_Click(
            object sender,
            EventArgs e)
        {
            Limpiar();
        }

        private void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            ObtenerControl<TextBox>(
                "txtIDBebida")?.Clear();

            ObtenerControl<TextBox>(
                "txtNombre")?.Clear();

            ObtenerControl<TextBox>(
                "txtPrecio")?.Clear();

            ObtenerControl<TextBox>(
                "txtIDBebida")?.Focus();
        }

        private void LimpiarCampos()
        {
            Limpiar();
        }

        // =========================================================
        // SELECCIONAR BEBIDA
        // =========================================================

        private void dataGridView1_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                var dgvBebidas =
                    ObtenerControl<DataGridView>(
                        "dgvBebidas");

                if (dgvBebidas != null &&
                    e.RowIndex >= 0)
                {
                    DataGridViewRow fila =
                        dgvBebidas.Rows[e.RowIndex];

                    var txtIDBebida =
                        ObtenerControl<TextBox>(
                            "txtIDBebida");

                    var txtNombre =
                        ObtenerControl<TextBox>(
                            "txtNombre");

                    var txtPrecio =
                        ObtenerControl<TextBox>(
                            "txtPrecio");

                    if (txtIDBebida != null)
                    {
                        txtIDBebida.Text =
                            fila.Cells["IdBebida"]
                            .Value?.ToString() ?? "";
                    }

                    if (txtNombre != null)
                    {
                        txtNombre.Text =
                            fila.Cells["Nombre"]
                            .Value?.ToString() ?? "";
                    }

                    if (txtPrecio != null)
                    {
                        txtPrecio.Text =
                            fila.Cells["Precio"]
                            .Value?.ToString() ?? "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al seleccionar la bebida:\n\n" +
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
                var txtBuscar =
                    ObtenerControl<TextBox>(
                        "txtBuscar")
                    ??
                    ObtenerControl<TextBox>(
                        "txtNombre");

                string termino =
                    txtBuscar != null
                        ? txtBuscar.Text.Trim()
                        : "";

                List<ESFE.RestauranteBD.EN.Bebida> lista =
                    bebidaLN.Buscar(termino);

                var dgvBebidas =
                    ObtenerControl<DataGridView>(
                        "dgvBebidas");

                if (dgvBebidas != null)
                {
                    dgvBebidas.DataSource = null;
                    dgvBebidas.DataSource = lista;
                    dgvBebidas.Refresh();
                    dgvBebidas.ClearSelection();
                }

                if (lista.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron bebidas.",
                        "Búsqueda",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar la bebida:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click1(
            object sender,
            EventArgs e)
        {
            btnBuscar_Click(sender, e);
        }

        // =========================================================
        // ACTUALIZAR / MODIFICAR
        // =========================================================

        private void btnActualizar_Click(
            object sender,
            EventArgs e)
        {
            btnModificar_Click(sender, e);
        }

        private void btnModificar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                var txtIDBebida =
                    ObtenerControl<TextBox>(
                        "txtIDBebida");

                var txtNombre =
                    ObtenerControl<TextBox>(
                        "txtNombre");

                var txtPrecio =
                    ObtenerControl<TextBox>(
                        "txtPrecio");

                if (txtIDBebida == null ||
                    string.IsNullOrWhiteSpace(
                        txtIDBebida.Text))
                {
                    MessageBox.Show(
                        "Seleccione una bebida para modificar.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (txtNombre == null ||
                    string.IsNullOrWhiteSpace(
                        txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre de la bebida.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre?.Focus();
                    return;
                }

                if (txtPrecio == null ||
                    string.IsNullOrWhiteSpace(
                        txtPrecio.Text))
                {
                    MessageBox.Show(
                        "Ingrese el precio.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtPrecio?.Focus();
                    return;
                }

                if (!decimal.TryParse(
                    txtPrecio.Text,
                    out decimal precio))
                {
                    MessageBox.Show(
                        "El precio debe ser un número válido.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtPrecio?.Focus();
                    return;
                }

                Bebida bebida =
                    new Bebida
                    {
                        IdBebida =
                            txtIDBebida.Text.Trim(),

                        Nombre =
                            txtNombre.Text.Trim(),

                        Precio = precio
                    };

                if (bebidaLN.Actualizar(bebida))
                {
                    MessageBox.Show(
                        "Bebida modificada correctamente.",
                        "Modificar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarBebidas();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo modificar la bebida.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al modificar la bebida:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
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
                var txtIDBebida =
                    ObtenerControl<TextBox>(
                        "txtIDBebida");

                if (txtIDBebida == null ||
                    string.IsNullOrWhiteSpace(
                        txtIDBebida.Text))
                {
                    MessageBox.Show(
                        "Seleccione una bebida.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (MessageBox.Show(
                    "¿Está seguro de eliminar la bebida?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    if (bebidaLN.Eliminar(
                        txtIDBebida.Text.Trim()))
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
                    "Error al eliminar la bebida:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // LOAD
        // =========================================================

        private void Bebida_Load(
            object sender,
            EventArgs e)
        {
            AplicarDiseno();
            DistribuirInterfaz();
            CargarBebidas();
        }

        private void FrmBebida_Load(
            object sender,
            EventArgs e)
        {
            AplicarDiseno();
            DistribuirInterfaz();
            CargarBebidas();
        }

        // =========================================================
        // EVENTOS DEL DISEÑADOR
        // =========================================================

        private void label1_Click(
            object sender,
            EventArgs e)
        {
        }

        private void label2_Click(
            object sender,
            EventArgs e)
        {
        }

        private void label3_Click(
            object sender,
            EventArgs e)
        {
        }

        private void textBox1_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void textBox2_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void label5_Click(
            object sender,
            EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }
    }
}