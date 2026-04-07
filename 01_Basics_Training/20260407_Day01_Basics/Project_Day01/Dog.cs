namespace Day01_Basics;

public class Dog:Animal
{
   
    public string Food { get; set; }

    public Dog() {
        Name = "Unknown";
        Food = "meat";
    
    }

    public Dog(string name)
    {
        Name = name;
        Food = "meat";
    }
    public override string Sound() => ($"{Name} barks.");


}
