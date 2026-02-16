namespace TaskManagerPro;

public interface ITask
{
    
    string Title {get; }
    void Complete();
    void Display();
}