namespace Principal.Operaciones
{
    partial class frm_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cliente));
            tbc_Principal = new TabControl();
            tp_Lista = new TabPage();
            dgb_Lista = new DataGridView();
            panel2 = new Panel();
            btn_Cerrar = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            cbo_Color_Comisionista = new ComboBox();
            label3 = new Label();
            tp_Mantenimiento = new TabPage();
            panel3 = new Panel();
            btn_Guardar = new Button();
            btn_Cancelar = new Button();
            groupBox3 = new GroupBox();
            label13 = new Label();
            cbo_TipoPersona = new ComboBox();
            txt_Documento = new TextBox();
            label1 = new Label();
            cbo_TipoDocumento = new ComboBox();
            txt_Codigo = new TextBox();
            label8 = new Label();
            label2 = new Label();
            gpb_PersonaJuridica = new GroupBox();
            txt_DireccionFiscal = new TextBox();
            label12 = new Label();
            txt_Abreviatura = new TextBox();
            label9 = new Label();
            txt_RazonSocial = new TextBox();
            label4 = new Label();
            gpb_PersonaNatural = new GroupBox();
            chk_Comisionista = new CheckBox();
            txt_ApellidoMaterno = new TextBox();
            label5 = new Label();
            txt_Nombres = new TextBox();
            label6 = new Label();
            dtp_FechaNacimiento = new DateTimePicker();
            label10 = new Label();
            txt_ApellidoPaterno = new TextBox();
            label7 = new Label();
            rbt_Femenino = new RadioButton();
            label11 = new Label();
            rbt_Masculino = new RadioButton();
            tbc_Principal.SuspendLayout();
            tp_Lista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgb_Lista).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tp_Mantenimiento.SuspendLayout();
            panel3.SuspendLayout();
            groupBox3.SuspendLayout();
            gpb_PersonaJuridica.SuspendLayout();
            gpb_PersonaNatural.SuspendLayout();
            SuspendLayout();
            // 
            // tbc_Principal
            // 
            tbc_Principal.AllowDrop = true;
            tbc_Principal.Controls.Add(tp_Lista);
            tbc_Principal.Controls.Add(tp_Mantenimiento);
            tbc_Principal.Dock = DockStyle.Fill;
            tbc_Principal.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbc_Principal.Location = new Point(0, 0);
            tbc_Principal.Margin = new Padding(3, 4, 3, 4);
            tbc_Principal.Name = "tbc_Principal";
            tbc_Principal.SelectedIndex = 0;
            tbc_Principal.Size = new Size(1407, 581);
            tbc_Principal.TabIndex = 1;
            // 
            // tp_Lista
            // 
            tp_Lista.AllowDrop = true;
            tp_Lista.Controls.Add(dgb_Lista);
            tp_Lista.Controls.Add(panel2);
            tp_Lista.Controls.Add(panel1);
            tp_Lista.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tp_Lista.ImageIndex = 0;
            tp_Lista.Location = new Point(4, 29);
            tp_Lista.Margin = new Padding(3, 4, 3, 4);
            tp_Lista.Name = "tp_Lista";
            tp_Lista.Padding = new Padding(3, 4, 3, 4);
            tp_Lista.Size = new Size(1399, 548);
            tp_Lista.TabIndex = 0;
            tp_Lista.Text = "Lista";
            tp_Lista.UseVisualStyleBackColor = true;
            // 
            // dgb_Lista
            // 
            dgb_Lista.AllowUserToAddRows = false;
            dgb_Lista.AllowUserToDeleteRows = false;
            dgb_Lista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgb_Lista.Dock = DockStyle.Fill;
            dgb_Lista.Location = new Point(3, 106);
            dgb_Lista.Name = "dgb_Lista";
            dgb_Lista.RowHeadersWidth = 51;
            dgb_Lista.RowTemplate.Height = 29;
            dgb_Lista.Size = new Size(1393, 438);
            dgb_Lista.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkGray;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(btn_Cerrar);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Top;
            panel2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(3, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(1393, 32);
            panel2.TabIndex = 1;
            // 
            // btn_Cerrar
            // 
            btn_Cerrar.Dock = DockStyle.Left;
            btn_Cerrar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_Cerrar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_Cerrar.Image = (Image)resources.GetObject("btn_Cerrar.Image");
            btn_Cerrar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Cerrar.Location = new Point(294, 0);
            btn_Cerrar.Name = "btn_Cerrar";
            btn_Cerrar.Size = new Size(89, 28);
            btn_Cerrar.TabIndex = 7;
            btn_Cerrar.Text = "Cerrar";
            btn_Cerrar.TextAlign = ContentAlignment.MiddleRight;
            btn_Cerrar.UseVisualStyleBackColor = true;
            btn_Cerrar.Click += btn_Cerrar_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Left;
            button3.FlatAppearance.MouseDownBackColor = Color.Gray;
            button3.FlatAppearance.MouseOverBackColor = Color.Silver;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(189, 0);
            button3.Name = "button3";
            button3.Size = new Size(105, 28);
            button3.TabIndex = 6;
            button3.Text = "Actualizar";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.FlatAppearance.MouseDownBackColor = Color.Gray;
            button2.FlatAppearance.MouseOverBackColor = Color.Silver;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(88, 0);
            button2.Name = "button2";
            button2.Size = new Size(101, 28);
            button2.TabIndex = 5;
            button2.Text = "Exportar";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.MouseDownBackColor = Color.Gray;
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(88, 28);
            button1.TabIndex = 4;
            button1.Text = "Nuevo";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(cbo_Color_Comisionista);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1393, 70);
            panel1.TabIndex = 0;
            panel1.Tag = "";
            // 
            // cbo_Color_Comisionista
            // 
            cbo_Color_Comisionista.FormattingEnabled = true;
            cbo_Color_Comisionista.Location = new Point(128, 20);
            cbo_Color_Comisionista.Name = "cbo_Color_Comisionista";
            cbo_Color_Comisionista.Size = new Size(68, 28);
            cbo_Color_Comisionista.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 23);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 7;
            label3.Text = "Comisionista";
            // 
            // tp_Mantenimiento
            // 
            tp_Mantenimiento.Controls.Add(panel3);
            tp_Mantenimiento.ImageIndex = 1;
            tp_Mantenimiento.Location = new Point(4, 29);
            tp_Mantenimiento.Margin = new Padding(3, 4, 3, 4);
            tp_Mantenimiento.Name = "tp_Mantenimiento";
            tp_Mantenimiento.Padding = new Padding(3, 4, 3, 4);
            tp_Mantenimiento.Size = new Size(1399, 548);
            tp_Mantenimiento.TabIndex = 1;
            tp_Mantenimiento.Text = "Mantenimiento";
            tp_Mantenimiento.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightBlue;
            panel3.Controls.Add(btn_Guardar);
            panel3.Controls.Add(btn_Cancelar);
            panel3.Controls.Add(groupBox3);
            panel3.Controls.Add(gpb_PersonaJuridica);
            panel3.Controls.Add(gpb_PersonaNatural);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1393, 540);
            panel3.TabIndex = 0;
            // 
            // btn_Guardar
            // 
            btn_Guardar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_Guardar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_Guardar.Image = Properties.Resources.diskette;
            btn_Guardar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Guardar.Location = new Point(889, 438);
            btn_Guardar.Name = "btn_Guardar";
            btn_Guardar.Size = new Size(106, 43);
            btn_Guardar.TabIndex = 25;
            btn_Guardar.Text = "Guardar";
            btn_Guardar.TextAlign = ContentAlignment.MiddleRight;
            btn_Guardar.UseVisualStyleBackColor = true;
            btn_Guardar.Click += btn_Guardar_Click;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.FlatAppearance.MouseDownBackColor = Color.Gray;
            btn_Cancelar.FlatAppearance.MouseOverBackColor = Color.Silver;
            btn_Cancelar.Image = Properties.Resources.cerrar2;
            btn_Cancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Cancelar.Location = new Point(756, 438);
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.Size = new Size(111, 43);
            btn_Cancelar.TabIndex = 24;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.TextAlign = ContentAlignment.MiddleRight;
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(cbo_TipoPersona);
            groupBox3.Controls.Add(txt_Documento);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(cbo_TipoDocumento);
            groupBox3.Controls.Add(txt_Codigo);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label2);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1393, 125);
            groupBox3.TabIndex = 23;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos Generales";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(9, 80);
            label13.Name = "label13";
            label13.Size = new Size(94, 20);
            label13.TabIndex = 21;
            label13.Text = "Tipo Persona";
            // 
            // cbo_TipoPersona
            // 
            cbo_TipoPersona.FormattingEnabled = true;
            cbo_TipoPersona.Location = new Point(141, 77);
            cbo_TipoPersona.Name = "cbo_TipoPersona";
            cbo_TipoPersona.Size = new Size(216, 28);
            cbo_TipoPersona.TabIndex = 22;
            cbo_TipoPersona.SelectedIndexChanged += cbo_TipoPersona_SelectedIndexChanged;
            // 
            // txt_Documento
            // 
            txt_Documento.Location = new Point(477, 26);
            txt_Documento.Name = "txt_Documento";
            txt_Documento.Size = new Size(216, 27);
            txt_Documento.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 29);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "Tipo Documento";
            // 
            // cbo_TipoDocumento
            // 
            cbo_TipoDocumento.FormattingEnabled = true;
            cbo_TipoDocumento.Location = new Point(141, 26);
            cbo_TipoDocumento.Name = "cbo_TipoDocumento";
            cbo_TipoDocumento.Size = new Size(216, 28);
            cbo_TipoDocumento.TabIndex = 1;
            // 
            // txt_Codigo
            // 
            txt_Codigo.Location = new Point(776, 27);
            txt_Codigo.Name = "txt_Codigo";
            txt_Codigo.Size = new Size(216, 27);
            txt_Codigo.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(712, 30);
            label8.Name = "label8";
            label8.Size = new Size(58, 20);
            label8.TabIndex = 19;
            label8.Text = "Codigo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(380, 29);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 2;
            label2.Text = "Documento";
            // 
            // gpb_PersonaJuridica
            // 
            gpb_PersonaJuridica.Controls.Add(txt_DireccionFiscal);
            gpb_PersonaJuridica.Controls.Add(label12);
            gpb_PersonaJuridica.Controls.Add(txt_Abreviatura);
            gpb_PersonaJuridica.Controls.Add(label9);
            gpb_PersonaJuridica.Controls.Add(txt_RazonSocial);
            gpb_PersonaJuridica.Controls.Add(label4);
            gpb_PersonaJuridica.Enabled = false;
            gpb_PersonaJuridica.Location = new Point(3, 284);
            gpb_PersonaJuridica.Name = "gpb_PersonaJuridica";
            gpb_PersonaJuridica.Size = new Size(1390, 125);
            gpb_PersonaJuridica.TabIndex = 22;
            gpb_PersonaJuridica.TabStop = false;
            gpb_PersonaJuridica.Text = "Persona Juridica";
            // 
            // txt_DireccionFiscal
            // 
            txt_DireccionFiscal.Location = new Point(132, 69);
            txt_DireccionFiscal.Name = "txt_DireccionFiscal";
            txt_DireccionFiscal.Size = new Size(860, 27);
            txt_DireccionFiscal.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 72);
            label12.Name = "label12";
            label12.Size = new Size(112, 20);
            label12.TabIndex = 25;
            label12.Text = "Dirección Fiscal";
            // 
            // txt_Abreviatura
            // 
            txt_Abreviatura.Location = new Point(776, 26);
            txt_Abreviatura.Name = "txt_Abreviatura";
            txt_Abreviatura.Size = new Size(216, 27);
            txt_Abreviatura.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(678, 29);
            label9.Name = "label9";
            label9.Size = new Size(86, 20);
            label9.TabIndex = 23;
            label9.Text = "Abreviatura";
            // 
            // txt_RazonSocial
            // 
            txt_RazonSocial.Location = new Point(132, 26);
            txt_RazonSocial.Name = "txt_RazonSocial";
            txt_RazonSocial.Size = new Size(529, 27);
            txt_RazonSocial.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 29);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 4;
            label4.Text = "Razon Social";
            // 
            // gpb_PersonaNatural
            // 
            gpb_PersonaNatural.Controls.Add(chk_Comisionista);
            gpb_PersonaNatural.Controls.Add(txt_ApellidoMaterno);
            gpb_PersonaNatural.Controls.Add(label5);
            gpb_PersonaNatural.Controls.Add(txt_Nombres);
            gpb_PersonaNatural.Controls.Add(label6);
            gpb_PersonaNatural.Controls.Add(dtp_FechaNacimiento);
            gpb_PersonaNatural.Controls.Add(label10);
            gpb_PersonaNatural.Controls.Add(txt_ApellidoPaterno);
            gpb_PersonaNatural.Controls.Add(label7);
            gpb_PersonaNatural.Controls.Add(rbt_Femenino);
            gpb_PersonaNatural.Controls.Add(label11);
            gpb_PersonaNatural.Controls.Add(rbt_Masculino);
            gpb_PersonaNatural.Enabled = false;
            gpb_PersonaNatural.Location = new Point(0, 131);
            gpb_PersonaNatural.Name = "gpb_PersonaNatural";
            gpb_PersonaNatural.Size = new Size(1393, 147);
            gpb_PersonaNatural.TabIndex = 21;
            gpb_PersonaNatural.TabStop = false;
            gpb_PersonaNatural.Text = "Persona Natural";
            // 
            // chk_Comisionista
            // 
            chk_Comisionista.AutoSize = true;
            chk_Comisionista.Location = new Point(555, 88);
            chk_Comisionista.Name = "chk_Comisionista";
            chk_Comisionista.Size = new Size(116, 24);
            chk_Comisionista.TabIndex = 19;
            chk_Comisionista.Text = "Comisionista";
            chk_Comisionista.UseVisualStyleBackColor = true;
            // 
            // txt_ApellidoMaterno
            // 
            txt_ApellidoMaterno.Location = new Point(776, 38);
            txt_ApellidoMaterno.Name = "txt_ApellidoMaterno";
            txt_ApellidoMaterno.Size = new Size(216, 27);
            txt_ApellidoMaterno.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 41);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 6;
            label5.Text = "Nombres";
            // 
            // txt_Nombres
            // 
            txt_Nombres.Location = new Point(108, 38);
            txt_Nombres.Name = "txt_Nombres";
            txt_Nombres.Size = new Size(216, 27);
            txt_Nombres.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(347, 41);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 8;
            label6.Text = "Ap. Paterno";
            // 
            // dtp_FechaNacimiento
            // 
            dtp_FechaNacimiento.CustomFormat = "dd/MM/yyyy";
            dtp_FechaNacimiento.Format = DateTimePickerFormat.Short;
            dtp_FechaNacimiento.Location = new Point(404, 87);
            dtp_FechaNacimiento.Name = "dtp_FechaNacimiento";
            dtp_FechaNacimiento.Size = new Size(134, 27);
            dtp_FechaNacimiento.TabIndex = 18;
            dtp_FechaNacimiento.Value = new DateTime(2023, 5, 1, 0, 0, 0, 0);
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(314, 92);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 17;
            label10.Text = "Fecha Nac.";
            // 
            // txt_ApellidoPaterno
            // 
            txt_ApellidoPaterno.Location = new Point(445, 38);
            txt_ApellidoPaterno.Name = "txt_ApellidoPaterno";
            txt_ApellidoPaterno.Size = new Size(216, 27);
            txt_ApellidoPaterno.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(678, 41);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 10;
            label7.Text = "Ap. Materno";
            // 
            // rbt_Femenino
            // 
            rbt_Femenino.AutoSize = true;
            rbt_Femenino.FlatAppearance.BorderSize = 0;
            rbt_Femenino.FlatAppearance.CheckedBackColor = Color.FromArgb(128, 255, 128);
            rbt_Femenino.Location = new Point(186, 86);
            rbt_Femenino.Name = "rbt_Femenino";
            rbt_Femenino.Size = new Size(94, 26);
            rbt_Femenino.TabIndex = 16;
            rbt_Femenino.Text = "Femenino";
            rbt_Femenino.UseCompatibleTextRendering = true;
            rbt_Femenino.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(31, 87);
            label11.Name = "label11";
            label11.Size = new Size(41, 20);
            label11.TabIndex = 15;
            label11.Text = "Sexo";
            // 
            // rbt_Masculino
            // 
            rbt_Masculino.AutoSize = true;
            rbt_Masculino.Checked = true;
            rbt_Masculino.FlatAppearance.BorderSize = 0;
            rbt_Masculino.FlatAppearance.CheckedBackColor = Color.FromArgb(128, 255, 128);
            rbt_Masculino.Location = new Point(79, 85);
            rbt_Masculino.Name = "rbt_Masculino";
            rbt_Masculino.Size = new Size(97, 24);
            rbt_Masculino.TabIndex = 14;
            rbt_Masculino.TabStop = true;
            rbt_Masculino.Text = "Masculino";
            rbt_Masculino.UseVisualStyleBackColor = true;
            // 
            // frm_Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 581);
            Controls.Add(tbc_Principal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Cliente";
            Text = "frm_Cliente";
            tbc_Principal.ResumeLayout(false);
            tp_Lista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgb_Lista).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tp_Mantenimiento.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            gpb_PersonaJuridica.ResumeLayout(false);
            gpb_PersonaJuridica.PerformLayout();
            gpb_PersonaNatural.ResumeLayout(false);
            gpb_PersonaNatural.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tbc_Principal;
        private TabPage tp_Lista;
        private DataGridView dgb_Lista;
        private Panel panel2;
        private Panel panel1;
        private ComboBox cbo_Color_Comisionista;
        private Label label3;
        private TabPage tp_Mantenimiento;
        private Panel panel3;
        private TextBox txt_ApellidoMaterno;
        private Label label7;
        private TextBox txt_ApellidoPaterno;
        private Label label6;
        private TextBox txt_Nombres;
        private Label label5;
        private TextBox txt_RazonSocial;
        private Label label4;
        private TextBox txt_Documento;
        private Label label2;
        private ComboBox cbo_TipoDocumento;
        private Label label1;
        private RadioButton rbt_Femenino;
        private Label label11;
        private RadioButton rbt_Masculino;
        private GroupBox groupBox3;
        private Label label13;
        private ComboBox cbo_TipoPersona;
        private TextBox txt_Codigo;
        private Label label8;
        private GroupBox gpb_PersonaJuridica;
        private TextBox txt_DireccionFiscal;
        private Label label12;
        private TextBox txt_Abreviatura;
        private Label label9;
        private GroupBox gpb_PersonaNatural;
        private CheckBox chk_Comisionista;
        private DateTimePicker dtp_FechaNacimiento;
        private Label label10;
        private Button btn_Guardar;
        private Button btn_Cancelar;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btn_Cerrar;
    }
}