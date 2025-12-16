using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();
            this.lstTienda.SelectionMode = SelectionMode.MultiExtended;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string producto = txtProducto.Text;
            this.lstTienda.Items.Add(producto);
            int productos = this.lstTienda.SelectedIndices.Count - 1;
            foreach (var items in this.lstTienda.Items)
            {
              
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int productos = this.lstTienda.SelectedIndices.Count - 1;
            for (int i = productos; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                //ELIMINAMOS DE LA COLECCION 
                this.lstTienda.Items.RemoveAt(index);
            }

        }


        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstTienda.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            int productos = this.lstTienda.SelectedIndices.Count - 1;
            foreach (string items in this.lstTienda.SelectedItems)
            {
                this.lstAlmacen.Items.Add(items);
               
            }
            for (int i = productos; i >= 0; i--)
            {
                int index = this.lstTienda.SelectedIndices[i];
                //ELIMINAMOS DE LA COLECCION 
                this.lstTienda.Items.RemoveAt(index);
            }

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            foreach (string items in this.lstTienda.Items) 
            {
                this.lstAlmacen.Items.Add(items);
                
            }
            this.lstTienda.Items.Clear();

        }
    }
}
