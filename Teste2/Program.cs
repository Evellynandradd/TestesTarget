using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número para verificar se pertence à sequência de Fibonacci: ");
        int numero = int.Parse(Console.ReadLine());

        bool pertence = PertenceFibonacci(numero);

        if (pertence)
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não pertence à sequência de Fibonacci.");
        }
    }

    static bool PertenceFibonacci(int numero)
    {
        int fib0 = 0;
        int fib1 = 1;

        for (int i = 0; i <= numero; i++)
        {
            if (fib0 == numero)
            {
                return true;
            }

            int temp = fib1;
            fib1 = fib0 + fib1;
            fib0 = temp;
        }

        return false;
    }
}
