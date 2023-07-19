using CEN.Entidad;
using CEN.Helpers;
using System.Data.SqlClient;

namespace CAD
{
    public class cad_Permiso
    {
        public ResponseHelper ListarPermiso(String tipoConsulta, int perf_Id,SqlConnection conn, SqlTransaction sqlTransaction) 
        {
            ResponseHelper response = null;
            List<ent_Permiso> lista = new List<ent_Permiso>();
            response = new ResponseHelper();
            SqlCommand cmd = new SqlCommand("DEV.pa_Permiso_LISTAR", conn);
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
                        ent_Permiso permiso = new ent_Permiso();
                        permiso.perm_Id = (int)reader["perm_Id"];
                        permiso.perm_Titulo = (String)reader["perm_Titulo"];
                        permiso.empr_Id = (int)reader["empr_Id"];
                        permiso.perm_OrdenPrincipal = (int)reader["perm_OrdenPrincipal"];
                        permiso.perm_OrdenPadre = (int)reader["perm_OrdenPadre"];
                        permiso.perm_OrdenHijo = (int)reader["perm_OrdenHijo"];
                        permiso.perm_OrdenSubHijo = (int)reader["perm_OrdenSubHijo"];
                        permiso.perm_Control = (String)reader["perm_Control"];
                        lista.Add(permiso);
                        
                    }
                }
                response.response = lista;
            }
            return response;
        }

        public ResponseHelper RegistrarPerfilPermiso(String tipoConsulta, int perf_Id, int perm_Id, String rela_Usuario, int rela_Marcabaja, SqlConnection conn, SqlTransaction sqlTransaction)
        {
            ResponseHelper response = null;
            List<ent_Permiso> lista = new List<ent_Permiso>();
            response = new ResponseHelper();
            SqlCommand cmd = new SqlCommand("DEV.pa_PerfilPermiso_IUD", conn);
            cmd.Transaction = sqlTransaction;
            cmd.Parameters.Add(new SqlParameter("tipo", tipoConsulta));
            cmd.Parameters.Add(new SqlParameter("perm_Id", perm_Id));
            cmd.Parameters.Add(new SqlParameter("perf_Id", perf_Id));
            cmd.Parameters.Add(new SqlParameter("rela_Usuario", rela_Usuario));
            cmd.Parameters.Add(new SqlParameter("rela_Marcabaja", rela_Marcabaja));
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    response.codError = (int)reader["codError"];
                    response.mensajeError = (String)reader["mensajeError"];
                }
            }
            return response;
        }
    }
}
