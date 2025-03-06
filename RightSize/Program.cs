using System;

namespace RighSize
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string arg in args)
            {
                if (arg.Length >= 8)
                {
                    Console.WriteLine("[EARLY STOP]");
                    return;
                }
                if (args.Length > 3)
                {
                    Console.WriteLine(arg);
                }
            }
    
        }
    }
}