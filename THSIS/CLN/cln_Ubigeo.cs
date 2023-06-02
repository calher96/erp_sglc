using CAD;
using CEN.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLN
{
    public class cln_Ubigeo
    {
        public List<ent_Ubigeo> listarUbigeo(int todos, String dept_Ubigeo, String prov_Ubigeo, String dist_Ubigeo)
        {
            cad_Ubigeo obj = new cad_Ubigeo();
            return obj.listarUbigeo(todos, dept_Ubigeo, prov_Ubigeo, dist_Ubigeo);
        }
    }
}
