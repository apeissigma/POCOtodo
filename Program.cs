namespace POCOtodo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TodoApp todoApp = new TodoApp();
            todoApp.AddTask("Complete POCO todo assn");
            todoApp.AddTask("Water plants");
            todoApp.UpdateStatus(todoApp.Tasks[0]); 

            todoApp.DisplayTasks(todoApp.Tasks); 
        }
    }
}
