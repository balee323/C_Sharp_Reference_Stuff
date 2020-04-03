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


    }
}
