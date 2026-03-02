using TaskManagerPro;
using TaskManagerPro.Core.Models;
using TaskManagerPro.Core.Interfaces;
using static TaskManagerPro.Core.Abstract.BaseTaskFP;
using System.ComponentModel.DataAnnotations;


System.Console.WriteLine("=======================================");
System.Console.WriteLine("Tasks using OOP Programming:\n\n");

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
System.Console.WriteLine("\n=====================================");
System.Console.WriteLine("Tasks after completeing first task:\n");
tasks[0].Complete();

foreach (var task in tasks)
{
    task.Display();
}

System.Console.WriteLine("\n\n=======================================");
System.Console.WriteLine("Tasks using Functional Programming:\n");

 var tasksFP = new List<ITaskFP>
{
    new SimpleTaskFP("Buy groceries"),
    new SimpleTaskFP("Email professor"),
    new TimedTaskFP("Study alogrithms", 45),
    new RecurringTaskFP("Take out trash", "Weekly")
};

foreach (var task in tasksFP)
{
    System.Console.WriteLine(Display(task));
}
System.Console.WriteLine("\n=====================================");
System.Console.WriteLine("Tasks after completeing first task:\n");
tasks[0].Complete();

foreach (var task in tasksFP)
{
    System.Console.WriteLine(Display(task));
}
