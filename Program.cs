using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> miFila = new Queue<string>();

            Console.Write("Ingrese el numero de personas en la fila: ");
            int numeroDePersonas = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroDePersonas; i++)
            {
                Console.Write("Ingrese el nombre de la persona " + (i + 1) + ":");
                string nombre = Console.ReadLine();
                miFila.Enqueue(nombre);
            }

            for (int cont = 0; cont < numeroDePersonas; cont++)
            {
                Console.WriteLine("La cajera atendera a: " + miFila.Dequeue());
            }

            Console.ReadKey();
        }
    }
}
