using CAD;
using CEN.Entidad;
using CEN.Request;
using CEN.Response;
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
            UbigeoRequest request = new UbigeoRequest();
            request.Todos = todos;
            request.Departamento = dept_Ubigeo;
            request.Provincia = prov_Ubigeo;
            request.Distrito = dist_Ubigeo;
            return obj.listarUbigeo(request);
        }
    }
}
