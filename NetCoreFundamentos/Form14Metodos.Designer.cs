namespace NetCoreFundamentos
{
    partial class Form14Metodos
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
            btnDobleValor = new Button();
            txtNumero = new TextBox();
            lblResultado = new Label();
            btnDobleReferencia = new Button();
            btnObjetoReferencia = new Button();
            label2 = new Label();
            lblRaton = new Label();
            label1 = new Label();
            txtSoloNumeros = new TextBox();
            label3 = new Label();
            txtSoloLetras = new TextBox();
            SuspendLayout();
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(41, 203);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(106, 23);
            btnDobleValor.TabIndex = 0;
            btnDobleValor.Text = "Doble Valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(50, 110);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(50, 155);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(38, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "label1";
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(41, 244);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(127, 28);
            btnDobleReferencia.TabIndex = 3;
            btnDobleReferencia.Text = "Doble Referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(44, 294);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(106, 27);
            btnObjetoReferencia.TabIndex = 4;
            btnObjetoReferencia.Text = "Objeto referencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 73);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Número";
            // 
            // lblRaton
            // 
            lblRaton.BackColor = Color.Red;
            lblRaton.Location = new Point(277, 187);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(300, 191);
            lblRaton.TabIndex = 6;
            lblRaton.Text = "label1";
            lblRaton.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 45);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 7;
            label1.Text = "Solo Números";
            // 
            // txtSoloNumeros
            // 
            txtSoloNumeros.Location = new Point(383, 42);
            txtSoloNumeros.Name = "txtSoloNumeros";
            txtSoloNumeros.Size = new Size(211, 23);
            txtSoloNumeros.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(277, 97);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 9;
            label3.Text = "Solo letras";
            label3.Click += label3_Click;
            // 
            // txtSoloLetras
            // 
            txtSoloLetras.Location = new Point(383, 89);
            txtSoloLetras.Name = "txtSoloLetras";
            txtSoloLetras.Size = new Size(211, 23);
            txtSoloLetras.TabIndex = 10;
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 567);
            Controls.Add(txtSoloLetras);
            Controls.Add(label3);
            Controls.Add(txtSoloNumeros);
            Controls.Add(label1);
            Controls.Add(lblRaton);
            Controls.Add(label2);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(btnDobleReferencia);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero);
            Controls.Add(btnDobleValor);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDobleValor;
        private TextBox txtNumero;
        private Label lblResultado;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
        private Label label2;
        private Label lblRaton;
        private Label label1;
        private TextBox txtSoloNumeros;
        private Label label3;
        private TextBox txtSoloLetras;
    }
}