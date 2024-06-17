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
    public partial class DatosAnimesWindow : Form
    {
        //Variable estado modo edición
        private bool EditMode = false;
        private string idAnimeSeleccionado;


        AnimeRepository repo = new AnimeRepository();
        public DatosAnimesWindow()
        {
            InitializeComponent();
            CargarAnimesALaGrilla();
        }

        public DatosAnimesWindow(string idAnimeSeleccionado)
        {
            this.idAnimeSeleccionado = idAnimeSeleccionado;
            CargarAnimesALaGrilla();
        }
        
        private async void CargarAnimesALaGrilla()
        {
            var animes = await repo.GetAnimesAsync();
            if (animes != null)
            {
                dataGridAnime.DataSource = animes;
            }
            else
            {
                MessageBox.Show("Error al cargar los datos.");
            }
        }


        //public Datos(string idAnimeSeleccionado)
        //{
        //    this.idAnimeSeleccionado = idAnimeSeleccionado;
        //    CargarDatosAnimeEnPantalla();
        //}
        
        private async void CargarDatosAnimeEnPantalla()
        {
            string? idAnimeSeleccionado = (string)dataGridAnime.CurrentRow.Cells[0].Value;
            Anime? anime = await repo.GetByIDAnimeAsync(idAnimeSeleccionado);
            if (anime != null)
            {
                txtNombre.Text = anime.nombre;
                txtTipo.Text = anime.tipo;
                txtGenero.Text = anime.genero;
                txtPortada.Text = anime.portada_url;
                txtTrailer.Text = anime.trailer_url;
                txtUltimoCap.Text = anime.ultimo_cap_url;
                nudDuracion.Value = anime.duracion;
                txtCapitulos.Text = anime.capitulos;
                txtSinopsis.Text = anime.sinopsis;
                EditMode = true;
            }
            else
            {
                MessageBox.Show("Error no se encontró el Anime");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnEliminar_Click_1(object sender, EventArgs e)
        {
            //Obtener el id del anime seleccionado y su nombre
            string? idAnimeSeleccionado = (string)dataGridAnime.CurrentRow.Cells[0].Value;
            string? nombreAnimeSeleccionado = (string)dataGridAnime.CurrentRow.Cells[1].Value;
            //Mostramos su messagebox que pregunta si esta seguro que desea borrar
            DialogResult respuesta = MessageBox.Show($"¿Está seguro que quiere borrar el anime {nombreAnimeSeleccionado}?",
                "Eliminar Anime",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            //Si el usuario seleccionó que quiere borrar, enviamos a borrar el anime, utilizando el id y el objeto repo.
            if (respuesta == DialogResult.Yes)
            {
                await repo.DeleteAnimeAsync(idAnimeSeleccionado);
                CargarAnimesALaGrilla();
            }
        }

        private async void btnAgregarEditar_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                string? idAnimeSeleccionado = (string)dataGridAnime.CurrentRow.Cells[0].Value;
                await repo.PutAnimeAsync(txtNombre.Text,
                    txtTipo.Text,
                    txtGenero.Text,
                    txtCapitulos.Text,
                    txtPortada.Text,
                    txtTrailer.Text,
                    txtUltimoCap.Text,
                    (int)nudDuracion.Value,
                    txtSinopsis.Text,
                    idAnimeSeleccionado);
                string? nombreAnimeSeleccionado = (string)dataGridAnime.CurrentRow.Cells[1].Value;
                lblNuevoAnime.Text = "Agregar Nuevo Anime";
                btnAgregarEditar.Text = "Agregar";
                btnModificar.Visible = true;

            }
            else
            {
                await repo.PostAnimeAsync(txtNombre.Text,
                    txtTipo.Text,
                    txtGenero.Text,
                    txtCapitulos.Text,
                    txtPortada.Text,
                    txtTrailer.Text,
                    txtUltimoCap.Text,
                    (int)nudDuracion.Value,
                    txtSinopsis.Text);
            }
            VaciarInputs();
            CargarAnimesALaGrilla(); // Refrescar la tabla después de agregar/editar
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string? idAnimeSeleccionado = (string)dataGridAnime.CurrentRow.Cells[0].Value;
            if (idAnimeSeleccionado != null)
            {
                btnModificar.Visible = false;
                string? nombreAnimeSeleccionado = (string)dataGridAnime.CurrentRow.Cells[1].Value;
                lblNuevoAnime.Text = $"Esta modificando el anime \n \"{nombreAnimeSeleccionado}\"";
                CargarDatosAnimeEnPantalla();
                btnAgregarEditar.Text = "Modificar";
            }
            else
            {
                MessageBox.Show("Seleccione un anime para modificar.");
            }
        }
        private void VaciarInputs()
        {
            txtNombre.Text = "";
            txtTipo.Text = "";
            txtGenero.Text = "";
            txtCapitulos.Text = "";
            txtPortada.Text = "";
            txtTrailer.Text = "";
            txtUltimoCap.Text = "";
            nudDuracion.Value = 0;
            txtSinopsis.Text = "";
            EditMode = false;
        }
    }
}
