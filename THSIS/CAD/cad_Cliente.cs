using CEN;
using CEN.Entidad;
using CEN.Helpers;
using CEN.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class cad_Cliente
    {
        public ResponseHelper guardarCliente(ent_Cliente obj, String tipo)
        {
            ResponseHelper response1 = null;
            string apiUrl = BasicVariable.webapi + "Cliente/iud?=tipo="+tipo;

            // Crear una instancia de HttpClient
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", StaticVariable.token);

                    // Crear un objeto JSON con usuario y contraseña


                    // Serializar el objeto JSON a una cadena JSON
                    string jsonRequestBody = Newtonsoft.Json.JsonConvert.SerializeObject(obj);

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
                            response1.response = Convert.ToInt32(responseFinal.Response);
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


            return response1;
        }
        public List<ent_Cliente> listarCliente(ent_Cliente obj, String tipo)
        {
            List<ent_Trabajador> lista = new List<ent_Trabajador>();
            ResponseHelper response1 = null;
            string apiUrl = BasicVariable.webapi + "Cliente/listar?tipo="+tipo;

            // Crear una instancia de HttpClient
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", StaticVariable.token);

                    // Crear un objeto JSON con usuario y contraseña


                    // Serializar el objeto JSON a una cadena JSON
                    string jsonRequestBody = Newtonsoft.Json.JsonConvert.SerializeObject(obj);

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
                            response1.response = JsonConvert.DeserializeObject<List<ent_Cliente>>(responseFinal.Response.ToString());
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
            return (List<ent_Cliente>)response1.response;
        }
    }
}
