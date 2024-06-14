using DesktopAnime.ClassStatic;
using DesktopAnime.Models;
using DesktopAnime.Repositories;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using DesktopAnime.ClassAux;
using System.Net.Mail;
using System.Net;


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
                    //Obtener datos dependiendo de lo que ingrese el usuario
                    Users? userData = await userRepository.GetUserDataAsync(txtUser.Text);

                    // Se almacenan los datos del usuario en UserSession
                    UserSession.Username = userData.usuario;
                    UserSession.Email = userData.email;
                    UserSession.Rol = userData.rol;

                    MainFormsWindows mainMenu = new MainFormsWindows(); //instancio menu principal
                    mainMenu.Show(); //mostrar ventana
                    mainMenu.FormClosed += btnCerrarSesion;
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

        private void btnCerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtPassword.Clear();
            txtUser.Focus();
            logMsgError.Visible = false;
            this.Show();
        }

        #region OlvidoContraseñaSMTP
        //Evento olvido contraseña
        private void linkContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Cuadro de diálogo para que el usuario ingrese su correo electrónico o nombre de usuario
            string emailOrUsername = Prompt.ShowDialog("Ingrese su correo electrónico o nombre de usuario:", "Olvidé mi contraseña");

            // Si se proporciona un valor no vacío, llama al método para enviar la contraseña por correo
            if (!string.IsNullOrEmpty(emailOrUsername))
            {
                SendPasswordByEmail(emailOrUsername);
            }
        }

        // Método para enviar la contraseña por correo electrónico
        private async void SendPasswordByEmail(string emailOrUsername)
        {
            // Obtiene el usuario desde la base de datos utilizando el correo electrónico o nombre de usuario
            Users? userData = await userRepository.GetUserDataAsync(emailOrUsername);

            // Si se encuentra un usuario con el correo electrónico o nombre de usuario proporcionado
            if (userData != null)
            {
                string to = userData.email; // Dirección de correo del usuario
                string from = "animedesktop.soporte@gmail.com"; // Tu dirección de correo
                string subject = "Recuperación de contraseña"; // Asunto del correo
                string body = $"Hola {userData.usuario},\n\nTu contraseña es: {userData.password}\n\nSaludos,\nEquipo de Soporte"; // Cuerpo del correo

                // Configura el mensaje de correo
                using (var message = new MailMessage(from, to)
                {
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = false // El cuerpo del correo no contiene HTML
                })
                {
                    // Configura el cliente SMTP para enviar el correo
                    using (var client = new SmtpClient("smtp.gmail.com", 587)) // Ajusta según tu servidor SMTP
                    {
                        client.Credentials = new NetworkCredential("animedesktop.soporte@gmail.com", "orfq yzdl uvdg vabd"); // Credenciales de tu correo electrónico
                        client.EnableSsl = true; // Habilita SSL para el servidor SMTP

                        try
                        {
                            // Envía el mensaje de correo
                            client.Send(message);
                            MessageBox.Show("Se ha enviado un correo con la contraseña a su email.", "Correo enviado");
                        }
                        catch (Exception ex)
                        {
                            // Muestra un mensaje de error si falla el envío del correo
                            MessageBox.Show($"Error al enviar el correo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                // Muestra un mensaje si no se encuentra un usuario con el correo electrónico o nombre de usuario proporcionado
                MessageBox.Show("No se encontró un usuario con ese correo electrónico o nombre de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}

