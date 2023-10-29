using System;

// a) Base class Telephone
abstract class Telephone
{
    protected string phonetype;

    // Abstract method Ring
    public abstract void Ring();

    // Constructor
    public Telephone(string type)
    {
        phonetype = type;
    }
}

// Derived class ElectronicPhone
class ElectronicPhone : Telephone
{
    public ElectronicPhone() : base("Digital") { }

    // Implementing the abstract method Ring
    public override void Ring()
    {
        Console.WriteLine($"Ringing the {phonetype} phone.");
    }

    // Additional method for demonstration
    public void Run()
    {
        Ring(); // Calls the overridden Ring method
    }
}

// Polymorphic method demonstration
class DigitalPhone : Telephone
{
    public DigitalPhone() : base("Digital") { }

    public override void Ring()
    {
        Console.WriteLine($"Digital phone is ringing.");
    }
}

class TalkingPhone : Telephone
{
    public TalkingPhone() : base("Analog") { }

    public override void Ring()
    {
        Console.WriteLine($"Analog phone is ringing.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an ElectronicPhone and call its Ring method
        ElectronicPhone electronicPhone = new ElectronicPhone();
        electronicPhone.Run();

        // Demonstrate polymorphism
        Telephone[] phones = new Telephone[]
        {
            new ElectronicPhone(),
            new DigitalPhone(),
            new TalkingPhone()
        };

        foreach (Telephone phone in phones)
        {
            phone.Ring(); // Calls the appropriate Ring method based on the object's type
        }
    }
}
