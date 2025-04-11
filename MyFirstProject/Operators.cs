using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Operators
 * ---------------------------------
 * Addition -> + ( x + y )
 * Subtraction -> - ( x - y )
 * Multiplication -> * ( x * y )
 * Division -> / ( x / y )
 * Modulus -> % ( x % y )
 * Increment -> ++ ( x++ )
 * Decrement -> -- ( y-- )
 * 
 * Assignment Operators
 * ---------------------------------
 * Assignment Operator -> = ( x = 20 )
 * Addition Assignment Operator -> += ( x += 20 )
 * Subtraction Assignment Operator -> -= ( x -= 20 )
 * Multiplication Assignment Operator -> *= ( x *= 20 )
 * Division Assignment Operator -> /= ( x /= 20 )
 * Modulus Assignment Operator -> %= ( x %= 20 )
 */

namespace MyFirstProject
{
    class Operators
    {
        public static void Main(string[] args)
        {
            int age = 23;

            age += 10;
            Console.WriteLine(age);

            Console.ReadLine();
        }
    }
}
