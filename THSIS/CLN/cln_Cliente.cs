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
    public class cln_Cliente
    {
        public ResponseHelper guardarTrabajador(ent_Cliente obj)
        {
            SqlTransaction sqlTransaction = null;
            SqlConnection sqlConnection = new SqlConnection(BasicVariable.cadena_conexion);
            ResponseHelper response = null;
            try
            {
                sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                cad_Cliente cad = new cad_Cliente();
                response = cad.guardarCliente(obj, "I", sqlConnection, sqlTransaction);
                
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

        public List<ent_Cliente> ListarCliente(ent_Cliente obj)
        {
            SqlTransaction sqlTransaction = null;
            SqlConnection sqlConnection = new SqlConnection(BasicVariable.cadena_conexion);
            List<ent_Cliente> response = null;
            try
            {
                sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                cad_Cliente cad = new cad_Cliente();
                response = cad.listarCliente(obj, sqlConnection, sqlTransaction);

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
