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
                InicializarDireccion();
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
            frm_Direccion.ListaDireccionCliente.Clear();
            frm_Direccion.ListaDireccionTrabajador.Clear();
            frm_Direccion.ListaDireccionCliente = Cliente.Lista_Direccion;
            frm_Direccion frm = new frm_Direccion();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            tpg_DireccionCliente.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
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
            pnl_AgregarTipoPago.Visible = true;
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
            DataGridViewTextBoxColumn ColumnaNumeroDoc = new DataGridViewTextBoxColumn();
            ColumnaNumeroDoc.Name = "NumeroDoc";
            ColumnaNumeroDoc.HeaderText = "N° Doc.";
            dgb_Cliente.Columns.Insert(1, ColumnaNumeroDoc);
            DataGridViewTextBoxColumn ColumnaNombre = new DataGridViewTextBoxColumn();
            ColumnaNombre.Name = "Nombre";
            ColumnaNombre.HeaderText = "Nombre";
            dgb_Cliente.Columns.Insert(2, ColumnaNombre);

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
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                cln_Cliente cln_Cliente = new cln_Cliente();
                Cliente.Lista_Direccion = frm_Direccion.ListaDireccionCliente;
                Cliente.Lista_TipoPago = (List<ent_TipoPago>)dgb_TipoPago.DataSource;
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
                Cliente.Morosidad = Convert.ToDouble(txt_Morosidad.Text);
                Cliente.LineaCredito = Convert.ToDouble(txt_LineaCredito.Text);
                Cliente.TipoNivelComercial = (ent_Concepto)cbo_TipoNivelComercial.SelectedItem;
                Cliente.ClasificacionTipo = (ent_Concepto)cbo_clasificacionCliente.SelectedItem;
                ResponseHelper response = cln_Cliente.guardarCliente(Cliente, (EditMode ? "I" : "U"));
                if (response.codError == -1)
                {
                    MessageBox.Show(response.mensajeError, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}
