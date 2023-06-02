using CEN.Entidad;
using CEN.Helpers;
using System.Data.SqlClient;

namespace CAD
{
    public class cad_ControlError
    {
        public void registrarError(ent_ControlError obj)
        {
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(BasicVariable.cadena_conexion);
                SqlCommand cmd = new SqlCommand("DEV.pa_RegistrarError", conn);
                cmd.Parameters.Add(new SqlParameter("cerr_Formulario", obj.Cerr_Formulario));
                cmd.Parameters.Add(new SqlParameter("cerr_MensajeError", obj.Cerr_MensajeError));
                cmd.Parameters.Add(new SqlParameter("cerr_Traza", obj.Cerr_Traza));
                cmd.Parameters.Add(new SqlParameter("cerr_Usuario", obj.Cerr_Usuario));
                cmd.Parameters.Add(new SqlParameter("cerr_Trama", obj.Cerr_Trama));
                cmd.Parameters.Add(new SqlParameter("cerr_FechaError", obj.Cerr_FechaError));
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                using (var reader = cmd.ExecuteReader())
                {
                }
            }
            finally  
            {
                if (conn != null) { conn.Close(); }
            } 
        }
    }
}