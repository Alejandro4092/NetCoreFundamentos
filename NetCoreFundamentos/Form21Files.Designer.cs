namespace NetCoreFundamentos
{
    partial class Form21Files
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
            label1 = new Label();
            txtContenido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            btnNuevoNombre = new Button();
            btnLeerFile = new Button();
            btnWriteFile = new Button();
            label = new Label();
            lstNombres = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 41);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 0;
            label1.Text = "Contenido File";
            label1.Click += label1_Click;
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(54, 80);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(271, 240);
            txtContenido.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(475, 50);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(475, 80);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(148, 23);
            txtNombre.TabIndex = 3;
            // 
            // btnNuevoNombre
            // 
            btnNuevoNombre.Location = new Point(493, 133);
            btnNuevoNombre.Name = "btnNuevoNombre";
            btnNuevoNombre.Size = new Size(115, 36);
            btnNuevoNombre.TabIndex = 4;
            btnNuevoNombre.Text = "Nuevo nombre";
            btnNuevoNombre.UseVisualStyleBackColor = true;
            btnNuevoNombre.Click += btnNuevoNombre_Click;
            // 
            // btnLeerFile
            // 
            btnLeerFile.Location = new Point(493, 190);
            btnLeerFile.Name = "btnLeerFile";
            btnLeerFile.Size = new Size(115, 36);
            btnLeerFile.TabIndex = 5;
            btnLeerFile.Text = "Leer file";
            btnLeerFile.UseVisualStyleBackColor = true;
            btnLeerFile.Click += btnLeerFile_Click;
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(493, 254);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(115, 36);
            btnWriteFile.TabIndex = 6;
            btnWriteFile.Text = "Write file";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(758, 62);
            label.Name = "label";
            label.Size = new Size(56, 15);
            label.TabIndex = 7;
            label.Text = "Nombres";
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(758, 99);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(167, 214);
            lstNombres.TabIndex = 8;
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 487);
            Controls.Add(lstNombres);
            Controls.Add(label);
            Controls.Add(btnWriteFile);
            Controls.Add(btnLeerFile);
            Controls.Add(btnNuevoNombre);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtContenido);
            Controls.Add(label1);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtContenido;
        private Label label2;
        private TextBox txtNombre;
        private Button btnNuevoNombre;
        private Button btnLeerFile;
        private Button btnWriteFile;
        private Label label;
        private ListBox lstNombres;
    }
}