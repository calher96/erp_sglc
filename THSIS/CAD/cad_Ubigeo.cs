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
using CEN.Request;

namespace CAD
{
    public class cad_Ubigeo
    {
        //public List<ent_Ubigeo> listarUbigeo(int todos, String dept_Ubigeo, String prov_Ubigeo, String dist_Ubigeo)
        //{
        //    List<ent_Ubigeo> lista = null;
        //    SqlConnection conn = null;
        //    try
        //    {
        //        conn = new SqlConnection(BasicVariable.cadena_conexion);
        //        conn.Open();
        //        SqlCommand cmd = new SqlCommand("DEV.pa_ObtenerUbigeo", conn);
        //        cmd.Parameters.Add(new SqlParameter("todos", todos));
        //        cmd.Parameters.Add(new SqlParameter("dept_Ubigeo", dept_Ubigeo));
        //        cmd.Parameters.Add(new SqlParameter("prov_Ubigeo", prov_Ubigeo));
        //        cmd.Parameters.Add(new SqlParameter("dist_Ubigeo", dist_Ubigeo));
        //        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //        lista = new List<ent_Ubigeo>();
        //        using (var reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                ent_Ubigeo obj = new ent_Ubigeo();
        //                obj.Ubigeo = (String)reader["Ubigeo"];
        //                obj.Descripcion = (String)reader["Descripcion"];
        //                obj.Referencia = (String)reader["Referencia"];
        //                lista.Add(obj);
        //            }

        //        }
        //    }
        //    finally
        //    {
        //        if (conn != null) { conn.Close(); }
        //    }
        //    return lista;
        //}
        public List<ent_Ubigeo> listarUbigeo(UbigeoRequest obj)
        {
            List<UbigeoResponse> lista = new List<UbigeoResponse>();
            ResponseHelper response1 = null;
            string apiUrl = BasicVariable.webapi + "Ubigeo/Buscar";

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
                            response1.response = JsonConvert.DeserializeObject<List<ent_Ubigeo>>(responseFinal.Response.ToString());
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
            return (List<ent_Ubigeo>)response1.response;
        }
    }
}
