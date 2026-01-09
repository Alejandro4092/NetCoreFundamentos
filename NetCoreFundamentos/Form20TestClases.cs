using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoClases;

namespace NetCoreFundamentos
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void Form20TestClases_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = "Alumno";
            persona.Apellidos = "Reyes";
            persona.Edad = 25;
            persona.Genero = TipoGenero.Femenino;
            persona.Nacionalidad = Paises.Andorra;
            persona[1] = "Vamos 1";
            persona[2] = "Vamos 2";

            this.lstClases.Items.Add(persona.GetNombreCompleto(true)
            );
            persona.Domicilio = new Direccion("Avenida Enero", "Lugo");
            //persona.Domicilio.Calle = "Avenida Enero";
            //persona.Domicilio.Ciudad = "Madrid";
            persona.Domicilio.CodigoPostal = 28003;
            this.lstClases.Items.Add("Direccion: " + persona.Domicilio.Calle + ", " + persona.Domicilio.Ciudad + ", " + persona.Domicilio.CodigoPostal);

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            //Empleado emp = new Empleado("Nombre","Apellidos");
            Empleado emp = new Empleado();
            emp.Nombre = "Becario";
            emp.Apellidos = "Becario";
            this.lstClases.Items.Add("Vacas Empleado: " + emp.GetDiasVacaciones());
            
            this.lstClases.Items.Add("Empleado: " + emp.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + emp.GetSalarioMinimo() + "€");
            Director dire = new Director();
            dire.Nombre = "Dire";
            dire.Apellidos = "Dire";
            this.lstClases.Items.Add("Director: " + dire.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + dire.GetSalarioMinimo() + "€");
            this.lstClases.Items.Add("Vacas Director: " + dire.GetDiasVacaciones());
        }
    }
}
