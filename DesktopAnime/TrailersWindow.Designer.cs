namespace DesktopAnime
{
    partial class TrailersWindow
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
            panel1 = new Panel();
            lblSeleccion = new Label();
            btnSelect = new Button();
            dataGridAnime = new DataGridView();
            panel2 = new Panel();
            lblTrailer = new Label();
            panelVideo = new Panel();
            btnExit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAnime).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(63, 90, 54);
            panel1.Controls.Add(lblSeleccion);
            panel1.Controls.Add(btnSelect);
            panel1.Controls.Add(dataGridAnime);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 450);
            panel1.TabIndex = 0;
            // 
            // lblSeleccion
            // 
            lblSeleccion.AutoSize = true;
            lblSeleccion.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSeleccion.ForeColor = Color.White;
            lblSeleccion.Location = new Point(12, 15);
            lblSeleccion.Name = "lblSeleccion";
            lblSeleccion.Size = new Size(165, 18);
            lblSeleccion.TabIndex = 2;
            lblSeleccion.Text = "Selecione un Anime";
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.Bottom;
            btnSelect.BackColor = Color.White;
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSelect.Location = new Point(59, 406);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(130, 26);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "&Seleccionar";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // dataGridAnime
            // 
            dataGridAnime.AllowUserToAddRows = false;
            dataGridAnime.AllowUserToDeleteRows = false;
            dataGridAnime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridAnime.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAnime.Location = new Point(0, 44);
            dataGridAnime.Name = "dataGridAnime";
            dataGridAnime.ReadOnly = true;
            dataGridAnime.RowHeadersVisible = false;
            dataGridAnime.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAnime.Size = new Size(259, 338);
            dataGridAnime.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(74, 103, 65);
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(lblTrailer);
            panel2.Controls.Add(panelVideo);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(259, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(541, 450);
            panel2.TabIndex = 1;
            // 
            // lblTrailer
            // 
            lblTrailer.AutoSize = true;
            lblTrailer.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTrailer.ForeColor = Color.White;
            lblTrailer.Location = new Point(20, 15);
            lblTrailer.Name = "lblTrailer";
            lblTrailer.Size = new Size(142, 18);
            lblTrailer.TabIndex = 3;
            lblTrailer.Text = "Trailer del Anime";
            // 
            // panelVideo
            // 
            panelVideo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelVideo.BackColor = Color.DarkGreen;
            panelVideo.Location = new Point(0, 44);
            panelVideo.Name = "panelVideo";
            panelVideo.Size = new Size(541, 338);
            panelVideo.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom;
            btnExit.BackColor = Color.White;
            btnExit.Cursor = Cursors.Hand;
            btnExit.FlatAppearance.BorderColor = Color.Black;
            btnExit.FlatAppearance.MouseDownBackColor = Color.Green;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(191, 406);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(217, 26);
            btnExit.TabIndex = 5;
            btnExit.Text = "&Cerrar Ventana";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // TrailersWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TrailersWindow";
            Text = "TrailersWindow";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAnime).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridAnime;
        private Panel panelVideo;
        private Button btnSelect;
        private Label lblSeleccion;
        private Label lblTrailer;
        private Button btnExit;
    }
}