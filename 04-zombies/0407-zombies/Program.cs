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
}
class Program
{
    static void Main()
    {
        //empty room that fits one zombie is not full
        var r0 = new R(1);
        Console.WriteLine("Empty one room not full: " + !r0.IsFull());
        //room with no capacity cannot fit any zombies
        //one-roomer becomes full when a zombie is added
        //two-roomer is not full when a zombie is added
        //second zombie consumes first zombie when added to a one-roomer
    }
}    
        