using CEN.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN
{
    public class ent_CargaDetalle
    {
        public int Id { get; set; }
        public int carg_Id { get; set; }
        public UbigeoResponse LugarOrigen { get; set; }
        public UbigeoResponse LugarDestino { get; set; }
        public ent_Concepto TipoCarga { get;set; }
        public Double Cantidad { get; set; }
        public Double Peso { get;set; }
        public ent_Cliente ClienteRecepcion { get; set; }
        public ent_Cliente ClienteFinal { get; set; }
        public ent_Cliente Comisionista { get; set; }
        public String ProductoTransportar { get; set; }
        public Double ValorUnitario { get; set; }
        public Double PrecioUnitario { get; set; }
        public Double ValorAfecto { get; set; }
        public Double ValorInafecto { get; set; }
        public Double ValorExonerado { get; set; }
        public Double IGV { get; set; }
        public Double Total { get; set; }
        public Double Adelanto { get; set; }
        public Double Comision { get; set; }
        public Boolean Facturado { get; set; }
        public Boolean FalsoFlete { get; set; }
        public Double Consolidado { get; set; }
        public Double ConEstiba { get; set; }
        public Double CEstibaDesc { get; set; }
        public Boolean PagoContraEntrega { get; set; }
        public ent_Concepto FormaPago { get; set; }
        public Boolean Carga { get; set; }
        public Boolean Descarga { get; set; }
        public int Marcabaja { get; set; }
        public String Usuario { get; set; }
        public String Ip { get; set; }
        public String Mac { get; set; }
        public String HostName { get; set; }
        public String HostUser { get; set; }

        public ent_CargaDetalle()
        {
            Id = 0;
            carg_Id = 0;
            LugarOrigen = new UbigeoResponse();
            LugarDestino = new UbigeoResponse();
            TipoCarga = new ent_Concepto();
            Cantidad = Double.NaN;
            Peso = Double.NaN;
            ClienteRecepcion = new ent_Cliente();
            ClienteFinal = new ent_Cliente();
            Comisionista = new ent_Cliente();
            ProductoTransportar = String.Empty;
            ValorUnitario = Double.NaN;
            PrecioUnitario= Double.NaN;
            ValorAfecto= Double.NaN;
            ValorInafecto= Double.NaN;
            ValorExonerado= Double.NaN;
            IGV= Double.NaN;
            Total= Double.NaN;
            Adelanto= Double.NaN;
            Comision= Double.NaN;
            Facturado= false;
            FalsoFlete=false;
            Consolidado= Double.NaN;
            ConEstiba= Double.NaN;
            CEstibaDesc = Double.NaN;
            PagoContraEntrega= false;
            FormaPago = new ent_Concepto();
            Carga = false;
            Descarga = false;
            Marcabaja = 0;
            Usuario = String.Empty;
            Ip = String.Empty;
            Mac = String.Empty;
            HostName = String.Empty;
            HostUser = String.Empty;
        }
    }
}
