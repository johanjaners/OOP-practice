class Z
{
    public string Name { get; set; }
    public Z(string name) => this.Name = name;
}
class R
{
    public int C { get; set; }
    public R(int c) => this.C = c;
    public List<Z> Zs { get; set; } = new();
    public bool IsFull() => Zs.Count >= C;
    public void AddZ(Z z)
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
        var ZA = new Z("A");
        var ZB = new Z("B");
        //empty room that fits one zombie is not full
        var r0 = new R(1);
        Console.WriteLine("Empty one room not full: " + !r0.IsFull());
        //room with no capacity cannot fit any zombies
        var r1 = new R(0);
        r1.AddZ(ZA);
        Console.WriteLine("0 room dont fit any: " + (r1.Zs.Count == 0));
        //one-roomer becomes full when a zombie is added
        var r2 = new R(1);
        r2.AddZ(ZA);
        Console.WriteLine("one room full after add: " + r2.IsFull());
        //two-roomer is not full when a zombie is added
        var r3 = new R(2);
        r3.AddZ(ZA);
        Console.WriteLine("two roomer not full after add: " + !r3.IsFull());
        // second zombie consumes first zombie when added to a one-roomer
        var r4 = new R(1);
        r4.AddZ(ZA);
        r4.AddZ(ZB);
        Console.WriteLine("Second eats first when added to one room: " + (r4.Zs.Count == 1 && r4.Zs[0] == ZB));
    }
}