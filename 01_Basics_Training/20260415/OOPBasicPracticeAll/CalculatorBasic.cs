namespace OOPBasicPracticeAll;

public class CalculatorBasic:Computer
{
    protected string Brand;
    protected string Type;
    protected string Function;

    private int price { get; set; }
    private int ram { get; set; }

    public override string Mouse { get; set; } = "Logitech";
    public override string Keyboard { get; set; } = "HHKB";

    //constuctor
    public CalculatorBasic() { }
    public CalculatorBasic(string brand, string type, string cpu, string system)
        : base(cpu, system) 
    {
        Brand = brand;
        Type = type;
    }

   
    public override int RAM(int ram)
    {
        Console.WriteLine($"Expanded to {ram}!");
        return ram;

    }

    public override string GetResult(string mouse= "Logitech", string keyboard= "Logitech") {

        Console.WriteLine($"{this.Mouse} and {this.Keyboard}");
        return $"{this.Mouse} and {this.Keyboard}";
    }
   

}
