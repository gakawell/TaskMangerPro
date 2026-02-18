namespace TaskManagerPro;

public class SimpleTask : BaseTask
{
    
    public SimpleTask(string title) : base(title)
    {
        
    }

    public override void Display()
    {
        Console.WriteLine($"[Simple] {Title} - Completed: {IsCompleted}");
    }



}