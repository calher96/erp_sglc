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
            SqlTransaction sqlTransaction = null;
            SqlConnection sqlConnection = new SqlConnection(BasicVariable.cadena_conexion);
            ResponseHelper response = null;
            try
            {
                sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                cad_Trabajador cad = new cad_Trabajador();
                response = cad.guardarTrabajador(obj, sqlConnection, sqlTransaction);
                if (obj.corr_Correo != "") 
                {
                    cad.guardarDatosTrabajador((int)response.response, obj.corr_Correo, 1, sqlConnection, sqlTransaction);
                }
                if (obj.celu_Celular != "")
                {
                    cad.guardarDatosTrabajador((int)response.response, obj.celu_Celular, 2, sqlConnection, sqlTransaction);
                }
                if (obj.telf_Telefono != "")
                {
                    cad.guardarDatosTrabajador((int)response.response, obj.telf_Telefono, 3, sqlConnection, sqlTransaction);
                }
                if (obj.dire_Direccion != "")
                {
                    cad.guardarDatosTrabajador((int)response.response, obj.dire_Direccion, 4, sqlConnection, sqlTransaction);
                }
                sqlTransaction.Commit();
                return response;
            }
            catch(Exception)
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
