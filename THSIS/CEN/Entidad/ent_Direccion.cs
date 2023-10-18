using CEN.Entidad;
using CEN.Helpers;
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
        public int Id_Cliente { get; set; }
        public ent_Concepto TipoVia { get; set; }
        public Boolean Principal { get; set; }
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
        public string DireccionCompleta
        {
            get
            {
                return ObtenerDireccion();
            }
        }
        public String Ubigeo { get; set; }
        public int Marcabaja { get; set; }
        public String Usuario { get; set; }
        public String Ip { get; set; }
        public String Mac { get; set; }
        public String HostUser { get; set; }
        public String HostName { get; set; }

        public ent_Direccion()
        {
            Id = 0;
            Id_Trabajador = 0;
            Id_Cliente = 0;
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
            Ubigeo = String.Empty;
            Marcabaja = 1;
            Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
            Ip = BasicVariable.Ip;
            Mac = BasicVariable.Mac;
            HostUser = BasicVariable.HostUser;
            HostName = BasicVariable.HostName;
        }

        public String ObtenerDireccion()
        {
            List<string> elementos = new List<string>();

            if (!string.IsNullOrEmpty(TipoVia.Descripcion))
            {
                elementos.Add(TipoVia.Descripcion);
            }
            if (!string.IsNullOrEmpty(NombreVia))
            {
                elementos.Add(NombreVia);
            }
            if (!string.IsNullOrEmpty(Numero))
            {
                elementos.Add("# " + Numero);
            }
            if (!string.IsNullOrEmpty(Departamento))
            {
                elementos.Add("Dept. " + Departamento);
            }
            if (!string.IsNullOrEmpty(Interior))
            {
                elementos.Add("Int. " + Interior);
            }
            if (!string.IsNullOrEmpty(Manzana))
            {
                elementos.Add("Mz. " + Manzana);
            }

            if (!string.IsNullOrEmpty(Lote))
            {
                elementos.Add("Lt. " + Lote);
            }
            if (!string.IsNullOrEmpty(Kilometro))
            {
                elementos.Add("Km. " + Kilometro);
            }

            if (!string.IsNullOrEmpty(Bloque))
            {
                elementos.Add("Bloque " + Bloque);
            }
            if (!string.IsNullOrEmpty(Etapa))
            {
                elementos.Add("Etapa " + Etapa);
            }
            if (!string.IsNullOrEmpty(TipoZona.Descripcion))
            {
                elementos.Add(TipoZona.Descripcion);
            }
            if (!string.IsNullOrEmpty(NombreZona))
            {
                elementos.Add(NombreZona);
            }
            string direccionCompleta = string.Join(" ", elementos);

            return direccionCompleta;
        }
    }
}
