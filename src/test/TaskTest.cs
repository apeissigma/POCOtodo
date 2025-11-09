namespace Test;
using Todo.Library; 

public class TaskTest
{
    TodoTask task = new TodoTask("Write unit tests");
    Account dinoAccount = new Account(1, "Dino", "Bird");

    [Fact]
    public void CreateTaskWithDate()
    {
        TodoTask task = new TodoTask("Write unit tests", 3);
        Assert.True(task.dueDate.Day == DateTime.Now.Day+3);
    }

    [Fact]
    public void CreateTaskWithAssignee()
    {
        TodoTask task = new TodoTask("Write unit tests", dinoAccount);
        Assert.True(task.assignee.FirstName == "Dino" && task.isAssigned);
    }

    [Fact]
    public void CreateTaskWithDateAndAssignee()
    {
        TodoTask task = new TodoTask("Write unit tests", 3, dinoAccount);
        Assert.True((task.dueDate.Day == DateTime.Now.Day + 3) && task.assignee.FirstName == "Dino" && task.isAssigned);
    }


    //assign an account to a task, should return true if the account was assigned
    [Fact]
    public void AssignAccount()
    {
        task.assignTo(dinoAccount);

        Assert.True(task.isAssigned);
    }


    //mark the task as completed, should return true if it was completed
    [Fact]
    public void CompleteTask()
    {
        task.markComplete();

        Assert.True(task.checkIfComplete()); 
    }

    //check if the task is overdue, should return false because the task was just created
    [Fact]
    public void CheckIfOverdue()
    {
        Assert.False(task.checkIfOverdue());
    }

}
