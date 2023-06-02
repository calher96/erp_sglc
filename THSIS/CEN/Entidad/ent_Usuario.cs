using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Entidad
{
    public class ent_Usuario
    {
        public int Usua_Id { get; set; }
        public String? Usua_Usuario { get; set; }
        public String? Usua_Password { get; set; }
        public int Usua_Estado { get; set; }
        public int Usua_Marcabaja { get; set; }
        public int Trab_Id { get; set; }
        public DateOnly Usua_FechaAlta { get; set; }
        public DateOnly Usua_FechaRegistro { get; set; }
        public String? Usua_UsuarioRegistro { get; set; }
        public DateOnly Usua_FechaModifica { get; set; }
        public String? Usua_UsuarioModifica { get; set; }
        public int Sucu_Id { get; set; }
    }
}
