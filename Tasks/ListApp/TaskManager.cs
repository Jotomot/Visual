using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListApp
{
    internal class TaskManager
    {
        private List<string> tasks = new List<string>();

        public void AddTask(string task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(string task)
        {
            tasks.Remove(task);
        }

        public List<string> GetTasks() => tasks;

        public override bool Equals(object? obj)
        {
            return obj is TaskManager manager &&
                   EqualityComparer<List<string>>.Default.Equals(tasks, manager.tasks);
        }
    }
}
