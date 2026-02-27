namespace TaskManagerPro.Core.Models;
using TaskManagerPro.Core.Abstract;
using TaskManagerPro.Core.Interfaces;

public class TimedTask : BaseTask
{
    public int Minutes {get; protected set; }

    public TimedTask(string title, int minutes) : base(title)
    {
        Minutes = minutes;
    }

    public override void Display()
    {
        Console.WriteLine($"[Timed] {Title} ({Minutes} min) - Completed: {IsCompleted}");
    }
}