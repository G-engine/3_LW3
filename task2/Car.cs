namespace task2;

public class Car : IEquatable<Car>
{
    public string Name { get; set; }
    public string Engine { get; set; }
    public uint MaxSpeed { get; set; }

    public Car(string name, string engine, uint maxSpeed)
    {
        Name = name;
        Engine = engine;
        MaxSpeed = maxSpeed;
    }
    public string ToString()
    {
        return Name;
    }

    public bool Equals(Car? car)
    {
        return (Name, Engine, MaxSpeed) ==
               (car?.Name, car?.Engine, car?.MaxSpeed);
    }
}