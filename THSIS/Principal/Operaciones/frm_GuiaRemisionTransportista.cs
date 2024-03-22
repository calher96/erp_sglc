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
        private void dgv_GRT_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verifica si la columna actual es la columna MotivoTraslado
            if (dgv_GRT.Columns[e.ColumnIndex].Name == "MotivoTraslado")
            {
                // Obtiene el valor actual de la celda
                var value = e.Value as ent_Concepto;

                // Verifica que el valor no sea nulo
                if (value != null)
                {
                    // Asigna el valor de la propiedad Descripcion al valor que se muestra en la celda
                    e.Value = value.Descripcion;
                }
            }
            if (dgv_GRT.Columns[e.ColumnIndex].Name == "Vehiculo")
            {
                // Obtiene el valor actual de la celda
                var value = e.Value as ent_Vehiculo;

                // Verifica que el valor no sea nulo
                if (value != null)
                {
                    // Asigna el valor de la propiedad Descripcion al valor que se muestra en la celda
                    e.Value = value.PlacaActual;
                }
            }
            if (dgv_GRT.Columns[e.ColumnIndex].Name == "Carreta")
            {
                // Obtiene el valor actual de la celda
                var value = e.Value as ent_Vehiculo;

                // Verifica que el valor no sea nulo
                if (value != null)
                {
                    // Asigna el valor de la propiedad Descripcion al valor que se muestra en la celda
                    e.Value = value.PlacaActual;
                }
            }
            if (dgv_GRT.Columns[e.ColumnIndex].Name == "Piloto")
            {
                // Obtiene el valor actual de la celda
                var value = e.Value as ent_Trabajador;

                // Verifica que el valor no sea nulo
                if (value != null)
                {
                    // Asigna el valor de la propiedad Descripcion al valor que se muestra en la celda
                    e.Value = value.NombresCompletos;
                }
            }

            if (dgv_GRT.Columns[e.ColumnIndex].Name == "Estado")
            {
                // Obtiene el valor actual de la celda
                var value = e.Value as ent_Concepto;

                // Verifica que el valor no sea nulo
                if (value != null)
                {
                    // Asigna el valor de la propiedad Descripcion al valor que se muestra en la celda
                    e.Value = value.Descripcion;
                }
            }

            if (dgv_GRT.Columns[e.ColumnIndex].Name == "Detalle")
            {
                // Obtiene el valor actual de la celda
                var value = e.Value as ent_GuiaRemisionTransportistaDetalle;

                // Verifica que el valor no sea nulo
                if (value != null)
                {
                    // Asigna el valor de la propiedad Descripcion al valor que se muestra en la celda
                    e.Value = value.Descripcion;
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            tpc_GuiaRemisionTransportista.SelectedIndex = 0;
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_GRT.DataSource = null;
                cln_GuiaRemisionTransportista cln = new cln_GuiaRemisionTransportista();
                List<ent_GuiaRemisionTransportista> Lista;
                ent_GuiaRemisionTransportista GRT = new ent_GuiaRemisionTransportista() { empr_Id = StaticVariable.obj_Empresa.Id };
                Lista = cln.ListarGRT(GRT, "GEN");
                dgv_GRT.DataSource = Lista;
                dgv_GRT.Refresh();
                ocultarColumnasGRT();

            }
            catch (Exception ex)
            {

            }
        }

        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            try
            {
                BasicMetod.ExportToExcel(dgv_GRT, "GUIAS DE REMISION TRANSPORTISTA" + DateTime.Now.ToString("ddMMyyyyHHmmss"));
            }
            catch (Exception ex)
            {

            }
        }
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            BasicMetod.CerrarPestaniaPrincipal("Guia Remisión");
        }
        private void cbo_Vehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_Vehiculo.SelectedIndex > -1)
            {
                ent_Vehiculo Vehiculo = (ent_Vehiculo)cbo_Vehiculo.SelectedItem;
                txt_Marca.Text = Vehiculo.Marca.Descripcion;

            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validarFormulario())
                {
                    ent_GuiaRemisionTransportista GRT = new ent_GuiaRemisionTransportista();
                    ent_GuiaRemisionTransportistaDetalle GRTD = new ent_GuiaRemisionTransportistaDetalle();
                    //Obtener el detalle
                    DataGridViewRow firstRow = dgv_DetalleGRT.Rows[0];

                    GRTD.Id = (int)firstRow.Cells["Id"].Value;
                    GRTD.Cantidad = Convert.ToDecimal(firstRow.Cells["Cantidad"].Value);
                    GRTD.Peso = Convert.ToDecimal(firstRow.Cells["Peso"].Value);
                    GRTD.PesoTotal = Convert.ToDecimal(firstRow.Cells["PesoTotal"].Value);
                    GRTD.Descripcion = Convert.ToString(firstRow.Cells["Descripcion"].Value);
                    //Obtener Cabecera
                    GRT.Carga = Carga;
                    GRT.Serie = txt_Serie.Text;
                    GRT.Correlativo = txt_Correlativo.Text;
                    if (cbo_Carreta.SelectedIndex > -1)
                    {
                        GRT.Carreta = (ent_Vehiculo)cbo_Carreta.SelectedItem;
                    }

                    GRT.empr_Id = ((ent_Empresa)cbo_Transportista.SelectedItem).Id;
                    GRT.Detalle = GRTD;
                    GRT.Piloto = (ent_Trabajador)cbo_Conductor.SelectedItem;
                    GRT.Piloto.Sucursal = StaticVariable.obj_Sucursal;
                    GRT.Vehiculo = (ent_Vehiculo)cbo_Vehiculo.SelectedItem;
                    GRT.NumeroLicencia = txt_NumeroLicencia.Text;
                    GRT.Fecha = DateOnly.FromDateTime(dtp_Fecha.Value);
                    GRT.FechaTraslado = DateOnly.FromDateTime(dtp_FechaTraslado.Value);
                    GRT.Serie = txt_Serie.Text;
                    GRT.Correlativo = txt_Correlativo.Text;
                    GRT.MotivoTraslado = (ent_Concepto)cbo_MotivoTraslado.SelectedItem;
                    GRT.NumeroDoc = txt_NumeroDoc.Text;
                    GRT.Peso = Convert.ToDecimal(txt_Peso.Text);
                    //GUARDAR GRT
                    cln_GuiaRemisionTransportista cln = new cln_GuiaRemisionTransportista();
                    ResponseHelper response = cln.registrarGRT(GRT, "I");
                    if (response != null)
                    {
                        if (response.codError == 0)
                        {
                            MessageBox.Show(response.mensajeError, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tpc_GuiaRemisionTransportista.SelectedIndex = 0;
                            tpc_GuiaRemisionTransportista.Controls[1].Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show(response.mensajeError, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
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
        #endregion
        #region "Métodos"
        private Boolean validarFormulario()
        {
            Boolean validar = false;
            if (txt_Serie.Text.Length != 4 ) { errorProvider1.SetError(txt_Serie,"Por favor ingrese una serie valida"); validar = true; } else { errorProvider1.SetError(txt_Serie, ""); }
            if (txt_Correlativo.Text.Length == 0) { errorProvider1.SetError(txt_Correlativo, "Por favor ingrese un correlativo para la GRT"); validar = true; } else { errorProvider1.SetError(txt_Correlativo, ""); }
            if (cbo_Vehiculo.SelectedIndex == -1) { errorProvider1.SetError(cbo_Vehiculo, "Por favor seleccione un vehiculo"); validar = true; } else { errorProvider1.SetError(cbo_Vehiculo, ""); }
            if (cbo_Conductor.SelectedIndex == -1) { errorProvider1.SetError(cbo_Conductor, "Por favor seleccione un conductor"); validar = true; } else { errorProvider1.SetError(cbo_Conductor, ""); }
            if (txt_Partida.Text.Length == 0) { errorProvider1.SetError(txt_Partida, "Por favor ingrese una direccion de partida"); validar = true; } else { errorProvider1.SetError(txt_Partida, ""); }
            if (txt_Llegada.Text.Length == 4) { errorProvider1.SetError(txt_Llegada, "Por favor ingrese una direccion de llegada"); validar = true; } else { errorProvider1.SetError(txt_Llegada, ""); }
            if (txt_NMtc.Text.Length == 0) { errorProvider1.SetError(txt_NMtc, "Por favor ingrese N° MTC"); validar = true; } else { errorProvider1.SetError(txt_NMtc, ""); }
            if (txt_NumeroLicencia.Text.Length == 0) { errorProvider1.SetError(txt_NumeroLicencia, "Por favor ingrese un numero de licencia de conductor"); validar = true; } else { errorProvider1.SetError(txt_NumeroLicencia, ""); }
            if (txt_NumeroDoc.Text.Length ==0 ) { errorProvider1.SetError(txt_NumeroDoc, "Por favor ingrese un numero de documento"); validar = true; } else { errorProvider1.SetError(txt_NumeroDoc, ""); }
            if (txt_Peso.Text.Length == 0) { errorProvider1.SetError(txt_Peso, "Por favor ingrese un Peso"); validar = true; } else { errorProvider1.SetError(txt_Peso, ""); }
            return validar;
        }
        private void construirFormulario()
        {
            try
            {
                dgv_GRT.CellFormatting += dgv_GRT_CellFormatting;
                tpc_GuiaRemisionTransportista.Controls[1].Enabled = true;
                if (mode == 2)
                {
                    tpc_GuiaRemisionTransportista.SelectedIndex = 1;
                    cargarClientes();
                    BasicMetod.cargarComboBox(cbo_MotivoTraslado, 38, "Correlativo", "Descripcion");
                    cargarVehiculo();
                    cargarCarreta();
                    cargarTransportista();
                    cargarConductor();
                    cargarCarga();
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
        private void cargarCarreta()
        {
            cln_Vehiculo cln_Vehiculo = new cln_Vehiculo();
            ent_Vehiculo Vehiculo = new ent_Vehiculo();
            Vehiculo.TipoVehiculo.Correlativo = 6;
            List<ent_Vehiculo> Lista = cln_Vehiculo.listarVehiculo(Vehiculo, "GEN");
            cbo_Carreta.DataSource = Lista;
            cbo_Carreta.ValueMember = "Id";
            cbo_Carreta.DisplayMember = "PlacaActual";
            cbo_Carreta.SelectedIndex = -1;
        }
        private void cargarCarga()
        {
            List<ent_Cliente> ListaCliente = (List<ent_Cliente>)cbo_Cliente.DataSource;
            List<ent_Cliente> ListaRemitente = (List<ent_Cliente>)cbo_ClienteRemitente.DataSource;
            List<ent_Cliente> ListaDestinatario = (List<ent_Cliente>)cbo_ClienteDestinatario.DataSource;
            int pos = 0;
            foreach (ent_Cliente Cliente in ListaCliente)
            {
                if (Cliente.Id == Carga.ClientePago.Id)
                {
                    cbo_Cliente.SelectedIndex = pos;
                    pos = 0;
                    break;
                }
                else
                {
                    pos++;
                }
            }
            foreach (ent_Cliente Cliente in ListaRemitente)
            {
                if (Cliente.Id == Carga.ClienteRemitente.Id)
                {
                    cbo_ClienteRemitente.SelectedIndex = pos;
                    pos = 0;
                    break;
                }
                else
                {
                    pos++;
                }
            }
            foreach (ent_Cliente Cliente in ListaDestinatario)
            {
                if (Cliente.Id == Carga.ClienteDestinatario.Id)
                {
                    cbo_ClienteDestinatario.SelectedIndex = pos;
                    pos = 0;
                    break;
                }
                else
                {
                    pos++;
                }
            }
            txt_Peso.Text = Convert.ToString(Carga.LiscaCarga[0].Peso);
            txt_Partida.Text = Carga.PuntoPartida;
            txt_Llegada.Text = Carga.PuntoLlegada;
            ent_CargaDetalle CD = Carga.LiscaCarga[0];
            dgv_DetalleGRT.Rows.Add(0, CD.ProductoTransportar, CD.Cantidad, CD.Peso, CD.Cantidad * CD.Peso);
        }
        private void cargarTransportista()
        {
            List<ent_Empresa> Lista = new List<ent_Empresa>() { StaticVariable.obj_Empresa };
            cbo_Transportista.DataSource = Lista;
            cbo_Transportista.ValueMember = "Id";
            cbo_Transportista.DisplayMember = "RazonSocial";
        }
        private void cargarConductor()
        {
            List<ent_Trabajador> Lista;
            cln_Trabajador cln_Trabajador = new cln_Trabajador();
            ent_Trabajador Trabajador = new ent_Trabajador();
            Trabajador.Piloto.Correlativo = 2;
            Lista = cln_Trabajador.ListarTrabajador(Trabajador);
            cbo_Conductor.DataSource = Lista;
            cbo_Conductor.DisplayMember = "NombresCompletos";
            cbo_Conductor.ValueMember = "Id";
            cbo_Conductor.SelectedIndex = -1;
        }
        private void cargarVehiculo()
        {
            cln_Vehiculo cln_Vehiculo = new cln_Vehiculo();
            ent_Vehiculo Vehiculo = new ent_Vehiculo();
            List<ent_Vehiculo> Lista = cln_Vehiculo.listarVehiculo(Vehiculo, "GEN");
            cbo_Vehiculo.DataSource = Lista;
            cbo_Vehiculo.ValueMember = "Id";
            cbo_Vehiculo.DisplayMember = "PlacaActual";
            cbo_Vehiculo.SelectedIndex = -1;
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
            List<ent_Cliente> ListaDestinatario = cln_Cliente.ListarCliente(new ent_Cliente(), "CLI");
            cbo_ClienteDestinatario.DataSource = ListaRemitente;
            cbo_ClienteDestinatario.DisplayMember = "RazonSocial";
            cbo_ClienteDestinatario.ValueMember = "Id";
        }

        private void ocultarColumnasGRT()
        {
            dgv_GRT.Columns["Carga"].Visible = false;
            dgv_GRT.Columns["Id"].Visible = false;
            dgv_GRT.Columns["empr_Id"].Visible = false;
            dgv_GRT.Columns["Marcabaja"].Visible = false;
            dgv_GRT.Columns["Usuario"].Visible = false;
            dgv_GRT.Columns["Ip"].Visible = false;
            dgv_GRT.Columns["Mac"].Visible = false;
            dgv_GRT.Columns["HostName"].Visible = false;
            dgv_GRT.Columns["HostUser"].Visible = false;
        }
        #endregion
        
    }
}
