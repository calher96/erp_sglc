﻿using CEN.Entidad;
using CEN.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN
{
    public class ent_Ruta
    {
        public int Id { get; set; }
        public ent_Ubigeo DistritoOrigen { get; set; }
        public ent_Ubigeo DistritoDestino { get; set; }
        public int Estado {  get; set; }
        public int Marcabaja { get; set; }
        public String Usuario { get; set; }
        public String Ip { get; set; }
        public String Mac { get; set; }
        public String HostUser { get; set; }
        public String HostName { get; set; }

        public ent_Ruta()
        {
            Id = 0;
            DistritoOrigen = new ent_Ubigeo();
            DistritoDestino = new ent_Ubigeo();
            Estado = 0;
            Marcabaja = 0;
            Usuario = String.Empty;
            Ip = String.Empty;
            Mac = String.Empty;
            HostUser = String.Empty;
            HostName = String.Empty;
        }
    }
}
