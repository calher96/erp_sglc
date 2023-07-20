using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEN.Entidad
{
    public class ent_Trabajador
    {
        public int Trab_Id { get; set; }
        public Int16 Trab_TipoDocumento { get; set; }
        public String? Trab_Documento { get; set; }
        public String? Trab_Nombres { get; set; }
        public String? Trab_ApellidoPaterno { get; set; }
        public String? Trab_ApellidoMaterno { get; set; }
        public String? Trab_NombresCompletos { get; set; }
        public int Trab_EstadoCivil { get; set; }
        public int Trab_Estado { get; set; }
        public int Trab_Marcabaja { get; set; }
        public DateOnly Trab_FechaNacimiento { get; set; }
        public int Trab_Sexo { get; set; }
        public String? Trab_SexoDescripcion { get; set; }
        public String? Trab_LugarNacimiento { get; set; }
        public String? Trab_usuarioRegistro { get; set; }
        public int empr_Id { get; set; }
        public int Trab_Categoria { get; set; }
        public Boolean Trab_Hijos { get; set; }
        public int Trab_GradoInstruccion { get; set; }
        public int Trab_Piloto { get; set; }
        public String? Trab_codigo { get; set; }
        public DateOnly? Trab_FechaRegistro { get; set; }
        public int Area_Id { get; set; }
        public String? Area_Nombre { get; set; }
        public String? Trab_RelacionLaboralDescripcion { get; set; }
        public String? corr_Correo { get; set; }
        public String? celu_Celular { get; set; }
        public String? telf_Telefono { get; set; }
        public String? dire_Direccion { get; set; }
    }
}
