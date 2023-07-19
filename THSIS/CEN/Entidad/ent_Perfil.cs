using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Entidad
{
    public class ent_Perfil
    {
        public int perf_Id { get;set; }
        public String perf_Nombre { get;set; }
        public int perf_Estado { get;set; }
        public String perf_EstadoDescripcion { get; set; }
        public int empr_Id { get;set; }
        public int perf_Marcabaja { get;set; }
        public String perf_Usuario { get;set; }
        public List<ent_Permiso> lista_Permiso = new List<ent_Permiso>();
    }
}
