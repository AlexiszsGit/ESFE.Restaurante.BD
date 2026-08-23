
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmEmpleado : Form
    {
        string idViejo = "";

        private EmpleadoLN empleadoLN = new EmpleadoLN();
        private TipoEmpleadoLN tipoEmpleadoLN = new TipoEmpleadoLN();

        private string idEmpleadoSeleccionado = "";

        // =========================================================
        // COLORES
        // =========================================================

        private readonly Color Fondo =
            Color.FromArgb(12, 12, 12);

        private readonly Color Panel =
            Color.FromArgb(24, 24, 24);

        private readonly Color Campo =
            Color.FromArgb(35, 35, 35);

        private readonly Color Dorado =
            Color.FromArgb(212, 175, 55);

        private readonly Color Blanco =
            Color.FromArgb(245, 245, 245);

        private readonly Color Gris =
            Color.FromArgb(190, 190, 190);

        private readonly Color Borde =
            Color.FromArgb(65, 65, 65);

        private readonly Color Azul =
            Color.FromArgb(45, 90, 125);

        private readonly Color Rojo =
            Color.FromArgb(155, 45, 45);

        private readonly Color Verde =
            Color.FromArgb(55, 105, 85);

        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public FrmEmpleado()
        {
            InitializeComponent();

            ConfigurarFormulario();
            AplicarDiseno();

            Resize += FrmEmpleado_Resize;
        }

        // =========================================================
        // CONFIGURAR FORMULARIO
        // =========================================================

        private void ConfigurarFormulario()
        {
            Text = "RESTAURANTEBD | Empleados";

            StartPosition =
                FormStartPosition.CenterScreen;

            FormBorderStyle =
                FormBorderStyle.Sizable;

            MaximizeBox = true;
            MinimizeBox = true;

            BackColor = Fondo;

            Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Regular);

            MinimumSize =
                new Size(1200, 800);
        }

        // =========================================================
        // DISEÑO GENERAL
        // =========================================================

        private void AplicarDiseno()
        {
            // =====================================================
            // TÍTULO PRINCIPAL
            // =====================================================

            lblTitulo2.Text =
                "RESTAURANTEBD";

            lblTitulo2.AutoSize = true;

            lblTitulo2.BackColor =
                Color.Transparent;

            lblTitulo2.ForeColor =
                Dorado;

            lblTitulo2.Font =
                new Font(
                    "Segoe UI",
                    27F,
                    FontStyle.Bold);

            // =====================================================
            // LABEL ID EMPLEADO
            // =====================================================

            lblIdEmpleado.Text =
                "ID Empleado";

            lblIdEmpleado.AutoSize = true;

            lblIdEmpleado.BackColor =
                Color.Transparent;

            lblIdEmpleado.ForeColor =
                Gris;

            lblIdEmpleado.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            // =====================================================
            // LABEL NOMBRE
            // =====================================================

            lblNombre.Text =
                "Nombre";

            lblNombre.AutoSize = true;

            lblNombre.BackColor =
                Color.Transparent;

            lblNombre.ForeColor =
                Gris;

            lblNombre.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            // =====================================================
            // LABEL TIPO EMPLEADO
            // =====================================================

            lblTipoEmpleado.Text =
                "Tipo de Empleado";

            lblTipoEmpleado.AutoSize = true;

            lblTipoEmpleado.BackColor =
                Color.Transparent;

            lblTipoEmpleado.ForeColor =
                Gris;

            lblTipoEmpleado.Font =
                new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

            // =====================================================
            // TEXTBOX ID
            // =====================================================

            EstilizarTextBox(txtIdEmpleado);

            // =====================================================
            // TEXTBOX NOMBRE
            // =====================================================

            EstilizarTextBox(txtNombre);

            // =====================================================
            // COMBOBOX
            // =====================================================

            EstilizarComboBox(cmbTipoEmpleado);

            // =====================================================
            // BOTONES
            // =====================================================

            EstilizarBoton(
                btnGuardar,
                Dorado,
                Color.Black);

            EstilizarBoton(
                btnModificar,
                Azul,
                Blanco);

            EstilizarBoton(
                btnEliminar,
                Rojo,
                Blanco);

            EstilizarBoton(
                btnLimpiar,
                Verde,
                Blanco);

            // =====================================================
            // TABLA
            // =====================================================

            EstilizarGrid(dgvEmpleados);

            // =====================================================
            // DISTRIBUCIÓN
            // =====================================================

            DistribuirControles();
        }

        // =========================================================
        // TEXTBOX
        // =========================================================

        private void EstilizarTextBox(
            TextBox control)
        {
            control.BackColor =
                Campo;

            control.ForeColor =
                Blanco;

            control.BorderStyle =
                BorderStyle.FixedSingle;

            control.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Regular);
        }

        // =========================================================
        // COMBOBOX
        // =========================================================

        private void EstilizarComboBox(
            ComboBox control)
        {
            control.BackColor =
                Campo;

            control.ForeColor =
                Blanco;

            control.FlatStyle =
                FlatStyle.Flat;

            control.Font =
                new Font(
                    "Segoe UI",
                    12F,
                    FontStyle.Regular);

            control.DropDownStyle =
                ComboBoxStyle.DropDownList;
        }

        // =========================================================
        // BOTONES
        // =========================================================

        private void EstilizarBoton(
            Button control,
            Color fondo,
            Color texto)
        {
            control.BackColor =
                fondo;

            control.ForeColor =
                texto;

            control.FlatStyle =
                FlatStyle.Flat;

            control.FlatAppearance.BorderSize =
                0;

            control.Font =
                new Font(
                    "Segoe UI Semibold",
                    11F,
                    FontStyle.Bold);

            control.UseVisualStyleBackColor =
                false;

            control.Cursor =
                Cursors.Hand;
        }

        // =========================================================
        // DATAGRIDVIEW
        // =========================================================

        private void EstilizarGrid(
            DataGridView grid)
        {
            grid.BackgroundColor =
                Panel;

            grid.BorderStyle =
                BorderStyle.None;

            grid.EnableHeadersVisualStyles =
                false;

            grid.GridColor =
                Borde;

            grid.RowHeadersVisible =
                false;

            grid.ReadOnly =
                true;

            grid.AllowUserToAddRows =
                false;

            grid.AllowUserToDeleteRows =
                false;

            grid.AllowUserToResizeRows =
                false;

            grid.MultiSelect =
                false;

            grid.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            grid.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            grid.ColumnHeadersHeight =
                52;

            grid.RowTemplate.Height =
                46;

            // =====================================================
            // ENCABEZADO COMPLETAMENTE AMARILLO
            // =====================================================

            grid.ColumnHeadersDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = Dorado,
                    ForeColor = Color.Black,
                    Font = new Font(
                        "Segoe UI Semibold",
                        11F,
                        FontStyle.Bold),
                    Alignment =
                        DataGridViewContentAlignment.MiddleCenter,
                    SelectionBackColor = Dorado,
                    SelectionForeColor = Color.Black
                };

            // =====================================================
            // CELDAS
            // =====================================================

            grid.DefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = Panel,
                    ForeColor = Blanco,
                    Font = new Font(
                        "Segoe UI",
                        10.5F,
                        FontStyle.Regular),
                    SelectionBackColor =
                        Color.FromArgb(
                            80,
                            68,
                            30),
                    SelectionForeColor =
                        Blanco,
                    Alignment =
                        DataGridViewContentAlignment.MiddleCenter
                };

            // =====================================================
            // FILAS ALTERNADAS
            // =====================================================

            grid.AlternatingRowsDefaultCellStyle =
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
                        Blanco,

                    Alignment =
                        DataGridViewContentAlignment.MiddleCenter
                };
        }

        // =========================================================
        // DISTRIBUIR CONTROLES
        // =========================================================

        private void DistribuirControles()
        {
            int ancho =
                ClientSize.Width;

            int alto =
                ClientSize.Height;

            int margen =
                80;

            // =====================================================
            // TÍTULO
            // =====================================================

            lblTitulo2.Location =
                new Point(
                    margen,
                    35);

            // =====================================================
            // CAMPOS
            // =====================================================

            int anchoDisponible =
                ancho -
                (margen * 2);

            int separacion =
                45;

            int anchoCampo =
                (anchoDisponible -
                (separacion * 2)) / 3;

            int yLabel =
                145;

            int yCampo =
                180;

            // =====================================================
            // LABEL ID EMPLEADO
            // =====================================================

            lblIdEmpleado.Location =
                new Point(
                    margen,
                    yLabel);

            // =====================================================
            // LABEL NOMBRE
            // =====================================================

            lblNombre.Location =
                new Point(
                    margen +
                    anchoCampo +
                    separacion,
                    yLabel);

            // =====================================================
            // LABEL TIPO EMPLEADO
            // =====================================================

            lblTipoEmpleado.Location =
                new Point(
                    margen +
                    ((anchoCampo +
                    separacion) * 2),
                    yLabel);

            // =====================================================
            // TEXTBOX ID
            // =====================================================

            txtIdEmpleado.Location =
                new Point(
                    margen,
                    yCampo);

            txtIdEmpleado.Size =
                new Size(
                    anchoCampo,
                    45);

            // =====================================================
            // TEXTBOX NOMBRE
            // =====================================================

            txtNombre.Location =
                new Point(
                    margen +
                    anchoCampo +
                    separacion,
                    yCampo);

            txtNombre.Size =
                new Size(
                    anchoCampo,
                    45);

            // =====================================================
            // COMBOBOX TIPO
            // =====================================================

            cmbTipoEmpleado.Location =
                new Point(
                    margen +
                    ((anchoCampo +
                    separacion) * 2),
                    yCampo);

            cmbTipoEmpleado.Size =
                new Size(
                    anchoCampo,
                    45);

            // =====================================================
            // BOTONES
            // =====================================================

            int botonAncho =
                185;

            int botonAlto =
                52;

            int espacioBotones =
                40;

            int anchoTotalBotones =
                (botonAncho * 4) +
                (espacioBotones * 3);

            int inicioBotones =
                (ancho -
                anchoTotalBotones) / 2;

            int yBotones =
                280;

            // =====================================================
            // GUARDAR
            // =====================================================

            btnGuardar.Location =
                new Point(
                    inicioBotones,
                    yBotones);

            btnGuardar.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            btnGuardar.Text =
                "Guardar";

            // =====================================================
            // MODIFICAR
            // =====================================================

            btnModificar.Location =
                new Point(
                    inicioBotones +
                    botonAncho +
                    espacioBotones,
                    yBotones);

            btnModificar.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            btnModificar.Text =
                "Modificar";

            // =====================================================
            // ELIMINAR
            // =====================================================

            btnEliminar.Location =
                new Point(
                    inicioBotones +
                    ((botonAncho +
                    espacioBotones) * 2),
                    yBotones);

            btnEliminar.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            btnEliminar.Text =
                "Eliminar";

            // =====================================================
            // LIMPIAR
            // =====================================================

            btnLimpiar.Location =
                new Point(
                    inicioBotones +
                    ((botonAncho +
                    espacioBotones) * 3),
                    yBotones);

            btnLimpiar.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            btnLimpiar.Text =
                "Limpiar";

            // =====================================================
            // DATAGRIDVIEW
            // =====================================================

            int yGrid =
                385;

            dgvEmpleados.Location =
                new Point(
                    margen,
                    yGrid);

            dgvEmpleados.Size =
                new Size(
                    ancho -
                    (margen * 2),
                    Math.Max(
                        300,
                        alto -
                        yGrid -
                        60));
        }

        // =========================================================
        // REDIMENSIONAR
        // =========================================================

        private void FrmEmpleado_Resize(
            object sender,
            EventArgs e)
        {
            if (WindowState !=
                FormWindowState.Minimized)
            {
                DistribuirControles();
            }
        }

        // =========================================================
        // LOAD
        // =========================================================

        private void FrmEmpleado_Load(
            object sender,
            EventArgs e)
        {
            CargarTiposEmpleado();
            CargarGrid();
        }

        private void FrmEmpleado_Load_1(
            object sender,
            EventArgs e)
        {
            CargarTiposEmpleado();
            CargarGrid();
        }

        // =========================================================
        // CARGAR TIPOS DE EMPLEADO
        // =========================================================

        private void CargarTiposEmpleado()
        {
            try
            {
                List<TipoEmpleado> lista =
                    tipoEmpleadoLN.Buscar("");

                cmbTipoEmpleado.DataSource =
                    null;

                cmbTipoEmpleado.DisplayMember =
                    "Nombre";

                cmbTipoEmpleado.ValueMember =
                    "IdTipo";

                cmbTipoEmpleado.DataSource =
                    lista;

                cmbTipoEmpleado.SelectedIndex =
                    -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los tipos de empleado:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // CARGAR GRID
        // =========================================================

        private void CargarGrid()
        {
            dgvEmpleados.DataSource =
                null;

            dgvEmpleados.DataSource =
                empleadoLN.Buscar("");

            dgvEmpleados.Refresh();
        }

        // =========================================================
        // LIMPIAR FORMULARIO
        // =========================================================

        private void LimpiarFormulario()
        {
            txtNombre.Clear();

            cmbTipoEmpleado.SelectedIndex =
                -1;

            idEmpleadoSeleccionado =
                "";

            txtNombre.Focus();
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
                    txtNombre.Text))
                {
                    MessageBox.Show(
                        "Ingrese el nombre del empleado.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (cmbTipoEmpleado.SelectedIndex ==
                    -1)
                {
                    MessageBox.Show(
                        "Seleccione un tipo de empleado.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbTipoEmpleado.Focus();

                    return;
                }

                Empleado emp =
                    new Empleado();

                emp.IdEmpleado =
                    txtIdEmpleado.Text.Trim();

                emp.Nombre =
                    txtNombre.Text.Trim();

                emp.IdTipo =
                    cmbTipoEmpleado.SelectedValue?
                    .ToString()
                    .Trim();

                empleadoLN.Insertar(emp);

                CargarGrid();

                LimpiarFormulario();

                MessageBox.Show(
                    "Empleado guardado correctamente.",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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
                    txtIdEmpleado.Text))
                {
                    MessageBox.Show(
                        "Seleccione un empleado de la tabla para modificar.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (cmbTipoEmpleado.SelectedIndex ==
                    -1)
                {
                    MessageBox.Show(
                        "Seleccione un tipo de empleado.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbTipoEmpleado.Focus();

                    return;
                }

                Empleado emp =
                    new Empleado();

                emp.IdEmpleado =
                    txtIdEmpleado.Text.Trim();

                emp.Nombre =
                    txtNombre.Text.Trim();

                emp.IdTipo =
                    cmbTipoEmpleado.SelectedValue?
                    .ToString()
                    .Trim();

                empleadoLN.Actualizar(
                    emp,
                    idViejo);

                CargarGrid();

                VaciarCampos();

                MessageBox.Show(
                    "¡Empleado modificado correctamente!",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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
                    txtIdEmpleado.Text))
                {
                    MessageBox.Show(
                        "Seleccione un empleado de la tabla para eliminar.",
                        "Advertencia",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult confirmacion =
                    MessageBox.Show(
                        "¿Está seguro de que desea eliminar el empleado " +
                        txtIdEmpleado.Text +
                        "?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (confirmacion ==
                    DialogResult.Yes)
                {
                    empleadoLN.Eliminar(
                        txtIdEmpleado.Text.Trim());

                    CargarGrid();

                    LimpiarFormulario();

                    MessageBox.Show(
                        "¡Empleado eliminado correctamente!",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
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
        // VACIAR CAMPOS
        // =========================================================

        private void VaciarCampos()
        {
            txtIdEmpleado.Clear();

            txtNombre.Clear();

            cmbTipoEmpleado.SelectedIndex =
                -1;

            dgvEmpleados.ClearSelection();

            dgvEmpleados.CurrentCell =
                null;

            idViejo =
                string.Empty;

            txtNombre.Focus();
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

        // =========================================================
        // CLICK EN LA TABLA
        // =========================================================

        private void dataGridView1_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila =
                    dgvEmpleados.Rows[
                        e.RowIndex];

                txtIdEmpleado.Text =
                    fila.Cells[0]
                    .Value?
                    .ToString()
                    .Trim();

                txtNombre.Text =
                    fila.Cells[1]
                    .Value?
                    .ToString()
                    .Trim();

                if (fila.Cells.Count > 2 &&
                    fila.Cells[2].Value != null)
                {
                    string idTipo =
                        fila.Cells[2]
                        .Value
                        .ToString()
                        .Trim();

                    cmbTipoEmpleado.SelectedValue =
                        idTipo;
                }

                idViejo =
                    txtIdEmpleado.Text;
            }
        }
    }
}

