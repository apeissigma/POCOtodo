namespace test;

using Todo.App;
using Todo.Library; 

public class UnitTest1
{
    TodoTask task = new TodoTask("Write unit tests");
    Account dinoAccount = new Account(1, "Dino", "Bird"); 

    //assign an account to a task, should return true if account name matches
    [Fact]
    public void AssignAccount()
    {
        task.assignTo(dinoAccount);

        Assert.True(task.isAssigned);
    }
}
