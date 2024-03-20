using CEN;
using CEN.Entidad;
using CEN.Helpers;
using CLN;
using Principal.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Operaciones
{
    public partial class frm_GuiaRemisionTransportista : Form
    {


        #region "Variables"
        public static ent_Carga Carga = new ent_Carga();
        public static int mode = 0; //2 = frm_Carga, 1 = frm_GuiRemisionTransportista
        #endregion
        #region "Constructor"
        public frm_GuiaRemisionTransportista()
        {
            InitializeComponent();
            construirFormulario();
        }
        #endregion
        #region "Eventos"
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            BasicMetod.CerrarPestaniaPrincipal("Guia Remisión");
        }
        #endregion
        #region "Métodos"
        private void construirFormulario()
        {
            try
            {
                if (mode == 2)
                {
                    tpc_GuiaRemisionTransportista.SelectedIndex = 1;
                    cargarClientes();
                    BasicMetod.cargarComboBox(cbo_MotivoTraslado, 38, "Correlativo", "Descripcion");
                    cargarVehiculo();
                }
            }
            catch (Exception ex)
            {
                cln_ControlError cln_ControlError = new cln_ControlError();
                ent_ControlError Error = new ent_ControlError();
                Error.Cerr_MensajeError = ex.Message;
                Error.Cerr_FechaError = DateOnly.FromDateTime(DateTime.Now);
                Error.Cerr_Traza = ex.StackTrace;
                Error.Cerr_Trama = "";
                Error.Cerr_Formulario = this.Name;
                cln_ControlError.registrarError(Error);
            }
            
        }
        private void cargarVehiculo()
        {
            
        }
        private void cargarClientes()
        {
            cln_Cliente cln_Cliente = new cln_Cliente();
         
            //Cliente
            List<ent_Cliente> ListaCliente = cln_Cliente.ListarCliente(new ent_Cliente(), "CLI");
            cbo_Cliente.DataSource = ListaCliente;
            cbo_Cliente.DisplayMember = "RazonSocial";
            cbo_Cliente.ValueMember = "Id";
            //Remitente
            List<ent_Cliente> ListaRemitente = cln_Cliente.ListarCliente(new ent_Cliente(), "CLI");
            cbo_ClienteRemitente.DataSource = ListaRemitente;
            cbo_ClienteRemitente.DisplayMember = "RazonSocial";
            cbo_ClienteRemitente.ValueMember = "Id";
            //Destinatario
            List<ent_Cliente> ListaDestinatario= cln_Cliente.ListarCliente(new ent_Cliente(), "CLI");
            cbo_ClienteDestinatario.DataSource = ListaRemitente;
            cbo_ClienteDestinatario.DisplayMember = "RazonSocial";
            cbo_ClienteDestinatario.ValueMember = "Id";
        }
        #endregion
    }
}
