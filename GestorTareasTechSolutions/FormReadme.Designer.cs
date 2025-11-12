namespace GestorTareasTechSolutions
{
    partial class FormReadme
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
            txtContenido = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // txtContenido
            // 
            txtContenido.Dock = DockStyle.Fill;
            txtContenido.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContenido.Location = new Point(0, 0);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.ReadOnly = true;
            txtContenido.ScrollBars = ScrollBars.Vertical;
            txtContenido.Size = new Size(800, 486);
            txtContenido.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.Dock = DockStyle.Bottom;
            btnGuardar.Location = new Point(0, 463);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(800, 23);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar como...";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FormReadme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(btnGuardar);
            Controls.Add(txtContenido);
            Name = "FormReadme";
            Text = "Form2";
            Load += FormReadme_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContenido;
        private Button btnGuardar;
    }
}