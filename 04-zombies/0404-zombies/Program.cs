class Room
{
    public int C { get; set; }
    public string? Z { get; set; }
    public List<string> Zs { get; set; } = new();
    public Room(int c) => this.C = c;
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
        // empty room that fits one zombie is not full
        var r0 = new Room(1);
        Console.WriteLine("Empty one room not full: " + !r0.IsFull());

        //room with no capacity cannot fit any zombies
        var r1 = new Room(0);
        r1.AddZ("A");
        Console.WriteLine("no cap room cant fit any zombie: " + (r1.Zs.Count == 0));

        //one-roomer becomes full when a zombie is added;
        var r2 = new Room(1);
        r2.AddZ("A");
        Console.WriteLine("one room gets full after one: " + r2.IsFull());

        //two-roomer is not full when a zombie is added
        var r3 = new Room(2);
        r3.AddZ("1");
        Console.WriteLine("two room not full after one: " + !r3.IsFull());

        //second zombie consumes first zombie when added to a one-roomer
        var r4 = new Room(1);
        r4.AddZ("A");
        r4.AddZ("B");
        Console.WriteLine("Second eats first when added to one room: " + (r4.Zs.Count == 1 && r4.Zs[0] == "B"));
    }
}

        // empty room that fits one zombie is not full
        //room with no capacity cannot fit any zombies
        //one-roomer becomes full when a zombie is added
        //two-roomer is not full when a zombie is added
        //second zombie consumes first zombie when added to a one-roomer