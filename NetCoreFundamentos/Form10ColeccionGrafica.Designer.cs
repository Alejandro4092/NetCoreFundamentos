namespace NetCoreFundamentos
{
    partial class Form10ColeccionGrafica
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
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            label1 = new Label();
            txtElementos = new TextBox();
            lstElementos = new ListBox();
            lblItem = new Label();
            lblIndex = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(309, 167);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(75, 23);
            btnInsertar.TabIndex = 0;
            btnInsertar.Text = "insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(309, 222);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += button2_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(309, 272);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(75, 23);
            btnBorrarTodo.TabIndex = 2;
            btnBorrarTodo.Text = "borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 91);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 3;
            label1.Text = "Nuevo Elemento";
            // 
            // txtElementos
            // 
            txtElementos.Location = new Point(297, 129);
            txtElementos.Name = "txtElementos";
            txtElementos.Size = new Size(100, 23);
            txtElementos.TabIndex = 4;
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(79, 117);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(120, 94);
            lstElementos.TabIndex = 5;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(100, 280);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(38, 15);
            lblItem.TabIndex = 6;
            lblItem.Text = "label2";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(100, 332);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(38, 15);
            lblIndex.TabIndex = 7;
            lblIndex.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 70);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 8;
            label2.Text = "Elementos";
            // 
            // Form10ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(lblIndex);
            Controls.Add(lblItem);
            Controls.Add(lstElementos);
            Controls.Add(txtElementos);
            Controls.Add(label1);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Name = "Form10ColeccionGrafica";
            Text = "Form10ColeccionGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private Label label1;
        private TextBox txtElementos;
        private ListBox lstElementos;
        private Label lblItem;
        private Label lblIndex;
        private Label label2;
    }
}