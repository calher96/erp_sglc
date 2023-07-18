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
            tpg_Lista = new TabControl();
            tpg_Mantenimiento = new TabPage();
            tpg_Lista.SuspendLayout();
            SuspendLayout();
            // 
            // tpg_Lista
            // 
            tpg_Lista.Controls.Add(tpg_Mantenimiento);
            tpg_Lista.Dock = DockStyle.Fill;
            tpg_Lista.Location = new Point(0, 0);
            tpg_Lista.Name = "tpg_Lista";
            tpg_Lista.SelectedIndex = 0;
            tpg_Lista.Size = new Size(1684, 834);
            tpg_Lista.TabIndex = 0;
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
            Controls.Add(tpg_Lista);
            Name = "frm_RecepcionCarga";
            Text = "frm_RecepcionCarga";
            tpg_Lista.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tpg_Lista;
        private TabPage tpg_Mantenimiento;
    }
}