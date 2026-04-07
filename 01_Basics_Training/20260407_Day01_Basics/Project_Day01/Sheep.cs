namespace Day01_Basics;

public class Sheep:Animal
{
   
    public string Food { get; set; }

    public Sheep() {
        Name = "Unknown";
        Food = "meat";
    
    }

    public Sheep(string name)
    {
        Name = name;
        Food = "meat";
    }
    public override string Sound() => ($"{Name} baas.");


}
