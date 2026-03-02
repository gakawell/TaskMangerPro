namespace TaskManagerPro.Core.Interfaces;


public interface ITask
{
    
    string Title {get; }
    
    void Complete();
    void Display();
}