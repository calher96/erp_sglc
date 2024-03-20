using CEN.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Entidad
{
    public class ent_Trabajador
    {
        public int Id { get; set; }
        public ent_Empresa Empresa { get; set; }
        public ent_Sucursal Sucursal { get; set; }
        public ent_Persona Persona { get; set; }
        public String Codigo { get; set; }
        public ent_Concepto Estado { get; set; }
        public ent_Concepto Categoria { get; set; }
        public ent_Concepto GradoInstruccion { get; set; }
        public ent_Concepto Piloto { get; set; }
        public List<ent_Ocupacion> Lista_Ocupacion { get; set; }
        public bool Hijos { get; set; }
        public int Marcabaja { get; set; }
        public List<ent_Telefono> Lista_Telefono { get; set; }
        public List<ent_Telefono> Lista_Celular { get; set; }
        public List<ent_Correo> Lista_Correo { get; set; }
        public List<ent_Direccion> Lista_Direccion { get; set; }
        public List<ent_Ocupacion> ListaOcupacion { get; set; }
        public String FotoPerfil { get; set; }
        public String Usuario { get; set; }
        public String Ip { get; set; }
        public String Mac { get; set; }
        public String HostUser { get; set; }
        public String HostName { get; set; }
        public String NombresCompletos {
            get { return Persona.Nombres + " " + Persona.ApellidoPaterno + " " + Persona.ApellidoMaterno;  } 
        }

        public ent_Trabajador()
        {
            Id = 0;
            Empresa = new ent_Empresa();
            Sucursal = new ent_Sucursal();
            Persona = new ent_Persona();
            Codigo = String.Empty;
            Estado = new ent_Concepto();
            Categoria = new ent_Concepto();
            GradoInstruccion = new ent_Concepto();
            Piloto = new ent_Concepto();
            Lista_Ocupacion = new List<ent_Ocupacion>();
            Hijos = false;
            Marcabaja = 1;
            Lista_Telefono = new List<ent_Telefono>();
            Lista_Celular = new List<ent_Telefono>();
            Lista_Correo = new List<ent_Correo>();
            Lista_Direccion = new List<ent_Direccion>();
            ListaOcupacion = new List<ent_Ocupacion>();
            FotoPerfil = String.Empty;
            Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
            Ip = BasicVariable.Ip;
            Mac = BasicVariable.Mac;
            HostUser = BasicVariable.HostUser;
            HostName = BasicVariable.HostName;
        }
    }
}
