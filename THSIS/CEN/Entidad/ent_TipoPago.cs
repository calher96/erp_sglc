using CEN.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Entidad
{
    public class ent_TipoPago
    {
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public ent_Concepto TipoPago { get; set; }
        public Boolean Cliente { get; set; }
        public Boolean Proveedor { get; set; }
        public int Marcabaja { get; set; }
        public String Usuario { get; set; }
        public String Ip { get; set; }
        public String Mac { get; set; }
        public String HostName { get; set; }
        public String HostUser { get; set; }

        public ent_TipoPago()
        {
            Id = 0;
            Id_Cliente = 0;
            TipoPago = new ent_Concepto();
            Cliente = false;
            Proveedor = false;
            Marcabaja = 1;
            Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
            Ip = BasicVariable.Ip;
            Mac = BasicVariable.Mac;
            HostName = BasicVariable.HostName;
            HostUser = BasicVariable.HostUser;
        }
    }
}
