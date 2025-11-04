namespace test;

using Todo.App;
using Todo.Library; 

public class UnitTest1
{
    TodoTask task = new TodoTask("Write unit tests");
    Account dinoAccount = new Account(1, "Dino", "Bird"); 

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
