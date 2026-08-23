using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmCategoria : Form
    {
        private readonly CategoriaLN categoriaLN;

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
        // ETIQUETAS
        // =========================================================

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblInformacion;
        private Label lblRegistros;

        private Label lblIdCategoria;
        private Label lblNombre;

        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public FrmCategoria()
        {
            InitializeComponent();

            categoriaLN = new CategoriaLN();

            ConfigurarFormulario();
            PrepararControles();
            CrearInterfaz();
            AplicarDiseno();
            CargarCategorias();

            Resize += FrmCategoria_Resize;
        }

        // =========================================================
        // CONFIGURACIÓN
        // =========================================================

        private void ConfigurarFormulario()
        {
            Text = "RESTAURANTEBD | Categorías";

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
        // BUSCAR CONTROLES
        // =========================================================

        private T ObtenerControl<T>(string nombre)
            where T : Control
        {
            return Controls
                .Find(nombre, true)
                .FirstOrDefault() as T;
        }

        // =========================================================
        // OBTENER BOTÓN MODIFICAR
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
        // ETIQUETAS
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
                    "Gestión de categorías",
                    15F,
                    Gris,
                    true);

            lblInformacion =
                CrearEtiqueta(
                    "INFORMACIÓN DE LA CATEGORÍA",
                    13F,
                    Dorado,
                    true);

            lblRegistros =
                CrearEtiqueta(
                    "CATEGORÍAS REGISTRADAS",
                    13F,
                    Dorado,
                    true);

            lblIdCategoria =
                CrearEtiqueta(
                    "ID DE CATEGORÍA",
                    10F,
                    Gris,
                    true);

            lblNombre =
                CrearEtiqueta(
                    "NOMBRE",
                    10F,
                    Gris,
                    true);

            panelCabecera.Controls.Add(lblTitulo);
            panelCabecera.Controls.Add(lblSubtitulo);

            panelInformacion.Controls.Add(lblInformacion);
            panelInformacion.Controls.Add(lblIdCategoria);
            panelInformacion.Controls.Add(lblNombre);

            panelTabla.Controls.Add(lblRegistros);
        }

        // =========================================================
        // AGREGAR CONTROLES ORIGINALES
        // =========================================================

        private void AgregarControles()
        {
            TextBox txtIdCategoria =
                ObtenerControl<TextBox>(
                    "txtIdCategoria");

            TextBox txtNombre =
                ObtenerControl<TextBox>(
                    "txtNombre");

            Button btnGuardar =
                ObtenerControl<Button>(
                    "btnGuardar");

            Button btmModificar =
                ObtenerBotonModificar();

            Button btnEliminar =
                ObtenerControl<Button>(
                    "btnEliminar");

            Button btnLimpiar =
                ObtenerControl<Button>(
                    "btnLimpiar");

            DataGridView dgvCategoria =
                ObtenerControl<DataGridView>(
                    "dgvCategoria");

            if (txtIdCategoria != null)
            {
                txtIdCategoria.Visible = true;
                panelInformacion.Controls.Add(
                    txtIdCategoria);
            }

            if (txtNombre != null)
            {
                txtNombre.Visible = true;
                panelInformacion.Controls.Add(
                    txtNombre);
            }

            if (btnGuardar != null)
            {
                btnGuardar.Visible = true;
                panelAcciones.Controls.Add(
                    btnGuardar);
            }

            if (btmModificar != null)
            {
                btmModificar.Visible = true;
                panelAcciones.Controls.Add(
                    btmModificar);
            }

            if (btnEliminar != null)
            {
                btnEliminar.Visible = true;
                panelAcciones.Controls.Add(
                    btnEliminar);
            }

            if (btnLimpiar != null)
            {
                btnLimpiar.Visible = true;
                panelAcciones.Controls.Add(
                    btnLimpiar);
            }

            if (dgvCategoria != null)
            {
                dgvCategoria.Visible = true;
                panelTabla.Controls.Add(
                    dgvCategoria);
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
                new Size(
                    ancho,
                    135);

            lblTitulo.Location =
                new Point(55, 27);

            lblSubtitulo.Location =
                new Point(59, 78);

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
                    210);

            lblInformacion.Location =
                new Point(32, 22);

            int espacio =
                (panelInformacion.Width - 64) / 2;

            int campoAncho =
                espacio - 32;

            int x1 = 32;
            int x2 = x1 + espacio;

            lblIdCategoria.Location =
                new Point(
                    x1,
                    70);

            lblNombre.Location =
                new Point(
                    x2,
                    70);

            TextBox txtIdCategoria =
                ObtenerControl<TextBox>(
                    "txtIdCategoria");

            TextBox txtNombre =
                ObtenerControl<TextBox>(
                    "txtNombre");

            if (txtIdCategoria != null)
            {
                txtIdCategoria.Location =
                    new Point(
                        x1,
                        103);

                txtIdCategoria.Size =
                    new Size(
                        campoAncho,
                        43);
            }

            if (txtNombre != null)
            {
                txtNombre.Location =
                    new Point(
                        x2,
                        103);

                txtNombre.Size =
                    new Size(
                        campoAncho,
                        43);
            }

            // =====================================================
            // BOTONES
            // =====================================================

            panelAcciones.Location =
                new Point(
                    margen,
                    400);

            panelAcciones.Size =
                new Size(
                    ancho - margen * 2,
                    105);

            Button btnGuardar =
                ObtenerControl<Button>(
                    "btnGuardar");

            Button btmModificar =
                ObtenerBotonModificar();

            Button btnEliminar =
                ObtenerControl<Button>(
                    "btnEliminar");

            Button btnLimpiar =
                ObtenerControl<Button>(
                    "btnLimpiar");

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
                new Point(
                    margen,
                    535);

            panelTabla.Size =
                new Size(
                    ancho - margen * 2,
                    Math.Max(
                        260,
                        alto - 565));

            lblRegistros.Location =
                new Point(
                    32,
                    22);

            DataGridView dgvCategoria =
                ObtenerControl<DataGridView>(
                    "dgvCategoria");

            if (dgvCategoria != null)
            {
                dgvCategoria.Location =
                    new Point(
                        32,
                        62);

                dgvCategoria.Size =
                    new Size(
                        panelTabla.Width - 64,
                        panelTabla.Height - 82);

                dgvCategoria.BringToFront();
            }
        }

        private void FrmCategoria_Resize(
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
                    "txtIdCategoria"));

            EstilizarTextBox(
                ObtenerControl<TextBox>(
                    "txtNombre"));

            Button btnGuardar =
                ObtenerControl<Button>(
                    "btnGuardar");

            Button btmModificar =
                ObtenerBotonModificar();

            Button btnEliminar =
                ObtenerControl<Button>(
                    "btnEliminar");

            Button btnLimpiar =
                ObtenerControl<Button>(
                    "btnLimpiar");

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
                ObtenerControl<DataGridView>(
                    "dgvCategoria"));
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

                    ForeColor = Blanco,

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

            tabla.Visible = true;
        }

        // =========================================================
        // CARGAR CATEGORÍAS
        // =========================================================

        private void CargarCategorias()
        {
            try
            {
                List<ESFE.RestauranteBD.EN.Categoria> lista =
                    categoriaLN.Buscar("");

                DataGridView dgvCategoria =
                    ObtenerControl<DataGridView>(
                        "dgvCategoria");

                if (dgvCategoria != null)
                {
                    dgvCategoria.DataSource = null;
                    dgvCategoria.DataSource = lista;
                    dgvCategoria.Refresh();
                    dgvCategoria.ClearSelection();
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
        // GUARDAR
        // =========================================================

        private void btnGuardar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    txtIdCategoria.Text))
                {
                    MessageBox.Show(
                        "Ingrese el ID de la categoría.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtIdCategoria.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(
                    txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre de la categoría.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return;
                }

                ESFE.RestauranteBD.EN.Categoria categoria =
                    new ESFE.RestauranteBD.EN.Categoria
                    {
                        IdCategoria =
                            txtIdCategoria.Text.Trim(),

                        Nombre =
                            txtNombre.Text.Trim()
                    };

                bool resultado =
                    categoriaLN.Insertar(categoria);

                if (resultado)
                {
                    MessageBox.Show(
                        "Categoría guardada correctamente.",
                        "Guardar categoría",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarCategorias();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo guardar la categoría.",
                        "Guardar categoría",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar la categoría:\n\n" +
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
                    txtIdCategoria.Text))
                {
                    MessageBox.Show(
                        "Seleccione una categoría.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (string.IsNullOrWhiteSpace(
                    txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre de la categoría.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtNombre.Focus();
                    return;
                }

                ESFE.RestauranteBD.EN.Categoria categoria =
                    new ESFE.RestauranteBD.EN.Categoria
                    {
                        IdCategoria =
                            txtIdCategoria.Text.Trim(),

                        Nombre =
                            txtNombre.Text.Trim()
                    };

                bool resultado =
                    categoriaLN.Actualizar(categoria);

                if (resultado)
                {
                    MessageBox.Show(
                        "Categoría actualizada correctamente.",
                        "Modificar categoría",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarCategorias();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo actualizar la categoría.",
                        "Modificar categoría",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al modificar la categoría:\n\n" +
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
                    txtIdCategoria.Text))
                {
                    MessageBox.Show(
                        "Seleccione una categoría.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult respuesta =
                    MessageBox.Show(
                        "¿Está seguro de eliminar la categoría?",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (respuesta ==
                    DialogResult.Yes)
                {
                    bool resultado =
                        categoriaLN.Eliminar(
                            txtIdCategoria.Text.Trim());

                    if (resultado)
                    {
                        MessageBox.Show(
                            "Categoría eliminada correctamente.",
                            "Eliminar categoría",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        LimpiarCampos();
                        CargarCategorias();
                    }
                    else
                    {
                        MessageBox.Show(
                            "No se pudo eliminar la categoría.",
                            "Eliminar categoría",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar la categoría:\n\n" +
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
            txtIdCategoria.Clear();
            txtNombre.Clear();

            txtIdCategoria.Focus();
        }

        // =========================================================
        // SELECCIONAR CATEGORÍA
        // =========================================================

        private void dgvCategoria_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                    return;

                DataGridViewRow fila =
                    dgvCategoria.Rows[e.RowIndex];

                txtIdCategoria.Text =
                    fila.Cells["IdCategoria"]
                        .Value?
                        .ToString() ?? "";

                txtNombre.Text =
                    fila.Cells["Nombre"]
                        .Value?
                        .ToString() ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al seleccionar la categoría:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // LOAD
        // =========================================================

        private void Categoria_Load(
            object sender,
            EventArgs e)
        {
            AplicarDiseno();
            DistribuirInterfaz();
            CargarCategorias();
        }

        // =========================================================
        // EVENTOS DEL DISEÑADOR
        // =========================================================

        private void txtIdCategoria_TextChanged(
            object sender,
            EventArgs e)
        {
        }

        private void label2_Click(
            object sender,
            EventArgs e)
        {
        }
    }
}