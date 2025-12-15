using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form06Email : Form
    {
        public Form06Email()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
           string email = this.txtEmail.Text;
            int posicionPunto = email.LastIndexOf(".");
            string dominio = email.Substring(posicionPunto+1);
            int posicionArroba = email.IndexOf("@");
          
            email.Trim(" ");

            if (email.Contains("@") == false) 
            {
                MessageBox.Show("Necesitas tener una @");
            }
            else if (email.StartsWith("@")==true || email.EndsWith("@")==true)
            {
                MessageBox.Show("No puedes tener una @ al inicio ni al final");
              
            }
            else if (email.IndexOf("@",email.IndexOf("@")+1)!=-1)
            {
                MessageBox.Show("no mas de una @");
            }
            else if (email.Contains(".") == false)
            {
                MessageBox.Show("Necesitas tener un punto");

            }
         
            else if (posicionPunto < posicionArroba)
            {
                MessageBox.Show("El punto tiene que estar despues de la @");
            }

            else if (dominio.Length < 2 || dominio.Length > 3)
            {
                MessageBox.Show("El dominio tiene que tener 2 o 3 letras");

            }

            else
            {
                MessageBox.Show("Es valido");
            }

        }
    }
}
