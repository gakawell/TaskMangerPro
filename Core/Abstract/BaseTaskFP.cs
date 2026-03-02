namespace TaskManagerPro.Core.Abstract;
using TaskManagerPro.Core.Models;
using TaskManagerPro.Core.Interfaces;

public static class BaseTaskFP
{
    // Pure function: returns a NEW task, never mutates
    public static ITaskFP Complete(ITaskFP task) =>
        task switch
        {
            SimpleTaskFP s     => s with { IsCompleted = true },
            TimedTaskFP t      => t with { IsCompleted = true },
            RecurringTaskFP r  => r with { IsCompleted = true },
            _ => task
        };

    // Pure function: returns a string instead of printing
    public static string Display(ITaskFP task) =>
        task switch
        {
            SimpleTaskFP s     => $"[Simple] {s.Title} - Completed: {s.IsCompleted}",
            TimedTaskFP t      => $"[Timed] {t.Title} ({t.Minutes} min) - Completed: {t.IsCompleted}",
            RecurringTaskFP r  => $"[Recurring] {r.Title} - Every: {r.Frequency}",
            _ => task.Title
        };
}