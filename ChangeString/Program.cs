using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
           Console.Write("Digite uma string: ");
           string texto = Console.ReadLine(); 

           Console.Write("Digite um caracter para substituir por 'x':");
           string input_char = Console.ReadLine();
           char caracter = input_char[0];

           string textoalt = texto.Replace(caracter, 'x');

           Console.WriteLine("String alterada: " + textoalt);
        }
    }
}
