

namespace OOPBasicPracticeAll;

public class PremiumTradingAccount : StockAccount
{
    private double cashbackRate = 0.001;
    public PremiumTradingAccount(string accountid) : base(accountid) { }

    public override bool BuyStock(int quantity, double pricePerShare)
    {
        double sum = quantity * pricePerShare;
        double netCost = sum - (sum * cashbackRate); // 計算回饋後的淨支出

        if (Balance < netCost) return false;

        Balance -= netCost;
        StockQuantity += quantity;
        return true;
    }

    public override bool SellStock(int quantity, double pricePerShare)
    {
        // 1. 檢查：肚子裡的持股夠不夠賣？
        if (this.StockQuantity >= quantity)
        {
            // 2. 計算這筆交易原本該得的錢
            double tradeAmount = quantity * pricePerShare;

            // 3. 設定變數：減少持股量
            this.StockQuantity -= quantity;

            // 4. 設定變數：增加餘額 (交易金額 + 100元獎勵金)
            // 這就是妳說的：用方法的模式去實作複雜的變數設定
            double totalIn = tradeAmount + 100;
            this.Balance += totalIn;

            Console.WriteLine($"[尊榮回饋] 賣出成功！獲得金額：{tradeAmount}，額外獎勵：100。總計入帳：{totalIn}");
            return true;
        }
        else
        {
            Console.WriteLine($"[交易失敗] 持股不足，無法賣出 {quantity} 股。");
            return false;
        }
    }
    public override void ShowPortfolio()
    {
        Console.WriteLine($"帳號{AccountID}");
        Console.WriteLine($"餘額: {Balance}");
        Console.WriteLine($"持股數{StockQuantity}");

    }//印出帳號、餘額、持股數。

}
