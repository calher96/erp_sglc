using CAD;
using CEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLN
{
    public class cln_Ruta
    {
        public List<ent_Ruta> ListarRuta(ent_Ruta obj, String tipo)
        {
            List<ent_Ruta> response = null;
            try
            {
                cad_Ruta cad = new cad_Ruta();
                response = cad.listarRuta(obj, tipo);

                return response;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
