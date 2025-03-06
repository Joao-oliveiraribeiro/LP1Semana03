using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
           Console.Write("Digite uma string: ");
           string texto = Console.ReadLine(); 

           Console.Write("Digite um caracter para substituir por x:");
           char caracter = Console.ReadKey().KeyChar;
           Console.WriteLine();
        }
    }
}
