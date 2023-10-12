using CEN.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN
{
    public class ent_Ocupacion
    {
        public int Id { get; set; }
        public ent_Concepto Ocupacion { get; set; }

        public ent_Ocupacion()
        {
            Id = 0;
            Ocupacion = new ent_Concepto();
        }
    }
}
