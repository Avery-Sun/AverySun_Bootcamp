
namespace OOP_Basics_Class;

public class Bank
{
    public int Number;
    public string Name;
    public string Tel;



    public virtual string PrintTel(string tel)
    {
        return tel;
    }

    public void PrintInfo()
    {

        Console.WriteLine(Number);
        Console.WriteLine(Name);
        Console.WriteLine(Tel);


    }


}
