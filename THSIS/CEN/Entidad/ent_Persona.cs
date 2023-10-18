using CEN.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Entidad
{
    public class ent_Persona
    {
        public int Id { get; set; }
        public int Id_Empresa { get; set; }
        public ent_Concepto TipoDocIdentidad { get; set; }
        public String DocIdentidad { get; set; }
        public String Ruc { get; set; }
        public String Nombres { get; set; }
        public String ApellidoPaterno { get; set; }
        public String ApellidoMaterno { get; set; }
        public String UbigeoNacimiento { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public ent_Concepto Sexo { get; set; }
        public ent_Concepto EstadoCivil { get; set; }
        public int Marcabaja { get; set; }
        public String Usuario { get; set; }
        public String Ip { get; set; }
        public String Mac { get; set; }
        public String HostUser { get; set; }
        public String HostName { get; set; }

        public ent_Persona()
        {
            Id = 0;
            Id_Empresa = 0;
            TipoDocIdentidad = new ent_Concepto();
            DocIdentidad = String.Empty;
            Ruc = String.Empty;
            Nombres = String.Empty;
            ApellidoPaterno = String.Empty;
            ApellidoMaterno = String.Empty;
            UbigeoNacimiento = String.Empty;
            FechaNacimiento = DateOnly.Parse("01/01/1901");
            Sexo = new ent_Concepto();
            EstadoCivil = new ent_Concepto();
            Marcabaja = 0;
            Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
            Ip = BasicVariable.Ip;
            Mac = BasicVariable.Mac;
            HostUser = BasicVariable.HostUser;
            HostName = BasicVariable.HostName;
        }
    }
}