using CAD;
using CEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLN
{
    public class cln_Vehiculo
    {
        public List<ent_Vehiculo> listarVehiculo(ent_Vehiculo request, String tipo)
        {
            List<ent_Vehiculo> response = null;
            try
            {
                cad_Vehiculo cad = new cad_Vehiculo();
                response = cad.ListarVehiculo(request, tipo);

                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
