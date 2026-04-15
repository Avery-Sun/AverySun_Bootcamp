namespace OOPBasicPracticeAll;

public class StockAccount : TradeAccount
{

    public StockAccount(string accountid)
    {
        AccountID = accountid;
    }

    public override bool BuyStock(int quantity, double pricePerShare)
    {
        double sum = quantity * pricePerShare;
        if (sum > Balance) return false;

        Balance -= sum;
        StockQuantity += quantity; // 這是最重要的變數設定
        return true;
    }

    public override bool SellStock(int quantity, double pricePerShare)
    {
        if (StockQuantity < quantity) return false;

        Balance += (quantity * pricePerShare);
        StockQuantity -= quantity; // 賣出要減持股
        return true;
    }
    public override void ShowPortfolio()
    {
        Console.WriteLine($"帳號{AccountID}");
        Console.WriteLine($"餘額: {Balance}");
        Console.WriteLine($"持股數{StockQuantity}");

    }//印出帳號、餘額、持股數。

}
