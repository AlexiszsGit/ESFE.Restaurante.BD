using ESFE.RestauranteBD.EN;
using ESFE.RestauranteBD.LN;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ESFE.RestauranteBD.UI
{
    public partial class frmMenu : Form
    {
        private readonly Color Fondo = Color.FromArgb(10, 10, 10);
        private readonly Color Panel = Color.FromArgb(24, 24, 24);
        private readonly Color Dorado = Color.FromArgb(212, 175, 55);
        private readonly Color Gris = Color.FromArgb(170, 170, 170);
        private readonly Color Blanco = Color.FromArgb(245, 245, 245);
        private readonly Color Rojo = Color.FromArgb(155, 45, 45);

        private MenuLN menuLN;

        private Panel panelCabecera;
        private Panel panelLateral;
        private Panel panelContenido;
        private Panel panelFormulario;
        private Panel panelBotones;

        private Label lblTitulo;
        private Label lblMenu;

        private Label lblPedido;
        private Label lblCategoria;
        private Label lblPostre;
        private Label lblBebida;
        private Label lblProducto;

        private ComboBox cmbPedido;
        private ComboBox cmbCategoria;
        private ComboBox cmbPostre;
        private ComboBox cmbBebida;

        private TextBox txtProducto;
        private TextBox txtBuscar;

        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnLimpiar;

        private Button btnBebida;
        private Button btnCategoria;
        private Button btnCliente;
        private Button btnDescuentos;
        private Button btnDetallePedidos;
        private Button btnEmpleado;
        private Button btnMetodoPago;
        private Button btnPago;
        private Button btnPedido;
        private Button btnReserva;
        private Button btnMesa;
        private Button btnPlatillos;
        private Button btnPostres;
        private Button btnTipoEmpleado;
        private Button btnSalir;

        private DataGridView dgvMenu;

        public frmMenu()
        {
            menuLN = new MenuLN();

            ConfigurarFormulario();
            CrearInterfaz();
            CargarCombos();
            CargarDatosIniciales();

            Resize += FrmMenu_Resize;
        }

        private void ConfigurarFormulario()
        {
            Text = "RESTAURANTEBD | Menú";

            StartPosition = FormStartPosition.CenterScreen;

            FormBorderStyle = FormBorderStyle.Sizable;

            MaximizeBox = true;
            MinimizeBox = true;

            WindowState = FormWindowState.Maximized;

            MinimumSize = new Size(1200, 750);

            BackColor = Fondo;

            Font = new Font(
                "Segoe UI",
                10F,
                FontStyle.Regular);
        }

        private void CrearInterfaz()
        {
            CrearPaneles();
            CrearCabecera();
            CrearFormulario();
            CrearBotonesAccion();
            CrearTabla();
            CrearMenuLateral();

            DistribuirInterfaz();
        }

        private void CrearPaneles()
        {
            panelCabecera = new Panel
            {
                BackColor = Panel
            };

            panelLateral = new Panel
            {
                BackColor = Panel,
                AutoScroll = true
            };

            panelContenido = new Panel
            {
                BackColor = Fondo
            };

            panelFormulario = new Panel
            {
                BackColor = Panel
            };

            panelBotones = new Panel
            {
                BackColor = Panel
            };

            Controls.Add(panelContenido);
            Controls.Add(panelLateral);
            Controls.Add(panelCabecera);

            panelContenido.Controls.Add(panelFormulario);
            panelContenido.Controls.Add(panelBotones);
        }

        private void CrearCabecera()
        {
            lblTitulo = CrearEtiqueta(
                "✦  RESTAURANTEBD",
                27F,
                Dorado,
                true);

            lblMenu = CrearEtiqueta(
                "MENÚ",
                22F,
                Blanco,
                true);

            panelCabecera.Controls.Add(lblTitulo);
            panelCabecera.Controls.Add(lblMenu);
        }

        private Label CrearEtiqueta(
            string texto,
            float tamaño,
            Color color,
            bool negrita)
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

        private void CrearFormulario()
        {
            lblPedido = CrearEtiqueta(
                "PEDIDO",
                10F,
                Gris,
                true);

            lblCategoria = CrearEtiqueta(
                "CATEGORÍA",
                10F,
                Gris,
                true);

            lblPostre = CrearEtiqueta(
                "POSTRE",
                10F,
                Gris,
                true);

            lblBebida = CrearEtiqueta(
                "BEBIDA",
                10F,
                Gris,
                true);

            lblProducto = CrearEtiqueta(
                "PRODUCTO",
                10F,
                Gris,
                true);

            cmbPedido = CrearComboBox();
            cmbCategoria = CrearComboBox();
            cmbPostre = CrearComboBox();
            cmbBebida = CrearComboBox();

            txtProducto = CrearTextBox();
            txtBuscar = CrearTextBox();

            txtBuscar.PlaceholderText =
                "Buscar por ID de pedido...";

            panelFormulario.Controls.Add(lblPedido);
            panelFormulario.Controls.Add(cmbPedido);

            panelFormulario.Controls.Add(lblCategoria);
            panelFormulario.Controls.Add(cmbCategoria);

            panelFormulario.Controls.Add(lblPostre);
            panelFormulario.Controls.Add(cmbPostre);

            panelFormulario.Controls.Add(lblBebida);
            panelFormulario.Controls.Add(cmbBebida);

            panelFormulario.Controls.Add(lblProducto);
            panelFormulario.Controls.Add(txtProducto);

            panelFormulario.Controls.Add(txtBuscar);
        }

        private ComboBox CrearComboBox()
        {
            return new ComboBox
            {
                DropDownStyle =
                    ComboBoxStyle.DropDownList,

                BackColor =
                    Color.FromArgb(35, 35, 35),

                ForeColor = Blanco,

                FlatStyle =
                    FlatStyle.Flat,

                Font =
                    new Font(
                        "Segoe UI",
                        10F)
            };
        }

        private TextBox CrearTextBox()
        {
            return new TextBox
            {
                BackColor =
                    Color.FromArgb(35, 35, 35),

                ForeColor = Blanco,

                BorderStyle =
                    BorderStyle.FixedSingle,

                Font =
                    new Font(
                        "Segoe UI",
                        10F)
            };
        }

        private void CrearBotonesAccion()
        {
            btnAgregar = CrearBoton("AGREGAR");
            btnActualizar = CrearBoton("ACTUALIZAR");
            btnEliminar = CrearBoton("ELIMINAR");
            btnBuscar = CrearBoton("BUSCAR");
            btnLimpiar = CrearBoton("LIMPIAR");

            btnAgregar.Click += BtnAgregar_Click;
            btnActualizar.Click += BtnActualizar_Click;
            btnEliminar.Click += BtnEliminar_Click;
            btnBuscar.Click += BtnBuscar_Click;
            btnLimpiar.Click += BtnLimpiar_Click;

            panelBotones.Controls.Add(btnAgregar);
            panelBotones.Controls.Add(btnActualizar);
            panelBotones.Controls.Add(btnEliminar);
            panelBotones.Controls.Add(btnBuscar);
            panelBotones.Controls.Add(btnLimpiar);
        }

        private Button CrearBoton(string texto)
        {
            Button boton = new Button
            {
                Text = texto,

                BackColor =
                    Color.FromArgb(
                        35,
                        35,
                        35),

                ForeColor = Blanco,

                FlatStyle =
                    FlatStyle.Flat,

                Font =
                    new Font(
                        "Segoe UI Semibold",
                        10F,
                        FontStyle.Bold),

                Cursor = Cursors.Hand,

                UseVisualStyleBackColor = false
            };

            boton.FlatAppearance.BorderSize = 1;
            boton.FlatAppearance.BorderColor = Dorado;

            boton.MouseEnter += delegate
            {
                boton.BackColor =
                    Color.FromArgb(
                        55,
                        48,
                        30);

                boton.ForeColor = Dorado;
            };

            boton.MouseLeave += delegate
            {
                boton.BackColor =
                    Color.FromArgb(
                        35,
                        35,
                        35);

                boton.ForeColor = Blanco;
            };

            return boton;
        }

        private void CrearTabla()
        {
            dgvMenu = new DataGridView
            {
                BackgroundColor =
                    Color.FromArgb(
                        18,
                        18,
                        18),

                BorderStyle =
                    BorderStyle.None,

                AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill,

                SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect,

                MultiSelect = false,

                AllowUserToAddRows = false,

                AllowUserToDeleteRows = false,

                AllowUserToResizeRows = false,

                ReadOnly = true,

                RowHeadersVisible = false,

                EnableHeadersVisualStyles = false,

                GridColor =
                    Color.FromArgb(
                        60,
                        60,
                        60)
            };

            dgvMenu.ColumnHeadersDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor =
                        Color.FromArgb(
                            35,
                            35,
                            35),

                    ForeColor = Dorado,

                    Font =
                        new Font(
                            "Segoe UI",
                            10F,
                            FontStyle.Bold),

                    Alignment =
                        DataGridViewContentAlignment.MiddleCenter
                };

            dgvMenu.DefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor =
                        Color.FromArgb(
                            25,
                            25,
                            25),

                    ForeColor = Blanco,

                    SelectionBackColor =
                        Color.FromArgb(
                            75,
                            60,
                            25),

                    SelectionForeColor = Blanco,

                    Font =
                        new Font(
                            "Segoe UI",
                            10F)
                };

            dgvMenu.RowTemplate.Height = 32;

            dgvMenu.CellClick += DgvMenu_CellClick;

            panelContenido.Controls.Add(dgvMenu);
        }

        private void CrearMenuLateral()
        {
            Label titulo = CrearEtiqueta(
                "PANTALLAS",
                14F,
                Dorado,
                true);

            titulo.Left = 25;
            titulo.Top = 20;

            panelLateral.Controls.Add(titulo);

            btnBebida =
                CrearBotonLateral("BEBIDA");

            btnCategoria =
                CrearBotonLateral("CATEGORÍA");

            btnCliente =
                CrearBotonLateral("CLIENTE");

            btnDescuentos =
                CrearBotonLateral("DESCUENTOS");

            btnDetallePedidos =
                CrearBotonLateral("DETALLE DE PEDIDOS");

            btnEmpleado =
                CrearBotonLateral("EMPLEADO");

            btnMetodoPago =
                CrearBotonLateral("MÉTODO DE PAGO");

            btnPago =
                CrearBotonLateral("PAGO");

            btnPedido =
                CrearBotonLateral("PEDIDO");

            btnReserva =
                CrearBotonLateral("RESERVA");

            btnMesa =
                CrearBotonLateral("MESA");

            btnPlatillos =
                CrearBotonLateral("PLATILLOS");

            btnPostres =
                CrearBotonLateral("POSTRES");

            btnTipoEmpleado =
                CrearBotonLateral("TIPO DE EMPLEADO");

            btnSalir =
                CrearBotonLateral("SALIR");

            btnSalir.BackColor = Rojo;
            btnSalir.FlatAppearance.BorderColor = Rojo;

            panelLateral.Controls.Add(btnBebida);
            panelLateral.Controls.Add(btnCategoria);
            panelLateral.Controls.Add(btnCliente);
            panelLateral.Controls.Add(btnDescuentos);
            panelLateral.Controls.Add(btnDetallePedidos);
            panelLateral.Controls.Add(btnEmpleado);
            panelLateral.Controls.Add(btnMetodoPago);
            panelLateral.Controls.Add(btnPago);
            panelLateral.Controls.Add(btnPedido);
            panelLateral.Controls.Add(btnReserva);
            panelLateral.Controls.Add(btnMesa);
            panelLateral.Controls.Add(btnPlatillos);
            panelLateral.Controls.Add(btnPostres);
            panelLateral.Controls.Add(btnTipoEmpleado);
            panelLateral.Controls.Add(btnSalir);

            btnBebida.Click += delegate
            {
                AbrirPantalla("FrmBebida");
            };

            btnCategoria.Click += delegate
            {
                AbrirPantalla("FrmCategoria");
            };

            btnCliente.Click += delegate
            {
                AbrirPantalla("FrmCliente");
            };

            btnDescuentos.Click += delegate
            {
                AbrirPantalla("FrmDescuentos");
            };

            btnDetallePedidos.Click += delegate
            {
                AbrirPantalla("FrmDetallePedidos");
            };

            btnEmpleado.Click += delegate
            {
                AbrirPantalla("FrmEmpleado");
            };

            btnMetodoPago.Click += delegate
            {
                AbrirPantalla("FrmMetodoPago");
            };

            btnPago.Click += delegate
            {
                AbrirPantalla("FrmPago");
            };

            btnPedido.Click += delegate
            {
                AbrirPantalla("FrmPedido");
            };

            btnReserva.Click += delegate
            {
                AbrirPantalla("FrmReserva");
            };

            btnMesa.Click += delegate
            {
                AbrirPantalla("FrmMesa");
            };

            btnPlatillos.Click += delegate
            {
                AbrirPantalla("FrmPlatillos");
            };

            btnPostres.Click += delegate
            {
                AbrirPantalla("FrmPostres");
            };

            btnTipoEmpleado.Click += delegate
            {
                AbrirPantalla("FrmTipoEmpleado");
            };

            btnSalir.Click += BtnSalir_Click;
        }

        private Button CrearBotonLateral(string texto)
        {
            Button boton = CrearBoton(texto);

            boton.Font =
                new Font(
                    "Segoe UI Semibold",
                    9.5F,
                    FontStyle.Bold);

            return boton;
        }

        private void DistribuirInterfaz()
        {
            int ancho = ClientSize.Width;
            int alto = ClientSize.Height;

            panelCabecera.Left = 0;
            panelCabecera.Top = 0;
            panelCabecera.Width = ancho;
            panelCabecera.Height = 100;

            lblTitulo.Left = 30;
            lblTitulo.Top = 22;

            lblMenu.Left =
                (panelCabecera.Width -
                 lblMenu.Width) / 2;

            lblMenu.Top = 30;

            panelLateral.Left = 0;
            panelLateral.Top = 100;
            panelLateral.Width = 245;
            panelLateral.Height =
                Math.Max(
                    alto - 100,
                    500);

            DistribuirBotonesLaterales();

            panelContenido.Left = 260;
            panelContenido.Top = 115;

            panelContenido.Width =
                Math.Max(
                    ancho - 280,
                    800);

            panelContenido.Height =
                Math.Max(
                    alto - 135,
                    550);

            panelFormulario.Left = 15;
            panelFormulario.Top = 15;

            panelFormulario.Width =
                panelContenido.Width - 30;

            panelFormulario.Height = 155;

            DistribuirFormulario();

            panelBotones.Left = 15;
            panelBotones.Top =
                panelFormulario.Bottom + 10;

            panelBotones.Width =
                panelContenido.Width - 30;

            panelBotones.Height = 60;

            DistribuirBotonesAccion();

            dgvMenu.Left = 15;

            dgvMenu.Top =
                panelBotones.Bottom + 15;

            dgvMenu.Width =
                panelContenido.Width - 30;

            dgvMenu.Height =
                panelContenido.Height -
                dgvMenu.Top -
                15;
        }

        private void DistribuirBotonesLaterales()
        {
            Button[] botones =
            {
                btnBebida,
                btnCategoria,
                btnCliente,
                btnDescuentos,
                btnDetallePedidos,
                btnEmpleado,
                btnMetodoPago,
                btnPago,
                btnPedido,
                btnReserva,
                btnMesa,
                btnPlatillos,
                btnPostres,
                btnTipoEmpleado,
                btnSalir
            };

            int ancho = 205;
            int alto = 42;
            int separacion = 7;

            int x = 20;
            int y = 55;

            foreach (Button boton in botones)
            {
                boton.Left = x;
                boton.Top = y;
                boton.Width = ancho;
                boton.Height = alto;

                y += alto + separacion;
            }
        }

        private void DistribuirFormulario()
        {
            int espacio = 15;

            int anchoCampo =
                (panelFormulario.Width -
                 (espacio * 6)) / 5;

            if (anchoCampo < 100)
                anchoCampo = 100;

            Label[] etiquetas =
            {
                lblPedido,
                lblCategoria,
                lblPostre,
                lblBebida,
                lblProducto
            };

            Control[] controles =
            {
                cmbPedido,
                cmbCategoria,
                cmbPostre,
                cmbBebida,
                txtProducto
            };

            for (int i = 0; i < 5; i++)
            {
                int x =
                    espacio +
                    (i *
                    (anchoCampo + espacio));

                etiquetas[i].Left = x;
                etiquetas[i].Top = 20;

                controles[i].Left = x;
                controles[i].Top = 48;

                controles[i].Width =
                    anchoCampo;

                controles[i].Height = 32;
            }

            txtBuscar.Left =
                panelFormulario.Width -
                300;

            txtBuscar.Top = 105;
            txtBuscar.Width = 280;
            txtBuscar.Height = 30;
        }

        private void DistribuirBotonesAccion()
        {
            Button[] botones =
            {
                btnAgregar,
                btnActualizar,
                btnEliminar,
                btnBuscar,
                btnLimpiar
            };

            int separacion = 10;

            int ancho =
                (panelBotones.Width -
                 (separacion * 6)) / 5;

            if (ancho < 100)
                ancho = 100;

            for (int i = 0; i < botones.Length; i++)
            {
                botones[i].Left =
                    separacion +
                    i * (ancho + separacion);

                botones[i].Top = 10;

                botones[i].Width = ancho;
                botones[i].Height = 40;
            }
        }

        private void CargarCombos()
        {
            try
            {
                List<Pedido> pedidos =
                    menuLN.ObtenerPedidos();

                cmbPedido.DataSource = null;
                cmbPedido.DataSource = pedidos;
                cmbPedido.DisplayMember = "IdPedido";
                cmbPedido.ValueMember = "IdPedido";
                cmbPedido.SelectedIndex = -1;

                List<Categoria> categorias =
                    menuLN.ObtenerCategorias();

                cmbCategoria.DataSource = null;
                cmbCategoria.DataSource = categorias;
                cmbCategoria.DisplayMember = "Nombre";
                cmbCategoria.ValueMember = "IdCategoria";
                cmbCategoria.SelectedIndex = -1;

                List<Postre> postres =
                    menuLN.ObtenerPostres();

                cmbPostre.DataSource = null;
                cmbPostre.DataSource = postres;
                cmbPostre.DisplayMember = "Nombre";
                cmbPostre.ValueMember = "IdPostre";
                cmbPostre.SelectedIndex = -1;

                List<Bebida> bebidas =
                    menuLN.ObtenerBebidas();

                cmbBebida.DataSource = null;
                cmbBebida.DataSource = bebidas;
                cmbBebida.DisplayMember = "Nombre";
                cmbBebida.ValueMember = "IdBebida";
                cmbBebida.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los datos de los campos.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarDatosIniciales()
        {
            CargarTabla();
        }

        private void CargarTabla()
        {
            try
            {
                List<MenuEN> lista =
                    menuLN.ObtenerTodos();

                dgvMenu.DataSource = null;
                dgvMenu.DataSource = lista;

                ConfigurarColumnasTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo cargar la tabla.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string ObtenerValorCombo(
            ComboBox combo)
        {
            if (combo.SelectedValue == null)
                return string.Empty;

            return combo.SelectedValue.ToString()
                   ?? string.Empty;
        }

        private MenuEN ObtenerMenuDesdeFormulario()
        {
            return new MenuEN
            {
                IdPedido =
                    ObtenerValorCombo(cmbPedido),

                IdCategoria =
                    ObtenerValorCombo(cmbCategoria),

                IdPostre =
                    ObtenerValorCombo(cmbPostre),

                IdBebida =
                    ObtenerValorCombo(cmbBebida),

                IdProducto =
                    txtProducto.Text.Trim()
            };
        }

        private void BtnAgregar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(
                    ObtenerValorCombo(cmbPedido)))
                {
                    MessageBox.Show(
                        "Seleccione un pedido.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    cmbPedido.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(
                    txtProducto.Text))
                {
                    MessageBox.Show(
                        "Escriba el producto.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtProducto.Focus();
                    return;
                }

                MenuEN menu =
                    ObtenerMenuDesdeFormulario();

                if (menuLN.agregar(menu))
                {
                    MessageBox.Show(
                        "El registro se agregó correctamente.",
                        "Menú",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarTabla();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo agregar el registro.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnActualizar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (dgvMenu.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione un registro de la tabla.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                MenuEN menu =
                    ObtenerMenuDesdeFormulario();

                if (string.IsNullOrWhiteSpace(menu.IdPedido))
                {
                    MessageBox.Show(
                        "Seleccione un pedido.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                DialogResult respuesta =
                    MessageBox.Show(
                        "¿Está seguro de actualizar este registro?",
                        "Actualizar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (respuesta != DialogResult.Yes)
                    return;

                if (menuLN.Actualizar(menu))
                {
                    CargarTabla();

                    MessageBox.Show(
                        "El registro se actualizó correctamente.",
                        "Menú",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo actualizar el registro.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo actualizar el registro.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                if (dgvMenu.CurrentRow == null)
                {
                    MessageBox.Show(
                        "Seleccione un registro de la tabla.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                MenuEN menu =
                    ObtenerMenuDesdeFormulario();

                DialogResult respuesta =
                    MessageBox.Show(
                        "¿Está seguro de eliminar este registro?",
                        "Eliminar",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (respuesta != DialogResult.Yes)
                    return;

                if (menuLN.Eliminar(menu))
                {
                    CargarTabla();
                    LimpiarCampos();

                    MessageBox.Show(
                        "El registro se eliminó correctamente.",
                        "Menú",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo eliminar el registro.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo eliminar el registro.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnBuscar_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                string idPedido =
                    txtBuscar.Text.Trim();

                if (string.IsNullOrWhiteSpace(idPedido))
                {
                    CargarTabla();
                    return;
                }

                MenuEN menu = new MenuEN
                {
                    IdPedido = idPedido
                };

                List<MenuEN> resultado =
                    menuLN.Buscar(menu);

                dgvMenu.DataSource = null;
                dgvMenu.DataSource = resultado;

                ConfigurarColumnasTabla();

                if (resultado.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron registros para ese pedido.",
                        "Buscar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo realizar la búsqueda.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(
            object sender,
            EventArgs e)
        {
            LimpiarCampos();
            CargarTabla();
        }

        private void LimpiarCampos()
        {
            txtProducto.Clear();
            txtBuscar.Clear();

            cmbPedido.SelectedIndex = -1;
            cmbCategoria.SelectedIndex = -1;
            cmbPostre.SelectedIndex = -1;
            cmbBebida.SelectedIndex = -1;

            dgvMenu.ClearSelection();
        }

        private void DgvMenu_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            try
            {
                DataGridViewRow fila =
                    dgvMenu.Rows[e.RowIndex];

                string idPedido =
                    fila.Cells["IdPedido"].Value
                    ?.ToString()
                    ?? string.Empty;

                string idCategoria =
                    fila.Cells["IdCategoria"].Value
                    ?.ToString()
                    ?? string.Empty;

                string idPostre =
                    fila.Cells["IdPostre"].Value
                    ?.ToString()
                    ?? string.Empty;

                string idBebida =
                    fila.Cells["IdBebida"].Value
                    ?.ToString()
                    ?? string.Empty;

                string idProducto =
                    fila.Cells["IdProducto"].Value
                    ?.ToString()
                    ?? string.Empty;

                SeleccionarCombo(
                    cmbPedido,
                    idPedido);

                SeleccionarCombo(
                    cmbCategoria,
                    idCategoria);

                SeleccionarCombo(
                    cmbPostre,
                    idPostre);

                SeleccionarCombo(
                    cmbBebida,
                    idBebida);

                txtProducto.Text =
                    idProducto;
            }
            catch
            {
            }
        }

        private void SeleccionarCombo(
            ComboBox combo,
            string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                combo.SelectedIndex = -1;
                return;
            }

            for (int i = 0;
                 i < combo.Items.Count;
                 i++)
            {
                object item =
                    combo.Items[i];

                object propiedad =
                    item.GetType()
                        .GetProperty(
                            combo.ValueMember)
                        ?.GetValue(item);

                if (propiedad != null &&
                    propiedad.ToString() == valor)
                {
                    combo.SelectedIndex = i;
                    return;
                }
            }

            combo.SelectedIndex = -1;
        }

        private void ConfigurarColumnasTabla()
        {
            if (dgvMenu.Columns.Count == 0)
                return;

            if (dgvMenu.Columns.Contains("IdPostre"))
                dgvMenu.Columns["IdPostre"].HeaderText =
                    "ID POSTRE";

            if (dgvMenu.Columns.Contains("IdBebida"))
                dgvMenu.Columns["IdBebida"].HeaderText =
                    "ID BEBIDA";

            if (dgvMenu.Columns.Contains("IdProducto"))
                dgvMenu.Columns["IdProducto"].HeaderText =
                    "PRODUCTO";

            if (dgvMenu.Columns.Contains("IdCategoria"))
                dgvMenu.Columns["IdCategoria"].HeaderText =
                    "ID CATEGORÍA";

            if (dgvMenu.Columns.Contains("IdPedido"))
                dgvMenu.Columns["IdPedido"].HeaderText =
                    "ID PEDIDO";
        }

        private void FrmMenu_Resize(
            object sender,
            EventArgs e)
        {
            if (WindowState !=
                FormWindowState.Minimized)
            {
                DistribuirInterfaz();
            }
        }

        private void AbrirPantalla(
            string nombreFormulario)
        {
            try
            {
                Type tipo =
                    Type.GetType(
                        "ESFE.RestauranteBD.UI." +
                        nombreFormulario);

                if (tipo == null)
                {
                    MessageBox.Show(
                        "No se encontró la pantalla: " +
                        nombreFormulario,
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (!(Activator.CreateInstance(tipo)
                    is Form formulario))
                {
                    MessageBox.Show(
                        "La pantalla no es un formulario válido.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Hide();

                formulario.StartPosition =
                    FormStartPosition.CenterScreen;

                formulario.FormClosed +=
                    delegate
                    {
                        Show();
                        CargarCombos();
                        CargarTabla();
                    };

                formulario.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo abrir la pantalla.\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnSalir_Click(
            object sender,
            EventArgs e)
        {
            DialogResult resultado =
                MessageBox.Show(
                    "¿Está seguro de salir del sistema?",
                    "Salir",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (resultado ==
                DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}