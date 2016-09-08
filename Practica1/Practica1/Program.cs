using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            float Sueldo;
            string linea;
            Console.Write("Ingrese el sueldo:");
            linea = Console.ReadLine();
            Sueldo = float.Parse(linea);
            if(Sueldo>300)
            {
                Console.Write("Esta persona debe abonar");
            }
            Console.ReadKey();
        }
    }
}
