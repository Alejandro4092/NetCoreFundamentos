using System;
using System.Collections.Generic;
using System.Text;
using ProyectoClases.Models;

namespace ProyectoClases.Helper
{
    public class HelperMacotas
    {
        public List<Mascota> Mascotas { get; set; }
        private HelperFiles helper;
        private string path;

        public HelperMacotas()
        {
            this.Mascotas = new List<Mascota>();
            this.helper = new HelperFiles();
            this.path = "mascotas.txt";

        }


        //Convertir el string del read a list
        private void ConvertirMascotasList(string data)
        {
            //garfield,gato@Pluto,perro
            this.Mascotas.Clear();
            //Separamos cada mascota con @
            string[] datosMascota = data.Split('@');
            foreach (string stringMascota in datosMascota)
            {
                //Separamos las propiedades mediante,
                string[] propiedades = stringMascota.Split(',');
                //Convertimos el string en objetos
                Mascota mascota = new Mascota();
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }

        }
        private string ConvertirMascotasString()
        {
            //garfield,gato@Pluto,perro
            string data = "";
            foreach(Mascota mascota in this.Mascotas)
            {
                //separamos las propiedades mediante ,
                string propiedades = mascota.Nombre + "," + mascota.Raza;
                //separamos cada string de masota
                data += propiedades + "@";
            }
            data = data.TrimEnd('@');
            return data;

        }
        //El programador escriba write y guardamos las mascotas
        //el programador escriba read y leemos un string y rellenamos la coleccion
        public async Task ReadMascotasAsync()
        {
            //leemos el fichero de mascotas
            string data = await this.helper.ReadFileAsync(this.path);
            //Convertimos el string en list
            this.ConvertirMascotasList(data);

        }
        public async Task WriteMascotasAsync()
            {
            //Convertir la colleccion a string
            string data = this.ConvertirMascotasString();
            //Escribir los datos en file
            await this.helper.WriteFileAsync(this.path,data);

        }
    }
}
