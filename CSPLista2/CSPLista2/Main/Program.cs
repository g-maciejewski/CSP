using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSPLista2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>{ 1, 2, 3, 4, 5 };
            lista.Remove(4);
            foreach(var x in lista)
            {
                WriteLine(x);
            }

            ReadKey();
            
        }
    }
}
