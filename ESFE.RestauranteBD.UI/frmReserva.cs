using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;

namespace ESFE.RestauranteBD.UI
{
    public partial class frmReserva : Form
    {
        private readonly ReservaLN reservaLN;

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
        private Panel panelInformacion;
        private Panel panelAcciones;
        private Panel panelTabla;

        // =========================================================
        // TÍTULOS
        // =========================================================

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblInformacion;
        private Label lblRegistros;

        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public frmReserva()
        {
            InitializeComponent();

            reservaLN = new ReservaLN();

            ConfigurarFormulario();
            CrearInterfaz();
            AplicarDiseno();

            Resize += frmReserva_Resize;
        }

        // =========================================================
        // CONFIGURACIÓN DEL FORMULARIO
        // =========================================================

        private void ConfigurarFormulario()
        {
            Text =
                "RESTAURANTEBD | Reservas";

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

            BackColor =
                Fondo;

            Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Regular);
        }

        // =========================================================
        // CREAR INTERFAZ
        // =========================================================

        private void CrearInterfaz()
        {
            panelCabecera =
                CrearPanel("panelCabecera");

            panelInformacion =
                CrearPanel("panelInformacion");

            panelAcciones =
                CrearPanel("panelAcciones");

            panelTabla =
                CrearPanel("panelTabla");

            Controls.Add(panelCabecera);
            Controls.Add(panelInformacion);
            Controls.Add(panelAcciones);
            Controls.Add(panelTabla);

            panelCabecera.BringToFront();
            panelInformacion.BringToFront();
            panelAcciones.BringToFront();
            panelTabla.BringToFront();

            // =====================================================
            // TÍTULOS
            // =====================================================

            lblTitulo =
                CrearEtiqueta(
                    "✦  RESTAURANTEBD",
                    28F,
                    Dorado,
                    true);

            lblSubtitulo =
                CrearEtiqueta(
                    "Gestión de reservas",
                    15F,
                    Gris,
                    true);

            lblInformacion =
                CrearEtiqueta(
                    "INFORMACIÓN DE LA RESERVA",
                    13F,
                    Dorado,
                    true);

            lblRegistros =
                CrearEtiqueta(
                    "RESERVAS REGISTRADAS",
                    13F,
                    Dorado,
                    true);

            panelCabecera.Controls.Add(lblTitulo);
            panelCabecera.Controls.Add(lblSubtitulo);

            panelInformacion.Controls.Add(lblInformacion);

            panelTabla.Controls.Add(lblRegistros);

            // =====================================================
            // CONTROLES ORIGINALES
            // =====================================================

            panelInformacion.Controls.Add(lbldReserva);
            panelInformacion.Controls.Add(lblFecha);
            panelInformacion.Controls.Add(lblNombre);
            panelInformacion.Controls.Add(lblIdCliente);
            panelInformacion.Controls.Add(lblPersonas);
            panelInformacion.Controls.Add(lblIdMesa);

            panelInformacion.Controls.Add(txtIdReserva);
            panelInformacion.Controls.Add(dtpFecha);
            panelInformacion.Controls.Add(dateTimePicker2);
            panelInformacion.Controls.Add(numPersonas);
            panelInformacion.Controls.Add(txtMesa);
            panelInformacion.Controls.Add(txtIdcliente);

            panelAcciones.Controls.Add(btnNuevo);
            panelAcciones.Controls.Add(btnAgregar);
            panelAcciones.Controls.Add(btnActualizar);
            panelAcciones.Controls.Add(btnEliminar);
            panelAcciones.Controls.Add(btnLimpiar);

            panelTabla.Controls.Add(dgvReserva);
        }

        // =========================================================
        // CREAR PANEL
        // =========================================================

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
        // CREAR ETIQUETA
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

        // =========================================================
        // DISEÑO
        // =========================================================

