
class Room
{
    public int Capacity { get; set; } // property , room has a capacity, assigned, and readable
    public List<string> Zombies { get; } = new(); // property, room has a list of zombies, initialize empty at creation of object, only readable
    public Room(int capacity) // constructor, instance of a room must have capacity at creation
    {
        this.Capacity = capacity;
    }

    // method, checks if room is full, return bool
    public bool IsFull() => Zombies.Count >= Capacity;

    // method, adds zombie(string) to list of zombies if capacity > 0, 
    public void Add(string zombie)
    {
        if (Capacity == 0) return;     // Cant add zombie to zero roomer
        if (IsFull() && Capacity > 0) // FIFO Eviciton if room is full and Capacity > 0
        {
            Zombies.Add(zombie);
            Zombies.RemoveAt(0);
            return;
        }
        Zombies.Add(zombie);        // add zombie if room is not full and capacity abouve 0
    }
}

class Program
{
    static void Main()
    {

        var R = new Room(1);
        Console.WriteLine("Created new room with capacity " + R.Capacity);
        Console.WriteLine("Zombie A added");
        R.Add("A");
        Console.WriteLine("Zombie B added");
        R.Add("B");
        // Console.WriteLine("Zombie C added");
        // R.Add("C");
        Console.WriteLine("Number of in room zombies: " + R.Zombies.Count);
        Console.WriteLine("Is room full? " + R.IsFull());
        Console.WriteLine("Zombie in room: ");
        foreach (var z in R.Zombies)
            Console.WriteLine(z);
    }
}



/*
test("room is full", () => {
  const room = createRoom(0);

  const isRoomFull = room.isFull();

  ok(isRoomFull);
});

test.skip("empty room that fits one zombie is not full", () => {});

test.skip("room with no capacity cannot fit any zombies", () => {});

test.skip("one-roomer becomes full when a zombie is added", () => {});

test.skip("two-roomer is not full when a zombie is added", () => {});

test.skip("second zombie consumes first zombie when added to a one-roomer", () => {});

// You are free to add more tests that you think are relevant!


import { ok } from "node:assert/strict";
import { test } from "node:test";

const createRoom = (capacity: number) => {
  const _capacity = capacity;

  return {
    isFull: () => true,
  };
};

*/