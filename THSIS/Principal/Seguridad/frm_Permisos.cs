using CEN.Helpers;
using CLN;
using CEN.Entidad;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Principal.Seguridad
{

    public partial class frm_Permisos : Form
    {
        #region "Variables"
        public static ent_Perfil perfil = new ent_Perfil();
        public static Boolean editMode = false;
        #endregion
        #region "Consturctor"
        public frm_Permisos()
        {
            InitializeComponent();
            cargarFormulario();
        }
        #endregion
        #region "Métodos"
        public void cargarPermisoPerfil(List<ent_Permiso> lista_Permiso)
        {
            foreach (var ent_Permiso in lista_Permiso)
            {
                var arbolPrincipal = trv_Permisos.Nodes;
                foreach (TreeNode nodePrincipal in arbolPrincipal)
                {
                    if (((ent_Permiso)nodePrincipal.Tag).perm_Id == ent_Permiso.perm_Id)
                    {
                        nodePrincipal.Checked = true;
                    }
                    foreach (TreeNode nodePadre in nodePrincipal.Nodes)
                    {
                        if (((ent_Permiso)nodePadre.Tag).perm_Id == ent_Permiso.perm_Id)
                        {
                            nodePadre.Checked = true;
                        }
                        foreach (TreeNode nodeHijo in nodePadre.Nodes)
                        {
                            if (((ent_Permiso)nodeHijo.Tag).perm_Id == ent_Permiso.perm_Id)
                            {
                                nodeHijo.Checked = true;
                            }
                            foreach (TreeNode nodeSubHijo in nodeHijo.Nodes)
                            {
                                if (((ent_Permiso)nodeSubHijo.Tag).perm_Id == ent_Permiso.perm_Id)
                                {
                                    nodeSubHijo.Checked = true;
                                }
                            }
                        }
                    }
                }
            }

        }
        public void editarPerfil()
        {
            try
            {
                limpiarPermisosSeleccionados();
                if (dgb_Perfiles.SelectedRows.Count > 0)
                {
                    perfil = (ent_Perfil)dgb_Perfiles.SelectedRows[0].DataBoundItem;
                    txt_Nombre.Text = perfil.perf_Nombre;
                    cbo_Estado.SelectedValue = perfil.perf_Estado;
                    editMode = true;
                    btn_Guardar.Enabled = true;
                    btn_Eliminar.Enabled = false;
                    btn_Editar.Enabled = false;
                    cln_Perfil cln = new cln_Perfil();
                    ResponseHelper response = cln.ListarPerfil("DET", perfil.perf_Id);
                    foreach (var perf in (List<ent_Perfil>)response.response)
                    {
                        perfil = perf;
                        cargarPermisoPerfil(perf.lista_Permiso);
                    }

                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un perfil", BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {

            }
        }
        private void cargarFormulario()
        {
            cargarPermisos();
            cargarPerfiles();
            cargarEstadoPerfil();
            cargarComboPerfil();
            cargarComboPerfil();
            cargarComboTrabajador();
            trv_Permisos.AfterCheck += treeView1_AfterCheck;
        }
        private void cargarComboTrabajador()
        {
            try
            {
                cln_Trabajador cln = new cln_Trabajador();
                ent_Trabajador trabajador = new ent_Trabajador();
                trabajador.empr_Id = 2;
                trabajador.Trab_Estado = 0;
                trabajador.Trab_Categoria = 0;
                cbo_Trabajador.DataSource = cln.ListarTrabajador(trabajador);
                cbo_Trabajador.ValueMember = "Trab_Id";
                cbo_Trabajador.DisplayMember = "Trab_Nombres";
            }
            catch (Exception ex)
            {

            }
        }
        private void cargarComboPerfil()
        {
            try
            {
                cln_Perfil cln = new cln_Perfil();
                cbo_Perfil.DataSource = (List<ent_Perfil>)cln.ListarPerfil("GEN", 0).response;
                cbo_Perfil.ValueMember = "perf_Id";
                cbo_Perfil.DisplayMember = "perf_Nombre";
            }
            catch (Exception ex)
            {

            }
        }
        private void configurarColumnasPerfil()
        {
            dgb_Perfiles.Columns["empr_Id"].Visible = false;
            dgb_Perfiles.Columns["perf_Nombre"].HeaderCell.Value = "Nombre";
            dgb_Perfiles.Columns["perf_Nombre"].ValueType = typeof(String);
            dgb_Perfiles.Columns["perf_Id"].HeaderCell.Value = "Id";
            dgb_Perfiles.Columns["perf_Id"].ValueType = typeof(int);
            dgb_Perfiles.Columns["perf_EstadoDescripcion"].HeaderCell.Value = "Estado";
            dgb_Perfiles.Columns["perf_Estado"].Visible = false;
            dgb_Perfiles.Columns["perf_Usuario"].Visible = false;
            dgb_Perfiles.Columns["perf_Marcabaja"].Visible = false;
            dgb_Perfiles.Columns["perf_Id"].Visible = false;
        }
        private void cargarEstadoPerfil()
        {
            List<ent_Concepto> lista;
            cln_Concepto cln = new cln_Concepto();
            lista = cln.listarConcepto(13);
            cbo_Estado.DataSource = lista;
            cbo_Estado.ValueMember = "conc_Correlativo";
            cbo_Estado.DisplayMember = "conc_Descripcion";
        }
        private void cargarPerfiles()
        {
            try
            {
                ResponseHelper response = new ResponseHelper();
                cln_Perfil cln = new cln_Perfil();
                response = cln.ListarPerfil("GEN", 0);
                dgb_Perfiles.DataSource = (List<ent_Perfil>)response.response;
                configurarColumnasPerfil();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cargarPermisos()
        {
            try
            {
                cln_Permiso cln = new cln_Permiso();
                ResponseHelper response = cln.ListarPermiso("GEN");
                foreach (var permiso in (List<ent_Permiso>)response.response)
                {
                    if (permiso.perm_OrdenPadre == 0 && permiso.perm_OrdenHijo == 0 && permiso.perm_OrdenSubHijo == 0)
                    {
                        trv_Permisos.Nodes.Add(permiso.perm_Titulo);
                        trv_Permisos.Nodes[trv_Permisos.Nodes.Count - 1].Tag = permiso;
                    }
                    if (permiso.perm_OrdenPadre != 0 && permiso.perm_OrdenHijo == 0 && permiso.perm_OrdenSubHijo == 0)
                    {
                        var permisoPrincipal = trv_Permisos.Nodes;
                        var permisoPadre = permisoPrincipal[permisoPrincipal.Count - 1].Nodes;
                        permisoPadre.Add(permiso.perm_Titulo);
                        permisoPadre[permisoPadre.Count - 1].Tag = permiso;
                    }
                    if (permiso.perm_OrdenHijo != 0 && permiso.perm_OrdenSubHijo == 0)
                    {
                        var permisoPrincipal = trv_Permisos.Nodes;
                        var permisoPadre = permisoPrincipal[permisoPrincipal.Count - 1].Nodes;
                        var permisoHijo = permisoPadre[permisoPadre.Count - 1].Nodes;
                        permisoHijo.Add(permiso.perm_Titulo);
                        permisoHijo[permisoHijo.Count - 1].Tag = permiso;
                    }
                    if (permiso.perm_OrdenSubHijo != 0)
                    {
                        var permisoPrincipal = trv_Permisos.Nodes;
                        var permisoPadre = permisoPrincipal[permisoPrincipal.Count - 1].Nodes;
                        var permisoHijo = permisoPadre[permisoPadre.Count - 1].Nodes;
                        var permisoSubHijo = permisoHijo[permisoHijo.Count - 1].Nodes;
                        permisoSubHijo.Add(permiso.perm_Titulo);
                        permisoSubHijo[permisoSubHijo.Count - 1].Tag = permiso;
                    }
                    trv_Permisos.CheckBoxes = true;
                }
            }
            catch { }
        }

        private Boolean validarPerfil()
        {
            Boolean response = false;
            if (txt_Nombre.Text.Length == 0)
            {
                MessageBox.Show("Por favor, ingrese un nombre de perfil", BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Nombre.Focus();
                response = false;
            }
            else
            {
                response = true;
            }
            if (cbo_Estado.SelectedIndex >= 0)
            {
                response = true;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un estado de perfil", BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbo_Estado.Focus();
                response = false;
            }
            return response;
        }
        public void construirPerfil()
        {
            perfil.empr_Id = 2;
            perfil.perf_Marcabaja = 0;
            perfil.perf_Nombre = txt_Nombre.Text;
            perfil.perf_Usuario = "CHERNANDEZ";
            perfil.perf_Estado = ((ent_Concepto)cbo_Estado.SelectedItem).conc_Correlativo;
        }

        private void UpdateParentNodes(TreeNode node, bool isChecked)
        {
            if (node.Parent != null)
            {
                node.Parent.Checked = isChecked;
                UpdateParentNodes(node.Parent, isChecked);
            }
        }
        #endregion
        #region "Eventos"
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgb_Perfiles.SelectedRows.Count > 0)
                {
                    cln_Perfil cln = new cln_Perfil();

                    perfil = (ent_Perfil)dgb_Perfiles.SelectedRows[0].DataBoundItem;
                    perfil.perf_Marcabaja = 1;
                    ResponseHelper response = cln.RegistrarPerfil("D", perfil);
                    if (response.codError == 0)
                    {
                        MessageBox.Show(response.mensajeError, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(response.mensajeError, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    cargarPerfiles();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un perfil", BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            editarPerfil();
        }

        private void dgb_Perfiles_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgb_Perfiles.SelectedRows.Count > 0)
            {
                btn_Editar.Enabled = true;
                btn_Eliminar.Enabled = true;
            }
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            editMode = false;
            btn_Eliminar.Enabled = false;
            btn_Editar.Enabled = false;
            btn_Guardar.Enabled = true;
        }

        private void dgb_Perfiles_DoubleClick(object sender, EventArgs e)
        {
            editarPerfil();
        }

        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                // Verificar si el nodo seleccionado tiene un nodo padre
                if (e.Node.Parent != null)
                {
                    bool allSiblingsChecked = true;

                    // Verificar si todos los nodos hermanos están seleccionados
                    foreach (TreeNode siblingNode in e.Node.Parent.Nodes)
                    {
                        if (!siblingNode.Checked)
                        {
                            allSiblingsChecked = false;
                            break;
                        }
                    }

                    // Seleccionar o deseleccionar el nodo padre según el estado de los nodos hijos
                    e.Node.Parent.Checked = allSiblingsChecked;

                    // Recursivamente marcar o desmarcar los nodos padres hasta la raíz
                    UpdateParentNodes(e.Node.Parent, allSiblingsChecked);
                }
            }
        }
        public void limpiarPermisosSeleccionados()
        {
            List<ent_Permiso> lista = new List<ent_Permiso>();
            var arbolPrincipal = trv_Permisos.Nodes;

            foreach (TreeNode nodePrincipal in arbolPrincipal)
            {
                nodePrincipal.Checked = false;
                foreach (TreeNode nodePadre in nodePrincipal.Nodes)
                {
                    nodePadre.Checked = false;
                    foreach (TreeNode nodeHijo in nodePadre.Nodes)
                    {
                        nodeHijo.Checked = false;
                        foreach (TreeNode nodeSubHijo in nodeHijo.Nodes)
                        {
                            nodeSubHijo.Checked = false;
                        }
                    }
                }


            }
        }

        public List<ent_Permiso> listarPermisosSeleccionados()
        {
            List<ent_Permiso> lista = new List<ent_Permiso>();
            var arbolPrincipal = trv_Permisos.Nodes;

            foreach (TreeNode nodePrincipal in arbolPrincipal)
            {
                if (nodePrincipal.Checked)
                {
                    lista.Add((ent_Permiso)nodePrincipal.Tag);
                }
                foreach (TreeNode nodePadre in nodePrincipal.Nodes)
                {
                    if (nodePadre.Checked)
                    {
                        lista.Add((ent_Permiso)nodePadre.Tag);
                    }
                    foreach (TreeNode nodeHijo in nodePadre.Nodes)
                    {
                        if (nodeHijo.Checked)
                        {
                            lista.Add((ent_Permiso)nodeHijo.Tag);
                        }
                        foreach (TreeNode nodeSubHijo in nodeHijo.Nodes)
                        {
                            if (nodeSubHijo.Checked)
                            {
                                lista.Add((ent_Permiso)nodeSubHijo.Tag);
                            }
                        }
                    }
                }


            }
            return lista;
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                List<ent_Permiso> lista_Permiso = null;
                lista_Permiso = listarPermisosSeleccionados();
                if (validarPerfil() && lista_Permiso.Count > 0)
                {
                    perfil.lista_Permiso = lista_Permiso;
                    if (!editMode)
                    {
                        construirPerfil();

                        ResponseHelper response;
                        cln_Perfil cln = new cln_Perfil();
                        response = cln.RegistrarPerfil("I", perfil);
                        if (response.codError == 0)
                        {
                            MessageBox.Show(response.mensajeError, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(response.mensajeError, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        cargarPerfiles();
                        perfil = new ent_Perfil();
                    }
                    else
                    {
                        ResponseHelper response;
                        cln_Perfil cln = new cln_Perfil();
                        perfil.perf_Nombre = txt_Nombre.Text;
                        perfil.perf_Estado = ((ent_Concepto)cbo_Estado.SelectedItem).conc_Correlativo;
                        perfil.perf_Usuario = "CHERNANDEZ";
                        response = cln.RegistrarPerfil("U", perfil);
                        if (response.codError == 0)
                        {
                            MessageBox.Show(response.mensajeError, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(response.mensajeError, BasicVariable.nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        cargarPerfiles();
                        editMode = false;
                    }
                }
                limpiarPermisosSeleccionados();
                btn_Guardar.Enabled = false;
                btn_Editar.Enabled = false;
                btn_Eliminar.Enabled = false;
                txt_Nombre.Text = "";
                cbo_Estado.SelectedIndex = 0;

            }
            catch (Exception ex)
            {

            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            TabPage tp = mdi_Principal.tbc_Principal.TabPages["Permisos"];
            mdi_Principal.tbc_Principal.TabPages.Remove(tp);
        }
        #endregion
    }
}
