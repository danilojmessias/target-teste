using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double SP = 67836.43, RJ = 36678.66, MG = 29229.88, ES = 27165.48, Outros = 19849.53;
            double porcentagem,total;
            int i = 0;
            double [] valores = {SP,RJ,MG,ES,Outros};
            string[] estados = { "SP", "RJ", "MG", "ES", "Outros" };
            string estado;
            total = valores.Sum();
            
            foreach (double valor in valores)
            {
                porcentagem = ((valor * 100) / total);
                estado = estados[i];
                Console.WriteLine("O estado {0} contribui com {1}% do faturamento mensal",estado,porcentagem.ToString("F"));
                i++;
            }
        }
    }
}
