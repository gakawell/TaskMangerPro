namespace TaskManagerPro;

public class BaseTask {
    public static ITask Complete(ITask task) => 
        task switch
        {
            SimpleTask s => s with {isCompleted  = true},
            TimedTask t => t with { isComplete = true},
            RecurringTask r => r with { isCompleted = true},
            _ =>
        };

    public static String Display(ITask task) =>
        task switch
        {
            SimpleTask s => $"[Simple] {s.Title} = Completed: {s.isCompleted}",
            TimedTask t => $"[Timed] {t.Title} ({t.Minutes} min) - Complted: {t.isCompleted}",
            RecurringTask r => $"[Recurring] {r.Title} - Every: {r.Frequency}",
            _ => task.Title
        };
}