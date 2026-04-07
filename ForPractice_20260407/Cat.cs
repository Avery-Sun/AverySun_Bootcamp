namespace ForPractice_20260407;

public class Cat:Animal
{
   
    public string Food { get; set; }

    public Cat() {
        Name = "Unknown";
        Food = "meat";
    
    }

    public Cat(string name)
    {
        Name = name;
        Food = "meat";
    }
    public override string Sound() => ($"{Name} meows.");


}
