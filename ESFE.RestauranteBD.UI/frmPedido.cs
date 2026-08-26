using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmPedido : Form
    {
        private pedidoLN _pedidoLN = new pedidoLN();

        private readonly Color Fondo = Color.FromArgb(10, 10, 10);
        private readonly Color Panel = Color.FromArgb(24, 24, 24);
        private readonly Color Campo = Color.FromArgb(35, 35, 35);

        private readonly Color Dorado = Color.FromArgb(212, 175, 55);
        private readonly Color Blanco = Color.FromArgb(245, 245, 245);
        private readonly Color Gris = Color.FromArgb(170, 170, 170);
        private readonly Color Borde = Color.FromArgb(55, 55, 55);

        private readonly Color Rojo = Color.FromArgb(155, 45, 45);
        private readonly Color VerdeLimpiar = Color.FromArgb(55, 105, 85);

        private Panel panelCabecera;
        private Panel panelInformacion;
        private Panel panelAcciones;
        private Panel panelTabla;

        private Label lblEncabezado;
        private Label lblSubtitulo;
        private Label lblInformacion;
        private Label lblRegistros;

        private Label lblIdPedido;
        private Label lblIdCliente;
        private Label lblEmpleado;
        private Label lblMesa;
        private Label lblEstado;
        private Label lblFecha;

        public FrmPedido()
        {
            InitializeComponent();

            ConfigurarFormulario();
            CrearInterfaz();
            AplicarDiseno();

            Resize += FrmPedido_Resize;

            CargarComboBoxes();
            CargarPedidos();
        }

        private void ConfigurarFormulario()
        {
            Text = "RESTAURANTEBD | Pedidos";

            StartPosition = FormStartPosition.CenterScreen;

            FormBorderStyle = FormBorderStyle.Sizable;

            MaximizeBox = true;
            MinimizeBox = true;

            WindowState = FormWindowState.Maximized;

            MinimumSize = new Size(1150, 700);

            BackColor = Fondo;

            Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Regular);
        }

        private void CrearInterfaz()
        {
            CrearPaneles();
            CrearTitulos();
            CrearEtiquetas();
            AgregarControles();
            DistribuirInterfaz();
        }

        private void CrearPaneles()
        {
            panelCabecera = CrearPanel("panelCabecera");
            panelInformacion = CrearPanel("panelInformacion");
            panelAcciones = CrearPanel("panelAcciones");
            panelTabla = CrearPanel("panelTabla");

            Controls.Add(panelCabecera);
            Controls.Add(panelInformacion);
            Controls.Add(panelAcciones);
            Controls.Add(panelTabla);

            panelCabecera.BringToFront();
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
            lblEncabezado = CrearEtiqueta(
                "✦  RESTAURANTEBD",
                28F,
                Dorado,
                true);

            lblSubtitulo = CrearEtiqueta(
                "Gestión de pedidos",
                15F,
                Gris,
                true);

            lblInformacion = CrearEtiqueta(
                "INFORMACIÓN DEL PEDIDO",
                13F,
                Dorado,
                true);

            lblRegistros = CrearEtiqueta(
                "PEDIDOS REGISTRADOS",
                13F,
                Dorado,
                true);

            panelCabecera.Controls.Add(lblEncabezado);
            panelCabecera.Controls.Add(lblSubtitulo);

            panelInformacion.Controls.Add(lblInformacion);

            panelTabla.Controls.Add(lblRegistros);
        }

        private void CrearEtiquetas()
        {
            lblIdPedido = CrearEtiqueta(
                "ID DEL PEDIDO",
                10F,
                Gris,
                true);

            lblIdCliente = CrearEtiqueta(
                "ID DEL CLIENTE",
                10F,
                Gris,
                true);

            lblEmpleado = CrearEtiqueta(
                "EMPLEADO",
                10F,
                Gris,
                true);

            lblMesa = CrearEtiqueta(
                "MESA",
                10F,
                Gris,
                true);

            lblEstado = CrearEtiqueta(
                "ESTADO",
                10F,
                Gris,
                true);

            lblFecha = CrearEtiqueta(
                "FECHA",
                10F,
                Gris,
                true);
        }

        private void AgregarControles()
        {
            panelInformacion.Controls.Add(lblIdPedido);
            panelInformacion.Controls.Add(txtIdPedido);

            panelInformacion.Controls.Add(lblIdCliente);
            panelInformacion.Controls.Add(txtIdCliente);

            panelInformacion.Controls.Add(lblEmpleado);
            panelInformacion.Controls.Add(cboEmpleado);

            panelInformacion.Controls.Add(lblMesa);
            panelInformacion.Controls.Add(cboMesa);

            panelInformacion.Controls.Add(lblEstado);
            panelInformacion.Controls.Add(cboEstado);

            panelInformacion.Controls.Add(lblFecha);
            panelInformacion.Controls.Add(dtpFecha);

            panelAcciones.Controls.Add(btnBuscar);
            panelAcciones.Controls.Add(btnAgregar);
            panelAcciones.Controls.Add(btnEliminar);
            panelAcciones.Controls.Add(btnLimpiar);

            panelTabla.Controls.Add(dgvPedido);

            OcultarControlesOriginales();
        }

        private void OcultarControlesOriginales()
        {
            foreach (Control control in Controls)
            {
                if (control != panelCabecera &&
                    control != panelInformacion &&
                    control != panelAcciones &&
                    control != panelTabla)
                {
                    control.Visible = false;
                }
            }
        }

        private void DistribuirInterfaz()
        {
            int ancho = ClientSize.Width;
            int alto = ClientSize.Height;

            int margen = 60;

            panelCabecera.Location =
                new Point(0, 0);

            panelCabecera.Size =
                new Size(ancho, 135);

            lblEncabezado.Location =
                new Point(55, 27);

            lblSubtitulo.Location =
                new Point(59, 78);

            panelInformacion.Location =
                new Point(margen, 155);

            panelInformacion.Size =
                new Size(
                    ancho - margen * 2,
                    250);

            lblInformacion.Location =
                new Point(32, 20);

            int anchoDisponible =
                panelInformacion.Width - 64;

            int columnaAncho =
                (anchoDisponible - 44) / 3;

            int x1 = 32;
            int x2 = x1 + columnaAncho + 22;
            int x3 = x2 + columnaAncho + 22;

            int fila1 = 62;
            int fila2 = 152;

            lblIdPedido.Location =
                new Point(x1, fila1);

            txtIdPedido.Location =
                new Point(x1, fila1 + 27);

            txtIdPedido.Size =
                new Size(columnaAncho, 38);

            lblIdCliente.Location =
                new Point(x2, fila1);

            txtIdCliente.Location =
                new Point(x2, fila1 + 27);

            txtIdCliente.Size =
                new Size(columnaAncho, 38);

            lblEmpleado.Location =
                new Point(x3, fila1);

            cboEmpleado.Location =
                new Point(x3, fila1 + 27);

            cboEmpleado.Size =
                new Size(columnaAncho, 38);

            lblMesa.Location =
                new Point(x1, fila2);

            cboMesa.Location =
                new Point(x1, fila2 + 27);

            cboMesa.Size =
                new Size(columnaAncho, 38);

            lblEstado.Location =
                new Point(x2, fila2);

            cboEstado.Location =
                new Point(x2, fila2 + 27);

            cboEstado.Size =
                new Size(columnaAncho, 38);

            lblFecha.Location =
                new Point(x3, fila2);

            dtpFecha.Location =
                new Point(x3, fila2 + 27);

            dtpFecha.Size =
                new Size(columnaAncho, 38);

            panelAcciones.Location =
                new Point(margen, 425);

            panelAcciones.Size =
                new Size(
                    ancho - margen * 2,
                    100);

            int botonAncho = 180;
            int botonAlto = 48;
            int separacion = 30;

            int anchoTotal =
                (botonAncho * 4) +
                (separacion * 3);

            int inicio =
                (panelAcciones.Width - anchoTotal) / 2;

            btnBuscar.Location =
                new Point(inicio, 26);

            btnBuscar.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            btnBuscar.Text = "Buscar";

            btnAgregar.Location =
                new Point(
                    inicio +
                    botonAncho +
                    separacion,
                    26);

            btnAgregar.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            btnAgregar.Text = "Agregar";

            btnEliminar.Location =
                new Point(
                    inicio +
                    ((botonAncho + separacion) * 2),
                    26);

            btnEliminar.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            btnEliminar.Text = "Eliminar";

            btnLimpiar.Location =
                new Point(
                    inicio +
                    ((botonAncho + separacion) * 3),
                    26);

            btnLimpiar.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            btnLimpiar.Text = "Limpiar";

            panelTabla.Location =
                new Point(margen, 545);

            panelTabla.Size =
                new Size(
                    ancho - margen * 2,
                    Math.Max(
                        180,
                        alto - 575));

            lblRegistros.Location =
                new Point(32, 20);

            dgvPedido.Location =
                new Point(32, 60);

            dgvPedido.Size =
                new Size(
                    panelTabla.Width - 64,
                    panelTabla.Height - 80);
        }

        private void FrmPedido_Resize(
            object sender,
            EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                DistribuirInterfaz();
            }
        }

        private void AplicarDiseno()
        {
            EstilizarTextBox(txtIdPedido);
            EstilizarTextBox(txtIdCliente);

            EstilizarComboBox(cboEmpleado);
            EstilizarComboBox(cboMesa);
            EstilizarComboBox(cboEstado);

            EstilizarDateTimePicker(dtpFecha);

            EstilizarBoton(
                btnBuscar,
                Dorado,
                Color.Black);

            EstilizarBoton(
                btnAgregar,
                Dorado,
                Color.Black);

            EstilizarBoton(
                btnEliminar,
                Rojo,
                Blanco);

            EstilizarBoton(
                btnLimpiar,
                VerdeLimpiar,
                Blanco);

            EstilizarTabla(dgvPedido);
        }

        private void EstilizarTextBox(TextBox caja)
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

        private void EstilizarComboBox(ComboBox combo)
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

            combo.DropDownStyle =
                ComboBoxStyle.DropDownList;
        }

        private void EstilizarDateTimePicker(
            DateTimePicker fecha)
        {
            if (fecha == null)
                return;

            fecha.CalendarMonthBackground = Campo;
            fecha.CalendarForeColor = Blanco;
            fecha.CalendarTitleBackColor = Dorado;
            fecha.CalendarTitleForeColor = Color.Black;

            fecha.BackColor = Campo;
            fecha.ForeColor = Blanco;

            fecha.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Regular);

            fecha.Format =
                DateTimePickerFormat.Short;
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

        private void CargarComboBoxes()
        {
            cboEmpleado.Items.Clear();

            cboEmpleado.Items.Add("IDE_1");
            cboEmpleado.Items.Add("IDE_2");
            cboEmpleado.Items.Add("IDE_3");
            cboEmpleado.Items.Add("IDE_4");

            cboMesa.Items.Clear();

            cboMesa.Items.Add("M_01");
            cboMesa.Items.Add("M_02");
            cboMesa.Items.Add("M_03");
            cboMesa.Items.Add("M_04");

            cboEstado.Items.Clear();

            cboEstado.Items.Add("ES_01");
            cboEstado.Items.Add("ES_02");
            cboEstado.Items.Add("ES_03");
            cboEstado.Items.Add("ES_04");

            if (cboEmpleado.Items.Count > 0)
                cboEmpleado.SelectedIndex = 0;

            if (cboMesa.Items.Count > 0)
                cboMesa.SelectedIndex = 0;

            if (cboEstado.Items.Count > 0)
                cboEstado.SelectedIndex = 0;
        }

        private void CargarPedidos()
        {
            try
            {
                List<Pedido> lista =
                    _pedidoLN.Buscar("");

                dgvPedido.DataSource = null;
                dgvPedido.DataSource = lista;

                dgvPedido.ClearSelection();
            }
            catch
            {
            }
        }

        private void LimpiarCampos()
        {
            txtIdPedido.Clear();
            txtIdCliente.Clear();

            if (cboEmpleado.Items.Count > 0)
                cboEmpleado.SelectedIndex = 0;

            if (cboMesa.Items.Count > 0)
                cboMesa.SelectedIndex = 0;

            if (cboEstado.Items.Count > 0)
                cboEstado.SelectedIndex = 0;

            dtpFecha.Value = DateTime.Now;

            CargarPedidos();

            txtIdPedido.Focus();
        }

        private void btnBuscar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                string idPedido =
                    txtIdPedido.Text.Trim();

                List<Pedido> lista =
                    _pedidoLN.Buscar(idPedido);

                dgvPedido.DataSource = null;
                dgvPedido.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar: " +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    txtIdPedido.Text) ||
                    string.IsNullOrWhiteSpace(
                    txtIdCliente.Text))
                {
                    MessageBox.Show(
                        "Por favor completa los campos obligatorios.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Pedido pedido =
                    new Pedido
                    {
                        IdPedido =
                            txtIdPedido.Text.Trim(),

                        fecha =
                            dtpFecha.Value,

                        IDCliente =
                            txtIdCliente.Text.Trim(),

                        IdEmpleado =
                            cboEmpleado.Text.Trim(),

                        IdMesa =
                            cboMesa.Text.Trim(),

                        IdEstado =
                            cboEstado.Text.Trim()
                    };

                bool resultado =
                    _pedidoLN.Insertar(pedido);

                if (resultado)
                {
                    MessageBox.Show(
                        "Pedido guardado exitosamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarPedidos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo guardar el pedido.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar: " +
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
                string idPedido =
                    txtIdPedido.Text.Trim();

                if (string.IsNullOrWhiteSpace(idPedido))
                {
                    MessageBox.Show(
                        "Ingresa el ID del pedido a eliminar.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult confirmacion =
                    MessageBox.Show(
                        "¿Deseas eliminar el pedido " +
                        idPedido +
                        "?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (confirmacion != DialogResult.Yes)
                    return;

                bool resultado =
                    _pedidoLN.Eliminar(idPedido);

                if (resultado)
                {
                    MessageBox.Show(
                        "Pedido eliminado con éxito.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo eliminar el pedido.",
                        "Eliminar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar: " +
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
            LimpiarCampos();
        }

        private void frmPedido_Load(
            object sender,
            EventArgs e)
        {
            CargarComboBoxes();
            CargarPedidos();
        }

        private void FrmPedido_Load_1(
            object sender,
            EventArgs e)
        {
        }
    }
}