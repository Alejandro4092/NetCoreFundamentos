using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form12ColeccionNumeros : Form
    {
        public Form12ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerarNumeros_Click(object sender, EventArgs e)
        {
            this.lstNumeros.Items.Clear();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                int numero = random.Next(1, 100);
                this.lstNumeros.Items.Add(numero);
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int sumaPares = 0;
            int sumaImpares = 0;
            foreach (int num in lstNumeros.Items)
            {
                suma += num;
                if (num % 2 == 0)
                {
                    sumaPares += num;

                }
                else
                {
                    sumaImpares += num;

                }

                
            }
            this.txtSuma.Text = suma.ToString();
            this.txtPares.Text = sumaPares.ToString();
            this.txtImpares.Text = sumaImpares.ToString();
        }
    }
}
