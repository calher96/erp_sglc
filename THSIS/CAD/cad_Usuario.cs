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
    public class cad_Usuario
    {
        //public ResponseHelper guardarUsuario(ent_Usuario obj, String tipo, SqlConnection conn, SqlTransaction sqlTransaction)
        //{
        //    ResponseHelper response = null;

        //    response = new ResponseHelper();
        //    SqlCommand cmd = new SqlCommand("DEV.pa_Usuario_IUD", conn);
        //    cmd.Transaction = sqlTransaction;
        //    cmd.Parameters.Add(new SqlParameter("tipo", tipo));
        //    cmd.Parameters.Add(new SqlParameter("usua_Id", obj.Usua_Id));
        //    cmd.Parameters.Add(new SqlParameter("usua_Usuario", obj.Usua_Usuario));
        //    cmd.Parameters.Add(new SqlParameter("usua_Password", obj.Usua_Password));
        //    cmd.Parameters.Add(new SqlParameter("usua_Estado", obj.Usua_Estado));
        //    cmd.Parameters.Add(new SqlParameter("usua_Marcabaja", obj.Usua_Marcabaja));
        //    cmd.Parameters.Add(new SqlParameter("trab_Id", obj.Trab_Id));
        //    cmd.Parameters.Add(new SqlParameter("usua_UsuarioRegistro", obj.Usua_UsuarioRegistro));
        //    cmd.Parameters.Add(new SqlParameter("sucu_Id", obj.Sucu_Id));
        //    cmd.Parameters.Add(new SqlParameter("perf_Id", obj.Perf_Id));
        //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //    using (var reader = cmd.ExecuteReader())
        //    {
        //        while (reader.Read())
        //        {
        //            response.codError = (int)reader["codError"];
        //            response.mensajeError = (String)reader["Mensaje"];
        //            if (response.codError != -1)
        //            {
        //                response.response = (int)reader["usua_Id"];
        //            }
        //        }

        //    }


        //    return response;
        //}
        public ResponseHelper guardarUsuario(ent_Usuario obj, String tipo)
        {
            ResponseHelper response1 = null;
            string apiUrl = BasicVariable.webapi + "Usuario/iud?tipo=" + tipo;

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
                    else if (response.StatusCode == HttpStatusCode.BadRequest)
                    {
                        response1 = new ResponseHelper();
                        response1.codError = -1;
                        response1.mensajeError = "Ocurrió un error, comuníquese con el área de sistemas";
                    }
                    else if (response.StatusCode == HttpStatusCode.BadGateway)
                    {
                        response1 = new ResponseHelper();
                        response1.codError = -1;
                        response1.mensajeError = "Ocurrió un error, comuníquese con el área de sistemas";
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Se produjo un error al invocar el Web API: {ex.Message}");
                }
            }


            return response1;
        }
    }
}
