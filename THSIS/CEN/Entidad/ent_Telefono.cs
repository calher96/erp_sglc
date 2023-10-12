using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Entidad
{
    public class ent_Telefono
    {
        public int Id { get; set; }
        public int Id_Trabajador { get; set; }
        public ent_Concepto Operador { get; set; }
        public String Numero { get; set; }
        public bool Principal { get; set; }
        public int Marcabaja { get; set; }
        public String Usuario { get; set; }
        public String Ip { get; set; }
        public String Mac { get; set; }
        public String HostUser { get; set; }
        public String HostName { get; set; }

        public ent_Telefono()
        {
            Id = 0;
            Id_Trabajador = 0;
            Operador = new ent_Concepto();
            Numero = String.Empty;
            Principal = false;
            Marcabaja = 0;
            Usuario = String.Empty;
            Ip = String.Empty;
            Mac = String.Empty;
            HostUser = String.Empty;
            HostName = String.Empty;
        }
    }
}
