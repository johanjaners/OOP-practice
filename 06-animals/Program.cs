//base class
class Animal
{
    public void Eat() => Console.WriteLine("Eating..");
}
//derived class, inherits Animal, (if non, inherits object which is ultimate base class)
class Dog : Animal
{
    public void Bark() => Console.WriteLine("Woof!");
}

class Program
{
    static void Main()
    {
        Dog d = new Dog();
        d.Eat(); // inherited from animal
        d.Bark(); // defined in dog
    }
}