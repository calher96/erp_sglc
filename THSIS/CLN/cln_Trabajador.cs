using CAD;
using CEN.Entidad;
using CEN.Helpers;
using System.Data.SqlClient;

namespace CLN
{
    public class cln_Trabajador
    {
        public ResponseHelper guardarTrabajador(ent_Trabajador obj)
        {
            ResponseHelper response = null;
            try
            {
                cad_Trabajador cad = new cad_Trabajador();
                response = cad.guardarTrabajador(obj);
                return response;
            }
            catch(Exception)
            {
                throw;
            }

        }
        public List<ent_Trabajador> ListarTrabajador(ent_Trabajador obj)
        {
            SqlTransaction sqlTransaction = null;
            SqlConnection sqlConnection = new SqlConnection(BasicVariable.cadena_conexion);
            List<ent_Trabajador> response = null;
            try
            {
                sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                cad_Trabajador cad = new cad_Trabajador();
                response = cad.listarTrabajador(obj, sqlConnection, sqlTransaction);

                sqlTransaction.Commit();
                return response;
            }
            catch (Exception)
            {
                if (sqlTransaction != null)
                {
                    sqlTransaction.Rollback();
                }
                throw;
            }
            finally
            {
                if (sqlConnection != null) { sqlConnection.Close(); }
            }

        }
    }
}
