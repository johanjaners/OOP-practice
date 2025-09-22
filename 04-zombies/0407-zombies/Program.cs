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
        r1.AddZ(new Z("A"));
        Console.WriteLine("0 room dont fit any: " + (r1.Zs.Count == 0));
        //one-roomer becomes full when a zombie is added
        //two-roomer is not full when a zombie is added
        //second zombie consumes first zombie when added to a one-roomer
    }
}