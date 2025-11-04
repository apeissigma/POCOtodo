using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.App
{
    public class TodoApp
    {
        public List<Task> Tasks = new List<Task>();

        public TodoApp() { }

        public void AddTask(string taskName)
        {
            Tasks.Add(new Task(taskName));
        }

        public void DisplayTasks(List<Task> tasks)
        {
            var today = DateTime.Now;
            Console.WriteLine($"{today.DayOfWeek}, {today.Month}/{today.Day}");
            Console.WriteLine("Today's tasks...\n");

            foreach (Task task in tasks)
            {
                Console.WriteLine(task.DisplayTask());
            }
        }
        public void UpdateStatus(Task task)
        {
            if (task.Status == false)
            {
                task.Status = true;
            }
        }
    }
}
