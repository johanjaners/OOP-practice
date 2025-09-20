
class Room
{
    public int Capacity { get; set; } // property , room has a capacity, assigned, and readable
    public List<string> Zombies { get; } = new(); // property, room has a list of zombies, initialize empty at creation of object, only readable
    public Room(int capacity) // constructor, instance of a room must have capacity at creation
    {
        this.Capacity = capacity;
    }

    // method cheks if room is full, bool
    public bool isFull() => Zombies.Count >= Capacity;

    // method, adds zombie(string) to list of zombies if capacity > 0 and capacoty > no of zombies
    public void Add(string zombie)
    {
        if (isFull()) return;
        Zombies.Add(zombie);
    }
}

class Program
{
    static void Main()
    {
        var R = new Room(2);
        R.Add("A");
        R.Add("B");
        R.Add("C");
        R.Add("D");
        R.Add("E");
        R.Add("F");

        Console.WriteLine(IsFull());
        Console.WriteLine(R.Zombies.Count);
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