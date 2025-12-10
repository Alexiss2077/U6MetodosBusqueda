using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U6MetodosBusqueda
{
    internal class LinearSearch
    {
        public static int Search(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;  // posición encontrada
            }
            return -1; // no encontrado
        }
    }
}
