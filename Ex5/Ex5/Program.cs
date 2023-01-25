using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "Frase invertida aqui";
            Console.WriteLine(frase);
            char[] chars= frase.ToCharArray();
            for (int i=0;i<frase.Length/2;i++) {
                char ch = chars[i];
                chars[i] = chars[frase.Length - i - 1];
                chars[frase.Length - i - 1] = ch;
            }
            Console.WriteLine(chars);
        }
    }
}
