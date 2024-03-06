using Herencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Ballena : Mamifero
    {
        public Ballena(string n, double p) : base(n, p) 
        { 
        }

        //Metodos
        public void mostrarballena()
        {
            string nom = "";
            nom = getNombre();
            Console.WriteLine("El nombre es: " + nom);
            Console.WriteLine("Su pesoen Kg es de: " + peso + "Kg");

        }
    }
}
