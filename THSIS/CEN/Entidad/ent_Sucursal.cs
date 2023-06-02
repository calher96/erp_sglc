using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Entidad
{
    public class ent_Sucursal
    {
        public int Sucu_Id { get; set; }
        public int Empr_Id { get; set; }
        public String? Sucu_Nombre { get; set; }
        public String? Sucu_Descripcion { get; set; }
        public String? Sucu_Direccion { get; set; }
        public String? Sucu_CodSunat { get; set; }
    }
}
