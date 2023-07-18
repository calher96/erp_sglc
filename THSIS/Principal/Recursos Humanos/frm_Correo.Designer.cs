namespace Principal.Recursos_Humanos
{
    partial class frm_Correo
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Correo));
            panel1 = new Panel();
            panel2 = new Panel();
            btn_Aceptar = new Button();
            btn_Quitar = new Button();
            btn_Cancelar = new Button();
            btn_Grabar = new Button();
            btn_Modificar = new Button();
            btn_Agregar = new Button();
            btn_Listar = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgv_Correo = new DataGridView();
            corr_Principal = new DataGridViewCheckBoxColumn();
            corr_Correo = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            txt_Correo = new TextBox();
            label1 = new Label();
            entCorreoBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Correo).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)entCorreoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(tabControl1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(739, 335);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_Aceptar);
            panel2.Controls.Add(btn_Quitar);
            panel2.Controls.Add(btn_Cancelar);
            panel2.Controls.Add(btn_Grabar);
            panel2.Controls.Add(btn_Modificar);
            panel2.Controls.Add(btn_Agregar);
            panel2.Controls.Add(btn_Listar);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(739, 37);
            panel2.TabIndex = 1;
            // 
            // btn_Aceptar
            // 
            btn_Aceptar.Dock = DockStyle.Left;
            btn_Aceptar.Image = (Image)resources.GetObject("btn_Aceptar.Image");
            btn_Aceptar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Aceptar.Location = new Point(528, 0);
            btn_Aceptar.Name = "btn_Aceptar";
            btn_Aceptar.Size = new Size(96, 37);
            btn_Aceptar.TabIndex = 6;
            btn_Aceptar.Text = "Aceptar";
            btn_Aceptar.TextAlign = ContentAlignment.MiddleRight;
            btn_Aceptar.UseVisualStyleBackColor = true;
            btn_Aceptar.Click += button7_Click;
            // 
            // btn_Quitar
            // 
            btn_Quitar.Dock = DockStyle.Left;
            btn_Quitar.Enabled = false;
            btn_Quitar.Image = (Image)resources.GetObject("btn_Quitar.Image");
            btn_Quitar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Quitar.Location = new Point(446, 0);
            btn_Quitar.Name = "btn_Quitar";
            btn_Quitar.Size = new Size(82, 37);
            btn_Quitar.TabIndex = 5;
            btn_Quitar.Text = "Quitar";
            btn_Quitar.TextAlign = ContentAlignment.MiddleRight;
            btn_Quitar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Dock = DockStyle.Left;
            btn_Cancelar.Image = (Image)resources.GetObject("btn_Cancelar.Image");
            btn_Cancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Cancelar.Location = new Point(351, 0);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(95, 37);
            btn_Cancelar.TabIndex = 4;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.TextAlign = ContentAlignment.MiddleRight;
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += button5_Click;
            // 
            // btn_Grabar
            // 
            btn_Grabar.Dock = DockStyle.Left;
            btn_Grabar.Enabled = false;
            btn_Grabar.Image = (Image)resources.GetObject("btn_Grabar.Image");
            btn_Grabar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Grabar.Location = new Point(269, 0);
            btn_Grabar.Name = "btn_Grabar";
            btn_Grabar.Size = new Size(82, 37);
            btn_Grabar.TabIndex = 3;
            btn_Grabar.Text = "Grabar";
            btn_Grabar.TextAlign = ContentAlignment.MiddleRight;
            btn_Grabar.UseVisualStyleBackColor = true;
            btn_Grabar.Click += button4_Click;
            // 
            // btn_Modificar
            // 
            btn_Modificar.Dock = DockStyle.Left;
            btn_Modificar.Enabled = false;
            btn_Modificar.Image = (Image)resources.GetObject("btn_Modificar.Image");
            btn_Modificar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Modificar.Location = new Point(171, 0);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(98, 37);
            btn_Modificar.TabIndex = 2;
            btn_Modificar.Text = "Modificar";
            btn_Modificar.TextAlign = ContentAlignment.MiddleRight;
            btn_Modificar.UseVisualStyleBackColor = true;
            btn_Modificar.Click += btn_Modificar_Click;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Dock = DockStyle.Left;
            btn_Agregar.Image = (Image)resources.GetObject("btn_Agregar.Image");
            btn_Agregar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Agregar.Location = new Point(82, 0);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(89, 37);
            btn_Agregar.TabIndex = 1;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.TextAlign = ContentAlignment.MiddleRight;
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += button2_Click;
            // 
            // btn_Listar
            // 
            btn_Listar.Dock = DockStyle.Left;
            btn_Listar.Image = (Image)resources.GetObject("btn_Listar.Image");
            btn_Listar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Listar.Location = new Point(0, 0);
            btn_Listar.Name = "btn_Listar";
            btn_Listar.Size = new Size(82, 37);
            btn_Listar.TabIndex = 0;
            btn_Listar.Text = "Listar";
            btn_Listar.TextAlign = ContentAlignment.MiddleRight;
            btn_Listar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 43);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(739, 292);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgv_Correo);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(731, 259);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lista";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgv_Correo
            // 
            dgv_Correo.AllowUserToAddRows = false;
            dgv_Correo.AllowUserToDeleteRows = false;
            dgv_Correo.AllowUserToResizeColumns = false;
            dgv_Correo.AllowUserToResizeRows = false;
            dgv_Correo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_Correo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Correo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Correo.Columns.AddRange(new DataGridViewColumn[] { corr_Principal, corr_Correo });
            dgv_Correo.Dock = DockStyle.Fill;
            dgv_Correo.Location = new Point(3, 3);
            dgv_Correo.Margin = new Padding(3, 4, 3, 4);
            dgv_Correo.Name = "dgv_Correo";
            dgv_Correo.RowHeadersWidth = 51;
            dgv_Correo.RowTemplate.Height = 25;
            dgv_Correo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Correo.Size = new Size(725, 253);
            dgv_Correo.TabIndex = 0;
            dgv_Correo.CellMouseClick += dgv_Correo_CellMouseClick;
            // 
            // corr_Principal
            // 
            corr_Principal.HeaderText = "Principal";
            corr_Principal.MinimumWidth = 6;
            corr_Principal.Name = "corr_Principal";
            corr_Principal.Width = 72;
            // 
            // corr_Correo
            // 
            corr_Correo.HeaderText = "Correo";
            corr_Correo.MinimumWidth = 6;
            corr_Correo.Name = "corr_Correo";
            corr_Correo.ReadOnly = true;
            corr_Correo.Width = 83;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txt_Correo);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(731, 259);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mantenimiento";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_Correo
            // 
            txt_Correo.Location = new Point(75, 27);
            txt_Correo.Name = "txt_Correo";
            txt_Correo.Size = new Size(578, 27);
            txt_Correo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Correo";
            // 
            // entCorreoBindingSource
            // 
            entCorreoBindingSource.DataSource = typeof(CEN.Entidad.ent_Correo);
            // 
            // frm_Correo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 335);
            Controls.Add(panel1);
            Name = "frm_Correo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frm_Correo";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Correo).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)entCorreoBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btn_Aceptar;
        private Button btn_Quitar;
        private Button btn_Cancelar;
        private Button btn_Grabar;
        private Button btn_Modificar;
        private Button btn_Agregar;
        private Button btn_Listar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txt_Correo;
        private Label label1;
        private BindingSource entCorreoBindingSource;
        private DataGridView dgv_Correo;
        private DataGridViewCheckBoxColumn corr_Principal;
        private DataGridViewTextBoxColumn corr_Correo;
    }
}