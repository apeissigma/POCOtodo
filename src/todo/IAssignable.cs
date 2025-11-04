using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Todo.Library
{
    public interface IAssignable
    {
        bool isAssigned { get; }

        Account assignee { get; }

        string assignTo(Account account);
    }
}