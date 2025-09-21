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
        Console.WriteLine("empty room not full: " + !r0.IsFull());

        var r1 = new Room(0);
        r1.AddZombie("A");
        Console.WriteLine("cap 0 cannot add: " + (r1.Zombies.Count == 0 && r1.IsFull()));

        var r2 = new Room(1);
        r2.AddZombie("A");
        Console.WriteLine("one-roomer full after one: " + r2.IsFull());

        var r3 = new Room(2);
        r3.AddZombie("A");
        Console.WriteLine("two-roomer not full after one: " + !r3.IsFull());

        var r4 = new Room(1);
        r4.AddZombie("A");
        r4.AddZombie("B"); // FIFO
        Console.WriteLine("fifo keeps newest: " + (r4.Zombies.Count == 1 && r4.Zombies[0] == "B"));
    }
}