namespace OOPBasicPracticeAll.Account;

public abstract class Account
{
    // 戶名與餘額，餘額設定為只有子類別能修改 (protected set)
    protected string AccountName;
    public double Balance { get; protected set; }

    // 建構子：強迫所有帳戶在出生時都要有戶名
    public Account(string name)
    {
        AccountName = name;
        Balance = 0; // 預設餘額為 0
    }

    // 抽象方法：所有分行「必須」實作存錢與領錢
    public abstract void Deposit(double amount);
    public abstract bool Withdraw(double amount);

    // 虛擬方法：提供預設的印表功能，子類別可以選擇性覆寫
    public virtual void PrintStatement()
    {
        Console.WriteLine($"[對帳單] 戶名：{AccountName} | 當前餘額：{Balance}");
    }
}
