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
    public partial class frm_RecepcionCarga : Form
    {

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
            llenarColoresComboBox();
            cargarComboBox();
        }

        public void cargarComboBox()
        {
            try
            {
                cargarMoneda();
                cargarTipoServicio();
                cargarCondicionPago();
                cargarTipoEntrega();
                cargarTipoVehiculo();
                cargarEstadoCarga();
                cargarUsuarioFilter();
                cargarTipoCarga();
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
        #endregion


    }
}
