using CAD;
using CEN;
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
        public ResponseHelper guardarCliente(ent_Cliente obj, String tipo)
        {
            ResponseHelper response = null;
            try
            {
                cad_Cliente cad = new cad_Cliente();
                response = cad.guardarCliente(obj, tipo);
                
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ent_Cliente> ListarCliente(ent_Cliente obj, String tipo)
        {
            List<ent_Cliente> response = null;
            try
            {
                cad_Cliente cad = new cad_Cliente();
                response = cad.listarCliente(obj, tipo);

                return response;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
