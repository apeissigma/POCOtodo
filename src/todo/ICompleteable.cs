using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Todo.Library
{
    public interface ICompleteable
    {
        bool isComplete { get; }

        void markComplete();
        void markIncomplete();

        bool checkIfComplete(); 
    }
}