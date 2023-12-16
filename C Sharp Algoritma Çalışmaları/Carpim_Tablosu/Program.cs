using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpim_Tablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                for (global::System.Int32 j = 0; j <= 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2} \t", i,j,(i * j));
                }
                Console.WriteLine();
            }

        }
    }
}
