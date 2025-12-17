using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form15ArrayList : Form
    {
        public Form15ArrayList()
        {
            InitializeComponent();
            //creamos una coleccion generica
            List<Control> botones = new List<Control>();
            //detecta automaticamente los elementos
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            botones.Add(this.textBox1);
            botones[0].BackColor = Color.AliceBlue;







            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            //si deseamos accder a un objeto y modificar alguna caracteristica 
            //necesitamos casting
            ((Button)coleccion[0]).BackColor = Color.Yellow;
            foreach (Button boton in coleccion)
            {
                boton.BackColor = Color.LightGreen;
            }
            //y si añadimos agregamos un boton que no sea un button???
            coleccion.Add(this.textBox1);
            foreach (Control boton in coleccion)
            {
                boton.BackColor = Color.LightGreen;
                //cuando tenemos multiples objetos de diferentes clases
                //nos podemos abstraer en el recorrido, pero necesitamos alguna caracteristica
                //especial de cada uno
                //una caja tiene un metodo llamado Paste()
                if(boton is TextBox)
                {
                    ((TextBox)boton).Paste();
                }
            }

            this.button1.Click += MetodoDelegado;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void MetodoDelegado(object sender, EventArgs e)
        {

        }




        private void Form15ArrayList_Load(object sender, EventArgs e)
        {

        }
    }
}
