namespace NetCoreFundamentos
{
    partial class Form22MascotasFiles
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
            label2 = new Label();
            label3 = new Label();
            txtMascota = new TextBox();
            label4 = new Label();
            lstMascotas = new ListBox();
            btnReadFile = new Button();
            btnNuevaMascota = new Button();
            btnWriteFile = new Button();
            txtRaza = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 57);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "mascota";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 118);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 218);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // txtMascota
            // 
            txtMascota.Location = new Point(76, 78);
            txtMascota.Name = "txtMascota";
            txtMascota.Size = new Size(100, 23);
            txtMascota.TabIndex = 3;
            txtMascota.TextChanged += txtMascota_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(445, 78);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(433, 96);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(187, 229);
            lstMascotas.TabIndex = 7;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(70, 230);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(122, 25);
            btnReadFile.TabIndex = 9;
            btnReadFile.Text = "leer file";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // btnNuevaMascota
            // 
            btnNuevaMascota.Location = new Point(70, 171);
            btnNuevaMascota.Name = "btnNuevaMascota";
            btnNuevaMascota.Size = new Size(113, 30);
            btnNuevaMascota.TabIndex = 10;
            btnNuevaMascota.Text = "Nueva mascota";
            btnNuevaMascota.UseVisualStyleBackColor = true;
            btnNuevaMascota.Click += btnNuevaMascota_Click;
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(70, 277);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(122, 26);
            btnWriteFile.TabIndex = 11;
            btnWriteFile.Text = "WriteFile";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_ClickAsync;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(76, 142);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 118);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 13;
            label5.Text = "raza";
            // 
            // Form22MascotasFiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txtRaza);
            Controls.Add(btnWriteFile);
            Controls.Add(btnNuevaMascota);
            Controls.Add(btnReadFile);
            Controls.Add(lstMascotas);
            Controls.Add(label4);
            Controls.Add(txtMascota);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form22MascotasFiles";
            Text = "Form22MascotasFiles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMascota;
        private Label label4;
        private ListBox lstMascotas;
        private Button btnReadFile;
        private Button btnNuevaMascota;
        private Button btnWriteFile;
        private TextBox txtRaza;
        private Label label5;
    }
}