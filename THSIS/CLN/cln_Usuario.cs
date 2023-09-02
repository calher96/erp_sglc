using CAD;
using CEN.Entidad;
using CEN.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLN
{
    public class cln_Usuario
    {
        public ResponseHelper guardarUsuario(ent_Usuario obj, String tipoConsulta)
        {
            SqlTransaction sqlTransaction = null;
            SqlConnection sqlConnection = new SqlConnection(BasicVariable.cadena_conexion);
            ResponseHelper response = null;
            try
            {
                sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                cad_Usuario cad = new cad_Usuario();
                response = cad.guardarUsuario(obj, tipoConsulta, sqlConnection, sqlTransaction);

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
