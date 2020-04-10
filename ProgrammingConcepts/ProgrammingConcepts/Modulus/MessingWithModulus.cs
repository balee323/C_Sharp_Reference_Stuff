using System;
using System.Collections.Generic;
using System.Text;

namespace Modulus
{
    class MessingWithModulus
    {
        public void RunModulusStuff()
        {
            var remainder = 10 % 6;  //the modulus is 6
            Console.WriteLine(remainder);  //remainder = 4
                                           //10 - 4 = something that is divisible by 6

            remainder = 56 % 6;  //the modulus is 6
            Console.WriteLine(remainder);  //remainder = 2
                                           //56 - 2 = something that is divisible by 6

            remainder = 54 % 6;  //the modulus is 6
            Console.WriteLine(remainder);  //remainder = 0




            remainder = 10 % 13;  //the modulus is 13
            Console.WriteLine(remainder);  //remainder = 10
                                           //10 - 10 = something that is divisible by 13

            remainder = 0 % 13;  //the modulus is 13
            Console.WriteLine(remainder);  //remainder = 0


            remainder = 25 % 13;  //the modulus is 13
            Console.WriteLine(remainder);  //remainder = 0
                                           //25 - 12 = something divisible by 13


            remainder = 1556 % 13;  //the modulus is 13
            Console.WriteLine(remainder);  //remainder = 9
                                           //1556 - 9 = something divisible by 13 //1547

            remainder = 1547 % 13;  //the modulus is 13
            Console.WriteLine(remainder);  //remainder = 0
        }

    }
}
