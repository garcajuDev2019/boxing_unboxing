using System;

namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 10;

            Console.WriteLine($"Value before boxing {value}");

            object box = Boxing(value);

            int value2 = Unboxing(box);

            Console.WriteLine($"Value after boxing {value2}");
        }

        private static Object Boxing(int value)
        {
            Object box = value;
            return box;
        }

        private static int Unboxing(object box) => (int)box;
    }
}
