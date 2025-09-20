


class Room
{
    public int Capacity { get; set; } // property , room has a capacity, assigned, and readable
    public List<string> Zombies { get; } = new(); // property, room has a list of zombies, initialize empty at creation of object, only readable
    public Room(int capacity) // constructor, instance of a room must have capacity at creation
    {
        this.Capacity = capacity;
    }

/*
    public void isFull()
    {
        if (Capacity == Zombies.Count)
        {
            return true;
        }
        elseif(Capacity > Zombies.Count)
        {
            return false;
        }
    }
*/


    // method, adds zombie(string) to list of zombies if capacity > 0 && Room is not full
    public void Add(string zombie) => Zombies.Add(zombie);

}

public class Program
{
    static void Main()
    {

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