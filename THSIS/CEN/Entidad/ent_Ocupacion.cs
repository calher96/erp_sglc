using CEN.Entidad;
using CEN.Helpers;

namespace CEN
{
    public class ent_Ocupacion
    {
        public int Id { get; set; }
        public ent_Concepto Ocupacion { get; set; }
        public ent_Concepto Centro { get; set; }
        public ent_Concepto Unidad { get; set; }
        public ent_Concepto Cargo { get;set; }
        public ent_Concepto TipoRelacionLaboral { get; set; }
        public DateOnly FechaIngreso { get; set; }
        public DateOnly FechaCese { get; set; }
        public ent_Concepto Ruta { get; set; }
        public Boolean OcupacionPrincipal { get; set; }
        public Boolean NoLaboraEMP { get; set; }
        public String Usuario { get; set; }
        public String Ip { get; set; }
        public String Mac { get; set; }
        public String HostName { get; set; }
        public String HostUser { get; set; }

        public ent_Ocupacion()
        {
            Id = 0;
            Ocupacion = new ent_Concepto();
            Centro = new ent_Concepto();
            Unidad = new ent_Concepto();
            Cargo = new ent_Concepto();
            TipoRelacionLaboral = new ent_Concepto();
            FechaIngreso = DateOnly.Parse("01/01/1901");
            FechaCese = DateOnly.Parse("01/01/1901");
            Ruta = new ent_Concepto();
            OcupacionPrincipal = false;
            NoLaboraEMP = false;
            Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
            Ip = BasicVariable.Ip;
            Mac = BasicVariable.Mac;
            HostName = BasicVariable.HostName;
            HostUser = BasicVariable.HostUser;
        }
    }
}
