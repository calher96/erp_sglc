namespace Principal.Helpers
{
    partial class frm_Direccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Direccion));
            tableLayoutPanel1 = new TableLayoutPanel();
            tbc_Direccion = new TabControl();
            tabPage1 = new TabPage();
            dgb_Direccion = new DataGridView();
            tabPage2 = new TabPage();
            label15 = new Label();
            label16 = new Label();
            txt_DireccionCompleta = new TextBox();
            cbo_Distrito = new ComboBox();
            label14 = new Label();
            cbo_Provincia = new ComboBox();
            txt_CentroCosto = new TextBox();
            chk_CentroEsSalud = new CheckBox();
            cbo_Departamento = new ComboBox();
            label17 = new Label();
            label13 = new Label();
            txt_Referencia = new TextBox();
            label12 = new Label();
            txt_NombreZona = new TextBox();
            label11 = new Label();
            cbo_TipoZona = new ComboBox();
            label10 = new Label();
            txt_Etapa = new TextBox();
            label9 = new Label();
            txt_Interior = new TextBox();
            label8 = new Label();
            txt_Manzana = new TextBox();
            label7 = new Label();
            txt_Lote = new TextBox();
            label6 = new Label();
            txt_Kilometro = new TextBox();
            label5 = new Label();
            txt_Block = new TextBox();
            label4 = new Label();
            txt_Departamento = new TextBox();
            label3 = new Label();
            txt_Numero = new TextBox();
            label2 = new Label();
            txt_NombreVia = new TextBox();
            label1 = new Label();
            cbo_TipoVia = new ComboBox();
            panel1 = new Panel();
            button1 = new Button();
            btn_Quitar = new Button();
            button3 = new Button();
            btn_Grabar = new Button();
            button5 = new Button();
            btn_Agregar = new Button();
            button7 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tbc_Direccion.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgb_Direccion).BeginInit();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(tbc_Direccion, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.111111F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.8888855F));
            tableLayoutPanel1.Size = new Size(1067, 451);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // tbc_Direccion
            // 
            tbc_Direccion.Controls.Add(tabPage1);
            tbc_Direccion.Controls.Add(tabPage2);
            tbc_Direccion.Dock = DockStyle.Fill;
            tbc_Direccion.Location = new Point(3, 35);
            tbc_Direccion.Name = "tbc_Direccion";
            tbc_Direccion.SelectedIndex = 0;
            tbc_Direccion.Size = new Size(1061, 413);
            tbc_Direccion.TabIndex = 32;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgb_Direccion);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1053, 380);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lista";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgb_Direccion
            // 
            dgb_Direccion.AllowUserToAddRows = false;
            dgb_Direccion.AllowUserToDeleteRows = false;
            dgb_Direccion.AllowUserToOrderColumns = true;
            dgb_Direccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgb_Direccion.Dock = DockStyle.Fill;
            dgb_Direccion.Location = new Point(3, 3);
            dgb_Direccion.Name = "dgb_Direccion";
            dgb_Direccion.ReadOnly = true;
            dgb_Direccion.RowHeadersWidth = 51;
            dgb_Direccion.RowTemplate.Height = 29;
            dgb_Direccion.Size = new Size(1047, 374);
            dgb_Direccion.TabIndex = 0;
            dgb_Direccion.CellClick += dgb_Direccion_CellClick;
            dgb_Direccion.SelectionChanged += dgb_Direccion_SelectionChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(txt_DireccionCompleta);
            tabPage2.Controls.Add(cbo_Distrito);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(cbo_Provincia);
            tabPage2.Controls.Add(txt_CentroCosto);
            tabPage2.Controls.Add(chk_CentroEsSalud);
            tabPage2.Controls.Add(cbo_Departamento);
            tabPage2.Controls.Add(label17);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(txt_Referencia);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(txt_NombreZona);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(cbo_TipoZona);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(txt_Etapa);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(txt_Interior);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txt_Manzana);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txt_Lote);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(txt_Kilometro);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txt_Block);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txt_Departamento);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txt_Numero);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txt_NombreVia);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(cbo_TipoVia);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1053, 380);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Mantenimiento";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(602, 164);
            label15.Name = "label15";
            label15.Size = new Size(58, 20);
            label15.TabIndex = 65;
            label15.Text = "Distrito";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(591, 129);
            label16.Name = "label16";
            label16.Size = new Size(69, 20);
            label16.TabIndex = 64;
            label16.Text = "Provincia";
            // 
            // txt_DireccionCompleta
            // 
            txt_DireccionCompleta.CharacterCasing = CharacterCasing.Upper;
            txt_DireccionCompleta.Location = new Point(533, 195);
            txt_DireccionCompleta.Multiline = true;
            txt_DireccionCompleta.Name = "txt_DireccionCompleta";
            txt_DireccionCompleta.Size = new Size(506, 52);
            txt_DireccionCompleta.TabIndex = 63;
            // 
            // cbo_Distrito
            // 
            cbo_Distrito.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbo_Distrito.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbo_Distrito.FormattingEnabled = true;
            cbo_Distrito.Location = new Point(667, 160);
            cbo_Distrito.Name = "cbo_Distrito";
            cbo_Distrito.Size = new Size(371, 28);
            cbo_Distrito.TabIndex = 57;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(550, 41);
            label14.Name = "label14";
            label14.Size = new Size(119, 20);
            label14.TabIndex = 62;
            label14.Text = "Centro de Costo:";
            // 
            // cbo_Provincia
            // 
            cbo_Provincia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbo_Provincia.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbo_Provincia.FormattingEnabled = true;
            cbo_Provincia.Location = new Point(667, 125);
            cbo_Provincia.Name = "cbo_Provincia";
            cbo_Provincia.Size = new Size(371, 28);
            cbo_Provincia.TabIndex = 54;
            cbo_Provincia.SelectedIndexChanged += cbo_Provincia_SelectedIndexChanged;
            // 
            // txt_CentroCosto
            // 
            txt_CentroCosto.CharacterCasing = CharacterCasing.Upper;
            txt_CentroCosto.Location = new Point(667, 35);
            txt_CentroCosto.Name = "txt_CentroCosto";
            txt_CentroCosto.Size = new Size(189, 27);
            txt_CentroCosto.TabIndex = 61;
            // 
            // chk_CentroEsSalud
            // 
            chk_CentroEsSalud.AutoSize = true;
            chk_CentroEsSalud.Location = new Point(10, 255);
            chk_CentroEsSalud.Name = "chk_CentroEsSalud";
            chk_CentroEsSalud.Size = new Size(221, 24);
            chk_CentroEsSalud.TabIndex = 60;
            chk_CentroEsSalud.Text = "Centro de Asistencia EsSalud";
            chk_CentroEsSalud.UseVisualStyleBackColor = true;
            // 
            // cbo_Departamento
            // 
            cbo_Departamento.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbo_Departamento.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbo_Departamento.FormattingEnabled = true;
            cbo_Departamento.Location = new Point(667, 92);
            cbo_Departamento.Name = "cbo_Departamento";
            cbo_Departamento.Size = new Size(371, 28);
            cbo_Departamento.TabIndex = 51;
            cbo_Departamento.SelectedIndexChanged += cbo_Departamento_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(554, 97);
            label17.Name = "label17";
            label17.Size = new Size(106, 20);
            label17.TabIndex = 48;
            label17.Text = "Departamento";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(10, 196);
            label13.Name = "label13";
            label13.Size = new Size(82, 20);
            label13.TabIndex = 59;
            label13.Text = "Referencia:";
            // 
            // txt_Referencia
            // 
            txt_Referencia.CharacterCasing = CharacterCasing.Upper;
            txt_Referencia.Location = new Point(7, 219);
            txt_Referencia.Name = "txt_Referencia";
            txt_Referencia.Size = new Size(506, 27);
            txt_Referencia.TabIndex = 58;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(167, 136);
            label12.Name = "label12";
            label12.Size = new Size(126, 20);
            label12.TabIndex = 56;
            label12.Text = "Nombre de Zona:";
            // 
            // txt_NombreZona
            // 
            txt_NombreZona.CharacterCasing = CharacterCasing.Upper;
            txt_NombreZona.Location = new Point(165, 159);
            txt_NombreZona.Name = "txt_NombreZona";
            txt_NombreZona.Size = new Size(349, 27);
            txt_NombreZona.TabIndex = 55;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 135);
            label11.Name = "label11";
            label11.Size = new Size(101, 20);
            label11.TabIndex = 53;
            label11.Text = "Tipo de Zona:";
            // 
            // cbo_TipoZona
            // 
            cbo_TipoZona.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbo_TipoZona.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbo_TipoZona.FormattingEnabled = true;
            cbo_TipoZona.Location = new Point(7, 157);
            cbo_TipoZona.Name = "cbo_TipoZona";
            cbo_TipoZona.Size = new Size(151, 28);
            cbo_TipoZona.TabIndex = 52;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(457, 69);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 50;
            label10.Text = "Etapa:";
            // 
            // txt_Etapa
            // 
            txt_Etapa.CharacterCasing = CharacterCasing.Upper;
            txt_Etapa.Location = new Point(454, 93);
            txt_Etapa.Name = "txt_Etapa";
            txt_Etapa.Size = new Size(59, 27);
            txt_Etapa.TabIndex = 49;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(149, 69);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 47;
            label9.Text = "Interior:";
            // 
            // txt_Interior
            // 
            txt_Interior.CharacterCasing = CharacterCasing.Upper;
            txt_Interior.Location = new Point(145, 93);
            txt_Interior.Name = "txt_Interior";
            txt_Interior.Size = new Size(60, 27);
            txt_Interior.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(214, 69);
            label8.Name = "label8";
            label8.Size = new Size(40, 20);
            label8.TabIndex = 45;
            label8.Text = "Mza:";
            // 
            // txt_Manzana
            // 
            txt_Manzana.CharacterCasing = CharacterCasing.Upper;
            txt_Manzana.Location = new Point(211, 93);
            txt_Manzana.Name = "txt_Manzana";
            txt_Manzana.Size = new Size(52, 27);
            txt_Manzana.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(272, 69);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 43;
            label7.Text = "Lote:";
            // 
            // txt_Lote
            // 
            txt_Lote.CharacterCasing = CharacterCasing.Upper;
            txt_Lote.Location = new Point(269, 93);
            txt_Lote.Name = "txt_Lote";
            txt_Lote.Size = new Size(52, 27);
            txt_Lote.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 69);
            label6.Name = "label6";
            label6.Size = new Size(34, 20);
            label6.TabIndex = 41;
            label6.Text = "Km:";
            // 
            // txt_Kilometro
            // 
            txt_Kilometro.CharacterCasing = CharacterCasing.Upper;
            txt_Kilometro.Location = new Point(327, 93);
            txt_Kilometro.Name = "txt_Kilometro";
            txt_Kilometro.Size = new Size(57, 27);
            txt_Kilometro.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 69);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 39;
            label5.Text = "Block:";
            // 
            // txt_Block
            // 
            txt_Block.CharacterCasing = CharacterCasing.Upper;
            txt_Block.Location = new Point(389, 93);
            txt_Block.Name = "txt_Block";
            txt_Block.Size = new Size(59, 27);
            txt_Block.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 69);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 37;
            label4.Text = "Dpto:";
            // 
            // txt_Departamento
            // 
            txt_Departamento.CharacterCasing = CharacterCasing.Upper;
            txt_Departamento.Location = new Point(79, 93);
            txt_Departamento.Name = "txt_Departamento";
            txt_Departamento.Size = new Size(60, 27);
            txt_Departamento.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 69);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 35;
            label3.Text = "Número:";
            // 
            // txt_Numero
            // 
            txt_Numero.CharacterCasing = CharacterCasing.Upper;
            txt_Numero.Location = new Point(7, 93);
            txt_Numero.Name = "txt_Numero";
            txt_Numero.Size = new Size(66, 27);
            txt_Numero.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 12);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 33;
            label2.Text = "Nombre de Vía:";
            // 
            // txt_NombreVia
            // 
            txt_NombreVia.CharacterCasing = CharacterCasing.Upper;
            txt_NombreVia.Location = new Point(165, 35);
            txt_NombreVia.Name = "txt_NombreVia";
            txt_NombreVia.Size = new Size(349, 27);
            txt_NombreVia.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 31;
            label1.Text = "Tipo de Vía:";
            // 
            // cbo_TipoVia
            // 
            cbo_TipoVia.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbo_TipoVia.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbo_TipoVia.FormattingEnabled = true;
            cbo_TipoVia.Location = new Point(7, 35);
            cbo_TipoVia.Name = "cbo_TipoVia";
            cbo_TipoVia.Size = new Size(151, 28);
            cbo_TipoVia.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_Quitar);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btn_Grabar);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(btn_Agregar);
            panel1.Controls.Add(button7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1061, 26);
            panel1.TabIndex = 31;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Left;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(528, 0);
            button1.Name = "button1";
            button1.Size = new Size(96, 26);
            button1.TabIndex = 6;
            button1.Text = "Aceptar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_Quitar
            // 
            btn_Quitar.Dock = DockStyle.Left;
            btn_Quitar.Enabled = false;
            btn_Quitar.Image = (Image)resources.GetObject("btn_Quitar.Image");
            btn_Quitar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Quitar.Location = new Point(446, 0);
            btn_Quitar.Name = "btn_Quitar";
            btn_Quitar.Size = new Size(82, 26);
            btn_Quitar.TabIndex = 5;
            btn_Quitar.Text = "Quitar";
            btn_Quitar.TextAlign = ContentAlignment.MiddleRight;
            btn_Quitar.UseVisualStyleBackColor = true;
            btn_Quitar.Click += button2_Click;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Left;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(351, 0);
            button3.Name = "button3";
            button3.Size = new Size(95, 26);
            button3.TabIndex = 4;
            button3.Text = "Cancelar";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btn_Grabar
            // 
            btn_Grabar.Dock = DockStyle.Left;
            btn_Grabar.Enabled = false;
            btn_Grabar.Image = (Image)resources.GetObject("btn_Grabar.Image");
            btn_Grabar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Grabar.Location = new Point(269, 0);
            btn_Grabar.Name = "btn_Grabar";
            btn_Grabar.Size = new Size(82, 26);
            btn_Grabar.TabIndex = 3;
            btn_Grabar.Text = "Grabar";
            btn_Grabar.TextAlign = ContentAlignment.MiddleRight;
            btn_Grabar.UseVisualStyleBackColor = true;
            btn_Grabar.Click += button4_Click;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Left;
            button5.Enabled = false;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(171, 0);
            button5.Name = "button5";
            button5.Size = new Size(98, 26);
            button5.TabIndex = 2;
            button5.Text = "Modificar";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = true;
            // 
            // btn_Agregar
            // 
            btn_Agregar.Dock = DockStyle.Left;
            btn_Agregar.Image = (Image)resources.GetObject("btn_Agregar.Image");
            btn_Agregar.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Agregar.Location = new Point(82, 0);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(89, 26);
            btn_Agregar.TabIndex = 1;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.TextAlign = ContentAlignment.MiddleRight;
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Left;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 0);
            button7.Name = "button7";
            button7.Size = new Size(82, 26);
            button7.TabIndex = 0;
            button7.Text = "Listar";
            button7.TextAlign = ContentAlignment.MiddleRight;
            button7.UseVisualStyleBackColor = true;
            // 
            // frm_Direccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 451);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Direccion";
            Text = "frm_Direccion";
            tableLayoutPanel1.ResumeLayout(false);
            tbc_Direccion.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgb_Direccion).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tbc_Direccion;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private Button button1;
        private Button btn_Quitar;
        private Button button3;
        private Button btn_Grabar;
        private Button button5;
        private Button btn_Agregar;
        private Button button7;
        private Label label15;
        private Label label16;
        private TextBox txt_DireccionCompleta;
        private ComboBox cbo_Distrito;
        private Label label14;
        private ComboBox cbo_Provincia;
        private TextBox txt_CentroCosto;
        private CheckBox chk_CentroEsSalud;
        private ComboBox cbo_Departamento;
        private Label label17;
        private Label label13;
        private TextBox txt_Referencia;
        private Label label12;
        private TextBox txt_NombreZona;
        private Label label11;
        private ComboBox cbo_TipoZona;
        private Label label10;
        private TextBox txt_Etapa;
        private Label label9;
        private TextBox txt_Interior;
        private Label label8;
        private TextBox txt_Manzana;
        private Label label7;
        private TextBox txt_Lote;
        private Label label6;
        private TextBox txt_Kilometro;
        private Label label5;
        private TextBox txt_Block;
        private Label label4;
        private TextBox txt_Departamento;
        private Label label3;
        private TextBox txt_Numero;
        private Label label2;
        private TextBox txt_NombreVia;
        private Label label1;
        private ComboBox cbo_TipoVia;
        private DataGridView dgb_Direccion;
    }
}