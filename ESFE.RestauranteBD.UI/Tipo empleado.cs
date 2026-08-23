
using System;
using System.Drawing;
using System.Windows.Forms;
using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmTipoEmpleado : Form
    {
        private TipoEmpleadoLN tipoEmpleadoLN = new TipoEmpleadoLN();
        private string idViejo = "";

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
        // CONSTRUCTOR
        // =========================================================

        public FrmTipoEmpleado()
        {
            InitializeComponent();

            ConfigurarFormulario();
            CrearInterfaz();
            AplicarDiseno();

            Resize += FrmTipoEmpleado_Resize;
        }

        // =========================================================
        // CONFIGURACIÓN
        // =========================================================

        private void ConfigurarFormulario()
        {
            Text =
                "RESTAURANTEBD | Tipos de Empleado";

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

            // Los controles originales se colocan dentro
            // de los paneles sin modificar sus eventos.

            if (lblTitulo1 != null)
            {
                panelCabecera.Controls.Add(lblTitulo1);
            }

            if (lblTitulo != null)
            {
                panelCabecera.Controls.Add(lblTitulo);
            }

            if (lblIdTipo != null)
            {
                panelInformacion.Controls.Add(lblIdTipo);
            }

            if (lblNombre != null)
            {
                panelInformacion.Controls.Add(lblNombre);
            }

            if (txtIdTipo != null)
            {
                panelInformacion.Controls.Add(txtIdTipo);
            }

            if (txtNombre != null)
            {
                panelInformacion.Controls.Add(txtNombre);
            }

            if (btnGuardar != null)
            {
                panelAcciones.Controls.Add(btnGuardar);
            }

            if (btnModificar != null)
            {
                panelAcciones.Controls.Add(btnModificar);
            }

            if (btnEliminar != null)
            {
                panelAcciones.Controls.Add(btnEliminar);
            }

            if (btnLimpiar != null)
            {
                panelAcciones.Controls.Add(btnLimpiar);
            }

            if (dgvTipoEmpleado != null)
            {
                panelTabla.Controls.Add(dgvTipoEmpleado);
            }
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
        // DISEÑO
        // =========================================================

        private void AplicarDiseno()
        {
            // -----------------------------------------------------
            // RESTAURANTEBD
            // -----------------------------------------------------

            if (lblTitulo1 != null)
            {
                lblTitulo1.Text =
                    "✦  RESTAURANTEBD";

                lblTitulo1.ForeColor =
                    Dorado;

                lblTitulo1.BackColor =
                    Color.Transparent;

                lblTitulo1.Font =
                    new Font(
                        "Segoe UI",
                        28F,
                        FontStyle.Bold);

                lblTitulo1.AutoSize =
                    true;
            }

            // -----------------------------------------------------
            // TÍTULO
            // -----------------------------------------------------

            if (lblTitulo != null)
            {
                lblTitulo.Text =
                    "Gestión de tipos de empleado";

                lblTitulo.ForeColor =
                    Gris;

                lblTitulo.BackColor =
                    Color.Transparent;

                lblTitulo.Font =
                    new Font(
                        "Segoe UI",
                        15F,
                        FontStyle.Bold);

                lblTitulo.AutoSize =
                    true;
            }

            // -----------------------------------------------------
            // ETIQUETAS
            // -----------------------------------------------------

            if (lblIdTipo != null)
            {
                lblIdTipo.Text =
                    "ID DE TIPO";

                lblIdTipo.ForeColor =
                    Gris;

                lblIdTipo.BackColor =
                    Color.Transparent;

                lblIdTipo.Font =
                    new Font(
                        "Segoe UI",
                        10F,
                        FontStyle.Bold);

                lblIdTipo.AutoSize =
                    true;
            }

            if (lblNombre != null)
            {
                lblNombre.Text =
                    "NOMBRE";

                lblNombre.ForeColor =
                    Gris;

                lblNombre.BackColor =
                    Color.Transparent;

                lblNombre.Font =
                    new Font(
                        "Segoe UI",
                        10F,
                        FontStyle.Bold);

                lblNombre.AutoSize =
                    true;
            }

            // -----------------------------------------------------
            // TEXTBOX
            // -----------------------------------------------------

            EstilizarTextBox(txtIdTipo);
            EstilizarTextBox(txtNombre);

            // -----------------------------------------------------
            // BOTONES
            // -----------------------------------------------------

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

            // -----------------------------------------------------
            // TABLA
            // -----------------------------------------------------

            EstilizarTabla(dgvTipoEmpleado);

            DistribuirInterfaz();
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

            caja.Multiline = false;
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

        private void EstilizarTabla(DataGridView tabla)
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
        // DISTRIBUCIÓN
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

            if (lblTitulo1 != null)
            {
                lblTitulo1.Location =
                    new Point(
                        55,
                        27);
            }

            if (lblTitulo != null)
            {
                lblTitulo.Location =
                    new Point(
                        59,
                        78);
            }

            // =====================================================
            // INFORMACIÓN
            // =====================================================

            panelInformacion.Location =
                new Point(
                    margen,
                    165);

            panelInformacion.Size =
                new Size(
                    ancho -
                    margen * 2,
                    190);

            if (lblIdTipo != null)
            {
                lblIdTipo.Location =
                    new Point(
                        32,
                        25);
            }

            if (lblNombre != null)
            {
                lblNombre.Location =
                    new Point(
                        430,
                        25);
            }

            if (txtIdTipo != null)
            {
                txtIdTipo.Location =
                    new Point(
                        32,
                        62);

                txtIdTipo.Size =
                    new Size(
                        340,
                        45);
            }

            if (txtNombre != null)
            {
                txtNombre.Location =
                    new Point(
                        430,
                        62);

                txtNombre.Size =
                    new Size(
                        Math.Max(
                            400,
                            panelInformacion.Width -
                            462),
                        45);
            }

            // =====================================================
            // BOTONES
            // =====================================================

            panelAcciones.Location =
                new Point(
                    margen,
                    380);

            panelAcciones.Size =
                new Size(
                    ancho -
                    margen * 2,
                    105);

            int botonAncho = 190;
            int botonAlto = 48;
            int separacion = 28;

            int anchoTotal =
                (botonAncho * 4) +
                (separacion * 3);

            int inicio =
                (panelAcciones.Width -
                anchoTotal) / 2;

            if (inicio < 20)
                inicio = 20;

            if (btnGuardar != null)
            {
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

            if (btnModificar != null)
            {
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

                btnModificar.BringToFront();
            }

            if (btnEliminar != null)
            {
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

            if (btnLimpiar != null)
            {
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
                new Point(
                    margen,
                    510);

            panelTabla.Size =
                new Size(
                    ancho -
                    margen * 2,
                    Math.Max(
                        260,
                        alto - 540));

            if (dgvTipoEmpleado != null)
            {
                dgvTipoEmpleado.Location =
                    new Point(
                        32,
                        25);

                dgvTipoEmpleado.Size =
                    new Size(
                        panelTabla.Width - 64,
                        panelTabla.Height - 40);

                dgvTipoEmpleado.BringToFront();
            }
        }

        // =========================================================
        // RESIZE
        // =========================================================

        private void FrmTipoEmpleado_Resize(
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

        private void FrmTipoEmpleado_Load(
            object sender,
            EventArgs e)
        {
            CargarGrid();
        }

        // =========================================================
        // CARGAR GRID
        // =========================================================

        private void CargarGrid()
        {
            dgvTipoEmpleado.DataSource =
                tipoEmpleadoLN.Buscar("");
        }

        // =========================================================
        // VACIAR CAMPOS
        // =========================================================

        private void VaciarCampos()
        {
            txtIdTipo.Clear();
            txtNombre.Clear();

            dgvTipoEmpleado.ClearSelection();
            dgvTipoEmpleado.CurrentCell = null;

            idViejo =
                string.Empty;

            txtNombre.Focus();
        }

        // =========================================================
        // SELECCIONAR REGISTRO
        // =========================================================

        private void dataGridView1_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila =
                    dgvTipoEmpleado.Rows[
                        e.RowIndex];

                txtIdTipo.Text =
                    fila.Cells[0]
                    .Value?
                    .ToString()
                    .Trim();

                txtNombre.Text =
                    fila.Cells[1]
                    .Value?
                    .ToString()
                    .Trim();

                idViejo =
                    txtIdTipo.Text;
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
                TipoEmpleado tipo =
                    new TipoEmpleado
                    {
                        IdTipo =
                            txtIdTipo.Text.Trim(),

                        Nombre =
                            txtNombre.Text.Trim()
                    };

                if (tipoEmpleadoLN.Insertar(tipo))
                {
                    MessageBox.Show(
                        "Guardado con éxito.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarGrid();
                    VaciarCampos();
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
                    idViejo))
                {
                    MessageBox.Show(
                        "Seleccione un registro de la tabla.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                TipoEmpleado tipo =
                    new TipoEmpleado
                    {
                        IdTipo =
                            txtIdTipo.Text.Trim(),

                        Nombre =
                            txtNombre.Text.Trim()
                    };

                if (tipoEmpleadoLN.Actualizar(
                    tipo,
                    idViejo))
                {
                    MessageBox.Show(
                        "Modificado con éxito.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarGrid();
                    VaciarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al modificar: " +
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
                    txtIdTipo.Text))
                {
                    MessageBox.Show(
                        "Seleccione un registro de la tabla para eliminar.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (MessageBox.Show(
                    "¿Está seguro de eliminar este registro?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                    == DialogResult.Yes)
                {
                    if (tipoEmpleadoLN.Eliminar(
                        txtIdTipo.Text.Trim()))
                    {
                        MessageBox.Show(
                            "Eliminado con éxito.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        CargarGrid();
                        VaciarCampos();
                    }
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

        // =========================================================
        // LIMPIAR
        // =========================================================

        private void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            VaciarCampos();
        }
    }
}
