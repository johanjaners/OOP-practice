class Zombie
{
    public string Name { get; set}    
    public Zombie(string name) => this.Name = name;
}
class Room
{
    public int C { get; set; }
    public Room(int c) => this.C = c;
}
        
        //empty room that fits one zombie is not full
        //room with no capacity cannot fit any zombies
        //one-roomer becomes full when a zombie is added
        //two-roomer is not full when a zombie is added
        //second zombie consumes first zombie when added to a one-roomer