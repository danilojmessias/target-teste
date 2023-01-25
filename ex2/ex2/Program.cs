using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Program
    {
  
        static void Main(string[] args)
        {
            List<int> Listafibonnaci = new List<int>();
            int numero, fim=1, inicio=0;
            Console.WriteLine("Digite um número");
            numero = Convert.ToInt32(Console.ReadLine());

            while (fim <= 100)
            {
                fim = inicio + fim;
                inicio = fim - inicio;
                if (fim <= 100)
                    Listafibonnaci.Add(fim);
            }
            foreach (var num in Listafibonnaci)
                Console.Write("{0} ", num);

            if (Listafibonnaci.Contains(numero))
                Console.WriteLine("\nO numero {0} está presente na sequencia", numero);
            else
                Console.WriteLine("\nO numero {0} não está presente na sequencia", numero);
        }
    }
}
