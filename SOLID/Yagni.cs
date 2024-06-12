using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    //with yagni
    public class Task
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime Deadline { get; set; } // Additional property added
    }

    public class TaskManager
    {
        private List<Task> tasks;

        public TaskManager()
        {
            tasks = new List<Task>();
        }

        public void AddTask(string title, DateTime deadline) // Modified method signature
        {
            tasks.Add(new Task { Title = title, IsCompleted = false, Deadline = deadline }); // Updated task creation
        }

        public void ListTasks()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.Title} - {(task.IsCompleted ? "Completed" : "Pending")} - Due: {task.Deadline}"); // Updated task display
            }
        }
    }

    class Program23
    {
        static void Main()
        {
            TaskManager taskManager = new TaskManager();
            taskManager.AddTask("Complete project proposal", DateTime.Now.AddDays(5)); // Added deadline
            taskManager.AddTask("Prepare presentation slides", DateTime.Now.AddDays(3)); // Added deadline

            taskManager.ListTasks();
        }
    }
    //without yagni
    public class Task1
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime Deadline { get; set; } // Additional property added
    }

    public class TaskManager1
    {
        private List<Task> tasks;

        public TaskManager1()
        {
            tasks = new List<Task>();
        }

        public void AddTask(string title, DateTime deadline) // Modified method signature
        {
            tasks.Add(new Task { Title = title, IsCompleted = false, Deadline = deadline }); // Updated task creation
        }

        public void ListTasks()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.Title} - {(task.IsCompleted ? "Completed" : "Pending")} - Due: {task.Deadline}"); // Updated task display
            }
        }
    }

    class Program11
    {
        static void Main()
        {
            TaskManager taskManager = new TaskManager();
            taskManager.AddTask("Complete project proposal", DateTime.Now.AddDays(5)); // Added deadline
            taskManager.AddTask("Prepare presentation slides", DateTime.Now.AddDays(3)); // Added deadline

            taskManager.ListTasks();
        }
    }

}
