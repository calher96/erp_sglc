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
        public int Marcabaja { get; set; }

        public ent_Sucursal()
        {
            Id = 0;
            Id_Empresa = 0;
            Nombre = String.Empty;
            Descripcion = String.Empty;
            Direccion = String.Empty;
            CodSunat = String.Empty;
            Marcabaja = 0;
        }
    }
}
