using CAD;
using CEN.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLN
{
    public class cln_ControlError
    {
        public void registrarError(ent_ControlError obj)
        {
            cad_ControlError cad = new cad_ControlError();
            cad.registrarError(obj);
        }
    }
}
