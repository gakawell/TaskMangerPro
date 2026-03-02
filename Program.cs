using TaskManagerPro;
using TaskManagerPro.Core.Models;
using TaskManagerPro.Core.Interfaces;

var tasks = new List<ITask>
{
    new SimpleTask("Buy groceries"),
    new SimpleTask("Email professor"),
    new TimedTask("Study alogrithms", 45),
    new RecurringTask("Take out trash", "Weekly")
};

foreach (var task in tasks)
{
    task.Display();
}


tasks[0].Complete();

foreach (var task in tasks)
{
    task.Display();
}


