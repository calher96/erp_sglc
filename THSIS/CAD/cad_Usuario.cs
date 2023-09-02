using CEN.Entidad;
using CEN.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class cad_Usuario
    {
        public ResponseHelper guardarUsuario(ent_Usuario obj, String tipo, SqlConnection conn, SqlTransaction sqlTransaction)
        {
            ResponseHelper response = null;

            response = new ResponseHelper();
            SqlCommand cmd = new SqlCommand("DEV.pa_Usuario_IUD", conn);
            cmd.Transaction = sqlTransaction;
            cmd.Parameters.Add(new SqlParameter("tipo", tipo));
            cmd.Parameters.Add(new SqlParameter("usua_Id", obj.Usua_Id));
            cmd.Parameters.Add(new SqlParameter("usua_Usuario", obj.Usua_Usuario));
            cmd.Parameters.Add(new SqlParameter("usua_Password", obj.Usua_Password));
            cmd.Parameters.Add(new SqlParameter("usua_Estado", obj.Usua_Estado));
            cmd.Parameters.Add(new SqlParameter("usua_Marcabaja", obj.Usua_Marcabaja));
            cmd.Parameters.Add(new SqlParameter("trab_Id", obj.Trab_Id));
            cmd.Parameters.Add(new SqlParameter("usua_UsuarioRegistro", obj.Usua_UsuarioRegistro));
            cmd.Parameters.Add(new SqlParameter("sucu_Id", obj.Sucu_Id));
            cmd.Parameters.Add(new SqlParameter("perf_Id", obj.Perf_Id));
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    response.codError = (int)reader["codError"];
                    response.mensajeError = (String)reader["Mensaje"];
                    if (response.codError != -1)
                    {
                        response.response = (int)reader["usua_Id"];
                    }
                }

            }


            return response;
        }
    }
}
