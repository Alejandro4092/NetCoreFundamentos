using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form16ListDelegados : Form
    {
        int contador;
        public Form16ListDelegados()
        {
            InitializeComponent();
            //inicializamos la variable contador
            this.contador = 0;
            //Almacenamos todos los botones en una nueva coleccion
            List<Button> botones = new List<Button>();
           //Añadimos dinamicamente todos lso botones del formulario
           foreach(Control control in this.Controls)
            {
                //preguntamos pro el tipo de control 
                if(control is Button)
                {
                    botones.Add((Button)control);
                }
                
            }

            //vamos a crear un emtodo para que todos los botones lean al ser pulsado
            foreach(Button boton in botones)
            {
                boton.Click += PulsarBoton;
            }
        }

        private void PulsarBoton(object? sender, EventArgs e)
        {
            this.contador += 1;
            this.txtContador.Text = this.contador.ToString();

            ((Button) sender).BackColor = Color.LightPink;
        }

       
    }
}
