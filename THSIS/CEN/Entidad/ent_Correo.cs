﻿using CEN.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Entidad
{
    public class ent_Correo
    {
        public int Id { get; set; }
        public int Id_Trabajador { get; set; }
        public String Correo { get; set; }
        public int Estado { get; set; }
        public bool Principal { get; set; }
        public int Marcabaja { get; set; }
        public String Usuario { get; set; }
        public String Ip { get; set; }
        public String Mac { get; set; }
        public String HostUser { get; set; }
        public String HostName { get; set; }
        public ent_Correo()
        {
            Id = 0;
            Id_Trabajador = 0;
            Correo = String.Empty;
            Estado = 0;
            Principal = false;
            Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
            Ip = BasicVariable.Ip;
            Mac = BasicVariable.Mac;
            HostUser = BasicVariable.HostUser;
            HostName = BasicVariable.HostName;
        }
    }
}
