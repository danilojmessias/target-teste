using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader("../../../dados.json");
            string jsonString = r.ReadToEnd();
            dynamic obj = JsonConvert.DeserializeObject(jsonString);
            int dia, menordia = 0, maiordia = 0, i = 0;
            double valor, maiorvalor = 0, menorvalor = 999999, total = 0, media;
            foreach (var key in obj)
            {
                dia = key.dia;
                valor = key.valor;
                if (valor < menorvalor && valor != 0)
                {
                    menordia = dia;
                    menorvalor = valor;
                }
                if (valor > maiorvalor)
                {
                    maiordia = dia;
                    maiorvalor = valor;
                }
                if (valor != 0)
                {
                    total += valor;
                    i++;
                }
            }
            media = total / i;

            Console.WriteLine("Dia com maior faturamento foi o {0}º com valor de {1}", maiordia, maiorvalor.ToString("C"));
            Console.WriteLine("Dia com menor faturamento foi o {0}º com valor de {1}", menordia, menorvalor.ToString("C"));
            Console.WriteLine("A média de faturamento foi de {0} por dia. Excluindo dias sem faturamento", media.ToString("C"));
        }
    }
}
