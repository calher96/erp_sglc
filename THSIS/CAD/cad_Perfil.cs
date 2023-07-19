using CEN.Entidad;
using CEN.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAD
{
    public class cad_Perfil
    {
        public ResponseHelper RegistrarPerfil(String tipoConsulta, ent_Perfil perfil, SqlConnection conn, SqlTransaction sqlTransaction)
        {
            ResponseHelper response = new ResponseHelper();
            SqlCommand cmd = new SqlCommand("DEV.pa_Perfil_IUD", conn);
            cmd.Transaction = sqlTransaction;
            cmd.Parameters.Add(new SqlParameter("tipo", tipoConsulta));
            cmd.Parameters.Add(new SqlParameter("perf_Id", perfil.perf_Id));
            cmd.Parameters.Add(new SqlParameter("perf_Nombre", perfil.perf_Nombre));
            cmd.Parameters.Add(new SqlParameter("perf_Estado", perfil.perf_Estado));
            cmd.Parameters.Add(new SqlParameter("empr_Id", perfil.empr_Id));
            cmd.Parameters.Add(new SqlParameter("perf_Marcabaja", perfil.perf_Marcabaja));
            cmd.Parameters.Add(new SqlParameter("usuario", perfil.perf_Usuario));
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    response.codError = (int)reader["codError"];
                    response.mensajeError = (String)reader["mensajeError"];
                    if (response.codError != -1)
                    {
                        perfil.perf_Id = Convert.ToInt32(reader["perf_Id"].ToString());

                    }
                }
                response.response = perfil;
            }
            return response;
        }
        public ResponseHelper ListarPerfil(String tipoConsulta, int perf_Id, SqlConnection conn, SqlTransaction sqlTransaction)
        {
            ResponseHelper response = null;
            List<ent_Perfil> lista = new List<ent_Perfil>();
            response = new ResponseHelper();
            SqlCommand cmd = new SqlCommand("DEV.pa_Perfil_LISTAR", conn);
            cmd.Transaction = sqlTransaction;
            cmd.Parameters.Add(new SqlParameter("tipo", tipoConsulta));
            cmd.Parameters.Add(new SqlParameter("perf_Id", perf_Id));
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    response.codError = 0;
                    response.mensajeError = "Proceso Exitoso";
                    if (response.codError != -1)
                    {
                        ent_Perfil perfil = new ent_Perfil();
                        perfil.perf_Id = (int)reader["perf_Id"];
                        perfil.perf_Nombre = (String)reader["perf_Nombre"];
                        perfil.empr_Id = (int)reader["empr_Id"];
                        perfil.perf_Estado = (int)reader["perf_Estado"];
                        perfil.perf_EstadoDescripcion = (String)reader["perf_EstadoDescripcion"];
                        lista.Add(perfil);

                    }
                }
                response.response = lista;
            }
            return response;
        }
    }
}
