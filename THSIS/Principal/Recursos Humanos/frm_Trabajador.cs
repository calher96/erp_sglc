using CEN.Entidad;
using CEN.Helpers;
using CLN;
using Microsoft.VisualBasic.ApplicationServices;
using Principal.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DataGridViewAutoFilter;
using CEN.DGV_View;
using CEN;

namespace Principal.Recursos_Humanos
{
    public partial class frm_Trabajador : Form
    {
        public static List<ent_Correo> lista_Correo = new List<ent_Correo>();
        public static List<ent_Telefono> lista_Telefono = new List<ent_Telefono>();
        public static List<ent_Telefono> lista_Celular = new List<ent_Telefono>();
        public static List<ent_Direccion> lista_Direccion = new List<ent_Direccion>();
        public static ent_Trabajador Trabajador;
        public static Boolean EditMode = false;
        List<ent_Trabajador> lista;
        public int index;
        public frm_Trabajador()
        {
            InitializeComponent();

            inicializarFormulario();
            this.txt_Documento.KeyPress += txt_Documento_KeyPress;
            btn_Correo.Enabled = true;

        }
        private void txt_Documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void inicializarFormulario()
        {
            construirDataGridView();
            llenarColoresComboBox();

            validarFiltro();
            validarTabControl();
            cargarComboBox();
            tabControl1.Controls[1].Enabled = false;
        }
        private void listarTrabajadores()
        {
            try
            {
                dgb_Lista.Rows.Clear();
                cln_Trabajador cln = new cln_Trabajador();
                ent_Trabajador obj = new ent_Trabajador();

                if (chk_Filtrar.Checked)
                {
                    obj.Estado.Correlativo = ((ent_Concepto)cbo_Situacion.SelectedItem).Correlativo;
                    obj.Categoria.Correlativo = ((ent_Concepto)cbo_Categoria.SelectedItem).Correlativo;
                }
                else
                {
                    obj.Estado.Correlativo = 0;
                    obj.Categoria.Correlativo = 0;
                }
                obj.Empresa.Id = StaticVariable.obj_Empresa.Id;
                lista = cln.ListarTrabajador(obj);
                //List<TrabajadorView> ListaView = new List<TrabajadorView>();
                foreach (ent_Trabajador trab in lista)
                {
                    Boolean estado = (trab.Estado.Correlativo == 2 ? true : false);
                    Color color = Color.Green;
                    if (trab.Estado.Correlativo == 1)
                    {
                        color = BasicMetod.obtenerColorComboBox(cbo_Color_Baja);
                    }
                    if (trab.Estado.Correlativo == 2)
                    {
                        color = BasicMetod.obtenerColorComboBox(cbo_Color_Actividad);
                    }
                    if (trab.Estado.Correlativo == 3 || trab.Estado.Correlativo == 4)
                    {
                        color = BasicMetod.obtenerColorComboBox(cbo_Color_Liquidar);
                    }
                    //TrabajadorView trabajadorView = new TrabajadorView();
                    //trabajadorView.Id = trab.Id;
                    //trabajadorView.Dni = trab.Persona.DocIdentidad;
                    //trabajadorView.Nombres = trab.Persona.Nombres + ' ' + trab.Persona.ApellidoPaterno + ' ' + trab.Persona.ApellidoMaterno;
                    //trabajadorView.Sexo = trab.Persona.Sexo.Descripcion;
                    //trabajadorView.FechaNacimiento = trab.Persona.FechaNacimiento;
                    //trabajadorView.Codigo = trab.Codigo;
                    //trabajadorView.Disponible = estado;
                    //ListaView.Add(trabajadorView);
                    dgb_Lista.Rows.Add(trab.Id, trab.Persona.DocIdentidad, trab.Persona.Nombres + ' ' + trab.Persona.ApellidoPaterno + ' ' + trab.Persona.ApellidoMaterno,
                        trab.Persona.Sexo.Descripcion, trab.Persona.FechaNacimiento, trab.Codigo, trab.Persona.FechaNacimiento, estado);
                    dgb_Lista.Rows[dgb_Lista.RowCount - 1].DefaultCellStyle.BackColor = color;

                }
                //dgb_Lista.DataSource = ListaView;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarDepartamento()
        {
            List<ent_Ubigeo> lista;
            cln_Ubigeo cln = new cln_Ubigeo();
            lista = cln.listarUbigeo(1, "", "", "");
            cbo_Departamento.DataSource = lista;
            cbo_Departamento.ValueMember = "Descripcion";
            cbo_Departamento.DisplayMember = "Descripcion";
        }
        private void cargarSituacionFiltro()
        {
            List<ent_Concepto> lista;
            cln_Concepto cln = new cln_Concepto();
            lista = cln.listarConcepto(4);
            cbo_Situacion.DataSource = lista;
            cbo_Situacion.ValueMember = "Descripcion";
            cbo_Situacion.DisplayMember = "Descripcion";
        }
        private void cargarCategoriaFiltro()
        {
            List<ent_Concepto> lista;
            cln_Concepto cln = new cln_Concepto();
            lista = cln.listarConcepto(3);
            cbo_Categoria.DataSource = lista;
            cbo_Categoria.ValueMember = "Descripcion";
            cbo_Categoria.DisplayMember = "Descripcion";
        }
        private void cargarEstadoTrabajadoro()
        {
            List<ent_Concepto> lista;
            cln_Concepto cln = new cln_Concepto();
            lista = cln.listarConcepto(4);
            cbo_EstadoTrabajador.DataSource = lista;
            cbo_EstadoTrabajador.ValueMember = "Descripcion";
            cbo_EstadoTrabajador.DisplayMember = "Descripcion";
            cbo_EstadoTrabajador.SelectedIndex = 1;
        }
        private void cargarCategoriaTrabajador()
        {
            List<ent_Concepto> lista;
            cln_Concepto cln = new cln_Concepto();
            lista = cln.listarConcepto(3);
            cbo_CategoriaTrabajador.DataSource = lista;
            cbo_CategoriaTrabajador.ValueMember = "Descripcion";
            cbo_CategoriaTrabajador.DisplayMember = "Descripcion";
        }

        private void cargarEstadoCivil()
        {
            List<ent_Concepto> lista;
            cln_Concepto cln = new cln_Concepto();
            lista = cln.listarConcepto(2);
            cbo_EstadoCivil.DataSource = lista;
            cbo_EstadoCivil.ValueMember = "Descripcion";
            cbo_EstadoCivil.DisplayMember = "Descripcion";
        }
        private void cargarGradoInstruccion()
        {
            List<ent_Concepto> lista;
            cln_Concepto cln = new cln_Concepto();
            lista = cln.listarConcepto(6);
            cbo_GradoInstruccion.DataSource = lista;
            cbo_GradoInstruccion.ValueMember = "Descripcion";
            cbo_GradoInstruccion.DisplayMember = "Descripcion";
        }

        private void cargarPiloto()
        {
            List<ent_Concepto> lista;
            cln_Concepto cln = new cln_Concepto();
            lista = cln.listarConcepto(5);
            cbo_PuestoPiloto.DataSource = lista;
            cbo_PuestoPiloto.ValueMember = "Descripcion";
            cbo_PuestoPiloto.DisplayMember = "Descripcion";
        }
        private void cargarComboBox()
        {
            try
            {
                cargarSituacionFiltro();
                cargarCategoriaFiltro();
                cargarEstadoCivil();
                cargarDepartamento();
                cargarEstadoTrabajadoro();
                cargarCategoriaTrabajador();
                cargarGradoInstruccion();
                cargarPiloto();
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
        private void validarTabControl()
        {
            //tp_Mantenimiento.C = false;
        }
        private void llenarColoresComboBox()
        {
            //CBO_COLOR_BAJA
            cbo_Color_Baja.DataSource = typeof(Color).GetProperties()
                                        .Where(x => x.PropertyType == typeof(Color))
                                        .Select(x => x.GetValue(null)).ToList();
            cbo_Color_Baja.MaxDropDownItems = 10;
            cbo_Color_Baja.IntegralHeight = false;
            cbo_Color_Baja.DrawMode = DrawMode.OwnerDrawFixed;
            cbo_Color_Baja.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Color_Baja.SelectedIndex = 16;
            cbo_Color_Baja.DrawItem += cbo_Color_Baja_DrawItem;


            //CBO_COLOR_ACTIVIDAD
            cbo_Color_Actividad.DataSource = typeof(Color).GetProperties()
                                        .Where(x => x.PropertyType == typeof(Color))
                                        .Select(x => x.GetValue(null)).ToList();
            cbo_Color_Actividad.MaxDropDownItems = 10;
            cbo_Color_Actividad.IntegralHeight = false;
            cbo_Color_Actividad.DrawMode = DrawMode.OwnerDrawFixed;
            cbo_Color_Actividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Color_Actividad.SelectedIndex = 15;
            cbo_Color_Actividad.DrawItem += cbo_Color_Actividad_DrawItem;

            //CBO_COLOR_LIQUIDAR
            //CBO_COLOR_ACTIVIDAD
            cbo_Color_Liquidar.DataSource = typeof(Color).GetProperties()
                                        .Where(x => x.PropertyType == typeof(Color))
                                        .Select(x => x.GetValue(null)).ToList();
            cbo_Color_Liquidar.MaxDropDownItems = 10;
            cbo_Color_Liquidar.IntegralHeight = false;
            cbo_Color_Liquidar.DrawMode = DrawMode.OwnerDrawFixed;
            cbo_Color_Liquidar.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Color_Liquidar.SelectedIndex = 49;
            cbo_Color_Liquidar.DrawItem += cbo_Color_Actividad_DrawItem;
        }
        private void cbo_Color_Baja_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                var txt = cbo_Color_Baja.GetItemText(cbo_Color_Baja.Items[e.Index]);
                var color = (Color)cbo_Color_Baja.Items[e.Index];
                var r1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                var r2 = Rectangle.FromLTRB(r1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (var b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, r1);
                e.Graphics.DrawRectangle(Pens.Black, r1);
                TextRenderer.DrawText(e.Graphics, txt, cbo_Color_Baja.Font, r2,
                    cbo_Color_Baja.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }
        private void cbo_Color_Actividad_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                var txt = cbo_Color_Actividad.GetItemText(cbo_Color_Actividad.Items[e.Index]);
                var color = (Color)cbo_Color_Actividad.Items[e.Index];
                var r1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                var r2 = Rectangle.FromLTRB(r1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (var b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, r1);
                e.Graphics.DrawRectangle(Pens.Black, r1);
                TextRenderer.DrawText(e.Graphics, txt, cbo_Color_Actividad.Font, r2,
                    cbo_Color_Actividad.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }
        private void cbo_Color_Liquidar_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index >= 0)
            {
                var txt = cbo_Color_Liquidar.GetItemText(cbo_Color_Liquidar.Items[e.Index]);
                var color = (Color)cbo_Color_Liquidar.Items[e.Index];
                var r1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                var r2 = Rectangle.FromLTRB(r1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (var b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, r1);
                e.Graphics.DrawRectangle(Pens.Black, r1);
                TextRenderer.DrawText(e.Graphics, txt, cbo_Color_Liquidar.Font, r2,
                    cbo_Color_Liquidar.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }
        private void construirDataGridView()
        {
            // Create an unbound DataGridView by declaring a column count.
            dgb_Lista.ColumnCount = 7;
            dgb_Lista.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.BlueViolet;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Regular);
            dgb_Lista.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            DataGridViewColumn columnas = new DataGridViewColumn(new DataGridViewCheckBoxCell());
            columnas.Name = "DISPONIBLE";
            // Set the column header names.
            dgb_Lista.Columns[0].Name = "ID";
            dgb_Lista.Columns[1].Name = "DNI";

            dgb_Lista.Columns[2].Name = "NOMBRE COMPLETO";
            dgb_Lista.Columns[3].Name = "SEXO";
            dgb_Lista.Columns[4].Name = "FECHA DE NACIMIENTO";
            dgb_Lista.Columns[5].Name = "CÓDIGO";
            dgb_Lista.Columns[6].Name = "FECHA DE INGRESO";
            //dgb_Lista.Columns[6].Name = "ÁREA";
            //dgb_Lista.Columns[7].Name = "OCUPACIÓN";
            //dgb_Lista.Columns[8].Name = "RELACIÓN LABORAL";
            dgb_Lista.Columns.Add(columnas);
            dgb_Lista.Columns[0].Resizable = DataGridViewTriState.False;
            dgb_Lista.Columns[1].Resizable = DataGridViewTriState.False;
            dgb_Lista.Columns[2].Resizable = DataGridViewTriState.False;
            dgb_Lista.Columns[3].Resizable = DataGridViewTriState.False;
            dgb_Lista.Columns[4].Resizable = DataGridViewTriState.False;
            dgb_Lista.Columns[5].Resizable = DataGridViewTriState.False;
            //dgb_Lista.Columns[6].Resizable = DataGridViewTriState.False;
            //dgb_Lista.Columns[7].Resizable = DataGridViewTriState.False;
            //dgb_Lista.Columns[8].Resizable = DataGridViewTriState.False;

            dgb_Lista.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgb_Lista.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgb_Lista.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgb_Lista.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgb_Lista.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgb_Lista.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgb_Lista.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgb_Lista.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dgb_Lista.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgb_Lista.AllowUserToAddRows = false;
            dgb_Lista.AllowUserToDeleteRows = false;
            dgb_Lista.ReadOnly = true;
            dgb_Lista.RowHeadersVisible = true;

            dgb_Lista.EnableHeadersVisualStyles = false;
            dgb_Lista.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.Control;
            dgb_Lista.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgb_Lista.ColumnHeadersHeight = 30;
            dgb_Lista.EnableHeadersVisualStyles = false;
            dgb_Lista.AllowUserToAddRows = false;
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listarTrabajadores();
        }

        private void chk_Filtrar_CheckedChanged(object sender, EventArgs e)
        {
            validarFiltro();
        }
        private void validarFiltro()
        {
            if (!chk_Filtrar.Checked)
            {
                cbo_Situacion.Enabled = false;
                cbo_Categoria.Enabled = false;
            }
            else
            {
                cbo_Situacion.Enabled = true;
                cbo_Categoria.Enabled = true;
            }
        }

        private void cbo_Departamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            ent_Ubigeo obj = (ent_Ubigeo)cbo_Departamento.SelectedItem;
            List<ent_Ubigeo> lista;
            cln_Ubigeo cln = new cln_Ubigeo();
            lista = cln.listarUbigeo(0, obj.Ubigeo, "", "");
            cbo_Provincia.DataSource = lista;
            cbo_Provincia.ValueMember = "Descripcion";
            cbo_Provincia.DisplayMember = "Descripcion";
        }

        private void cbo_Provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            ent_Ubigeo obj = (ent_Ubigeo)cbo_Provincia.SelectedItem;
            List<ent_Ubigeo> lista;
            cln_Ubigeo cln = new cln_Ubigeo();
            lista = cln.listarUbigeo(0, "", obj.Ubigeo, "");
            cbo_Distrito.DataSource = lista;
            cbo_Distrito.ValueMember = "Descripcion";
            cbo_Distrito.DisplayMember = "Descripcion";
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            tabControl1.Controls[1].Enabled = true;
            EditMode = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TabPage tp = mdi_Principal.tbc_Principal.TabPages["Trabajador"];
            mdi_Principal.tbc_Principal.TabPages.Remove(tp);
        }
        private bool validarCampos()
        {
            errorProvider1.SetIconAlignment(txt_Nombres, ErrorIconAlignment.MiddleRight);
            String mensaje = "";
            bool resp = false;
            if (txt_Nombres.Text.Length == 0) { mensaje = "POR FAVOR, RELLENE EL/LOS NOMBRES"; txt_Nombres.Focus(); errorProvider1.SetError(txt_Nombres, "Ingrese Nombre de Trabajador"); }
            if (txt_ApellidoMaterno.Text.Length == 0) { mensaje = "POR FAVOR, RELLENE EL APELLIDO MATERNO"; txt_ApellidoMaterno.Focus(); errorProvider1.SetError(txt_ApellidoMaterno, "Ingrese Apellido Materno de Trabajador"); }
            if (txt_ApellidoPaterno.Text.Length == 0) { mensaje = "POR FAVOR, RELLENE EL APELLIDO PATERNO"; txt_ApellidoPaterno.Focus(); errorProvider1.SetError(txt_ApellidoPaterno, "Ingrese Apellido Paterno de Trabajador"); }
            if (txt_Documento.Text.Length == 0) { mensaje = "POR FAVOR, RELLENE EL NÚMERO DE DOCUMENTO"; txt_Documento.Focus(); errorProvider1.SetError(txt_Documento, "Ingrese Documento de Trabajador"); }

            if (mensaje.Length > 0) { resp = true; MessageBox.Show(mensaje, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error); }

            return resp;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validarCampos())
                {

                    cln_Trabajador cln = new cln_Trabajador();
                    ResponseHelper response;
                    if (!EditMode)
                    {
                        Trabajador = new ent_Trabajador();
                        Trabajador.Sucursal = StaticVariable.obj_Sucursal;
                        Trabajador.Persona.TipoDocIdentidad.Correlativo = 1;
                        Trabajador.Persona.DocIdentidad = txt_Documento.Text;
                        Trabajador.Persona.Id_Empresa = StaticVariable.obj_Empresa.Id;
                        Trabajador.Persona.Nombres = txt_Nombres.Text;
                        Trabajador.Persona.ApellidoPaterno = txt_ApellidoPaterno.Text;
                        Trabajador.Persona.ApellidoMaterno = txt_ApellidoMaterno.Text;
                        Trabajador.Persona.EstadoCivil = ((ent_Concepto)cbo_EstadoCivil.SelectedItem);
                        Trabajador.Estado = ((ent_Concepto)cbo_EstadoTrabajador.SelectedItem);
                        Trabajador.Categoria = ((ent_Concepto)cbo_CategoriaTrabajador.SelectedItem);
                        Trabajador.Marcabaja = 1;
                        Trabajador.Persona.FechaNacimiento = DateOnly.Parse(dtp_FechaNacimiento.Value.Date.ToShortDateString());
                        Trabajador.Persona.Sexo.Correlativo = (rbt_Femenino.Checked ? 2 : 1);
                        Trabajador.Persona.UbigeoNacimiento = ((ent_Ubigeo)cbo_Distrito.SelectedItem).Ubigeo;
                        Trabajador.Empresa = StaticVariable.obj_Empresa;
                        Trabajador.Codigo = txt_Codigo.Text;
                        Trabajador.Lista_Correo = lista_Correo;
                        Trabajador.Lista_Celular = lista_Celular;
                        Trabajador.Lista_Telefono = lista_Telefono;
                        Trabajador.Lista_Direccion = lista_Direccion;
                        Trabajador.Piloto = ((ent_Concepto)cbo_PuestoPiloto.SelectedItem);
                        Trabajador.GradoInstruccion = ((ent_Concepto)cbo_GradoInstruccion.SelectedItem);
                        Trabajador.Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
                        Trabajador.Ip = BasicVariable.Ip;
                        Trabajador.Mac = BasicVariable.Mac;
                        Trabajador.HostName = BasicVariable.HostName;
                        Trabajador.HostUser = BasicVariable.HostUser;
                        Trabajador.Persona.Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
                        Trabajador.Persona.Ip = BasicVariable.Ip;
                        Trabajador.Persona.Mac = BasicVariable.Mac;
                        Trabajador.Persona.HostName = BasicVariable.HostName;
                        Trabajador.Persona.HostUser = BasicVariable.HostUser;
                        Trabajador.Marcabaja = 1;
                        Trabajador.Persona.Marcabaja = 1;
                        Trabajador.Persona.UbigeoNacimiento = ((ent_Ubigeo)cbo_Distrito.SelectedItem).Ubigeo;
                        response = cln.guardarTrabajador(Trabajador);
                        if (response.codError == -1)
                        {
                            MessageBox.Show(response.mensajeError, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(response.mensajeError, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        limpiarCampos();
                    }
                    else
                    {
                        Trabajador.Sucursal = StaticVariable.obj_Sucursal;
                        Trabajador.Persona.TipoDocIdentidad.Correlativo = 1;
                        Trabajador.Persona.DocIdentidad = txt_Documento.Text;
                        Trabajador.Persona.Id_Empresa = StaticVariable.obj_Empresa.Id;
                        Trabajador.Persona.Nombres = txt_Nombres.Text;
                        Trabajador.Persona.ApellidoPaterno = txt_ApellidoPaterno.Text;
                        Trabajador.Persona.ApellidoMaterno = txt_ApellidoMaterno.Text;
                        Trabajador.Persona.EstadoCivil = ((ent_Concepto)cbo_EstadoCivil.SelectedItem);
                        Trabajador.Estado = ((ent_Concepto)cbo_EstadoTrabajador.SelectedItem);
                        Trabajador.Categoria = ((ent_Concepto)cbo_CategoriaTrabajador.SelectedItem);
                        Trabajador.Marcabaja = 1;
                        Trabajador.Persona.FechaNacimiento = DateOnly.Parse(dtp_FechaNacimiento.Value.Date.ToShortDateString());
                        Trabajador.Persona.Sexo.Correlativo = (rbt_Femenino.Checked ? 2 : 1);
                        Trabajador.Persona.UbigeoNacimiento = ((ent_Ubigeo)cbo_Distrito.SelectedItem).Ubigeo;
                        Trabajador.Empresa = StaticVariable.obj_Empresa;
                        Trabajador.Codigo = txt_Codigo.Text;
                        Trabajador.Lista_Correo = lista_Correo;
                        Trabajador.Lista_Celular = lista_Celular;
                        Trabajador.Lista_Telefono = lista_Telefono;
                        Trabajador.Lista_Direccion = lista_Direccion;
                        Trabajador.Piloto = ((ent_Concepto)cbo_PuestoPiloto.SelectedItem);
                        Trabajador.GradoInstruccion = ((ent_Concepto)cbo_GradoInstruccion.SelectedItem);
                        Trabajador.Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
                        Trabajador.Ip = BasicVariable.Ip;
                        Trabajador.Mac = BasicVariable.Mac;
                        Trabajador.HostName = BasicVariable.HostName;
                        Trabajador.HostUser = BasicVariable.HostUser;
                        Trabajador.Persona.Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
                        Trabajador.Persona.Ip = BasicVariable.Ip;
                        Trabajador.Persona.Mac = BasicVariable.Mac;
                        Trabajador.Persona.HostName = BasicVariable.HostName;
                        Trabajador.Persona.HostUser = BasicVariable.HostUser;
                        Trabajador.Marcabaja = 1;
                        Trabajador.Persona.Marcabaja = 1;
                        Trabajador.Persona.UbigeoNacimiento = ((ent_Ubigeo)cbo_Distrito.SelectedItem).Ubigeo;
                        response = cln.guardarTrabajador(Trabajador);
                        if (response.codError == -1)
                        {
                            MessageBox.Show(response.mensajeError, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(response.mensajeError, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        limpiarCampos();
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void limpiarCampos()
        {
            txt_Documento.Text = "";
            txt_ApellidoMaterno.Text = "";
            txt_ApellidoPaterno.Text = "";
            txt_Nombres.Text = "";
            txt_Direccion.Text = "";
            txt_Celular.Text = "";
            txt_Telefono.Text = "";
            txt_Correo.Text = "";
            dtp_FechaNacimiento.Text = DateTime.Now.ToString("dd/MM/yyyy");
            chk_Hijos.Checked = false;
            cargarComboBox();
            tabControl1.SelectedIndex = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listarTrabajadores();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            tabControl1.Controls[1].Enabled = false;
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {

        }


        private void dgb_ListaOcupacion_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


        }

        private void dgb_ListaOcupacion_MouseHover(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dgb_Lista.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                dgb_ListaOcupacion.ContextMenuStrip = cms_Principal;
            }
            else
            {
                dgb_ListaOcupacion.ContextMenuStrip = cms_Secundario;
            }
        }

        //private void textBox2_Leave(object sender, EventArgs e)
        //{
        //    Double value;
        //    if (Double.TryParse(textBox2.Text, out value))
        //        textBox2.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
        //    else
        //        textBox2.Text = String.Empty;
        //}

        private void txt_Documento_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_Documento.Text.Length > 0)
            {
                errorProvider1.SetError(txt_Documento, "");
            }
            else
            {
                errorProvider1.SetError(txt_Documento, "Ingrese Documento de Trabajador");
            }
        }

        private void txt_ApellidoPaterno_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_ApellidoPaterno.Text.Length > 0)
            {
                errorProvider1.SetError(txt_ApellidoPaterno, "");
            }
            else
            {
                errorProvider1.SetError(txt_ApellidoPaterno, "Ingrese Apellido Paterno de Trabajador");
            }
        }

        private void txt_ApellidoMaterno_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_ApellidoMaterno.Text.Length > 0)
            {
                errorProvider1.SetError(txt_ApellidoMaterno, "");
            }
            else
            {
                errorProvider1.SetError(txt_ApellidoMaterno, "Ingrese ApellidoMaterno de Trabajador");
            }
        }

        private void txt_Nombres_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_Nombres.Text.Length > 0)
            {
                errorProvider1.SetError(txt_Nombres, "");
            }
            else
            {
                errorProvider1.SetError(txt_Nombres, "Ingrese Nombres de Trabajador");
            }
        }

        private void txt_Filtro_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void dgb_Lista_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[0].Value = txt_ApellidoMaterno.Text;
        }

        private void dgb_Lista_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_Filtro_KeyUp(object sender, KeyEventArgs e)
        {
            //dgb_Lista.Rows.Clear();
            //if (txt_Filtro.Text.Length > 0)
            //{
            //    List<ent_Trabajador> listaFiltro = lista.Where(o =>
            //    o.Trab_Documento.Contains(txt_Filtro.Text, StringComparison.OrdinalIgnoreCase)
            //    || o.Trab_Nombres.Contains(txt_Filtro.Text, StringComparison.OrdinalIgnoreCase)
            //    || o.Trab_ApellidoPaterno.Contains(txt_Filtro.Text, StringComparison.OrdinalIgnoreCase)
            //    || o.Trab_ApellidoMaterno.Contains(txt_Filtro.Text, StringComparison.OrdinalIgnoreCase)
            //    || o.Trab_FechaNacimiento.ToShortDateString().Contains(txt_Filtro.Text, StringComparison.OrdinalIgnoreCase)
            //    || o.Trab_SexoDescripcion.Contains(txt_Filtro.Text, StringComparison.OrdinalIgnoreCase)
            //    || o.Area_Nombre.Contains(txt_Filtro.Text, StringComparison.OrdinalIgnoreCase)
            //    || o.Trab_RelacionLaboralDescripcion.Contains(txt_Filtro.Text, StringComparison.OrdinalIgnoreCase)).ToList();
            //    foreach (ent_Trabajador trab in listaFiltro)
            //    {
            //        Boolean estado = (trab.Trab_Estado == 2 ? true : false);
            //        Color color = Color.Green;
            //        if (trab.Trab_Estado == 1)
            //        {
            //            color = BasicMetod.obtenerColorComboBox(cbo_Color_Baja);
            //        }
            //        if (trab.Trab_Estado == 2)
            //        {
            //            color = BasicMetod.obtenerColorComboBox(cbo_Color_Actividad);
            //        }
            //        if (trab.Trab_Estado == 3 || trab.Trab_Estado == 4)
            //        {
            //            color = BasicMetod.obtenerColorComboBox(cbo_Color_Liquidar);
            //        }
            //        dgb_Lista.Rows.Add(trab.Trab_Documento, trab.Trab_Nombres + ' ' + trab.Trab_ApellidoPaterno + ' ' + trab.Trab_ApellidoMaterno,
            //            trab.Trab_SexoDescripcion, trab.Trab_FechaNacimiento, trab.Trab_codigo, trab.Trab_FechaRegistro, trab.Area_Nombre, "", trab.Trab_RelacionLaboralDescripcion, estado);
            //        dgb_Lista.Rows[dgb_Lista.RowCount - 1].DefaultCellStyle.BackColor = color;

            //    }
            //}
            //else
            //{
            //    foreach (ent_Trabajador trab in lista)
            //    {
            //        Boolean estado = (trab.Trab_Estado == 2 ? true : false);
            //        Color color = Color.Green;
            //        if (trab.Trab_Estado == 1)
            //        {
            //            color = BasicMetod.obtenerColorComboBox(cbo_Color_Baja);
            //        }
            //        if (trab.Trab_Estado == 2)
            //        {
            //            color = BasicMetod.obtenerColorComboBox(cbo_Color_Actividad);
            //        }
            //        if (trab.Trab_Estado == 3 || trab.Trab_Estado == 4)
            //        {
            //            color = BasicMetod.obtenerColorComboBox(cbo_Color_Liquidar);
            //        }
            //        dgb_Lista.Rows.Add(trab.Trab_Documento, trab.Trab_Nombres + ' ' + trab.Trab_ApellidoPaterno + ' ' + trab.Trab_ApellidoMaterno,
            //            trab.Trab_SexoDescripcion, trab.Trab_FechaNacimiento, trab.Trab_codigo, trab.Trab_FechaRegistro, trab.Area_Nombre, "", trab.Trab_RelacionLaboralDescripcion, estado);
            //        dgb_Lista.Rows[dgb_Lista.RowCount - 1].DefaultCellStyle.BackColor = color;

            //    }
            //}


        }

        private void btn_Correo_Click(object sender, EventArgs e)
        {
            frm_Correo.lista_Correo = lista_Correo;
            frm_Correo Correo = new frm_Correo();
            Correo.ShowDialog();
            if (lista_Correo.Count > 0)
            {
                txt_Correo.Text = lista_Correo[0].Correo;
            }

        }

        private void btn_Celular_Click(object sender, EventArgs e)
        {
            frm_Telefono.lista_Telefono = lista_Telefono;
            frm_Telefono Telefono = new frm_Telefono();
            Telefono.ShowDialog();
            if (lista_Telefono.Count > 0)
            {
                txt_Telefono.Text = lista_Telefono[0].Numero;
            }
        }
        public void BuscarTrabajador(int Id)
        {

            foreach (ent_Trabajador obj in lista)
            {
                if (obj.Id == Id)
                {
                    Trabajador = obj;
                }
            }
        }
        private void ConstruirEdicionTrabajador()
        {
            EditMode = true;
            tabControl1.SelectedIndex = 1;
            tabControl1.Controls[1].Enabled = true;
            lista_Correo.Clear();
            lista_Celular.Clear();
            lista_Telefono.Clear();
            lista_Direccion.Clear();
            if (dgb_Lista.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgb_Lista.SelectedRows[0]; // Obtiene la primera fila seleccionada

                // Verifica si la columna "ID" existe en el DataGridView
                if (dgb_Lista.Columns.Contains("ID"))
                {
                    BuscarTrabajador(Convert.ToInt32(selectedRow.Cells["ID"].Value));
                    txt_Documento.Text = Trabajador.Persona.DocIdentidad;
                    txt_Nombres.Text = Trabajador.Persona.Nombres;
                    txt_ApellidoPaterno.Text = Trabajador.Persona.ApellidoPaterno;
                    txt_ApellidoMaterno.Text = Trabajador.Persona.ApellidoMaterno;
                    dtp_FechaNacimiento.Value = Trabajador.Persona.FechaNacimiento.ToDateTime(new TimeOnly(0, 0, 0));
                    BasicMetod.seleccionarItemComboBoxConcepto(cbo_EstadoCivil, Trabajador.Persona.EstadoCivil);
                    BasicMetod.seleccionarUbigeo(cbo_Departamento, Trabajador.Persona.UbigeoNacimiento, "DEPARTAMENTO");
                    BasicMetod.seleccionarUbigeo(cbo_Provincia, Trabajador.Persona.UbigeoNacimiento, "PROVINCIA");
                    BasicMetod.seleccionarUbigeo(cbo_Distrito, Trabajador.Persona.UbigeoNacimiento, "DISTRITO");
                    txt_Codigo.Text = Trabajador.Codigo;
                    BasicMetod.seleccionarItemComboBoxConcepto(cbo_EstadoTrabajador, Trabajador.Estado);
                    BasicMetod.seleccionarItemComboBoxConcepto(cbo_CategoriaTrabajador, Trabajador.Categoria);
                    BasicMetod.seleccionarItemComboBoxConcepto(cbo_GradoInstruccion, Trabajador.GradoInstruccion);
                    BasicMetod.seleccionarItemComboBoxConcepto(cbo_PuestoPiloto, Trabajador.Piloto);
                    lista_Correo = Trabajador.Lista_Correo;
                    if (lista_Correo.Count > 0)
                    {
                        txt_Correo.Text = lista_Correo[0].Correo;
                    }
                    lista_Telefono = Trabajador.Lista_Telefono;
                    if (lista_Telefono.Count > 0)
                    {
                        txt_Telefono.Text = lista_Telefono[0].Numero;
                    }
                    lista_Celular = Trabajador.Lista_Celular;
                    if (lista_Celular.Count > 0)
                    {
                        txt_Celular.Text = lista_Celular[0].Numero;
                    }
                    chk_Hijos.Checked = Trabajador.Hijos;
                }
                else
                {
                    MessageBox.Show("La columna 'ID' no existe en el DataGridView.");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila.");
            }
        }

        private void dgb_Lista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ConstruirEdicionTrabajador();
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_Telefono_Click(object sender, EventArgs e)
        {

        }
    }
}
