using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.DGV_View
{
    public class TrabajadorView
    {
        public int Id { get; set; }
        public String Dni { get; set; }
        public String Nombres { get; set; }
        public String Sexo { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public String Codigo { get; set; }
        public DateOnly FechaIngreso { get; set; }
        public Boolean Disponible { get; set; }

        public TrabajadorView()
        {
            Id = 0;
            Dni = String.Empty; Nombres = String.Empty; Sexo = String.Empty;
            FechaNacimiento = new DateOnly();
            Codigo = String.Empty;
            FechaIngreso = new DateOnly();
            Disponible = false;
        }
    }
}
