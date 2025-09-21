class Room
{
    public int C { get; set; }
    public string Z { get; set; }
    public Room(int c) => this.C = c;
    public List<string> Zs { get; } = new();
    public bool IsFull() => Zs.Count > C;
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