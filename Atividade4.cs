using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número N: ");
        int n = int.Parse(Console.ReadLine());

        long soma = 0;

        for (int i = 1; i <= n; i++) 
        {
            soma += i;
        }

        Console.WriteLine("Soma: " + soma);
    }
}
