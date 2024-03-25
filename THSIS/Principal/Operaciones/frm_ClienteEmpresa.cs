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
    public partial class frm_ClienteEmpresa : Form
    {
        private frm_Direccion frm;
        private Boolean EditMode = false;
        ent_Cliente Cliente;
        List<ent_TipoPago> ListaTipoPago;
        public frm_ClienteEmpresa()
        {
            InitializeComponent();

            Cliente = new ent_Cliente();
            ListaTipoPago = new List<ent_TipoPago>();
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            try
            {
                //InicializarDireccion();
                InicializarComboBox();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void InicializarTablaTipoPago()
        {
            dgb_TipoPago.DataSource = null;
            dgb_TipoPago.DataSource = ListaTipoPago;
            Boolean columnaTipoClienteExiste = false;
            Boolean columnaDiasExiste = false;
            foreach (DataGridViewColumn columna in dgb_TipoPago.Columns)
            {
                if (columna.Name == "TipoCliente")
                {
                    columnaTipoClienteExiste = true;
                }
                if (columna.Name == "Dias")
                {
                    columnaDiasExiste = true;
                }
            }
            if (!columnaTipoClienteExiste)
            {
                dgb_TipoPago.Columns.Add("TipoCliente", "Tipo");
            }
            if (!columnaDiasExiste)
            {
                dgb_TipoPago.Columns.Add("Dias", "Dias");
            }
            foreach (DataGridViewColumn column in dgb_TipoPago.Columns)
            {
                if (column.Name != "TipoPago" && column.Name != "TipoCliente" && column.Name != "Dias")
                {
                    column.Visible = false;
                }
            }

            // Suscríbete al evento CellFormatting
            dgb_TipoPago.CellFormatting += dgb_TipoPago_CellFormatting;
        }
        private void dgb_TipoPago_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgb_TipoPago.Columns[e.ColumnIndex].Name == "TipoCliente")
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgb_TipoPago.Rows.Count)
                {
                    var tipoPago = dgb_TipoPago.Rows[e.RowIndex].DataBoundItem as ent_TipoPago;

                    if (tipoPago != null)
                    {
                        if (tipoPago.Cliente && tipoPago.Proveedor)
                        {
                            e.Value = "CLIENTE / PROVEEDOR";
                        }
                        else if (tipoPago.Cliente)
                        {
                            e.Value = "CLIENTE";
                        }
                        else if (tipoPago.Proveedor)
                        {
                            e.Value = "PROVEEDOR";
                        }
                        else
                        {
                            e.Value = "No Especificado";
                        }
                    }
                }
            }
            if (dgb_TipoPago.Columns[e.ColumnIndex].Name == "TipoPago")
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgb_TipoPago.Rows.Count)
                {
                    var tipoPago = dgb_TipoPago.Rows[e.RowIndex].DataBoundItem as ent_TipoPago;

                    if (tipoPago != null)
                    {
                        e.Value = tipoPago.TipoPago.Descripcion;
                    }
                }
            }
            if (dgb_TipoPago.Columns[e.ColumnIndex].Name == "Dias")
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgb_TipoPago.Rows.Count)
                {
                    var tipoPago = dgb_TipoPago.Rows[e.RowIndex].DataBoundItem as ent_TipoPago;

                    if (tipoPago != null)
                    {
                        e.Value = tipoPago.TipoPago.Valor1;
                    }
                }
            }
        }

        private void InicializarComboBox()
        {
            BasicMetod.cargarComboBox(cbo_Moneda, 21, "Descripcion", "Descripcion");
            BasicMetod.cargarComboBox(cbo_TipoDocumento, 1, "Descripcion", "Descripcion");
            BasicMetod.cargarComboBox(cbo_ClasificacionEMP, 32, "Descripcion", "Descripcion");
            BasicMetod.cargarComboBox(cbo_TipoEmpresa, 33, "Descripcion", "Descripcion");
            BasicMetod.cargarComboBox(cbo_TipoPago, 18, "Descripcion", "Descripcion");
            BasicMetod.cargarComboBox(cbo_TipoNivelComercial, 34, "Descripcion", "Descripcion");
            BasicMetod.cargarComboBox(cbo_clasificacionCliente, 35, "Descripcion", "Descripcion");
        }
        private void InicializarDireccion()
        {
            frm_Direccion.mode = 1;
            frm_Direccion.ListaDireccionCliente.Clear();
            frm_Direccion.ListaDireccionTrabajador.Clear();
            frm_Direccion.ListaDireccionCliente = Cliente.Lista_Direccion;
            frm = new frm_Direccion();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            tpg_DireccionCliente.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
            tpg_DireccionCliente.Refresh();
            //Cliente.Lista_Direccion = frm_Direccion.ListaDireccionCliente;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_AgregarTipoPago.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnl_AgregarTipoPago.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ent_TipoPago ent_TipoPago = new ent_TipoPago();
                ent_TipoPago.TipoPago = (ent_Concepto)cbo_TipoPago.SelectedItem;
                ent_TipoPago.Cliente = rbt_TipoPagoCliente.Checked;
                ent_TipoPago.Proveedor = rbt_TipoPagoProveedor.Checked;
                ent_TipoPago.Marcabaja = 1;
                ListaTipoPago.Add(ent_TipoPago);
                InicializarTablaTipoPago();
                pnl_AgregarTipoPago.Visible = false;

            }
            catch (Exception ex)
            {

            }

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ListarClientes();
            }
            catch (Exception ex)
            {

            }
        }

        private void ListarClientes()
        {
            List<ent_Cliente> ListaCliente = new List<ent_Cliente>();
            ent_Cliente ent_Cliente = new ent_Cliente();
            cln_Cliente cln_Cliente = new cln_Cliente();

            ent_Cliente.Empresa.Id = StaticVariable.obj_Empresa.Id;

            ListaCliente = cln_Cliente.ListarCliente(ent_Cliente, "GEN");
            dgb_Cliente.DataSource = null;
            dgb_Cliente.DataSource = ListaCliente;
            var columnaNumeroDoc = false;
            var columnaNombre = false;
            foreach (DataGridViewColumn columna in dgb_Cliente.Columns)
            {
                if (columna.Name == "NumeroDoc")
                {
                    columnaNumeroDoc = true;
                }
                if (columna.Name == "Nombre")
                {
                    columnaNombre = true;
                }
            }
            if (!columnaNumeroDoc)
            {
                DataGridViewTextBoxColumn ColumnaNumeroDoc = new DataGridViewTextBoxColumn();
                ColumnaNumeroDoc.Name = "NumeroDoc";
                ColumnaNumeroDoc.HeaderText = "N° Doc.";
                dgb_Cliente.Columns.Insert(1, ColumnaNumeroDoc);
            }
            if (!columnaNombre)
            {
                DataGridViewTextBoxColumn ColumnaNombre = new DataGridViewTextBoxColumn();
                ColumnaNombre.Name = "Nombre";
                ColumnaNombre.HeaderText = "Nombre";
                dgb_Cliente.Columns.Insert(2, ColumnaNombre);
            }



            dgb_Cliente.CellFormatting += dgb_Cliente_CellFormatting;
            dgb_Cliente.Columns["Nombre"].SortMode = DataGridViewColumnSortMode.Programmatic;

            foreach (DataGridViewColumn column in dgb_Cliente.Columns)
            {
                if (column.Name != "Telefono" && column.Name != "NumeroDoc" && column.Name != "Nombre" && column.Name != "Abreviatura" && column.Name != "DomicilioFiscal" && column.Name != "TipoEmpresa" && column.Name != "Percepcion" && column.Name != "Retencion" && column.Name != "BuenContribuyente" && column.Name != "CanjeDocumento" && column.Name != "Letras" && column.Name != "Cheque" && column.Name != "EmpresaRelacionada" && column.Name != "Morosidad" && column.Name != "LineaCredito")
                {
                    column.Visible = false;
                }
            }

        }

        private void dgb_Cliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgb_Cliente.Columns[e.ColumnIndex].Name == "TipoEmpresa")
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgb_Cliente.Rows.Count)
                {
                    var cliente = dgb_Cliente.Rows[e.RowIndex].DataBoundItem as ent_Cliente;

                    e.Value = cliente.TipoEmpresa.Descripcion;
                }
            }

            if (dgb_Cliente.Columns[e.ColumnIndex].Name == "NumeroDoc")
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgb_Cliente.Rows.Count)
                {
                    var cliente = dgb_Cliente.Rows[e.RowIndex].DataBoundItem as ent_Cliente;

                    e.Value = cliente.Persona.DocIdentidad;
                }
            }
            if (dgb_Cliente.Columns[e.ColumnIndex].Name == "Nombre")
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgb_Cliente.Rows.Count)
                {
                    var cliente = dgb_Cliente.Rows[e.RowIndex].DataBoundItem as ent_Cliente;
                    if (cliente.RazonSocial.Length > 0)
                    {
                        e.Value = cliente.RazonSocial;
                    }
                    else
                    {
                        e.Value = cliente.Persona.ApellidoPaterno + " " + cliente.Persona.ApellidoMaterno + " " + cliente.Persona.Nombres;
                    }

                }
            }

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            TabPage tp = mdi_Principal.tbc_Principal.TabPages["Empresa"];
            mdi_Principal.tbc_Principal.TabPages.Remove(tp);
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            tbc_EmpresaCliente.SelectedIndex = 1;
            tbc_EmpresaCliente.Controls[1].Enabled = true;
            EditMode = false;
            Cliente = new ent_Cliente();
            frm_Direccion.ListaDireccionCliente.Clear();
            InicializarDireccion();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                cln_Cliente cln_Cliente = new cln_Cliente();
                Cliente.Lista_Direccion = frm_Direccion.ListaDireccionCliente;

                Cliente.Lista_TipoPago = (List<ent_TipoPago>)dgb_TipoPago.DataSource;
                foreach (ent_TipoPago TipoPago in Cliente.Lista_TipoPago)
                {
                    TipoPago.Ip = BasicVariable.Ip;
                    TipoPago.Mac = BasicVariable.Mac;
                    TipoPago.Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
                    TipoPago.HostName = BasicVariable.HostName;
                    TipoPago.HostUser = BasicVariable.HostUser;
                }
                Cliente.RazonSocial = txt_RazonSocial.Text;
                Cliente.Estado.Correlativo = 1;
                Cliente.Persona.TipoDocIdentidad = (ent_Concepto)cbo_TipoDocumento.SelectedItem;
                Cliente.Persona.DocIdentidad = txt_NumeroDoc.Text;
                Cliente.EmpresaRelacionada = chk_EmpresaRelacionada.Checked;
                Cliente.TipoEmpresa = (ent_Concepto)cbo_TipoEmpresa.SelectedItem;
                Cliente.Telefono = txt_Telefono.Text;
                Cliente.Abreviatura = txt_Abreviatura.Text;
                Cliente.Moneda = (ent_Concepto)cbo_Moneda.SelectedItem;
                Cliente.Correo = txt_Correo.Text;
                Cliente.DomicilioFiscal = txt_DireccionFiscal.Text;
                Cliente.Cliente = rbt_ClienteSi.Checked;
                Cliente.Proveedor = rbt_ProveedorSi.Checked;
                Cliente.Comisionista = rbt_ComisionistaSi.Checked;
                Cliente.ClasificacionEMP = (ent_Concepto)cbo_ClasificacionEMP.SelectedItem;
                Cliente.Percepcion = chk_Percepcion.Checked;
                Cliente.Retencion = chk_Retencion.Checked;
                Cliente.BuenContribuyente = chk_BuenContribuyente.Checked;
                Cliente.CanjeDocumento = chk_CanjeDocumento.Checked;
                Cliente.Letras = chk_Letras.Checked;
                Cliente.Cheque = chk_Cheque.Checked;
                Cliente.Morosidad = Convert.ToDouble(txt_Morosidad.Text.Length > 0 ? txt_Morosidad.Text : "0.0");
                Cliente.LineaCredito = Convert.ToDouble(txt_LineaCredito.Text.Length > 0 ? txt_LineaCredito.Text : "0.0");
                Cliente.TipoNivelComercial = (ent_Concepto)cbo_TipoNivelComercial.SelectedItem;
                Cliente.ClasificacionTipo = (ent_Concepto)cbo_clasificacionCliente.SelectedItem;
                Cliente.Empresa.Id = StaticVariable.obj_Empresa.Id;
                Cliente.Persona.Id_Empresa = StaticVariable.obj_Empresa.Id;
                Cliente.Ip = BasicVariable.Ip;
                Cliente.Mac = BasicVariable.Mac;
                Cliente.Usuario = StaticVariable.obj_Usuario.Usua_Usuario;
                Cliente.HostName = BasicVariable.HostName;
                Cliente.HostUser = BasicVariable.HostUser;
                ResponseHelper response = cln_Cliente.guardarCliente(Cliente, (EditMode ? "U" : "I"));
                if (response.codError == -1)
                {
                    MessageBox.Show(response.mensajeError, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frm.Dispose();
                }
                else
                {
                    MessageBox.Show(response.mensajeError, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void dgb_Cliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //InicializarDireccion();
            if (e.RowIndex >= 0)
            {
                // Obtiene la fila seleccionada.
                DataGridViewRow filaSeleccionada = dgb_Cliente.Rows[e.RowIndex];

                // Accede a la propiedad DataBoundItem de la fila para obtener el cliente seleccionado.
                if (filaSeleccionada.DataBoundItem is ent_Cliente clienteSeleccionado)
                {
                    Cliente = clienteSeleccionado;
                    llenarCliente();
                }
            }
        }
        private void llenarCliente()
        {
            try
            {
                BasicMetod.seleccionarItemComboBoxConcepto(cbo_clasificacionCliente, Cliente.ClasificacionTipo);
                BasicMetod.seleccionarItemComboBoxConcepto(cbo_TipoDocumento, Cliente.Persona.TipoDocIdentidad);
                BasicMetod.seleccionarItemComboBoxConcepto(cbo_TipoEmpresa, Cliente.TipoEmpresa);
                BasicMetod.seleccionarItemComboBoxConcepto(cbo_Moneda, Cliente.Moneda);
                BasicMetod.seleccionarItemComboBoxConcepto(cbo_ClasificacionEMP, Cliente.ClasificacionEMP);
                BasicMetod.seleccionarItemComboBoxConcepto(cbo_clasificacionCliente, Cliente.ClasificacionTipo);
                txt_NumeroDoc.Text = Cliente.Persona.DocIdentidad;
                txt_RazonSocial.Text = Cliente.RazonSocial;
                txt_Abreviatura.Text = Cliente.Abreviatura;
                txt_DireccionFiscal.Text = Cliente.DomicilioFiscal;
                dgb_TipoPago.DataSource = null;
                ListaTipoPago = Cliente.Lista_TipoPago;
                if (Cliente.Cliente)
                {
                    rbt_ClienteSi.Select();
                }
                else
                {
                    rbt_ClienteNo.Select();
                }
                if (Cliente.Proveedor)
                {
                    rbt_ProveedorSi.Select();
                }
                else
                {
                    rbt_ProveedorNo.Select();
                }
                if (Cliente.Comisionista)
                {
                    rbt_ComisionistaSi.Select();
                }
                else
                {
                    rbt_ComisionistaNo.Select();
                }
                chk_EmpresaRelacionada.Checked = Cliente.EmpresaRelacionada;
                chk_Percepcion.Checked = Cliente.Percepcion;
                chk_Retencion.Checked = Cliente.Retencion;
                chk_BuenContribuyente.Checked = Cliente.BuenContribuyente;
                chk_CanjeDocumento.Checked = Cliente.CanjeDocumento;
                chk_Letras.Checked = Cliente.Letras;
                chk_Cheque.Checked = Cliente.Cheque;
                txt_Telefono.Text = Cliente.Telefono;
                txt_Correo.Text = Cliente.Correo;
                txt_Morosidad.Text = Cliente.Morosidad.ToString();
                txt_LineaCredito.Text = Cliente.LineaCredito.ToString();
                tbc_EmpresaCliente.SelectedIndex = 1;
                tbc_EmpresaCliente.Controls[1].Enabled = true;
                EditMode = true;
                InicializarDireccion();
                InicializarTablaTipoPago();
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (dgb_Cliente.SelectedRows.Count > 0)
            {
                // Obtiene la fila seleccionada.
                DataGridViewRow filaSeleccionada = dgb_Cliente.SelectedRows[0];

                // Obtiene la entidad del cliente de la fila seleccionada.
                if (filaSeleccionada.DataBoundItem is ent_Cliente clienteSeleccionado)
                {
                    Cliente = clienteSeleccionado;
                    llenarCliente();
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            tbc_EmpresaCliente.SelectedIndex = 0;
            tbc_EmpresaCliente.Controls[1].Enabled = false;
            EditMode = false;
            Cliente = new ent_Cliente();
            frm.Dispose();
        }

        
    }
}
