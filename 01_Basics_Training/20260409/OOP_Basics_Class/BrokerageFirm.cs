namespace OOP_Basics_Class;

public class BrokerageFirm
{
    public string Department;
    public string Name;
    public int DeptNo;
    public string Job;

    //建構子
    public BrokerageFirm() { }

    //建構子方法
    public BrokerageFirm(string Department, string Name) {

        Console.WriteLine(Department);

        Console.WriteLine(Name);

    }

    //方法改寫
    public virtual void FindAtJob() {

        Console.WriteLine(Department);
        Console.WriteLine(Job);
    
    }

    //方法多載
    public void PrintInfo() {

        Console.WriteLine(Department);
        Console.WriteLine(Job);
        Console.WriteLine(Name);
        Console.WriteLine(DeptNo);

    }


}
