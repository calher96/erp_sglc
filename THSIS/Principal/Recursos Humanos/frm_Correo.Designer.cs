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
            panel1 = new Panel();
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            tabControl1 = new TabControl();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            dataGridView1 = new DataGridView();
            Principal = new DataGridViewCheckBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            button6 = new Button();
            button7 = new Button();
            panel1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(731, 259);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mantenimiento";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(731, 259);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lista";
            tabPage1.UseVisualStyleBackColor = true;
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
            // panel2
            // 
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(739, 37);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 0;
            button1.Text = "Listar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.Location = new Point(94, 0);
            button2.Name = "button2";
            button2.Size = new Size(94, 37);
            button2.TabIndex = 1;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Left;
            button3.Location = new Point(188, 0);
            button3.Name = "button3";
            button3.Size = new Size(94, 37);
            button3.TabIndex = 2;
            button3.Text = "Modificar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Left;
            button4.Location = new Point(282, 0);
            button4.Name = "button4";
            button4.Size = new Size(94, 37);
            button4.TabIndex = 3;
            button4.Text = "Grabar";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Left;
            button5.Location = new Point(376, 0);
            button5.Name = "button5";
            button5.Size = new Size(94, 37);
            button5.TabIndex = 4;
            button5.Text = "Cancelar";
            button5.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Principal, Correo });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(725, 253);
            dataGridView1.TabIndex = 0;
            // 
            // Principal
            // 
            Principal.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Principal.HeaderText = "Principal";
            Principal.MinimumWidth = 6;
            Principal.Name = "Principal";
            Principal.ReadOnly = true;
            Principal.Resizable = DataGridViewTriState.False;
            Principal.Width = 72;
            // 
            // Correo
            // 
            Correo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 83;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Left;
            button6.Location = new Point(470, 0);
            button6.Name = "button6";
            button6.Size = new Size(94, 37);
            button6.TabIndex = 5;
            button6.Text = "Quitar";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Left;
            button7.Location = new Point(564, 0);
            button7.Name = "button7";
            button7.Size = new Size(94, 37);
            button7.TabIndex = 6;
            button7.Text = "Regresar";
            button7.UseVisualStyleBackColor = true;
            // 
            // frm_Correo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 335);
            Controls.Add(panel1);
            Name = "frm_Correo";
            Text = "frm_Correo";
            panel1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private DataGridViewCheckBoxColumn Principal;
        private DataGridViewTextBoxColumn Correo;
        private TabPage tabPage2;
    }
}