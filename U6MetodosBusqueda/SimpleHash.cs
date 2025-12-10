using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U6MetodosBusqueda
{
    internal class SimpleHash
    {
        public static bool Search(Dictionary<int, string> map, int key)
        {
            return map.ContainsKey(key);
        }
    }
}
