class Room
{
    public int C { get; set; }
    public string? Z { get; set; } // ?allow null
    public Room(int c) => this.C = c;
    public List<string> Zs { get; } = new();
    public bool IsFull() => Zs.Count >= C;
    public void AddZ(string z)
    {
        if (C == 0) return;
        if (IsFull() && C > 0)
        {
            Zs.Add(z);
            Zs.RemoveAt(0);
            return;
        }
        Zs.Add(z);
    }
}
class Program
{
    static void Main()
    {
        var r0 = new Room(1);
        Console.WriteLine("empty room not full: " + !r0.IsFull());

        var r1 = new Room(0);
        r1.AddZ("A");
        Console.WriteLine("cap 0 cannot add: " + (r1.Zs.Count == 0 && r1.IsFull()));

        var r2 = new Room(1);
        r2.AddZ("A");
        Console.WriteLine("one-roomer full after one: " + r2.IsFull());

        var r3 = new Room(2);
        r3.AddZ("A");
        Console.WriteLine("two-roomer not full after one: " + !r3.IsFull());

        var r4 = new Room(1);
        r4.AddZ("A");
        r4.AddZ("B"); // FIFO
        Console.WriteLine("fifo keeps newest: " + (r4.Zs.Count == 1 && r4.Zs[0] == "B"));
    }
}