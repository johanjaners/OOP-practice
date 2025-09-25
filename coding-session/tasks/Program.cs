class Program
{
    private static readonly TaskManager taskManager = new();
    static void Main()
    {
        taskManager.AddTask("Do the dishes", DateTime.Now.AddDays(-1));
        taskManager.AddTask("Cook food", DateTime.Now.AddDays(1));
        Console.WriteLine("Description of due tasks: ");
        foreach (var t in taskManager.GetDueTasks())
        {
            Console.WriteLine(t.Description);
        }
    }
}