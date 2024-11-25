namespace Homework13;

public class UserTask
{
    public string Description { get; }
    public string Status { get; private set; }

    private bool AbilityToModify { get; set; }

    public UserTask(string description)
    {
        Description = description;
        Status = "Unfinished";
    }

    public void SetTaskAsDone()
    {
        if (AbilityToModify == false)
        {
            return;
        }
        Status = "Finished";
        AbilityToModify = false;
    }
}