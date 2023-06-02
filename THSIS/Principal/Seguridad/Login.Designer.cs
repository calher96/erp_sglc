namespace Principal.Seguridad
{
    partial class Login
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
            txtUser = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(15, 15, 15);
            txtUser.CharacterCasing = CharacterCasing.Upper;
            txtUser.ForeColor = Color.DimGray;
            txtUser.Location = new Point(348, 71);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "USUARIO";
            txtUser.Size = new Size(369, 27);
            txtUser.TabIndex = 0;
            txtUser.Tag = "";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(15, 15, 15);
            txtPassword.CharacterCasing = CharacterCasing.Upper;
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Location = new Point(348, 144);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "CONTRASEÑA";
            txtPassword.Size = new Size(369, 27);
            txtPassword.TabIndex = 1;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(40, 40, 40);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gainsboro;
            button1.Location = new Point(348, 217);
            button1.Name = "button1";
            button1.Size = new Size(369, 41);
            button1.TabIndex = 4;
            button1.Text = "Iniciar Sesión";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 122, 204);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 330);
            panel1.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(780, 330);
            Controls.Add(panel1);
            Controls.Add(txtUser);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPassword;
        private Button button1;
        private Panel panel1;
    }
}