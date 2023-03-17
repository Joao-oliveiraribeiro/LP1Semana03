using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            string y;
            
            Console.WriteLine("Please write a string");
            x= Console.ReadLine();
            Console.WriteLine("Please write a caracter");
            y= Console.ReadLine();
            var removechar = new string[] {y};
            foreach (var z in removechar)
            {
                x = x.Replace(y, string.Empty);
            }
            Console.WriteLine(x);
            


        }
    }
}
