using System;
using System.Collections.Generic;
using System.Text;



namespace CustomDelegates
{

    public enum TypeOfWork
    {
        CoolWork = 1,
        LameWork = 2,
        ScaryWork =3
    }

    public class SpecialCustomDelegates
    {
        //The delegate basically just is a "shell" of a method that the data will get dumped into. - Dan Wahlin Pluralsight.
        public delegate void DidSomeWorkHandler(string nameOfThing, TypeOfWork typeOfThing);


        //let's create a delegate with a return type
        public delegate int DidSomeWorkWithResultHandler(string nameOfThing, TypeOfWork typeOfThing);


        //let's create a delegate that uses custom event args
        public delegate void DidSomeMoreWorkHandler(object sender, WorkEventArgs e);

    }
}
