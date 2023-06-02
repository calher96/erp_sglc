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
    public class cad_Cliente
    {
        public ResponseHelper guardarCliente(ent_Cliente obj, String tipo, SqlConnection conn, SqlTransaction sqlTransaction)
        {
            ResponseHelper response = null;

            response = new ResponseHelper();
            SqlCommand cmd = new SqlCommand("DEV.pa_Cliente_IUD", conn);
            cmd.Transaction = sqlTransaction;
            cmd.Parameters.Add(new SqlParameter("tipo", tipo));
            cmd.Parameters.Add(new SqlParameter("clie_Id", "0"));
            cmd.Parameters.Add(new SqlParameter("clie_TipoDocumento", obj.Clie_TipoDocumento));
            cmd.Parameters.Add(new SqlParameter("clie_Documento", obj.Clie_Documento));
            cmd.Parameters.Add(new SqlParameter("clie_TipoPersona", obj.Clie_TipoPersona));
            cmd.Parameters.Add(new SqlParameter("clie_RazonSocial", obj.Clie_RazonSocial));
            cmd.Parameters.Add(new SqlParameter("clie_Nombres", obj.Clie_Nombres));
            cmd.Parameters.Add(new SqlParameter("clie_ApellidoPaterno", obj.Clie_ApellidoPaterno));
            cmd.Parameters.Add(new SqlParameter("clie_ApellidoMaterno", obj.Clie_ApellidoMaterno));
            cmd.Parameters.Add(new SqlParameter("clie_Sexo", obj.Clie_Sexo));
            cmd.Parameters.Add(new SqlParameter("clie_FechaNacimiento", obj.Clie_FechaNacimiento.ToString("yyyy-MM-dd")));
            cmd.Parameters.Add(new SqlParameter("clie_Codigo", obj.Clie_Codigo));
            cmd.Parameters.Add(new SqlParameter("clie_Comisionista", obj.Clie_Comisionista));
            cmd.Parameters.Add(new SqlParameter("clie_Abreviatura", obj.Clie_Abreviatura));
            cmd.Parameters.Add(new SqlParameter("clie_DomicilioFiscal", obj.Clie_DomicilioFiscal));
            cmd.Parameters.Add(new SqlParameter("empr_Id", obj.empr_Id));
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    response.codError = (int)reader["codError"];
                    response.mensajeError = (String)reader["Mensaje"];
                    if (response.codError != -1)
                    {
                        response.response = (int)reader["clie_Id"];
                    }
                }

            }


            return response;
        }
        public List<ent_Cliente> listarCliente(ent_Cliente obj, SqlConnection conn, SqlTransaction sqlTransaction)
        {
            ent_Cliente response = null;

            List<ent_Cliente> lista = new List<ent_Cliente>();
            SqlCommand cmd = new SqlCommand("DEV.pa_ListarCliente", conn);
            cmd.Transaction = sqlTransaction;
            cmd.Parameters.Add(new SqlParameter("empr_Id", obj.empr_Id));
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    response = new ent_Cliente();
                    response.Clie_Id = (int)reader["clie_Id"];
                    response.Clie_TipoDocumento = (int)reader["clie_TipoDocumento"];
                    response.Clie_TipoDocumentoDescripcion = (String)reader["clie_TipoDocumentoDescripcion"];
                    response.Clie_Documento = (String)reader["clie_Documento"];
                    response.Clie_TipoPersona = (Int16)reader["clie_TipoPersona"];
                    response.Clie_TipoPersonaDescripcion= (String)reader["clie_TipoPersonaDescripcion"];
                    response.Clie_RazonSocial = (String)reader["clie_RazonSocial"];
                    response.Clie_Codigo= (String)reader["clie_Codigo"];
                    response.Clie_DomicilioFiscal = (String)reader["clie_DomicilioFiscal"];
                    response.Clie_Estado = (Int16)reader["clie_Estado"];
                    response.Clie_Comisionista = (Int16)reader["clie_Comisionista"];
                    lista.Add(response);
                }
            }
            return lista;
        }
    }
}
