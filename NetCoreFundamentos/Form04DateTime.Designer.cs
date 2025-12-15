namespace NetCoreFundamentos
{
    partial class Form04DateTime
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
            txtFecha = new TextBox();
            chkFormato = new CheckBox();
            label2 = new Label();
            rdbDias = new RadioButton();
            rdbMeses = new RadioButton();
            rdbAnyos = new RadioButton();
            label3 = new Label();
            txtIncremento = new TextBox();
            btnIncremento = new Button();
            txtFechaFinal = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 41);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha actual";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(76, 83);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(390, 23);
            txtFecha.TabIndex = 1;
            // 
            // chkFormato
            // 
            chkFormato.AutoSize = true;
            chkFormato.Location = new Point(85, 134);
            chkFormato.Name = "chkFormato";
            chkFormato.Size = new Size(119, 19);
            chkFormato.TabIndex = 2;
            chkFormato.Text = "Cambiar Formato";
            chkFormato.UseVisualStyleBackColor = true;
            chkFormato.CheckedChanged += chkFormato_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 253);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha final";
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(85, 159);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(47, 19);
            rdbDias.TabIndex = 4;
            rdbDias.TabStop = true;
            rdbDias.Text = "Dias";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Location = new Point(85, 184);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(58, 19);
            rdbMeses.TabIndex = 5;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbAnyos
            // 
            rdbAnyos.AutoSize = true;
            rdbAnyos.Location = new Point(85, 209);
            rdbAnyos.Name = "rdbAnyos";
            rdbAnyos.Size = new Size(52, 19);
            rdbAnyos.TabIndex = 6;
            rdbAnyos.TabStop = true;
            rdbAnyos.Text = "Años";
            rdbAnyos.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(325, 150);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 7;
            label3.Text = "Incremento";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(399, 147);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(79, 23);
            txtIncremento.TabIndex = 8;
            // 
            // btnIncremento
            // 
            btnIncremento.Location = new Point(325, 184);
            btnIncremento.Name = "btnIncremento";
            btnIncremento.Size = new Size(153, 26);
            btnIncremento.TabIndex = 9;
            btnIncremento.Text = "Incrementar";
            btnIncremento.UseVisualStyleBackColor = true;
            btnIncremento.Click += btnIncremento_Click;
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Location = new Point(85, 287);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(414, 23);
            txtFechaFinal.TabIndex = 10;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFechaFinal);
            Controls.Add(btnIncremento);
            Controls.Add(txtIncremento);
            Controls.Add(label3);
            Controls.Add(rdbAnyos);
            Controls.Add(rdbMeses);
            Controls.Add(rdbDias);
            Controls.Add(label2);
            Controls.Add(chkFormato);
            Controls.Add(txtFecha);
            Controls.Add(label1);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFecha;
        private CheckBox chkFormato;
        private Label label2;
        private RadioButton rdbDias;
        private RadioButton rdbMeses;
        private RadioButton rdbAnyos;
        private Label label3;
        private TextBox txtIncremento;
        private Button btnIncremento;
        private TextBox txtFechaFinal;
    }
}