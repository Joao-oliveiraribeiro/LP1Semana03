using System;
using System.Collections.Generic;

namespace HeroPerk
{
    [Flags]
    enum Perks
    {
        WarpShift = 1 << 0,
        Stealth = 1 << 1,
        AutoHeal = 1 << 2,
        DoubleJump = 1 << 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1 || string.IsNullOrWhiteSpace(args[0]))
            {
                Console.WriteLine("!Unknown perk!");
                return;
            }

            
        }
    }
}