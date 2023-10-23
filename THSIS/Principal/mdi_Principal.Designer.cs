namespace Principal
{
    partial class mdi_Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdi_Principal));
            toolTip = new ToolTip(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            tsm_Operaciones = new ToolStripMenuItem();
            tsm_GestionClientes = new ToolStripMenuItem();
            tsm_Clientes = new ToolStripMenuItem();
            tsm_Carga = new ToolStripMenuItem();
            tsm_Planeamiento = new ToolStripMenuItem();
            tsm_Administracion = new ToolStripMenuItem();
            tsm_Finanzas = new ToolStripMenuItem();
            tsm_Contabilidad = new ToolStripMenuItem();
            tsm_Mantenimiento = new ToolStripMenuItem();
            tsm_Neumaticos = new ToolStripMenuItem();
            tsm_Logistica = new ToolStripMenuItem();
            tsm_Personal = new ToolStripMenuItem();
            tsm_Trabajador = new ToolStripMenuItem();
            tsm_Seguridad = new ToolStripMenuItem();
            tsm_Configuracion = new ToolStripMenuItem();
            tsm_PermisosPerfiles = new ToolStripMenuItem();
            tsm_CerrarSesion = new ToolStripMenuItem();
            tsm_Empresa = new ToolStripMenuItem();
            tsm_Reportes = new ToolStripMenuItem();
            tsm_Ayuda = new ToolStripMenuItem();
            tsm_Grifo = new ToolStripMenuItem();
            panel1 = new Panel();
            lbl_Desde = new Label();
            lbl_Hora = new Label();
            label2 = new Label();
            lbl_Usuario = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tbc_Principal = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            tbc_Principal.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { cerrarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(123, 30);
            // 
            // cerrarToolStripMenuItem
            // 
            cerrarToolStripMenuItem.Image = Properties.Resources.cerrar1;
            cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            cerrarToolStripMenuItem.Size = new Size(122, 26);
            cerrarToolStripMenuItem.Text = "Cerrar";
            cerrarToolStripMenuItem.Click += cerrarToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsm_Operaciones, tsm_Planeamiento, tsm_Administracion, tsm_Finanzas, tsm_Contabilidad, tsm_Mantenimiento, tsm_Neumaticos, tsm_Logistica, tsm_Personal, tsm_Seguridad, tsm_Configuracion, tsm_Reportes, tsm_Ayuda, tsm_Grifo });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1541, 42);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsm_Operaciones
            // 
            tsm_Operaciones.DropDownItems.AddRange(new ToolStripItem[] { tsm_GestionClientes, tsm_Carga });
            tsm_Operaciones.Image = (Image)resources.GetObject("tsm_Operaciones.Image");
            tsm_Operaciones.ImageScaling = ToolStripItemImageScaling.None;
            tsm_Operaciones.Name = "tsm_Operaciones";
            tsm_Operaciones.Size = new Size(138, 36);
            tsm_Operaciones.Text = "Operaciones";
            tsm_Operaciones.Visible = false;
            // 
            // tsm_GestionClientes
            // 
            tsm_GestionClientes.DropDownItems.AddRange(new ToolStripItem[] { tsm_Clientes });
            tsm_GestionClientes.Image = (Image)resources.GetObject("tsm_GestionClientes.Image");
            tsm_GestionClientes.ImageScaling = ToolStripItemImageScaling.None;
            tsm_GestionClientes.Name = "tsm_GestionClientes";
            tsm_GestionClientes.Size = new Size(231, 38);
            tsm_GestionClientes.Text = "Gestión de Clientes";
            tsm_GestionClientes.Visible = false;
            // 
            // tsm_Clientes
            // 
            tsm_Clientes.Image = (Image)resources.GetObject("tsm_Clientes.Image");
            tsm_Clientes.ImageScaling = ToolStripItemImageScaling.None;
            tsm_Clientes.Name = "tsm_Clientes";
            tsm_Clientes.Size = new Size(156, 38);
            tsm_Clientes.Text = "Clientes";
            tsm_Clientes.Visible = false;
            tsm_Clientes.Click += clientesToolStripMenuItem_Click;
            // 
            // tsm_Carga
            // 
            tsm_Carga.Image = (Image)resources.GetObject("tsm_Carga.Image");
            tsm_Carga.ImageScaling = ToolStripItemImageScaling.None;
            tsm_Carga.Name = "tsm_Carga";
            tsm_Carga.Size = new Size(231, 38);
            tsm_Carga.Text = "Carga";
            tsm_Carga.Visible = false;
            tsm_Carga.Click += tsm_Carga_Click;
            // 
            // tsm_Planeamiento
            // 
            tsm_Planeamiento.Image = (Image)resources.GetObject("tsm_Planeamiento.Image");
            tsm_Planeamiento.ImageScaling = ToolStripItemImageScaling.None;
            tsm_Planeamiento.Name = "tsm_Planeamiento";
            tsm_Planeamiento.Size = new Size(146, 36);
            tsm_Planeamiento.Text = "Planeamiento";
            tsm_Planeamiento.Visible = false;
            // 
            // tsm_Administracion
            // 
            tsm_Administracion.Image = (Image)resources.GetObject("tsm_Administracion.Image");
            tsm_Administracion.ImageScaling = ToolStripItemImageScaling.None;
            tsm_Administracion.Name = "tsm_Administracion";
            tsm_Administracion.Size = new Size(155, 36);
            tsm_Administracion.Text = "Administración";
            tsm_Administracion.Visible = false;
            // 
            // tsm_Finanzas
            // 
            tsm_Finanzas.Image = (Image)resources.GetObject("tsm_Finanzas.Image");
            tsm_Finanzas.ImageScaling = ToolStripItemImageScaling.None;
            tsm_Finanzas.Name = "tsm_Finanzas";
            tsm_Finanzas.Size = new Size(111, 36);
            tsm_Finanzas.Text = "Finanzas";
            tsm_Finanzas.Visible = false;
            // 
            // tsm_Contabilidad
            // 
            tsm_Contabilidad.Image = (Image)resources.GetObject("tsm_Contabilidad.Image");
            tsm_Contabilidad.ImageScaling = ToolStripItemImageScaling.None;
            tsm_Contabilidad.Name = "tsm_Contabilidad";
            tsm_Contabilidad.Size = new Size(141, 36);
            tsm_Contabilidad.Text = "Contabilidad";
            tsm_Contabilidad.Visible = false;
            // 
            // tsm_Mantenimiento
            // 
            tsm_Mantenimiento.Image = (Image)resources.GetObject("tsm_Mantenimiento.Image");
            tsm_Mantenimiento.ImageScaling = ToolStripItemImageScaling.None;
            tsm_Mantenimiento.Name = "tsm_Mantenimiento";
            tsm_Mantenimiento.Size = new Size(156, 36);
            tsm_Mantenimiento.Text = "Mantenimiento";
            tsm_Mantenimiento.Visible = false;
            // 
            // tsm_Neumaticos
            // 
            tsm_Neumaticos.Image = (Image)resources.GetObject("tsm_Neumaticos.Image");
            tsm_Neumaticos.ImageScaling = ToolStripItemImageScaling.None;
            tsm_Neumaticos.Name = "tsm_Neumaticos";
            tsm_Neumaticos.Size = new Size(134, 36);
            tsm_Neumaticos.Text = "Neumáticos";
            tsm_Neumaticos.Visible = false;
            // 
            // tsm_Logistica
            // 
            tsm_Logistica.Image = (Image)resources.GetObject("tsm_Logistica.Image");
            tsm_Logistica.ImageScaling = ToolStripItemImageScaling.None;
            tsm_Logistica.Name = "tsm_Logistica";
            tsm_Logistica.Size = new Size(114, 36);
            tsm_Logistica.Text = "Logística";
            tsm_Logistica.Visible = false;
            // 
            // tsm_Personal
            // 
            tsm_Personal.DropDownItems.AddRange(new ToolStripItem[] { tsm_Trabajador });
            tsm_Personal.Image = (Image)resources.GetObject("tsm_Personal.Image");
            tsm_Personal.ImageScaling = ToolStripItemImageScaling.None;
            tsm_Personal.Name = "tsm_Personal";
            tsm_Personal.Size = new Size(110, 36);
            tsm_Personal.Text = "Personal";
            tsm_Personal.Visible = false;
            // 
            // tsm_Trabajador
            // 
            tsm_Trabajador.Image = (Image)resources.GetObject("tsm_Trabajador.Image");
            tsm_Trabajador.ImageScaling = ToolStripItemImageScaling.None;
            tsm_Trabajador.Name = "tsm_Trabajador";
            tsm_Trabajador.Size = new Size(176, 38);
            tsm_Trabajador.Text = "Trabajador";
            tsm_Trabajador.Click += registrarTrabajadorToolStripMenuItem_Click;
            // 
            // tsm_Seguridad
            // 
            tsm_Seguridad.Image = (Image)resources.GetObject("tsm_Seguridad.Image");
            tsm_Seguridad.ImageScaling = ToolStripItemImageScaling.None;
            tsm_Seguridad.Name = "tsm_Seguridad";
            tsm_Seguridad.Size = new Size(123, 36);
            tsm_Seguridad.Text = "Seguridad";
            tsm_Seguridad.Visible = false;
            // 
            // tsm_Configuracion
            // 
            tsm_Configuracion.DropDownItems.AddRange(new ToolStripItem[] { tsm_PermisosPerfiles, tsm_CerrarSesion, tsm_Empresa });
            tsm_Configuracion.Image = (Image)resources.GetObject("tsm_Configuracion.Image");
            tsm_Configuracion.ImageScaling = ToolStripItemImageScaling.None;
            tsm_Configuracion.Name = "tsm_Configuracion";
            tsm_Configuracion.Size = new Size(148, 36);
            tsm_Configuracion.Text = "Configuración";
            tsm_Configuracion.Visible = false;
            // 
            // tsm_PermisosPerfiles
            // 
            tsm_PermisosPerfiles.Image = (Image)resources.GetObject("tsm_PermisosPerfiles.Image");
            tsm_PermisosPerfiles.ImageScaling = ToolStripItemImageScaling.None;
            tsm_PermisosPerfiles.Name = "tsm_PermisosPerfiles";
            tsm_PermisosPerfiles.Size = new Size(236, 38);
            tsm_PermisosPerfiles.Text = "Permisos y Perfiles";
            tsm_PermisosPerfiles.Visible = false;
            tsm_PermisosPerfiles.Click += permisosYPerfilesToolStripMenuItem_Click;
            // 
            // tsm_CerrarSesion
            // 
            tsm_CerrarSesion.Image = (Image)resources.GetObject("tsm_CerrarSesion.Image");
            tsm_CerrarSesion.ImageScaling = ToolStripItemImageScaling.None;
            tsm_CerrarSesion.Name = "tsm_CerrarSesion";
            tsm_CerrarSesion.Size = new Size(236, 38);
            tsm_CerrarSesion.Text = "Cerrar Sesión";
            tsm_CerrarSesion.Visible = false;
            tsm_CerrarSesion.Click += tsm_CerrarSesion_Click;
            // 
            // tsm_Empresa
            // 
            tsm_Empresa.Name = "tsm_Empresa";
            tsm_Empresa.Size = new Size(236, 38);
            tsm_Empresa.Text = "Empresa";
            tsm_Empresa.Click += tsm_Empresa_Click;
            // 
            // tsm_Reportes
            // 
            tsm_Reportes.Image = (Image)resources.GetObject("tsm_Reportes.Image");
            tsm_Reportes.ImageScaling = ToolStripItemImageScaling.None;
            tsm_Reportes.Name = "tsm_Reportes";
            tsm_Reportes.Size = new Size(114, 36);
            tsm_Reportes.Text = "Reportes";
            tsm_Reportes.Visible = false;
            // 
            // tsm_Ayuda
            // 
            tsm_Ayuda.Image = (Image)resources.GetObject("tsm_Ayuda.Image");
            tsm_Ayuda.ImageScaling = ToolStripItemImageScaling.None;
            tsm_Ayuda.Name = "tsm_Ayuda";
            tsm_Ayuda.Size = new Size(97, 36);
            tsm_Ayuda.Text = "Ayuda";
            tsm_Ayuda.Visible = false;
            // 
            // tsm_Grifo
            // 
            tsm_Grifo.Image = (Image)resources.GetObject("tsm_Grifo.Image");
            tsm_Grifo.Name = "tsm_Grifo";
            tsm_Grifo.Size = new Size(76, 36);
            tsm_Grifo.Text = "Grifo";
            tsm_Grifo.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_Desde);
            panel1.Controls.Add(lbl_Hora);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lbl_Usuario);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 661);
            panel1.Name = "panel1";
            panel1.Size = new Size(1541, 36);
            panel1.TabIndex = 11;
            // 
            // lbl_Desde
            // 
            lbl_Desde.AutoSize = true;
            lbl_Desde.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Desde.Location = new Point(523, 9);
            lbl_Desde.Name = "lbl_Desde";
            lbl_Desde.Size = new Size(51, 20);
            lbl_Desde.TabIndex = 4;
            lbl_Desde.Text = "label2";
            // 
            // lbl_Hora
            // 
            lbl_Hora.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Hora.AutoSize = true;
            lbl_Hora.Location = new Point(1483, 9);
            lbl_Hora.Name = "lbl_Hora";
            lbl_Hora.Size = new Size(50, 20);
            lbl_Hora.TabIndex = 3;
            lbl_Hora.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(465, 9);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "Desde";
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Usuario.Location = new Point(72, 9);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(51, 20);
            lbl_Usuario.TabIndex = 1;
            lbl_Usuario.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // tbc_Principal
            // 
            tbc_Principal.Controls.Add(tabPage1);
            tbc_Principal.Dock = DockStyle.Fill;
            tbc_Principal.Location = new Point(0, 42);
            tbc_Principal.Name = "tbc_Principal";
            tbc_Principal.SelectedIndex = 0;
            tbc_Principal.Size = new Size(1541, 619);
            tbc_Principal.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1533, 586);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Principal";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1527, 580);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // mdi_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1541, 697);
            Controls.Add(tbc_Principal);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 4, 5, 4);
            Name = "mdi_Principal";
            Text = "mdi_Principal";
            WindowState = FormWindowState.Maximized;
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tbc_Principal.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolTip toolTip;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsm_Configuracion;
        private ToolStripMenuItem tsm_CerrarSesion;
        private ToolStripMenuItem tsm_Personal;
        private ToolStripMenuItem tsm_Trabajador;
        private ToolStripMenuItem tsm_Operaciones;
        private ToolStripMenuItem tsm_Planeamiento;
        private ToolStripMenuItem tsm_Administracion;
        private ToolStripMenuItem tsm_Finanzas;
        private ToolStripMenuItem tsm_Contabilidad;
        private ToolStripMenuItem tsm_Mantenimiento;
        private ToolStripMenuItem tsm_Neumaticos;
        private ToolStripMenuItem tsm_Logistica;
        private ToolStripMenuItem tsm_Seguridad;
        private ToolStripMenuItem tsm_Reportes;
        private ToolStripMenuItem tsm_Ayuda;
        private ToolStripMenuItem tsm_Grifo;
        private Panel panel1;
        private Label label2;
        private Label lbl_Usuario;
        private Label label1;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private Label lbl_Hora;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem tsm_GestionClientes;
        private ToolStripMenuItem tsm_Clientes;
        private ToolStripMenuItem tsm_PermisosPerfiles;
        private TabPage tabPage1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem tsm_Carga;
        private Label lbl_Desde;
        private ToolStripMenuItem tsm_Empresa;
        public static TabControl tbc_Principal;
    }
}



