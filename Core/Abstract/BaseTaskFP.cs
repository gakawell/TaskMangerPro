namespace TaskManagerPro.Core.Abstract;

using TaskManagerPro.Core.Interfaces;
using TaskManagerPro.Core.Models;

public static class BaseTaskFP{

public static ITaskFP Complete(ITaskFP task) =>
    task switch
    {
        SimpleTaskFP s => s with { IsCompleted = true},
        TimedTaskFP t  => t with { IsCompleted = true},
        RecurringTaskFP r => r with {IsCompleted = true},
        _ => task
    };

    public static string Display(ITaskFP task) =>
        task switch
        {
            SimpleTaskFP s => $"[SimpleFP] {s.Title} - Complete: {s.IsCompleted}",
            TimedTaskFP t  => $"[TimedFP] {t.Title} ({t.Minutes} min) - Completed: {t.IsCompleted}",
            RecurringTaskFP r => $"[RecurringFP] {r.Title} - Every: {r.Frequency}",
            _ => task.Title
        };

}