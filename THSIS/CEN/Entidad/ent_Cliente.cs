using CEN.Entidad;
using CEN.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN
{
    public class ent_Cliente
    {
        public int Id { get; set; }
        public ent_Empresa Empresa { get; set; }
        public ent_Concepto TipoPersona { get; set; }
        public String RazonSocial { get; set; }
        public ent_Persona Persona { get; set; }
        public ent_Concepto Estado { get; set; }
        public String DomicilioFiscal { get; set; }
        public String Codigo { get; set; }
        public Boolean Comisionista { get; set; }
        public String Abreviatura { get; set; }
        public int Marcabaja { get; set; }
        public String Usuario { get; set; }
        public String Ip { get; set; }
        public String Mac { get; set; }
        public String HostUser { get; set; }
        public String HostName { get; set; }

        public ent_Cliente()
        {
            Id = 0;
            Empresa = new ent_Empresa();
            TipoPersona = new ent_Concepto();
            RazonSocial = String.Empty;
            Persona = new ent_Persona();
            Estado = new ent_Concepto();
            DomicilioFiscal = String.Empty;
            Codigo = String.Empty;
            Comisionista = false;
            Abreviatura = String.Empty;
            Marcabaja = 1;
            Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
            Ip = BasicVariable.Ip;
            Mac = BasicVariable.Mac;
            HostUser = BasicVariable.HostUser;
            HostName = BasicVariable.HostName;
        }
    }
}
