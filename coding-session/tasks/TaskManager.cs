class TaskManager
{
    public List<Task> Tasks { get; } = [];
    private static int _id = 0;
    public Task AddTask(string description, DateTime? dueDate)
    {
        var id = _id++;
        var t = new Task(id)
        {
            Description = description,
            DueDate = dueDate
        };
        Tasks.Add(t);
        return t;
    }
    public List<Task> GetDueTasks(DateTime dueDate)
    {
        // go through all tasks
        return Tasks.FindAll(t => t.DueDate < dueDate);
        // find tasks that have duedate after duedate
        // return tasks
    }
    public List<Task> GetDueTasks() => GetDueTasks(DateTime.Now);
}