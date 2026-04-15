namespace OOPBasicPracticeAll.Account;

public class SavingsAccount : Account
{
    // 利用 : base 把戶名傳回給父類別建構子
    public SavingsAccount(string name) : base(name) { }

    public override void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"{AccountName} 存入：{amount}");
    }

    public override bool Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"{AccountName} 提款成功：{amount}");
            return true;
        }
        Console.WriteLine($"{AccountName} 提款失敗：餘額不足");
        return false;
    }

    public override void PrintStatement()
    {
        base.PrintStatement(); // 先執行爸爸的印表邏輯
        Console.WriteLine("---- 這是一般儲蓄帳戶 ----");
    }
}