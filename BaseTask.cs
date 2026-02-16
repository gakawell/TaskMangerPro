namespace TaskManagerPro;

public abstract class BaseTask : ITask{
    public string Title {get; protected set; }
    public bool IsCompleted {get; protected set; }

    public BaseTask(string title)
    {
        Title = title;
    }

    public virtual void Complete()
    {
      IsCompleted = true;  
    }

    public abstract void Display();

}