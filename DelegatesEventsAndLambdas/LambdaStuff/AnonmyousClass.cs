using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaStuff
{
    class AnonmyousClass
    {


        private delegate void Del1 (string message);

        public void NestedFunction()
        {

            Console.WriteLine("Outside of the nested function.");


            //without use of a delegate
            void innerFunction(string message){
                Console.WriteLine(message);
            }

            //function invoked directly
            innerFunction("blah blah, inner function");


            Del1 del1 = delegate (string message)
            {
                Console.WriteLine(message);

            };

            //now to invoke the method
            string message = "inside of the nested function.";
            del1(message);



            //Now let's use the lambda way.
            (new Action(() => { Console.WriteLine(message); })).Invoke();


            //same, just 2 steps
            Action a = () => { Console.WriteLine(message); };
            a.Invoke();


           

        }


    }
}
