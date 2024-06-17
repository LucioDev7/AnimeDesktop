namespace DesktopAnime
{
    partial class DatosUsersWindow
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
            panelGrilla = new Panel();
            btnExit = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            dataGridUser = new DataGridView();
            panelAgregarEditar = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            txtRol = new TextBox();
            txtEmail = new TextBox();
            lblNuevoAnime = new Label();
            btnAgregarEditar = new Button();
            panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).BeginInit();
            panelAgregarEditar.SuspendLayout();
            SuspendLayout();
            // 
            // panelGrilla
            // 
            panelGrilla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelGrilla.BackColor = Color.FromArgb(74, 103, 65);
            panelGrilla.Controls.Add(btnExit);
            panelGrilla.Controls.Add(btnModificar);
            panelGrilla.Controls.Add(btnEliminar);
            panelGrilla.Controls.Add(label1);
            panelGrilla.Controls.Add(dataGridUser);
            panelGrilla.Location = new Point(0, 0);
            panelGrilla.Name = "panelGrilla";
            panelGrilla.Size = new Size(461, 450);
            panelGrilla.TabIndex = 1;
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
            btnExit.Location = new Point(297, 410);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 26);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exi&t";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Bottom;
            btnModificar.BackColor = Color.White;
            btnModificar.Cursor = Cursors.Hand;
            btnModificar.FlatAppearance.BorderColor = Color.Black;
            btnModificar.FlatAppearance.MouseDownBackColor = Color.Green;
            btnModificar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(148, 410);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(96, 26);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "&Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom;
            btnEliminar.BackColor = Color.White;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.Black;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.Green;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.Black;
            btnEliminar.Location = new Point(12, 410);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 26);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(166, 18);
            label1.TabIndex = 1;
            label1.Text = "Listado de Usuarios";
            // 
            // dataGridUser
            // 
            dataGridUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUser.Location = new Point(0, 62);
            dataGridUser.Name = "dataGridUser";
            dataGridUser.ReadOnly = true;
            dataGridUser.RowHeadersVisible = false;
            dataGridUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridUser.Size = new Size(410, 328);
            dataGridUser.TabIndex = 0;
            // 
            // panelAgregarEditar
            // 
            panelAgregarEditar.BackColor = Color.FromArgb(63, 90, 54);
            panelAgregarEditar.Controls.Add(label5);
            panelAgregarEditar.Controls.Add(label4);
            panelAgregarEditar.Controls.Add(label3);
            panelAgregarEditar.Controls.Add(label2);
            panelAgregarEditar.Controls.Add(txtUsuario);
            panelAgregarEditar.Controls.Add(txtContraseña);
            panelAgregarEditar.Controls.Add(txtRol);
            panelAgregarEditar.Controls.Add(txtEmail);
            panelAgregarEditar.Controls.Add(lblNuevoAnime);
            panelAgregarEditar.Controls.Add(btnAgregarEditar);
            panelAgregarEditar.Dock = DockStyle.Right;
            panelAgregarEditar.Location = new Point(408, 0);
            panelAgregarEditar.Name = "panelAgregarEditar";
            panelAgregarEditar.Size = new Size(392, 450);
            panelAgregarEditar.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 245);
            label5.Name = "label5";
            label5.Size = new Size(30, 16);
            label5.TabIndex = 17;
            label5.Text = "Rol:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 216);
            label4.Name = "label4";
            label4.Size = new Size(77, 16);
            label4.TabIndex = 16;
            label4.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 187);
            label3.Name = "label3";
            label3.Size = new Size(55, 16);
            label3.TabIndex = 15;
            label3.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 158);
            label2.Name = "label2";
            label2.Size = new Size(44, 16);
            label2.TabIndex = 14;
            label2.Text = "Email:";
            // 
            // txtUsuario
            // 
            txtUsuario.Cursor = Cursors.IBeam;
            txtUsuario.Location = new Point(97, 185);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(283, 23);
            txtUsuario.TabIndex = 12;
            // 
            // txtContraseña
            // 
            txtContraseña.Cursor = Cursors.IBeam;
            txtContraseña.Location = new Point(97, 214);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(283, 23);
            txtContraseña.TabIndex = 11;
            // 
            // txtRol
            // 
            txtRol.Cursor = Cursors.IBeam;
            txtRol.Location = new Point(97, 243);
            txtRol.Name = "txtRol";
            txtRol.Size = new Size(283, 23);
            txtRol.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Location = new Point(97, 156);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(283, 23);
            txtEmail.TabIndex = 5;
            // 
            // lblNuevoAnime
            // 
            lblNuevoAnime.AutoSize = true;
            lblNuevoAnime.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNuevoAnime.ForeColor = Color.White;
            lblNuevoAnime.Location = new Point(24, 15);
            lblNuevoAnime.Name = "lblNuevoAnime";
            lblNuevoAnime.Size = new Size(193, 18);
            lblNuevoAnime.TabIndex = 4;
            lblNuevoAnime.Text = "Agregar nuevo Usuario";
            // 
            // btnAgregarEditar
            // 
            btnAgregarEditar.Anchor = AnchorStyles.Bottom;
            btnAgregarEditar.BackColor = Color.White;
            btnAgregarEditar.Cursor = Cursors.Hand;
            btnAgregarEditar.FlatAppearance.BorderColor = Color.Black;
            btnAgregarEditar.FlatAppearance.MouseDownBackColor = Color.Green;
            btnAgregarEditar.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAgregarEditar.FlatStyle = FlatStyle.Flat;
            btnAgregarEditar.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAgregarEditar.ForeColor = Color.Black;
            btnAgregarEditar.Location = new Point(140, 410);
            btnAgregarEditar.Name = "btnAgregarEditar";
            btnAgregarEditar.Size = new Size(157, 26);
            btnAgregarEditar.TabIndex = 4;
            btnAgregarEditar.Text = "&Agregar";
            btnAgregarEditar.UseVisualStyleBackColor = false;
            btnAgregarEditar.Click += btnAgregarEditar_Click;
            // 
            // DatosUsersWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panelAgregarEditar);
            Controls.Add(panelGrilla);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DatosUsersWindow";
            Text = "DatosUsersWindow";
            panelGrilla.ResumeLayout(false);
            panelGrilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridUser).EndInit();
            panelAgregarEditar.ResumeLayout(false);
            panelAgregarEditar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGrilla;
        private Panel panelAgregarEditar;
        private DataGridView dataGridUser;
        private Button btnEliminar;
        private Label label1;
        private Button btnModificar;
        private Label lblNuevoAnime;
        private Button btnAgregarEditar;
        private TextBox txtEmail;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private TextBox txtRol;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnExit;
    }
}