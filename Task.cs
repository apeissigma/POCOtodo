using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace POCOtodo
{
    public class Task
    {
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }
        public bool Status { get; set; }

        public Task(string taskName) 
        { 
            this.TaskName = taskName;
            this.DueDate = (DateTime.Now).AddDays(1);
            this.Status = false; 
        }

        public string DisplayTask()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("-------------------------\n");
            sb.Append($"{TaskName}\n");
            sb.Append("-------------------------\n");

            if (Status)
            {
                sb.Append($"Status: Complete\n");
            }
            else { sb.Append($"Status: Not started\n"); }

            sb.Append($"Due Date: {DueDate}\n");
            return sb.ToString();
        }

        
           
    }
}