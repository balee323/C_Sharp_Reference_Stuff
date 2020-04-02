
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDelegates
{
    public class WorkEventArgs : EventArgs
    {

        public WorkEventArgs(string name, TypeOfWork work)
        {
            Name = name;
            Work = work;
        }

        public string Name { get; set; }

        public TypeOfWork Work { get; set; }

    }
}
