using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndHandlers
{
    public class Work
    {
        //We will need to subscribe some handler methods to these events outside this class.


        //defining the custom event (DoSpecialThing) -- Notice we haven't create instance of delegates yet...
        public event CustomDelegates.SpecialCustomDelegates.DidSomeWorkHandler DidSomeWork;  

        public event CustomDelegates.SpecialCustomDelegates.DidSomeMoreWorkHandler DidSomeMoreWork;

        //define a generic event (from system, uses a generic delegate)
        public event EventHandler WorkCompleted;

        
        public void DoWork()
        {

            for(int i = 0; i < 5; i++)
            {
                //raise event
                DidSomeWork("Worked some", CustomDelegates.TypeOfWork.LameWork);
            }

            //raise event
            WorkCompleted(this, EventArgs.Empty);

            Console.WriteLine("**Work is done notification sent**");
        }


        //using raising event using custom event args
        public void DoSomeMoreWork()
        {
            DidSomeMoreWork(this, new CustomDelegates.WorkEventArgs("More Work", CustomDelegates.TypeOfWork.ScaryWork));
        }

    }
}
