using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Director: Empleado
    {
        public Director()
        {
            Debug.WriteLine("CONSTRUCTOR DIRECTOR");
            this.SalarioMinimo += 200;
        }

        //Metodo sobrescrito
        public override int GetDiasVacaciones()
        {
            int vacasEmpleado = base.GetDiasVacaciones();
            Debug.WriteLine("GetVacaciones() Director");
            return vacasEmpleado+8;
        }
    }
}
