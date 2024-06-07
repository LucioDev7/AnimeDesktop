namespace DesktopAnime
{
    partial class loginWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginWindow));
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            btnExitLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11F);
            label1.Location = new Point(12, 118);
            label1.Name = "label1";
            label1.Size = new Size(99, 17);
            label1.TabIndex = 1;
            label1.Text = "Usuario/Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11F);
            label2.Location = new Point(12, 161);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(117, 117);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(226, 21);
            txtUser.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(116, 160);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(226, 21);
            txtPassword.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(348, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 310);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.ForestGreen;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(274, 253);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(117, 31);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnExitLogin
            // 
            btnExitLogin.BackColor = Color.ForestGreen;
            btnExitLogin.FlatStyle = FlatStyle.Flat;
            btnExitLogin.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExitLogin.Location = new Point(659, 0);
            btnExitLogin.Name = "btnExitLogin";
            btnExitLogin.Size = new Size(38, 23);
            btnExitLogin.TabIndex = 7;
            btnExitLogin.Text = "X";
            btnExitLogin.UseVisualStyleBackColor = false;
            btnExitLogin.Click += btnExitLogin_Click;
            // 
            // loginWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(696, 309);
            Controls.Add(btnExitLogin);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "loginWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anime Desktop";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
        private Button btnLogin;
        private Button btnExitLogin;
    }
}
