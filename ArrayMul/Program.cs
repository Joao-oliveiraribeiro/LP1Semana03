using System;
using System.Globalization;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo dec = CultureInfo.InvariantCulture;

            float[,] A = new float[2, 2]
            {
                {float.Parse(args[0], dec), float.Parse(args[1], dec)},
                {float.Parse(args[2], dec), float.Parse(args[3], dec)}
            };


}
