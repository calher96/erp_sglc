using CEN.Entidad;
using CEN.Helpers;
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

        private int childFormNumber = 0;
        public static int status_login = 0;
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
            }

        }



        private void registrarTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Trabajador frm = new frm_Trabajador();
            frm.index = childFormNumber;

            abrirFormHijo(frm, "Trabajador");

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
        private void abrirFormHijo(Object form, String titulo)
        {
            try
            {
                TabPage tp = tbc_Principal.TabPages[titulo];
                if (tp == null)
                {
                    TabPage tabpage = new TabPage();
                    Form fh = form as Form;
                    fh.AutoScroll = true;
                    fh.TopLevel = false;
                    fh.Dock = DockStyle.Fill;
                    fh.Parent = tabpage;
                    childFormNumber++;
                    tabpage.Name = titulo;
                    tabpage.Controls.Add(fh);
                    tabpage.Text = titulo;
                    tabpage.BackColor = Color.Blue;
                    tabpage.AutoScroll = true;
                    tbc_Principal.TabPages.Add(tabpage);
                    tbc_Principal.SelectedIndex = tbc_Principal.Controls.Count - 1;
                    tbc_Principal.Show();
                    tabpage.Show();
                    fh.Show();
                }
                else
                {
                    tbc_Principal.SelectedTab = tp;
                }
            }
            catch
            {

            }


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
        /*public static void cerrarPestania(int index)
        {
            TabPage tp_Eliminar = tbc_Principal.TabPages[index];
            tbc_Principal.TabPages.Remove(tp_Eliminar);
        }*/

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Cliente frm = new frm_Cliente();
            //frm.index = childFormNumber;

            abrirFormHijo(frm, "Cliente");
        }

        private void permisosYPerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Permisos frm = new frm_Permisos();
            //frm.index = childFormNumber;

            abrirFormHijo(frm, "Permisos");
        }
    }
}
