class R
{
    public int C { get; set; }
    public R(int c) => this.C = c;

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
        var r0 = new R(1);
        Console.WriteLine("empty one roomer not full: " + !r0.IsFull());
        //room with no capacity cannot fit any zombies
        var r1 = new R(0);
        Console.WriteLine("no cap room dont fit any: " + (r1.Zs.Count == 0));
        //one-roomer becomes full when a zombie is added
        var r2 = new R(1);
        r2.AddZ("A");
        Console.WriteLine("one room full after add: " + r2.IsFull());
        //two-roomer is not full when a zombie is added
        var r3 = new R(2);
        r3.AddZ("A");
        Console.WriteLine("two room not full after add: " + !r3.IsFull());
        //second zombie consumes first zombie when added to a one-roomer
        var r4 = new R(1);
        r4.AddZ("A");
        r4.AddZ("B");
        Console.WriteLine("Second eats first when added to one roomer: " + (r4.Zs.Count == 1 && r4.Zs[0] == "B"));
    }
}
