namespace TaskManagerPro.Core.Models;
using TaskManagerPro.Core.Interfaces;

public record SimpleTaskFP(
    string Title,
    bool IsCompleted = false
) : ITaskFP;