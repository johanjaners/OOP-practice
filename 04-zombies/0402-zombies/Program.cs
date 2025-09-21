class Room
{
    public int Capacity { get; set; }
    public string Zombie { get; set; }
    public List<Zombie> Zombies { get; } = new();
    public Room(int capacity) => this.Capacity = capacity;

    public bool IsFull() => Zombies.Count >= Capacity;

    public void AddZombie(string zombie)
    {
        if (Capacity == 0) return;
        if (IsFull() && Capacity > 0)
        {
            Zombies.Add(zombie);
            Zombies.RemoveAt(0);
            return;
        }
        Zombies.Add(zombie);
    }






}