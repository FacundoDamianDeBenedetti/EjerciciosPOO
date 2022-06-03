using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO
{
    class Cuenta
    {

        private Persona titular = new Persona();

        private int cantDinero;

        public Cuenta(Persona titular, int cantDinero)
        {
            this.titular = titular;
            this.cantDinero = cantDinero;
        }

        public void Mostrar()
        {
            Console.WriteLine(this.titular);
        }

        private int Ingresar(int dinero)
        {
            return this.cantDinero =+ dinero;
        }

        private int Retirar(int dinero)
        {
            return this.cantDinero =- dinero;
        }
    }
}
