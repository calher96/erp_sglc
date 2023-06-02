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
    public class cad_Concepto
    {
        public List<ent_Concepto> listarConcepto(int conc_Prefijo)
        {
            List<ent_Concepto> lista = null;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(BasicVariable.cadena_conexion);
                conn.Open();
                SqlCommand cmd = new SqlCommand("DEV.pa_ObtenerConcepto", conn);
                cmd.Parameters.Add(new SqlParameter("conc_Prefijo", conc_Prefijo));
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                lista = new List<ent_Concepto>();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ent_Concepto obj = new ent_Concepto();
                        obj.conc_Prefijo = (int)reader["conc_Prefijo"];
                        obj.conc_Correlativo = (int)reader["conc_Correlativo"];
                        obj.conc_Descripcion = (String)reader["conc_Descripcion"];
                        obj.conc_Abreviatura = (String)reader["conc_Abreviatura"];                        
                        lista.Add(obj);
                    }

                }
            }
            finally 
            { 
                if(conn != null) { conn.Close(); }
            }
            return lista;
        }
    }
}
