using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAnime.Models
{
    public class Anime
    {
        public string _id { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public string genero { get; set; }
        public string capitulos { get; set; }
        public string portada_url { get; set; }
        public string trailer_url { get; set; }
        public string ultimo_cap_url { get; set; }
        public string sinopsis { get; set; }
        public int duracion { get; set; }
    }
}
