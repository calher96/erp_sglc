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
            toolTip = new ToolTip(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            operacionesToolStripMenuItem = new ToolStripMenuItem();
            planeamientoToolStripMenuItem = new ToolStripMenuItem();
            administraciónToolStripMenuItem = new ToolStripMenuItem();
            finanzasToolStripMenuItem = new ToolStripMenuItem();
            contabilidadToolStripMenuItem = new ToolStripMenuItem();
            mantenimientoToolStripMenuItem = new ToolStripMenuItem();
            neumáticosToolStripMenuItem = new ToolStripMenuItem();
            logísticaToolStripMenuItem = new ToolStripMenuItem();
            recursosHumanosToolStripMenuItem = new ToolStripMenuItem();
            registrarTrabajadorToolStripMenuItem = new ToolStripMenuItem();
            seguridadToolStripMenuItem = new ToolStripMenuItem();
            configuraciónToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            grifoToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            lbl_Hora = new Label();
            label2 = new Label();
            lbl_Usuario = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            tbc_Principal = new TabControl();
            gestiónDeClientesToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
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
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { operacionesToolStripMenuItem, planeamientoToolStripMenuItem, administraciónToolStripMenuItem, finanzasToolStripMenuItem, contabilidadToolStripMenuItem, mantenimientoToolStripMenuItem, neumáticosToolStripMenuItem, logísticaToolStripMenuItem, recursosHumanosToolStripMenuItem, seguridadToolStripMenuItem, configuraciónToolStripMenuItem, reportesToolStripMenuItem, ayudaToolStripMenuItem, grifoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1466, 30);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // operacionesToolStripMenuItem
            // 
            operacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestiónDeClientesToolStripMenuItem });
            operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            operacionesToolStripMenuItem.Size = new Size(106, 24);
            operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // planeamientoToolStripMenuItem
            // 
            planeamientoToolStripMenuItem.Name = "planeamientoToolStripMenuItem";
            planeamientoToolStripMenuItem.Size = new Size(114, 24);
            planeamientoToolStripMenuItem.Text = "Planeamiento";
            // 
            // administraciónToolStripMenuItem
            // 
            administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            administraciónToolStripMenuItem.Size = new Size(123, 24);
            administraciónToolStripMenuItem.Text = "Administración";
            // 
            // finanzasToolStripMenuItem
            // 
            finanzasToolStripMenuItem.Name = "finanzasToolStripMenuItem";
            finanzasToolStripMenuItem.Size = new Size(79, 24);
            finanzasToolStripMenuItem.Text = "Finanzas";
            // 
            // contabilidadToolStripMenuItem
            // 
            contabilidadToolStripMenuItem.Name = "contabilidadToolStripMenuItem";
            contabilidadToolStripMenuItem.Size = new Size(109, 24);
            contabilidadToolStripMenuItem.Text = "Contabilidad";
            // 
            // mantenimientoToolStripMenuItem
            // 
            mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            mantenimientoToolStripMenuItem.Size = new Size(124, 24);
            mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // neumáticosToolStripMenuItem
            // 
            neumáticosToolStripMenuItem.Name = "neumáticosToolStripMenuItem";
            neumáticosToolStripMenuItem.Size = new Size(102, 24);
            neumáticosToolStripMenuItem.Text = "Neumáticos";
            // 
            // logísticaToolStripMenuItem
            // 
            logísticaToolStripMenuItem.Name = "logísticaToolStripMenuItem";
            logísticaToolStripMenuItem.Size = new Size(82, 24);
            logísticaToolStripMenuItem.Text = "Logística";
            // 
            // recursosHumanosToolStripMenuItem
            // 
            recursosHumanosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarTrabajadorToolStripMenuItem });
            recursosHumanosToolStripMenuItem.Name = "recursosHumanosToolStripMenuItem";
            recursosHumanosToolStripMenuItem.Size = new Size(78, 24);
            recursosHumanosToolStripMenuItem.Text = "Personal";
            // 
            // registrarTrabajadorToolStripMenuItem
            // 
            registrarTrabajadorToolStripMenuItem.Image = Properties.Resources.trabajador;
            registrarTrabajadorToolStripMenuItem.Name = "registrarTrabajadorToolStripMenuItem";
            registrarTrabajadorToolStripMenuItem.Size = new Size(164, 26);
            registrarTrabajadorToolStripMenuItem.Text = "Trabajador";
            registrarTrabajadorToolStripMenuItem.Click += registrarTrabajadorToolStripMenuItem_Click;
            // 
            // seguridadToolStripMenuItem
            // 
            seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            seguridadToolStripMenuItem.Size = new Size(91, 24);
            seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // configuraciónToolStripMenuItem
            // 
            configuraciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesiónToolStripMenuItem });
            configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            configuraciónToolStripMenuItem.Size = new Size(116, 24);
            configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(179, 26);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(82, 24);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(65, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // grifoToolStripMenuItem
            // 
            grifoToolStripMenuItem.Name = "grifoToolStripMenuItem";
            grifoToolStripMenuItem.Size = new Size(56, 24);
            grifoToolStripMenuItem.Text = "Grifo";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_Hora);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lbl_Usuario);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 661);
            panel1.Name = "panel1";
            panel1.Size = new Size(1466, 36);
            panel1.TabIndex = 11;
            // 
            // lbl_Hora
            // 
            lbl_Hora.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_Hora.AutoSize = true;
            lbl_Hora.Location = new Point(1409, 9);
            lbl_Hora.Name = "lbl_Hora";
            lbl_Hora.Size = new Size(50, 20);
            lbl_Hora.TabIndex = 3;
            lbl_Hora.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 9);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 2;
            label2.Text = "Desde";
            // 
            // lbl_Usuario
            // 
            lbl_Usuario.AutoSize = true;
            lbl_Usuario.Location = new Point(72, 10);
            lbl_Usuario.Name = "lbl_Usuario";
            lbl_Usuario.Size = new Size(50, 20);
            lbl_Usuario.TabIndex = 1;
            lbl_Usuario.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
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
            tbc_Principal.Dock = DockStyle.Fill;
            tbc_Principal.Location = new Point(0, 30);
            tbc_Principal.Name = "tbc_Principal";
            tbc_Principal.SelectedIndex = 0;
            tbc_Principal.Size = new Size(1466, 631);
            tbc_Principal.TabIndex = 12;
            // 
            // gestiónDeClientesToolStripMenuItem
            // 
            gestiónDeClientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem });
            gestiónDeClientesToolStripMenuItem.Name = "gestiónDeClientesToolStripMenuItem";
            gestiónDeClientesToolStripMenuItem.Size = new Size(224, 26);
            gestiónDeClientesToolStripMenuItem.Text = "Gestión de Clientes";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(224, 26);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // mdi_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1466, 697);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem configuraciónToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private ToolStripMenuItem recursosHumanosToolStripMenuItem;
        private ToolStripMenuItem registrarTrabajadorToolStripMenuItem;
        private ToolStripMenuItem operacionesToolStripMenuItem;
        private ToolStripMenuItem planeamientoToolStripMenuItem;
        private ToolStripMenuItem administraciónToolStripMenuItem;
        private ToolStripMenuItem finanzasToolStripMenuItem;
        private ToolStripMenuItem contabilidadToolStripMenuItem;
        private ToolStripMenuItem mantenimientoToolStripMenuItem;
        private ToolStripMenuItem neumáticosToolStripMenuItem;
        private ToolStripMenuItem logísticaToolStripMenuItem;
        private ToolStripMenuItem seguridadToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem grifoToolStripMenuItem;
        private Panel panel1;
        private Label label2;
        private Label lbl_Usuario;
        private Label label1;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private Label lbl_Hora;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem gestiónDeClientesToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        public static TabControl tbc_Principal;
    }
}



