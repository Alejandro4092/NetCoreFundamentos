namespace NetCoreFundamentos
{
    partial class Form12ColeccionNumeros
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
            lstNumeros = new ListBox();
            btnGenerarNumeros = new Button();
            btnMostrarDatos = new Button();
            label2 = new Label();
            txtSuma = new TextBox();
            txtPares = new TextBox();
            txtImpares = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 35);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Numeros";
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(68, 71);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(120, 169);
            lstNumeros.TabIndex = 1;
            // 
            // btnGenerarNumeros
            // 
            btnGenerarNumeros.Location = new Point(496, 71);
            btnGenerarNumeros.Name = "btnGenerarNumeros";
            btnGenerarNumeros.Size = new Size(155, 50);
            btnGenerarNumeros.TabIndex = 2;
            btnGenerarNumeros.Text = "Generar Numeros";
            btnGenerarNumeros.UseVisualStyleBackColor = true;
            btnGenerarNumeros.Click += btnGenerarNumeros_Click;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(496, 127);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(155, 50);
            btnMostrarDatos.TabIndex = 3;
            btnMostrarDatos.Text = "Mostrar Datos";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(442, 221);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Suma:";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(535, 213);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 5;
            // 
            // txtPares
            // 
            txtPares.Location = new Point(535, 260);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(100, 23);
            txtPares.TabIndex = 6;
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(535, 311);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(100, 23);
            txtImpares.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(442, 263);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 8;
            label3.Text = "Pares:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(442, 314);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 9;
            label4.Text = "Impares:";
            // 
            // Form12ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtImpares);
            Controls.Add(txtPares);
            Controls.Add(txtSuma);
            Controls.Add(label2);
            Controls.Add(btnMostrarDatos);
            Controls.Add(btnGenerarNumeros);
            Controls.Add(lstNumeros);
            Controls.Add(label1);
            Name = "Form12ColeccionNumeros";
            Text = "Form12ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstNumeros;
        private Button btnGenerarNumeros;
        private Button btnMostrarDatos;
        private Label label2;
        private TextBox txtSuma;
        private TextBox txtPares;
        private TextBox txtImpares;
        private Label label3;
        private Label label4;
    }
}