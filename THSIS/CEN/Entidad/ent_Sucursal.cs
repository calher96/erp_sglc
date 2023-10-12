using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Entidad
{
    public class ent_Sucursal
    {
        public int Id { get; set; }
        public int Id_Empresa { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public String Direccion { get; set; }
        public String CodSunat { get; set; }
    }
}
