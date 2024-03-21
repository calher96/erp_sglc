using CEN.Entidad;
using CEN.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN
{
    public class ent_GuiaRemisionTransportista
    {
        public int Id { get; set; }
        public String Serie {  get; set; }
        public String Correlativo { get; set; }
        public ent_Carga Carga { get; set; }
        public DateOnly Fecha { get; set; }
        public DateOnly FechaTraslado { get; set; }
        public int empr_Id { get; set; }
        public ent_Concepto MotivoTraslado { get; set; }
        public String NumeroDoc { get; set; }
        public ent_Vehiculo Vehiculo { get; set; }
        public ent_Vehiculo Carreta { get; set; }
        public ent_Trabajador Piloto { get; set; }
        public String NumeroLicencia { get; set; }
        public Decimal Peso { get; set; }
        public ent_Concepto Estado { get; set; }
        public int Marcabaja { get; set; }
        public ent_GuiaRemisionTransportistaDetalle Detalle { get; set; }
        public String Usuario { get; set; }
        public String Ip { get; set; }
        public String Mac { get; set; }
        public String HostName { get; set; }
        public String HostUser { get; set; }
        

        public ent_GuiaRemisionTransportista()
        {
            Id = 0;
            Serie = String.Empty;
            Correlativo = String.Empty;
            Carga = new ent_Carga();
            Fecha = DateOnly.MinValue;
            FechaTraslado = DateOnly.MinValue;
            empr_Id = StaticVariable.obj_Empresa.Id;
            MotivoTraslado = new ent_Concepto() { Prefijo = 38};
            NumeroDoc = String.Empty;
            Vehiculo = new ent_Vehiculo();
            Carreta = new ent_Vehiculo();
            Piloto = new ent_Trabajador();
            NumeroLicencia = String.Empty;
            Peso = Decimal.Zero;
            Estado = new ent_Concepto() { Prefijo = 39 };
            Marcabaja = 1;
            Detalle = new ent_GuiaRemisionTransportistaDetalle();
            Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
            Ip = BasicVariable.Ip;
            Mac = BasicVariable.Mac;
            HostName = BasicVariable.HostName;
            HostUser = BasicVariable.HostUser;
        }
    }
}
