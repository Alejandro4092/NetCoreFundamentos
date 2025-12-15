namespace NetCoreFundamentos
{
    partial class Form05Char
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
            txtLetras = new TextBox();
            txtNumeros = new TextBox();
            txtSimbolos = new TextBox();
            txtPuntuacion = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnRun = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 28);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Letras";
            // 
            // txtLetras
            // 
            txtLetras.Location = new Point(50, 46);
            txtLetras.Multiline = true;
            txtLetras.Name = "txtLetras";
            txtLetras.Size = new Size(276, 125);
            txtLetras.TabIndex = 1;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(430, 46);
            txtNumeros.Multiline = true;
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(276, 125);
            txtNumeros.TabIndex = 2;
            // 
            // txtSimbolos
            // 
            txtSimbolos.Location = new Point(50, 236);
            txtSimbolos.Multiline = true;
            txtSimbolos.Name = "txtSimbolos";
            txtSimbolos.Size = new Size(273, 125);
            txtSimbolos.TabIndex = 3;
            // 
            // txtPuntuacion
            // 
            txtPuntuacion.Location = new Point(430, 236);
            txtPuntuacion.Multiline = true;
            txtPuntuacion.Name = "txtPuntuacion";
            txtPuntuacion.Size = new Size(276, 125);
            txtPuntuacion.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(440, 28);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 5;
            label2.Text = "Numeros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 211);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 6;
            label3.Text = "Simbolos";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 211);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 7;
            label4.Text = "Puntuacion";
            label4.Click += label4_Click;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(299, 377);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(147, 61);
            btnRun.TabIndex = 8;
            btnRun.Text = "Run ASCII";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // Form05Char
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRun);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPuntuacion);
            Controls.Add(txtSimbolos);
            Controls.Add(txtNumeros);
            Controls.Add(txtLetras);
            Controls.Add(label1);
            Name = "Form05Char";
            Text = "Form05Char";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLetras;
        private TextBox txtNumeros;
        private TextBox txtSimbolos;
        private TextBox txtPuntuacion;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnRun;
    }
}