
//second zombie consumes first zombie when added to a one-roomer

class Room
{
    public int C { get; set; }
    public Room(int c) => this.C = c;
    public string? Z { get; set; }
    public List<string> Zs { get; set; } = new();
    public bool IsFull() => Zs.Count >= C;
    public void AddZ(string z)
    {
        if (C == 0) return;
        if (IsFull()) Zs.RemoveAt(0);
        Zs.Add(z);
    }

}


class Program
{
    static void Main()
    {
        //empty room that fits one zombie is not full
        var r0 = new Room(1);
        Console.WriteLine("empty one room not full: " + !r0.IsFull());

        //room with no capacity cannot fit any zombies
        var r1 = new Room(0);
        r1.AddZ("A");
        Console.WriteLine("no cap fit no zombie: " + (r1.Zs.Count == 0 && r1.IsFull()));

        //one-roomer becomes full when a zombie is added
        var r2 = new Room(1);
        r2.AddZ("A");
        Console.WriteLine("one room full w one: " + r2.IsFull());

        //two-roomer is not full when a zombie is added
        var r3 = new Room(2);
        r3.AddZ("A");
        Console.WriteLine("Two room not full w one: " + !r3.IsFull());

        //second zombie consumes first zombie when added to a one-roomer
        var r4 = new Room(1);
        r4.AddZ("A");
        r4.AddZ("B");
        Console.WriteLine("Second zombie eats first when added to one room: " + (r4.Zs.Count == 1 && r4.Zs[0] == "B"));
    }
}