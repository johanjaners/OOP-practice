class R
{
    public int C { get; set; }
    public R(int c) => this.C = c;
    public List<string> Zs { get; } = new();
    public bool IsFull() => Zs.Count >= C;
    public void AddZ(string z)
    {
        if (C == 0) return;
        Zs.Add(z);
    }
}
class Program
{
    static void Main()
    {
        //empty room that fits one zombie is not full
        var r0 = new R(1);
        Console.WriteLine("Empty one room not full: " + !r0.IsFull());
        //room with no capacity cannot fit any zombies
        var r1 = new R(0);
        r1.AddZ("A");
        Console.WriteLine("No cap room cant fit any: " + (r1.Zs.Count == 0));
        //one-roomer becomes full when a zombie is added
        var r2 = new R(1);
        r2.AddZ("A");
        Console.WriteLine("One roomer full after one add: " + r2.IsFull());
        //two-roomer is not full when a zombie is added
        var r3 = new R(2);
        r3.AddZ("A");
        Console.WriteLine("Two roomer not full after one add: " + !r3.IsFull());
        //second zombie consumes first zombie when added to a one-roomer   
    }
}