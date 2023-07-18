namespace Principal.Seguridad
{
    partial class frm_Permisos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Permisos));
            tpg_Lista = new TabControl();
            tpg_Mantenimiento = new TabPage();
            panel2 = new Panel();
            cbo_Estado = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txt_Nombre = new TextBox();
            panel1 = new Panel();
            btn_Cerrar = new Button();
            btn_Editar = new Button();
            btn_Eliminar = new Button();
            btn_Guardar = new Button();
            btn_Nuevo = new Button();
            dgb_Perfiles = new DataGridView();
            trv_Permisos = new TreeView();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tpg_Lista.SuspendLayout();
            tpg_Mantenimiento.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgb_Perfiles).BeginInit();
            SuspendLayout();
            // 
            // tpg_Lista
            // 
            tpg_Lista.Controls.Add(tpg_Mantenimiento);
            tpg_Lista.Controls.Add(tabPage1);
            tpg_Lista.Controls.Add(tabPage2);
            tpg_Lista.Dock = DockStyle.Fill;
            tpg_Lista.Location = new Point(0, 0);
            tpg_Lista.Name = "tpg_Lista";
            tpg_Lista.SelectedIndex = 0;
            tpg_Lista.Size = new Size(1565, 839);
            tpg_Lista.TabIndex = 1;
            // 
            // tpg_Mantenimiento
            // 
            tpg_Mantenimiento.Controls.Add(panel2);
            tpg_Mantenimiento.Controls.Add(panel1);
            tpg_Mantenimiento.Controls.Add(dgb_Perfiles);
            tpg_Mantenimiento.Controls.Add(trv_Permisos);
            tpg_Mantenimiento.Location = new Point(4, 29);
            tpg_Mantenimiento.Name = "tpg_Mantenimiento";
            tpg_Mantenimiento.Padding = new Padding(3);
            tpg_Mantenimiento.Size = new Size(1557, 806);
            tpg_Mantenimiento.TabIndex = 1;
            tpg_Mantenimiento.Text = "Permisos";
            tpg_Mantenimiento.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(cbo_Estado);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txt_Nombre);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 47);
            panel2.Name = "panel2";
            panel2.Size = new Size(642, 66);
            panel2.TabIndex = 3;
            // 
            // cbo_Estado
            // 
            cbo_Estado.FormattingEnabled = true;
            cbo_Estado.Location = new Point(388, 15);
            cbo_Estado.Name = "cbo_Estado";
            cbo_Estado.Size = new Size(248, 28);
            cbo_Estado.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(325, 19);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 3;
            label2.Text = "Estado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 18);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Location = new Point(75, 15);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(239, 27);
            txt_Nombre.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Cerrar);
            panel1.Controls.Add(btn_Editar);
            panel1.Controls.Add(btn_Eliminar);
            panel1.Controls.Add(btn_Guardar);
            panel1.Controls.Add(btn_Nuevo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(642, 44);
            panel1.TabIndex = 2;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Dock = DockStyle.Left;
            btn_Cerrar.Image = Properties.Resources.cerrar2;
            btn_Cerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Cerrar.Location = new Point(400, 0);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(94, 44);
            btn_Cerrar.TabIndex = 4;
            btn_Cerrar.Text = "Cerrar";
            btn_Cerrar.TextAlign = ContentAlignment.MiddleRight;
            btn_Cerrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Cerrar.UseVisualStyleBackColor = true;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // btn_Editar
            // 
            btn_Editar.Dock = DockStyle.Left;
            btn_Editar.Enabled = false;
            btn_Editar.Image = (Image)resources.GetObject("btn_Editar.Image");
            btn_Editar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Editar.Location = new Point(306, 0);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(94, 44);
            btn_Editar.TabIndex = 3;
            btn_Editar.Text = "Editar";
            btn_Editar.TextAlign = ContentAlignment.MiddleRight;
            btn_Editar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Editar.UseVisualStyleBackColor = true;
            btn_Editar.Click += btn_Editar_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Dock = DockStyle.Left;
            btn_Eliminar.Enabled = false;
            btn_Eliminar.Image = (Image)resources.GetObject("btn_Eliminar.Image");
            btn_Eliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Eliminar.Location = new Point(200, 0);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(106, 44);
            btn_Eliminar.TabIndex = 2;
            btn_Eliminar.Text = "Eliminar";
            btn_Eliminar.TextAlign = ContentAlignment.MiddleRight;
            btn_Eliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Dock = DockStyle.Left;
            btn_Guardar.Enabled = false;
            btn_Guardar.Image = Properties.Resources.diskette;
            btn_Guardar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Guardar.Location = new Point(94, 0);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(106, 44);
            btn_Guardar.TabIndex = 1;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.TextAlign = ContentAlignment.MiddleRight;
            btn_Guardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // btn_Nuevo
            // 
            btn_Nuevo.Dock = DockStyle.Left;
            btn_Nuevo.Image = Properties.Resources.new_file;
            btn_Nuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Nuevo.Location = new Point(0, 0);
            btn_Nuevo.Name = "btn_Nuevo";
            btn_Nuevo.Size = new Size(94, 44);
            btn_Nuevo.TabIndex = 0;
            btn_Nuevo.Text = "Nuevo";
            btn_Nuevo.TextAlign = ContentAlignment.MiddleRight;
            btn_Nuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Nuevo.UseVisualStyleBackColor = true;
            btn_Nuevo.Click += btn_Nuevo_Click;
            // 
            // dgb_Perfiles
            // 
            dgb_Perfiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgb_Perfiles.Dock = DockStyle.Bottom;
            dgb_Perfiles.Location = new Point(3, 110);
            dgb_Perfiles.Name = "dgb_Perfiles";
            dgb_Perfiles.RowHeadersWidth = 51;
            dgb_Perfiles.RowTemplate.Height = 29;
            dgb_Perfiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgb_Perfiles.Size = new Size(642, 693);
            dgb_Perfiles.TabIndex = 1;
            dgb_Perfiles.DoubleClick += dgb_Perfiles_DoubleClick;
            dgb_Perfiles.MouseClick += dgb_Perfiles_MouseClick;
            // 
            // trv_Permisos
            // 
            trv_Permisos.Dock = DockStyle.Right;
            trv_Permisos.Location = new Point(645, 3);
            trv_Permisos.Name = "trv_Permisos";
            trv_Permisos.Size = new Size(909, 800);
            trv_Permisos.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1557, 806);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Perfil";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1557, 806);
            tabPage2.TabIndex = 3;
            tabPage2.Text = "Usuarios";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // frm_Permisos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1565, 839);
            Controls.Add(tpg_Lista);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Permisos";
            Text = "frm_Permisos";
            tpg_Lista.ResumeLayout(false);
            tpg_Mantenimiento.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgb_Perfiles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tpg_Lista;
        private TabPage tpg_Mantenimiento;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TreeView trv_Permisos;
        private DataGridView dgb_Perfiles;
        private Panel panel1;
        private Button btn_Nuevo;
        private Panel panel2;
        private Label label1;
        private TextBox txt_Nombre;
        private Button btn_Guardar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox cbo_Estado;
        private Label label2;
        private Button btn_Editar;
        private Button btn_Eliminar;
        private Button btn_Cerrar;
    }
}