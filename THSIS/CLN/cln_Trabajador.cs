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
            List<ent_Trabajador> response = null;
            try
            {
                cad_Trabajador cad = new cad_Trabajador();
                response = cad.listarTrabajador(obj);

                return response;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
