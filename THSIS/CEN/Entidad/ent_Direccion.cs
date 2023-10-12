using CEN.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN
{
    public class ent_Direccion
    {
        public int Id { get; set; }
        public int Id_Trabajador { get; set; }
        public String Direccion { get; set; }
        public ent_Concepto TipoVia { get; set; }
        public String NombreVia { get; set; }
        public String Numero { get; set; }
        public String Departamento { get; set; }
        public String Interior { get; set; }
        public String Manzana { get; set; }
        public String Lote { get; set; }
        public String Kilometro { get; set; }
        public String Bloque { get; set; }
        public String Etapa { get; set; }
        public ent_Concepto TipoZona { get; set; }
        public String NombreZona { get; set; }
        public String Referencia { get; set; }
        public bool CentroAsistenciaEssalud { get; set; }
        public String Usuario { get; set; }
        public String Ip { get; set; }
        public String Mac { get; set; }
        public String HostUser { get; set; }
        public String HostName { get; set; }

        public ent_Direccion()
        {
            Id = 0;
            Id_Trabajador = 0;
            Direccion = String.Empty;
            TipoVia = new ent_Concepto();
            NombreVia = String.Empty;
            Numero = String.Empty;
            Departamento = String.Empty;
            Interior = String.Empty;
            Manzana = String.Empty;
            Lote = String.Empty;
            Kilometro = String.Empty;
            Bloque = String.Empty;
            Etapa = String.Empty;
            TipoZona = new ent_Concepto();
            NombreZona = String.Empty;
            Referencia = String.Empty;
            CentroAsistenciaEssalud = false;
            Usuario = String.Empty;
            Ip = String.Empty;
            Mac = String.Empty;
            HostUser = String.Empty;
            HostName = String.Empty;
        }
    }
}
