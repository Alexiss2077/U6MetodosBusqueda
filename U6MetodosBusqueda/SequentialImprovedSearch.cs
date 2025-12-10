using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U6MetodosBusqueda
{
    internal class SequentialImprovedSearch
    {
        public static int Search(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;

                if (arr[i] > target)
                    return -1; // se pasa y termina
            }
            return -1;
        }
    }
}
