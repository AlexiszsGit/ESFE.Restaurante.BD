using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;

namespace ESFE.RestauranteBD.UI
{
    public partial class frmMetodoDePago : Form
    {
        private readonly MetodoPagoLN metodoPagoLN = new MetodoPagoLN();

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
        private Panel panelInformacion;
        private Panel panelAcciones;
        private Panel panelTabla;

        private Label lblEncabezado;
        private Label lblInformacion;
        private Label lblRegistros;

        public frmMetodoDePago()
        {
            InitializeComponent();

            ConfigurarFormulario();
            CrearInterfaz();
            AplicarDiseno();

            Resize += frmMetodoDePago_Resize;

            CargarMetodos();
        }

        private void ConfigurarFormulario()
        {
            Text = "RESTAURANTEBD | Métodos de Pago";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.Sizable;

            MaximizeBox = true;
            MinimizeBox = true;

            WindowState = FormWindowState.Maximized;
            MinimumSize = new Size(1150, 700);

            BackColor = Fondo;
            Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        }

        private T ObtenerControl<T>(string nombre) where T : Control
        {
            return Controls.Find(nombre, true).FirstOrDefault() as T;
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
                    negrita ? FontStyle.Bold : FontStyle.Regular)
            };
        }

        private void CrearTitulos()
        {
            lblEncabezado = CrearEtiqueta(
                "✦  RESTAURANTEBD",
                28F,
                Dorado,
                true);

            lblInformacion = CrearEtiqueta(
                "INFORMACIÓN DEL MÉTODO DE PAGO",
                13F,
                Dorado,
                true);

            lblRegistros = CrearEtiqueta(
                "MÉTODOS DE PAGO REGISTRADOS",
                13F,
                Dorado,
                true);

            lblTitulo.Text = "Gestión de métodos de pago";
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.ForeColor = Gris;
            lblTitulo.Font = new Font(
                "Segoe UI",
                15F,
                FontStyle.Bold);

            panelCabecera.Controls.Add(lblEncabezado);
            panelCabecera.Controls.Add(lblTitulo);

            panelInformacion.Controls.Add(lblInformacion);
            panelTabla.Controls.Add(lblRegistros);
        }

        private void AgregarControles()
        {
            panelInformacion.Controls.Add(lblNombe);
            panelInformacion.Controls.Add(txbNombre);

            panelInformacion.Controls.Add(lblIdMetodo);
            panelInformacion.Controls.Add(txtDescricion);

            panelAcciones.Controls.Add(btnBuscar);
            panelAcciones.Controls.Add(btnAgregar);
            panelAcciones.Controls.Add(btnModificar1);
            panelAcciones.Controls.Add(btnEliminar);
            panelAcciones.Controls.Add(btnLimpiar);

            panelTabla.Controls.Add(dgvMetodosDePago);

            grp.Visible = false;
        }

        private void DistribuirInterfaz()
        {
            int ancho = ClientSize.Width;
            int alto = ClientSize.Height;

            int margen = 60;

            panelCabecera.Location = new Point(0, 0);
            panelCabecera.Size = new Size(ancho, 135);

            lblEncabezado.Location = new Point(55, 27);
            lblTitulo.Location = new Point(59, 78);

            panelInformacion.Location = new Point(margen, 165);
            panelInformacion.Size = new Size(
                ancho - margen * 2,
                180);

            lblInformacion.Location = new Point(32, 22);

            int espacio = (panelInformacion.Width - 64) / 2;
            int campoAncho = espacio - 32;

            int x1 = 32;
            int x2 = x1 + espacio;

            lblNombe.Location = new Point(x1, 70);
            lblIdMetodo.Location = new Point(x2, 70);

            txbNombre.Location = new Point(x1, 103);
            txbNombre.Size = new Size(campoAncho, 43);

            txtDescricion.Location = new Point(x2, 103);
            txtDescricion.Size = new Size(campoAncho, 43);

            panelAcciones.Location = new Point(margen, 365);
            panelAcciones.Size = new Size(
                ancho - margen * 2,
                105);

            int botonAncho = 170;
            int botonAlto = 48;
            int separacion = 22;

            int anchoTotal =
                (botonAncho * 5) +
                (separacion * 4);

            int inicio =
                (panelAcciones.Width - anchoTotal) / 2;

            btnBuscar.Location =
                new Point(inicio, 27);

            btnBuscar.Size =
                new Size(botonAncho, botonAlto);

            btnAgregar.Location =
                new Point(
                    inicio + (botonAncho + separacion),
                    27);

            btnAgregar.Size =
                new Size(botonAncho, botonAlto);

            btnModificar1.Location =
                new Point(
                    inicio + ((botonAncho + separacion) * 2),
                    27);

            btnModificar1.Size =
                new Size(botonAncho, botonAlto);

            btnEliminar.Location =
                new Point(
                    inicio + ((botonAncho + separacion) * 3),
                    27);

            btnEliminar.Size =
                new Size(botonAncho, botonAlto);

            btnLimpiar.Location =
                new Point(
                    inicio + ((botonAncho + separacion) * 4),
                    27);

            btnLimpiar.Size =
                new Size(botonAncho, botonAlto);

            panelTabla.Location =
                new Point(margen, 500);

            panelTabla.Size =
                new Size(
                    ancho - margen * 2,
                    Math.Max(260, alto - 530));

            lblRegistros.Location =
                new Point(32, 22);

            dgvMetodosDePago.Location =
                new Point(32, 62);

            dgvMetodosDePago.Size =
                new Size(
                    panelTabla.Width - 64,
                    panelTabla.Height - 82);
        }

        private void frmMetodoDePago_Resize(
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
            EstilizarTextBox(txbNombre);
            EstilizarTextBox(txtDescricion);

            EstilizarEtiquetaCampo(
                lblNombe,
                "NOMBRE");

            EstilizarEtiquetaCampo(
                lblIdMetodo,
                "ID DE MÉTODO DE PAGO");

            EstilizarBoton(
                btnBuscar,
                Dorado,
                Color.Black);

            EstilizarBoton(
                btnAgregar,
                Dorado,
                Color.Black);

            EstilizarBoton(
                btnModificar1,
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

            EstilizarTabla(dgvMetodosDePago);
        }

        private void EstilizarEtiquetaCampo(
            Label etiqueta,
            string texto)
        {
            if (etiqueta == null)
                return;

            etiqueta.Text = texto;
            etiqueta.AutoSize = true;
            etiqueta.BackColor = Color.Transparent;
            etiqueta.ForeColor = Gris;
            etiqueta.Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Bold);
        }

        private void EstilizarTextBox(TextBox caja)
        {
            if (caja == null)
                return;

            caja.BackColor = Campo;
            caja.ForeColor = Blanco;
            caja.BorderStyle = BorderStyle.FixedSingle;
            caja.Font = new Font(
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
            boton.FlatStyle = FlatStyle.Flat;
            boton.FlatAppearance.BorderSize = 0;
            boton.Font = new Font(
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
                    Font = new Font(
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
                    Font = new Font(
                        "Segoe UI",
                        11F),
                    SelectionBackColor =
                        Color.FromArgb(80, 68, 30),
                    SelectionForeColor = Blanco,
                    Alignment =
                        DataGridViewContentAlignment.MiddleCenter
                };

            tabla.AlternatingRowsDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor =
                        Color.FromArgb(20, 20, 20),
                    ForeColor = Blanco,
                    SelectionBackColor =
                        Color.FromArgb(80, 68, 30),
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

        private void CargarMetodos()
        {
            try
            {
                MetodoDePago filtro =
                    new MetodoDePago
                    {
                        IdMetodoDePago = "",
                        Nombre = ""
                    };

                List<MetodoDePago> lista =
                    metodoPagoLN.Buscar(filtro);

                dgvMetodosDePago.DataSource = null;
                dgvMetodosDePago.DataSource = lista;

                dgvMetodosDePago.ClearSelection();
                dgvMetodosDePago.Refresh();
                dgvMetodosDePago.Update();

                idAnterior = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los métodos de pago:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SeleccionarMetodo(int filaIndex)
        {
            if (filaIndex < 0 ||
                filaIndex >= dgvMetodosDePago.Rows.Count)
            {
                return;
            }

            try
            {
                DataGridViewRow fila =
                    dgvMetodosDePago.Rows[filaIndex];

                object valorId =
                    fila.Cells["IdMetodoDePago"].Value;

                object valorNombre =
                    fila.Cells["Nombre"].Value;

                if (valorId == null ||
                    valorId == DBNull.Value)
                {
                    return;
                }

                idAnterior =
                    valorId.ToString().Trim();

                txtDescricion.Text =
                    idAnterior;

                txbNombre.Text =
                    valorNombre == null ||
                    valorNombre == DBNull.Value
                        ? ""
                        : valorNombre.ToString().Trim();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al seleccionar el registro:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void dgvMetodosDePago_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            SeleccionarMetodo(e.RowIndex);
        }

        private void dgvMetodosDePago_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            SeleccionarMetodo(e.RowIndex);
        }

        private void LimpiarCampos()
        {
            txtDescricion.Clear();
            txbNombre.Clear();

            idAnterior = "";

            dgvMetodosDePago.ClearSelection();

            txtDescricion.Focus();
        }

        private void btnBuscar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                MetodoDePago metodo =
                    new MetodoDePago
                    {
                        IdMetodoDePago =
                            txtDescricion.Text.Trim(),

                        Nombre =
                            txbNombre.Text.Trim()
                    };

                List<MetodoDePago> lista =
                    metodoPagoLN.Buscar(metodo);

                dgvMetodosDePago.DataSource = null;
                dgvMetodosDePago.DataSource = lista;

                dgvMetodosDePago.Refresh();
                dgvMetodosDePago.Update();
                dgvMetodosDePago.ClearSelection();

                idAnterior = "";
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

        private void btnAgregar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                string id =
                    txtDescricion.Text.Trim();

                string nombre =
                    txbNombre.Text.Trim();

                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show(
                        "Ingresa el ID del método de pago.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtDescricion.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show(
                        "Ingresa el nombre del método de pago.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txbNombre.Focus();
                    return;
                }

                MetodoDePago metodo =
                    new MetodoDePago
                    {
                        IdMetodoDePago = id,
                        Nombre = nombre
                    };

                int resultado =
                    metodoPagoLN.Agregar(metodo);

                if (resultado > 0)
                {
                    CargarMetodos();
                    LimpiarCampos();

                    MessageBox.Show(
                        "Método de pago registrado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo agregar el método de pago.",
                        "Agregar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al agregar:\n\n" +
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
                        "Selecciona primero un método de pago de la tabla.",
                        "Modificar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                string idNuevo =
                    txtDescricion.Text.Trim();

                string nombreNuevo =
                    txbNombre.Text.Trim();

                if (string.IsNullOrWhiteSpace(idNuevo))
                {
                    MessageBox.Show(
                        "Ingresa el ID del método de pago.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtDescricion.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(nombreNuevo))
                {
                    MessageBox.Show(
                        "Ingresa el nombre del método de pago.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txbNombre.Focus();
                    return;
                }

                MetodoDePago metodo =
                    new MetodoDePago
                    {
                        IdMetodoDePago = idNuevo,
                        Nombre = nombreNuevo
                    };

                int resultado =
                    metodoPagoLN.Modificar(
                        metodo,
                        idAnterior);

                if (resultado > 0)
                {
                    CargarMetodos();
                    LimpiarCampos();

                    MessageBox.Show(
                        "Método de pago modificado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró el registro para modificar.",
                        "Modificar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
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
                string id =
                    txtDescricion.Text.Trim();

                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show(
                        "Selecciona un método de pago de la tabla.",
                        "Validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult confirmacion =
                    MessageBox.Show(
                        "¿Deseas eliminar el registro " +
                        id +
                        "?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (confirmacion != DialogResult.Yes)
                    return;

                int resultado =
                    metodoPagoLN.Eliminar(id);

                if (resultado > 0)
                {
                    CargarMetodos();
                    LimpiarCampos();

                    MessageBox.Show(
                        "Registro eliminado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo eliminar el registro.",
                        "Eliminar",
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

        private void btnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            LimpiarCampos();
        }

        private void grp_Enter(
            object sender,
            EventArgs e)
        {
        }

        private void frmMetodoDePago_Load(
            object sender,
            EventArgs e)
        {
            CargarMetodos();
        }
    }
}