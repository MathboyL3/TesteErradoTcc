using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        
        int numero = int.Parse(Console.ReadLine()); 

        if (numero / 2 == 0) 
        {
            Console.WriteLine("É par"); 
        }
        else
        {
            Console.WriteLine("É impar");
        }
    }
}
