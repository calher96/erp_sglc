using CEN.Entidad;

namespace CEN.Helpers
{
    public class StaticVariable
    {
        public static ent_Empresa obj_Empresa = new ent_Empresa();
        public static ent_Sucursal obj_Sucursal = new ent_Sucursal();
        public static ent_Usuario obj_Usuario = new ent_Usuario();
        public static ent_Perfil obj_Perfil = new ent_Perfil();
        public static ent_Trabajador obj_Trabajador = new ent_Trabajador();
        public static String token;
    }
}