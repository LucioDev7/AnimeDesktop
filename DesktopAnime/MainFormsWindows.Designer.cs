namespace DesktopAnime
{
    partial class MainFormsWindows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFormsWindows));
            panelContenedor = new Panel();
            panelFormularios = new Panel();
            panelMenu = new Panel();
            button4 = new Button();
            menuMinMax = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelPerfil = new Panel();
            imagenPerfil = new PictureBox();
            btnCerrarSesion = new Button();
            MostrarRol = new Label();
            MostrarNombre = new Label();
            MostrarCorreo = new Label();
            panelHeader = new Panel();
            label1 = new Label();
            btnRestaurar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            panelContenedor.SuspendLayout();
            panelMenu.SuspendLayout();
            panelPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenPerfil).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.ActiveCaption;
            panelContenedor.Controls.Add(panelFormularios);
            panelContenedor.Controls.Add(panelMenu);
            panelContenedor.Controls.Add(panelHeader);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1280, 600);
            panelContenedor.TabIndex = 0;
            // 
            // panelFormularios
            // 
            panelFormularios.BackColor = Color.White;
            panelFormularios.BackgroundImage = (Image)resources.GetObject("panelFormularios.BackgroundImage");
            panelFormularios.BackgroundImageLayout = ImageLayout.Stretch;
            panelFormularios.Dock = DockStyle.Fill;
            panelFormularios.Location = new Point(225, 40);
            panelFormularios.Name = "panelFormularios";
            panelFormularios.Size = new Size(1055, 560);
            panelFormularios.TabIndex = 2;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkGreen;
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(menuMinMax);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(panelPerfil);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 40);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(225, 560);
            panelMenu.TabIndex = 1;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            button4.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 315);
            button4.Name = "button4";
            button4.Size = new Size(225, 42);
            button4.TabIndex = 8;
            button4.Text = "U&suarios";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // menuMinMax
            // 
            menuMinMax.BackColor = Color.Black;
            menuMinMax.FlatAppearance.BorderSize = 0;
            menuMinMax.FlatStyle = FlatStyle.Flat;
            menuMinMax.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            menuMinMax.ForeColor = Color.White;
            menuMinMax.Location = new Point(0, 130);
            menuMinMax.Name = "menuMinMax";
            menuMinMax.Size = new Size(225, 55);
            menuMinMax.TabIndex = 7;
            menuMinMax.UseVisualStyleBackColor = false;
            menuMinMax.Click += menuMinMax_Click_1;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            button3.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 272);
            button3.Name = "button3";
            button3.Size = new Size(225, 42);
            button3.TabIndex = 2;
            button3.Text = "&Ultimo Capítulo";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            button2.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 229);
            button2.Name = "button2";
            button2.Size = new Size(225, 42);
            button2.TabIndex = 1;
            button2.Text = "&Trailers";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            button1.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 186);
            button1.Name = "button1";
            button1.Size = new Size(225, 42);
            button1.TabIndex = 0;
            button1.Text = "&Animes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelPerfil
            // 
            panelPerfil.BackColor = Color.ForestGreen;
            panelPerfil.Controls.Add(imagenPerfil);
            panelPerfil.Controls.Add(btnCerrarSesion);
            panelPerfil.Controls.Add(MostrarRol);
            panelPerfil.Controls.Add(MostrarNombre);
            panelPerfil.Controls.Add(MostrarCorreo);
            panelPerfil.Location = new Point(-2, -1);
            panelPerfil.Name = "panelPerfil";
            panelPerfil.Size = new Size(227, 132);
            panelPerfil.TabIndex = 6;
            // 
            // imagenPerfil
            // 
            imagenPerfil.Image = (Image)resources.GetObject("imagenPerfil.Image");
            imagenPerfil.Location = new Point(164, 68);
            imagenPerfil.Name = "imagenPerfil";
            imagenPerfil.Size = new Size(63, 61);
            imagenPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenPerfil.TabIndex = 0;
            imagenPerfil.TabStop = false;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Green;
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.Crimson;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(2, 1);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(114, 24);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // MostrarRol
            // 
            MostrarRol.AutoSize = true;
            MostrarRol.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            MostrarRol.ForeColor = Color.White;
            MostrarRol.Location = new Point(14, 105);
            MostrarRol.Name = "MostrarRol";
            MostrarRol.Size = new Size(26, 14);
            MostrarRol.TabIndex = 3;
            MostrarRol.Text = "Rol";
            // 
            // MostrarNombre
            // 
            MostrarNombre.AutoSize = true;
            MostrarNombre.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            MostrarNombre.ForeColor = Color.White;
            MostrarNombre.Location = new Point(14, 78);
            MostrarNombre.Name = "MostrarNombre";
            MostrarNombre.Size = new Size(54, 14);
            MostrarNombre.TabIndex = 2;
            MostrarNombre.Text = "Nombre";
            // 
            // MostrarCorreo
            // 
            MostrarCorreo.AutoSize = true;
            MostrarCorreo.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            MostrarCorreo.ForeColor = Color.White;
            MostrarCorreo.Location = new Point(14, 51);
            MostrarCorreo.Name = "MostrarCorreo";
            MostrarCorreo.Size = new Size(164, 14);
            MostrarCorreo.TabIndex = 1;
            MostrarCorreo.Text = "correoejemplo@gmail.com";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Black;
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(btnRestaurar);
            panelHeader.Controls.Add(btnMinimizar);
            panelHeader.Controls.Add(btnMaximizar);
            panelHeader.Controls.Add(btnCerrar);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1280, 40);
            panelHeader.TabIndex = 0;
            panelHeader.MouseMove += panelHeader_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 17);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 2;
            label1.Text = "Anime Desktop v1.0.0.0";
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1224, 12);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(18, 19);
            btnRestaurar.TabIndex = 0;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(1199, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(19, 19);
            btnMinimizar.TabIndex = 0;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1224, 12);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(19, 20);
            btnMaximizar.TabIndex = 0;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1249, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(19, 19);
            btnCerrar.TabIndex = 1;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // MainFormsWindows
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 600);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(680, 400);
            Name = "MainFormsWindows";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Anime Desktop v1.0.0.0";
            panelContenedor.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelPerfil.ResumeLayout(false);
            panelPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagenPerfil).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private Panel panelHeader;
        private Panel panelFormularios;
        private Panel panelMenu;
        private PictureBox btnMaximizar;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private PictureBox btnRestaurar;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Button btnCerrarSesion;
        private Panel panelPerfil;
        private PictureBox imagenPerfil;
        private Label MostrarRol;
        private Label MostrarNombre;
        private Label MostrarCorreo;
        private Button menuMinMax;
        private Button button4;
    }
}
