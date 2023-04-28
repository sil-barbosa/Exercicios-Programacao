using System;
using System.Globalization; // p/ colocar nº decimal (aparecer o ponto (extrangeiro), no lugar da vírgula (brasil). OBS: digitar nº c/ vírgula.

namespace ExercicioEntradaDados { 

    class Program {   

    private static void Main(string[] args)
    {
        Console.WriteLine("Entre com seu nome commpleto:");
        string nome = Console.ReadLine();
        Console.WriteLine("Quantos quartos tem na sua casa?");
        int quartos = int.Parse(Console.ReadLine());
        Console.WriteLine("Entre com o preço de um produto:");
        double valor = double.Parse(Console.ReadLine());


        Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha:"); //escrever na msm linha e usar o comando Split p/ separar
        string[] dados = Console.ReadLine().Split(' ');

        string sobrenome =   dados[0];
        int idade = int.Parse(dados[1]);
        double altura = double.Parse(dados[2]);

        
        Console.WriteLine(nome);
        Console.WriteLine(quartos);
        Console.WriteLine(valor.ToString("F2",CultureInfo.InvariantCulture)); // CultureInfo.InvariantCulture: p/ usar o pontinho em nº decimal       
        Console.WriteLine(sobrenome);
        Console.WriteLine(idade);
        Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture)); // ("F2"): p/ aparecerem 2 casas dpois do ponto.
        }
  }
}