using CEN.Entidad;
using CEN.Helpers;
using System.Data.SqlClient;

namespace CAD
{
    public class cad_Trabajador
    {
        public ResponseHelper guardarTrabajador(ent_Trabajador obj, SqlConnection conn, SqlTransaction sqlTransaction)
        {
            ResponseHelper response = null;
            
                response = new ResponseHelper();
                SqlCommand cmd = new SqlCommand("DEV.pa_Trabajador_IUD", conn);
                cmd.Transaction = sqlTransaction;
                cmd.Parameters.Add(new SqlParameter("tipo", "I"));
                cmd.Parameters.Add(new SqlParameter("trab_Id", "0"));
                cmd.Parameters.Add(new SqlParameter("trab_TipoDocumento", obj.Trab_TipoDocumento));
                cmd.Parameters.Add(new SqlParameter("trab_Documento", obj.Trab_Documento));
                cmd.Parameters.Add(new SqlParameter("trab_Nombres", obj.Trab_Nombres));
                cmd.Parameters.Add(new SqlParameter("trab_ApellidoPaterno", obj.Trab_ApellidoPaterno));
                cmd.Parameters.Add(new SqlParameter("trab_ApellidoMaterno", obj.Trab_ApellidoMaterno));
                cmd.Parameters.Add(new SqlParameter("trab_EstadoCivil", obj.Trab_EstadoCivil));
                cmd.Parameters.Add(new SqlParameter("trab_Estado", obj.Trab_Estado));
                cmd.Parameters.Add(new SqlParameter("trab_Marcabaja", obj.Trab_Marcabaja));
                cmd.Parameters.Add(new SqlParameter("trab_FechaNacimiento", obj.Trab_FechaNacimiento.ToString("yyyy-MM-dd")));
                cmd.Parameters.Add(new SqlParameter("trab_Sexo", obj.Trab_Sexo));
                cmd.Parameters.Add(new SqlParameter("trab_LugarNacimiento", obj.Trab_LugarNacimiento));
                cmd.Parameters.Add(new SqlParameter("trab_usuarioRegistro", obj.Trab_usuarioRegistro));
                cmd.Parameters.Add(new SqlParameter("empr_Id", obj.empr_Id));
                cmd.Parameters.Add(new SqlParameter("trab_Categoria", obj.Trab_Categoria));
                cmd.Parameters.Add(new SqlParameter("trab_Hijos", obj.Trab_Hijos));
                cmd.Parameters.Add(new SqlParameter("trab_GradoInstruccion", obj.Trab_GradoInstruccion));
                cmd.Parameters.Add(new SqlParameter("trab_Piloto", obj.Trab_Piloto));
                cmd.Parameters.Add(new SqlParameter("trab_Codigo", obj.Trab_codigo));
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        response.codError = (int)reader["codError"];
                        response.mensajeError = (String)reader["Mensaje"];
                        if (response.codError != -1)
                        {
                            response.response = (int)reader["trab_Id"];
                        }
                    }

                }
            
            
            return response;
        }

        public List<ent_Trabajador> listarTrabajador(ent_Trabajador obj, SqlConnection conn, SqlTransaction sqlTransaction)
        {
            ent_Trabajador response = null;

            List<ent_Trabajador> lista = new List<ent_Trabajador>();
            SqlCommand cmd = new SqlCommand("DEV.pa_ListarTrabajador", conn);
            cmd.Transaction = sqlTransaction;
            cmd.Parameters.Add(new SqlParameter("trab_Estado", obj.Trab_Estado));
            cmd.Parameters.Add(new SqlParameter("trab_Categoria", obj.Trab_Categoria));
            cmd.Parameters.Add(new SqlParameter("empr_Id", obj.empr_Id));
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    response = new ent_Trabajador();
                    response.Trab_Id = (int)reader["trab_Id"];
                    response.Trab_Documento = (String)reader["trab_Documento"];
                    response.Trab_Nombres = (String)reader["trab_Nombres"];
                    response.Trab_ApellidoPaterno = (String)reader["trab_ApellidoPaterno"];
                    response.Trab_ApellidoMaterno = (String)reader["trab_ApellidoMaterno"];
                    response.Trab_Sexo = (int)reader["trab_Sexo"];
                    response.Trab_SexoDescripcion = (String)reader["trab_SexoDescripcion"];
                    response.Trab_FechaNacimiento = DateOnly.FromDateTime((DateTime)reader["trab_FechaNacimiento"]);
                    response.Trab_codigo = (String)reader["trab_Codigo"];
                    response.Trab_FechaRegistro = DateOnly.FromDateTime((DateTime)reader["trab_FechaRegistro"]);
                    response.Area_Id = (int)reader["area_Id"];
                    response.Area_Nombre = (String)reader["area_Nombre"];
                    response.Trab_RelacionLaboralDescripcion = (String)reader["trab_RelacionLaboral"];
                    response.Trab_Estado = (int)reader["trab_Estado"];
                    lista.Add(response);
                }

            }
            return lista;
        }

        public void guardarDatosTrabajador(int trab_Id, String dato, int tipo, SqlConnection conn, SqlTransaction sqlTransaction)
        {
            int response = 0;
            SqlCommand cmd = new SqlCommand("DEV.pa_GuardarDatosTrabajador", conn);
            cmd.Transaction = sqlTransaction;
            cmd.Parameters.Add(new SqlParameter("tipo", tipo));
            cmd.Parameters.Add(new SqlParameter("trab_Id", trab_Id));
            cmd.Parameters.Add(new SqlParameter("dato", dato));
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    response = (int)reader["response"];
                   
                }

            }
        }
    }
}
