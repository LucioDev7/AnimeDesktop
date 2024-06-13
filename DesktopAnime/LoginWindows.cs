using DesktopAnime.Repositories;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace DesktopAnime
{
    public partial class LoginWindows : Form
    {
        UserRepository userRepository = new UserRepository(); //se instancia la clase 'UserRepository'
        public LoginWindows()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnCloseLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //Cambia los caracteres ingresados a un caracter "oculto"
            txtPassword.UseSystemPasswordChar = true;
        }

        private void LoginWindows_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private async void btnAccederLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                msgError("Ingrese su usuario o email");
            }
            else if (txtPassword.Text == "")
            {
                msgError("Ingrese su contraseña");
            }
            else
            {   //verifico si en la base de dato existen esos datos
                //VerifyCredentials es un metodo que devuelve true o false
                //Guardo lo que devuelve en una variable booleana
                bool validLogin = await userRepository.VerifyCredentialsAsync(txtUser.Text, txtPassword.Text);
                if (validLogin == true)
                {
                    MainFormsWindows mainMenu = new MainFormsWindows(); //instancio menu principal
                    mainMenu.Show(); //mostrar ventana
                    this.Hide(); //ocultar login
                }
                else
                {
                    msgError("Usuario/Email o Contraseña Incorrecta. Por favor, vuelva a intentar");
                    txtPassword.Clear(); //limpiar campo de contraseña
                    txtUser.Focus(); // focus a user
                }
            }
        }

        private void msgError(string msg) //creo el metodo del mensaje de Error que recibe un string
        {
            logMsgError.Visible = true;
            logMsgError.Text = " | " + msg + " | ";
        }
    }
}

