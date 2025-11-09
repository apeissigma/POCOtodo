namespace Test;
using Todo.Library;

public class AppTest
{
    public App app; 
    
    //adds 5 tasks to list, then checks if the tasks were added successfully
    [Fact]
    public void AddToList()
    {
        app = new App();
        app.Tasks.Add(new TodoTask("task 1"));
        app.Tasks.Add(new TodoTask("task 2"));
        app.Tasks.Add(new TodoTask("task 3"));
        app.Tasks.Add(new TodoTask("task 4"));
        app.Tasks.Add(new TodoTask("task 5"));

        Assert.True(app.Tasks.Count == 5);
    }
}
