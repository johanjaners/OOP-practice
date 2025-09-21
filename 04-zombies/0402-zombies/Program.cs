class Room
{
    public int Capacity { get; set; }
    public string Zombie { get; set; }
    public List<string> Zombies { get; } = new();
    public Room(int capacity) => this.Capacity = capacity;
    public bool IsFull() => Zombies.Count >= Capacity;
    public void AddZombie(string zombie)
    {
        if (Capacity == 0) return;
        if (IsFull() && Capacity > 0)
        {
            Zombies.Add(zombie);
            Zombies.RemoveAt(0);
            return;
        }
        Zombies.Add(zombie);
    }
}


class Program
{
    static void Main()
    {
        var r0 = new Room(1);
        Console.WriteLine("empty one-room full? " + r0.IsFull());
    }
}