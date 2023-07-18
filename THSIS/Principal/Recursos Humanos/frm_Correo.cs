using CEN.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal.Recursos_Humanos
{
    public partial class frm_Correo : Form
    {
        public static List<ent_Correo> lista_Correo = new List<ent_Correo>();
        public frm_Correo()
        {
            InitializeComponent();
            construirTabla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_Correo.Text.Length > 0)
            {
                ent_Correo correo = new ent_Correo();
                if (lista_Correo.Count == 0)
                {
                    correo.corr_Principal = true;
                }
                else
                {
                    correo.corr_Principal = false;
                }
                correo.corr_Correo = txt_Correo.Text;
                lista_Correo.Add(correo);
            }
            construirTabla();
            txt_Correo.Text = "";
            tabControl1.SelectedIndex = 0;
            btn_Grabar.Enabled = false;
            btn_Agregar.Enabled = true;
        }
        private void construirTabla()
        {
            dgv_Correo.Rows.Clear();
            foreach (ent_Correo correo in lista_Correo)
            {
                dgv_Correo.Rows.Add(correo.corr_Principal, correo.corr_Correo);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            tabControl1.Controls[1].Enabled = true;
            btn_Grabar.Enabled = true;
            btn_Agregar.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm_Trabajador.lista_Correo = lista_Correo;
            this.Dispose(true);
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            btn_Grabar.Enabled = true;
            btn_Modificar.Enabled = false;
        }

        private void dgv_Correo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_Correo.SelectedRows[0].Index > -1)
            {
                btn_Quitar.Enabled = true;
                btn_Modificar.Enabled = true;
            }
            else
            {
                btn_Quitar.Enabled = false;
                btn_Modificar.Enabled = false;
            }
        }
    }
}
