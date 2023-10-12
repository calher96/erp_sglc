using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Entidad
{
    public class ent_Concepto
    {
        public int Prefijo { get; set; }
        public int Correlativo { get; set; }
        public String Descripcion { get; set; }
        public String Abreviatura { get; set; }
        public int Valor1 { get; set; }
        public int Valor2 { get; set; }
        public int Valor3 { get; set; }
        public Double Valor4 { get; set; }
        public Double Valor5 { get; set; }
        public Double Valor6 { get; set; }
        public int Marcabaja { get; set; }
        public String Usuario { get; set; }
        public String Ip { get; set; }
        public String Mac { get; set; }
        public String HostUser { get; set; }
        public String HostName { get; set; }

        public ent_Concepto()
        {
            Prefijo = 0;
            Correlativo = 0;
            Descripcion = String.Empty;
            Abreviatura = String.Empty;
            Valor1 = 0;
            Valor2 = 0;
            Valor3 = 0;
            Valor4 = 0;
            Valor5 = 0;
            Valor6 = 0;
            Marcabaja = 0;
            Usuario = String.Empty;
            Ip = String.Empty;
            Mac = String.Empty;
            HostUser = String.Empty;
            HostName = String.Empty;
        }
    }
}
