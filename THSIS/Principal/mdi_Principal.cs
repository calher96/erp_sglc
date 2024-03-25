using CEN.Entidad;
using CEN.Helpers;
using Principal.Helpers;
using Principal.Operaciones;
using Principal.Recursos_Humanos;
using Principal.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class mdi_Principal : Form
    {
        #region "Variables"
        public static int status_login = 0;
        #endregion
        #region "Constructor"
        public mdi_Principal()
        {
            InitializeComponent();
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            if (status_login == 0)
            {
                this.Dispose();
            }
            else
            {
                cargarPermisos();
                cargarPiePrincipal();
            }

        }
        #endregion
        #region "Métodos"
        private void cargarPiePrincipal()
        {
            lbl_Usuario.Text = StaticVariable.obj_Trabajador.Persona.ApellidoPaterno + " " + StaticVariable.obj_Trabajador.Persona.ApellidoMaterno + " " + StaticVariable.obj_Trabajador.Persona.Nombres;
            lbl_Desde.Text = BasicVariable.HostUser + "(" + BasicVariable.Ip + ")";
            //lbl_Desde.Text = BasicVariable.Ip;
            //MessageBox.Show(BasicVariable.Ip, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cargarPermisos()
        {
            foreach (ent_Permiso permiso in StaticVariable.obj_Perfil.lista_Permiso)
            {
                Control[] Controls = this.Controls.Find("menuStrip1", true);
                foreach (Control control in Controls)
                {

                    foreach (ToolStripDropDownItem item in ((MenuStrip)control).Items)
                    {
                        if (item.Name == permiso.perm_Control)
                        {
                            item.Visible = true;
                            item.Tag = permiso;
                            break;
                        }
                        else
                        {
                            ToolStripItemCollection itemsPadre = item.DropDownItems;
                            foreach (ToolStripMenuItem itemPadre in itemsPadre)
                            {
                                if (itemPadre.Name == permiso.perm_Control)
                                {
                                    itemPadre.Visible = true;
                                    itemPadre.Tag = permiso;
                                    break;
                                }
                                else
                                {
                                    ToolStripItemCollection itemsHijo = itemPadre.DropDownItems;
                                    foreach (ToolStripMenuItem itemHijo in itemsHijo)
                                    {
                                        if (itemHijo.Name == permiso.perm_Control)
                                        {
                                            itemHijo.Visible = true;
                                            itemHijo.Tag = permiso;
                                            break;
                                        }
                                        else
                                        {
                                            ToolStripItemCollection itemsSubHijo = itemHijo.DropDownItems;
                                            foreach (ToolStripMenuItem itemSubHijo in itemsSubHijo)
                                            {
                                                if (itemSubHijo.Name == permiso.perm_Control)
                                                {
                                                    itemSubHijo.Visible = true;
                                                    itemSubHijo.Tag = permiso;
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        #endregion
        #region "Eventos"

        private void registrarTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Trabajador frm = new frm_Trabajador();
            BasicMetod.abrirFormHijo(frm, "Trabajador");

        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void tbc_Principal_MouseMove(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tbc_Principal.TabCount; i++)
            {
                if (tbc_Principal.GetTabRect(i).Contains(e.X, e.Y))
                {
                    tbc_Principal.SelectedIndex = i;
                    break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToShortTimeString();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cliente frm = new frm_Cliente();
            BasicMetod.abrirFormHijo(frm, "Cliente");
        }

        private void permisosYPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Permisos frm = new frm_Permisos();
            BasicMetod.abrirFormHijo(frm, "Permisos");
        }

        private void tsm_Carga_Click(object sender, EventArgs e)
        {
            frm_RecepcionCarga frm = new frm_RecepcionCarga();
            BasicMetod.abrirFormHijo(frm, "Recepción Carga");
        }

        private void tsm_CerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            StaticVariable.obj_Usuario = null;
            StaticVariable.obj_Empresa = null;
            StaticVariable.obj_Perfil = null;
            this.Close();
            login.ShowDialog();
        }
        private void tsm_Empresa_Click(object sender, EventArgs e)
        {
            frm_ClienteEmpresa frm = new frm_ClienteEmpresa();
            BasicMetod.abrirFormHijo(frm, "Empresa");
        }
        #endregion



        private void tsm_GRT_Click(object sender, EventArgs e)
        {
            frm_GuiaRemisionTransportista frm = new frm_GuiaRemisionTransportista();
            BasicMetod.abrirFormHijo(frm, "Guia Remisión");
        }
    }
}
