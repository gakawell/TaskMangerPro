namespace TaskManagerPro.Core.Models;
using TaskManagerPro.Core.Interfaces;

public record TimedTaskFP(
    string Title,
    int Minutes,
    bool IsCompleted = false
) : ITaskFP;