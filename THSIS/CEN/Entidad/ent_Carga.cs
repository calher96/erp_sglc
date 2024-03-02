using CEN.Entidad;
using CEN.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN
{
    public class ent_Carga
    {
        public int Id { get; set; }
        public List<ent_CargaDetalle> LiscaCarga { get;set; }
        public String Codigo { get; set; }
        public ent_Concepto Estado { get; set; }
        public ent_Concepto TipoServicio { get; set; }
        public DateTime FechaSolicita { get; set; }
        public DateTime FechaRecepcion { get;set; }
        public DateTime FechaAtencion { get; set; }
        public UbigeoResponse LugarOrigen { get; set; }
        public UbigeoResponse LugarDestino { get; set; }
        public ent_Concepto CondicionPago { get; set; }
        public ent_Concepto TipoEntrega { get; set; }
        public Boolean Tercero { get; set; }
        public Double FleteTotal { get; set; }
        public String Vendedor { get; set; }
        public String Observacion { get; set; }
        public Boolean RecojoDomicilio { get; set; }
        public UbigeoResponse RecojoDomicilioLugar { get; set; }
        public String DireccionRecojoDomicilio { get; set; }
        public ent_Concepto TipoVehiculo { get; set; }
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
            Codigo = String.Empty;
            Estado = new ent_Concepto();
            TipoServicio = new ent_Concepto();
            FechaSolicita = new DateTime(1900,1,1);
            FechaRecepcion = new DateTime(1900, 1, 1);
            FechaAtencion = new DateTime(1900, 1, 1);
            LugarOrigen = new UbigeoResponse();
            LugarDestino = new UbigeoResponse();
            CondicionPago = new ent_Concepto();
            TipoEntrega = new ent_Concepto();
            Tercero = false;
            FleteTotal = Double.NaN;
            Vendedor = String.Empty;
            Observacion = String.Empty;
            RecojoDomicilio = false;
            RecojoDomicilioLugar = new UbigeoResponse();
            DireccionRecojoDomicilio = String.Empty;
            TipoVehiculo = new ent_Concepto();
            Marcabaja = 0;
            Usuario = String.Empty;
            Ip = String.Empty;
            Mac = String.Empty;
            HostName = String.Empty;
            HostUser = String.Empty;
        }
    }
}
