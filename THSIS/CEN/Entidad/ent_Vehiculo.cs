using CEN.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN
{
    public class ent_Vehiculo
    {
        public int Id { get; set; }
        public String PlacaAntigua { get; set; }
        public String PlacaActual { get; set; }
        public ent_Concepto Marca { get; set; }
        public ent_Concepto TipoVehiculo { get; set; }
        public int Marcabaja { get; set; } 

        public ent_Vehiculo()
        {
            Id = 0;
            PlacaAntigua = String.Empty;
            PlacaActual = String.Empty;
            Marca = new ent_Concepto() { Prefijo = 36 };
            TipoVehiculo = new ent_Concepto() { Prefijo = 22 };
            Marcabaja = 0;
        }
    }
}
