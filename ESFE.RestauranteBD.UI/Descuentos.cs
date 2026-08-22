using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmDescuentos : Form
    {
        private readonly DescuentosLN descuentosLN;

        private string idAnterior = "";

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

        private Label lblIdDescuento;
        private Label lblNombre;
        private Label lblPorcentaje;

        public FrmDescuentos()
        {
            InitializeComponent();

            descuentosLN = new DescuentosLN();

            ConfigurarFormulario();
            PrepararControles();
            CrearInterfaz();
            AplicarDiseno();
            CargarDescuentos();

            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
            txtBuscar.KeyDown += txtBuscar_KeyDown;

            txtBuscar.Text = "Buscar descuentos";
            txtBuscar.ForeColor = Gris;

            Resize += FrmDescuentos_Resize;
        }

        private void ConfigurarFormulario()
        {
            Text = "RESTAURANTEBD | Descuentos";

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

        private T ObtenerControl<T>(string nombre)
            where T : Control
        {
            return Controls
                .Find(nombre, true)
                .FirstOrDefault() as T;
        }

        private Button ObtenerBotonModificar()
        {
            Button btnModificar =
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
                "Gestión de descuentos",
                15F,
                Gris,
                true);

            lblBusqueda = CrearEtiqueta(
                "BUSCAR DESCUENTO",
                13F,
                Dorado,
                true);

            lblInformacion = CrearEtiqueta(
                "INFORMACIÓN DEL DESCUENTO",
                13F,
                Dorado,
                true);

            lblRegistros = CrearEtiqueta(
                "DESCUENTOS REGISTRADOS",
                13F,
                Dorado,
                true);

            lblIdDescuento = CrearEtiqueta(
                "ID DE DESCUENTO",
                10F,
                Gris,
                true);

            lblNombre = CrearEtiqueta(
                "NOMBRE",
                10F,
                Gris,
                true);

            lblPorcentaje = CrearEtiqueta(
                "PORCENTAJE",
                10F,
                Gris,
                true);

            panelCabecera.Controls.Add(lblTitulo);
            panelCabecera.Controls.Add(lblSubtitulo);

            panelBusqueda.Controls.Add(lblBusqueda);

            panelInformacion.Controls.Add(lblInformacion);
            panelInformacion.Controls.Add(lblIdDescuento);
            panelInformacion.Controls.Add(lblNombre);
            panelInformacion.Controls.Add(lblPorcentaje);

            panelTabla.Controls.Add(lblRegistros);
        }

        private void AgregarControles()
        {
            TextBox txtBuscar =
                ObtenerControl<TextBox>("txtBuscar");

            Button btnBuscar =
                ObtenerControl<Button>("btnBuscar");

            TextBox txtIdDescuento =
                ObtenerControl<TextBox>("txtIdDescuento");

            TextBox txtNombre =
                ObtenerControl<TextBox>("txtNombre");

            NumericUpDown numPorcentaje =
                ObtenerControl<NumericUpDown>("numPorcentaje");

            Button btnGuardar =
                ObtenerControl<Button>("btnGuardar");

            Button btnModificar =
                ObtenerBotonModificar();

            Button btnEliminar =
                ObtenerControl<Button>("btnEliminar");

            Button btnLimpiar =
                ObtenerControl<Button>("btnLimpiar");

            DataGridView dgv =
                ObtenerControl<DataGridView>("dgvDescuentos");

            if (txtBuscar != null)
                panelBusqueda.Controls.Add(txtBuscar);

            if (btnBuscar != null)
                panelBusqueda.Controls.Add(btnBuscar);

            if (txtIdDescuento != null)
                panelInformacion.Controls.Add(txtIdDescuento);

            if (txtNombre != null)
                panelInformacion.Controls.Add(txtNombre);

            if (numPorcentaje != null)
                panelInformacion.Controls.Add(numPorcentaje);

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

        private void DistribuirInterfaz()
        {
            int ancho = ClientSize.Width;
            int alto = ClientSize.Height;

            int margen = 60;

            panelCabecera.Location =
                new Point(0, 0);

            panelCabecera.Size =
                new Size(ancho, 135);

            lblTitulo.Location =
                new Point(55, 27);

            lblSubtitulo.Location =
                new Point(59, 78);

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

            lblIdDescuento.Location =
                new Point(x1, 70);

            lblNombre.Location =
                new Point(x2, 70);

            lblPorcentaje.Location =
                new Point(x3, 70);

            TextBox txtIdDescuento =
                ObtenerControl<TextBox>("txtIdDescuento");

            TextBox txtNombre =
                ObtenerControl<TextBox>("txtNombre");

            NumericUpDown numPorcentaje =
                ObtenerControl<NumericUpDown>("numPorcentaje");

            if (txtIdDescuento != null)
            {
                txtIdDescuento.Location =
                    new Point(x1, 103);

                txtIdDescuento.Size =
                    new Size(campoAncho, 43);
            }

            if (txtNombre != null)
            {
                txtNombre.Location =
                    new Point(x2, 103);

                txtNombre.Size =
                    new Size(campoAncho, 43);
            }

            if (numPorcentaje != null)
            {
                numPorcentaje.Location =
                    new Point(x3, 103);

                numPorcentaje.Size =
                    new Size(campoAncho, 43);
            }

            panelAcciones.Location =
                new Point(margen, 550);

            panelAcciones.Size =
                new Size(
                    ancho - margen * 2,
                    105);

            Button btnGuardar =
                ObtenerControl<Button>("btnGuardar");

            Button btnModificar =
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

                btnGuardar.BringToFront();
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

                btnModificar.BringToFront();
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

                btnEliminar.BringToFront();
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

                btnLimpiar.BringToFront();
            }

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
                ObtenerControl<DataGridView>(
                    "dgvDescuentos");

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

        private void FrmDescuentos_Resize(
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
            EstilizarTextBox(
                ObtenerControl<TextBox>("txtBuscar"));

            EstilizarTextBox(
                ObtenerControl<TextBox>("txtIdDescuento"));

            EstilizarTextBox(
                ObtenerControl<TextBox>("txtNombre"));

            NumericUpDown numPorcentaje =
                ObtenerControl<NumericUpDown>("numPorcentaje");

            if (numPorcentaje != null)
            {
                numPorcentaje.BackColor = Campo;
                numPorcentaje.ForeColor = Blanco;

                numPorcentaje.Font =
                    new Font(
                        "Segoe UI",
                        12F,
                        FontStyle.Regular);
            }

            EstilizarBoton(
                ObtenerControl<Button>("btnBuscar"),
                Dorado,
                Color.Black);

            EstilizarBoton(
                ObtenerControl<Button>("btnGuardar"),
                Dorado,
                Color.Black);

            EstilizarBoton(
                ObtenerBotonModificar(),
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
                    "dgvDescuentos"));
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
                    Font = new Font(
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
                    Font = new Font(
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

        private void CargarDescuentos()
        {
            try
            {
                List<Descuentos> lista =
                    descuentosLN.Buscar("");

                dgvDescuentos.DataSource = null;
                dgvDescuentos.DataSource = lista;
                dgvDescuentos.Refresh();

                dgvDescuentos.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los descuentos:\n\n" +
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
                    txtIdDescuento.Text))
                {
                    MessageBox.Show(
                        "Ingrese el ID del descuento.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtIdDescuento.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(
                    txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre del descuento.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return;
                }

                if (numPorcentaje.Value <= 0)
                {
                    MessageBox.Show(
                        "El porcentaje debe ser mayor que 0.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    numPorcentaje.Focus();
                    return;
                }

                Descuentos descuento =
                    new Descuentos
                    {
                        IdDescuento =
                            txtIdDescuento.Text.Trim(),

                        Nombre =
                            txtNombre.Text.Trim(),

                        Porcentaje =
                            numPorcentaje.Value
                    };

                bool resultado =
                    descuentosLN.Insertar(
                        descuento);

                if (resultado)
                {
                    MessageBox.Show(
                        "Descuento guardado correctamente.",
                        "Guardar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarDescuentos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo guardar el descuento.",
                        "Guardar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el descuento:\n\n" +
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
                if (string.IsNullOrWhiteSpace(idAnterior))
                {
                    MessageBox.Show(
                        "Seleccione un descuento de la tabla antes de modificar.",
                        "Modificar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (string.IsNullOrWhiteSpace(
                    txtIdDescuento.Text))
                {
                    MessageBox.Show(
                        "Ingrese el ID del descuento.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtIdDescuento.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(
                    txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre del descuento.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return;
                }

                if (numPorcentaje.Value <= 0)
                {
                    MessageBox.Show(
                        "El porcentaje debe ser mayor que 0.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    numPorcentaje.Focus();
                    return;
                }

                Descuentos descuento =
                    new Descuentos
                    {
                        IdDescuento =
                            txtIdDescuento.Text.Trim(),

                        Nombre =
                            txtNombre.Text.Trim(),

                        Porcentaje =
                            numPorcentaje.Value
                    };

                bool resultado =
                    descuentosLN.Actualizar(
                        descuento,
                        idAnterior);

                if (resultado)
                {
                    MessageBox.Show(
                        "Descuento modificado correctamente.",
                        "Modificar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarDescuentos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo modificar el descuento.",
                        "Modificar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al modificar el descuento:\n\n" +
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
                    txtIdDescuento.Text))
                {
                    MessageBox.Show(
                        "Seleccione un descuento para eliminar.",
                        "Eliminar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string idEliminar =
                    txtIdDescuento.Text.Trim();

                DialogResult respuesta =
                    MessageBox.Show(
                        "¿Está seguro de eliminar el descuento?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    bool resultado =
                        descuentosLN.Eliminar(
                            idEliminar);

                    if (resultado)
                    {
                        MessageBox.Show(
                            "Descuento eliminado correctamente.",
                            "Eliminar",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        CargarDescuentos();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se pudo eliminar el descuento.",
                            "Eliminar",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el descuento:\n\n" +
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
            txtIdDescuento.Clear();
            txtNombre.Clear();

            numPorcentaje.Value =
                numPorcentaje.Minimum;

            idAnterior = "";

            txtIdDescuento.Focus();
        }

        private void dgvDescuentos_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow fila =
                    dgvDescuentos.Rows[e.RowIndex];

                txtIdDescuento.Text =
                    fila.Cells["IdDescuento"]
                    .Value?.ToString() ?? "";

                txtNombre.Text =
                    fila.Cells["Nombre"]
                    .Value?.ToString() ?? "";

                if (fila.Cells["Porcentaje"].Value != null)
                {
                    numPorcentaje.Value =
                        Convert.ToDecimal(
                            fila.Cells["Porcentaje"]
                            .Value);
                }

                idAnterior =
                    txtIdDescuento.Text.Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al seleccionar el descuento:\n\n" +
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
                string texto =
                    txtBuscar.Text.Trim();

                if (texto == "Buscar descuentos")
                {
                    texto = "";
                }

                List<Descuentos> lista =
                    descuentosLN.BuscarPorNombre(
                        texto);

                dgvDescuentos.DataSource = null;
                dgvDescuentos.DataSource = lista;
                dgvDescuentos.Refresh();

                txtBuscar.Text =
                    "Buscar descuentos";

                txtBuscar.ForeColor =
                    Gris;

                if (lista.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron descuentos.",
                        "Búsqueda",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar el descuento:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtBuscar_Enter(
            object sender,
            EventArgs e)
        {
            if (txtBuscar.Text ==
                "Buscar descuentos")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor =
                    Blanco;
            }
        }

        private void txtBuscar_Leave(
            object sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(
                txtBuscar.Text))
            {
                txtBuscar.Text =
                    "Buscar descuentos";

                txtBuscar.ForeColor =
                    Gris;
            }
        }

        private void txtBuscar_KeyDown(
            object sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(
                    sender,
                    e);

                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void FrmDescuentos_Load(
            object sender,
            EventArgs e)
        {
            AplicarDiseno();
            DistribuirInterfaz();
            CargarDescuentos();
        }
    }
}