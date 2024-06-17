using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.WinForms;
using DesktopAnime.Repositories;
using DesktopAnime.Models;

namespace DesktopAnime
{
    public partial class CapitulosWindow : Form
    {
        AnimeRepository repo = new AnimeRepository();
        private WebView2 webView;
        public CapitulosWindow()
        {
            InitializeComponent();
            SetupDataGridView();
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

        private void SetupDataGridView()
        {
            dataGridAnime.AutoGenerateColumns = false;


            dataGridAnime.Columns.Add("_id", "ID");
            dataGridAnime.Columns["_id"].DataPropertyName = "_id";

            dataGridAnime.Columns.Add("nombre", "Nombre");
            dataGridAnime.Columns["nombre"].DataPropertyName = "nombre";

            dataGridAnime.Columns.Add("tipo", "Tipo");
            dataGridAnime.Columns["tipo"].DataPropertyName = "tipo";

        }

        private async void btnSelect_Click(object sender, EventArgs e)
        {
            string? idAnimeSeleccionado = (string)dataGridAnime.CurrentRow.Cells[0].Value;
            var anime = await repo.GetByIDAnimeAsync(idAnimeSeleccionado);
            string videoUrl = anime.ultimo_cap_url;

            string? nombreAnimeSeleccionado = (string)dataGridAnime.CurrentRow.Cells[1].Value;
            lblCapitulo.Text = $"Visualizando ultimo capítulo del anime: \"{nombreAnimeSeleccionado}\"";


            // Crear una instancia del control WebView2
            webView = new WebView2
            {
                Dock = DockStyle.Fill
            };

            // Agregar el control WebView2 al panel
            this.panelVideo.Controls.Add(webView);

            // Inicializar el control WebView2
            await webView.EnsureCoreWebView2Async(null);

            // Verificar si la URL no está vacía
            if (!string.IsNullOrEmpty(videoUrl))
            {
                // Navegar a la URL del video
                webView.Source = new Uri(videoUrl);
            }
            else
            {
                MessageBox.Show("Url del ultimo capitulo no encontrada.", "URL no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
