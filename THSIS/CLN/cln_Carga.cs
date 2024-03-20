using CAD;
using CEN.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN
{
    public class cln_Carga
    {
        public ResponseHelper registrarCarga(ent_Carga obj, String tipo)
        {
            ResponseHelper response = null;
            try
            {
                cad_Carga cad = new cad_Carga();
                response = cad.RegistrarCarga(obj, tipo);

                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ent_Carga> ListarCarga(ent_Carga obj, String tipo)
        {
            List<ent_Carga> response = null;
            try
            {
                cad_Carga cad = new cad_Carga();
                response = cad.listarCarga(obj, tipo);

                return response;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
