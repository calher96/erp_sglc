using CAD;
using CEN.Entidad;
using CEN.Helpers;

namespace CLN
{
    public class cln_Login
    {
        public cln_Login()
        {

        }
        public ResponseHelper iniciarSesion(ent_Usuario User)
        {
            cad_Login cad = new cad_Login();
            return cad.IniciarSesion(User);
        }
    }
}