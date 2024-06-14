namespace DesktopAnime
{
    partial class LoginWindows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindows));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            btnAccederLogin = new Button();
            linkContra = new LinkLabel();
            btnCloseLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            logMsgError = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(230, 230);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(230, 230);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += LoginWindows_MouseDown;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.Black;
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.ForeColor = Color.White;
            txtUser.Location = new Point(345, 78);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(404, 25);
            txtUser.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Black;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(345, 110);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(404, 25);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(456, 22);
            label1.Name = "label1";
            label1.Size = new Size(153, 22);
            label1.TabIndex = 3;
            label1.Text = "Inicio de Sesión";
            // 
            // btnAccederLogin
            // 
            btnAccederLogin.BackColor = Color.FromArgb(40, 40, 40);
            btnAccederLogin.FlatAppearance.BorderSize = 0;
            btnAccederLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnAccederLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnAccederLogin.FlatStyle = FlatStyle.Flat;
            btnAccederLogin.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAccederLogin.ForeColor = Color.LightGray;
            btnAccederLogin.Location = new Point(345, 154);
            btnAccederLogin.Name = "btnAccederLogin";
            btnAccederLogin.Size = new Size(400, 40);
            btnAccederLogin.TabIndex = 4;
            btnAccederLogin.Text = "&Acceder";
            btnAccederLogin.UseVisualStyleBackColor = false;
            btnAccederLogin.Click += btnAccederLogin_Click;
            // 
            // linkContra
            // 
            linkContra.ActiveLinkColor = Color.FromArgb(0, 124, 254);
            linkContra.AutoSize = true;
            linkContra.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkContra.LinkColor = Color.DimGray;
            linkContra.Location = new Point(486, 206);
            linkContra.Name = "linkContra";
            linkContra.Size = new Size(123, 15);
            linkContra.TabIndex = 5;
            linkContra.TabStop = true;
            linkContra.Text = "Olvide mi contraseña";
            linkContra.LinkClicked += linkContra_LinkClicked;
            // 
            // btnCloseLogin
            // 
            btnCloseLogin.BackColor = Color.FromArgb(40, 40, 40);
            btnCloseLogin.FlatAppearance.BorderSize = 0;
            btnCloseLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnCloseLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnCloseLogin.FlatStyle = FlatStyle.Flat;
            btnCloseLogin.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCloseLogin.ForeColor = Color.LightGray;
            btnCloseLogin.Location = new Point(746, 0);
            btnCloseLogin.Name = "btnCloseLogin";
            btnCloseLogin.Size = new Size(34, 28);
            btnCloseLogin.TabIndex = 6;
            btnCloseLogin.Text = "X";
            btnCloseLogin.UseVisualStyleBackColor = false;
            btnCloseLogin.Click += btnCloseLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(236, 81);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 7;
            label2.Text = "Usuario/Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(236, 113);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 8;
            label3.Text = "Contraseña:";
            // 
            // logMsgError
            // 
            logMsgError.AutoSize = true;
            logMsgError.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logMsgError.ForeColor = Color.Gray;
            logMsgError.Location = new Point(345, 51);
            logMsgError.Name = "logMsgError";
            logMsgError.Size = new Size(84, 15);
            logMsgError.TabIndex = 9;
            logMsgError.Text = "Error Mensaje";
            logMsgError.Visible = false;
            // 
            // LoginWindows
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(780, 230);
            ControlBox = false;
            Controls.Add(logMsgError);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCloseLogin);
            Controls.Add(linkContra);
            Controls.Add(btnAccederLogin);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginWindows";
            Opacity = 0.9D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anime Desktop v1.0.0.0";
            MouseDown += LoginWindows_MouseDown;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label label1;
        private Button btnAccederLogin;
        private LinkLabel linkContra;
        private PictureBox pictureBox1;
        private Button btnCloseLogin;
        private Label label2;
        private Label label3;
        private Label logMsgError;
    }
}
