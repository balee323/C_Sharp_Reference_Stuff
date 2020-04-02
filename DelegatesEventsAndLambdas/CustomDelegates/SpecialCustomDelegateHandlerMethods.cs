using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDelegates
{
    public static class SpecialCustomDelegateHandlerMethods
    {

        public static void OnDidSomeWork(string nameOfThing, TypeOfWork typeOfThing)
        {
            Console.WriteLine("Handling delegate invocation." + " Work type: " + typeOfThing);
        }


        public static int OnDidSomeWorkWithReturn(string nameOfThing, TypeOfWork typeOfThing)
        {
            Console.WriteLine("Handling delegate invocation.");
            return 0;
        }


        public static void OnWorkCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Work Completed: " + sender.ToString() );
        }


        public static void OnDidSomeMoreWork(object sender, WorkEventArgs e)
        {
            Console.WriteLine("Captured an event from: " + sender.ToString() + " Work was : " + e.Work + " and it was : " + e.Name);
        }

    }
}
