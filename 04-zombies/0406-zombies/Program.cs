class Room
{
    public int C { get; set; }
    public Room(int c) => this.C = c;
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
        Console.WriteLine("no cap room cannot fit any: " + (r1.IsFull() && r1.Zs.Count == 0));
        //one-roomer becomes full when a zombie is added
        var r2 = new Room(1);
        r2.AddZ("A");
        Console.WriteLine("one room full after one add: " + r2.IsFull());
        //two-roomer is not full when a zombie is added
        var r3 = new Room(2);
        r2.AddZ("A");
        Console.WriteLine("two roomer not full after one add: " + !r3.IsFull());
        //second zombie consumes first zombie when added to a one-roomer    
        var r4 = new Room(1);
        r4.AddZ("A");
        r4.AddZ("B");
        Console.WriteLine("second eats first when added to one roomer: " + (r4.IsFull() && r4.Zs.Count == 1 && r4.Zs[0] == "B"));
    }
}