using System;

namespace LambdaStuff
{
    class Program
    {
        static void Main(string[] args)
        {

            //var anomyous = new AnonmyousClass();
            //anomyous.NestedFunction();


            var lpg = new LambdaPlayground();

            lpg.PrintNames();

            Console.WriteLine("================");

            lpg.Sort();

            lpg.PrintNames();


            lpg.Str = "something else"; //cool, works!

            Console.ReadKey();
        }
    }
}
