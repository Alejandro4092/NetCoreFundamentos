namespace NetCoreFundamentos
{
    partial class Form11ColeccionMultiple
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
            label2 = new Label();
            lblIndex = new Label();
            lblItem = new Label();
            lstElementos = new ListBox();
            txtElementos = new TextBox();
            label1 = new Label();
            btnBorrarTodo = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            btnSeleccionados = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 87);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 17;
            label2.Text = "Elementos";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Location = new Point(262, 349);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(38, 15);
            lblIndex.TabIndex = 16;
            lblIndex.Text = "label3";
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Location = new Point(262, 297);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(38, 15);
            lblItem.TabIndex = 15;
            lblItem.Text = "label2";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(241, 134);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(120, 94);
            lstElementos.TabIndex = 14;
            // 
            // txtElementos
            // 
            txtElementos.Location = new Point(459, 146);
            txtElementos.Name = "txtElementos";
            txtElementos.Size = new Size(100, 23);
            txtElementos.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(464, 108);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 12;
            label1.Text = "Nuevo Elemento";
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(464, 289);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(91, 31);
            btnBorrarTodo.TabIndex = 11;
            btnBorrarTodo.Text = "borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(464, 239);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 31);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(464, 184);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(91, 31);
            btnInsertar.TabIndex = 9;
            btnInsertar.Text = "insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(464, 341);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(91, 31);
            btnSeleccionados.TabIndex = 18;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // Form11ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeleccionados);
            Controls.Add(label2);
            Controls.Add(lblIndex);
            Controls.Add(lblItem);
            Controls.Add(lstElementos);
            Controls.Add(txtElementos);
            Controls.Add(label1);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Name = "Form11ColeccionMultiple";
            Text = "Form11ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label lblIndex;
        private Label lblItem;
        private ListBox lstElementos;
        private TextBox txtElementos;
        private Label label1;
        private Button btnBorrarTodo;
        private Button btnEliminar;
        private Button btnInsertar;
        private Button btnSeleccionados;
    }
}