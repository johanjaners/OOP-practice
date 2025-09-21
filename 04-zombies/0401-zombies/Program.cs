class Room
{
    public int Capacity { get; set; } // property of room , readable setable
    public List<string> Zombies { get; } = new();
    public Room(int capacity) => this.Capacity = capacity;
    public bool isFull() => Zombies.Count >= Capacity;
    public void AddZombie(string zombie)
    {
        if (Capacity == 0) return;
        if (isFull() && Capacity > 0) // FIFO
        {
            Zombies.Add(zombie);
            Zombies.RemoveAt(0);
        }
        Zombies.Add(zombie);
    }
}
class Program
{
    static void Main()
    {
        //test.skip("empty room that fits one zombie is not full", () => {});
        var R0 = new Room(0);
        Console.WriteLine("Room Capacity: " + R0.Capacity);
        Console.WriteLine("Zombies: " + R0.Zombies.Count);
        Console.WriteLine("Room is full: " + R0.isFull());

        //test.skip("room with no capacity cannot fit any zombies", () => {});
        var R = new Room(0);
        Console.WriteLine("Room Capacity: " + R.Capacity);
        Console.WriteLine("Adding zombie A");
        R.AddZombie("A");
        Console.WriteLine("Zombies: " + R.Zombies.Count);
        Console.WriteLine("Room is full: " + R.isFull());

        // test.skip("one-roomer becomes full when a zombie is added", () => {});
        var R1 = new Room(1);
        Console.WriteLine("Room Capacity: " + R1.Capacity);
        Console.WriteLine("Adding zombie A");
        R1.AddZombie("A");
        Console.WriteLine("Zombies: " + R1.Zombies.Count);
        Console.WriteLine("Room is full: " + R1.isFull());

        // test.skip("two-roomer is not full when a zombie is added", () => {});
        var R2 = new Room(2);
        Console.WriteLine("Room Capacity: " + R2.Capacity);
        Console.WriteLine("Adding zombie A");
        R2.AddZombie("A");
        Console.WriteLine("Zombies: " + R2.Zombies.Count);
        Console.WriteLine("Room is full: " + R2.isFull());

        // test.skip("second zombie consumes first zombie when added to a one-roomer", () => {});
        var R3 = new Room(1);
        Console.WriteLine("Room Capacity: " + R3.Capacity);

        Console.WriteLine("Adding zombie A");
        R3.AddZombie("A");

        Console.WriteLine("Zombies: " + R3.Zombies.Count);
        Console.WriteLine("Room is full: " + R3.isFull());

        Console.WriteLine("Adding zombie B");
        R3.AddZombie("B");

        Console.WriteLine("no Zombies in room: " + R3.Zombies.Count);
        Console.WriteLine("Which Zombie in room: " + R3.Zombies);
        Console.WriteLine("Room is full: " + R3.isFull());
    }
}

/*




// You are free to add more tests that you think are relevant!
*/
