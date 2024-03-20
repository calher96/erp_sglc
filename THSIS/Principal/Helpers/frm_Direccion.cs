using CEN;
using CEN.Entidad;
using CLN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Principal.Helpers
{
    public partial class frm_Direccion : Form
    {
        public static List<ent_Direccion> ListaDireccionTrabajador = new List<ent_Direccion>();
        public List<ent_Direccion> ListaDireccionEliminada = new List<ent_Direccion>();
        public static List<ent_Direccion> ListaDireccionCliente = new List<ent_Direccion>();
        public frm_Direccion()
        {
            InitializeComponent();
            InicializarComboBox();
            InicializarTabla();
        }

        private void InicializarTabla()
        {
            try
            {
                if (ListaDireccionTrabajador.Count > 0)
                {
                    //ListaDireccionEliminada = ListaDireccionTrabajador.Where(d => d.Marcabaja == 0).ToList();
                    ListaDireccionTrabajador = ListaDireccionTrabajador.Where(d => d.Marcabaja == 1).ToList();
                    //dgb_Direccion.DataSource = null;
                    dgb_Direccion.DataSource = ListaDireccionTrabajador;
                    dgb_Direccion.CellFormatting += dgb_Direccion_CellFormatting;
                    dgb_Direccion.Columns["DireccionCompleta"].Width = 600;
                    dgb_Direccion.Columns["DireccionCompleta"].HeaderText = "Dirección Completa";
                    foreach (DataGridViewColumn column in dgb_Direccion.Columns)
                    {
                        if (column.Name != "DireccionCompleta")
                        {
                            column.Visible = false;
                        }
                    }
                }
                else if (ListaDireccionCliente.Count > 0)
                {
                    //ListaDireccionEliminada = ListaDireccionCliente.Where(d => d.Marcabaja == 0).ToList();
                    ListaDireccionCliente = ListaDireccionCliente.Where(d => d.Marcabaja == 1).ToList();
                    //dgb_Direccion.DataSource = null;
                    dgb_Direccion.DataSource = ListaDireccionCliente;
                    dgb_Direccion.CellFormatting += dgb_Direccion_CellFormatting;
                    dgb_Direccion.Columns["DireccionCompleta"].Width = 600;
                    dgb_Direccion.Columns["DireccionCompleta"].HeaderText = "Dirección Completa";
                    foreach (DataGridViewColumn column in dgb_Direccion.Columns)
                    {
                        if (column.Name != "DireccionCompleta")
                        {
                            column.Visible = false;
                        }
                    }
                }

                dgb_Direccion.Refresh();    
            }
            catch (Exception ex)
            {

            }
            

        }

        private void InicializarComboBox()
        {
            BasicMetod.cargarComboBox(cbo_TipoVia, 24, "Descripcion", "Descripcion");
            BasicMetod.cargarComboBox(cbo_TipoZona, 25, "Descripcion", "Descripcion");
            cargarDepartamento();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            tbc_Direccion.SelectedIndex = 1;
            tbc_Direccion.TabPages[1].Enabled = true;
            btn_Agregar.Enabled = false;
            btn_Grabar.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ent_Direccion ent_Direccion = new ent_Direccion();
                ent_Direccion.TipoVia = (ent_Concepto)cbo_TipoVia.SelectedItem;
                ent_Direccion.TipoZona = (ent_Concepto)cbo_TipoZona.SelectedItem;
                ent_Direccion.NombreVia = txt_NombreVia.Text;
                ent_Direccion.Numero = txt_Numero.Text;
                ent_Direccion.Departamento = txt_Departamento.Text;
                ent_Direccion.Interior = txt_Interior.Text;
                ent_Direccion.Manzana = txt_Manzana.Text;
                ent_Direccion.Lote = txt_Lote.Text;
                ent_Direccion.Kilometro = txt_Kilometro.Text;
                ent_Direccion.Bloque = txt_Block.Text;
                ent_Direccion.Etapa = txt_Etapa.Text;
                ent_Direccion.NombreZona = txt_NombreZona.Text;
                ent_Direccion.Referencia = txt_Referencia.Text;
                ent_Direccion.Ubigeo = ((ent_Ubigeo)cbo_Distrito.SelectedItem).Ubigeo;
                ent_Direccion.Marcabaja = 1;
                if (ListaDireccionCliente.Count > 0)
                {
                    ListaDireccionCliente.Add(ent_Direccion);
                }
                else
                {
                    ListaDireccionTrabajador.Add(ent_Direccion);
                }
                
                InicializarTabla();
                tbc_Direccion.SelectedIndex = 0;
                btn_Agregar.Enabled = true;
                btn_Grabar.Enabled = false;
            }
            catch (Exception ex)
            {
                throw;
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

        private void dgb_Direccion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgb_Direccion.Columns["TipoVia"].Index && e.RowIndex >= 0)
            {
                if (dgb_Direccion.Rows[e.RowIndex].DataBoundItem is ent_Direccion direccion)
                {
                    e.Value = direccion.TipoVia.Descripcion;
                }
            }

            if (e.ColumnIndex == dgb_Direccion.Columns["TipoZona"].Index && e.RowIndex >= 0)
            {
                if (dgb_Direccion.Rows[e.RowIndex].DataBoundItem is ent_Direccion direccion)
                {
                    e.Value = direccion.TipoZona.Descripcion;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaDireccionTrabajador.AddRange(ListaDireccionEliminada);
            if (ListaDireccionTrabajador.Count > 0)
            {
                this.Dispose();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado una fila en el DataGridView
            if (dgb_Direccion.SelectedRows.Count > 0)
            {
                // Obtén el objeto ent_Direccion de la fila seleccionada
                ent_Direccion direccionSeleccionada = (ent_Direccion)dgb_Direccion.SelectedRows[0].DataBoundItem;
                
                // Cambia el valor de la propiedad "Marcabaja" a 0
                direccionSeleccionada.Marcabaja = 0;
                ListaDireccionEliminada.Add(direccionSeleccionada);
                // Vuelve a enlazar el DataGridView para reflejar los cambios
                InicializarTabla();

                MessageBox.Show("Dirección marcada como eliminada.");
            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de eliminar.");
            }
        }

        private void dgb_Direccion_SelectionChanged(object sender, EventArgs e)
        {
            //if (dgb_Direccion.SelectedRows.Count > 0)
            //{
            //    btn_Quitar.Enabled = true; // Habilita el botón si se selecciona al menos una fila
            //}
            //else
            //{
            //    btn_Quitar.Enabled = false; // Deshabilita el botón si no se selecciona ninguna fila
            //}
        }

        private void dgb_Direccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgb_Direccion.SelectedRows.Count > 0)
            {
                btn_Quitar.Enabled = true; // Habilita el botón si se selecciona al menos una fila
            }
            else
            {
                btn_Quitar.Enabled = false; // Deshabilita el botón si no se selecciona ninguna fila
            }
        }
    }
}
