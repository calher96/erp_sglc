using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Request
{
    public class UbigeoRequest
    {
        public int Todos { get; set; }
        public String Departamento { get; set; }
        public String Provincia { get; set; }
        public String Distrito { get; set;}

        public UbigeoRequest() 
        {
            Todos = 0;
            Departamento = String.Empty; 
            Provincia = String.Empty;
            Distrito = String.Empty;
        }
    }
}
