using CAD;
using CEN.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLN
{
    public class cln_Concepto
    {
        public List<ent_Concepto> listarConcepto(int conc_Prefijo)
        {
            cad_Concepto obj = new cad_Concepto();
            return obj.listarConcepto(conc_Prefijo);
        }
    }
}
