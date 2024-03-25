using CEN;
using CEN.Entidad;
using CEN.Helpers;
using CEN.Response;
using CLN;
using Principal.Helpers;
using System;
using System.Collections;
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
    public partial class frm_RecepcionCarga : Form
    {
        #region "Variables"
        private string currentInput = "";
        private string currentInputSubtotal = "";
        private string currentInputFleteSinIGV = "";
        private string currentInputAdelanto = "";
        private string currentInputComision = "";
        private string currentInputConsolidado = "";
        private string currentInputConEstiba = "";
        private string currentInputCEstibaDesc = "";
        private string currentInputPrecioUnitConIGV = "";
        #endregion

        #region "Constructor"
        public frm_RecepcionCarga()
        {
            InitializeComponent();
            InicializarFormulario();
        }
        #endregion

        #region "Métodos"
        private void ocultarColumnas()
        {
            dgb_Carga.Columns["Id"].Visible = false;
            dgb_Carga.Columns["empr_Id"].Visible = false;
            dgb_Carga.Columns["Id"].Visible = false;
            dgb_Carga.Columns["ClaveSeguridad"].Visible = false;
            dgb_Carga.Columns["Marcabaja"].Visible = false;
            dgb_Carga.Columns["Usuario"].Visible = false;
            dgb_Carga.Columns["Ip"].Visible = false;
            dgb_Carga.Columns["Mac"].Visible = false;
            dgb_Carga.Columns["HostName"].Visible = false;
            dgb_Carga.Columns["HostUser"].Visible = false;
        }
        private ent_Carga llenarCarga()
        {
            ent_Carga carga = new ent_Carga();
            ent_CargaDetalle cargaDet = new ent_CargaDetalle();
            carga.Codigo = txt_Codigo.Text;
            carga.Estado = new ent_Concepto() { Correlativo = 2 };
            carga.TipoServicio = (ent_Concepto)cbo_TipoServicio.SelectedItem;
            carga.FechaSolicita = new DateTime(dtp_FechaSolicita.Value.Year, dtp_FechaSolicita.Value.Month, dtp_FechaSolicita.Value.Day, dtp_HoraSolicita.Value.Hour, dtp_HoraSolicita.Value.Minute, dtp_HoraSolicita.Value.Second);
            carga.FechaRecepcion = new DateTime(dtp_FechaRecepcion.Value.Year, dtp_FechaRecepcion.Value.Month, dtp_FechaRecepcion.Value.Day, dtp_HoraRecepcion.Value.Hour, dtp_HoraRecepcion.Value.Minute, dtp_HoraRecepcion.Value.Second);
            carga.FechaAtencion = new DateTime(dtp_FechaAtencion.Value.Year, dtp_FechaAtencion.Value.Month, dtp_FechaAtencion.Value.Day, dtp_HoraAtencion.Value.Hour, dtp_HoraAtencion.Value.Minute, dtp_HoraAtencion.Value.Second);
            carga.LugarOrigen = (ent_Ubigeo)cbo_OrigenCabecera.SelectedItem;
            carga.LugarDestino = (ent_Ubigeo)cbo_DestinoCabecera.SelectedItem;
            carga.CondicionPago = (ent_Concepto)cbo_CondicionPago.SelectedItem;
            carga.TipoEntrega = (ent_Concepto)cbo_TipoEntrega.SelectedItem;
            carga.Tercero = chk_Tercerizado.Checked;
            carga.FleteTotal = Convert.ToDouble(txt_FleteTotalCab.Text);//Por Revisar
            carga.Vendedor = StaticVariable.obj_Usuario.Usua_Usuario;
            carga.Observacion = txt_Observacion.Text;
            carga.RecojoDomicilio = chk_RecojoDomicilioLugar.Checked;
            carga.RecojoDomicilioLugar = (ent_Ubigeo)cbo_DomicilioLugar.SelectedItem;
            carga.DireccionRecojoDomicilio = txt_DireccionRecojoDomicilio.Text;
            carga.TipoVehiculo = (ent_Concepto)cbo_TipoVehiculo.SelectedItem;
            carga.ClienteRemitente = (ent_Cliente)cbo_ClienteRemitente.SelectedItem;
            carga.ClienteDestinatario = (ent_Cliente)cbo_ClienteDestinatario.SelectedItem;
            carga.PuntoPartida = ((ent_Direccion)cbo_DireccionPartida.SelectedItem);
            carga.PuntoLlegada = ((ent_Direccion)cbo_DireccionLlegada.SelectedItem);
            carga.Anexos = txt_Anexos.Text;
            carga.ClaveSeguridad = txt_ClaveSeguridad.Text;
            carga.ClientePago = (ent_Cliente)cbo_ClientePaga.SelectedItem;
            carga.DireccionFacturacion = txt_DireccionFacturacion.Text;
            carga.sucu_Id = StaticVariable.obj_Sucursal.Id;
            carga.Marcabaja = 1;

            //CARGA DETALLE INICIO
            cargaDet.LugarOrigen = (ent_Ubigeo)cbo_OrigenDetalle.SelectedItem;
            cargaDet.LugarDestino = (ent_Ubigeo)cbo_DestinoDetalle.SelectedItem;
            cargaDet.TipoCarga = (ent_Concepto)cbo_TipoCarga.SelectedItem;
            cargaDet.Cantidad = txt_Cantidad.Text.Length > 0 ? Convert.ToDouble(txt_Cantidad.Text) : 0.0;
            cargaDet.Peso = txt_Peso.Text.Length > 0 ? Convert.ToDouble(txt_Peso.Text) : 0.0;
            cargaDet.ClienteRecepcion = (ent_Cliente)cbo_ClienteRecepcion.SelectedItem;
            cargaDet.ClienteFinal = (ent_Cliente)cbo_ClienteFinal.SelectedItem;
            if (cbo_Comisionista.SelectedIndex > -1)
            {
                cargaDet.Comisionista = (ent_Cliente)cbo_Comisionista.SelectedItem;
            }
            cargaDet.ProductoTransportar = txt_ProductoTransportar.Text;
            cargaDet.ValorUnitario = txt_FleteSinIGV.Text.Length > 0 ? Convert.ToDouble(txt_FleteSinIGV.Text) : 0.0;
            cargaDet.PrecioUnitario = txt_PrecioUnitario.Text.Length > 0 ? Convert.ToDouble(txt_PrecioUnitario.Text) : 0.0;
            cargaDet.ValorAfecto = txt_Subtotal.Text.Length > 0 ? Convert.ToDouble(txt_Subtotal.Text) : 0.0;
            cargaDet.IGV = Convert.ToDouble(txt_FleteTotal.Text) - Convert.ToDouble(txt_Subtotal.Text);
            cargaDet.Total = Convert.ToDouble(txt_FleteTotal.Text);
            cargaDet.Adelanto = txt_Adelanto.Text.Length > 0 ? Convert.ToDouble(txt_Adelanto.Text) : 0.0;
            cargaDet.Comision = txt_Comision.Text.Length > 0 ? Convert.ToDouble(txt_Comision.Text) : 0.0;
            cargaDet.Facturado = chk_Facturado.Checked;
            cargaDet.FalsoFlete = chk_FalsoFlete.Checked;
            cargaDet.Consolidado = txt_Consolidado.Text.Length > 0 ? Convert.ToDouble(txt_Consolidado.Text) : 0.0;
            cargaDet.ConEstiba = txt_ConEstiba.Text.Length > 0 ? Convert.ToDouble(txt_ConEstiba.Text) : 0.0;
            cargaDet.CEstibaDesc = txt_CEstibaDesc.Text.Length > 0 ? Convert.ToDouble(txt_CEstibaDesc.Text) : 0.0;
            cargaDet.PagoContraEntrega = chk_PagoContraEntrega.Checked;
            cargaDet.FormaPago = new ent_Concepto()
            {
                Prefijo = 37,
                Correlativo = (rbt_Efectivo.Checked ? 1 : (rbt_Deposito.Checked ? 2 : 3))
            };
            cargaDet.Carga = chk_Carga.Checked;
            cargaDet.Descarga = chk_Descarga.Checked;
            cargaDet.Marcabaja = 1;
            //CARGA DETALLE FIN

            carga.LiscaCarga.Add(cargaDet);
            return carga;
        }

        public void InicializarFormulario()
        {
            dgb_Carga.CellFormatting += dgb_Carga_CellFormatting;
            tpc_RecepcionCarga.TabPages[1].Enabled = false;
            tpc_Carga.TabPages[1].Enabled = false;
            txt_Cantidad.Text = "1.0";
            llenarColoresComboBox();
            cargarComboBox();
        }


        public void cargarComboBox()
        {
            try
            {
                cargarRutaOrigen();
                cargarRecojoDomicilio();
                cargarMoneda();
                cargarTipoServicio();
                cargarCondicionPago();
                cargarTipoEntrega();
                cargarTipoVehiculo();
                cargarEstadoCarga();
                cargarUsuarioFilter();
                cargarTipoCarga();
                cargarClienteFinal();
                cargarClienteRecepcion();
                cargarClientePaga();
                cargarComisionista();
                cargarVendedor();
                cbo_DireccionPartida.SelectedIndex = -1;
                cbo_DireccionLlegada.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ent_ControlError obj = new ent_ControlError();
                obj.Cerr_MensajeError = ex.Message;
                obj.Cerr_Traza = ex.StackTrace;
                obj.Cerr_Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
                obj.Cerr_Trama = "4";
                obj.Cerr_Formulario = "Login";
                obj.Cerr_FechaError = DateOnly.Parse(DateTime.Now.ToShortDateString());
                cln_ControlError cln = new cln_ControlError();
                cln.registrarError(obj);
                MessageBox.Show("Ocurrió un error interno, por favor vuelve a intentar", BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarVendedor()
        {
            //try
            //{
            //    cln_Trabajador cln = new cln_Trabajador();
            //    List<ent_Trabajador> lista = cln.ListarTrabajador(new ent_Trabajador());
            //    cbo_Vendedor.DataSource = lista;
            //    cbo_OrigenCabecera.ValueMember = "Ubigeo";
            //    cbo_OrigenCabecera.DisplayMember = "Descripcion";

            //    cbo_OrigenDetalle.DataSource = lista;
            //    cbo_OrigenDetalle.ValueMember = "Ubigeo";
            //    cbo_OrigenDetalle.DisplayMember = "Descripcion";
            //}
            //catch (Exception ex)
            //{
            //    ent_ControlError obj = new ent_ControlError();
            //    obj.Cerr_MensajeError = ex.Message;
            //    obj.Cerr_Traza = ex.StackTrace;
            //    obj.Cerr_Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
            //    obj.Cerr_Trama = "4";
            //    obj.Cerr_Formulario = "Login";
            //    obj.Cerr_FechaError = DateOnly.Parse(DateTime.Now.ToShortDateString());
            //    cln_ControlError cln = new cln_ControlError();
            //    cln.registrarError(obj);
            //    MessageBox.Show("Ocurrió un error interno, por favor vuelve a intentar", BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        public void cargarRecojoDomicilio()
        {
            try
            {
                cln_Ubigeo cln = new cln_Ubigeo();
                List<ent_Ubigeo> lista = cln.listarUbigeo(3, "", "", "");
                cbo_DomicilioLugar.DataSource = lista;
                cbo_DomicilioLugar.ValueMember = "Ubigeo";
                cbo_DomicilioLugar.DisplayMember = "Descripcion";

            }
            catch (Exception ex)
            {
                ent_ControlError obj = new ent_ControlError();
                obj.Cerr_MensajeError = ex.Message;
                obj.Cerr_Traza = ex.StackTrace;
                obj.Cerr_Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
                obj.Cerr_Trama = "4";
                obj.Cerr_Formulario = "Login";
                obj.Cerr_FechaError = DateOnly.Parse(DateTime.Now.ToShortDateString());
                cln_ControlError cln = new cln_ControlError();
                cln.registrarError(obj);
                MessageBox.Show("Ocurrió un error interno, por favor vuelve a intentar", BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarRutaOrigen()
        {
            try
            {
                cln_Ubigeo cln = new cln_Ubigeo();
                List<ent_Ubigeo> lista = cln.listarUbigeo(3, "", "", "");
                cbo_OrigenCabecera.DataSource = lista;
                cbo_OrigenCabecera.ValueMember = "Ubigeo";
                cbo_OrigenCabecera.DisplayMember = "Descripcion";
                cbo_OrigenCabecera.SelectedIndex = -1;

                cbo_OrigenDetalle.DataSource = lista;
                cbo_OrigenDetalle.ValueMember = "Ubigeo";
                cbo_OrigenDetalle.DisplayMember = "Descripcion";
                cbo_OrigenDetalle.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ent_ControlError obj = new ent_ControlError();
                obj.Cerr_MensajeError = ex.Message;
                obj.Cerr_Traza = ex.StackTrace;
                obj.Cerr_Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
                obj.Cerr_Trama = "4";
                obj.Cerr_Formulario = "Login";
                obj.Cerr_FechaError = DateOnly.Parse(DateTime.Now.ToShortDateString());
                cln_ControlError cln = new cln_ControlError();
                cln.registrarError(obj);
                MessageBox.Show("Ocurrió un error interno, por favor vuelve a intentar", BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarComisionista()
        {
            try
            {
                cln_Cliente cln_Cliente = new cln_Cliente();
                ent_Cliente ent_Cliente = new ent_Cliente();
                ent_Cliente.Empresa = StaticVariable.obj_Empresa;
                ent_Cliente.Comisionista = true;
                List<ent_Cliente> ListaCliente = cln_Cliente.ListarCliente(ent_Cliente, "COM");
                cbo_Comisionista.DataSource = ListaCliente;
                cbo_Comisionista.DisplayMember = "RazonSocial";
                cbo_Comisionista.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

            }
        }

        public void cargarClienteFinal()
        {
            try
            {
                cln_Cliente cln_Cliente = new cln_Cliente();
                ent_Cliente ent_Cliente = new ent_Cliente();
                ent_Cliente.Empresa = StaticVariable.obj_Empresa;

                List<ent_Cliente> ListaCliente = cln_Cliente.ListarCliente(ent_Cliente, "CLI");
                cbo_ClienteFinal.DataSource = ListaCliente;
                cbo_ClienteFinal.DisplayMember = "RazonSocial";
                cbo_ClienteFinal.SelectedIndex = -1;

                cbo_ClienteDestinatario.DataSource = ListaCliente;
                cbo_ClienteDestinatario.DisplayMember = "RazonSocial";
                cbo_ClienteDestinatario.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

            }
        }

        public void cargarClientePaga()
        {
            try
            {
                cln_Cliente cln_Cliente = new cln_Cliente();
                ent_Cliente ent_Cliente = new ent_Cliente();
                ent_Cliente.Empresa = StaticVariable.obj_Empresa;

                List<ent_Cliente> ListaCliente = cln_Cliente.ListarCliente(ent_Cliente, "CLI");
                cbo_ClientePaga.DataSource = ListaCliente;
                cbo_ClientePaga.DisplayMember = "RazonSocial";
                cbo_ClientePaga.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

            }
        }

        public void cargarClienteRecepcion()
        {
            try
            {
                cln_Cliente cln_Cliente = new cln_Cliente();
                ent_Cliente ent_Cliente = new ent_Cliente();
                ent_Cliente.Empresa = StaticVariable.obj_Empresa;

                List<ent_Cliente> ListaCliente = cln_Cliente.ListarCliente(ent_Cliente, "CLI");
                cbo_ClienteRecepcion.DataSource = ListaCliente;
                cbo_ClienteRecepcion.DisplayMember = "RazonSocial";
                cbo_ClienteRecepcion.SelectedIndex = -1;

                cbo_ClienteRemitente.DataSource = ListaCliente;
                cbo_ClienteRemitente.DisplayMember = "RazonSocial";
                cbo_ClienteRemitente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

            }
        }

        public void cargarUsuarioFilter()
        {
            List<ent_Usuario> ListaUsuario = new List<ent_Usuario>();
            ent_Usuario Todos = new ent_Usuario();
            Todos.Usua_Id = 0;
            Todos.Usua_Usuario = "TODOS";
            ListaUsuario.Add(Todos);
            ListaUsuario.Add(StaticVariable.obj_Usuario);
            cbo_UsuarioFilter.DataSource = ListaUsuario;
            cbo_UsuarioFilter.ValueMember = "Usua_Usuario";
            cbo_UsuarioFilter.DisplayMember = "Usua_Usuario";
        }

        public void cargarTipoCarga()
        {
            List<ent_Concepto> lista;
            cln_Concepto cln = new cln_Concepto();
            lista = cln.listarConcepto(20);
            cbo_TipoCarga.DataSource = lista;
            cbo_TipoCarga.ValueMember = "Descripcion";
            cbo_TipoCarga.DisplayMember = "Descripcion";
        }

        public void cargarEstadoCarga()
        {
            List<ent_Concepto> lista;
            cln_Concepto cln = new cln_Concepto();
            lista = cln.listarConcepto(16);
            cbo_EstadoCarga.DataSource = lista;
            cbo_EstadoCarga.ValueMember = "Descripcion";
            cbo_EstadoCarga.DisplayMember = "Descripcion";
        }

        public void cargarTipoVehiculo()
        {
            List<ent_Concepto> lista;
            cln_Concepto cln = new cln_Concepto();
            lista = cln.listarConcepto(22);
            cbo_TipoVehiculo.DataSource = lista;
            cbo_TipoVehiculo.ValueMember = "Descripcion";
            cbo_TipoVehiculo.DisplayMember = "Descripcion";
        }

        public void cargarTipoEntrega()
        {
            List<ent_Concepto> lista;
            cln_Concepto cln = new cln_Concepto();
            lista = cln.listarConcepto(19);
            cbo_TipoEntrega.DataSource = lista;
            cbo_TipoEntrega.ValueMember = "Descripcion";
            cbo_TipoEntrega.DisplayMember = "Descripcion";
        }

        public void cargarCondicionPago()
        {
            List<ent_Concepto> lista;
            cln_Concepto cln = new cln_Concepto();
            lista = cln.listarConcepto(18);
            cbo_CondicionPago.DataSource = lista;
            cbo_CondicionPago.ValueMember = "Descripcion";
            cbo_CondicionPago.DisplayMember = "Descripcion";
        }

        public void cargarMoneda()
        {
            List<ent_Concepto> lista;
            cln_Concepto cln = new cln_Concepto();
            lista = cln.listarConcepto(21);
            cbo_MonedaContratoTercero.DataSource = lista;
            cbo_MonedaContratoTercero.ValueMember = "Descripcion";
            cbo_MonedaContratoTercero.DisplayMember = "Abreviatura";

            lista = cln.listarConcepto(21);
            cbo_MonedaDetalleCarga.DataSource = lista;
            cbo_MonedaDetalleCarga.ValueMember = "Descripcion";
            cbo_MonedaDetalleCarga.DisplayMember = "Abreviatura";
        }

        public void cargarTipoServicio()
        {
            List<ent_Concepto> lista;
            cln_Concepto cln = new cln_Concepto();
            lista = cln.listarConcepto(17);
            cbo_TipoServicio.DataSource = lista;
            cbo_TipoServicio.ValueMember = "Descripcion";
            cbo_TipoServicio.DisplayMember = "Descripcion";
        }
        public Boolean ValidarControles()
        {
            Boolean result = false;
            if (cbo_OrigenCabecera.SelectedIndex == -1) { result = true; errorProvider1.SetError(cbo_OrigenCabecera, "Por favor, seleccione un lugar de origen"); }
            if (cbo_DestinoCabecera.SelectedIndex == -1) { result = true; errorProvider1.SetError(cbo_DestinoCabecera, "Por favor, seleccione un lugar de destino"); }
            if (txt_FleteTotalCab.Text.Length == 0) { result = true; errorProvider1.SetError(txt_FleteTotalCab, "Por favor, ingrese un flete total"); }
            if (cbo_OrigenDetalle.SelectedIndex == -1) { result = true; errorProvider1.SetError(cbo_OrigenDetalle, "Por favor, seleccione un lugar de origen"); }
            if (cbo_DestinoDetalle.SelectedIndex == -1) { result = true; errorProvider1.SetError(cbo_DestinoDetalle, "Por favor, seleccione un lugar de destino"); }
            if (!rbt_Efectivo.Checked && !rbt_Deposito.Checked && !rbt_Otros.Checked) { result = true; errorProvider1.SetError(rbt_Efectivo, "Por favor, seleccione una forma de pago"); }
            if (cbo_ClienteRecepcion.SelectedIndex == -1) { result = true; errorProvider1.SetError(cbo_ClienteRecepcion, "Por favor, seleccione un cliente"); }
            if (cbo_ClienteFinal.SelectedIndex == -1) { result = true; errorProvider1.SetError(cbo_ClienteFinal, "Por favor, seleccione un cliente"); }
            if (txt_ProductoTransportar.Text.Length == 0) { result = true; errorProvider1.SetError(txt_ProductoTransportar, "Por favor, ingrese material a transportar"); }
            if (cbo_ClienteRemitente.SelectedIndex == -1) { result = true; errorProvider1.SetError(cbo_ClienteRemitente, "Por favor, seleccione un cliente"); }
            if (cbo_ClienteDestinatario.SelectedIndex == -1) { result = true; errorProvider1.SetError(cbo_ClienteDestinatario, "Por favor, seleccione un cliente"); }
            if (cbo_DireccionPartida.SelectedIndex == -1) { result = true; errorProvider1.SetError(cbo_DireccionPartida, "Por favor, ingrese punto de partida"); }
            if (cbo_DireccionLlegada.SelectedIndex == -1) { result = true; errorProvider1.SetError(cbo_DireccionLlegada, "Por favor, ingrese punto de llegada"); }
            if (txt_Anexos.Text.Length == 0) { result = true; errorProvider1.SetError(txt_Anexos, "Por favor, ingrese documentos de Anexo"); }
            if (txt_DireccionFacturacion.Text.Length == 0) { result = true; errorProvider1.SetError(txt_DireccionFacturacion, "Por favor, ingrese una direccion de facturacion"); }

            return result;
        }
        public void llenarColoresComboBox()
        {
            //CBO_COLOR_GENERADA
            cbo_Color_Generada.DataSource = typeof(Color).GetProperties()
                                        .Where(x => x.PropertyType == typeof(Color))
                                        .Select(x => x.GetValue(null)).ToList();
            cbo_Color_Generada.MaxDropDownItems = 10;
            cbo_Color_Generada.IntegralHeight = false;
            cbo_Color_Generada.DrawMode = DrawMode.OwnerDrawFixed;
            cbo_Color_Generada.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Color_Generada.SelectedIndex = 16;
            cbo_Color_Generada.DrawItem += cbo_Color_Generada_DrawItem;

            //CBO_COLOR_PARCIAL
            cbo_Color_Parcial.DataSource = typeof(Color).GetProperties()
                                        .Where(x => x.PropertyType == typeof(Color))
                                        .Select(x => x.GetValue(null)).ToList();
            cbo_Color_Parcial.MaxDropDownItems = 10;
            cbo_Color_Parcial.IntegralHeight = false;
            cbo_Color_Parcial.DrawMode = DrawMode.OwnerDrawFixed;
            cbo_Color_Parcial.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Color_Parcial.SelectedIndex = 16;
            cbo_Color_Parcial.DrawItem += cbo_Color_Parcial_DrawItem;

            //CBO_COLOR_ASIGNADA
            cbo_Color_Asignada.DataSource = typeof(Color).GetProperties()
                                        .Where(x => x.PropertyType == typeof(Color))
                                        .Select(x => x.GetValue(null)).ToList();
            cbo_Color_Asignada.MaxDropDownItems = 10;
            cbo_Color_Asignada.IntegralHeight = false;
            cbo_Color_Asignada.DrawMode = DrawMode.OwnerDrawFixed;
            cbo_Color_Asignada.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Color_Asignada.SelectedIndex = 16;
            cbo_Color_Asignada.DrawItem += cbo_Color_Asignada_DrawItem;

            //CBO_COLOR_ACTUALIZADA
            cbo_Color_Actualizado.DataSource = typeof(Color).GetProperties()
                                        .Where(x => x.PropertyType == typeof(Color))
                                        .Select(x => x.GetValue(null)).ToList();
            cbo_Color_Actualizado.MaxDropDownItems = 10;
            cbo_Color_Actualizado.IntegralHeight = false;
            cbo_Color_Actualizado.DrawMode = DrawMode.OwnerDrawFixed;
            cbo_Color_Actualizado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Color_Actualizado.SelectedIndex = 16;
            cbo_Color_Actualizado.DrawItem += cbo_Color_Actualizado_DrawItem;

            //CBO_COLOR_CANCELADA
            cbo_Color_Cancelada.DataSource = typeof(Color).GetProperties()
                                        .Where(x => x.PropertyType == typeof(Color))
                                        .Select(x => x.GetValue(null)).ToList();
            cbo_Color_Cancelada.MaxDropDownItems = 10;
            cbo_Color_Cancelada.IntegralHeight = false;
            cbo_Color_Cancelada.DrawMode = DrawMode.OwnerDrawFixed;
            cbo_Color_Cancelada.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Color_Cancelada.SelectedIndex = 16;
            cbo_Color_Cancelada.DrawItem += cbo_Color_Cancelada_DrawItem;

            //CBO_COLOR_APROBADA
            cbo_Color_Aprobada.DataSource = typeof(Color).GetProperties()
                                        .Where(x => x.PropertyType == typeof(Color))
                                        .Select(x => x.GetValue(null)).ToList();
            cbo_Color_Aprobada.MaxDropDownItems = 10;
            cbo_Color_Aprobada.IntegralHeight = false;
            cbo_Color_Aprobada.DrawMode = DrawMode.OwnerDrawFixed;
            cbo_Color_Aprobada.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Color_Aprobada.SelectedIndex = 16;
            cbo_Color_Aprobada.DrawItem += cbo_Color_Aprobada_DrawItem;
        }


        #endregion

        #region "Eventos"
        private void txt_Subtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //currentInputSubtotal Subtotal  = txt_Subtotal.Text;
            // Verifica si la tecla presionada es la tecla de retroceso
            if (e.KeyChar == '\b')
            {
                // Aquí puedes realizar la lógica deseada al presionar la tecla de retroceso.
                // Por ejemplo, eliminar el último carácter del texto actual.
                if (txt_Subtotal.Text.Length > 0)
                {
                    currentInputSubtotal = txt_Subtotal.Text.Substring(0, txt_Subtotal.Text.Length - 1);
                    // Formatea el texto con los dos últimos dígitos en la parte decimal
                    if (currentInputSubtotal.Length >= 2 && !currentInputSubtotal.Contains("."))
                    {
                        int length = currentInputSubtotal.Length;
                        txt_Subtotal.Text = currentInputSubtotal.Substring(0, length - 2) + "." + currentInputSubtotal.Substring(length - 2);
                    }
                    else
                    {
                        txt_Subtotal.Text = currentInputSubtotal;
                    }
                }
            }
            else
            {
                // Verifica si la tecla presionada es un número
                if (char.IsDigit(e.KeyChar))
                {
                    // Agrega el dígito a la cadena de entrada actual
                    currentInputSubtotal += e.KeyChar;

                    // Formatea el texto con los dos últimos dígitos en la parte decimal
                    if (currentInputSubtotal.Length >= 2 && !currentInputSubtotal.Contains("."))
                    {
                        int length = currentInputSubtotal.Length;
                        txt_Subtotal.Text = currentInputSubtotal.Substring(0, length - 2) + "." + currentInputSubtotal.Substring(length - 2);
                    }
                    else
                    {
                        txt_Subtotal.Text = currentInputSubtotal;
                    }
                }
            }


            e.Handled = true; // Evita que el evento KeyPress procese la tecla nuevamente
        }

        private void txt_Subtotal_KeyUp(object sender, KeyEventArgs e)
        {
            Double Subtotal;
            Double Igv;
            Double Gravada;
            Double TotalFlete;
            Double Cantidad;

            if (e.KeyCode == Keys.Enter)
            {
                Subtotal = Convert.ToDouble(txt_Subtotal.Text);
                Cantidad = Convert.ToDouble(txt_Cantidad.Text);
                if (chk_IncluyeIGVFlete.Checked)
                {
                    Gravada = Subtotal / 1.18;
                    Igv = Subtotal - Gravada;
                }
                else
                {
                    Gravada = Subtotal;
                    Subtotal = Gravada + Subtotal * 0.18;
                    Igv = Subtotal - Gravada;
                }
                TotalFlete = Subtotal * Cantidad;

                Gravada = Math.Round(Gravada, 2);
                Igv = Math.Round(Igv, 2);
                Subtotal = Math.Round(Subtotal, 2);
                TotalFlete = Math.Round(Subtotal, 2);

                txt_FleteSinIGV.Text = Gravada.ToString("0.00");
                txt_Subtotal.Text = Subtotal.ToString("0.00");
                txt_PrecioUnitario.Text = Igv.ToString("0.00");
                txt_FleteTotal.Text = TotalFlete.ToString("0.00");
            }
        }

        private void cbo_ClienteRecepcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_ClienteRecepcion.SelectedIndex > -1)
                {
                    ent_Cliente Cliente = (ent_Cliente)cbo_ClienteRecepcion.SelectedItem;
                    txt_DocClienteRecepcion.Text = Cliente.Persona.DocIdentidad;
                }
                else
                {
                    txt_DocClienteRecepcion.Text = "";
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void txt_DocClienteRecepcion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    String Documento = txt_DocClienteRecepcion.Text;
                    List<ent_Cliente> ListaClientes = (List<ent_Cliente>)cbo_ClienteRecepcion.DataSource;
                    foreach (ent_Cliente Cliente in ListaClientes)
                    {
                        if (Cliente.Persona.DocIdentidad == Documento)
                        {
                            cbo_ClienteRecepcion.SelectedItem = Cliente;
                        }
                    }
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void cbo_OrigenCabecera_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_OrigenCabecera.SelectedIndex > -1)
                {
                    errorProvider1.SetError(cbo_OrigenCabecera, "");
                    cln_Ruta cln = new cln_Ruta();
                    ent_Ruta Ruta = new ent_Ruta();
                    Ruta.DistritoOrigen.Ubigeo = ((ent_Ubigeo)cbo_OrigenCabecera.SelectedItem).Ubigeo;
                    List<ent_Ruta> Lista = cln.ListarRuta(Ruta, "GEN");
                    List<ent_Ubigeo> ListaUbigeo = new List<ent_Ubigeo>();
                    foreach (ent_Ruta RutaDet in Lista)
                    {
                        ListaUbigeo.Add(RutaDet.DistritoDestino);
                    }
                    cbo_DestinoCabecera.DataSource = null;
                    cbo_DestinoCabecera.DataSource = ListaUbigeo;
                    if (Lista.Count > 0)
                    {


                        cbo_DestinoCabecera.ValueMember = "Ubigeo";
                        cbo_DestinoCabecera.DisplayMember = "Descripcion";
                    }
                    else
                    {
                        cbo_DestinoCabecera.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void cbo_OrigenDetalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_OrigenDetalle.SelectedIndex > -1)
                {
                    cln_Ruta cln = new cln_Ruta();
                    ent_Ruta Ruta = new ent_Ruta();
                    Ruta.DistritoOrigen.Ubigeo = ((ent_Ubigeo)cbo_OrigenDetalle.SelectedItem).Ubigeo;
                    List<ent_Ruta> Lista = cln.ListarRuta(Ruta, "GEN");
                    List<ent_Ubigeo> ListaUbigeo = new List<ent_Ubigeo>();
                    foreach (ent_Ruta RutaDet in Lista)
                    {
                        ListaUbigeo.Add(RutaDet.DistritoDestino);
                    }
                    cbo_DestinoDetalle.DataSource = null;
                    cbo_DestinoDetalle.DataSource = ListaUbigeo;
                    if (Lista.Count > 0)
                    {
                        cbo_DestinoDetalle.ValueMember = "Ubigeo";
                        cbo_DestinoDetalle.DisplayMember = "Descripcion";
                    }
                    else
                    {
                        cbo_DestinoDetalle.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void cbo_Color_Aprobada_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                var txt = cbo_Color_Aprobada.GetItemText(cbo_Color_Aprobada.Items[e.Index]);
                var color = (Color)cbo_Color_Aprobada.Items[e.Index];
                var r1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                var r2 = Rectangle.FromLTRB(r1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (var b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, r1);
                e.Graphics.DrawRectangle(Pens.Black, r1);
                TextRenderer.DrawText(e.Graphics, txt, cbo_Color_Aprobada.Font, r2,
                    cbo_Color_Aprobada.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }

        private void cbo_Color_Cancelada_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                var txt = cbo_Color_Cancelada.GetItemText(cbo_Color_Cancelada.Items[e.Index]);
                var color = (Color)cbo_Color_Cancelada.Items[e.Index];
                var r1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                var r2 = Rectangle.FromLTRB(r1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (var b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, r1);
                e.Graphics.DrawRectangle(Pens.Black, r1);
                TextRenderer.DrawText(e.Graphics, txt, cbo_Color_Cancelada.Font, r2,
                    cbo_Color_Cancelada.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }

        private void cbo_Color_Actualizado_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                var txt = cbo_Color_Actualizado.GetItemText(cbo_Color_Actualizado.Items[e.Index]);
                var color = (Color)cbo_Color_Actualizado.Items[e.Index];
                var r1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                var r2 = Rectangle.FromLTRB(r1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (var b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, r1);
                e.Graphics.DrawRectangle(Pens.Black, r1);
                TextRenderer.DrawText(e.Graphics, txt, cbo_Color_Actualizado.Font, r2,
                    cbo_Color_Actualizado.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }

        private void cbo_Color_Asignada_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                var txt = cbo_Color_Asignada.GetItemText(cbo_Color_Asignada.Items[e.Index]);
                var color = (Color)cbo_Color_Asignada.Items[e.Index];
                var r1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                var r2 = Rectangle.FromLTRB(r1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (var b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, r1);
                e.Graphics.DrawRectangle(Pens.Black, r1);
                TextRenderer.DrawText(e.Graphics, txt, cbo_Color_Asignada.Font, r2,
                    cbo_Color_Asignada.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }

        private void cbo_Color_Parcial_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                var txt = cbo_Color_Parcial.GetItemText(cbo_Color_Parcial.Items[e.Index]);
                var color = (Color)cbo_Color_Parcial.Items[e.Index];
                var r1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                var r2 = Rectangle.FromLTRB(r1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (var b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, r1);
                e.Graphics.DrawRectangle(Pens.Black, r1);
                TextRenderer.DrawText(e.Graphics, txt, cbo_Color_Parcial.Font, r2,
                    cbo_Color_Parcial.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }

        private void cbo_Color_Generada_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                var txt = cbo_Color_Generada.GetItemText(cbo_Color_Generada.Items[e.Index]);
                var color = (Color)cbo_Color_Generada.Items[e.Index];
                var r1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                var r2 = Rectangle.FromLTRB(r1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (var b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, r1);
                e.Graphics.DrawRectangle(Pens.Black, r1);
                TextRenderer.DrawText(e.Graphics, txt, cbo_Color_Generada.Font, r2,
                    cbo_Color_Generada.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }

        private void cbo_Color_Actividad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            TabPage tp = mdi_Principal.tbc_Principal.TabPages["Recepción Carga"];
            mdi_Principal.tbc_Principal.TabPages.Remove(tp);
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            tpc_RecepcionCarga.SelectedIndex = 1;
            tpc_RecepcionCarga.Controls[1].Enabled = true;
            //EditMode = false;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            tpc_RecepcionCarga.SelectedIndex = 0;
            tpc_RecepcionCarga.Controls[1].Enabled = false;
        }

        private void chk_RecojoDomicilioLugar_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_RecojoDomicilioLugar.Checked)
            {
                cbo_DomicilioLugar.Enabled = true;
            }
            else
            {
                cbo_DomicilioLugar.Enabled = false;
            }
        }

        private void chk_Tercerizado_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Tercerizado.Checked)
            {
                tpc_Carga.SelectedIndex = 1;
                tpc_Carga.Controls[1].Enabled = true;
            }
            else
            {
                tpc_Carga.SelectedIndex = 0;
                tpc_Carga.Controls[1].Enabled = false;
                tpg_ContratoTercero.Enabled = false;
            }
        }



        private void dgb_Carga_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgb_Carga.SelectedRows.Count > 0)
            {
                tsm_IngresarGRT.Enabled = true;
            }
            else
            {
                tsm_IngresarGRT.Enabled = false;
            }
        }
        private void inToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgb_Carga.SelectedRows.Count > 0)
            {

                cln_Carga cln_Carga = new cln_Carga();
                ent_Carga Carga = new ent_Carga();
                DataGridViewRow selectedRow = dgb_Carga.SelectedRows[0];
                Carga.Id = Convert.ToInt32(selectedRow.Cells["Id"].Value.ToString());
                Carga.empr_Id = StaticVariable.obj_Empresa.Id;
                List<ent_Carga> Lista = cln_Carga.ListarCarga(Carga, "GEN");
                if (Lista.Count > 0)
                {
                    if (Lista[0].Estado.Correlativo == 2)
                    {
                        frm_GuiaRemisionTransportista.mode = 2;
                        frm_GuiaRemisionTransportista.Carga = Lista[0];
                        frm_GuiaRemisionTransportista form = new frm_GuiaRemisionTransportista();
                        BasicMetod.abrirFormHijo(form, "Guia Remisión");
                    }
                    else
                    {
                        MessageBox.Show("No se puede ingresar otra GRT para este registro", BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }

        private void txt_FleteSinIGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_FleteSinIGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            //currentInput = txt_FleteSinIGV.Text;
            // Verifica si la tecla presionada es la tecla de retroceso
            if (e.KeyChar == '\b')
            {
                // Aquí puedes realizar la lógica deseada al presionar la tecla de retroceso.
                // Por ejemplo, eliminar el último carácter del texto actual.
                if (txt_FleteSinIGV.Text.Length > 0)
                {
                    currentInputFleteSinIGV = txt_FleteSinIGV.Text.Substring(0, txt_FleteSinIGV.Text.Length - 1);
                    // Formatea el texto con los dos últimos dígitos en la parte decimal
                    if (currentInputFleteSinIGV.Length >= 2 && !currentInputFleteSinIGV.Contains("."))
                    {
                        int length = currentInputFleteSinIGV.Length;
                        txt_FleteSinIGV.Text = currentInputFleteSinIGV.Substring(0, length - 2) + "." + currentInputFleteSinIGV.Substring(length - 2);
                    }
                    else
                    {
                        txt_FleteSinIGV.Text = currentInputFleteSinIGV;
                    }
                }
            }
            else
            {
                // Verifica si la tecla presionada es un número
                if (char.IsDigit(e.KeyChar))
                {
                    // Agrega el dígito a la cadena de entrada actual
                    currentInputFleteSinIGV += e.KeyChar;

                    // Formatea el texto con los dos últimos dígitos en la parte decimal
                    if (currentInputFleteSinIGV.Length >= 2 && !currentInputFleteSinIGV.Contains("."))
                    {
                        int length = currentInputFleteSinIGV.Length;
                        txt_FleteSinIGV.Text = currentInputFleteSinIGV.Substring(0, length - 2) + "." + currentInputFleteSinIGV.Substring(length - 2);
                    }
                    else
                    {
                        txt_FleteSinIGV.Text = currentInputFleteSinIGV;
                    }
                }
            }


            e.Handled = true; // Evita que el evento KeyPress procese la tecla nuevamente

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarControles())
                {
                    ent_Carga Carga = llenarCarga();
                    cln_Carga cln_Carga = new cln_Carga();
                    ResponseHelper response = cln_Carga.registrarCarga(Carga, "I");
                    if (response != null)
                    {
                        if (response.codError == 0)
                        {
                            MessageBox.Show(response.mensajeError, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tpc_RecepcionCarga.SelectedIndex = 0;
                            tpc_RecepcionCarga.Controls[1].Enabled = false;
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

            }
        }

        private void txt_FleteTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es la tecla de retroceso
            if (e.KeyChar == '\b')
            {
                // Aquí puedes realizar la lógica deseada al presionar la tecla de retroceso.
                // Por ejemplo, eliminar el último carácter del texto actual.
                if (txt_FleteTotal.Text.Length > 0)
                {
                    currentInput = txt_FleteTotal.Text.Substring(0, txt_FleteTotal.Text.Length - 1);
                    // Formatea el texto con los dos últimos dígitos en la parte decimal
                    if (currentInput.Length >= 2 && !currentInput.Contains("."))
                    {
                        int length = currentInput.Length;
                        txt_FleteTotal.Text = currentInput.Substring(0, length - 2) + "." + currentInput.Substring(length - 2);
                    }
                    else
                    {
                        txt_FleteTotal.Text = currentInput;
                    }
                }
            }
            else
            {
                // Verifica si la tecla presionada es un número
                if (char.IsDigit(e.KeyChar))
                {
                    // Agrega el dígito a la cadena de entrada actual
                    currentInput += e.KeyChar;

                    // Formatea el texto con los dos últimos dígitos en la parte decimal
                    if (currentInput.Length >= 2 && !currentInput.Contains("."))
                    {
                        int length = currentInput.Length;
                        txt_FleteTotal.Text = currentInput.Substring(0, length - 2) + "." + currentInput.Substring(length - 2);
                    }
                    else
                    {
                        txt_FleteTotal.Text = currentInput;
                    }
                }
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (chk_IncluyeIGVFlete.Checked)
                {
                    Double PrecioUnitario;
                    Double ValorUnitario;
                    Double SubTotal;
                    Double Cantidad = Convert.ToDouble(txt_Peso.Text);
                    Double Total = Convert.ToDouble(txt_FleteTotal.Text);
                    SubTotal = Total / 1.18;
                    PrecioUnitario = Total / Cantidad;
                    ValorUnitario = SubTotal / Cantidad;
                    txt_FleteSinIGV.Text = Convert.ToString(Math.Round(ValorUnitario, 10));
                    txt_PrecioUnitario.Text = Convert.ToString(Math.Round(PrecioUnitario, 10));
                    txt_Subtotal.Text = Convert.ToString(Math.Round(SubTotal, 10));
                    txt_FleteTotalCab.Text = Convert.ToString(Total);
                }
                else
                {
                    Double PrecioUnitario;
                    Double ValorUnitario;
                    Double SubTotal;
                    Double Cantidad = Convert.ToDouble(txt_Peso.Text);
                    Double Total = Convert.ToDouble(txt_FleteTotal.Text) + Convert.ToDouble(txt_FleteTotal.Text) * 0.18;
                    SubTotal = Total / 1.18;
                    PrecioUnitario = Total / Cantidad;
                    ValorUnitario = SubTotal / Cantidad;
                    txt_FleteSinIGV.Text = Convert.ToString(Math.Round(ValorUnitario, 10));
                    txt_PrecioUnitario.Text = Convert.ToString(Math.Round(PrecioUnitario, 10));
                    txt_Subtotal.Text = Convert.ToString(Math.Round(SubTotal, 10));
                    txt_FleteTotal.Text = Convert.ToString(Math.Round(Total, 10));
                    txt_FleteTotalCab.Text = Convert.ToString(Math.Round(Total, 10));
                }
            }


            e.Handled = true; // Evita que el evento KeyPress procese la tecla nuevamente
        }

        private void txt_Adelanto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //currentInput = txt_Adelanto.Text;
            // Verifica si la tecla presionada es la tecla de retroceso
            if (e.KeyChar == '\b')
            {
                // Aquí puedes realizar la lógica deseada al presionar la tecla de retroceso.
                // Por ejemplo, eliminar el último carácter del texto actual.
                if (txt_Adelanto.Text.Length > 0)
                {
                    currentInputAdelanto = txt_Adelanto.Text.Substring(0, txt_Adelanto.Text.Length - 1);
                    // Formatea el texto con los dos últimos dígitos en la parte decimal
                    if (currentInputAdelanto.Length >= 2 && !currentInputAdelanto.Contains("."))
                    {
                        int length = currentInputAdelanto.Length;
                        txt_Adelanto.Text = currentInputAdelanto.Substring(0, length - 2) + "." + currentInputAdelanto.Substring(length - 2);
                    }
                    else
                    {
                        txt_Adelanto.Text = currentInputAdelanto;
                    }
                }
            }
            else
            {
                // Verifica si la tecla presionada es un número
                if (char.IsDigit(e.KeyChar))
                {
                    // Agrega el dígito a la cadena de entrada actual
                    currentInputAdelanto += e.KeyChar;

                    // Formatea el texto con los dos últimos dígitos en la parte decimal
                    if (currentInputAdelanto.Length >= 2 && !currentInputAdelanto.Contains("."))
                    {
                        int length = currentInputAdelanto.Length;
                        txt_Adelanto.Text = currentInputAdelanto.Substring(0, length - 2) + "." + currentInputAdelanto.Substring(length - 2);
                    }
                    else
                    {
                        txt_Adelanto.Text = currentInputAdelanto;
                    }
                }
            }
        }

        private void txt_Comision_KeyPress(object sender, KeyPressEventArgs e)
        {
            //currentInput = txt_Comision.Text;
            // Verifica si la tecla presionada es la tecla de retroceso
            if (e.KeyChar == '\b')
            {
                // Aquí puedes realizar la lógica deseada al presionar la tecla de retroceso.
                // Por ejemplo, eliminar el último carácter del texto actual.
                if (txt_Comision.Text.Length > 0)
                {
                    currentInputComision = txt_Comision.Text.Substring(0, txt_Comision.Text.Length - 1);
                    // Formatea el texto con los dos últimos dígitos en la parte decimal
                    if (currentInputComision.Length >= 2 && !currentInputComision.Contains("."))
                    {
                        int length = currentInputComision.Length;
                        txt_Comision.Text = currentInputComision.Substring(0, length - 2) + "." + currentInputComision.Substring(length - 2);
                    }
                    else
                    {
                        txt_Comision.Text = currentInputComision;
                    }
                }
            }
            else
            {
                // Verifica si la tecla presionada es un número
                if (char.IsDigit(e.KeyChar))
                {
                    // Agrega el dígito a la cadena de entrada actual
                    currentInputComision += e.KeyChar;

                    // Formatea el texto con los dos últimos dígitos en la parte decimal
                    if (currentInputComision.Length >= 2 && !currentInputComision.Contains("."))
                    {
                        int length = currentInputComision.Length;
                        txt_Comision.Text = currentInputComision.Substring(0, length - 2) + "." + currentInputComision.Substring(length - 2);
                    }
                    else
                    {
                        txt_Comision.Text = currentInputComision;
                    }
                }
            }
        }

        private void txt_Consolidado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //currentInput = txt_Consolidado.Text;
            // Verifica si la tecla presionada es la tecla de retroceso
            if (e.KeyChar == '\b')
            {
                // Aquí puedes realizar la lógica deseada al presionar la tecla de retroceso.
                // Por ejemplo, eliminar el último carácter del texto actual.
                if (txt_Consolidado.Text.Length > 0)
                {
                    currentInputConsolidado = txt_Consolidado.Text.Substring(0, txt_Consolidado.Text.Length - 1);
                    // Formatea el texto con los dos últimos dígitos en la parte decimal
                    if (currentInputConsolidado.Length >= 2 && !currentInputConsolidado.Contains("."))
                    {
                        int length = currentInputConsolidado.Length;
                        txt_Consolidado.Text = currentInputConsolidado.Substring(0, length - 2) + "." + currentInputConsolidado.Substring(length - 2);
                    }
                    else
                    {
                        txt_Consolidado.Text = currentInputConsolidado;
                    }
                }
            }
            else
            {
                // Verifica si la tecla presionada es un número
                if (char.IsDigit(e.KeyChar))
                {
                    // Agrega el dígito a la cadena de entrada actual
                    currentInputConsolidado += e.KeyChar;

                    // Formatea el texto con los dos últimos dígitos en la parte decimal
                    if (currentInputConsolidado.Length >= 2 && !currentInputConsolidado.Contains("."))
                    {
                        int length = currentInputConsolidado.Length;
                        txt_Consolidado.Text = currentInputConsolidado.Substring(0, length - 2) + "." + currentInputConsolidado.Substring(length - 2);
                    }
                    else
                    {
                        txt_Consolidado.Text = currentInputConsolidado;
                    }
                }
            }
        }


        private void cbo_ClienteFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_ClienteFinal.SelectedIndex > -1)
                {
                    ent_Cliente Cliente = (ent_Cliente)cbo_ClienteFinal.SelectedItem;
                    txt_DocClienteFinal.Text = Cliente.Persona.DocIdentidad;
                }
                else
                {
                    txt_DocClienteFinal.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txt_DocClienteFinal_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    String Documento = txt_DocClienteFinal.Text;
                    List<ent_Cliente> ListaClientes = (List<ent_Cliente>)cbo_ClienteFinal.DataSource;
                    foreach (ent_Cliente Cliente in ListaClientes)
                    {
                        if (Cliente.Persona.DocIdentidad == Documento)
                        {
                            cbo_ClienteFinal.SelectedItem = Cliente;
                        }
                    }
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void cbo_Comisionista_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbo_Comisionista.SelectedIndex > -1)
                {
                    ent_Cliente Cliente = (ent_Cliente)cbo_Comisionista.SelectedItem;
                    txt_DocComisionista.Text = Cliente.Persona.DocIdentidad;
                }
                else
                {
                    txt_DocComisionista.Text = "";
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void txt_DocComisionista_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    String Documento = txt_DocComisionista.Text;
                    List<ent_Cliente> ListaClientes = (List<ent_Cliente>)cbo_Comisionista.DataSource;
                    foreach (ent_Cliente Cliente in ListaClientes)
                    {
                        if (Cliente.Persona.DocIdentidad == Documento)
                        {
                            cbo_Comisionista.SelectedItem = Cliente;
                        }
                    }
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void txt_ConEstiba_KeyPress(object sender, KeyPressEventArgs e)
        {
            //currentInput = txt_ConEstiba.Text;
            // Verifica si la tecla presionada es la tecla de retroceso
            if (e.KeyChar == '\b')
            {
                // Aquí puedes realizar la lógica deseada al presionar la tecla de retroceso.
                // Por ejemplo, eliminar el último carácter del texto actual.
                if (txt_ConEstiba.Text.Length > 0)
                {
                    currentInputConEstiba = txt_ConEstiba.Text.Substring(0, txt_ConEstiba.Text.Length - 1);
                    // Formatea el texto con los dos últimos dígitos en la parte decimal
                    if (currentInputConEstiba.Length >= 2 && !currentInputConEstiba.Contains("."))
                    {
                        int length = currentInputConEstiba.Length;
                        txt_ConEstiba.Text = currentInputConEstiba.Substring(0, length - 2) + "." + currentInputConEstiba.Substring(length - 2);
                    }
                    else
                    {
                        txt_ConEstiba.Text = currentInputConEstiba;
                    }
                }
            }
            else
            {
                // Verifica si la tecla presionada es un número
                if (char.IsDigit(e.KeyChar))
                {
                    // Agrega el dígito a la cadena de entrada actual
                    currentInputConEstiba += e.KeyChar;

                    // Formatea el texto con los dos últimos dígitos en la parte decimal
                    if (currentInputConEstiba.Length >= 2 && !currentInputConEstiba.Contains("."))
                    {
                        int length = currentInputConEstiba.Length;
                        txt_ConEstiba.Text = currentInputConEstiba.Substring(0, length - 2) + "." + currentInputConEstiba.Substring(length - 2);
                    }
                    else
                    {
                        txt_ConEstiba.Text = currentInputConEstiba;
                    }
                }
            }
        }

        private void txt_CEstibaDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //currentInput = txt_CEstibaDesc.Text;
            // Verifica si la tecla presionada es la tecla de retroceso
            if (e.KeyChar == '\b')
            {
                // Aquí puedes realizar la lógica deseada al presionar la tecla de retroceso.
                // Por ejemplo, eliminar el último carácter del texto actual.
                if (txt_CEstibaDesc.Text.Length > 0)
                {
                    currentInputCEstibaDesc = txt_CEstibaDesc.Text.Substring(0, txt_CEstibaDesc.Text.Length - 1);
                    // Formatea el texto con los dos últimos dígitos en la parte decimal
                    if (currentInputCEstibaDesc.Length >= 2 && !currentInputCEstibaDesc.Contains("."))
                    {
                        int length = currentInputCEstibaDesc.Length;
                        txt_CEstibaDesc.Text = currentInputCEstibaDesc.Substring(0, length - 2) + "." + currentInputCEstibaDesc.Substring(length - 2);
                    }
                    else
                    {
                        txt_CEstibaDesc.Text = currentInputCEstibaDesc;
                    }
                }
            }
            else
            {
                // Verifica si la tecla presionada es un número
                if (char.IsDigit(e.KeyChar))
                {
                    // Agrega el dígito a la cadena de entrada actual
                    currentInputCEstibaDesc += e.KeyChar;

                    // Formatea el texto con los dos últimos dígitos en la parte decimal
                    if (currentInputCEstibaDesc.Length >= 2 && !currentInputCEstibaDesc.Contains("."))
                    {
                        int length = currentInputCEstibaDesc.Length;
                        txt_CEstibaDesc.Text = currentInputCEstibaDesc.Substring(0, length - 2) + "." + currentInputCEstibaDesc.Substring(length - 2);
                    }
                    else
                    {
                        txt_CEstibaDesc.Text = currentInputCEstibaDesc;
                    }
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbt_Remitente.Checked)
                {
                    ent_Cliente cliente = (ent_Cliente)cbo_ClienteRemitente.SelectedItem;
                    cbo_ClientePaga.SelectedItem = cliente;
                    txt_DireccionFacturacion.Text = cliente.DomicilioFiscal;
                    cbo_ClientePaga.Enabled = false;
                }
                else
                {
                    cbo_ClientePaga.Enabled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void rbt_Destinatario_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbt_Destinatario.Checked)
                {
                    ent_Cliente cliente = (ent_Cliente)cbo_ClienteDestinatario.SelectedItem;
                    cbo_ClientePaga.SelectedItem = cliente;
                    txt_DireccionFacturacion.Text = cliente.DomicilioFiscal;
                    cbo_ClientePaga.Enabled = false;
                }
                else
                {
                    cbo_ClientePaga.Enabled = true;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void rbt_Seleccionar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cbo_ClientePaga.Enabled = true;
            }
            catch (Exception ex)
            {

            }
        }
        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                cln_Carga cln_Carga = new cln_Carga();
                ent_Carga Carga = new ent_Carga();

                List<ent_Carga> Lista = cln_Carga.ListarCarga(new ent_Carga(), "GEN");
                //Lista = Lista.Where(x => x.FechaRecepcion >= dtp_FechaInicio.Value && x.FechaRecepcion<= dtp_FechaFin.Value).ToList();
                dgb_Carga.DataSource = Lista;
                ocultarColumnas();
                dgb_Carga.Refresh();
            }
            catch (Exception ex)
            {

            }
        }
        private void dgb_Carga_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgb_Carga.Columns[e.ColumnIndex].Name == "TipoServicio")
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
            if (dgb_Carga.Columns[e.ColumnIndex].Name == "LugarOrigen")
            {
                // Obtiene el valor actual de la celda
                var value = e.Value as ent_Ubigeo;

                // Verifica que el valor no sea nulo
                if (value != null)
                {
                    // Asigna el valor de la propiedad Descripcion al valor que se muestra en la celda
                    e.Value = value.Descripcion;
                }
            }
            if (dgb_Carga.Columns[e.ColumnIndex].Name == "LugarDestino")
            {
                // Obtiene el valor actual de la celda
                var value = e.Value as ent_Ubigeo;

                // Verifica que el valor no sea nulo
                if (value != null)
                {
                    // Asigna el valor de la propiedad Descripcion al valor que se muestra en la celda
                    e.Value = value.Descripcion;
                }
            }
            if (dgb_Carga.Columns[e.ColumnIndex].Name == "CondicionPago")
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
            if (dgb_Carga.Columns[e.ColumnIndex].Name == "TipoEntrega")
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
            if (dgb_Carga.Columns[e.ColumnIndex].Name == "RecojoDomicilioLugar")
            {
                // Obtiene el valor actual de la celda
                var value = e.Value as ent_Ubigeo;

                // Verifica que el valor no sea nulo
                if (value != null)
                {
                    // Asigna el valor de la propiedad Descripcion al valor que se muestra en la celda
                    e.Value = value.Descripcion;
                }
            }
            if (dgb_Carga.Columns[e.ColumnIndex].Name == "TipoVehiculo")
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
            if (dgb_Carga.Columns[e.ColumnIndex].Name == "ClienteDestinatario")
            {
                // Obtiene el valor actual de la celda
                var value = e.Value as ent_Cliente;

                // Verifica que el valor no sea nulo
                if (value != null)
                {
                    // Asigna el valor de la propiedad Descripcion al valor que se muestra en la celda
                    e.Value = value.RazonSocial;
                }
            }
            if (dgb_Carga.Columns[e.ColumnIndex].Name == "ClienteRemitente")
            {
                // Obtiene el valor actual de la celda
                var value = e.Value as ent_Cliente;

                // Verifica que el valor no sea nulo
                if (value != null)
                {
                    // Asigna el valor de la propiedad Descripcion al valor que se muestra en la celda
                    e.Value = value.RazonSocial;
                }
            }
            if (dgb_Carga.Columns[e.ColumnIndex].Name == "ClientePago")
            {
                // Obtiene el valor actual de la celda
                var value = e.Value as ent_Cliente;

                // Verifica que el valor no sea nulo
                if (value != null)
                {
                    // Asigna el valor de la propiedad Descripcion al valor que se muestra en la celda
                    e.Value = value.RazonSocial;
                }
            }
            if (dgb_Carga.Columns[e.ColumnIndex].Name == "Estado")
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
            if (dgb_Carga.Columns[e.ColumnIndex].Name == "PuntoPartida")
            {
                // Obtiene el valor actual de la celda
                var value = e.Value as ent_Direccion;

                // Verifica que el valor no sea nulo
                if (value != null)
                {
                    // Asigna el valor de la propiedad Descripcion al valor que se muestra en la celda
                    e.Value = value.DireccionCompleta;
                }
            }
            if (dgb_Carga.Columns[e.ColumnIndex].Name == "PuntoLlegada")
            {
                // Obtiene el valor actual de la celda
                var value = e.Value as ent_Direccion;

                // Verifica que el valor no sea nulo
                if (value != null)
                {
                    // Asigna el valor de la propiedad Descripcion al valor que se muestra en la celda
                    e.Value = value.DireccionCompleta;
                }
            }
        }
        private void cbo_ClienteRemitente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_ClienteRemitente.SelectedIndex > -1)
            {

                if (cbo_ClienteRemitente.SelectedIndex > -1 && cbo_OrigenCabecera.SelectedIndex > -1)
                {
                    ent_Cliente Cliente = (ent_Cliente)cbo_ClienteRemitente.SelectedItem;
                    cln_Cliente cln_Cliente = new cln_Cliente();
                    List<ent_Cliente> ListaCliente = cln_Cliente.ListarCliente(Cliente, "CLI");
                    Cliente = ListaCliente.Count > 0 ? ListaCliente[0] : null;
                    ent_Ubigeo Ubigeo = cbo_OrigenCabecera.SelectedItem as ent_Ubigeo;
                    if (Cliente != null)
                    {
                        List<ent_Direccion> ListaDireccion = Cliente.Lista_Direccion.Where(x => x.Ubigeo == Ubigeo.Ubigeo).ToList();
                        if (ListaDireccion.Count > 0)
                        {
                            cbo_DireccionPartida.DataSource = ListaDireccion;
                            cbo_DireccionPartida.ValueMember = "Id";
                            cbo_DireccionPartida.DisplayMember = "DireccionCompleta";
                        }
                        else
                        {
                            ListaDireccion = Cliente.Lista_Direccion;
                            cbo_DireccionPartida.DataSource = ListaDireccion;
                            cbo_DireccionPartida.ValueMember = "Id";
                            cbo_DireccionPartida.DisplayMember = "DireccionCompleta";
                        }
                    }

                }
                else
                {
                    ent_Cliente Cliente = (ent_Cliente)cbo_ClienteRemitente.SelectedItem;
                    cln_Cliente cln_Cliente = new cln_Cliente();
                    List<ent_Cliente> ListaCliente = cln_Cliente.ListarCliente(Cliente, "CLI");
                    Cliente = ListaCliente.Count > 0 ? ListaCliente[0] : null;
                    List<ent_Direccion> ListaDireccion;
                    ListaDireccion = Cliente.Lista_Direccion;
                    cbo_DireccionPartida.DataSource = ListaDireccion;
                    cbo_DireccionPartida.ValueMember = "Id";
                    cbo_DireccionPartida.DisplayMember = "DireccionCompleta";
                }

            }
            else
            {
                cbo_DireccionPartida.Items.Clear();
            }
        }
        #endregion


        private void cbo_ClienteDestinatario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_ClienteDestinatario.SelectedIndex > -1)
            {

                if (cbo_ClienteDestinatario.SelectedIndex > -1 && cbo_DestinoCabecera.SelectedIndex > -1)
                {
                    ent_Cliente Cliente = (ent_Cliente)cbo_ClienteDestinatario.SelectedItem;
                    cln_Cliente cln_Cliente = new cln_Cliente();
                    List<ent_Cliente> ListaCliente = cln_Cliente.ListarCliente(Cliente, "CLI");
                    Cliente = ListaCliente.Count > 0 ? ListaCliente[0] : null;
                    ent_Ubigeo Ubigeo = cbo_DestinoCabecera.SelectedItem as ent_Ubigeo;
                    if (Cliente != null)
                    {
                        List<ent_Direccion> ListaDireccion = Cliente.Lista_Direccion.Where(x => x.Ubigeo == Ubigeo.Ubigeo).ToList();
                        if (ListaDireccion.Count > 0)
                        {
                            cbo_DireccionLlegada.DataSource = ListaDireccion;
                            cbo_DireccionLlegada.ValueMember = "Id";
                            cbo_DireccionLlegada.DisplayMember = "DireccionCompleta";
                        }
                        else
                        {
                            ListaDireccion = Cliente.Lista_Direccion;
                            cbo_DireccionLlegada.DataSource = ListaDireccion;
                            cbo_DireccionLlegada.ValueMember = "Id";
                            cbo_DireccionLlegada.DisplayMember = "DireccionCompleta";
                        }
                    }

                }
                else
                {
                    ent_Cliente Cliente = (ent_Cliente)cbo_ClienteDestinatario.SelectedItem;
                    cln_Cliente cln_Cliente = new cln_Cliente();
                    List<ent_Cliente> ListaCliente = cln_Cliente.ListarCliente(Cliente, "CLI");
                    Cliente = ListaCliente.Count > 0 ? ListaCliente[0] : null;
                    List<ent_Direccion> ListaDireccion;
                    ListaDireccion = Cliente.Lista_Direccion;
                    cbo_DireccionLlegada.DataSource = ListaDireccion;
                    cbo_DireccionLlegada.ValueMember = "Id";
                    cbo_DireccionLlegada.DisplayMember = "DireccionCompleta";
                }

            }
            else
            {
                cbo_DireccionPartida.Items.Clear();
            }
        }

        private void cbo_ClientePaga_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_ClientePaga.SelectedIndex > -1)
            {
                ent_Cliente Cliente = (ent_Cliente)cbo_ClientePaga.SelectedItem;
                cln_Cliente cln_Cliente = new cln_Cliente();
                Cliente = cln_Cliente.ListarCliente(Cliente, "CLI")[0];
                txt_DireccionFacturacion.Text = Cliente.DomicilioFiscal;
            }
            else
            {
                txt_DireccionFacturacion.Text = "";
            }
        }

        private void txt_PrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es la tecla de retroceso
            if (e.KeyChar == '\b')
            {
                // Aquí puedes realizar la lógica deseada al presionar la tecla de retroceso.
                // Por ejemplo, eliminar el último carácter del texto actual.
                if (txt_PrecioUnitario.Text.Length > 0)
                {
                    currentInputPrecioUnitConIGV = txt_PrecioUnitario.Text.Substring(0, txt_PrecioUnitario.Text.Length - 1);
                    // Formatea el texto con los dos últimos dígitos en la parte decimal
                    if (currentInput.Length >= 2 && !currentInputPrecioUnitConIGV.Contains("."))
                    {
                        int length = currentInputPrecioUnitConIGV.Length;
                        txt_PrecioUnitario.Text = currentInputPrecioUnitConIGV.Substring(0, length - 2) + "." + currentInputPrecioUnitConIGV.Substring(length - 2);
                    }
                    else
                    {
                        txt_PrecioUnitario.Text = currentInputPrecioUnitConIGV;
                    }
                }
            }
            else
            {
                // Verifica si la tecla presionada es un número
                if (char.IsDigit(e.KeyChar))
                {
                    // Agrega el dígito a la cadena de entrada actual
                    currentInputPrecioUnitConIGV += e.KeyChar;

                    // Formatea el texto con los dos últimos dígitos en la parte decimal
                    if (currentInputPrecioUnitConIGV.Length >= 2 && !currentInputPrecioUnitConIGV.Contains("."))
                    {
                        int length = currentInputPrecioUnitConIGV.Length;
                        txt_PrecioUnitario.Text = currentInputPrecioUnitConIGV.Substring(0, length - 2) + "." + currentInputPrecioUnitConIGV.Substring(length - 2);
                    }
                    else
                    {
                        txt_PrecioUnitario.Text = currentInputPrecioUnitConIGV;
                    }
                }
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (chk_IncluyeIGVFlete.Checked)
                {
                    Double PrecioUnitario = Convert.ToDouble(txt_PrecioUnitario.Text);
                    Double Cantidad = Convert.ToDouble(txt_Peso.Text);
                    Double ValorUnitario = PrecioUnitario /1.18;
                    Double Total = PrecioUnitario * Cantidad;
                    Double SubTotal;

                    SubTotal = Total / 1.18;
                    PrecioUnitario = Total / Cantidad;
                    ValorUnitario = SubTotal / Cantidad;
                    txt_FleteSinIGV.Text = Convert.ToString(Math.Round(ValorUnitario, 10));
                    txt_PrecioUnitario.Text = Convert.ToString(Math.Round(PrecioUnitario, 10));
                    txt_Subtotal.Text = Convert.ToString(Math.Round(SubTotal, 10));
                    txt_FleteTotalCab.Text = Convert.ToString(Total);
                    txt_FleteTotal.Text = Convert.ToString(Math.Round(Total, 10));
                }
                else
                {
                    Double PrecioUnitario = Convert.ToDouble(txt_PrecioUnitario.Text);
                    PrecioUnitario = PrecioUnitario + PrecioUnitario * 0.18;
                    Double Cantidad = Convert.ToDouble(txt_Peso.Text);
                    Double ValorUnitario = PrecioUnitario / 1.18;
                    Double Total = PrecioUnitario * Cantidad;
                    Double SubTotal;

                    SubTotal = Total / 1.18;
                    PrecioUnitario = Total / Cantidad;
                    ValorUnitario = SubTotal / Cantidad;
                    txt_FleteSinIGV.Text = Convert.ToString(Math.Round(ValorUnitario, 10));
                    txt_PrecioUnitario.Text = Convert.ToString(Math.Round(PrecioUnitario, 10));
                    txt_Subtotal.Text = Convert.ToString(Math.Round(SubTotal, 10));
                    txt_FleteTotalCab.Text = Convert.ToString(Total);
                    txt_FleteTotal.Text = Convert.ToString(Math.Round(Total, 10));
                }
            }
        }
    }
}
