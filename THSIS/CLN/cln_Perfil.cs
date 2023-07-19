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
    public class cln_Perfil
    {
        public ResponseHelper ListarPerfil(String tipoConsulta, int perf_Id)
        {
            SqlTransaction sqlTransaction = null;
            SqlConnection sqlConnection = new SqlConnection(BasicVariable.cadena_conexion);
            ResponseHelper response = null;
            try
            {
                sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();
                cad_Perfil cad = new cad_Perfil();
                cad_Permiso cad_Permiso = new cad_Permiso();
                response = cad.ListarPerfil(tipoConsulta, perf_Id, sqlConnection, sqlTransaction);
                foreach (ent_Perfil perfil in (List<ent_Perfil>)response.response)
                {
                    perfil.lista_Permiso = (List<ent_Permiso>)cad_Permiso.ListarPermiso("PPE", perfil.perf_Id, sqlConnection, sqlTransaction).response;
                }
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
        
        public ResponseHelper RegistrarPerfil(String tipoConsulta, ent_Perfil perfil)
        {
            SqlTransaction sqlTransaction = null;
            SqlConnection sqlConnection = new SqlConnection(BasicVariable.cadena_conexion);
            ResponseHelper response = null;
            try
            {
                sqlConnection.Open();
                sqlTransaction = sqlConnection.BeginTransaction();

                cad_Perfil cad = new cad_Perfil();
                cad_Permiso cadPermiso = new cad_Permiso();
                response = cad.RegistrarPerfil(tipoConsulta, perfil, sqlConnection, sqlTransaction);
                if (tipoConsulta == "U")
                {
                    tipoConsulta = "I";
                }
                foreach (var permiso in perfil.lista_Permiso)
                {
                    cadPermiso.RegistrarPerfilPermiso("D", ((ent_Perfil)response.response).perf_Id, permiso.perm_Id, perfil.perf_Usuario, 0, sqlConnection, sqlTransaction);
                    cadPermiso.RegistrarPerfilPermiso(tipoConsulta, ((ent_Perfil)response.response).perf_Id, permiso.perm_Id, perfil.perf_Usuario,0, sqlConnection, sqlTransaction);
                }
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
