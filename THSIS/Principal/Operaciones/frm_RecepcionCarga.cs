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
        private string currentInput = "";
        #region "Constructor"
        public frm_RecepcionCarga()
        {
            InitializeComponent();
            InicializarForulario();
        }
        #endregion

        #region "Métodos"
        public void InicializarForulario()
        {
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
                cargarMoneda();
                cargarTipoServicio();
                cargarCondicionPago();
                cargarTipoEntrega();
                cargarTipoVehiculo();
                cargarEstadoCarga();
                cargarUsuarioFilter();
                cargarTipoCarga();
                cargarClienteRecepcion();
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

                cbo_OrigenDetalle.DataSource = lista;
                cbo_OrigenDetalle.ValueMember = "Ubigeo";
                cbo_OrigenDetalle.DisplayMember = "Descripcion";
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
                frm_GuiaRemisionTransportista form = new frm_GuiaRemisionTransportista();
                BasicMetod.abrirFormHijo(form, "Guia Remisión");
            }
        }

        private void txt_FleteSinIGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_FleteSinIGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es la tecla de retroceso
            if (e.KeyChar == '\b')
            {
                // Aquí puedes realizar la lógica deseada al presionar la tecla de retroceso.
                // Por ejemplo, eliminar el último carácter del texto actual.
                if (txt_FleteSinIGV.Text.Length > 0)
                {
                    currentInput = txt_FleteSinIGV.Text.Substring(0, txt_FleteSinIGV.Text.Length - 1);
                    // Formatea el texto con los dos últimos dígitos en la parte decimal
                    if (currentInput.Length >= 2 && !currentInput.Contains("."))
                    {
                        int length = currentInput.Length;
                        txt_FleteSinIGV.Text = currentInput.Substring(0, length - 2) + "." + currentInput.Substring(length - 2);
                    }
                    else
                    {
                        txt_FleteSinIGV.Text = currentInput;
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
                        txt_FleteSinIGV.Text = currentInput.Substring(0, length - 2) + "." + currentInput.Substring(length - 2);
                    }
                    else
                    {
                        txt_FleteSinIGV.Text = currentInput;
                    }
                }
            }


            e.Handled = true; // Evita que el evento KeyPress procese la tecla nuevamente

        }
        #endregion

        private void txt_Subtotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es la tecla de retroceso
            if (e.KeyChar == '\b')
            {
                // Aquí puedes realizar la lógica deseada al presionar la tecla de retroceso.
                // Por ejemplo, eliminar el último carácter del texto actual.
                if (txt_Subtotal.Text.Length > 0)
                {
                    currentInput = txt_Subtotal.Text.Substring(0, txt_Subtotal.Text.Length - 1);
                    // Formatea el texto con los dos últimos dígitos en la parte decimal
                    if (currentInput.Length >= 2 && !currentInput.Contains("."))
                    {
                        int length = currentInput.Length;
                        txt_Subtotal.Text = currentInput.Substring(0, length - 2) + "." + currentInput.Substring(length - 2);
                    }
                    else
                    {
                        txt_Subtotal.Text = currentInput;
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
                        txt_Subtotal.Text = currentInput.Substring(0, length - 2) + "." + currentInput.Substring(length - 2);
                    }
                    else
                    {
                        txt_Subtotal.Text = currentInput;
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
                txt_IGV.Text = Igv.ToString("0.00");
                txt_FleteTotal.Text = TotalFlete.ToString("0.00");
            }
        }

        private void cbo_ClienteRecepcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ent_Cliente Cliente = (ent_Cliente)cbo_ClienteRecepcion.SelectedItem;
                txt_DocClienteRecepcion.Text = Cliente.Persona.DocIdentidad;
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
                cln_Ruta cln = new cln_Ruta();
                ent_Ruta Ruta = new ent_Ruta();
                Ruta.DistritoOrigen.Ubigeo = ((ent_Ubigeo)cbo_OrigenCabecera.SelectedItem).Ubigeo;
                List<ent_Ruta> Lista = cln.ListarRuta(Ruta, "GEN");

                cbo_DestinoCabecera.DataSource = Lista;
                cbo_DestinoCabecera.ValueMember = "DistritoDestino.Ubigeo";
                cbo_DestinoCabecera.DisplayMember = "DistritoDestino.Descripcion";
            }
            catch (Exception ex)
            {

            }
        }
    }
}
