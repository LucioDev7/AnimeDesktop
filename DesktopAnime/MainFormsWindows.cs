using DesktopAnime.ClassStatic;
using DesktopAnime.Repositories;
using System.Runtime.InteropServices;

namespace DesktopAnime
{
    public partial class MainFormsWindows : Form
    {
        UserRepository userRepository = new UserRepository();
        public MainFormsWindows()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica(Pero no en un 100 %)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;

            botonAdmin();
            MostrarDatosPerfil();
        }

        #region FuncionalidadFormulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Cierra todo los formularios y demas a diferencia de This.Close(); que cierra solo el formulario actual al que se aplique 
        }

        //Posiciones y tamaño antes de maximizar para restaurar
        int lx, ly; //l = location xy = posiciones de ejes
        int sw, sh; //sw = size width sy = size heigth

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.X;
            sw = this.Size.Width;
            sh = this.Size.Height;

            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size(sw, sh); //objeto size
            this.Location = new Point(lx, ly); //obejeto point (coordenadas?)
        }

        //Metodo que permite arrastrar/mover la ventana

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //Evento que funciona al hacer el click y mover el mouse
        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region MetodoGenericoAbrirFormularios
        //Es un método genérico el que se utiliza para abrir instancias caso de formularios
        //en una aplicación Windows Forms.Vamos a descomponerlo:

        //El método tiene un parámetro de tipo MiForm, que es un tipo genérico. Esto significa
        //que el método puede trabajar con cualquier tipo de formulario que se derive de la clase
        //Form y que tenga un constructor sin parámetros (gracias a la restricción new()).

        //La restricción where MiForm : Form, new() indica que el tipo MiForm debe cumplir con dos condiciones:
        //Debe ser una clase que derive de 'Form' (Windows Forms)
        //Debe tener un constructor sin parametros

        //Para utilizar este método, simplemente llama a AbrirFormularios y pasa el tipo de formulario que deseas abrir como parámetro de tipo. Por ejemplo:
        //AbrirFormularios<Formulario1>();
        //AbrirFormularios<Formulario2>();
        #endregion

        #region Forms
        //Metodo para abrir formularios dentro del panel (Metodo generico)
        private void AbrirFormularios<MiForm>() where MiForm : Form, new()
        {
            Form? formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la colecion el formulario
                                                                                      //OfType<MiForm>(): Filtra la colección para incluir solo los controles de tipo MiForm.
                                                                                      //FirstOrDefault(): Devuelve el primer formulario de tipo MiForm encontrado en la colección, o null si no se encuentra ninguno.

            //Si el formulario/instancia no existe
            if (formulario == null)
            {
                //Instancia nueva de formulario
                formulario = new MiForm();
                //Para que no sea de nivel superior y poder integrarlo a otro
                formulario.TopLevel = false;
                //Elimina los bordes de los formularios
                formulario.FormBorderStyle = FormBorderStyle.None;
                //El formulario ocupa todo el espacio del contenedor padre
                formulario.Dock = DockStyle.Fill;
                //Añade el formulario al panel de formularios
                panelFormularios.Controls.Add(formulario);
                //Guarda una referencia en la propiedad Tag del panel
                panelFormularios.Tag = formulario;
                //Muestra el formulario
                formulario.Show();
                //Lleva el formulario al frente
                formulario.BringToFront();
                //Añade un evento para cuando el formulario se cierre
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //Si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        private void CloseForms(object sender, EventArgs e)
        {
            if (Application.OpenForms["DatosAnimesWindow"] == null) button1.BackColor = Color.FromArgb(0, 100, 0);
            if (Application.OpenForms["TrailersWindow"] == null) button2.BackColor = Color.FromArgb(0, 100, 0);
            if (Application.OpenForms["CapitulosWindow"] == null) button3.BackColor = Color.FromArgb(0, 100, 0);
            if (Application.OpenForms["DatosUsersWindow"] == null) button4.BackColor = Color.FromArgb(0, 100, 0);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularios<DatosAnimesWindow>();
            button1.BackColor = Color.FromArgb(34, 139, 34);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormularios<TrailersWindow>();
            button2.BackColor = Color.FromArgb(34, 139, 34); //Al tocar el boton queda en este color
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormularios<CapitulosWindow>();
            button3.BackColor = Color.FromArgb(34, 139, 34);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormularios<DatosUsersWindow>();
            button4.BackColor = Color.FromArgb(34, 139, 34);
        }

        private void botonAdmin()
        {
            string rol = UserSession.Rol;
            if (rol == "admin")
            {
                button4.Visible = true;
            }
            else
            {
                button4.Visible = false;
            }
        }

        #endregion

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cerrar sesión?",
                "Peligro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes) this.Close();
        }


        private void MostrarDatosPerfil()
        {
            MostrarCorreo.Text = UserSession.Email;
            MostrarNombre.Text = UserSession.Username;
            MostrarRol.Text = UserSession.Rol;
        }

        private void menuMinMax_Click_1(object sender, EventArgs e)
        {
            if (panelMenu.Width == 225)
            {
                panelMenu.Width = 50;
                panelPerfil.Height = 0;
            }
            else
            {
                panelPerfil.Height = 132;
                panelMenu.Width = 225;

            }
        }
    }
}

//Teoria de la arquitectura tradicional en capas, tenemos 3. La capa de Presentación, Negocio/Dominio, Acceso a Datos/Persistencia,
//Pero tambien hay una cuarta capa que estara siempre presente sobre todo en app web,
//Cross-Cutting (Corte transversal), tambien conocido como capa común o soporte, esta capa es común para las demas, es decir que pueden
//acceder a ella. La responsabilidad de esta capa es la gestión de seguridad y operaciones como; Autenticación, Autorización,
//Almacenamiento en Caché, Comunicación, Gestión de la configuracion, gestion de excepciones, registro e instrumentación,
//administracion del estado, validaciones de seguridad.