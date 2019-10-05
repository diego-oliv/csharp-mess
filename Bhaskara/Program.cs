using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double icgnA;
            double icgnB;
            double icgnC;
            
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine("     Cálculo de Bháskara     ");
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine();
            System.Console.WriteLine("Aperte ENTER para continuar!");
            System.Console.WriteLine("Digite '0' para sair!");
            Console.ReadLine();
            Console.Clear();
            
            System.Console.WriteLine("** Digite os valores das icógnitas **");
            System.Console.Write("Digite o valor de 'a': ");
            icgnA = double.Parse(Console.ReadLine());
            System.Console.Write("Digite o valor de 'b': ");
            icgnB = double.Parse(Console.ReadLine());
            System.Console.Write("Digite o valor de 'c': ");
            icgnC = double.Parse(Console.ReadLine());
            
            double delta;
            double bhaskara1;
            double bhaskara2;
            delta = ((icgnB*icgnB) - (4 * icgnA * icgnC));
            if (delta >= 0)
            {   
                Console.Clear();
                
                bhaskara1 = (-(icgnB) + (Math.Sqrt(delta))) / (2 * icgnA);
                bhaskara2 = (-(icgnB) - (Math.Sqrt(delta))) / (2 * icgnA);
                System.Console.WriteLine($"O valor de Delta é: {delta}");
                System.Console.WriteLine($"O resultado da primeira raíz é: {bhaskara1}");
                System.Console.WriteLine($"O resultado da segunda raíz é: {bhaskara2}");
            } else {
                System.Console.WriteLine("O valor de delta é: " + delta);
                System.Console.WriteLine("Delta é um valor negativo, logo não pode haver Bháskara!");
            }
        }
    }
}
