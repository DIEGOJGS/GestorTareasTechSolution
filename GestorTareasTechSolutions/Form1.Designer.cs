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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 35);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
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
            label2.Size = new Size(72, 15);
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
            label3.Size = new Size(73, 15);
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
            label4.Size = new Size(72, 15);
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
            btnRegistrar.Location = new Point(77, 357);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(144, 63);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar Tarea";
            btnRegistrar.UseVisualStyleBackColor = true;
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
            groupBox1.Location = new Point(28, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 426);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de Tarea";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblConteoHistorial);
            groupBox2.Controls.Add(lblConteoPendientes);
            groupBox2.Controls.Add(btnEspiar);
            groupBox2.Controls.Add(lstHistorial);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(lstPendientes);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnProcesar);
            groupBox2.Location = new Point(327, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(248, 426);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gestión y Visualización";
            // 
            // lblConteoHistorial
            // 
            lblConteoHistorial.AutoSize = true;
            lblConteoHistorial.Location = new Point(165, 248);
            lblConteoHistorial.Name = "lblConteoHistorial";
            lblConteoHistorial.Size = new Size(21, 15);
            lblConteoHistorial.TabIndex = 7;
            lblConteoHistorial.Text = "(0)";
            // 
            // lblConteoPendientes
            // 
            lblConteoPendientes.AutoSize = true;
            lblConteoPendientes.Location = new Point(160, 92);
            lblConteoPendientes.Name = "lblConteoPendientes";
            lblConteoPendientes.Size = new Size(21, 15);
            lblConteoPendientes.TabIndex = 6;
            lblConteoPendientes.Text = "(0)";
            // 
            // btnEspiar
            // 
            btnEspiar.Location = new Point(6, 66);
            btnEspiar.Name = "btnEspiar";
            btnEspiar.Size = new Size(227, 23);
            btnEspiar.TabIndex = 5;
            btnEspiar.Text = "Ver Próximo";
            btnEspiar.UseVisualStyleBackColor = true;
            btnEspiar.Click += btnEspiar_Click;
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 15;
            lstHistorial.Items.AddRange(new object[] { "..." });
            lstHistorial.Location = new Point(6, 267);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(226, 139);
            lstHistorial.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 249);
            label6.Name = "label6";
            label6.Size = new Size(162, 15);
            label6.TabIndex = 3;
            label6.Text = "Historial de Tareas Atendidas:";
            // 
            // lstPendientes
            // 
            lstPendientes.FormattingEnabled = true;
            lstPendientes.ItemHeight = 15;
            lstPendientes.Items.AddRange(new object[] { "...." });
            lstPendientes.Location = new Point(6, 110);
            lstPendientes.Name = "lstPendientes";
            lstPendientes.Size = new Size(226, 124);
            lstPendientes.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 92);
            label5.Name = "label5";
            label5.Size = new Size(155, 15);
            label5.TabIndex = 1;
            label5.Text = "Tareas Pendientes (En Cola):";
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(6, 22);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(226, 40);
            btnProcesar.TabIndex = 0;
            btnProcesar.Text = "Procesar Siguiente Tarea";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // btnVerReadme
            // 
            btnVerReadme.Location = new Point(600, 56);
            btnVerReadme.Name = "btnVerReadme";
            btnVerReadme.Size = new Size(75, 340);
            btnVerReadme.TabIndex = 11;
            btnVerReadme.Text = "README";
            btnVerReadme.UseVisualStyleBackColor = true;
            btnVerReadme.Click += btnVerReadme_Click;
            // 
            // btnGitHub
            // 
            btnGitHub.Location = new Point(697, 118);
            btnGitHub.Name = "btnGitHub";
            btnGitHub.Size = new Size(75, 245);
            btnGitHub.TabIndex = 12;
            btnGitHub.Text = "Ver en GitHub";
            btnGitHub.UseVisualStyleBackColor = true;
            btnGitHub.Click += btnGitHub_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGitHub);
            Controls.Add(btnVerReadme);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
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
    }
}
