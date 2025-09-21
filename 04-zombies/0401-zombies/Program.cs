class Room
{
    public int Capacity { get; set; } // property of room , readabke setable
    public List<string> Zombies { get;} = new();
    public Room(int capacity) => this.Capacity = capacity;
    public void AddZombie(string zombie) => Zombies.Add(zombie);
    public bool isFull() => Zombies.Count >= Capacity;

}




class Program
{
    static void Main()
    {
        var R = new Room(0);

        Console.WriteLine(R.isFull());
    }
}