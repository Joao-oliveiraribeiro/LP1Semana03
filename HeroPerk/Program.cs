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

            string input = args[0].ToLower();
            var perk_cont = new Dictionary<char, int>() {['w']=0, ['a']=0, ['s']=0, ['d']=0};

            foreach (char c in input)
            {
                if (!perk_cont.TryGetValue(c, out int count))
                {
                    Console.WriteLine("!Unknown perk!");
                    return;
                }
                perk_cont[c] = count +1;
            }

        }
    }
}