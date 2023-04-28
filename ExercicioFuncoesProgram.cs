using System;
using System.Globalization; // p/ colocar nº decimal (aparecer o ponto (extrangeiro), no lugar da vírgula (brasil). OBS: digitar nº c/ vírgula.

namespace ExercicioFuncoes
{

    class Program
    {

        private static void Main(string[] args)
        {
            Console.WriteLine("Informe a largura do terreno:");
                double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o comprimento do terreno:");
                double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe o valor do metro quadrado:");
                double valorMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaRetangulo = largura * comprimento;
            double valorTotal = valorMetroQuadrado * areaRetangulo;

            
            Console.WriteLine("A área total do terreno corresponde a " + areaRetangulo.ToString("F2", CultureInfo.InvariantCulture) + "m².");
            Console.WriteLine("Valor total do terreno: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}           

       