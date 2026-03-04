namespace TaskManagerPro.Core.Interfaces;


public interface ITask
{
    
    string Title {get; }
    bool IsCompleted {get; }

    void Complete();
    void Display();

}