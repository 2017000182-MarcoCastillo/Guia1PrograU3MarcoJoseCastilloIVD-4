using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication55
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colores = new string[9];

            colores[1] = "cafe oscuro";
            colores[2] = "cafe";
            colores[3] = "rojo";
            colores[4] = "naranja";
            colores[5] = "amarillo";
            colores[6] = "verde";
            colores[7] = "morado";
            colores[8] = "morado oscuro";

            Console.WriteLine("El dato 1 es: " + colores[1]);

            Console.ReadKey();
        }
    }
}
