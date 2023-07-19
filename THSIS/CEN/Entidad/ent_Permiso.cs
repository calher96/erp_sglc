using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Entidad
{
    public class ent_Permiso
    {
        public int perm_Id { get; set; }
        public String perm_Titulo { get; set; }
        public int empr_Id { get; set; }
        public int perm_OrdenPrincipal { get; set; }
        public int perm_OrdenPadre { get; set; }
        public int perm_OrdenHijo { get; set; }
        public int perm_OrdenSubHijo { get; set; }
        public String perm_Control { get; set; }
    }
}
