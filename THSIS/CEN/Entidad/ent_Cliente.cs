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
        public String Telefono { get; set; }
        public ent_Concepto TipoPersona { get; set; }
        public String RazonSocial { get; set; }
        public ent_Persona Persona { get; set; }
        public ent_Concepto Estado { get; set; }
        public String DomicilioFiscal { get; set; }
        public String Codigo { get; set; }
        public Boolean Comisionista { get; set; }
        public Boolean Cliente { get; set; }
        public Boolean Proveedor { get; set; }
        public ent_Concepto ClasificacionEMP { get; set; }
        public String Abreviatura { get; set; }
        public List<ent_Direccion> Lista_Direccion { get; set; }
        public List<ent_TipoPago> Lista_TipoPago { get; set; }
        public Boolean Percepcion { get; set; }
        public Boolean Retencion { get; set; }
        public Boolean BuenContribuyente { get; set; }
        public Boolean CanjeDocumento { get; set; }
        public Boolean Letras { get; set; }
        public Boolean Cheque { get; set; }
        public Boolean EmpresaRelacionada { get; set; }
        public Double Morosidad { get; set; }
        public Double LineaCredito { get; set; }
        public ent_Concepto TipoNivelComercial { get; set; }
        public ent_Concepto ClasificacionTipo { get; set; }
        public ent_Concepto Moneda { get; set; }
        public ent_Concepto TipoEmpresa { get; set; }
        public String Correo { get; set; }
        public int Marcabaja { get; set; }
        public String Usuario { get; set; }
        public String Ip { get; set; }
        public String Mac { get; set; }
        public String HostUser { get; set; }
        public String HostName { get; set; }

        public ent_Cliente()
        {
            Id = 0;
            Empresa = new ent_Empresa() { Id = StaticVariable.obj_Empresa.Id};
            TipoPersona = new ent_Concepto();
            RazonSocial = String.Empty;
            Persona = new ent_Persona();
            Estado = new ent_Concepto();
            DomicilioFiscal = String.Empty;
            Codigo = String.Empty;
            Comisionista = false;
            Cliente = true;
            Proveedor = false;
            ClasificacionEMP = new ent_Concepto();
            Abreviatura = String.Empty;
            Lista_Direccion = new List<ent_Direccion>();
            Lista_TipoPago = new List<ent_TipoPago>();
            Percepcion = false;
            Retencion = false;
            BuenContribuyente = false;
            CanjeDocumento = false;
            Letras = false;
            Cheque = false;
            EmpresaRelacionada = false;
            Morosidad = 0.0;
            LineaCredito = 0.0;
            TipoNivelComercial = new ent_Concepto();
            ClasificacionTipo = new ent_Concepto();
            Moneda = new ent_Concepto();
            TipoEmpresa = new ent_Concepto();
            Telefono = String.Empty;
            Correo = String.Empty;
            Marcabaja = 1;
            Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
            Ip = BasicVariable.Ip;
            Mac = BasicVariable.Mac;
            HostUser = BasicVariable.HostUser;
            HostName = BasicVariable.HostName;
        }
    }
}
