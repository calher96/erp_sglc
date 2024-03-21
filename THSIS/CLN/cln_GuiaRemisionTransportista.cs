using CAD;
using CEN.Helpers;
using CEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLN
{
    public class cln_GuiaRemisionTransportista
    {
        public ResponseHelper registrarGRT(ent_GuiaRemisionTransportista obj, String tipo)
        {
            ResponseHelper response = null;
            try
            {
                cad_GuiaRemisionTransportista cad = new cad_GuiaRemisionTransportista();
                response = cad.RegistrarGRT(obj, tipo);

                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ent_GuiaRemisionTransportista> ListarGRT(ent_GuiaRemisionTransportista obj, String tipo)
        {
            List<ent_GuiaRemisionTransportista> response = null;
            try
            {
                cad_GuiaRemisionTransportista cad = new cad_GuiaRemisionTransportista();
                response = cad.listarGRT(obj, tipo);

                return response;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
