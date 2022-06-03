using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO
{
    public class Persona
    {
        public string nombre;

        public int edad;

        private int dni;


        public Persona(string nombre, int edad, int dni)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }


        public void Mostrar()
        {
           Console.WriteLine("La persona es " + this.nombre + " , tiene"+ this.edad +" años " +" Y el dni es : "+ this.dni);
        }

        public bool EsMayorDeEdad(int edad)
        {
            if (edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
