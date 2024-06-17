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
using DesktopAnime.Properties;
using System.Resources;

namespace DesktopAnime
{
    public partial class TrailersWindow : Form
    {
        AnimeRepository repo = new AnimeRepository();
        private WebView2 webView;
        public TrailersWindow()
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
            string videoUrl = anime.trailer_url;
            string? nombreAnimeSeleccionado = (string)dataGridAnime.CurrentRow.Cells[1].Value;
            lblTrailer.Text = $"Visualizando trailer del anime: \"{nombreAnimeSeleccionado}\"";


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
                // Convertir la URL al formato de inserción
                string videoId = GetYouTubeVideoId(videoUrl);
                if (!string.IsNullOrEmpty(videoId))
                {
                    string embedUrl = $"https://www.youtube.com/embed/{videoId}";
                    webView.Source = new Uri(embedUrl);
                }
                else
                {
                    MessageBox.Show("URL de YouTube no válida.", "URL no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Este anime no cuenta con trailer cargado.", "URL no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private string GetYouTubeVideoId(string url)
        {
            var uri = new Uri(url);
            var query = System.Web.HttpUtility.ParseQueryString(uri.Query);
            return query["v"];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
