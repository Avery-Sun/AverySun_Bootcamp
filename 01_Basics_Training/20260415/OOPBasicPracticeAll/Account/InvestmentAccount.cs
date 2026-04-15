namespace OOPBasicPracticeAll.Account;

public class InvestmentAccount : Account
{
    private double fee = 50.0;

    public InvestmentAccount(string name) : base(name) { }

    public override void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"{AccountName} (投資帳戶) 存入：{amount}");
    }

    public override bool Withdraw(double amount)
    {
        double totalRequired = amount + fee; // 提款金額 + 手續費

        if (Balance >= totalRequired)
        {
            Balance -= totalRequired;
            Console.WriteLine($"{AccountName} 提款：{amount}，手續費：{fee} (扣除總額：{totalRequired})");
            return true;
        }
        Console.WriteLine($"{AccountName} 提款失敗：餘額不足以支付金額與手續費");
        return false;
    }

    public override void PrintStatement()
    {
        base.PrintStatement();
        Console.WriteLine($"---- 投資帳戶 (提款手續費: {fee}) ----");
    }
}