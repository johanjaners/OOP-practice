class Room
{
    public int Capacity { get; set; } // property of room , readabke setable
    public string Zombie { get; set; } // 
    public List<Zombie> Zombies { get; set; } = new();
    public Room(int capacity) => this.Capacity = capacity;
    public AddZombie(string zombie) => Zombies.Add(zombie);
    public boolean isFull() => Zombies.Count >= Capacity;

}




class Program
{
    static void Main()
    {
        var R = new Room(0);

        Console.WriteLine(R.isFull);
    }
}