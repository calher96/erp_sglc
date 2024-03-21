using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CEN;
using CEN.Helpers;
using CEN.Response;
using Newtonsoft.Json;

namespace CAD
{
    public class cad_Vehiculo
    {
        public List<ent_Vehiculo> ListarVehiculo(ent_Vehiculo request, String tipo)
        {
            List<ent_Vehiculo> lista = new List<ent_Vehiculo>();
            ResponseHelper response1 = null;
            string apiUrl = BasicVariable.webapi + "Vehiculo/listar?tipo=" + tipo;

            // Crear una instancia de HttpClient
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", StaticVariable.token);

                    // Crear un objeto JSON con usuario y contraseña


                    // Serializar el objeto JSON a una cadena JSON
                    string jsonRequestBody = Newtonsoft.Json.JsonConvert.SerializeObject(request);

                    // Crear el contenido de la solicitud POST
                    var content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");

                    // Realizar una solicitud POST al Web API de forma sincrónica
                    HttpResponseMessage response = httpClient.PostAsync(apiUrl, content).Result;

                    // Comprobar si la solicitud fue exitosa
                    if (response.IsSuccessStatusCode)
                    {
                        // Leer y mostrar la respuesta del Web API
                        string responseBody = response.Content.ReadAsStringAsync().Result;
                        Console.WriteLine("Respuesta del Web API:");
                        Console.WriteLine(responseBody);
                        PrincipalResponse responseFinal = JsonConvert.DeserializeObject<PrincipalResponse>(responseBody);
                        response1 = new ResponseHelper();
                        response1.codError = responseFinal.CodError;
                        response1.mensajeError = responseFinal.MensajeError;
                        if (response1.codError == 0)
                        {
                            //responseFinal.Response = (responseFinal.Response.ToString()).Substring(1, (responseFinal.Response.ToString()).Length - 2);
                            response1.response = JsonConvert.DeserializeObject<List<ent_Vehiculo>>(responseFinal.Response.ToString());
                        }

                    }
                    else if (response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        response1 = new ResponseHelper();
                        response1.codError = 401;
                        response1.mensajeError = "Por favor, vuelva a iniciar sesión";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Se produjo un error al invocar el Web API: {ex.Message}");
                }
            }
            return (List<ent_Vehiculo>)response1.response;
        }
    }
}
