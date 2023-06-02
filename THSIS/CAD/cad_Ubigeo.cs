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
    public class cad_Ubigeo
    {
        public List<ent_Ubigeo> listarUbigeo(int todos, String dept_Ubigeo, String prov_Ubigeo, String dist_Ubigeo)
        {
            List<ent_Ubigeo> lista = null;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(BasicVariable.cadena_conexion);
                conn.Open();
                SqlCommand cmd = new SqlCommand("DEV.pa_ObtenerUbigeo", conn);
                cmd.Parameters.Add(new SqlParameter("todos", todos));
                cmd.Parameters.Add(new SqlParameter("dept_Ubigeo", dept_Ubigeo));
                cmd.Parameters.Add(new SqlParameter("prov_Ubigeo", prov_Ubigeo));
                cmd.Parameters.Add(new SqlParameter("dist_Ubigeo", dist_Ubigeo));
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                lista = new List<ent_Ubigeo>();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ent_Ubigeo obj = new ent_Ubigeo();
                        obj.Ubigeo = (String)reader["Ubigeo"];
                        obj.Descripcion = (String)reader["Descripcion"];
                        obj.Referencia = (String)reader["Referencia"];
                        lista.Add(obj);
                    }

                }
            }
            finally
            {
                if (conn != null) { conn.Close(); }
            }
            return lista;
        }
    }
}
