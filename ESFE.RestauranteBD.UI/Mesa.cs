using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.BL;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmMesa : Form
    {
        private readonly MesaLN mesaLN = new MesaLN();

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
        private readonly Color AzulModificar = Color.FromArgb(45, 90, 125);
        private readonly Color VerdeLimpiar = Color.FromArgb(55, 105, 85);

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

        public FrmMesa()
        {
            InitializeComponent();

            ConfigurarFormulario();
            CrearInterfaz();
            ConfigurarEstado();
            AplicarDiseno();
            CargarGrid();

            Resize += FrmMesa_Resize;
        }

        // =========================================================
        // CONFIGURACIÓN DEL FORMULARIO
        // =========================================================

        private void ConfigurarFormulario()
        {
            Text = "RESTAURANTEBD | Mesas";

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
        // CREAR INTERFAZ
        // =========================================================

        private void CrearInterfaz()
        {
            CrearPaneles();
            CrearTitulos();
            AgregarControles();
            DistribuirInterfaz();
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
                "Gestión de mesas",
                15F,
                Gris,
                true);

            lblBusqueda = CrearEtiqueta(
                "BUSCAR MESA",
                13F,
                Dorado,
                true);

            lblInformacion = CrearEtiqueta(
                "INFORMACIÓN DE LA MESA",
                13F,
                Dorado,
                true);

            lblRegistros = CrearEtiqueta(
                "MESAS REGISTRADAS",
                13F,
                Dorado,
                true);

            panelCabecera.Controls.Add(lblTitulo);
            panelCabecera.Controls.Add(lblSubtitulo);

            panelBusqueda.Controls.Add(lblBusqueda);

            panelInformacion.Controls.Add(lblInformacion);

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

            TextBox txtNumeroMesa =
                ObtenerControl<TextBox>("txtNumeroMesa");

            Label lblTituloMesa =
                ObtenerControl<Label>("lblTituloMesa");

            Label lblCapacidad =
                ObtenerControl<Label>("lblCapacidad");

            NumericUpDown nudCapacidad =
                ObtenerControl<NumericUpDown>("nudCapacidad");

            Label lblEstado =
                ObtenerControl<Label>("lblEstado");

            ComboBox cmbEstado =
                ObtenerControl<ComboBox>("cmbEstado");

            Button btnGuardar =
                ObtenerControl<Button>("btnGuardar");

            Button btnModificar =
                ObtenerControl<Button>("btmModificar");

            if (btnModificar == null)
            {
                btnModificar =
                    ObtenerControl<Button>("btnModificar");
            }

            Button btnEliminar =
                ObtenerControl<Button>("btnEliminar");

            Button btnLimpiar =
                ObtenerControl<Button>("btnLimpiar");

            DataGridView dgvMesa =
                ObtenerControl<DataGridView>("dgvMesa");

            if (txtBuscar != null)
                panelBusqueda.Controls.Add(txtBuscar);

            if (btnBuscar != null)
                panelBusqueda.Controls.Add(btnBuscar);

            if (lblTituloMesa != null)
                panelInformacion.Controls.Add(lblTituloMesa);

            if (txtNumeroMesa != null)
                panelInformacion.Controls.Add(txtNumeroMesa);

            if (lblCapacidad != null)
                panelInformacion.Controls.Add(lblCapacidad);

            if (nudCapacidad != null)
                panelInformacion.Controls.Add(nudCapacidad);

            if (lblEstado != null)
                panelInformacion.Controls.Add(lblEstado);

            if (cmbEstado != null)
                panelInformacion.Controls.Add(cmbEstado);

            if (btnGuardar != null)
                panelAcciones.Controls.Add(btnGuardar);

            if (btnModificar != null)
                panelAcciones.Controls.Add(btnModificar);

            if (btnEliminar != null)
                panelAcciones.Controls.Add(btnEliminar);

            if (btnLimpiar != null)
                panelAcciones.Controls.Add(btnLimpiar);

            if (dgvMesa != null)
                panelTabla.Controls.Add(dgvMesa);
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
            panelCabecera.Location = new Point(0, 0);
            panelCabecera.Size = new Size(ancho, 135);

            lblTitulo.Location =
                new Point(55, 27);

            lblSubtitulo.Location =
                new Point(
                    ancho - lblSubtitulo.Width - 60,
                    82);

            // BÚSQUEDA
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

                btnBuscar.Text = "Buscar";
            }

            // INFORMACIÓN
            panelInformacion.Location =
                new Point(margen, 315);

            panelInformacion.Size =
                new Size(
                    ancho - margen * 2,
                    260);

            lblInformacion.Location =
                new Point(32, 22);

            int columnas = 3;

            int espacio =
                (panelInformacion.Width - 64) /
                columnas;

            int campoAncho =
                espacio - 22;

            int x1 = 32;
            int x2 = x1 + espacio;
            int x3 = x2 + espacio;

            // NÚMERO DE MESA
            Label lblTituloMesa =
                ObtenerControl<Label>("lblTituloMesa");

            if (lblTituloMesa != null)
            {
                lblTituloMesa.Text =
                    "NÚMERO DE MESA";

                lblTituloMesa.ForeColor = Gris;

                lblTituloMesa.Font =
                    new Font(
                        "Segoe UI",
                        10F,
                        FontStyle.Bold);

                lblTituloMesa.Location =
                    new Point(x1, 75);

                lblTituloMesa.Visible = true;
            }

            // CAPACIDAD
            Label lblCapacidad =
                ObtenerControl<Label>("lblCapacidad");

            if (lblCapacidad != null)
            {
                lblCapacidad.Text =
                    "CAPACIDAD";

                lblCapacidad.ForeColor = Gris;

                lblCapacidad.Font =
                    new Font(
                        "Segoe UI",
                        10F,
                        FontStyle.Bold);

                lblCapacidad.Location =
                    new Point(x2, 75);

                lblCapacidad.Visible = true;
            }

            // ESTADO
            Label lblEstado =
                ObtenerControl<Label>("lblEstado");

            if (lblEstado != null)
            {
                lblEstado.Text =
                    "ESTADO";

                lblEstado.ForeColor = Gris;

                lblEstado.Font =
                    new Font(
                        "Segoe UI",
                        10F,
                        FontStyle.Bold);

                lblEstado.Location =
                    new Point(x3, 75);

                lblEstado.Visible = true;
            }

            TextBox txtNumeroMesa =
                ObtenerControl<TextBox>("txtNumeroMesa");

            NumericUpDown nudCapacidad =
                ObtenerControl<NumericUpDown>("nudCapacidad");

            ComboBox cmbEstado =
                ObtenerControl<ComboBox>("cmbEstado");

            if (txtNumeroMesa != null)
            {
                txtNumeroMesa.Location =
                    new Point(x1, 108);

                txtNumeroMesa.Size =
                    new Size(
                        campoAncho,
                        43);
            }

            if (nudCapacidad != null)
            {
                nudCapacidad.Location =
                    new Point(x2, 108);

                nudCapacidad.Size =
                    new Size(
                        campoAncho,
                        43);

                nudCapacidad.DecimalPlaces = 0;
                nudCapacidad.Increment = 1;
                nudCapacidad.Minimum = 1;
                nudCapacidad.Maximum = 100;
                nudCapacidad.ThousandsSeparator = false;
            }

            if (cmbEstado != null)
            {
                cmbEstado.Location =
                    new Point(x3, 108);

                cmbEstado.Size =
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
                ObtenerControl<Button>("btnGuardar");

            Button btnModificar =
                ObtenerControl<Button>("btmModificar");

            if (btnModificar == null)
            {
                btnModificar =
                    ObtenerControl<Button>("btnModificar");
            }

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
                (panelAcciones.Width - anchoTotal) / 2;

            if (btnGuardar != null)
            {
                btnGuardar.Visible = true;

                btnGuardar.Location =
                    new Point(inicio, 27);

                btnGuardar.Size =
                    new Size(
                        botonAncho,
                        botonAlto);

                btnGuardar.Text = "Guardar";
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

                btnModificar.Text = "Modificar";
            }

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
            }

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

            lblRegistros.Location =
                new Point(32, 22);

            DataGridView dgv =
                ObtenerControl<DataGridView>("dgvMesa");

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

        private void FrmMesa_Resize(
            object sender,
            EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                DistribuirInterfaz();
            }
        }

        // =========================================================
        // ESTADO
        // =========================================================

        private void ConfigurarEstado()
        {
            ComboBox cmbEstado =
                ObtenerControl<ComboBox>("cmbEstado");

            if (cmbEstado == null)
                return;

            cmbEstado.Items.Clear();

            cmbEstado.Items.Add("Disponible");
            cmbEstado.Items.Add("Ocupada");

            cmbEstado.SelectedIndex = 0;
        }

        // =========================================================
        // DISEÑO
        // =========================================================

        private void AplicarDiseno()
        {
            EstilizarTextBox(
                ObtenerControl<TextBox>("txtBuscar"));

            EstilizarTextBox(
                ObtenerControl<TextBox>("txtNumeroMesa"));

            EstilizarNumericUpDown(
                ObtenerControl<NumericUpDown>(
                    "nudCapacidad"));

            EstilizarComboBox(
                ObtenerControl<ComboBox>(
                    "cmbEstado"));

            EstilizarBoton(
                ObtenerControl<Button>("btnBuscar"),
                Dorado,
                Color.Black);

            EstilizarBoton(
                ObtenerControl<Button>("btnGuardar"),
                Dorado,
                Color.Black);

            Button btnModificar =
                ObtenerControl<Button>("btmModificar");

            if (btnModificar == null)
            {
                btnModificar =
                    ObtenerControl<Button>("btnModificar");
            }

            EstilizarBoton(
                btnModificar,
                AzulModificar,
                Blanco);

            EstilizarBoton(
                ObtenerControl<Button>("btnEliminar"),
                Rojo,
                Blanco);

            EstilizarBoton(
                ObtenerControl<Button>("btnLimpiar"),
                VerdeLimpiar,
                Blanco);

            EstilizarTabla(
                ObtenerControl<DataGridView>(
                    "dgvMesa"));
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

            caja.Multiline = false;
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

            control.DecimalPlaces = 0;
            control.Increment = 1;
            control.Minimum = 1;
            control.Maximum = 100;
            control.ThousandsSeparator = false;
        }

        private void EstilizarComboBox(ComboBox combo)
        {
            if (combo == null)
                return;

            combo.BackColor = Campo;
            combo.ForeColor = Blanco;
            combo.FlatStyle = FlatStyle.Flat;

            combo.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Regular);
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
                        DataGridViewContentAlignment.MiddleCenter
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
                        DataGridViewContentAlignment.MiddleCenter
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
        // CARGAR GRID
        // =========================================================

        private void CargarGrid()
        {
            try
            {
                DataGridView dgv =
                    ObtenerControl<DataGridView>("dgvMesa");

                if (dgv == null)
                    return;

                dgv.DataSource = null;
                dgv.DataSource = mesaLN.Buscar("");

                ConfigurarColumnasGrid(dgv);

                dgv.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las mesas:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // CONFIGURAR COLUMNAS DEL GRID
        // =========================================================

        private void ConfigurarColumnasGrid(DataGridView dgv)
        {
            if (dgv.Columns.Count < 3)
                return;

            // Se utilizan posiciones, no nombres SQL.
            // La lista viene de la entidad Mesa:
            // 0 = IdMesa
            // 1 = Capacidad
            // 2 = Disponible

            dgv.Columns[0].HeaderText = "Número de mesa";
            dgv.Columns[1].HeaderText = "Capacidad";
            dgv.Columns[2].HeaderText = "Estado";
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
                    txtNumeroMesa.Text))
                {
                    MessageBox.Show(
                        "Ingrese el número de mesa.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Mesa mesa = new Mesa
                {
                    IdMesa =
                        txtNumeroMesa.Text.Trim(),

                    Capacidad =
                        Convert.ToInt32(
                            nudCapacidad.Value),

                    Disponible =
                        cmbEstado.Text == "Disponible"
                            ? "SI"
                            : "NO"
                };

                bool resultado =
                    mesaLN.Insertar(mesa);

                if (resultado)
                {
                    MessageBox.Show(
                        "Mesa guardada correctamente.",
                        "Guardar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarGrid();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo guardar la mesa.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar la mesa:\n\n" +
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
                    txtNumeroMesa.Text))
                {
                    MessageBox.Show(
                        "Seleccione una mesa primero.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Mesa mesa = new Mesa
                {
                    IdMesa =
                        txtNumeroMesa.Text.Trim(),

                    Capacidad =
                        Convert.ToInt32(
                            nudCapacidad.Value),

                    Disponible =
                        cmbEstado.Text.Trim()
                        .Equals(
                            "Disponible",
                            StringComparison.OrdinalIgnoreCase)
                            ? "SI"
                            : "NO"
                };

                bool resultado =
                    mesaLN.Actualizar(mesa);

                if (resultado)
                {
                    MessageBox.Show(
                        "Mesa modificada correctamente.",
                        "Modificar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarGrid();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo modificar la mesa.",
                        "Modificar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al modificar la mesa:\n\n" +
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
                if (string.IsNullOrWhiteSpace(
                    txtNumeroMesa.Text))
                {
                    MessageBox.Show(
                        "Seleccione una mesa para eliminar.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (MessageBox.Show(
                    "¿Desea eliminar la mesa seleccionada?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                    != DialogResult.Yes)
                {
                    return;
                }

                bool resultado =
                    mesaLN.Eliminar(
                        txtNumeroMesa.Text.Trim());

                if (resultado)
                {
                    MessageBox.Show(
                        "Mesa eliminada correctamente.",
                        "Eliminar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarGrid();
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo eliminar la mesa.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar la mesa:\n\n" +
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
            LimpiarFormulario();
            CargarGrid();
        }

        private void LimpiarFormulario()
        {
            txtNumeroMesa.Clear();

            nudCapacidad.Value = 1;

            if (cmbEstado.Items.Count > 0)
                cmbEstado.SelectedIndex = 0;
            else
                cmbEstado.Text = "";

            txtBuscar.Clear();

            txtNumeroMesa.Focus();
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

                DataGridView dgv =
                    ObtenerControl<DataGridView>("dgvMesa");

                if (dgv == null)
                    return;

                if (string.IsNullOrWhiteSpace(termino))
                {
                    CargarGrid();
                    return;
                }

                dgv.DataSource = null;
                dgv.DataSource =
                    mesaLN.Buscar(termino);

                ConfigurarColumnasGrid(dgv);

                dgv.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar la mesa:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // SELECCIONAR MESA
        // =========================================================

        private void dgvMesa_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            CargarMesaSeleccionada(e.RowIndex);
        }

        // Evento que puede estar conectado desde el Designer
        private void dgvMesa_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            CargarMesaSeleccionada(e.RowIndex);
        }

        private void CargarMesaSeleccionada(int filaIndex)
        {
            if (filaIndex < 0)
                return;

            try
            {
                DataGridView dgv =
                    ObtenerControl<DataGridView>("dgvMesa");

                if (dgv == null)
                    return;

                if (filaIndex >= dgv.Rows.Count)
                    return;

                DataGridViewRow fila =
                    dgv.Rows[filaIndex];

                // =================================================
                // IMPORTANTE:
                // NO SE USAN "ID Mesa", "id_mesa", etc.
                // Se utilizan las posiciones reales del Grid.
                //
                // 0 = IdMesa
                // 1 = Capacidad
                // 2 = Disponible
                // =================================================

                if (fila.Cells.Count >= 3)
                {
                    // Número de mesa
                    object valorId =
                        fila.Cells[0].Value;

                    if (valorId != null &&
                        valorId != DBNull.Value)
                    {
                        txtNumeroMesa.Text =
                            valorId.ToString().Trim();
                    }

                    // Capacidad
                    object valorCapacidad =
                        fila.Cells[1].Value;

                    if (valorCapacidad != null &&
                        valorCapacidad != DBNull.Value)
                    {
                        decimal capacidad =
                            Convert.ToDecimal(
                                valorCapacidad);

                        if (capacidad >= nudCapacidad.Minimum &&
                            capacidad <= nudCapacidad.Maximum)
                        {
                            nudCapacidad.Value =
                                capacidad;
                        }
                    }

                    // Estado
                    object valorDisponible =
                        fila.Cells[2].Value;

                    string disponible = "";

                    if (valorDisponible != null &&
                        valorDisponible != DBNull.Value)
                    {
                        disponible =
                            valorDisponible
                            .ToString()
                            .Trim()
                            .ToUpper();
                    }

                    if (disponible == "SI" ||
                        disponible == "DISPONIBLE")
                    {
                        cmbEstado.SelectedItem =
                            "Disponible";
                    }
                    else
                    {
                        cmbEstado.SelectedItem =
                            "Ocupada";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al seleccionar la mesa:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // LOAD
        // =========================================================

        private void FrmMesa_Load(
            object sender,
            EventArgs e)
        {
            ConfigurarEstado();
            AplicarDiseno();
            DistribuirInterfaz();
            CargarGrid();
        }

        private void Mesa_Load(
            object sender,
            EventArgs e)
        {
            ConfigurarEstado();
            AplicarDiseno();
            DistribuirInterfaz();
            CargarGrid();
        }

        // =========================================================
        // CAPACIDAD
        // =========================================================

        private void nudCapacidad_ValueChanged(
            object sender,
            EventArgs e)
        {
        }
    }
}