using System.Data;

namespace TaskManagerPro;

public class RecurringTask : BaseTask
{
    public string Frequency {get; protected set; }

    public RecurringTask(string title, string frequency) : base(title)
    {
        Frequency = frequency;
    }

    public override void Complete()
    {
        Console.WriteLine($"{Title} completed once, but it recurs every {Frequency}.");
    }

    public override void Display()
    {
        Console.WriteLine($"[Recurring {Title}] - Every {Frequency}");
    }
}