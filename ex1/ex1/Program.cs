using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indice = 13, soma = 0, k = 0;

            while (k<indice) {
                k++;
                soma += k;
            }
            Console.WriteLine(soma);
        }
    }
}
