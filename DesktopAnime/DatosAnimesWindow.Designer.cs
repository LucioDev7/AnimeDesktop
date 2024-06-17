namespace DesktopAnime
{
    partial class DatosAnimesWindow
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
            dataGridAnime = new DataGridView();
            panelAgregarEditar = new Panel();
            nudDuracion = new NumericUpDown();
            label10 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTrailer = new TextBox();
            txtTipo = new TextBox();
            txtGenero = new TextBox();
            txtPortada = new TextBox();
            txtSinopsis = new TextBox();
            txtCapitulos = new TextBox();
            txtUltimoCap = new TextBox();
            txtNombre = new TextBox();
            lblNuevoAnime = new Label();
            btnAgregarEditar = new Button();
            panelGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAnime).BeginInit();
            panelAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuracion).BeginInit();
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
            panelGrilla.Controls.Add(dataGridAnime);
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
            btnExit.Location = new Point(316, 410);
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
            btnModificar.Location = new Point(177, 410);
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
            btnEliminar.Location = new Point(51, 410);
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
            label1.Size = new Size(154, 18);
            label1.TabIndex = 1;
            label1.Text = "Listado de Animes";
            // 
            // dataGridAnime
            // 
            dataGridAnime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridAnime.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAnime.Location = new Point(0, 62);
            dataGridAnime.Name = "dataGridAnime";
            dataGridAnime.ReadOnly = true;
            dataGridAnime.RowHeadersVisible = false;
            dataGridAnime.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAnime.Size = new Size(461, 328);
            dataGridAnime.TabIndex = 0;
            // 
            // panelAgregarEditar
            // 
            panelAgregarEditar.BackColor = Color.FromArgb(63, 90, 54);
            panelAgregarEditar.Controls.Add(nudDuracion);
            panelAgregarEditar.Controls.Add(label10);
            panelAgregarEditar.Controls.Add(label6);
            panelAgregarEditar.Controls.Add(label7);
            panelAgregarEditar.Controls.Add(label8);
            panelAgregarEditar.Controls.Add(label9);
            panelAgregarEditar.Controls.Add(label5);
            panelAgregarEditar.Controls.Add(label4);
            panelAgregarEditar.Controls.Add(label3);
            panelAgregarEditar.Controls.Add(label2);
            panelAgregarEditar.Controls.Add(txtTrailer);
            panelAgregarEditar.Controls.Add(txtTipo);
            panelAgregarEditar.Controls.Add(txtGenero);
            panelAgregarEditar.Controls.Add(txtPortada);
            panelAgregarEditar.Controls.Add(txtSinopsis);
            panelAgregarEditar.Controls.Add(txtCapitulos);
            panelAgregarEditar.Controls.Add(txtUltimoCap);
            panelAgregarEditar.Controls.Add(txtNombre);
            panelAgregarEditar.Controls.Add(lblNuevoAnime);
            panelAgregarEditar.Controls.Add(btnAgregarEditar);
            panelAgregarEditar.Dock = DockStyle.Right;
            panelAgregarEditar.Location = new Point(459, 0);
            panelAgregarEditar.Name = "panelAgregarEditar";
            panelAgregarEditar.Size = new Size(341, 450);
            panelAgregarEditar.TabIndex = 2;
            // 
            // nudDuracion
            // 
            nudDuracion.Cursor = Cursors.Hand;
            nudDuracion.Font = new Font("Arial", 10F);
            nudDuracion.Location = new Point(97, 236);
            nudDuracion.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudDuracion.Name = "nudDuracion";
            nudDuracion.Size = new Size(232, 23);
            nudDuracion.TabIndex = 23;
            nudDuracion.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(3, 294);
            label10.Name = "label10";
            label10.Size = new Size(61, 16);
            label10.TabIndex = 22;
            label10.Text = "Sinopsis:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 267);
            label6.Name = "label6";
            label6.Size = new Size(65, 16);
            label6.TabIndex = 21;
            label6.Text = "Capítulos:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 238);
            label7.Name = "label7";
            label7.Size = new Size(62, 16);
            label7.TabIndex = 20;
            label7.Text = "Duración:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(3, 209);
            label8.Name = "label8";
            label8.Size = new Size(95, 16);
            label8.TabIndex = 19;
            label8.Text = "Url Ultimo Cap:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(3, 180);
            label9.Name = "label9";
            label9.Size = new Size(66, 16);
            label9.TabIndex = 18;
            label9.Text = "Url Trailer:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 151);
            label5.Name = "label5";
            label5.Size = new Size(76, 16);
            label5.TabIndex = 17;
            label5.Text = "Url Portada:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 122);
            label4.Name = "label4";
            label4.Size = new Size(53, 16);
            label4.TabIndex = 16;
            label4.Text = "Genero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 93);
            label3.Name = "label3";
            label3.Size = new Size(35, 16);
            label3.TabIndex = 15;
            label3.Text = "Tipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 64);
            label2.Name = "label2";
            label2.Size = new Size(56, 16);
            label2.TabIndex = 14;
            label2.Text = "Nombre:";
            // 
            // txtTrailer
            // 
            txtTrailer.Cursor = Cursors.IBeam;
            txtTrailer.Location = new Point(97, 178);
            txtTrailer.Name = "txtTrailer";
            txtTrailer.Size = new Size(232, 23);
            txtTrailer.TabIndex = 13;
            // 
            // txtTipo
            // 
            txtTipo.Cursor = Cursors.IBeam;
            txtTipo.Location = new Point(97, 91);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(232, 23);
            txtTipo.TabIndex = 12;
            // 
            // txtGenero
            // 
            txtGenero.Cursor = Cursors.IBeam;
            txtGenero.Location = new Point(97, 120);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(232, 23);
            txtGenero.TabIndex = 11;
            // 
            // txtPortada
            // 
            txtPortada.Cursor = Cursors.IBeam;
            txtPortada.Location = new Point(97, 149);
            txtPortada.Name = "txtPortada";
            txtPortada.Size = new Size(232, 23);
            txtPortada.TabIndex = 10;
            // 
            // txtSinopsis
            // 
            txtSinopsis.Cursor = Cursors.IBeam;
            txtSinopsis.Location = new Point(97, 294);
            txtSinopsis.Multiline = true;
            txtSinopsis.Name = "txtSinopsis";
            txtSinopsis.Size = new Size(232, 96);
            txtSinopsis.TabIndex = 9;
            // 
            // txtCapitulos
            // 
            txtCapitulos.Cursor = Cursors.IBeam;
            txtCapitulos.Location = new Point(97, 265);
            txtCapitulos.Name = "txtCapitulos";
            txtCapitulos.Size = new Size(232, 23);
            txtCapitulos.TabIndex = 8;
            // 
            // txtUltimoCap
            // 
            txtUltimoCap.Cursor = Cursors.IBeam;
            txtUltimoCap.Location = new Point(97, 207);
            txtUltimoCap.Name = "txtUltimoCap";
            txtUltimoCap.Size = new Size(232, 23);
            txtUltimoCap.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(97, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 23);
            txtNombre.TabIndex = 5;
            // 
            // lblNuevoAnime
            // 
            lblNuevoAnime.AutoSize = true;
            lblNuevoAnime.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNuevoAnime.ForeColor = Color.White;
            lblNuevoAnime.Location = new Point(24, 15);
            lblNuevoAnime.Name = "lblNuevoAnime";
            lblNuevoAnime.Size = new Size(179, 18);
            lblNuevoAnime.TabIndex = 4;
            lblNuevoAnime.Text = "Agregar nuevo anime";
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
            btnAgregarEditar.Location = new Point(114, 410);
            btnAgregarEditar.Name = "btnAgregarEditar";
            btnAgregarEditar.Size = new Size(157, 26);
            btnAgregarEditar.TabIndex = 4;
            btnAgregarEditar.Text = "&Agregar";
            btnAgregarEditar.UseVisualStyleBackColor = false;
            btnAgregarEditar.Click += btnAgregarEditar_Click;
            // 
            // DatosWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panelAgregarEditar);
            Controls.Add(panelGrilla);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DatosAnimesWindow";
            Text = "DatosAnimesWindow";
            panelGrilla.ResumeLayout(false);
            panelGrilla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridAnime).EndInit();
            panelAgregarEditar.ResumeLayout(false);
            panelAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDuracion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGrilla;
        private Panel panelAgregarEditar;
        private DataGridView dataGridAnime;
        private Button btnEliminar;
        private Label label1;
        private Button btnModificar;
        private Label lblNuevoAnime;
        private Button btnAgregarEditar;
        private TextBox txtNombre;
        private TextBox txtTrailer;
        private TextBox txtTipo;
        private TextBox txtGenero;
        private TextBox txtPortada;
        private TextBox txtSinopsis;
        private TextBox txtCapitulos;
        private TextBox txtUltimoCap;
        private Label label10;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown nudDuracion;
        private Button btnExit;
    }
}