namespace NetCoreFundamentos
{
    partial class Form07SumarString
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
            btnSumar = new Button();
            label1 = new Label();
            txtNumero = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(262, 188);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(75, 23);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 89);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 1;
            label1.Text = "Introduzaca un numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(251, 135);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(282, 242);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(38, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "label2";
            // 
            // Form07SumarString
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Controls.Add(btnSumar);
            Name = "Form07SumarString";
            Text = "Form07SumarString";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumar;
        private Label label1;
        private TextBox txtNumero;
        private Label lblResultado;
    }
}