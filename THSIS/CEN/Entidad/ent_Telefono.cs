using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Entidad
{
    public class ent_Telefono
    {
        public ent_Concepto tipo_Telefono = new ent_Concepto();
        public String? telf_Numero { get; set; }
        public ent_Concepto operador = new ent_Concepto();
        public Boolean telf_Principal { get; set; }
    }
}
