using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaStuff
{
    class LambdaPlayground
    {

        private List<string> _list = new List<string>() { "brian", "john", "mike", "sam", "allan" };

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
                };
            }
        }

       
        public LambdaPlayground()
        {
            SetupEventHandlerMethod();
        }


        public void Find(string name)
        {

            var foundPerson = _list.Find(x => x == name);

            var foundPersonList = _list.FindAll(x => x == name);

        }

       
        public void Sort()
        {
             _list.Sort((x, y) => x.CompareTo(y));
        }


        public void PrintNames()
        {
            _list.ForEach((x) => Console.WriteLine(x));

            //Parallel.ForEach(_list, (x) => Console.WriteLine(x));

        }


        private void SetupEventHandlerMethod()
        {
            StringValueChanged += OnStringValueChanged; 
        }


        private void OnStringValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("String Value has been changed!");
        }

    }
}
