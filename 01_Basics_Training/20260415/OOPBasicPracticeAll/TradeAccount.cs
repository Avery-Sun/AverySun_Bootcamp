namespace OOPBasicPracticeAll;

public abstract class TradeAccount
{
        protected string AccountID;
        public double Balance { get; protected set; }
        public int StockQuantity { get; protected set; }

        // 增加一個 Deposit 方法，不然沒錢買股票
        public void Deposit(double amount) { Balance += amount; }

        public abstract bool BuyStock(int quantity, double pricePerShare);
        public abstract bool SellStock(int quantity, double pricePerShare);

        public virtual void ShowPortfolio()
        {
            Console.WriteLine($"--- 帳戶: {AccountID} | 餘額: {Balance} | 持股: {StockQuantity} ---");
        }
    

}
