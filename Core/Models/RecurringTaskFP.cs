namespace TaskManagerPro.Core.Models;
using TaskManagerPro.Core.Interfaces;

public record RecurringTaskFP(
    string Title,
    string Frequency,
    bool IsCompleted = false
) : ITaskFP;