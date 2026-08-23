using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESFE.RestauranteBD.UI
{
    public partial class FrmPrincipal : Form
    {
        private readonly Color Fondo = Color.FromArgb(10, 10, 10);
        private readonly Color Panel = Color.FromArgb(24, 24, 24);
        private readonly Color Dorado = Color.FromArgb(212, 175, 55);
        private readonly Color Gris = Color.FromArgb(170, 170, 170);
        private readonly Color Blanco = Color.FromArgb(245, 245, 245);
        private readonly Color Rojo = Color.FromArgb(155, 45, 45);

        private Panel panelCabecera;
        private Panel panelMenu;
        private Panel panelGaleria;

        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lblSeccion;

        private Button btnBebidas;
        private Button btnCategorias;
        private Button btnClientes;
        private Button btnDescuentos;
        private Button btnPlatillos;
        private Button btnSalir;

        private Panel panelPlatillos;
        private Panel panelBebidas;
        private Panel panelPostres;

        private System.Windows.Forms.Timer timerPlatillos;
        private System.Windows.Forms.Timer timerBebidas;
        private System.Windows.Forms.Timer timerPostres;

        private static readonly HttpClient clienteHttp =
            CrearClienteHttp();

        private readonly Dictionary<string, Image> cacheImagenes =
            new Dictionary<string, Image>();

        private readonly object bloqueoCache =
            new object();

        private readonly string[] nombresPlatillos =
        {
            "Hamburguesa",
            "Pizza",
            "Pasta",
            "Pollo Asado",
            "Carne a la Parrilla"
        };

        private readonly string[] urlsPlatillos =
        {
            "https://images.unsplash.com/photo-1568901346375-23c9450c58cd?auto=format&fit=crop&w=800&q=75",
            "https://images.unsplash.com/photo-1574071318508-1cdbab80d002?auto=format&fit=crop&w=800&q=75",
            "https://images.unsplash.com/photo-1473093295043-cdd812d0e601?auto=format&fit=crop&w=800&q=75",
            "https://images.unsplash.com/photo-1532550907401-a500c9a57435?auto=format&fit=crop&w=800&q=75",
            "https://images.unsplash.com/photo-1546833999-b9f581a1996d?auto=format&fit=crop&w=800&q=75"
        };

        private readonly string[] nombresBebidas =
        {
            "Limonada",
            "Horchata",
            "Cafe",
            "Jugo de Naranja",
            "Batido de Fresa"
        };

        private readonly string[] urlsBebidas =
        {
            "https://images.unsplash.com/photo-1621263764928-df1444c5a6d0?auto=format&fit=crop&w=800&q=75",
            "https://images.unsplash.com/photo-1572490122747-3968b75cc699?auto=format&fit=crop&w=800&q=75",
            "https://images.unsplash.com/photo-1495474472287-4d71bcdd2085?auto=format&fit=crop&w=800&q=75",
            "https://images.unsplash.com/photo-1600271886742-f049cd451bba?auto=format&fit=crop&w=800&q=75",
            "https://images.unsplash.com/photo-1553530666-ba11a7da3888?auto=format&fit=crop&w=800&q=75"
        };

        private readonly string[] nombresPostres =
        {
            "Pastel de Chocolate",
            "Cheesecake",
            "Flan",
            "Brownie",
            "Waffles"
        };

        private readonly string[] urlsPostres =
        {
            "https://images.unsplash.com/photo-1578985545062-69928b1d9587?auto=format&fit=crop&w=800&q=75",
            "https://images.unsplash.com/photo-1565958011703-44f9829ba187?auto=format&fit=crop&w=800&q=75",
            "https://images.unsplash.com/photo-1551024601-bec78aea704b?auto=format&fit=crop&w=800&q=75",
            "https://images.unsplash.com/photo-1564355808539-22f0c5d79f6d?auto=format&fit=crop&w=800&q=75",
            "https://images.unsplash.com/photo-1562376552-0d160a2f238d?auto=format&fit=crop&w=800&q=75"
        };

        public FrmPrincipal()
        {
            InitializeComponent();

            ConfigurarFormulario();
            CrearInterfaz();
            CrearGaleria();
            CrearTimers();
            DistribuirInterfaz();

            Resize += FrmPrincipal_Resize;
        }

        private static HttpClient CrearClienteHttp()
        {
            HttpClient cliente = new HttpClient();

            cliente.Timeout =
                TimeSpan.FromSeconds(12);

            cliente.DefaultRequestHeaders
                .UserAgent.ParseAdd(
                    "Mozilla/5.0");

            return cliente;
        }

        private void ConfigurarFormulario()
        {
            Text =
                "RESTAURANTEBD | Menu Principal";

            StartPosition =
                FormStartPosition.CenterScreen;

            FormBorderStyle =
                FormBorderStyle.Sizable;

            MaximizeBox = true;
            MinimizeBox = true;

            WindowState =
                FormWindowState.Maximized;

            MinimumSize =
                new Size(1500, 950);

            BackColor = Fondo;

            Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Regular);
        }

        private void CrearInterfaz()
        {
            CrearPaneles();
            CrearTitulos();
            CrearBotones();
        }

        private void CrearPaneles()
        {
            panelCabecera =
                new Panel
                {
                    Name = "panelCabecera",
                    BackColor = Panel
                };

            panelMenu =
                new Panel
                {
                    Name = "panelMenu",
                    BackColor = Panel
                };

            panelGaleria =
                new Panel
                {
                    Name = "panelGaleria",
                    BackColor = Fondo
                };

            Controls.Add(panelGaleria);
            Controls.Add(panelCabecera);
            Controls.Add(panelMenu);
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
                    30F,
                    Dorado,
                    true);

            lblSubtitulo =
                CrearEtiqueta(
                    "Sistema de gestion del restaurante",
                    15F,
                    Gris,
                    true);

            lblSeccion =
                CrearEtiqueta(
                    "MENU PRINCIPAL",
                    14F,
                    Dorado,
                    true);

            panelCabecera.Controls.Add(
                lblTitulo);

            panelCabecera.Controls.Add(
                lblSubtitulo);

            panelMenu.Controls.Add(
                lblSeccion);
        }

        private Button CrearBoton(
            string texto)
        {
            Button boton =
                new Button
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
                            12F,
                            FontStyle.Bold),
                    Cursor =
                        Cursors.Hand,
                    UseVisualStyleBackColor =
                        false
                };

            boton.FlatAppearance.BorderSize = 1;
            boton.FlatAppearance.BorderColor = Dorado;

            return boton;
        }

        private void CrearBotones()
        {
            btnBebidas =
                CrearBoton("BEBIDAS");

            btnCategorias =
                CrearBoton("CATEGORIAS");

            btnClientes =
                CrearBoton("CLIENTES");

            btnDescuentos =
                CrearBoton("DESCUENTOS");

            btnPlatillos =
                CrearBoton("PLATILLOS");

            btnSalir =
                CrearBoton("SALIR");

            btnSalir.BackColor = Rojo;
            btnSalir.FlatAppearance.BorderColor = Rojo;

            panelMenu.Controls.Add(btnBebidas);
            panelMenu.Controls.Add(btnCategorias);
            panelMenu.Controls.Add(btnClientes);
            panelMenu.Controls.Add(btnDescuentos);
            panelMenu.Controls.Add(btnPlatillos);
            panelMenu.Controls.Add(btnSalir);

            btnBebidas.Click += BtnBebidas_Click;
            btnCategorias.Click += BtnCategorias_Click;
            btnClientes.Click += BtnClientes_Click;
            btnDescuentos.Click += BtnDescuentos_Click;
            btnPlatillos.Click += BtnPlatillos_Click;
            btnSalir.Click += BtnSalir_Click;

            AgregarEfectoBoton(btnBebidas);
            AgregarEfectoBoton(btnCategorias);
            AgregarEfectoBoton(btnClientes);
            AgregarEfectoBoton(btnDescuentos);
            AgregarEfectoBoton(btnPlatillos);
        }

        private void AgregarEfectoBoton(
            Button boton)
        {
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
        }

        private void CrearGaleria()
        {
            panelPlatillos =
                CrearPanelCarrusel(
                    "PLATILLOS");

            panelBebidas =
                CrearPanelCarrusel(
                    "BEBIDAS");

            panelPostres =
                CrearPanelCarrusel(
                    "POSTRES");

            CrearTarjetas(
                panelPlatillos,
                nombresPlatillos);

            CrearTarjetas(
                panelBebidas,
                nombresBebidas);

            CrearTarjetas(
                panelPostres,
                nombresPostres);

            panelGaleria.Controls.Add(
                panelPlatillos);

            panelGaleria.Controls.Add(
                panelBebidas);

            panelGaleria.Controls.Add(
                panelPostres);
        }

        private Panel CrearPanelCarrusel(
            string titulo)
        {
            Panel panel =
                new Panel
                {
                    BackColor = Panel,
                    BorderStyle =
                        BorderStyle.None
                };

            Label etiqueta =
                CrearEtiqueta(
                    titulo,
                    15F,
                    Dorado,
                    true);

            etiqueta.Left = 25;
            etiqueta.Top = 10;

            panel.Controls.Add(etiqueta);

            return panel;
        }

        private void CrearTarjetas(
            Panel panel,
            string[] nombres)
        {
            /*
             * 5 imágenes reales.
             * Se repiten 3 veces.
             * El carrusel tiene 15 tarjetas,
             * pero solo se descargan 5 imágenes.
             */

            for (int vuelta = 0;
                 vuelta < 3;
                 vuelta++)
            {
                for (int i = 0;
                     i < nombres.Length;
                     i++)
                {
                    Panel tarjeta =
                        CrearTarjeta(
                            nombres[i],
                            i);

                    panel.Controls.Add(
                        tarjeta);
                }
            }

            ReorganizarCarrusel(panel);
        }

        private Panel CrearTarjeta(
            string nombre,
            int indice)
        {
            Panel tarjeta =
                new Panel
                {
                    Width = 420,
                    Height = 330,
                    BackColor =
                        Color.FromArgb(
                            30,
                            30,
                            30),
                    Tag = indice
                };

            PictureBox imagen =
                new PictureBox
                {
                    Width = 410,
                    Height = 275,
                    Left = 5,
                    Top = 5,
                    BackColor =
                        Color.FromArgb(
                            15,
                            15,
                            15),
                    SizeMode =
                        PictureBoxSizeMode.Zoom,
                    BorderStyle =
                        BorderStyle.None
                };

            Label nombreLabel =
                new Label
                {
                    Text = nombre,
                    Width = 410,
                    Height = 40,
                    Left = 5,
                    Top = 282,
                    ForeColor = Blanco,
                    BackColor =
                        Color.FromArgb(
                            30,
                            30,
                            30),
                    TextAlign =
                        ContentAlignment.MiddleCenter,
                    Font =
                        new Font(
                            "Segoe UI Semibold",
                            14F,
                            FontStyle.Bold),
                    AutoEllipsis = true
                };

            tarjeta.Controls.Add(imagen);
            tarjeta.Controls.Add(nombreLabel);

            return tarjeta;
        }

        private void ReorganizarCarrusel(
            Panel panel)
        {
            int x = 25;

            foreach (Control control
                     in panel.Controls)
            {
                if (control is Panel)
                {
                    control.Left = x;
                    control.Top = 45;

                    x +=
                        control.Width + 25;
                }
            }
        }

        private void CrearTimers()
        {
            timerPlatillos =
                new System.Windows.Forms.Timer();

            timerBebidas =
                new System.Windows.Forms.Timer();

            timerPostres =
                new System.Windows.Forms.Timer();

            /*
             * Movimiento fluido.
             */
            timerPlatillos.Interval = 20;
            timerBebidas.Interval = 20;
            timerPostres.Interval = 20;

            timerPlatillos.Tick +=
                TimerPlatillos_Tick;

            timerBebidas.Tick +=
                TimerBebidas_Tick;

            timerPostres.Tick +=
                TimerPostres_Tick;

            timerPlatillos.Start();
            timerBebidas.Start();
            timerPostres.Start();
        }

        private void TimerPlatillos_Tick(
            object sender,
            EventArgs e)
        {
            MoverCarrusel(
                panelPlatillos,
                -7);
        }

        private void TimerBebidas_Tick(
            object sender,
            EventArgs e)
        {
            MoverCarrusel(
                panelBebidas,
                7);
        }

        private void TimerPostres_Tick(
            object sender,
            EventArgs e)
        {
            MoverCarrusel(
                panelPostres,
                -7);
        }

        private void MoverCarrusel(
            Panel panel,
            int velocidad)
        {
            if (panel == null ||
                panel.IsDisposed)
            {
                return;
            }

            List<Control> tarjetas =
                ObtenerTarjetas(panel);

            if (tarjetas.Count < 2)
                return;

            foreach (Control tarjeta
                     in tarjetas)
            {
                tarjeta.Left += velocidad;
            }

            int separacion = 25;

            if (velocidad < 0)
            {
                Control primera =
                    tarjetas[0];

                if (primera.Right < 0)
                {
                    Control ultima =
                        tarjetas[
                            tarjetas.Count - 1];

                    primera.Left =
                        ultima.Right +
                        separacion;
                }
            }
            else
            {
                Control ultima =
                    tarjetas[
                        tarjetas.Count - 1];

                if (ultima.Left >
                    panel.Width)
                {
                    Control primera =
                        tarjetas[0];

                    ultima.Left =
                        primera.Left -
                        ultima.Width -
                        separacion;
                }
            }
        }

        private List<Control> ObtenerTarjetas(
            Panel panel)
        {
            List<Control> tarjetas =
                new List<Control>();

            foreach (Control control
                     in panel.Controls)
            {
                if (control is Panel)
                {
                    tarjetas.Add(control);
                }
            }

            tarjetas.Sort(
                delegate (
                    Control a,
                    Control b)
                {
                    return a.Left.CompareTo(
                        b.Left);
                });

            return tarjetas;
        }

        private void DistribuirInterfaz()
        {
            if (panelCabecera == null ||
                panelMenu == null ||
                panelGaleria == null ||
                panelPlatillos == null ||
                panelBebidas == null ||
                panelPostres == null)
            {
                return;
            }

            int ancho =
                ClientSize.Width;

            int alto =
                ClientSize.Height;

            panelCabecera.Left = 0;
            panelCabecera.Top = 0;
            panelCabecera.Width = ancho;
            panelCabecera.Height = 135;

            lblTitulo.Left = 45;
            lblTitulo.Top = 25;

            lblSubtitulo.Left = 49;
            lblSubtitulo.Top = 78;

            int margen = 35;

            panelMenu.Left = margen;
            panelMenu.Top = 160;
            panelMenu.Width = 390;

            panelMenu.Height =
                Math.Max(
                    alto - 195,
                    950);

            lblSeccion.Left = 30;
            lblSeccion.Top = 25;

            int botonAncho = 320;
            int botonAlto = 65;
            int separacionY = 18;

            int inicioX =
                (panelMenu.Width -
                 botonAncho) / 2;

            int inicioY = 80;

            btnBebidas.Location =
                new Point(
                    inicioX,
                    inicioY);

            btnCategorias.Location =
                new Point(
                    inicioX,
                    inicioY +
                    botonAlto +
                    separacionY);

            btnClientes.Location =
                new Point(
                    inicioX,
                    inicioY +
                    ((botonAlto +
                      separacionY) * 2));

            btnDescuentos.Location =
                new Point(
                    inicioX,
                    inicioY +
                    ((botonAlto +
                      separacionY) * 3));

            btnPlatillos.Location =
                new Point(
                    inicioX,
                    inicioY +
                    ((botonAlto +
                      separacionY) * 4));

            btnSalir.Location =
                new Point(
                    inicioX,
                    inicioY +
                    ((botonAlto +
                      separacionY) * 5));

            btnBebidas.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            btnCategorias.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            btnClientes.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            btnDescuentos.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            btnPlatillos.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            btnSalir.Size =
                new Size(
                    botonAncho,
                    botonAlto);

            int galeriaX =
                margen + 415;

            int galeriaY = 160;

            int galeriaAncho =
                ancho -
                galeriaX -
                margen;

            int galeriaAlto =
                alto -
                galeriaY -
                35;

            panelGaleria.Left =
                galeriaX;

            panelGaleria.Top =
                galeriaY;

            panelGaleria.Width =
                Math.Max(
                    galeriaAncho,
                    950);

            panelGaleria.Height =
                Math.Max(
                    galeriaAlto,
                    1050);

            int altoFila =
                (panelGaleria.Height -
                 40) / 3;

            panelPlatillos.Left = 0;
            panelPlatillos.Top = 0;
            panelPlatillos.Width =
                panelGaleria.Width;
            panelPlatillos.Height =
                altoFila;

            panelBebidas.Left = 0;
            panelBebidas.Top =
                altoFila + 10;
            panelBebidas.Width =
                panelGaleria.Width;
            panelBebidas.Height =
                altoFila;

            panelPostres.Left = 0;
            panelPostres.Top =
                (altoFila + 10) * 2;
            panelPostres.Width =
                panelGaleria.Width;
            panelPostres.Height =
                altoFila;
        }

        private void FrmPrincipal_Resize(
            object sender,
            EventArgs e)
        {
            if (WindowState !=
                FormWindowState.Minimized)
            {
                DistribuirInterfaz();
            }
        }

        private void BtnBebidas_Click(
            object sender,
            EventArgs e)
        {
            AbrirFormulario(
                new FrmBebida());
        }

        private void BtnCategorias_Click(
            object sender,
            EventArgs e)
        {
            AbrirFormulario(
                new FrmCategoria());
        }

        private void BtnClientes_Click(
            object sender,
            EventArgs e)
        {
            AbrirFormulario(
                new FrmCliente());
        }

        private void BtnDescuentos_Click(
            object sender,
            EventArgs e)
        {
            AbrirFormulario(
                new FrmDescuentos());
        }

        private void BtnPlatillos_Click(
            object sender,
            EventArgs e)
        {
            AbrirFormulario(
                new FrmMenu());
        }

        private void AbrirFormulario(
            Form formulario)
        {
            Hide();

            formulario.FormClosed +=
                Formulario_FormClosed;

            formulario.Show();
        }

        private void Formulario_FormClosed(
            object sender,
            FormClosedEventArgs e)
        {
            Show();
        }

        private void BtnSalir_Click(
            object sender,
            EventArgs e)
        {
            DialogResult resultado =
                MessageBox.Show(
                    "¿Esta seguro de salir del sistema?",
                    "Salir",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (resultado ==
                DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private async void FrmPrincipal_Load(
            object sender,
            EventArgs e)
        {
            DistribuirInterfaz();

            await CargarTodasLasImagenes();
        }

        private async Task CargarTodasLasImagenes()
        {
            /*
             * Las tres categorías empiezan
             * simultáneamente.
             */

            Task tareaPlatillos =
                CargarFilaRapida(
                    panelPlatillos,
                    nombresPlatillos,
                    urlsPlatillos);

            Task tareaBebidas =
                CargarFilaRapida(
                    panelBebidas,
                    nombresBebidas,
                    urlsBebidas);

            Task tareaPostres =
                CargarFilaRapida(
                    panelPostres,
                    nombresPostres,
                    urlsPostres);

            await Task.WhenAll(
                tareaPlatillos,
                tareaBebidas,
                tareaPostres);
        }

        private async Task CargarFilaRapida(
            Panel panel,
            string[] nombres,
            string[] urls)
        {
            if (panel == null ||
                panel.IsDisposed)
            {
                return;
            }

            List<Task> tareas =
                new List<Task>();

            for (int i = 0;
                 i < urls.Length;
                 i++)
            {
                int indice = i;

                tareas.Add(
                    CargarImagenIndividual(
                        panel,
                        indice,
                        urls[indice]));
            }

            await Task.WhenAll(tareas);
        }

        private async Task CargarImagenIndividual(
            Panel panel,
            int indice,
            string url)
        {
            try
            {
                Image imagen;

                lock (bloqueoCache)
                {
                    if (cacheImagenes.ContainsKey(url))
                    {
                        imagen =
                            new Bitmap(
                                cacheImagenes[url]);

                        MostrarImagenEnFila(
                            panel,
                            indice,
                            imagen);

                        return;
                    }
                }

                byte[] datos =
                    await clienteHttp
                        .GetByteArrayAsync(url);

                using (MemoryStream memoria =
                       new MemoryStream(datos))
                {
                    using (Image temporal =
                           Image.FromStream(
                               memoria))
                    {
                        imagen =
                            new Bitmap(
                                temporal);
                    }
                }

                lock (bloqueoCache)
                {
                    if (!cacheImagenes.ContainsKey(url))
                    {
                        cacheImagenes[url] =
                            new Bitmap(imagen);
                    }
                }

                MostrarImagenEnFila(
                    panel,
                    indice,
                    imagen);
            }
            catch
            {
                /*
                 * Si una imagen falla,
                 * no detiene las demás.
                 */
            }
        }

        private void MostrarImagenEnFila(
            Panel panel,
            int indice,
            Image imagen)
        {
            if (IsDisposed ||
                panel == null ||
                panel.IsDisposed)
            {
                imagen.Dispose();
                return;
            }

            try
            {
                if (InvokeRequired)
                {
                    BeginInvoke(
                        new Action(
                            delegate
                            {
                                MostrarImagenEnFila(
                                    panel,
                                    indice,
                                    imagen);
                            }));

                    return;
                }

                foreach (Control control
                         in panel.Controls)
                {
                    Panel tarjeta =
                        control as Panel;

                    if (tarjeta == null)
                        continue;

                    if (Convert.ToInt32(
                            tarjeta.Tag) != indice)
                    {
                        continue;
                    }

                    PictureBox picture =
                        ObtenerImagen(tarjeta);

                    if (picture == null)
                        continue;

                    Image anterior =
                        picture.Image;

                    picture.Image =
                        imagen;

                    if (anterior != null)
                    {
                        anterior.Dispose();
                    }

                    /*
                     * Las otras dos copias del
                     * carrusel reciben la misma imagen.
                     */
                    AplicarImagenARepeticiones(
                        panel,
                        indice,
                        imagen,
                        tarjeta);

                    return;
                }

                imagen.Dispose();
            }
            catch
            {
                imagen.Dispose();
            }
        }

        private void AplicarImagenARepeticiones(
            Panel panel,
            int indice,
            Image imagen,
            Panel tarjetaOriginal)
        {
            foreach (Control control
                     in panel.Controls)
            {
                Panel tarjeta =
                    control as Panel;

                if (tarjeta == null ||
                    tarjeta == tarjetaOriginal)
                {
                    continue;
                }

                if (Convert.ToInt32(
                        tarjeta.Tag) != indice)
                {
                    continue;
                }

                PictureBox picture =
                    ObtenerImagen(tarjeta);

                if (picture == null)
                    continue;

                if (picture.Image != null)
                {
                    picture.Image.Dispose();
                }

                picture.Image =
                    new Bitmap(imagen);
            }
        }

        private PictureBox ObtenerImagen(
            Panel tarjeta)
        {
            foreach (Control control
                     in tarjeta.Controls)
            {
                PictureBox picture =
                    control as PictureBox;

                if (picture != null)
                    return picture;
            }

            return null;
        }

        private void LiberarCache()
        {
            lock (bloqueoCache)
            {
                foreach (Image imagen
                         in cacheImagenes.Values)
                {
                    if (imagen != null)
                    {
                        imagen.Dispose();
                    }
                }

                cacheImagenes.Clear();
            }
        }

        protected override void OnFormClosed(
            FormClosedEventArgs e)
        {
            if (timerPlatillos != null)
                timerPlatillos.Stop();

            if (timerBebidas != null)
                timerBebidas.Stop();

            if (timerPostres != null)
                timerPostres.Stop();

            LiberarCache();

            base.OnFormClosed(e);
        }
    }
} 