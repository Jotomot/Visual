
using System.Threading.Tasks;

namespace ListApp;

class MyClass
{
    static void Main(string[] args)
    {
        TaskManager tasks = new TaskManager();

        tasks.AddTask("Kup 1");
        tasks.AddTask("Kup 2");
        List<string> list = tasks.GetTasks();


        tasks.RemoveTask("Kup 1");
        List<string> list2 = tasks.GetTasks();
        listReader(list2);

    }
    private static void listReader(List<string> list)
    {
       
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
                
       
    }
}