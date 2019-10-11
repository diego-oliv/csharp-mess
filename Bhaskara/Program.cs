using System;
using System.Globalization;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            string option;

            Console.Clear();
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine("     Cálculo de Bháskara     ");
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine();
            System.Console.WriteLine("Aperte ENTER para calcular");
            System.Console.WriteLine("Digite 0 para sair");
            option = Console.ReadLine();
            
            while (option != "0"){
            Console.Clear();
            double icgnA;
            double icgnB;
            double icgnC;
            double delta;
            double bhaskara1;
            double bhaskara2;
            double valorcima1;
            double valorcima2;
            double valorbaixo;

            System.Console.WriteLine("** Digite os valores das icógnitas **");
            System.Console.Write("Digite o valor de a: ");
            icgnA = double.Parse(Console.ReadLine());
            System.Console.Write("Digite o valor de b: ");
            icgnB = double.Parse(Console.ReadLine());
            System.Console.Write("Digite o valor de c: ");
            icgnC = double.Parse(Console.ReadLine());           

            delta = ((icgnB*icgnB) - (4 * icgnA * icgnC));
            if (delta >= 0)
            {   
                Console.Clear();

                valorbaixo = (2 * icgnA);
                valorcima1 = (-(icgnB) + (Math.Sqrt(delta)));
                valorcima2 = (-(icgnB) - (Math.Sqrt(delta)));
                bhaskara1 = (-(icgnB) + (Math.Sqrt(delta))) / (2 * icgnA);
                bhaskara2 = (-(icgnB) - (Math.Sqrt(delta))) / (2 * icgnA);

                System.Console.WriteLine($"O valor de Delta é: {delta}");
                System.Console.WriteLine($"O resultado da primeira raíz é: {valorcima1} / {valorbaixo} = {bhaskara1}");
                System.Console.WriteLine($"O resultado da segunda raíz é: {valorcima2} / {valorbaixo} = {bhaskara2}\n");   
                System.Console.WriteLine("Aperte ENTER para calcular");
                System.Console.WriteLine("Digite 0 para sair");
                option = Console.ReadLine();
            } else {
                System.Console.WriteLine("O valor de delta é: " + delta);
                System.Console.WriteLine("Delta é um valor negativo, logo não existe valor de Bháskara!\n");
                System.Console.WriteLine("Aperte ENTER para calcular");
                System.Console.WriteLine("Digite 0 para sair");
                option = Console.ReadLine();
            }
            }
        }
        public static void ApertarEnter (){
            System.Console.WriteLine("Aperte ENTER para continuar!");
            System.Console.ReadLine();
        }
    }
}