        private void AplicarDiseno()
        {
            // =====================================================
            // ETIQUETAS ORIGINALES
            // =====================================================

            EstilizarEtiqueta(lbldReserva);
            EstilizarEtiqueta(lblFecha);
            EstilizarEtiqueta(lblNombre);
            EstilizarEtiqueta(lblIdCliente);
            EstilizarEtiqueta(lblPersonas);
            EstilizarEtiqueta(lblIdMesa);

            lbldReserva.Text = "ID DE RESERVA";
            lblFecha.Text = "FECHA";
            lblNombre.Text = "HORA";
            lblIdCliente.Text = "CLIENTE";
            lblPersonas.Text = "PERSONAS";
            lblIdMesa.Text = "MESA";

            // =====================================================
            // CAMPOS
            // =====================================================

            EstilizarTextBox(txtIdReserva);
            EstilizarTextBox(txtMesa);
            EstilizarTextBox(txtIdcliente);

            EstilizarDateTimePicker(dtpFecha);
            EstilizarDateTimePicker(dateTimePicker2);
            EstilizarNumericUpDown(numPersonas);

            // =====================================================
            // BOTONES
            // =====================================================

            EstilizarBoton(
                btnNuevo,
                Color.FromArgb(65, 65, 65),
                Blanco);

            EstilizarBoton(
                btnAgregar,
                Dorado,
                Color.Black);

            EstilizarBoton(
                btnActualizar,
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

            btnNuevo.Text = "Nuevo";
            btnAgregar.Text = "Agregar";
            btnActualizar.Text = "Actualizar";
            btnEliminar.Text = "Eliminar";
            btnLimpiar.Text = "Limpiar";

            // =====================================================
            // TABLA
            // =====================================================

            EstilizarTabla(dgvReserva);

            DistribuirInterfaz();
        }

        // =========================================================
        // ETIQUETAS
        // =========================================================

        private void EstilizarEtiqueta(Label etiqueta)
        {
            if (etiqueta == null)
                return;

            etiqueta.ForeColor =
                Gris;

            etiqueta.BackColor =
                Color.Transparent;

            etiqueta.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            etiqueta.AutoSize =
                true;
        }

        // =========================================================
        // TEXTBOX
        // =========================================================

        private void EstilizarTextBox(TextBox caja)
        {
            if (caja == null)
                return;

            caja.BackColor =
                Campo;

            caja.ForeColor =
                Blanco;

            caja.BorderStyle =
                BorderStyle.FixedSingle;

            caja.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Regular);

            caja.Multiline =
                false;
        }

        // =========================================================
        // DATE TIME PICKER
        // =========================================================

