using CEN.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Response
{
    public class LoginResponse
    {
        public String Usuario { get; set; }
        public String Token { get; set; }
        public ent_Trabajador Trabajador { get; set; }
        public ent_Perfil Perfil { get; set; }
        public LoginResponse()
        {
            Usuario = String.Empty;
            Token = String.Empty;
            Perfil = new ent_Perfil();
            Trabajador = new ent_Trabajador();
        }
    }
}
