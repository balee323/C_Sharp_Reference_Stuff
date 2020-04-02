using System;
using System.Collections.Generic;
using System.Text;
using CustomDelegates;

namespace EventsAndHandlers
{
    public class Subscriber
    {
        private Work _work;

        public Subscriber(Work work)
        {
            _work = work;
        }

       

        public void SubscribeToWork()
        {

            //** There are 2 ways to subscribe to events with Handler methods **

            

            //1.  This is the long way, you must create instance of delegate yourself.

            //Subscribed event to a handler method
            _work.DidSomeWork += new SpecialCustomDelegates.DidSomeWorkHandler(SpecialCustomDelegateHandlerMethods.OnDidSomeWork);

            //subscibed to event to handler method (custom event args)
            _work.DidSomeMoreWork += new SpecialCustomDelegates.DidSomeMoreWorkHandler(SpecialCustomDelegateHandlerMethods.OnDidSomeMoreWork);

            //subscribe to generic event
            _work.WorkCompleted += new EventHandler(SpecialCustomDelegateHandlerMethods.OnWorkCompleted);





            //2. This is the easy way, the instance of the delegate gets created at runtime.
            //C# will infer the delegate at runtime

            //Subscribed event to a handler method
            _work.DidSomeWork += SpecialCustomDelegateHandlerMethods.OnDidSomeWork;

            //subscibed to event to handler method (custom event args)
            _work.DidSomeMoreWork += SpecialCustomDelegateHandlerMethods.OnDidSomeMoreWork;

            //Subscribe to generic event 
            _work.WorkCompleted += SpecialCustomDelegateHandlerMethods.OnWorkCompleted;



        }

  

    }
}
