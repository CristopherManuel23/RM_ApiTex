using Newtonsoft.Json;
using RM_APItex.Model;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace RM_APItex.Controler
{
    
    public class CharacterControler
    {
        private HttpClient Client;

        public CharacterControler()
        {
            Client = new HttpClient();
        }

        public async Task<Characteres> GetCharactersAsync() //Metodo asincrono que devuelve un objeto de tipo characteres
        {
            try
            {
                Characteres characters = new Characteres(); //Instancia de la clase

                // Se realiza la solicitu Get a la api de Rick and Morty
                HttpResponseMessage response = await Client.GetAsync("https://rickandmortyapi.com/api/character");

                response.EnsureSuccessStatusCode(); // Verifica que la respuesta sea exitosa

                string responseJson = await response.Content.ReadAsStringAsync();// Se obtiene el contenido de la respuesta en formato json

                characters = JsonConvert.DeserializeObject<Characteres>(responseJson); // Se deserializa el Json obtenido y se Convierte
                
                return characters;
            }
            catch
            {
                return null;
            }
            
        }
    }
}
