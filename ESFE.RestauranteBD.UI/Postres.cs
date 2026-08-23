using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using ESFE.RestauranteBD.DAL;
using ESFE.RestauranteBD.EN;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmPostres : Form
    {
        private readonly Color Fondo =
            Color.FromArgb(10, 10, 10);

        private readonly Color Panel =
            Color.FromArgb(24, 24, 24);

        private readonly Color Campo =
            Color.FromArgb(35, 35, 35);

        private readonly Color Dorado =
            Color.FromArgb(212, 175, 55);

        private readonly Color DoradoClaro =
            Color.FromArgb(235, 210, 130);

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

        private bool precioVacio = false;

        public FrmPostres()
        {
            Thread.CurrentThread.CurrentCulture =
                new CultureInfo("en-US");

            Thread.CurrentThread.CurrentUICulture =
                new CultureInfo("en-US");

            InitializeComponent();

            ConfigurarFormulario();
            ConfigurarPrecio();
            AplicarDiseno();

            Resize += FrmPostres_Resize;
        }

        private void ConfigurarFormulario()
        {
            Text =
                "RESTAURANTEBD | Postres";

            StartPosition =
                FormStartPosition.CenterScreen;

            FormBorderStyle =
                FormBorderStyle.Sizable;

            MaximizeBox = true;
            MinimizeBox = true;

            WindowState =
                FormWindowState.Maximized;

            MinimumSize =
                new Size(1200, 800);

            BackColor =
                Fondo;

            Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Regular);
        }

        private void FrmPostres_Load(
            object sender,
            EventArgs e)
        {
            CargarGrid();

            nudPrecio.Value = 0M;
            precioVacio = false;
        }

        private void ConfigurarPrecio()
        {
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Increment = 0.01M;
            nudPrecio.Minimum = 0M;
            nudPrecio.Maximum = 999.99M;
            nudPrecio.ThousandsSeparator = false;
            nudPrecio.Value = 0M;

            nudPrecio.BackColor =
                Campo;

            nudPrecio.ForeColor =
                Blanco;

            nudPrecio.BorderStyle =
                BorderStyle.FixedSingle;

            nudPrecio.Font =
                new Font(
                    "Segoe UI",
                    13F);

            nudPrecio.TextAlign =
                HorizontalAlignment.Left;

            nudPrecio.Enter +=
                nudPrecio_Enter;

            nudPrecio.KeyPress +=
                nudPrecio_KeyPress;
        }

        private TextBox ObtenerCajaPrecio()
        {
            foreach (Control control
                in nudPrecio.Controls)
            {
                if (control is TextBox)
                    return (TextBox)control;
            }

            return null;
        }

        private void nudPrecio_Enter(
            object sender,
            EventArgs e)
        {
            BeginInvoke(new Action(() =>
            {
                TextBox caja =
                    ObtenerCajaPrecio();

                if (caja == null)
                    return;

                caja.Focus();
                caja.SelectAll();

                if (nudPrecio.Value == 0M)
                {
                    precioVacio = true;
                    caja.Clear();
                }
            }));
        }

        private void nudPrecio_KeyPress(
            object sender,
            KeyPressEventArgs e)
        {
            TextBox caja =
                ObtenerCajaPrecio();

            if (caja == null)
                return;

            if (precioVacio)
            {
                if (char.IsDigit(e.KeyChar) ||
                    e.KeyChar == '.')
                {
                    caja.Clear();
                    precioVacio = false;
                }
            }

            if (e.KeyChar == ',')
            {
                e.Handled = true;

                int posicion =
                    caja.SelectionStart;

                caja.Text =
                    caja.Text.Insert(
                        posicion,
                        ".");

                caja.SelectionStart =
                    posicion + 1;
            }
        }

        private void AplicarDiseno()
        {
            lblTitulo4.Text =
                "✦  RESTAURANTEBD";

            lblTitulo4.ForeColor =
                Dorado;

            lblTitulo4.BackColor =
                Color.Transparent;

            lblTitulo4.Font =
                new Font(
                    "Segoe UI",
                    28F,
                    FontStyle.Bold);

            lblTitulo4.AutoSize = true;

            lblTituloPostres.Text =
                "Gestión de Postres";

            lblTituloPostres.ForeColor =
                Gris;

            lblTituloPostres.BackColor =
                Color.Transparent;

            lblTituloPostres.Font =
                new Font(
                    "Segoe UI",
                    15F,
                    FontStyle.Bold);

            lblTituloPostres.AutoSize = true;

            lblPostres.Text =
                "ID Postre";

            lblNombre.Text =
                "Nombre";

            lblPrecio.Text =
                "Precio";

            EstilizarEtiqueta(lblPostres);
            EstilizarEtiqueta(lblNombre);
            EstilizarEtiqueta(lblPrecio);

            EstilizarTextBox(txtIdPostre);
            EstilizarTextBox(txtNombre);
            EstilizarTextBox(txtBuscar);

            EstilizarBoton(
                btnGuardar,
                Dorado,
                Color.Black);

            EstilizarBoton(
                btnModificar,
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

            EstilizarBoton(
                btnBuscar,
                Dorado,
                Color.Black);

            EstilizarTabla(dgvPostres);

            DistribuirInterfaz();
        }

        private void EstilizarEtiqueta(
            Label etiqueta)
        {
            etiqueta.ForeColor =
                Gris;

            etiqueta.BackColor =
                Color.Transparent;

            etiqueta.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);
        }

        private void EstilizarTextBox(
            TextBox caja)
        {
            caja.BackColor =
                Campo;

            caja.ForeColor =
                Blanco;

            caja.BorderStyle =
                BorderStyle.FixedSingle;

            caja.Font =
                new Font(
                    "Segoe UI",
                    13F);

            caja.Multiline = false;
        }

        private void EstilizarBoton(
            Button boton,
            Color fondo,
            Color texto)
        {
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
                    11F,
                    FontStyle.Bold);

            boton.Cursor =
                Cursors.Hand;

            boton.UseVisualStyleBackColor =
                false;
        }

        private void EstilizarTabla(
            DataGridView tabla)
        {
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
                    BackColor =
                        DoradoClaro,

                    ForeColor =
                        Color.Black,

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
                    BackColor =
                        Panel,

                    ForeColor =
                        Blanco,

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

            tabla.ColumnHeadersHeight = 50;
            tabla.RowTemplate.Height = 46;

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

        private void DistribuirInterfaz()
        {
            int ancho =
                ClientSize.Width;

            int alto =
                ClientSize.Height;

            int margen = 70;
            int espacio = 35;

            // Título

            lblTitulo4.Location =
                new Point(
                    margen,
                    30);

            // Subtítulo en la esquina derecha

            lblTituloPostres.Location =
                new Point(
                    ancho -
                    margen -
                    lblTituloPostres.PreferredWidth,
                    45);

            // Búsqueda

            int yBusqueda = 125;

            txtBuscar.Location =
                new Point(
                    margen,
                    yBusqueda);

            txtBuscar.Size =
                new Size(
                    ancho -
                    margen * 2 -
                    220,
                    48);

            btnBuscar.Location =
                new Point(
                    ancho -
                    margen -
                    190,
                    yBusqueda);

            btnBuscar.Size =
                new Size(
                    190,
                    48);

            btnBuscar.Text =
                "Buscar";

            // Tres campos iguales

            int anchoDisponible =
                ancho -
                (margen * 2) -
                (espacio * 2);

            int anchoCampo =
                anchoDisponible / 3;

            int yEtiqueta = 230;
            int yCampo = 265;

            // ID Postre

            lblPostres.Location =
                new Point(
                    margen,
                    yEtiqueta);

            txtIdPostre.Location =
                new Point(
                    margen,
                    yCampo);

            txtIdPostre.Size =
                new Size(
                    anchoCampo,
                    48);

            // Nombre

            lblNombre.Location =
                new Point(
                    margen +
                    anchoCampo +
                    espacio,
                    yEtiqueta);

            txtNombre.Location =
                new Point(
                    margen +
                    anchoCampo +
                    espacio,
                    yCampo);

            txtNombre.Size =
                new Size(
                    anchoCampo,
                    48);

            // Precio

            lblPrecio.Location =
                new Point(
                    margen +
                    ((anchoCampo +
                    espacio) * 2),
                    yEtiqueta);

            nudPrecio.Location =
                new Point(
                    margen +
                    ((anchoCampo +
                    espacio) * 2),
                    yCampo);

            nudPrecio.Size =
                new Size(
                    anchoCampo,
                    48);

            // Botones

            int botonAncho = 190;
            int botonAlto = 50;
            int separacion = 45;

            int anchoTotal =
                (botonAncho * 4) +
                (separacion * 3);

            int inicio =
                (ancho - anchoTotal) / 2;

            if (inicio < margen)
                inicio = margen;

            int yBotones = 370;

            btnGuardar.Location =
                new Point(
                    inicio,
                    yBotones);

            btnGuardar.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            btnModificar.Location =
                new Point(
                    inicio +
                    botonAncho +
                    separacion,
                    yBotones);

            btnModificar.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            btnEliminar.Location =
                new Point(
                    inicio +
                    ((botonAncho +
                    separacion) * 2),
                    yBotones);

            btnEliminar.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            btnLimpiar.Location =
                new Point(
                    inicio +
                    ((botonAncho +
                    separacion) * 3),
                    yBotones);

            btnLimpiar.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            // Tabla

            dgvPostres.Location =
                new Point(
                    margen,
                    470);

            dgvPostres.Size =
                new Size(
                    ancho -
                    (margen * 2),
                    Math.Max(
                        300,
                        alto - 520));
        }

        private void FrmPostres_Resize(
            object sender,
            EventArgs e)
        {
            if (WindowState !=
                FormWindowState.Minimized)
            {
                DistribuirInterfaz();
            }
        }

        private void CargarGrid()
        {
            try
            {
                PostreDAL postreDAL =
                    new PostreDAL();

                dgvPostres.DataSource =
                    postreDAL.Buscar("");

                dgvPostres.ClearSelection();
                dgvPostres.CurrentCell = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar la lista de postres:\n\n" +
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
            try
            {
                PostreDAL postreDAL =
                    new PostreDAL();

                dgvPostres.DataSource =
                    postreDAL.Buscar(
                        txtBuscar.Text.Trim());

                dgvPostres.ClearSelection();
                dgvPostres.CurrentCell = null;
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

        private void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    txtIdPostre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el ID del postre.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtIdPostre.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(
                    txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre del postre.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return;
                }

                Postre postre =
                    new Postre
                    {
                        IdPostre =
                            txtIdPostre.Text.Trim(),

                        Nombre =
                            txtNombre.Text.Trim(),

                        Precio =
                            nudPrecio.Value
                    };

                PostreDAL postreDAL =
                    new PostreDAL();

                bool resultado =
                    postreDAL.Insertar(postre);

                if (resultado)
                {
                    MessageBox.Show(
                        "Postre guardado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarGrid();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo guardar el postre.",
                        "Atención",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error de SQL:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    txtIdPostre.Text))
                {
                    MessageBox.Show(
                        "Seleccione un postre de la tabla para modificar.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Postre postre =
                    new Postre
                    {
                        IdPostre =
                            txtIdPostre.Text.Trim(),

                        Nombre =
                            txtNombre.Text.Trim(),

                        Precio =
                            nudPrecio.Value
                    };

                PostreDAL postreDAL =
                    new PostreDAL();

                bool resultado =
                    postreDAL.Actualizar(postre);

                if (resultado)
                {
                    MessageBox.Show(
                        "Registro actualizado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarGrid();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "Error al intentar actualizar el registro.",
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

        private void btnEliminar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    txtIdPostre.Text))
                {
                    MessageBox.Show(
                        "Seleccione un registro de la tabla para eliminar.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult confirmacion =
                    MessageBox.Show(
                        "¿Está seguro de eliminar este postre?",
                        "Confirmar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (confirmacion ==
                    DialogResult.Yes)
                {
                    PostreDAL postreDAL =
                        new PostreDAL();

                    bool resultado =
                        postreDAL.Eliminar(
                            txtIdPostre.Text.Trim());

                    if (resultado)
                    {
                        MessageBox.Show(
                            "Registro eliminado correctamente.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        CargarGrid();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Error al intentar eliminar el registro.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
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

        private void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtIdPostre.Clear();
            txtNombre.Clear();
            txtBuscar.Clear();

            nudPrecio.Value = 0M;
            precioVacio = false;

            dgvPostres.ClearSelection();
            dgvPostres.CurrentCell = null;

            CargarGrid();

            txtIdPostre.Focus();
        }

        private void dgvPostres_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila =
                dgvPostres.Rows[e.RowIndex];

            txtIdPostre.Text =
                fila.Cells["IdPostre"]
                .Value?
                .ToString();

            txtNombre.Text =
                fila.Cells["Nombre"]
                .Value?
                .ToString();

            if (fila.Cells["Precio"].Value != null)
            {
                decimal precio;

                if (decimal.TryParse(
                    fila.Cells["Precio"]
                    .Value
                    .ToString(),
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out precio))
                {
                    if (precio >= nudPrecio.Minimum &&
                        precio <= nudPrecio.Maximum)
                    {
                        nudPrecio.Value =
                            precio;

                        precioVacio = false;
                    }
                }
            }
        }

        private void numericUpDown1_ValueChanged(
            object sender,
            EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(
            object sender,
            EventArgs e)
        {
        }
    }
}