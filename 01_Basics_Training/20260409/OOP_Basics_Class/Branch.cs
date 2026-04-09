namespace OOP_Basics_Class;


public class Branch : Bank
{
    //建構子預設
    public Branch() { }

    //建構子帶參數
    public Branch(int Number, string Name)
    {

        this.Number = Number;
        this.Name = Name;
    }

    //方法(一般)
    public void ShowInfo() {

        Console.WriteLine(Number);
    
    }

    //方法可被子類改---override
    public override string PrintTel(string Tel)
    {
        Console.WriteLine(Tel);
        return Tel;

    }

    //方法多載--overload
    public string PrintInfo(string name, string tel) {

        return $"{name}+{tel}";
    
    }



}