namespace GestorTareasTechSolutions
{
    partial class Form1
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
            Button btnRegistrar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnVerReadme = new Button();
            btnGitHub = new Button();
            lblTitulo = new Label();
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            cmbPrioridad = new ComboBox();
            label1 = new Label();
            txtDescripcion = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            lblConteoPendientes = new Label();
            btnEspiar = new Button();
            lstPendientes = new ListBox();
            label5 = new Label();
            btnProcesar = new Button();
            label6 = new Label();
            lstHistorial = new ListBox();
            btnSalir = new Button();
            lblConteoHistorial = new Label();
            panelContenedor = new Panel();
            groupBox3 = new GroupBox();
            btnRegistrar = new Button();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panelContenedor.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(39, 174, 96);
            btnRegistrar.Cursor = Cursors.Hand;
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(26, 133, 57);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(20, 480);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(360, 45);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar Tarea";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVerReadme
            // 
            btnVerReadme.BackColor = Color.FromArgb(150, 0, 255);
            btnVerReadme.Cursor = Cursors.Hand;
            btnVerReadme.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVerReadme.ForeColor = SystemColors.Control;
            btnVerReadme.Image = (Image)resources.GetObject("btnVerReadme.Image");
            btnVerReadme.Location = new Point(1313, 0);
            btnVerReadme.Name = "btnVerReadme";
            btnVerReadme.Size = new Size(71, 82);
            btnVerReadme.TabIndex = 11;
            btnVerReadme.UseVisualStyleBackColor = false;
            btnVerReadme.Click += btnVerReadme_Click;
            // 
            // btnGitHub
            // 
            btnGitHub.BackColor = Color.FromArgb(150, 0, 255);
            btnGitHub.Cursor = Cursors.Hand;
            btnGitHub.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGitHub.ForeColor = SystemColors.Control;
            btnGitHub.Image = (Image)resources.GetObject("btnGitHub.Image");
            btnGitHub.Location = new Point(1230, 1);
            btnGitHub.Name = "btnGitHub";
            btnGitHub.Size = new Size(84, 79);
            btnGitHub.TabIndex = 12;
            btnGitHub.UseVisualStyleBackColor = false;
            btnGitHub.Click += btnGitHub_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.FromArgb(230, 126, 34);
            lblTitulo.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(120, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(310, 47);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Gestor de Tareas";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(230, 126, 34);
            panelHeader.Controls.Add(btnGitHub);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(btnVerReadme);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1384, 80);
            panelHeader.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 69);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(250, 250, 250);
            groupBox1.Controls.Add(cmbPrioridad);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(44, 62, 80);
            groupBox1.Location = new Point(20, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 600);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de Tarea";
            // 
            // cmbPrioridad
            // 
            cmbPrioridad.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            cmbPrioridad.FormattingEnabled = true;
            cmbPrioridad.Items.AddRange(new object[] { "Alta", "Media", "Baja" });
            cmbPrioridad.Location = new Point(20, 205);
            cmbPrioridad.Name = "cmbPrioridad";
            cmbPrioridad.Size = new Size(360, 29);
            cmbPrioridad.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(93, 109, 126);
            label1.Location = new Point(20, 40);
            label1.Name = "label1";
            label1.Size = new Size(22, 17);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtDescripcion.Location = new Point(20, 275);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(360, 185);
            txtDescripcion.TabIndex = 7;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtId.Location = new Point(20, 65);
            txtId.Name = "txtId";
            txtId.Size = new Size(360, 29);
            txtId.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(93, 109, 126);
            label4.Location = new Point(20, 250);
            label4.Name = "label4";
            label4.Size = new Size(80, 17);
            label4.TabIndex = 6;
            label4.Text = "Descripción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(93, 109, 126);
            label2.Location = new Point(20, 110);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 2;
            label2.Text = "Nombre ";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txtNombre.Location = new Point(20, 135);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(360, 29);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(93, 109, 126);
            label3.Location = new Point(20, 180);
            label3.Name = "label3";
            label3.Size = new Size(69, 17);
            label3.TabIndex = 4;
            label3.Text = "Prioridad ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(250, 250, 250);
            groupBox2.Controls.Add(lblConteoPendientes);
            groupBox2.Controls.Add(btnEspiar);
            groupBox2.Controls.Add(lstPendientes);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnProcesar);
            groupBox2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(44, 62, 80);
            groupBox2.Location = new Point(440, 20);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(420, 600);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tareas Pendientes";
            // 
            // lblConteoPendientes
            // 
            lblConteoPendientes.AutoSize = true;
            lblConteoPendientes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConteoPendientes.ForeColor = Color.FromArgb(93, 109, 126);
            lblConteoPendientes.Location = new Point(96, 26);
            lblConteoPendientes.Name = "lblConteoPendientes";
            lblConteoPendientes.Size = new Size(30, 20);
            lblConteoPendientes.TabIndex = 6;
            lblConteoPendientes.Text = "(0)";

            // 
            // btnEspiar
            // 
            btnEspiar.BackColor = Color.FromArgb(52, 152, 219);
            btnEspiar.Cursor = Cursors.Hand;
            btnEspiar.FlatAppearance.BorderSize = 0;
            btnEspiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(38, 115, 191);
            btnEspiar.FlatStyle = FlatStyle.Flat;
            btnEspiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEspiar.ForeColor = Color.White;
            btnEspiar.Location = new Point(20, 480);
            btnEspiar.Name = "btnEspiar";
            btnEspiar.Size = new Size(180, 45);
            btnEspiar.TabIndex = 5;
            btnEspiar.Text = "Ver Próximo";
            btnEspiar.UseVisualStyleBackColor = false;
            btnEspiar.Click += btnEspiar_Click;
            // 
            // lstPendientes
            // 
            lstPendientes.BackColor = Color.White;
            lstPendientes.BorderStyle = BorderStyle.FixedSingle;
            lstPendientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstPendientes.FormattingEnabled = true;
            lstPendientes.HorizontalScrollbar = true;
            lstPendientes.ItemHeight = 17;
            lstPendientes.Items.AddRange(new object[] { "...." });
            lstPendientes.Location = new Point(20, 50);
            lstPendientes.Name = "lstPendientes";
            lstPendientes.Size = new Size(380, 410);
            lstPendientes.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(93, 109, 126);
            label5.Location = new Point(19, 25);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 1;
            label5.Text = "(En Cola):";
            // 
            // btnProcesar
            // 
            btnProcesar.BackColor = Color.FromArgb(155, 89, 182);
            btnProcesar.Cursor = Cursors.Hand;
            btnProcesar.FlatAppearance.BorderSize = 0;
            btnProcesar.FlatAppearance.MouseOverBackColor = Color.FromArgb(115, 38, 153);
            btnProcesar.FlatStyle = FlatStyle.Flat;
            btnProcesar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnProcesar.ForeColor = Color.White;
            btnProcesar.Location = new Point(220, 480);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(180, 45);
            btnProcesar.TabIndex = 0;
            btnProcesar.Text = "Procesar Siguiente Tarea";
            btnProcesar.UseVisualStyleBackColor = false;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(93, 109, 126);
            label6.Location = new Point(20, 27);
            label6.Name = "label6";
            label6.Size = new Size(95, 21);
            label6.TabIndex = 3;
            label6.Text = "Atendidas:";
            // 
            // lstHistorial
            // 
            lstHistorial.BackColor = Color.White;
            lstHistorial.BorderStyle = BorderStyle.FixedSingle;
            lstHistorial.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstHistorial.FormattingEnabled = true;
            lstHistorial.HorizontalScrollbar = true;
            lstHistorial.ItemHeight = 17;
            lstHistorial.Items.AddRange(new object[] { "..." });
            lstHistorial.Location = new Point(20, 50);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(380, 410);
            lstHistorial.TabIndex = 4;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(231, 76, 60);
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(173, 57, 38);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(20, 480);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(380, 45);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblConteoHistorial
            // 
            lblConteoHistorial.AutoSize = true;
            lblConteoHistorial.ForeColor = Color.FromArgb(93, 109, 126);
            lblConteoHistorial.Location = new Point(105, 27);
            lblConteoHistorial.Name = "lblConteoHistorial";
            lblConteoHistorial.Size = new Size(34, 21);
            lblConteoHistorial.TabIndex = 7;
            lblConteoHistorial.Text = "(0)";
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(groupBox3);
            panelContenedor.Controls.Add(groupBox2);
            panelContenedor.Controls.Add(groupBox1);
            panelContenedor.Location = new Point(30, 110);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1340, 660);
            panelContenedor.TabIndex = 18;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(250, 250, 250);
            groupBox3.Controls.Add(lblConteoHistorial);
            groupBox3.Controls.Add(lstHistorial);
            groupBox3.Controls.Add(btnSalir);
            groupBox3.Controls.Add(label6);
            groupBox3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.FromArgb(44, 62, 80);
            groupBox3.Location = new Point(880, 20);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(420, 600);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Historial de Tareas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1384, 761);
            Controls.Add(panelHeader);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panelContenedor.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnVerReadme;
        private Button btnGitHub;
        private Label lblTitulo;
        private Panel panelHeader;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private ComboBox cmbPrioridad;
        private Label label1;
        private TextBox txtDescripcion;
        private TextBox txtId;
        private Label label4;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private GroupBox groupBox2;
        private Label lblConteoHistorial;
        private Button btnSalir;
        private Label lblConteoPendientes;
        private Button btnEspiar;
        private ListBox lstHistorial;
        private Label label6;
        private ListBox lstPendientes;
        private Label label5;
        private Button btnProcesar;
        private Panel panelContenedor;
        private GroupBox groupBox3;
    }
}
