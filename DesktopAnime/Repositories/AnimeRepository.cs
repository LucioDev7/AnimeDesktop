using DesktopAnime.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAnime.Repositories
{
    public class AnimeRepository
    {
        string urlApi = "https://animes-e66d.restdb.io/rest/animes"; //URL
        HttpClient client = new HttpClient();

        //66611ec43973a32ab92964a1 APIKEY
        //link--https://animes-e66d.restdb.io/rest/animes?apikey=66611ec43973a32ab92964a1 URL CON APIKEY

        public AnimeRepository() //Constructor
        {
            client.DefaultRequestHeaders.Add("Accept", "application/json"); //Que trabaja con Json
            client.DefaultRequestHeaders.Add("apikey", "66611ec43973a32ab92964a1"); //Apikey
        }

        //GET: Utilizado para recuperar información del servidor.
        //POST: Utilizado para enviar datos al servidor para crear un nuevo recurso.
        //PUT: Utilizado para actualizar un recurso existente en el servidor.
        //DELETE: Utilizado para eliminar un recurso en el servidor.


        //Operación Get (Obtener todos los datos)
        public async Task<ObservableCollection<Anime>?> GetAnimesAsync()
        {
            var response = await client.GetStringAsync(urlApi);
            return JsonConvert.DeserializeObject<ObservableCollection<Anime>>(response);
        }

        //Operación Get (Obtener datos según una ID)
        public async Task<Anime?> GetByIDAsync(string id)
        {
            var response = await client.GetStringAsync($"{urlApi}/{id}");
            return JsonConvert.DeserializeObject<Anime>(response);

        }

        //Operacion Post
        public async Task<Anime?> PostAsync(string nombre, string tipo, string genero, string capitulo, string portada_url, string trailer_url, string ultimo_cap_url, int duracion, string sinopsis)
        {
            //Objeto con los parámetros que llegan
            Anime anime = new Anime()
            {
                nombre = nombre,
                tipo = tipo,
                capitulos = capitulo,
                genero = genero,
                portada_url = portada_url,
                trailer_url = trailer_url,
                ultimo_cap_url = ultimo_cap_url,
                duracion = duracion,
                sinopsis = sinopsis
            };

            //Envio por POST el objeto que creado a la URL de la API
            var librojson = new StringContent(JsonConvert.SerializeObject(anime), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(urlApi, librojson);

            //Retorno del objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Anime>(await response.Content.ReadAsStringAsync());
        }

        //Operacion Put
        public async Task<Anime?> PutAsync(string nombre, string tipo, string genero, string capitulo, string portada_url, string trailer_url, string ultimo_cap_url, int duracion, string sinopsis, string id)
        {
            Anime anime = new Anime()
            {
                nombre = nombre,
                tipo = tipo,
                capitulos = capitulo,
                genero = genero,
                portada_url = portada_url,
                trailer_url = trailer_url,
                ultimo_cap_url = ultimo_cap_url,
                duracion = duracion,
                sinopsis = sinopsis
            };

            //Envio por PUT del objeto que se creo a la URL de la API
            var librojson = new StringContent(
                    JsonConvert.SerializeObject(anime),
                    Encoding.UTF8, "application/json");

            var response = await client.PutAsync(urlApi + "/" + id, librojson);

            //Retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Anime>(
                await response.Content.ReadAsStringAsync());

        }

        //Operación Delete
        public async Task<bool> DeleteAsync(string id)
        {
            var response = await client.DeleteAsync(urlApi + "/" + id);
            return response.IsSuccessStatusCode; //Retorno de solitud HTTP
        }


    }
}
