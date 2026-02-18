namespace TaskManagerPro;

public class TimedTask : BaseTask
{
    public int Minutes {get; private set; }

    public TimedTask(string title, int minutes) : base(title)
    {
        Minutes = minutes;
    }

    public override void Display()
    {
        Console.WriteLine($"[Timed] {Title} ({Minutes} min) - Completed: {IsCompleted}");
    }
}