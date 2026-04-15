

namespace OOPBasicPracticeAll;

public abstract class Hardware
{
    public abstract string Mouse { get; set; }
    public abstract string Keyboard { get; set; }
    public abstract string GetResult(string mouse = "Logitech", string keyboard = "Logitech");
}
public abstract class Computer :Hardware
{
    protected string Cpu;
    protected string System;
    protected static string power;
    public string Version { get; set; }


    //constructor
    public Computer(){}
    public Computer(string cpu, string system)
    {

        Cpu = cpu;
        System = system;

    }

    //method
    public void PrintInfoWin()
    {

        Console.WriteLine($"This Computer cpu:{Cpu} system:{System} version:{Version} ");

    }

    public void PrintInfoMac()
    {

        Console.WriteLine($"This Computer cpu:{Cpu} system:{System} version:{Version} ");

    }

    public int Plus(int num1,int num2)
    {

        int number1 = num1;
        int number2 = num2;
        int number3 = number1 + number2;
        Console.WriteLine($"{number1} + {number2} ={number3}");
        return number3;
        


    }
    public int Minus(int num1, int num2)
    {

        int number1 = num1;
        int number2 = num2;
        int number3 = number2 - number1;
        Console.WriteLine($"{number2} - {number1} ={number3}");
        return number3;


    }

    public int Times(int num1, int num2)
    {

        int number1 = num1;
        int number2 = num2;
        int number3 = number2 * number1;
        Console.WriteLine($"{number2} * {number1} ={number3}");
        return number3;

    }

    public int Divide(int num1, int num2)
    {


        int number1 = num1;
        if (number1 == 0)
        {

            Console.WriteLine($"key-in the new number:");
            return 0;
        }
        else
        {
            int number2 = num2;
            int number3 = number2 / number1;
            Console.WriteLine($"{number2} / {number1} ={number3}");
            return number3;
        }
        


    }

    public int Mod(int num1, int num2)
    {
        int number1 = num1;
        if (number1 == 0)
        {

            Console.WriteLine($"key-in the new number:");
            return 0;
        }
        else
        {

            int number2 = num2;
            int number3 = number2 % number1;
            Console.WriteLine($"{number2} % {number1} ={number3}");
            return number3;
        }
        
    }

    public virtual int RAM(int ram) {

        Console.WriteLine("Fixed RAM,can't expanded");
        return ram; 
    }

    public static void Open() {

        string power = "on";
        Console.WriteLine($"The computer power is on!");
    
    }

    
}
