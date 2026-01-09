using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    //Las enumeraciones estan dentro del namespace
    public enum TipoGenero { Masculino=0,Femenino=1}
    public enum Paises { España,Francia,Alemania,Andorra,Colombia}
    public class Persona
    {
        #region Constructores
        public Persona()
        {
            Debug.WriteLine("Constructor Persona vacio");
        }
        public Persona(string nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            Debug.WriteLine("Constructor Persona con dos parametros");
        }
        #endregion

        #region PROPIEDADES
        private string _Descripcionthis;
        public string this [int indice]
        {
            get { return this._Descripcionthis; }
            set {
                //Devolvemos una descripcion aleatoria de nuestro numero
                Random random = new Random();
                int dato = random.Next(1, 20);
                this._Descripcionthis = "Descripcion "+ dato;
            }
        }
        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }
        public TipoGenero _Genero;
        public TipoGenero Genero
        {
            get { return this._Genero; }
            set
            {
                if (value != TipoGenero.Femenino && value != TipoGenero.Masculino)
                {
                    throw new Exception("Donde vas, listo...");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        public Paises Nacionalidad { get; set; }


        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        //CAMPO DE PROPIEDAD
        private int _Edad;
        public int Edad
        {
            get { return this._Edad; }
            //Establecemos un valor
            //Programador: person.Edad=-25;
            set
            {
                if (value < 0)
                {
                    //NO NOS GUSTA  Error
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    this._Edad = value;
                }
            }
        }
    

    #endregion
    
        #region METODOS
    public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

    public string GetNombreCompleto(bool orden)
        {
            return this.Apellidos + " " + this.Nombre;
        }
        public string GetNombreCompleto(int num1)
        {
            return (this.Apellidos + " " + this.Nombre).ToUpper();
        }
        public string GetNombreCompleto(int num1,int num2)
        {
            return this.GetNombreCompleto().ToLower();
        }
        public void GetNombreCompleto(string dato)
        {

        }

        #endregion
    }
}
