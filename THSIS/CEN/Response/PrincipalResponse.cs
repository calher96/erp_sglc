using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Response
{
    public class PrincipalResponse
    {
        public int CodError { get; set; }
        public String? MensajeError { get; set; }
        public Object? Response { get; set; }
    }
}
