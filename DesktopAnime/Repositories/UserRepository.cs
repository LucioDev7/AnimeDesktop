using DesktopAnime.Models;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopAnime.Repositories
{   public class UserRepository
    {
        string urlApi = "https://usuarios-0d57.restdb.io/rest/usuarios"; //URL
        HttpClient client = new HttpClient();

        //6661fa51adca367e29833ea6 APIKEY
        //link--https://usuarios-0d57.restdb.io/rest/usuarios?apikey=6661fa51adca367e29833ea6 URL CON APIKEY

        public UserRepository() //Constructor
        {
            client.DefaultRequestHeaders.Add("Accept", "application/json"); //Que trabaja con Json
            client.DefaultRequestHeaders.Add("apikey", "6661fa51adca367e29833ea6"); //Apikey
        }

        //GET: Utilizado para recuperar información del servidor.
        //POST: Utilizado para enviar datos al servidor para crear un nuevo recurso.
        //PUT: Utilizado para actualizar un recurso existente en el servidor.
        //DELETE: Utilizado para eliminar un recurso en el servidor.


        //Operación Get (Obtener todos los datos)
        public async Task<ObservableCollection<Users>?> GetUsersAsync()
        {
            var response = await client.GetStringAsync(urlApi);
            return JsonConvert.DeserializeObject<ObservableCollection<Users>>(response);
        }

        //Operación Get (Obtener datos según una ID)
        public async Task<Users?> GetByIDAsync(string idAutomatico)
        {
            var response = await client.GetStringAsync($"{urlApi}/{idAutomatico}");
            return JsonConvert.DeserializeObject<Users>(response);

        }


        //Operacion Post
        public async Task<Users?> PostAsync(string email, string password, string usuario, string rol)
        {
            //Objeto con los parámetros que llegan
            Users user = new Users()
            {
                email = email,
                password = password,
                usuario = usuario,
                rol = rol
            };

            //Envio por POST el objeto que creado a la URL de la API
            var usuariojson = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(urlApi, usuariojson);

            //Retorno del objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Users>(await response.Content.ReadAsStringAsync());
        }

        //Operacion Put
        public async Task<Users?> PutAsync(string email, string password, string usuario, string rol, string idAutomatico)
        {
            Users user = new Users()
            {
                email = email,
                password = password,
                usuario = usuario,
                rol = rol
            };

            //Envio por PUT del objeto que se creo a la URL de la API
            var usuariojson = new StringContent(
                    JsonConvert.SerializeObject(user),
                    Encoding.UTF8, "application/json");

            var response = await client.PutAsync(urlApi + "/" + idAutomatico, usuariojson);

            //Retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Users>(
                await response.Content.ReadAsStringAsync());

        }

        //SDelete
        public async Task<bool> DeleteAsync(string idAutomatico)
        {
            var response = await client.DeleteAsync(urlApi + "/" + idAutomatico);
            return response.IsSuccessStatusCode; //Retorno de solitud HTTP
        }

        public async Task<bool> VerifyCredentialsAsync(string emailUsuario, string password)
        {
            //Traemos los datos
            var users = await GetUsersAsync(); 
            //Verificamos si alguna elemento de la condicion cumple con las condiciones.
            //Usamos el metodo de extensión LINQ Any, que verifica si al menos  un elemento
            //de la colección cumple con la condición
            //en caso de que el elemento sea null devolvemos false (?? false)
            return users?.Any(user => (user.email == emailUsuario || user.usuario == emailUsuario) && user.password == password) ?? false;
        }

        // Obtenemos los datos del usuario según el nombre de usuario o email
        public async Task<Users?> GetUserDataAsync(string username)
        {
            // URL para buscar usuarios por nombre de usuario o email
            string qUrl = $"{urlApi}?q={{\"$or\":[{{\"usuario\":\"{username}\"}},{{\"email\":\"{username}\"}}]}}";

            var response = await client.GetStringAsync(qUrl);

            // Deserializar la respuesta en una lista de usuarios
            var users = JsonConvert.DeserializeObject<List<Users>>(response);

            // Retornar el primer usuario encontrado
            return users?.FirstOrDefault();
        }

    }
}
