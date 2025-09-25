class Task(int id)
{
    public int ID { get; } = id;
    public string? Description { get; set; }
    public DateTime? DueDate { get; set; }
}