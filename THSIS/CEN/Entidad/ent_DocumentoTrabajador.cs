using CEN.Entidad;
using CEN.Helpers;

namespace CEN
{
    public class ent_DocumentoTrabajador
    {
        public int Id { get; set; }
        public int trab_Id { get; set; }
        public ent_Concepto TipoDocumento { get; set; }
        public String NumeroDocumento { get; set; }
        public DateOnly FechaEmision { get; set; }
        public DateOnly FechaCaducidad { get; set; }
        public int Marcabaja { get; set; }
        public String Usuario { get; set; }
        public String Ip { get; set; }
        public String Mac { get; set; }
        public String HostName { get; set; }
        public String HostUser { get; set; }

        public ent_DocumentoTrabajador()
        {
            Id = 0;
            trab_Id = 0;
            TipoDocumento = new ent_Concepto() { Prefijo = 1 };
            NumeroDocumento = String.Empty;
            FechaEmision = DateOnly.FromDateTime(DateTime.MinValue);
            FechaCaducidad = DateOnly.FromDateTime(DateTime.MinValue);
            Marcabaja = 1;
            Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
            Ip = BasicVariable.Ip;
            Mac = BasicVariable.Mac;
            HostName = BasicVariable.HostName;
            HostUser = BasicVariable.HostUser;
        }
    }
}
