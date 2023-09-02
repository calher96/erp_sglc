namespace Principal.Operaciones
{
    partial class frm_RecepcionCarga
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
            tpc_RecepcionCarga = new TabControl();
            tpg_Lista = new TabPage();
            tpg_Mantenimiento = new TabPage();
            tpc_RecepcionCarga.SuspendLayout();
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
            tpc_RecepcionCarga.Size = new Size(1684, 834);
            tpc_RecepcionCarga.TabIndex = 0;
            // 
            // tpg_Lista
            // 
            tpg_Lista.Location = new Point(4, 29);
            tpg_Lista.Name = "tpg_Lista";
            tpg_Lista.Padding = new Padding(3);
            tpg_Lista.Size = new Size(1676, 801);
            tpg_Lista.TabIndex = 0;
            tpg_Lista.Text = "Lista";
            tpg_Lista.UseVisualStyleBackColor = true;
            // 
            // tpg_Mantenimiento
            // 
            tpg_Mantenimiento.Location = new Point(4, 29);
            tpg_Mantenimiento.Name = "tpg_Mantenimiento";
            tpg_Mantenimiento.Padding = new Padding(3);
            tpg_Mantenimiento.Size = new Size(1676, 801);
            tpg_Mantenimiento.TabIndex = 1;
            tpg_Mantenimiento.Text = "Mantenimiento";
            tpg_Mantenimiento.UseVisualStyleBackColor = true;
            // 
            // frm_RecepcionCarga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1684, 834);
            Controls.Add(tpc_RecepcionCarga);
            Name = "frm_RecepcionCarga";
            Text = "frm_RecepcionCarga";
            tpc_RecepcionCarga.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tpc_RecepcionCarga;
        private TabPage tpg_Lista;
        private TabPage tpg_Mantenimiento;
    }
}