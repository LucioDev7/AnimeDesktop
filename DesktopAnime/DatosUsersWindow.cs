using DesktopAnime.Models;
using DesktopAnime.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesktopAnime
{
    public partial class DatosUsersWindow : Form
    {
        //Variable estado modo edición
        private bool EditMode = false;
        private string? idUsuarioSeleccionado;


        UserRepository user = new UserRepository();
        public DatosUsersWindow()
        {
            InitializeComponent();
            CargarUsuariosALaGrilla();
        }

        public DatosUsersWindow(string idUsuarioSeleccionado)
        {
            this.idUsuarioSeleccionado = idUsuarioSeleccionado;
            CargarUsuariosALaGrilla();
        }
        
        private async void CargarUsuariosALaGrilla()
        {
            var usuario = await user.GetUsersAsync();
            if (usuario != null)
            {
                dataGridUser.DataSource = usuario;
            }
            else
            {
                MessageBox.Show("Error al cargar los datos.");
            }
        }
        
        private async void CargarDatosUsuarioEnPantalla()
        {
            string? idUsuarioSeleccionado = (string)dataGridUser.CurrentRow.Cells[0].Value;
            Users? usuario = await user.GetByIDAsync(idUsuarioSeleccionado);
            if (usuario != null)
            {
                txtEmail.Text = usuario.email;
                txtUsuario.Text = usuario.usuario;
                txtContraseña.Text = usuario.password;
                txtRol.Text = usuario.rol;
                EditMode = true;
            }
            else
            {
                MessageBox.Show("Error no se encontró el Usuario");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnEliminar_Click_1(object sender, EventArgs e)
        {
            //Obtener el id del anime seleccionado y su nombre
            string? idUsuarioSeleccionado = (string)dataGridUser.CurrentRow.Cells[0].Value;
            string? nombreUsuarioSeleccionado = (string)dataGridUser.CurrentRow.Cells[1].Value;
            //Mostramos su messagebox que pregunta si esta seguro que desea borrar
            DialogResult respuesta = MessageBox.Show($"¿Está seguro que quiere borrar el usuario {nombreUsuarioSeleccionado}?",
                "Eliminar Usuario",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            //Si el usuario seleccionó que quiere borrar, enviamos a borrar el anime, utilizando el id y el objeto repo.
            if (respuesta == DialogResult.Yes)
            {
                await user.DeleteAsync(idUsuarioSeleccionado);
                CargarUsuariosALaGrilla();
            }
        }

        private async void btnAgregarEditar_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                string? idUserSeleccionado = (string)dataGridUser.CurrentRow.Cells[0].Value;
                await user.PutAsync(txtEmail.Text,
                    txtContraseña.Text,
                    txtUsuario.Text,
                    txtRol.Text,
                    idUserSeleccionado);
                string? nombreUsuarioSeleccionado = (string)dataGridUser.CurrentRow.Cells[1].Value;
                lblNuevoAnime.Text = "Agregar Nuevo Usuario";
                btnAgregarEditar.Text = "Agregar";
                btnModificar.Visible = true;

            }
            else
            {
                await user.PostAsync(txtEmail.Text,
                    txtContraseña.Text,
                    txtUsuario.Text,
                    txtRol.Text);
            }
            VaciarInputs();
            CargarUsuariosALaGrilla(); // Refrescar la tabla después de agregar/editar
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string? idUsuarioSeleccionado = (string)dataGridUser.CurrentRow.Cells[0].Value;
            if (idUsuarioSeleccionado != null)
            {
                btnModificar.Visible = false;
                string? nombreUsuarioSeleccionado = (string)dataGridUser.CurrentRow.Cells[1].Value;
                lblNuevoAnime.Text = $"Esta modificando el usuario \"{nombreUsuarioSeleccionado}\"";
                CargarDatosUsuarioEnPantalla();
                btnAgregarEditar.Text = "Modificar";
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para modificar.");
            }
        }
        private void VaciarInputs()
        {
            txtEmail.Text = "";
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtRol.Text = "";
            EditMode = false;
        }
    }
}
