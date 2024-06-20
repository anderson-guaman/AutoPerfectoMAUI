using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using AutoPerfectoMAUI.Models;
using System.Text.Json;
using System.Net.Http.Headers;
namespace Pokemones.Services
{
    internal class AutosServices
    {
        public async Task<List<Auto>> GetAutos()
        {
            try
            {
                string url = "https://localhost:7095/api/Autos";
                HttpClient client = new HttpClient();
                string json = await client.GetStringAsync(url);
                List<Auto> autos = JsonConvert.DeserializeObject<List<Auto>>(json);
                Debug.WriteLine("SII");
                Debug.WriteLine(json);
                return autos;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error: {ex.Message}");
                return new List<Auto>();
            }
            
        }
        public async void ActualizarAuto(Auto auto)
        {
            string apiBaseUrl = "https://localhost:7095/api/Autos";
            var url = $"{apiBaseUrl}/{auto.Id}";
            HttpClient _httpClient = new HttpClient();
            // Serializar el objeto Auto a JSON
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

            var json = System.Text.Json.JsonSerializer.Serialize(auto, options);
            var content = new StringContent(json, Encoding.UTF8, new MediaTypeHeaderValue("application/json"));

            // Enviar la solicitud PUT a la API
            var response = await _httpClient.PutAsync(url, content);

            // Manejar la respuesta de la API
            if (response.IsSuccessStatusCode)
            {
                // La actualización fue exitosa
                // Manejo del éxito, podría ser logging u otro procesamiento
            }
            else
            {
                // Hubo un error al actualizar el auto
                var errorMessage = await response.Content.ReadAsStringAsync();
                // Manejo del error, podría ser logging u otro procesamiento
                throw new ApplicationException($"Error actualizando el auto: {errorMessage}");
            }
        }

    }
}
