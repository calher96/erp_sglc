using CEN.Response;
using CEN.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEN.Helpers;

namespace CEN
{
    public class ent_Carga
    {
        public int Id { get; set; }
        public List<ent_CargaDetalle> LiscaCarga { get; set; }
        public int empr_Id { get; set; }
        public String Codigo { get; set; }
        public ent_Cliente ClienteRemitente { get; set; }
        public ent_Cliente ClienteDestinatario { get; set; }
        public String PuntoPartida { get; set; }
        public String PuntoLlegada { get; set; }
        public ent_Concepto Estado { get; set; }
        public ent_Concepto TipoServicio { get; set; }
        public DateTime FechaSolicita { get; set; }
        public DateTime FechaRecepcion { get; set; }
        public DateTime FechaAtencion { get; set; }
        public ent_Ubigeo LugarOrigen { get; set; }
        public ent_Ubigeo LugarDestino { get; set; }
        public ent_Concepto CondicionPago { get; set; }
        public ent_Concepto TipoEntrega { get; set; }
        public Boolean Tercero { get; set; }
        public Double FleteTotal { get; set; }
        public String Vendedor { get; set; }
        public String Observacion { get; set; }
        public Boolean RecojoDomicilio { get; set; }
        public ent_Ubigeo RecojoDomicilioLugar { get; set; }
        public String DireccionRecojoDomicilio { get; set; }
        public ent_Concepto TipoVehiculo { get; set; }
        
        
        public String Anexos { get; set; }
        public String ClaveSeguridad { get; set; }
        public ent_Cliente ClientePago { get; set; }
        public String DireccionFacturacion { get; set; }
        public int Marcabaja { get; set; }
        public String Usuario { get; set; }
        public String Ip { get; set; }
        public String Mac { get; set; }
        public String HostName { get; set; }
        public String HostUser { get; set; }

        public ent_Carga()
        {
            Id = 0;
            LiscaCarga = new List<ent_CargaDetalle>();
            empr_Id = StaticVariable.obj_Empresa.Id;
            Codigo = String.Empty;
            Estado = new ent_Concepto();
            TipoServicio = new ent_Concepto();
            FechaSolicita = new DateTime(1900,1,1);
            FechaRecepcion = new DateTime(1900, 1, 1);
            FechaAtencion = new DateTime(1900, 1, 1);
            LugarOrigen = new ent_Ubigeo();
            LugarDestino = new ent_Ubigeo();
            CondicionPago = new ent_Concepto();
            TipoEntrega = new ent_Concepto();
            Tercero = false;
            FleteTotal = Double.NegativeZero;
            Vendedor = String.Empty;
            Observacion = String.Empty;
            RecojoDomicilio = false;
            RecojoDomicilioLugar = new ent_Ubigeo();
            DireccionRecojoDomicilio = String.Empty;
            TipoVehiculo = new ent_Concepto();
            ClienteRemitente = new ent_Cliente();
            ClienteDestinatario = new ent_Cliente();
            PuntoPartida = String.Empty;
            PuntoLlegada = String.Empty;
            Anexos = String.Empty;
            ClaveSeguridad = String.Empty;
            ClientePago = new ent_Cliente();
            DireccionFacturacion = String.Empty;
            Marcabaja = 0;
            Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
            Ip = BasicVariable.Ip;
            Mac = BasicVariable.Mac;
            HostName = BasicVariable.HostName;
            HostUser = BasicVariable.HostUser;
        }
    }
}
