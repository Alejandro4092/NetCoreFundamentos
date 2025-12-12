namespace NetCoreFundamentos
{
    partial class Form02ColoresPosicion
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
            txtPosicionX = new TextBox();
            txtPosicionY = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCambiarPosicion = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtRojo = new TextBox();
            txtVerde = new TextBox();
            txtAzul = new TextBox();
            btnCambiarFondo = new Button();
            SuspendLayout();
            // 
            // txtPosicionX
            // 
            txtPosicionX.Location = new Point(263, 167);
            txtPosicionX.Name = "txtPosicionX";
            txtPosicionX.Size = new Size(100, 23);
            txtPosicionX.TabIndex = 0;
            // 
            // txtPosicionY
            // 
            txtPosicionY.Location = new Point(263, 260);
            txtPosicionY.Name = "txtPosicionY";
            txtPosicionY.Size = new Size(100, 23);
            txtPosicionY.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 123);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "Posicion X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 217);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "PosicionY";
            label2.Click += label2_Click;
            // 
            // btnCambiarPosicion
            // 
            btnCambiarPosicion.Location = new Point(263, 368);
            btnCambiarPosicion.Name = "btnCambiarPosicion";
            btnCambiarPosicion.Size = new Size(100, 71);
            btnCambiarPosicion.TabIndex = 5;
            btnCambiarPosicion.Text = "Cambiar posicion";
            btnCambiarPosicion.UseVisualStyleBackColor = true;
            btnCambiarPosicion.Click += btnCambiarPosicion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(545, 157);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 6;
            label3.Text = "Rojo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(545, 204);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Verde";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(545, 263);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 8;
            label5.Text = "Azul";
            label5.Click += label5_Click;
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(660, 155);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(100, 23);
            txtRojo.TabIndex = 9;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(660, 201);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(100, 23);
            txtVerde.TabIndex = 10;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(660, 260);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(100, 23);
            txtAzul.TabIndex = 11;
            // 
            // btnCambiarFondo
            // 
            btnCambiarFondo.Location = new Point(518, 328);
            btnCambiarFondo.Name = "btnCambiarFondo";
            btnCambiarFondo.Size = new Size(115, 64);
            btnCambiarFondo.TabIndex = 12;
            btnCambiarFondo.Text = "CambiarFondo";
            btnCambiarFondo.UseVisualStyleBackColor = true;
            btnCambiarFondo.Click += btnCambiarFondo_Click;
            // 
            // Form02ColoresPosicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 598);
            Controls.Add(btnCambiarFondo);
            Controls.Add(txtAzul);
            Controls.Add(txtVerde);
            Controls.Add(txtRojo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnCambiarPosicion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPosicionY);
            Controls.Add(txtPosicionX);
            Name = "Form02ColoresPosicion";
            Text = "Form02ColoresPosicion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPosicionX;
        private TextBox txtPosicionY;
        private Label label1;
        private Label label2;
        private Button btnCambiarPosicion;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private TextBox txtAzul;
        private Button btnCambiarFondo;
    }
}