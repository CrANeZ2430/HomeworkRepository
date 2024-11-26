namespace Homework13;

public class UserTask
{
    public string Description { get; }
    public TaskStatus Status { get; private set; }
    public bool CanModify { get; private set; }

    public UserTask(string description, TaskStatus status = TaskStatus.Unfinished)
    {
        Description = description;
        Status = status;
        CanModify = status == TaskStatus.Unfinished;
    }

    public void SetTaskAsDone()
    {
        if (CanModify == false)
        {
            return;
        }
        
        Status = TaskStatus.Finished;
        CanModify = false;
    }
}