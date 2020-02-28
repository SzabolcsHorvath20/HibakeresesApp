using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HibakeresesApp
{
    class Program
    {
        static int MaxKeres(List<int> l)
        {
            int maxIndex = 0;
            for (int i = 1; i < l.Count; i++)
            {
                Debug.WriteLine(maxIndex + " " + l[maxIndex], "valtozok");
                if (l[i] > l[maxIndex])
                {
                    maxIndex = 1;
                }
            }
            return l[maxIndex];
        }

        static void Main(string[] args)
        {
            var lista = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                lista.Add(r.Next());
            }
            Console.WriteLine(MaxKeres(lista));
            Console.ReadKey();
        }
    }
}
