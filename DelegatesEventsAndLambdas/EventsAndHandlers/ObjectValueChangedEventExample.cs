using System;
using System.Collections.Generic;
using System.Text;

namespace EventsAndHandlers
{
    class ObjectValueChangedEventExample
    {

        private string _str = string.Empty;

        public event EventHandler StringValueChanged;




        public string Str
        {
            get { return Str; }
            set
            {
                if (value != _str)
                {
                    //trigger event
                    StringValueChanged(this, EventArgs.Empty);
                }
            }
        }


        //constructor
        public ObjectValueChangedEventExample()
        {
            //wireup event to event handler (callback method)
            StringValueChanged += OnStringValueChanged;
        }
 


        //call back method (eventhandler method)
        private void OnStringValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("String Value has been changed!");
        }

    }
}