        private void EstilizarDateTimePicker(
            DateTimePicker control)
        {
            if (control == null)
                return;

            control.CalendarMonthBackground =
                Campo;

            control.CalendarForeColor =
                Blanco;

            control.BackColor =
                Campo;

            control.ForeColor =
                Blanco;

            control.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Regular);
        }

        // =========================================================
        // NUMERIC UP DOWN
        // =========================================================

        private void EstilizarNumericUpDown(
            NumericUpDown control)
        {
            if (control == null)
                return;

            control.BackColor =
                Campo;

            control.ForeColor =
                Blanco;

            control.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Regular);

            control.Minimum = 1;
            control.Maximum = 50;
            control.Value = 1;
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

            boton.BackColor =
                fondo;

            boton.ForeColor =
                texto;

            boton.FlatStyle =
                FlatStyle.Flat;

            boton.FlatAppearance.BorderSize =
                0;

            boton.Font =
                new Font(
                    "Segoe UI Semibold",
                    10F,
                    FontStyle.Bold);

            boton.Cursor =
                Cursors.Hand;

            boton.UseVisualStyleBackColor =
                false;

            boton.Visible =
                true;
        }

        // =========================================================
        // TABLA
        // =========================================================

        private void EstilizarTabla(
            DataGridView tabla)
        {
            if (tabla == null)
                return;

            tabla.BackgroundColor =
                Panel;

            tabla.BorderStyle =
                BorderStyle.None;

            tabla.EnableHeadersVisualStyles =
                false;

            tabla.GridColor =
                Borde;

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

                    SelectionForeColor =
                        Blanco,

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

                    ForeColor =
                        Blanco,

                    SelectionBackColor =
                        Color.FromArgb(
                            80,
                            68,
                            30),

                    SelectionForeColor =
                        Blanco
                };

            tabla.ColumnHeadersHeight =
                48;

            tabla.RowTemplate.Height =
                44;

            tabla.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            tabla.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            tabla.MultiSelect =
                false;

            tabla.ReadOnly =
                true;

            tabla.AllowUserToAddRows =
                false;

            tabla.AllowUserToDeleteRows =
                false;

            tabla.AllowUserToResizeRows =
                false;

            tabla.RowHeadersVisible =
                false;

            tabla.Visible =
                true;
        }

        // =========================================================
        // DISTRIBUIR INTERFAZ
        // =========================================================

        private void DistribuirInterfaz()
        {
            if (panelCabecera == null ||
                panelInformacion == null ||
                panelAcciones == null ||
                panelTabla == null)
            {
                return;
            }

            int ancho =
                ClientSize.Width;

            int alto =
                ClientSize.Height;

            int margen = 60;

            // =====================================================
            // CABECERA
            // =====================================================

            panelCabecera.Location =
                new Point(0, 0);

            panelCabecera.Size =
                new Size(
                    ancho,
                    135);

            lblTitulo.Location =
                new Point(
                    55,
                    27);

            lblSubtitulo.Location =
                new Point(
                    59,
                    78);

            // =====================================================
            // INFORMACIÓN
            // =====================================================

            panelInformacion.Location =
                new Point(
                    margen,
                    165);

            panelInformacion.Size =
                new Size(
                    ancho - margen * 2,
                    330);

            lblInformacion.Location =
                new Point(
                    32,
                    22);

            // =====================================================
            // DISTRIBUCIÓN DE CAMPOS
            // =====================================================

            int espacio =
                (panelInformacion.Width - 96) / 3;

            int campoAncho =
                espacio - 32;

            int x1 = 32;

            int x2 =
                x1 + espacio;

            int x3 =
                x2 + espacio;

            // FILA 1
            lbldReserva.Location =
                new Point(
                    x1,
                    70);

            lblPersonas.Location =
                new Point(
                    x2,
                    70);

            lblFecha.Location =
                new Point(
                    x3,
                    70);

            txtIdReserva.Location =
                new Point(
                    x1,
                    105);

            txtIdReserva.Size =
                new Size(
                    campoAncho,
                    43);

            numPersonas.Location =
                new Point(
                    x2,
                    105);

            numPersonas.Size =
                new Size(
                    campoAncho,
                    43);

            dtpFecha.Location =
                new Point(
                    x3,
                    105);

            dtpFecha.Size =
                new Size(
                    campoAncho,
                    43);

            // =====================================================
            // FILA 2
            // =====================================================

            lblNombre.Location =
                new Point(
                    x1,
                    175);

            lblIdCliente.Location =
                new Point(
                    x2,
                    175);

            lblIdMesa.Location =
                new Point(
                    x3,
                    175);

            dateTimePicker2.Location =
                new Point(
                    x1,
                    210);

            dateTimePicker2.Size =
                new Size(
                    campoAncho,
                    43);

            txtIdcliente.Location =
                new Point(
                    x2,
                    210);

            txtIdcliente.Size =
                new Size(
                    campoAncho,
                    43);

            txtMesa.Location =
                new Point(
                    x3,
                    210);

            txtMesa.Size =
                new Size(
                    campoAncho,
                    43);

            // =====================================================
            // BOTONES
            // =====================================================

            panelAcciones.Location =
                new Point(
                    margen,
                    515);

            panelAcciones.Size =
                new Size(
                    ancho - margen * 2,
                    110);

            int botonAncho = 145;
            int botonAlto = 45;
            int separacion = 20;

            int anchoTotal =
                (botonAncho * 5) +
                (separacion * 4);

            int inicio =
                (panelAcciones.Width -
                 anchoTotal) / 2;

            if (inicio < 20)
                inicio = 20;

            // NUEVO
            btnNuevo.Location =
                new Point(
                    inicio,
                    30);

            btnNuevo.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            // AGREGAR
            btnAgregar.Location =
                new Point(
                    inicio +
                    (botonAncho +
                     separacion),
                    30);

            btnAgregar.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            // ACTUALIZAR
            btnActualizar.Location =
                new Point(
                    inicio +
                    ((botonAncho +
                      separacion) * 2),
                    30);

            btnActualizar.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            // ELIMINAR
            btnEliminar.Location =
                new Point(
                    inicio +
                    ((botonAncho +
                      separacion) * 3),
                    30);

            btnEliminar.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            // LIMPIAR
            btnLimpiar.Location =
                new Point(
                    inicio +
                    ((botonAncho +
                      separacion) * 4),
                    30);

            btnLimpiar.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            // =====================================================
            // TABLA
            // =====================================================

            panelTabla.Location =
                new Point(
                    margen,
                    650);

            panelTabla.Size =
                new Size(
                    ancho - margen * 2,
                    Math.Max(
                        260,
                        alto - 680));

            lblRegistros.Location =
                new Point(
                    32,
                    22);

            dgvReserva.Location =
                new Point(
                    32,
                    62);

            dgvReserva.Size =
                new Size(
                    panelTabla.Width - 64,
                    panelTabla.Height - 82);

            dgvReserva.BringToFront();
        }

        // =========================================================
        // RESIZE
        // =========================================================

        private void frmReserva_Resize(
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
        // LOAD
        // =========================================================

        private void frmReserva_Load(
            object sender,
            EventArgs e)
        {
            AplicarDiseno();
            DistribuirInterfaz();
            CargarReservas();

            dgvReserva.ClearSelection();
        }

        // =========================================================
        // CARGAR RESERVAS
        // =========================================================

        private void CargarReservas()
        {
            try
            {
                List<Reserva> lista =
                    reservaLN.Buscar("");

                dgvReserva.DataSource =
                    null;

                dgvReserva.DataSource =
                    lista;

                dgvReserva.Refresh();

                dgvReserva.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las reservas:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // NUEVO
        // =========================================================

        private void btnNuevo_Click(
            object sender,
            EventArgs e)
        {
            LimpiarCampos();

            txtIdReserva.Focus();
        }

        // =========================================================
        // AGREGAR
        // =========================================================

        private void btnAgregar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    txtIdReserva.Text))
                {
                    MessageBox.Show(
                        "Ingrese el ID de la reserva.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtIdReserva.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(
                    txtIdcliente.Text))
                {
                    MessageBox.Show(
                        "Ingrese el ID del cliente.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtIdcliente.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(
                    txtMesa.Text))
                {
                    MessageBox.Show(
                        "Ingrese el ID de la mesa.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtMesa.Focus();
                    return;
                }

                Reserva reserva =
                    ObtenerReservaDesdeControles();

                bool resultado =
                    reservaLN.Insertar(
                        reserva);

                if (resultado)
                {
                    MessageBox.Show(
                        "Reserva agregada correctamente.",
                        "Agregar Reserva",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarReservas();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al agregar la reserva:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // ACTUALIZAR
        // =========================================================

        private void btnActualizar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    txtIdReserva.Text))
                {
                    MessageBox.Show(
                        "Seleccione una reserva de la tabla.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Reserva reserva =
                    ObtenerReservaDesdeControles();

                bool resultado =
                    reservaLN.Actualizar(
                        reserva);

                if (resultado)
                {
                    MessageBox.Show(
                        "Reserva actualizada correctamente.",
                        "Actualizar Reserva",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarReservas();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró la reserva.",
                        "Actualizar Reserva",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar la reserva:\n\n" +
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
                    txtIdReserva.Text))
                {
                    MessageBox.Show(
                        "Seleccione una reserva para eliminar.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult confirmar =
                    MessageBox.Show(
                        "¿Está seguro de eliminar esta reserva?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (confirmar !=
                    DialogResult.Yes)
                {
                    return;
                }

                bool resultado =
                    reservaLN.Eliminar(
                        txtIdReserva.Text.Trim());

                if (resultado)
                {
                    MessageBox.Show(
                        "Reserva eliminada correctamente.",
                        "Eliminar Reserva",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarReservas();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo eliminar la reserva.",
                        "Eliminar Reserva",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar la reserva:\n\n" +
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
            txtIdReserva.Clear();

            txtIdcliente.Clear();

            txtMesa.Clear();

            numPersonas.Value = 1;

            dtpFecha.Value =
                DateTime.Today;

            dateTimePicker2.Value =
                DateTime.Now;

            dgvReserva.ClearSelection();

            dgvReserva.CurrentCell =
                null;

            txtIdReserva.Focus();
        }

        // =========================================================
        // OBTENER RESERVA DE LOS CONTROLES
        // =========================================================

        private Reserva ObtenerReservaDesdeControles()
        {
            return new Reserva
            {
                IdReserva =
                    txtIdReserva.Text.Trim(),

                fechaReserva =
                    dtpFecha.Value.Date,

                Hora =
                    dateTimePicker2.Value
                    .ToString("HH:mm"),

                Personas =
                    Convert.ToInt32(
                        numPersonas.Value),

                IdCliente =
                    txtIdcliente.Text.Trim(),

                IdMesa =
                    txtMesa.Text.Trim()
            };
        }

        // =========================================================
        // CELL CLICK
        // =========================================================

        private void dgvReserva_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow fila =
                    dgvReserva.Rows[e.RowIndex];

                txtIdReserva.Text =
                    Convert.ToString(
                        fila.Cells["IdReserva"]
                        .Value) ?? "";

                if (fila.Cells["fechaReserva"].Value != null)
                {
                    dtpFecha.Value =
                        Convert.ToDateTime(
                            fila.Cells["fechaReserva"].Value);
                }

                string hora =
                    Convert.ToString(
                        fila.Cells["Hora"].Value) ?? "";

                if (DateTime.TryParse(
                    hora,
                    out DateTime horaConvertida))
                {
                    dateTimePicker2.Value =
                        DateTime.Today.Add(
                            horaConvertida.TimeOfDay);
                }

                if (fila.Cells["Personas"].Value != null)
                {
                    int personas =
                        Convert.ToInt32(
                            fila.Cells["Personas"].Value);

                    if (personas >= numPersonas.Minimum &&
                        personas <= numPersonas.Maximum)
                    {
                        numPersonas.Value =
                            personas;
                    }
                }

                txtIdcliente.Text =
                    Convert.ToString(
                        fila.Cells["IdCliente"]
                        .Value) ?? "";

                txtMesa.Text =
                    Convert.ToString(
                        fila.Cells["IdMesa"]
                        .Value) ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al seleccionar la reserva:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // FECHA
        // =========================================================

        private void dateTimePicker1_ValueChanged(
            object sender,
            EventArgs e)
        {
        }
    }
}