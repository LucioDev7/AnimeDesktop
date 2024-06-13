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
            menuMinimizar = new PictureBox();
            menuMaximizar = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelHeader = new Panel();
            label1 = new Label();
            btnRestaurar = new PictureBox();
            btnMinimizar = new PictureBox();
            btnMaximizar = new PictureBox();
            btnCerrar = new PictureBox();
            panelContenedor.SuspendLayout();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuMaximizar).BeginInit();
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
            panelContenedor.Size = new Size(1084, 561);
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
            panelFormularios.Size = new Size(859, 521);
            panelFormularios.TabIndex = 2;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DarkGreen;
            panelMenu.Controls.Add(menuMinimizar);
            panelMenu.Controls.Add(menuMaximizar);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 40);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(225, 521);
            panelMenu.TabIndex = 1;
            // 
            // menuMinimizar
            // 
            menuMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuMinimizar.Cursor = Cursors.Hand;
            menuMinimizar.Image = (Image)resources.GetObject("menuMinimizar.Image");
            menuMinimizar.Location = new Point(187, 17);
            menuMinimizar.Name = "menuMinimizar";
            menuMinimizar.Size = new Size(21, 24);
            menuMinimizar.TabIndex = 4;
            menuMinimizar.TabStop = false;
            menuMinimizar.Click += menuMinMax_Click;
            // 
            // menuMaximizar
            // 
            menuMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuMaximizar.Cursor = Cursors.Hand;
            menuMaximizar.Image = (Image)resources.GetObject("menuMaximizar.Image");
            menuMaximizar.Location = new Point(187, 17);
            menuMaximizar.Name = "menuMaximizar";
            menuMaximizar.Size = new Size(21, 23);
            menuMaximizar.TabIndex = 3;
            menuMaximizar.TabStop = false;
            menuMaximizar.Click += menuMinMax_Click;
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
            button3.Location = new Point(0, 233);
            button3.Name = "button3";
            button3.Size = new Size(225, 42);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            //button3.Click += button3_Click;
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
            button2.Location = new Point(0, 185);
            button2.Name = "button2";
            button2.Size = new Size(225, 42);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            //button2.Click += button2_Click;
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
            button1.Location = new Point(0, 137);
            button1.Name = "button1";
            button1.Size = new Size(225, 42);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            panelHeader.Size = new Size(1084, 40);
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
            btnRestaurar.Location = new Point(1028, 12);
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
            btnMinimizar.Location = new Point(1003, 12);
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
            btnMaximizar.Location = new Point(1028, 12);
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
            btnCerrar.Location = new Point(1053, 12);
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
            ClientSize = new Size(1084, 561);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(680, 400);
            Name = "MainFormsWindows";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelContenedor.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menuMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuMaximizar).EndInit();
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
        private PictureBox menuMinimizar;
        private PictureBox menuMaximizar;
    }
}
