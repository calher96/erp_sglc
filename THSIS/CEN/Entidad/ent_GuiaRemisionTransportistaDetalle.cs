using CEN.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN
{
    public class ent_GuiaRemisionTransportistaDetalle
    {
        public int Id { get; set; }
        public int Grtr_Id { get; set; }
        public String Descripcion { get; set; }
        public Decimal Cantidad { get; set; }
        public Decimal Peso { get; set; }
        public Decimal PesoTotal { get; set; }
        public int Marcabaja { get; set; }
        public String Usuario { get; set; }
        public String Ip { get; set; }
        public String Mac { get; set; }
        public String HostName { get; set; }
        public String HostUser { get; set; }

        public ent_GuiaRemisionTransportistaDetalle()
        {
            Id = 0;
            Grtr_Id = 0;
            Descripcion = String.Empty;
            Cantidad = Decimal.Zero;
            Peso = Decimal.Zero;
            PesoTotal = Decimal.Zero;
            Marcabaja = 1;
            Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
            Ip = BasicVariable.Ip;
            Mac = BasicVariable.Mac;
            HostName = BasicVariable.HostName;
            HostUser = BasicVariable.HostUser;
        }
    }
}
