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
        var R = new Room(1);
        Console.WriteLine("Room Cpacity: " + R.Capacity);
        Console.WriteLine("Zombies: " + R.Zombies.Count);
        Console.WriteLine("Room is full: " + R.isFull());
    }
}

/*
test.skip("empty room that fits one zombie is not full", () => {});
test.skip("room with no capacity cannot fit any zombies", () => {});
test.skip("one-roomer becomes full when a zombie is added", () => {});
test.skip("two-roomer is not full when a zombie is added", () => {});
test.skip("second zombie consumes first zombie when added to a one-roomer", () => {});
// You are free to add more tests that you think are relevant!
*/
