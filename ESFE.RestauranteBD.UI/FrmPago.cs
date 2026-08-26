using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmPago : Form
    {
        private PagoLN pagoLN = new PagoLN();

        // ============================================================
        // COLORES
        // ============================================================

        private readonly Color Fondo =
            Color.FromArgb(10, 10, 10);

        private readonly Color Panel =
            Color.FromArgb(24, 24, 24);

        private readonly Color Caja =
            Color.FromArgb(35, 35, 35);

        private readonly Color Dorado =
            Color.FromArgb(218, 177, 45);

        private readonly Color Blanco =
            Color.FromArgb(245, 245, 245);

        private readonly Color Gris =
            Color.FromArgb(185, 185, 185);

        private readonly Color Rojo =
            Color.FromArgb(155, 45, 45);

        private readonly Color Verde =
            Color.FromArgb(55, 115, 90);

        // ============================================================
        // PANELES
        // ============================================================

        private Panel panelTitulo;
        private Panel panelDatos;
        private Panel panelBotones;
        private Panel panelTabla;

        private Label lblTitulo;
        private Label lblTituloDatos;
        private Label lblTituloTabla;

        // ============================================================
        // CONSTRUCTOR
        // ============================================================

        public FrmPago()
        {
            InitializeComponent();

            dgvPago.CellClick -= dgvPago_CellClick;
            dgvPago.CellContentClick -= dgvPago_CellClick;

            dgvPago.CellClick += dgvPago_CellClick;
        }

        // ============================================================
        // LOAD
        // ============================================================

        private void FrmPago_Load(
            object sender,
            EventArgs e)
        {
            ConfigurarFormulario();
            CrearDiseno();
            ConfigurarDataGridView();

            ConfigurarFecha();

            CargarPagos();
        }

        // ============================================================
        // FORMULARIO
        // ============================================================

        private void ConfigurarFormulario()
        {
            Text = "RESTAURANTEBD | Pagos";

            WindowState =
                FormWindowState.Maximized;

            StartPosition =
                FormStartPosition.CenterScreen;

            BackColor = Fondo;
            ForeColor = Blanco;

            MinimumSize =
                new Size(1150, 700);
        }

        // ============================================================
        // CREAR DISEÑO
        // ============================================================

        private void CrearDiseno()
        {
            CrearPanelTitulo();
            CrearPanelDatos();
            CrearPanelBotones();
            CrearPanelTabla();

            DistribuirCampos();
            ConfigurarBotones();

            panelTitulo.BringToFront();
            panelDatos.BringToFront();
            panelBotones.BringToFront();
            panelTabla.BringToFront();

            dgvPago.BringToFront();
        }

        // ============================================================
        // PANEL TITULO
        // ============================================================

        private void CrearPanelTitulo()
        {
            panelTitulo = new Panel();

            panelTitulo.BackColor = Panel;

            panelTitulo.Location =
                new Point(0, 0);

            panelTitulo.Size =
                new Size(
                    ClientSize.Width,
                    110);

            panelTitulo.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            lblTitulo = new Label();

            lblTitulo.Text =
                "✦  RESTAURANTEBD";

            lblTitulo.ForeColor =
                Dorado;

            lblTitulo.Font =
                new Font(
                    "Segoe UI",
                    28F,
                    FontStyle.Bold);

            lblTitulo.AutoSize = true;

            lblTitulo.Location =
                new Point(45, 27);

            panelTitulo.Controls.Add(
                lblTitulo);

            Controls.Add(panelTitulo);
        }

        // ============================================================
        // PANEL DATOS
        // ============================================================

        private void CrearPanelDatos()
        {
            panelDatos = new Panel();

            panelDatos.BackColor =
                Panel;

            panelDatos.Location =
                new Point(40, 130);

            panelDatos.Size =
                new Size(
                    ClientSize.Width - 80,
                    240);

            panelDatos.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            lblTituloDatos =
                new Label();

            lblTituloDatos.Text =
                "INFORMACIÓN DEL PAGO";

            lblTituloDatos.ForeColor =
                Dorado;

            lblTituloDatos.Font =
                new Font(
                    "Segoe UI",
                    15F,
                    FontStyle.Bold);

            lblTituloDatos.AutoSize = true;

            lblTituloDatos.Location =
                new Point(25, 18);

            panelDatos.Controls.Add(
                lblTituloDatos);

            Controls.Add(panelDatos);

            grbMetodo.Visible = false;

            txtIdPago.Parent =
                panelDatos;

            txtIdPedido.Parent =
                panelDatos;

            txtIdMetodoPago.Parent =
                panelDatos;

            nudMonto.Parent =
                panelDatos;

            dtpFechaPago.Parent =
                panelDatos;

            lblIdPago.Parent =
                panelDatos;

            lblIdPedido.Parent =
                panelDatos;

            lblIdMetodo.Parent =
                panelDatos;

            lblTotal.Parent =
                panelDatos;

            lblFechaDePago.Parent =
                panelDatos;
        }

        // ============================================================
        // DISTRIBUIR CAMPOS
        // ============================================================

        private void DistribuirCampos()
        {
            int margen = 25;
            int separacion = 18;

            int anchoDisponible =
                panelDatos.Width -
                (margen * 2) -
                (separacion * 4);

            int ancho =
                anchoDisponible / 5;

            int yLabel = 65;
            int yCaja = 100;

            // ID PAGO
            PrepararLabel(
                lblIdPago,
                "ID DE PAGO");

            PrepararTextBox(
                txtIdPago);

            lblIdPago.Location =
                new Point(
                    margen,
                    yLabel);

            txtIdPago.Location =
                new Point(
                    margen,
                    yCaja);

            txtIdPago.Size =
                new Size(
                    ancho,
                    42);

            // ID PEDIDO
            int x2 =
                margen +
                ancho +
                separacion;

            PrepararLabel(
                lblIdPedido,
                "ID DE PEDIDO");

            PrepararTextBox(
                txtIdPedido);

            lblIdPedido.Location =
                new Point(
                    x2,
                    yLabel);

            txtIdPedido.Location =
                new Point(
                    x2,
                    yCaja);

            txtIdPedido.Size =
                new Size(
                    ancho,
                    42);

            // METODO
            int x3 =
                margen +
                ((ancho + separacion) * 2);

            PrepararLabel(
                lblIdMetodo,
                "MÉTODO DE PAGO");

            PrepararTextBox(
                txtIdMetodoPago);

            lblIdMetodo.Location =
                new Point(
                    x3,
                    yLabel);

            txtIdMetodoPago.Location =
                new Point(
                    x3,
                    yCaja);

            txtIdMetodoPago.Size =
                new Size(
                    ancho,
                    42);

            // TOTAL
            int x4 =
                margen +
                ((ancho + separacion) * 3);

            PrepararLabel(
                lblTotal,
                "TOTAL");

            lblTotal.Location =
                new Point(
                    x4,
                    yLabel);

            nudMonto.Location =
                new Point(
                    x4,
                    yCaja);

            nudMonto.Size =
                new Size(
                    ancho,
                    42);

            nudMonto.DecimalPlaces = 2;
            nudMonto.Minimum = 0;
            nudMonto.Maximum = 999999;

            nudMonto.BackColor =
                Caja;

            nudMonto.ForeColor =
                Blanco;

            nudMonto.Font =
                new Font(
                    "Segoe UI",
                    12F);

            // FECHA
            int x5 =
                margen +
                ((ancho + separacion) * 4);

            PrepararLabel(
                lblFechaDePago,
                "FECHA DE PAGO");

            lblFechaDePago.Location =
                new Point(
                    x5,
                    yLabel);

            dtpFechaPago.Location =
                new Point(
                    x5,
                    yCaja);

            dtpFechaPago.Size =
                new Size(
                    ancho,
                    42);

            dtpFechaPago.Font =
                new Font(
                    "Segoe UI",
                    11F);

            dtpFechaPago.ShowCheckBox = true;
        }

        // ============================================================
        // LABEL
        // ============================================================

        private void PrepararLabel(
            Label label,
            string texto)
        {
            if (label == null)
                return;

            label.Text = texto;

            label.ForeColor =
                Gris;

            label.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            label.AutoSize = true;

            label.BackColor =
                Color.Transparent;
        }

        // ============================================================
        // TEXTBOX
        // ============================================================

        private void PrepararTextBox(
            TextBox textbox)
        {
            if (textbox == null)
                return;

            textbox.BackColor =
                Caja;

            textbox.ForeColor =
                Blanco;

            textbox.BorderStyle =
                BorderStyle.FixedSingle;

            textbox.Font =
                new Font(
                    "Segoe UI",
                    12F);
        }

        // ============================================================
        // PANEL BOTONES
        // ============================================================

        private void CrearPanelBotones()
        {
            panelBotones =
                new Panel();

            panelBotones.BackColor =
                Panel;

            panelBotones.Location =
                new Point(
                    40,
                    390);

            panelBotones.Size =
                new Size(
                    ClientSize.Width - 80,
                    85);

            panelBotones.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Left |
                AnchorStyles.Right;

            Controls.Add(panelBotones);
        }

        // ============================================================
        // BOTONES
        // ============================================================

        private void ConfigurarBotones()
        {
            int espacio = 20;

            int margen = 50;

            int ancho =
                (panelBotones.Width -
                (margen * 2) -
                (espacio * 3)) / 4;

            int alto = 48;

            btnBuscar.Parent =
                panelBotones;

            btnAgregar.Parent =
                panelBotones;

            btnEliminar.Parent =
                panelBotones;

            btnLimpiar.Parent =
                panelBotones;

            PrepararBoton(
                btnBuscar,
                "Buscar",
                Dorado);

            PrepararBoton(
                btnAgregar,
                "Agregar",
                Dorado);

            PrepararBoton(
                btnEliminar,
                "Eliminar",
                Rojo);

            PrepararBoton(
                btnLimpiar,
                "Limpiar",
                Verde);

            btnBuscar.Size =
                new Size(
                    ancho,
                    alto);

            btnAgregar.Size =
                new Size(
                    ancho,
                    alto);

            btnEliminar.Size =
                new Size(
                    ancho,
                    alto);

            btnLimpiar.Size =
                new Size(
                    ancho,
                    alto);

            btnBuscar.Location =
                new Point(
                    margen,
                    18);

            btnAgregar.Location =
                new Point(
                    margen +
                    ancho +
                    espacio,
                    18);

            btnEliminar.Location =
                new Point(
                    margen +
                    ((ancho + espacio) * 2),
                    18);

            btnLimpiar.Location =
                new Point(
                    margen +
                    ((ancho + espacio) * 3),
                    18);
        }

        private void PrepararBoton(
            Button boton,
            string texto,
            Color color)
        {
            if (boton == null)
                return;

            boton.Text = texto;

            boton.BackColor =
                color;

            boton.ForeColor =
                Color.White;

            boton.FlatStyle =
                FlatStyle.Flat;

            boton.FlatAppearance.BorderSize =
                0;

            boton.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            boton.Cursor =
                Cursors.Hand;

            boton.UseVisualStyleBackColor =
                false;
        }

        // ============================================================
        // PANEL TABLA
        // ============================================================

        private void CrearPanelTabla()
        {
            panelTabla =
                new Panel();

            panelTabla.BackColor =
                Panel;

            panelTabla.Location =
                new Point(
                    40,
                    495);

            panelTabla.Size =
                new Size(
                    ClientSize.Width - 80,
                    ClientSize.Height - 535);

            panelTabla.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            lblTituloTabla =
                new Label();

            lblTituloTabla.Text =
                "PAGOS REGISTRADOS";

            lblTituloTabla.ForeColor =
                Dorado;

            lblTituloTabla.Font =
                new Font(
                    "Segoe UI",
                    15F,
                    FontStyle.Bold);

            lblTituloTabla.AutoSize = true;

            lblTituloTabla.Location =
                new Point(
                    20,
                    15);

            panelTabla.Controls.Add(
                lblTituloTabla);

            Controls.Add(panelTabla);

            dgvPago.Parent =
                panelTabla;

            dgvPago.Location =
                new Point(
                    20,
                    55);

            dgvPago.Size =
                new Size(
                    panelTabla.ClientSize.Width - 40,
                    panelTabla.ClientSize.Height - 70);

            dgvPago.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;
        }

        // ============================================================
        // DATAGRIDVIEW
        // ============================================================

        private void ConfigurarDataGridView()
        {
            if (dgvPago == null)
                return;

            dgvPago.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvPago.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvPago.MultiSelect = false;

            dgvPago.AllowUserToAddRows = false;

            dgvPago.AllowUserToDeleteRows = false;

            dgvPago.ReadOnly = true;

            dgvPago.RowHeadersVisible = false;

            dgvPago.BackgroundColor =
                Panel;

            dgvPago.BorderStyle =
                BorderStyle.None;

            dgvPago.GridColor =
                Color.FromArgb(
                    55,
                    55,
                    55);

            dgvPago.EnableHeadersVisualStyles =
                false;

            dgvPago.ColumnHeadersDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = Dorado,
                    ForeColor = Color.Black,
                    Font =
                        new Font(
                            "Segoe UI",
                            11F,
                            FontStyle.Bold),
                    Alignment =
                        DataGridViewContentAlignment.MiddleCenter
                };

            dgvPago.ColumnHeadersHeight =
                45;

            dgvPago.DefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = Panel,
                    ForeColor = Blanco,
                    Font =
                        new Font(
                            "Segoe UI",
                            10F),
                    Alignment =
                        DataGridViewContentAlignment.MiddleCenter,
                    SelectionBackColor =
                        Color.FromArgb(
                            80,
                            68,
                            30),
                    SelectionForeColor =
                        Blanco
                };

            dgvPago.AlternatingRowsDefaultCellStyle =
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

            dgvPago.RowTemplate.Height =
                40;
        }

        // ============================================================
        // FECHA
        // ============================================================

        private void ConfigurarFecha()
        {
            dtpFechaPago.Format =
                DateTimePickerFormat.Custom;

            dtpFechaPago.CustomFormat =
                " ";

            dtpFechaPago.ShowCheckBox = true;
        }

        private void dtpFechaPago_ValueChanged(
            object sender,
            EventArgs e)
        {
            dtpFechaPago.Format =
                DateTimePickerFormat.Short;
        }

        // ============================================================
        // CARGAR PAGOS
        // ============================================================

        private void CargarPagos()
        {
            try
            {
                Pago pago =
                    new Pago
                    {
                        IdPago = "",
                        IdPedido = "",
                        IdMetodo = ""
                    };

                List<Pago> lista =
                    pagoLN.Buscar(pago);

                dgvPago.DataSource = null;

                dgvPago.DataSource =
                    lista;

                dgvPago.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los pagos.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // BUSCAR
        // ============================================================

        private void btnBuscar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                Pago pago =
                    new Pago
                    {
                        IdPago =
                            txtIdPago.Text.Trim(),

                        IdPedido =
                            txtIdPedido.Text.Trim(),

                        IdMetodo =
                            txtIdMetodoPago.Text.Trim()
                    };

                List<Pago> resultados =
                    pagoLN.Buscar(pago);

                dgvPago.DataSource = null;

                dgvPago.DataSource =
                    resultados;

                if (resultados.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron pagos.",
                        "Búsqueda",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
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

        // ============================================================
        // AGREGAR
        // ============================================================

        private void btnAgregar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    txtIdPago.Text) ||
                    string.IsNullOrWhiteSpace(
                    txtIdPedido.Text) ||
                    string.IsNullOrWhiteSpace(
                    txtIdMetodoPago.Text))
                {
                    MessageBox.Show(
                        "Completa los campos requeridos.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Pago pago =
                    new Pago
                    {
                        IdPago =
                            txtIdPago.Text.Trim(),

                        total =
                            nudMonto.Value,

                        fechaPago =
                            dtpFechaPago.Value,

                        IdPedido =
                            txtIdPedido.Text.Trim(),

                        IdMetodo =
                            txtIdMetodoPago.Text.Trim()
                    };

                int resultado =
                    pagoLN.Agregar(pago);

                if (resultado > 0)
                {
                    MessageBox.Show(
                        "Pago guardado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarCampos();
                    CargarPagos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo registrar el pago.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al agregar pago:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // ELIMINAR
        // ============================================================

        private void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                string idPago =
                    txtIdPago.Text.Trim();

                if (string.IsNullOrWhiteSpace(idPago))
                {
                    MessageBox.Show(
                        "Selecciona o escribe un ID de pago.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult respuesta =
                    MessageBox.Show(
                        "¿Deseas eliminar el pago " +
                        idPago +
                        "?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (respuesta != DialogResult.Yes)
                    return;

                int resultado =
                    pagoLN.Eliminar(idPago);

                if (resultado > 0)
                {
                    MessageBox.Show(
                        "Pago eliminado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarCampos();
                    CargarPagos();
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró el pago.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
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

        // ============================================================
        // LIMPIAR
        // ============================================================

        private void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            LimpiarCampos();
            CargarPagos();
        }

        private void LimpiarCampos()
        {
            txtIdPago.Clear();
            txtIdPedido.Clear();
            txtIdMetodoPago.Clear();

            nudMonto.Value = 0;

            dtpFechaPago.Format =
                DateTimePickerFormat.Custom;

            dtpFechaPago.CustomFormat =
                " ";

            dgvPago.ClearSelection();

            txtIdPago.Focus();
        }

        // ============================================================
        // CELL CLICK
        // ============================================================

        private void dgvPago_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                if (dgvPago.Rows[e.RowIndex]
                    .DataBoundItem is Pago pago)
                {
                    txtIdPago.Text =
                        pago.IdPago ?? "";

                    txtIdPedido.Text =
                        pago.IdPedido ?? "";

                    txtIdMetodoPago.Text =
                        pago.IdMetodo ?? "";

                    decimal monto =
                        pago.total;

                    if (monto < nudMonto.Minimum)
                        monto = nudMonto.Minimum;

                    if (monto > nudMonto.Maximum)
                        monto = nudMonto.Maximum;

                    nudMonto.Value =
                        monto;

                    dtpFechaPago.Value =
                        pago.fechaPago;

                    dtpFechaPago.Format =
                        DateTimePickerFormat.Short;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los datos de la fila.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ============================================================
        // EVENTOS DEL DISEÑADOR
        // ============================================================

        private void label4_Click(
            object sender,
            EventArgs e)
        {
        }

        private void label1_Click(
            object sender,
            EventArgs e)
        {
        }

        private void grbMetodo_Enter(
            object sender,
            EventArgs e)
        {
        }
    }
}