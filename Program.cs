using System;

namespace DevelopCApp_Homework_02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int value = 512;
            var bits = new Bits(value);

            string a = string.Empty;

            for (int i = 0; i < bits.SizeOfValue; i++)
            {
                a += bits.GetBit(i) ? 1 : 0;
            }

            a = string.Join("", a.Reverse());

            Console.WriteLine(a);
        }
    }
}