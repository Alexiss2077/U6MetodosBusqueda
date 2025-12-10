using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U6MetodosBusqueda
{
    internal class Program
    {

        static void MostrarResultado(int pos)
        {
            if (pos == -1)
                Console.WriteLine("\nNo encontrado.");
            else
                Console.WriteLine($"\nEncontrado en la posición {pos}.");
        }
        static void Main(string[] args)
        {
            int[] lista = { 3, 10, 14, 22, 35, 50, 71 };
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("===== MÉTODOS DE BÚSQUEDA =====");
                Console.WriteLine("1. Búsqueda Lineal");
                Console.WriteLine("2. Búsqueda Binaria");
                Console.WriteLine("3. Búsqueda Secuencial Mejorada");
                Console.WriteLine("4. Búsqueda Hash");
                Console.WriteLine("5. Salir");
                Console.Write("Elige una opción: ");
                string opcion = Console.ReadLine();

                Console.Write("\nIngresa el número a buscar: ");
                int target = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case "1":
                        int pos1 = LinearSearch.Search(lista, target);
                        MostrarResultado(pos1);
                        break;

                    case "2":
                        int pos2 = BinarySearch.Search(lista, target);
                        MostrarResultado(pos2);
                        break;

                    case "3":
                        int pos3 = SequentialImprovedSearch.Search(lista, target);
                        MostrarResultado(pos3);
                        break;

                    case "4":
                        var dic = new Dictionary<int, string>()
                    {
                        {3,"Hola"},{10,"Valor 2"},{14,"c"},{22,"d"}         ///// KEY Y VALUE DE LA TABLA HASH
                    };

                        bool existe = SimpleHash.Search(dic, target);
                        Console.WriteLine(existe
                            ? "\nEncontrado en la tabla hash."
                            : "\nNo existe en la tabla hash.");
                        break;

                    case "5":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresiona una tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}
