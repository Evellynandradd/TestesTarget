using System;

namespace Teste3
{
    class Program
    {
        static void Main(string[] args)
        {

            string texto = "evellyn";
            string textoInvertido = InverterString(texto);
            Console.WriteLine($"Texto original: {texto}");
            Console.WriteLine($"Texto invertido: {textoInvertido}");
        }

        static string InverterString(string texto)
        {
            char[] caracteres = texto.ToCharArray();

            for (int i = 0, j = caracteres.Length - 1; i < j; i++, j--)
            {

                char temp = caracteres[i];
                caracteres[i] = caracteres[j];
                caracteres[j] = temp;
            }
            return new string(caracteres);
        }
    }
}

