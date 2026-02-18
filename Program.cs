using TaskManagerPro;

var tasks = new List<ITask>
{
    new SimpleTask("Buy groceries"),
    new SimpleTask("Email professor")

};


foreach (var task in tasks)
{
    task.Display();
}

tasks[0].Complete();

Console.WriteLine("\nAfter completeing first task:\n");

foreach (var task in tasks)
{
    task.Display();
}