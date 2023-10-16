namespace Principal.Operaciones
{
    partial class frm_GuiaRemisionTransportista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GuiaRemisionTransportista));
            tpc_RecepcionCarga = new TabControl();
            tpg_Lista = new TabPage();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btn_Actualizar = new Button();
            btn_Cerrar = new Button();
            button7 = new Button();
            btn_Nuevo = new Button();
            panel1 = new Panel();
            chk_Excluir_Asignada = new CheckBox();
            chk_Tercerizados = new CheckBox();
            panel3 = new Panel();
            label7 = new Label();
            label8 = new Label();
            cbo_Color_Aprobada = new ComboBox();
            cbo_Color_Cancelada = new ComboBox();
            label5 = new Label();
            cbo_Color_Actualizado = new ComboBox();
            chk_Asignada = new CheckBox();
            label4 = new Label();
            label6 = new Label();
            cbo_Color_Asignada = new ComboBox();
            cbo_Color_Parcial = new ComboBox();
            cbo_Color_Generada = new ComboBox();
            label3 = new Label();
            cbo_UsuarioFilter = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            tpg_Mantenimiento = new TabPage();
            panel4 = new Panel();
            btn_Cancelar = new Button();
            btn_Guardar = new Button();
            tpc_RecepcionCarga.SuspendLayout();
            tpg_Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tpg_Mantenimiento.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tpc_RecepcionCarga
            // 
            tpc_RecepcionCarga.Controls.Add(tpg_Lista);
            tpc_RecepcionCarga.Controls.Add(tpg_Mantenimiento);
            tpc_RecepcionCarga.Dock = DockStyle.Fill;
            tpc_RecepcionCarga.Location = new Point(0, 0);
            tpc_RecepcionCarga.Name = "tpc_RecepcionCarga";
            tpc_RecepcionCarga.SelectedIndex = 0;
            tpc_RecepcionCarga.Size = new Size(1550, 629);
            tpc_RecepcionCarga.TabIndex = 1;
            // 
            // tpg_Lista
            // 
            tpg_Lista.Controls.Add(dataGridView1);
            tpg_Lista.Controls.Add(panel2);
            tpg_Lista.Controls.Add(panel1);
            tpg_Lista.Location = new Point(4, 29);
            tpg_Lista.Name = "tpg_Lista";
            tpg_Lista.Padding = new Padding(3);
            tpg_Lista.Size = new Size(1542, 596);
            tpg_Lista.TabIndex = 0;
            tpg_Lista.Text = "Lista";
            tpg_Lista.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1536, 433);
            dataGridView1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btn_Actualizar);
            panel2.Controls.Add(btn_Cerrar);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(btn_Nuevo);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(1536, 32);
            panel2.TabIndex = 2;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Left;
            button3.FlatAppearance.MouseDownBackColor = Color.Gray;
            button3.FlatAppearance.MouseOverBackColor = Color.Silver;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(566, 0);
            button3.Name = "button3";
            button3.Size = new Size(84, 30);
            button3.TabIndex = 9;
            button3.Text = "Anular";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.FlatAppearance.MouseDownBackColor = Color.Gray;
            button2.FlatAppearance.MouseOverBackColor = Color.Silver;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(467, 0);
            button2.Name = "button2";
            button2.Size = new Size(99, 30);
            button2.TabIndex = 8;
            button2.Text = "Eliminar";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.MouseDownBackColor = Color.Gray;
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(383, 0);
            button1.Name = "button1";
            button1.Size = new Size(84, 30);
            button1.TabIndex = 7;
            button1.Text = "Enviar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_Actualizar
            // 
            btn_Actualizar.Dock = DockStyle.Left;
            btn_Actualizar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_Actualizar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_Actualizar.Image = (Image)resources.GetObject("btn_Actualizar.Image");
            btn_Actualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Actualizar.Location = new Point(278, 0);
            btn_Actualizar.Name = "btn_Actualizar";
            btn_Actualizar.Size = new Size(105, 30);
            btn_Actualizar.TabIndex = 3;
            btn_Actualizar.Text = "Actualizar";
            btn_Actualizar.TextAlign = ContentAlignment.MiddleRight;
            btn_Actualizar.UseVisualStyleBackColor = true;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Dock = DockStyle.Left;
            btn_Cerrar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_Cerrar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Cerrar.Location = new Point(189, 0);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(89, 30);
            btn_Cerrar.TabIndex = 2;
            btn_Cerrar.Text = "Cerrar";
            btn_Cerrar.TextAlign = ContentAlignment.MiddleRight;
            btn_Cerrar.UseVisualStyleBackColor = true;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Left;
            button7.FlatAppearance.MouseDownBackColor = Color.Gray;
            button7.FlatAppearance.MouseOverBackColor = Color.Silver;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(88, 0);
            button7.Name = "button7";
            button7.Size = new Size(101, 30);
            button7.TabIndex = 1;
            button7.Text = "Exportar";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseVisualStyleBackColor = true;
            // 
            // btn_Nuevo
            // 
            btn_Nuevo.Dock = DockStyle.Left;
            btn_Nuevo.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_Nuevo.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_Nuevo.Image = (Image)resources.GetObject("btn_Nuevo.Image");
            btn_Nuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Nuevo.Location = new Point(0, 0);
            btn_Nuevo.Name = "btn_Nuevo";
            btn_Nuevo.Size = new Size(88, 30);
            btn_Nuevo.TabIndex = 0;
            btn_Nuevo.Text = "Nuevo";
            btn_Nuevo.TextAlign = ContentAlignment.MiddleRight;
            btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(chk_Excluir_Asignada);
            panel1.Controls.Add(chk_Tercerizados);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cbo_UsuarioFilter);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1536, 125);
            panel1.TabIndex = 0;
            // 
            // chk_Excluir_Asignada
            // 
            chk_Excluir_Asignada.AutoSize = true;
            chk_Excluir_Asignada.Location = new Point(868, 63);
            chk_Excluir_Asignada.Name = "chk_Excluir_Asignada";
            chk_Excluir_Asignada.Size = new Size(140, 24);
            chk_Excluir_Asignada.TabIndex = 10;
            chk_Excluir_Asignada.Text = "Excluir Asignada";
            chk_Excluir_Asignada.UseVisualStyleBackColor = true;
            // 
            // chk_Tercerizados
            // 
            chk_Tercerizados.AutoSize = true;
            chk_Tercerizados.Location = new Point(868, 31);
            chk_Tercerizados.Name = "chk_Tercerizados";
            chk_Tercerizados.Size = new Size(114, 24);
            chk_Tercerizados.TabIndex = 9;
            chk_Tercerizados.Text = "Tercerizados";
            chk_Tercerizados.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(cbo_Color_Aprobada);
            panel3.Controls.Add(cbo_Color_Cancelada);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(cbo_Color_Actualizado);
            panel3.Controls.Add(chk_Asignada);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(cbo_Color_Asignada);
            panel3.Controls.Add(cbo_Color_Parcial);
            panel3.Controls.Add(cbo_Color_Generada);
            panel3.Location = new Point(354, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(499, 110);
            panel3.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(336, 56);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 21;
            label7.Text = "Aprobada:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(334, 21);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 20;
            label8.Text = "Cancelada:";
            // 
            // cbo_Color_Aprobada
            // 
            cbo_Color_Aprobada.FormattingEnabled = true;
            cbo_Color_Aprobada.Location = new Point(416, 52);
            cbo_Color_Aprobada.Name = "cbo_Color_Aprobada";
            cbo_Color_Aprobada.Size = new Size(68, 28);
            cbo_Color_Aprobada.TabIndex = 19;
            // 
            // cbo_Color_Cancelada
            // 
            cbo_Color_Cancelada.FormattingEnabled = true;
            cbo_Color_Cancelada.Location = new Point(416, 18);
            cbo_Color_Cancelada.Name = "cbo_Color_Cancelada";
            cbo_Color_Cancelada.Size = new Size(68, 28);
            cbo_Color_Cancelada.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(168, 57);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 17;
            label5.Text = "Actualizado:";
            // 
            // cbo_Color_Actualizado
            // 
            cbo_Color_Actualizado.FormattingEnabled = true;
            cbo_Color_Actualizado.Location = new Point(262, 53);
            cbo_Color_Actualizado.Name = "cbo_Color_Actualizado";
            cbo_Color_Actualizado.Size = new Size(68, 28);
            cbo_Color_Actualizado.TabIndex = 16;
            // 
            // chk_Asignada
            // 
            chk_Asignada.AutoSize = true;
            chk_Asignada.Location = new Point(164, 20);
            chk_Asignada.Name = "chk_Asignada";
            chk_Asignada.Size = new Size(96, 24);
            chk_Asignada.TabIndex = 15;
            chk_Asignada.Text = "Asignada:";
            chk_Asignada.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 56);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 14;
            label4.Text = "Parcial:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 21);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 13;
            label6.Text = "Generada:";
            // 
            // cbo_Color_Asignada
            // 
            cbo_Color_Asignada.FormattingEnabled = true;
            cbo_Color_Asignada.Location = new Point(262, 18);
            cbo_Color_Asignada.Name = "cbo_Color_Asignada";
            cbo_Color_Asignada.Size = new Size(68, 28);
            cbo_Color_Asignada.TabIndex = 12;
            // 
            // cbo_Color_Parcial
            // 
            cbo_Color_Parcial.FormattingEnabled = true;
            cbo_Color_Parcial.Location = new Point(90, 52);
            cbo_Color_Parcial.Name = "cbo_Color_Parcial";
            cbo_Color_Parcial.Size = new Size(67, 28);
            cbo_Color_Parcial.TabIndex = 11;
            // 
            // cbo_Color_Generada
            // 
            cbo_Color_Generada.FormattingEnabled = true;
            cbo_Color_Generada.Location = new Point(90, 18);
            cbo_Color_Generada.Name = "cbo_Color_Generada";
            cbo_Color_Generada.Size = new Size(68, 28);
            cbo_Color_Generada.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(196, 9);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 7;
            label3.Text = "Usuarios:";
            // 
            // cbo_UsuarioFilter
            // 
            cbo_UsuarioFilter.FormattingEnabled = true;
            cbo_UsuarioFilter.Location = new Point(196, 32);
            cbo_UsuarioFilter.Name = "cbo_UsuarioFilter";
            cbo_UsuarioFilter.Size = new Size(151, 28);
            cbo_UsuarioFilter.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 70);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Hasta:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 35);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 4;
            label1.Text = "Desde:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(63, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(127, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(63, 65);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(127, 27);
            dateTimePicker2.TabIndex = 0;
            // 
            // tpg_Mantenimiento
            // 
            tpg_Mantenimiento.Controls.Add(panel4);
            tpg_Mantenimiento.Location = new Point(4, 29);
            tpg_Mantenimiento.Name = "tpg_Mantenimiento";
            tpg_Mantenimiento.Padding = new Padding(3);
            tpg_Mantenimiento.Size = new Size(1542, 596);
            tpg_Mantenimiento.TabIndex = 1;
            tpg_Mantenimiento.Text = "Mantenimiento";
            tpg_Mantenimiento.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(btn_Cancelar);
            panel4.Controls.Add(btn_Guardar);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1536, 32);
            panel4.TabIndex = 3;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.Dock = DockStyle.Left;
            btn_Cancelar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_Cancelar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_Cancelar.Image = (Image)resources.GetObject("btn_Cancelar.Image");
            btn_Cancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Cancelar.Location = new Point(88, 0);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(89, 30);
            btn_Cancelar.TabIndex = 2;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.TextAlign = ContentAlignment.MiddleRight;
            btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Guardar
            // 
            btn_Guardar.Dock = DockStyle.Left;
            btn_Guardar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_Guardar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_Guardar.Image = (Image)resources.GetObject("btn_Guardar.Image");
            btn_Guardar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Guardar.Location = new Point(0, 0);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(88, 30);
            btn_Guardar.TabIndex = 0;
            btn_Guardar.Text = "Nuevo";
            btn_Guardar.TextAlign = ContentAlignment.MiddleRight;
            btn_Guardar.UseVisualStyleBackColor = true;
            // 
            // frm_GuiaRemisionTransportista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1550, 629);
            Controls.Add(tpc_RecepcionCarga);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_GuiaRemisionTransportista";
            Text = "frm_GuiaRemisionTransportista";
            tpc_RecepcionCarga.ResumeLayout(false);
            tpg_Lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tpg_Mantenimiento.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tpc_RecepcionCarga;
        private TabPage tpg_Lista;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button btn_Actualizar;
        private Button btn_Cerrar;
        private Button button7;
        private Button btn_Nuevo;
        private Panel panel1;
        private CheckBox chk_Excluir_Asignada;
        private CheckBox chk_Tercerizados;
        private Panel panel3;
        private Label label7;
        private Label label8;
        private ComboBox cbo_Color_Aprobada;
        private ComboBox cbo_Color_Cancelada;
        private Label label5;
        private ComboBox cbo_Color_Actualizado;
        private CheckBox chk_Asignada;
        private Label label4;
        private Label label6;
        private ComboBox cbo_Color_Asignada;
        private ComboBox cbo_Color_Parcial;
        private ComboBox cbo_Color_Generada;
        private Label label3;
        private ComboBox cbo_UsuarioFilter;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private TabPage tpg_Mantenimiento;
        private Panel panel4;
        private Button btn_Cancelar;
        private Button btn_Guardar;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}