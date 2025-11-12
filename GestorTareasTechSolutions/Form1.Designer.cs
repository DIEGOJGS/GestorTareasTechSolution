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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            cmbPrioridad = new ComboBox();
            label4 = new Label();
            txtDescripcion = new TextBox();
            btnRegistrar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblConteoHistorial = new Label();
            lblConteoPendientes = new Label();
            btnEspiar = new Button();
            lstHistorial = new ListBox();
            label6 = new Label();
            lstPendientes = new ListBox();
            label5 = new Label();
            btnProcesar = new Button();
            btnVerReadme = new Button();
            btnGitHub = new Button();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 35);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "ID                : ";
            // 
            // txtId
            // 
            txtId.Location = new Point(84, 30);
            txtId.Name = "txtId";
            txtId.Size = new Size(191, 23);
            txtId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 80);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre     : ";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(84, 77);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 133);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 4;
            label3.Text = "Prioridad    : ";
            // 
            // cmbPrioridad
            // 
            cmbPrioridad.FormattingEnabled = true;
            cmbPrioridad.Items.AddRange(new object[] { "Alta", "Media", "Baja" });
            cmbPrioridad.Location = new Point(84, 130);
            cmbPrioridad.Name = "cmbPrioridad";
            cmbPrioridad.Size = new Size(191, 23);
            cmbPrioridad.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 177);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 6;
            label4.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(8, 204);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(267, 147);
            txtDescripcion.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(150, 0, 255);
            btnRegistrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = SystemColors.Control;
            btnRegistrar.Location = new Point(77, 357);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(144, 63);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar Tarea";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbPrioridad);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 426);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de Tarea";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(lblConteoHistorial);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(lblConteoPendientes);
            groupBox2.Controls.Add(btnVerReadme);
            groupBox2.Controls.Add(btnEspiar);
            groupBox2.Controls.Add(lstHistorial);
            groupBox2.Controls.Add(btnGitHub);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(lstPendientes);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnProcesar);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(311, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(477, 426);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gestión y Visualización";
            // 
            // lblConteoHistorial
            // 
            lblConteoHistorial.AutoSize = true;
            lblConteoHistorial.Location = new Point(409, 16);
            lblConteoHistorial.Name = "lblConteoHistorial";
            lblConteoHistorial.Size = new Size(22, 15);
            lblConteoHistorial.TabIndex = 7;
            lblConteoHistorial.Text = "(0)";
            // 
            // lblConteoPendientes
            // 
            lblConteoPendientes.AutoSize = true;
            lblConteoPendientes.Location = new Point(160, 17);
            lblConteoPendientes.Name = "lblConteoPendientes";
            lblConteoPendientes.Size = new Size(22, 15);
            lblConteoPendientes.TabIndex = 6;
            lblConteoPendientes.Text = "(0)";
            // 
            // btnEspiar
            // 
            btnEspiar.BackColor = Color.FromArgb(150, 0, 255);
            btnEspiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEspiar.ForeColor = SystemColors.Control;
            btnEspiar.Location = new Point(4, 348);
            btnEspiar.Name = "btnEspiar";
            btnEspiar.Size = new Size(227, 32);
            btnEspiar.TabIndex = 5;
            btnEspiar.Text = "Ver Próximo";
            btnEspiar.UseVisualStyleBackColor = false;
            btnEspiar.Click += btnEspiar_Click;
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 15;
            lstHistorial.Items.AddRange(new object[] { "..." });
            lstHistorial.Location = new Point(245, 34);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(226, 304);
            lstHistorial.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 17);
            label6.Name = "label6";
            label6.Size = new Size(169, 15);
            label6.TabIndex = 3;
            label6.Text = "Historial de Tareas Atendidas:";
            // 
            // lstPendientes
            // 
            lstPendientes.FormattingEnabled = true;
            lstPendientes.ItemHeight = 15;
            lstPendientes.Items.AddRange(new object[] { "...." });
            lstPendientes.Location = new Point(6, 35);
            lstPendientes.Name = "lstPendientes";
            lstPendientes.Size = new Size(226, 304);
            lstPendientes.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 17);
            label5.Name = "label5";
            label5.Size = new Size(160, 15);
            label5.TabIndex = 1;
            label5.Text = "Tareas Pendientes (En Cola):";
            // 
            // btnProcesar
            // 
            btnProcesar.BackColor = Color.FromArgb(150, 0, 255);
            btnProcesar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnProcesar.ForeColor = SystemColors.Control;
            btnProcesar.Location = new Point(5, 386);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(226, 32);
            btnProcesar.TabIndex = 0;
            btnProcesar.Text = "Procesar Siguiente Tarea";
            btnProcesar.UseVisualStyleBackColor = false;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // btnVerReadme
            // 
            btnVerReadme.BackColor = Color.FromArgb(150, 0, 255);
            btnVerReadme.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVerReadme.ForeColor = SystemColors.Control;
            btnVerReadme.Location = new Point(359, 382);
            btnVerReadme.Name = "btnVerReadme";
            btnVerReadme.Size = new Size(114, 36);
            btnVerReadme.TabIndex = 11;
            btnVerReadme.Text = "README";
            btnVerReadme.UseVisualStyleBackColor = false;
            btnVerReadme.Click += btnVerReadme_Click;
            // 
            // btnGitHub
            // 
            btnGitHub.BackColor = Color.FromArgb(150, 0, 255);
            btnGitHub.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGitHub.ForeColor = SystemColors.Control;
            btnGitHub.Location = new Point(244, 382);
            btnGitHub.Name = "btnGitHub";
            btnGitHub.Size = new Size(114, 36);
            btnGitHub.TabIndex = 12;
            btnGitHub.Text = "Ver en GitHub";
            btnGitHub.UseVisualStyleBackColor = false;
            btnGitHub.Click += btnGitHub_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(251, 9);
            label7.Name = "label7";
            label7.Size = new Size(293, 47);
            label7.TabIndex = 13;
            label7.Text = "Gestor de Tareas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 69);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(254, 348);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(378, 348);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(75, 33);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 184, 24);
            ClientSize = new Size(800, 531);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private ComboBox cmbPrioridad;
        private Label label4;
        private TextBox txtDescripcion;
        private Button btnRegistrar;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox lstHistorial;
        private Label label6;
        private ListBox lstPendientes;
        private Label label5;
        private Button btnProcesar;
        private Button btnVerReadme;
        private Button btnEspiar;
        private Label lblConteoHistorial;
        private Label lblConteoPendientes;
        private Button btnGitHub;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
