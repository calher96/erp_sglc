using CEN.Entidad;
using CEN.Helpers;
using CEN.Response;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Text;

namespace CAD
{
    public class cad_ControlError
    {
        public void registrarError(ent_ControlError request)
        {
            ResponseHelper response1 = null;
            string apiUrl = BasicVariable.webapi + "ControlError/iud";

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
                        //// Leer y mostrar la respuesta del Web API
                        //string responseBody = response.Content.ReadAsStringAsync().Result;
                        //Console.WriteLine("Respuesta del Web API:");
                        //Console.WriteLine(responseBody);
                        //PrincipalResponse responseFinal = JsonConvert.DeserializeObject<PrincipalResponse>(responseBody);
                        //response1 = new ResponseHelper();
                        //response1.codError = responseFinal.CodError;
                        //response1.mensajeError = responseFinal.MensajeError;
                        //if (response1.codError == 0)
                        //{
                        //    //responseFinal.Response = (responseFinal.Response.ToString()).Substring(1, (responseFinal.Response.ToString()).Length - 2);
                        //    response1.response = JsonConvert.DeserializeObject<List<ent_Concepto>>(responseFinal.Response.ToString());
                        //}

                    }
                    else
                    {
                        Console.WriteLine($"La solicitud al Web API falló con el código: {response.StatusCode}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Se produjo un error al invocar el Web API: {ex.Message}");
                }
            }
            //return (List<ent_Concepto>)response1.response;
        }
    }
}