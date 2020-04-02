using System;

namespace CustomDelegates
{
    class Program
    {
        static void Main(string[] args)
        {

            //This application shows the creation of a custom delegate, it's handler (callback method) and 
            //the hooking-up of the custom delgate (by creating an instance of the custom delegate and attaching a handler).
            //Multiple handlers (callback functions) can be assigned to a delegate.  This gets added to the delegate base-class
            //invocationList.




            //create delegate and attach handler
            //Delegate has been wiredup with a HandlerMethod (callback function) by creating an instance of the delegate.
            SpecialCustomDelegates.DidSomeWorkHandler delegate1 = new SpecialCustomDelegates.DidSomeWorkHandler(SpecialCustomDelegateHandlerMethods.OnDidSomeWork);


          
            //now let's envoke the delegate (events also envoke the delegates)
            delegate1("scaredYa", TypeOfWork.ScaryWork);

         

            //Delegates with return values

            SpecialCustomDelegates.DidSomeWorkWithResultHandler delegate2 = new SpecialCustomDelegates.DidSomeWorkWithResultHandler(SpecialCustomDelegateHandlerMethods.OnDidSomeWorkWithReturn);

            var number = delegate2("let's get a number", TypeOfWork.CoolWork);

            Console.WriteLine(number.ToString());


            Console.ReadKey();

        }
    }
}
