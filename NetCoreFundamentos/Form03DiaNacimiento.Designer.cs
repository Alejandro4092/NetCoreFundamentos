namespace NetCoreFundamentos
{
    partial class Form03DiaNacimiento
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
            btnNacimiento = new Button();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAño = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblDia = new Label();
            SuspendLayout();
            // 
            // btnNacimiento
            // 
            btnNacimiento.Location = new Point(114, 248);
            btnNacimiento.Name = "btnNacimiento";
            btnNacimiento.Size = new Size(100, 49);
            btnNacimiento.TabIndex = 0;
            btnNacimiento.Text = "Mostrar Dia";
            btnNacimiento.UseVisualStyleBackColor = true;
            btnNacimiento.Click += btnNacimiento_Click;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(114, 45);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 1;
            txtDia.TextChanged += txtDia_TextChanged;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(114, 110);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 2;
            txtMes.TextChanged += txtMes_TextChanged;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(114, 162);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(100, 23);
            txtAño.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 50);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 4;
            label1.Text = "Dia";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 113);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 5;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 169);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 6;
            label3.Text = "Año";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(100, 332);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(0, 15);
            lblDia.TabIndex = 7;
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAño);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(btnNacimiento);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            Load += Form03DiaNacimiento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNacimiento;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAño;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblDia;
    }
}