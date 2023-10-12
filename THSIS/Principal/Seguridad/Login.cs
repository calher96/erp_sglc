using CEN.Entidad;
using CLN;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEN.Helpers;
using System.Text.Json.Serialization;
using System.Text.Json;
using CEN.Response;

namespace Principal.Seguridad
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public void limpiarCampos()
        {
            txtUser.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ent_Usuario User = null;
            try
            {
                User = new ent_Usuario();
                User.Usua_Usuario = txtUser.Text;
                User.Usua_Password = txtPassword.Text;
                cln_Login cln = new cln_Login();
                cln_Perfil clnPerfil = new cln_Perfil();
                ResponseHelper response = cln.iniciarSesion(User);
                if (response.codError == 0)
                {
                    //MessageBox.Show(response.mensajeError + " " + StaticVariable.obj_Usuario.Usua_Usuario, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StaticVariable.obj_Perfil = ((LoginResponse)response.response).Perfil;
                    StaticVariable.obj_Empresa = ((LoginResponse)response.response).Trabajador.Empresa;
                    StaticVariable.token = ((LoginResponse)response.response).Token;
                    StaticVariable.obj_Usuario.Usua_Usuario = ((LoginResponse)response.response).Usuario;
                    StaticVariable.obj_Trabajador = ((LoginResponse)response.response).Trabajador;
                    mdi_Principal.status_login = 1;
                    this.Dispose();
                }
                else
                {
                    limpiarCampos();
                    MessageBox.Show(response.mensajeError, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ent_ControlError obj = new ent_ControlError();
                obj.Cerr_MensajeError = ex.Message;
                obj.Cerr_Traza = ex.StackTrace;
                obj.Cerr_Usuario = txtUser.Text;
                obj.Cerr_Trama = JsonSerializer.Serialize(new { User.Usua_Usuario, User.Usua_Password });
                obj.Cerr_Formulario = "Login";
                obj.Cerr_FechaError = DateOnly.Parse(DateTime.Now.ToShortDateString());
                cln_ControlError cln = new cln_ControlError();
                cln.registrarError(obj);
                limpiarCampos();
                MessageBox.Show("Ocurrió un error interno, por favor vuelve a intentar", BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click((object)sender, (EventArgs)e);
            }
        }
    }
}
