using CEN.Entidad;
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

namespace Principal.Recursos_Humanos
{

    public partial class frm_Telefono : Form
    {
        public static List<ent_Telefono> lista_Telefono = new List<ent_Telefono>();
        public frm_Telefono()
        {
            InitializeComponent();
            cargarCombos();
        }
        private void cargarCombos()
        {

            BasicMetod.cargarComboBox(cmb_Tipo, 11, "Descripcion", "Descripcion");
            BasicMetod.cargarComboBox(cmb_Operador, 12, "Descripcion", "Descripcion");
        }
        

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            tabControl1.Controls[1].Enabled = true;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

        }
    }
}
