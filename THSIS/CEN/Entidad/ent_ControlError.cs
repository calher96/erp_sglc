using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Entidad
{
    public class ent_ControlError
    {
        public int Cerr_Id {  get; set; }
        public String? Cerr_Formulario { get; set; }
        public String? Cerr_MensajeError { get; set; }
        public String? Cerr_Traza { get; set; }
        public String? Cerr_Usuario { get; set; }
        public String? Cerr_Trama { get; set; }
        public DateOnly Cerr_FechaError { get; set; }
    }
}
