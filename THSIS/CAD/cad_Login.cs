using System.Data.SqlClient;
using CEN.Entidad;
using CEN.Helpers;
namespace CAD
{
    public class cad_Login
    {
        public ResponseHelper IniciarSesion(ent_Usuario User)
        {
            SqlConnection conn = null;
            ResponseHelper response = null;
            try
            {
                ent_Usuario usuario;
                response = new ResponseHelper();
                conn = new SqlConnection(BasicVariable.cadena_conexion);
                conn.Open();
                SqlCommand cmd = new SqlCommand("DEV.pa_IniciarSesion", conn);
                cmd.Parameters.Add(new SqlParameter("usuario", User.Usua_Usuario));
                cmd.Parameters.Add(new SqlParameter("password", User.Usua_Password));
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        response.codError = (int)reader["codError"];
                        response.mensajeError = (String)reader["Mensaje"];
                        if (response.codError == 0)
                        {
                            usuario = new ent_Usuario();
                            usuario.Usua_Id = (int)reader["usua_Id"];
                            usuario.Usua_Usuario = (String)reader["usua_Usuario"];
                            usuario.Usua_Estado = (int)reader["usua_Estado"];
                            usuario.Trab_Id = (int)reader["trab_Id"];
                            usuario.Perf_Id = (int)reader["perf_Id"];
                            StaticVariable.obj_Usuario = usuario;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn != null) { conn.Close(); }
            }

            return response;
        }
    }
}