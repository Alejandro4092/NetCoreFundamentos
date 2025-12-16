using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form11ColeccionMultiple : Form
    {
        public Form11ColeccionMultiple()
        {
            InitializeComponent();
            //la lista tendra sellecion multiple
            this.lstElementos.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string elem = this.txtElementos.Text;
            this.lstElementos.Items.Add(elem);
            this.txtElementos.Focus();
            this.txtElementos.SelectAll();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";
            //vamos a recorrer la coleccion de items seleccionados
            foreach (string item in this.lstElementos.SelectedItems)
            {
                items += item + ",";
            }
            foreach (int index in this.lstElementos.SelectedIndices)
            {
                indices += index + ",";
            }
            this.lblIndex.Text = indices.Trim(',');
            this.lblItem.Text = items.Trim(',');
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //    for (int i = 0; i < this.lstElementos.SelectedIndices.Count; i++)
            //    {
            //        int index = this.lstElementos.SelectedIndices[i];
            //        this.lstElementos.Items.RemoveAt(index);
            //    }

            //DEBEMOS ELIMINAR DE FORMA INVERSA PARA QUE NO AFECTEN LOS INDICES
            int numElementos = this.lstElementos.SelectedIndices.Count-1;
            for(int i = numElementos; i >= 0; i--)
            {
                int index = this.lstElementos.SelectedIndices[i];
                this.lstElementos.Items.RemoveAt(index);
            }


        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }
    }
}
