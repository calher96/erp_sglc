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
            dataGridView1 = new DataGridView();
            panel4 = new Panel();
            groupBox1 = new GroupBox();
            cbo_Trabajador = new ComboBox();
            label6 = new Label();
            textBox1 = new TextBox();
            cbo_Perfil = new ComboBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            button1 = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel4.SuspendLayout();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
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
            tpg_Mantenimiento.Controls.Add(dataGridView1);
            tpg_Mantenimiento.Controls.Add(panel4);
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 560);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(642, 243);
            dataGridView1.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox1);
            panel4.Controls.Add(panel3);
            panel4.Location = new Point(0, 301);
            panel4.Name = "panel4";
            panel4.Size = new Size(645, 253);
            panel4.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbo_Trabajador);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(cbo_Perfil);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(645, 214);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Usuarios";
            // 
            // cbo_Trabajador
            // 
            cbo_Trabajador.FormattingEnabled = true;
            cbo_Trabajador.Location = new Point(115, 48);
            cbo_Trabajador.Name = "cbo_Trabajador";
            cbo_Trabajador.Size = new Size(357, 28);
            cbo_Trabajador.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 177);
            label6.Name = "label6";
            label6.Size = new Size(45, 20);
            label6.TabIndex = 7;
            label6.Text = "Perfil:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(115, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 27);
            textBox1.TabIndex = 1;
            // 
            // cbo_Perfil
            // 
            cbo_Perfil.FormattingEnabled = true;
            cbo_Perfil.Location = new Point(115, 173);
            cbo_Perfil.Name = "cbo_Perfil";
            cbo_Perfil.Size = new Size(303, 28);
            cbo_Perfil.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(116, 131);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(231, 27);
            textBox2.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 134);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 5;
            label5.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 51);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 3;
            label3.Text = "Trabajador:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 93);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 4;
            label4.Text = "Usuario:";
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 214);
            panel3.Name = "panel3";
            panel3.Size = new Size(645, 39);
            panel3.TabIndex = 4;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.Enabled = false;
            button1.Image = Properties.Resources.diskette;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(106, 39);
            button1.TabIndex = 2;
            button1.Text = "Guardar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
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
            txt_Nombre.CharacterCasing = CharacterCasing.Upper;
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
            dgb_Perfiles.AllowUserToAddRows = false;
            dgb_Perfiles.AllowUserToDeleteRows = false;
            dgb_Perfiles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dgb_Perfiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgb_Perfiles.GridColor = SystemColors.ButtonHighlight;
            dgb_Perfiles.Location = new Point(3, 110);
            dgb_Perfiles.Name = "dgb_Perfiles";
            dgb_Perfiles.RowHeadersWidth = 51;
            dgb_Perfiles.RowTemplate.Height = 29;
            dgb_Perfiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgb_Perfiles.Size = new Size(642, 185);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
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
        private Panel panel4;
        private Panel panel3;
        private Button button1;
        private Label label6;
        private ComboBox cbo_Perfil;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox cbo_Trabajador;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
    }
}