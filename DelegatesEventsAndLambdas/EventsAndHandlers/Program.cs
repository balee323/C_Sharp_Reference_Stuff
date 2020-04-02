﻿using System;
using static CustomDelegates.SpecialCustomDelegates;

namespace EventsAndHandlers
{
    class Program
    {
        static void Main(string[] args)
        {

            var work = new Work();

            //Let's subscribe to events...
            //make instance subscriber class
            var subscriber = new Subscriber(work);
            subscriber.SubscribeToWork();


            //**anomoyous method**
            //we can also directly hook in an event with an anomoyous method when we subscrible
            work.WorkCompleted += delegate (object sender, EventArgs e)
            {
                //create a method here... Note that this is much clear if we use Lambdas..
                Console.WriteLine("Anonomyous method: work has been completed");
            };
                

            //**Lambda's baby**




            KickOffSomeWork(work);

            Console.ReadKey();
        }


        public static void KickOffSomeWork(Work work)
        {
            work.DoWork();
            work.DoSomeMoreWork();
        }

    }
}
