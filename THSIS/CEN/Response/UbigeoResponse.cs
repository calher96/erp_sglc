using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Response
{
    public class UbigeoResponse
    {
        public String Ubigeo { get; set; }
        public String Descripcion { get; set; }
        public String Referencia { get; set; }

        public UbigeoResponse() 
        {
            Ubigeo = String.Empty;
            Descripcion = String.Empty;
            Referencia = String.Empty;
        }
    }
}
