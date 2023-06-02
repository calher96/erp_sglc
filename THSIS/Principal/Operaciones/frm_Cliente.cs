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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Principal.Operaciones
{
    public partial class frm_Cliente : Form
    {
        public frm_Cliente()
        {
            InitializeComponent();
            llenarColoresComboBox();
            cargarTipoDocumento();
            cargarTipoPersona();
            construirDataGridView();
            tbc_Principal.Controls[1].Enabled = false;
        }
        private void llenarColoresComboBox()
        {
            //CBO_COLOR_Comisionista
            cbo_Color_Comisionista.DataSource = typeof(Color).GetProperties()
                                        .Where(x => x.PropertyType == typeof(Color))
                                        .Select(x => x.GetValue(null)).ToList();
            cbo_Color_Comisionista.MaxDropDownItems = 10;
            cbo_Color_Comisionista.IntegralHeight = false;
            cbo_Color_Comisionista.DrawMode = DrawMode.OwnerDrawFixed;
            cbo_Color_Comisionista.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Color_Comisionista.SelectedIndex = 16;
            cbo_Color_Comisionista.DrawItem += cbo_Color_Comisionista_DrawItem;
        }
        private void cbo_Color_Comisionista_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                var txt = cbo_Color_Comisionista.GetItemText(cbo_Color_Comisionista.Items[e.Index]);
                var color = (Color)cbo_Color_Comisionista.Items[e.Index];
                var r1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                var r2 = Rectangle.FromLTRB(r1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (var b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, r1);
                e.Graphics.DrawRectangle(Pens.Black, r1);
                TextRenderer.DrawText(e.Graphics, txt, cbo_Color_Comisionista.Font, r2,
                    cbo_Color_Comisionista.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TabPage tp = mdi_Principal.tbc_Principal.TabPages["Cliente"];
            mdi_Principal.tbc_Principal.TabPages.Remove(tp);
        }
        private void cargarTipoDocumento()
        {
            List<ent_Concepto> lista;
            cln_Concepto cln = new cln_Concepto();
            lista = cln.listarConcepto(1);
            cbo_TipoDocumento.DataSource = lista;
            cbo_TipoDocumento.ValueMember = "conc_Descripcion";
            cbo_TipoDocumento.DisplayMember = "conc_Descripcion";
        }

        private void cargarTipoPersona()
        {
            List<ent_Concepto> lista;
            cln_Concepto cln = new cln_Concepto();
            lista = cln.listarConcepto(10);
            cbo_TipoPersona.DataSource = lista;
            cbo_TipoPersona.ValueMember = "conc_Descripcion";
            cbo_TipoPersona.DisplayMember = "conc_Descripcion";
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            tbc_Principal.Controls[1].Enabled = true;
            tbc_Principal.SelectedIndex = 1;
        }

        private void cbo_TipoPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ent_Concepto)cbo_TipoPersona.SelectedItem).conc_Correlativo == 1)
            {
                gpb_PersonaNatural.Enabled = true;
                gpb_PersonaJuridica.Enabled = false;
                cbo_TipoDocumento.Enabled = true;
                limpiarPersonaJuridica();
            }
            if (((ent_Concepto)cbo_TipoPersona.SelectedItem).conc_Correlativo == 2)
            {
                gpb_PersonaNatural.Enabled = false;
                gpb_PersonaJuridica.Enabled = true;
                for (int i = 0; i < cbo_TipoDocumento.Items.Count; i++)
                {
                    int conc_Codigo = ((ent_Concepto)cbo_TipoDocumento.Items[i]).conc_Correlativo;
                    if (conc_Codigo == 2)
                    {
                        cbo_TipoDocumento.SelectedIndex = i;
                    }
                }
                cbo_TipoDocumento.Enabled = false;
                limpiarPersonaNatural();
            }
        }
        private void limpiarDatosGenerales()
        {
            txt_Documento.Text = "";
            txt_Codigo.Text = "";
        }
        private void limpiarPersonaJuridica()
        {
            txt_RazonSocial.Text = "";
            txt_DireccionFiscal.Text = "";
            txt_Abreviatura.Text = "";
        }
        private void limpiarPersonaNatural()
        {
            txt_Nombres.Text = "";
            txt_ApellidoMaterno.Text = "";
            txt_ApellidoPaterno.Text = "";
            chk_Comisionista.Checked = false;
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Boolean resp = true;
            Int16 tipoPersona = Convert.ToInt16(((ent_Concepto)cbo_TipoPersona.SelectedItem).conc_Correlativo);
            resp = validarDatosGenerales();
            if (tipoPersona == 1)
            {

                resp = validarPersonaNatural();
            }
            else
            {

                resp = validarPersonaJuridica();
            }
            if (!resp)
            {
                cln_Cliente cln = new cln_Cliente();
                ent_Cliente obj = new ent_Cliente();
                ResponseHelper response;
                obj.Clie_TipoDocumento = ((ent_Concepto)cbo_TipoDocumento.SelectedItem).conc_Correlativo;
                obj.Clie_Documento = txt_Documento.Text;
                obj.Clie_Codigo = txt_Codigo.Text;
                obj.Clie_TipoPersona = Convert.ToInt16(((ent_Concepto)cbo_TipoPersona.SelectedItem).conc_Correlativo);
                obj.Clie_Nombres = txt_Nombres.Text;
                obj.Clie_ApellidoPaterno = txt_ApellidoPaterno.Text;
                obj.Clie_ApellidoMaterno = txt_ApellidoMaterno.Text;
                obj.Clie_Sexo = (rbt_Masculino.Checked ? 1 : 2);
                obj.Clie_FechaNacimiento = DateOnly.Parse(dtp_FechaNacimiento.Value.Date.ToShortDateString());
                obj.Clie_Comisionista = Convert.ToInt16(chk_Comisionista.Checked ? 1 : 2);
                obj.Clie_RazonSocial = txt_RazonSocial.Text;
                obj.Clie_Abreviatura = txt_Abreviatura.Text;
                obj.Clie_DomicilioFiscal = txt_DireccionFiscal.Text;
                obj.empr_Id = 2;
                response = cln.guardarTrabajador(obj);
                if (response.codError == -1)
                {
                    MessageBox.Show(response.mensajeError, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(response.mensajeError, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {

            }
        }
        public Boolean validarPersonaNatural()
        {
            Boolean resp = false;
            if (txt_Nombres.Text.Length == 0)
            {
                resp = true;
                txt_Nombres.Focus();
            }
            if (txt_ApellidoPaterno.Text.Length == 0)
            {
                resp = true;
                txt_ApellidoPaterno.Focus();
            }
            if (txt_ApellidoMaterno.Text.Length == 0)
            {
                resp = true;
                txt_ApellidoMaterno.Focus();
            }
            return resp;
        }
        private Boolean validarPersonaJuridica()
        {
            Boolean resp = false;
            if (txt_RazonSocial.Text.Length == 0)
            {
                resp = true;
                txt_RazonSocial.Focus();
            }
            if (txt_DireccionFiscal.Text.Length == 0)
            {
                resp = true;
                txt_DireccionFiscal.Focus();
            }
            return resp;
        }

        private Boolean validarDatosGenerales()
        {
            Boolean resp = false;
            if (txt_Documento.Text.Length == 0)
            {
                resp = true;
                txt_Documento.Focus();
            }
            if (txt_Codigo.Text.Length == 0)
            {
                resp = true;
                txt_Codigo.Focus();
            }
            if (txt_Documento.Text.Length == 0)
            {
                resp = true;
                txt_Documento.Focus();
            }

            return resp;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            tbc_Principal.Controls[1].Enabled = false;
            tbc_Principal.SelectedIndex = 0;
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            listarCliente();
        }

        private void listarCliente()
        {
            try
            {
                cln_Cliente cln = new cln_Cliente();
                ent_Cliente ent = new ent_Cliente();
                List<ent_Cliente> lista;
                ent.empr_Id = 2;
                lista = cln.ListarCliente(ent);
                foreach (ent_Cliente obj in lista)
                {
                    Boolean estado = (obj.Clie_Estado == 1 ? true : false);
                    dgb_Lista.Rows.Add(obj.Clie_TipoDocumentoDescripcion, obj.Clie_Documento, obj.Clie_TipoPersonaDescripcion, obj.Clie_RazonSocial, obj.Clie_Codigo, obj.Clie_DomicilioFiscal, estado);
                    if (obj.Clie_Comisionista == 1)
                    {
                        Color color;
                        color = BasicMetod.obtenerColorComboBox(cbo_Color_Comisionista);
                        dgb_Lista.Rows[dgb_Lista.RowCount - 1].DefaultCellStyle.BackColor = color;
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }
        private void construirDataGridView()
        {
            // Create an unbound DataGridView by declaring a column count.
            dgb_Lista.ColumnCount = 6;
            dgb_Lista.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.BlueViolet;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dgb_Lista.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            DataGridViewColumn columnas = new DataGridViewColumn(new DataGridViewCheckBoxCell());
            columnas.Name = "ACTIVO";
            // Set the column header names.
            dgb_Lista.Columns[0].Name = "TIPO DOCUMENTO";

            dgb_Lista.Columns[1].Name = "DOCUMENTO";
            dgb_Lista.Columns[2].Name = "TIPO PERSONA";
            dgb_Lista.Columns[3].Name = "NOMBRE/RAZÓN SOCIAL";
            dgb_Lista.Columns[4].Name = "CÓDIGO";
            dgb_Lista.Columns[5].Name = "DOMICILIO FISCAL";
            dgb_Lista.Columns.Add(columnas);

            dgb_Lista.Columns[0].Resizable = DataGridViewTriState.False;
            dgb_Lista.Columns[1].Resizable = DataGridViewTriState.False;
            dgb_Lista.Columns[2].Resizable = DataGridViewTriState.False;
            dgb_Lista.Columns[3].Resizable = DataGridViewTriState.False;
            dgb_Lista.Columns[4].Resizable = DataGridViewTriState.False;
            dgb_Lista.Columns[5].Resizable = DataGridViewTriState.False;

            dgb_Lista.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgb_Lista.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgb_Lista.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgb_Lista.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgb_Lista.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgb_Lista.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgb_Lista.AllowUserToAddRows = false;
            dgb_Lista.AllowUserToDeleteRows = false;
            
            dgb_Lista.ReadOnly = true;
        }
    }
}
