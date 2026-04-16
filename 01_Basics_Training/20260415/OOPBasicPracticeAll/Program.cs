//computer test

using OOPBasicPracticeAll;
using OOPBasicPracticeAll.Account;
using static OOPBasicPracticeAll.Balls;
//basic practice
//CalculatorBasic micosofteware1 = new("acer", "notebook", "intel5", "windows");
//Computer micosofteware2 = new CalculatorBasic("asus", "notbook", "intel7", "windows");
//Computer mac1 = new CalculatorBasic("apple", "notbook", "m4", "mac");
//micosofteware1.Version = "win11";
//micosofteware2.Version = "win10";
//mac1.Version = "os26.4";

//micosofteware1.PrintInfoWin();
//micosofteware2.PrintInfoWin();
//mac1.PrintInfoMac();

////use oop encapsulation,inheritance,polymorphism,abstract
//CalculatorBasic cb=new CalculatorBasic("dell","notbook","intel9","windows");
//cb.Version = "win11";
//cb.PrintInfoWin();

//cb.Plus(8,9);//17
//cb.Minus(10,45);//35
//cb.Times(50,78);//3900
//cb.Divide(5,78);//15
//cb.Mod(9, 67);//4

//Computer computer = new CalculatorBasic();
//computer.Version = "win12";
//computer.GetResult();
//computer.RAM(9);
//computer.Keyboard = "yellow duck";
//computer.Mouse = "razer";
//computer.GetResult();
//Computer.Open();

//account test
//Account mySavings = new SavingsAccount("Andy Lin");

//Console.WriteLine("=== 儲蓄帳戶測試開始 ===");
//mySavings.Deposit(1000);     // 存入 1000
//mySavings.Withdraw(200);      // 提款 200
//mySavings.PrintStatement();   // 印出對帳單
//Console.WriteLine();


//// --- 建立投資帳戶測試 ---
//Account myInvest = new InvestmentAccount("Luxemburg Project");

//Console.WriteLine("=== 投資帳戶測試開始 ===");
//myInvest.Deposit(500);       // 存入 500

//// 第一次提款：100 元 + 50 元手續費 = 150 元 (應成功)
//myInvest.Withdraw(100);

//// 第二次提款：1000 元 (餘額不足，應失敗)
//myInvest.Withdraw(1000);

//myInvest.PrintStatement();   // 印出對帳單

//STOCK TEST


//// 1. 測試普通股票帳戶 (StockAccount)
//Console.WriteLine("===== 1. 普通股票帳戶測試 =====");
//// 初始金額 10,000
//StockAccount userA = new StockAccount("Normal_User_01");
//userA.Deposit(10000); // 假設妳在類別裡有寫 Deposit，或直接在建構子給錢

//// 買入：5 股 * 1000 元 = 5000 元
//bool resultA = userA.BuyStock(5, 1000);

//if (resultA)
//{
//    Console.WriteLine("User A 買入成功！");
//}
//userA.ShowPortfolio();
//// 預期餘額：10000 - 5000 = 5000
//Console.WriteLine();


//// 2. 測試尊榮交易帳戶 (PremiumTradingAccount)
//Console.WriteLine("===== 2. 尊榮交易帳戶測試 =====");
//// 初始金額 10,000
//PremiumTradingAccount userB = new PremiumTradingAccount("Premium_User_99");
//userB.Deposit(10000);

//// 買入：5 股 * 1000 元 = 5000 元
//// 注意：這個方法內部會自動計算萬分之一的回饋金 (5000 * 0.001 = 5 元)
//bool resultB = userB.BuyStock(5, 1000);

//if (resultB)
//{
//    Console.WriteLine("User B 買入成功 (已自動計算回饋金)！");
//}
//userB.ShowPortfolio();
//// 預期餘額：10000 - 5000 + 5 = 5005
//Console.WriteLine();


//// 3. 測試邊界邏輯：持股不足能否賣出？
//Console.WriteLine("===== 3. 交易安全邏輯測試 =====");
//Console.WriteLine("嘗試賣出 10 股 (目前僅持股 5 股)...");
//bool sellResult = userB.SellStock(10, 1200);

//if (!sellResult)
//{
//    Console.WriteLine("系統攔截成功：持股不足，變數未被修改。");
//}
//userB.ShowPortfolio(); // 確認持股數量依然是 5，餘額也沒變


//choice ball color

ColorScanner myScanner = new ColorScanner();

Balls[] myBalls = new Balls[]
{
            new YellowBall(),
            new BlueBall()
};

Console.WriteLine("開始分辨球的顏色");


foreach (var ball in myBalls)
{
   
    myScanner.Scan(ball);
}

