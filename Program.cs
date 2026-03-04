using TaskManagerPro;
using TaskManagerPro.Core.Models;
using TaskManagerPro.Core.Interfaces;

using static TaskManagerPro.Core.Abstract.BaseTaskFP;
using System.ComponentModel.DataAnnotations;

System.Console.WriteLine("==========================");
System.Console.WriteLine("Tasks using OOP Programming:\n\n");

var tasks = new List<ITask>
{
    new SimpleTask("Buy groceries"),
    new SimpleTask("Email professor"),
    new TimedTask("Study Algorithms", 45),
    new RecurringTask("Take out trash", "Weekly")
};


foreach (var task in tasks)
{
    task.Display();
}

tasks[0].Complete();

System.Console.WriteLine("=============================");
System.Console.WriteLine("Tasks after completeing first task:\n\n");
foreach (var task in tasks)
{
    task.Display();
}

System.Console.WriteLine("==========================");
System.Console.WriteLine("Tasks using FP Programming:\n\n");

var tasksFP = new List<ITaskFP>
{
    new SimpleTaskFP("Buy groceries"),
    new SimpleTaskFP("Email professor"),
    new TimedTaskFP("Study Algorithms", 45),
    new RecurringTaskFP("Take out trash", "Weekly")
};


foreach (var task in tasksFP)
{
   System.Console.WriteLine(Display(task));
}

tasks[0].Complete();

System.Console.WriteLine("=============================");
System.Console.WriteLine("Tasks after completeing first task:\n\n");

foreach (var task in tasksFP)
{
   System.Console.WriteLine( Display(task));
}