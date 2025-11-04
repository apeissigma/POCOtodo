using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Todo.Library
{
    public interface IDueDate
    {
        DateTime dueDate { get; }
        bool isOverdue { get; }

        bool checkIfOverdue(); 
    }
}