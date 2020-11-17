using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaStuff
{
    class PlayingWithActions
    {
        //Action types are .net Built-in delegates.  These will save you some time and a bit easier to deal with.
        //2 most common of these are Action<T>  and Func<T, TResult>
        //Action<T> takes 1 - 16 parameters, but no return value
        //Fuct<T, TResult> takes 1 parameter and returns type TResult.

        Action doSpecialThing;
        Action doSpecialLambdaThing;

        //Use parameter with the Action
        Action<string> doSpecialLambdaThingWithParam;
        Action<string, int, object> doSpecialLambdaThingWithMultiParams; 

        public PlayingWithActions()
        {
            //assign method to Action (delegate) type
            doSpecialThing = MethodForActionDelegate;

            //use lambda
            doSpecialLambdaThing = () =>
            {
                Console.WriteLine("blah blah, lambda method is attached to Action Type");
            };


            //use lambda with param
            doSpecialLambdaThingWithParam = (message) => Console.WriteLine(message); 
            //Now you would have to envoke this action and pass a string parameter.
        }

        public void MethodForActionDelegate()
        {
            Console.WriteLine("Action delegate type was invoked.");
        }



    }
}
