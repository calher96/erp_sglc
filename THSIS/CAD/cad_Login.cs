using System.Data.SqlClient;
using System.Text;
using CEN.Entidad;
using CEN.Helpers;
using CEN.Response;
using Newtonsoft.Json;

namespace CAD
{
    public class cad_Login
    {
        public ResponseHelper IniciarSesion(ent_Usuario User)
        {
            ResponseHelper response1 = null;
            
            string apiUrl = BasicVariable.webapi + "Login/IniciarSesion";

            // Crear una instancia de HttpClient
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    // Crear un objeto JSON con usuario y contraseña
                    var loginData = new
                    {
                        Usuario = User.Usua_Usuario,
                        Password = User.Usua_Password
                    };

                    // Serializar el objeto JSON a una cadena JSON
                    string jsonRequestBody = Newtonsoft.Json.JsonConvert.SerializeObject(loginData);

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
                        if(response1.codError == 0)
                        {
                            //responseFinal.Response = (responseFinal.Response.ToString()).Substring(1, (responseFinal.Response.ToString()).Length - 2);
                            response1.response = JsonConvert.DeserializeObject<LoginResponse>(responseFinal.Response.ToString());
                        }
                        
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
                return response1;
            }
        }
    }
}