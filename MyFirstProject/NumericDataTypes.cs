using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    class NumericDataTypes
    {
        public static void Main(string[] args)
        {
            int x = 10,
                y = 20,
                z = 30;

            int age = 23;
            Console.WriteLine(age);
            Console.WriteLine("int max value => " + int.MaxValue);
            Console.WriteLine("int min value => " + int.MinValue);

            long bigNumber = -900000000L;
            Console.WriteLine(bigNumber);
            Console.WriteLine("long max vlaue => " + long.MaxValue);
            Console.WriteLine("long min value => " + long.MinValue);

            double negative = -55.2D;
            Console.WriteLine(negative);
            Console.WriteLine("double max value => " + double.MaxValue);
            Console.WriteLine("double min value => " + double.MinValue);

            float precision = 5.000001F;
            Console.WriteLine(precision);
            Console.WriteLine("float max value => " + float.MaxValue);
            Console.WriteLine("float min value => " + float.MinValue);

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine("decimal max value => " + decimal.MaxValue);
            Console.WriteLine("decimal min value => " + decimal.MinValue);

            Console.ReadLine();
        }
    }
}
