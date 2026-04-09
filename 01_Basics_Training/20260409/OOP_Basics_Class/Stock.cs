namespace OOP_Basics_Class;


public class Stock: BrokerageFirm
{
    public string StockName { get; set; }
    public string StockId { get; set; }

    public decimal StockPrice { get; set; }

    //建構子預設
    public Stock() { }

    //建構子帶參
    public Stock(string name, decimal price) {
        this.StockName = name; // 先存進去
        this.StockPrice = price; // 先存進去
        if (this.StockPrice > 0) {

            Console.WriteLine(this.StockPrice);


        }
    
    }

    //方法改寫
    public override void FindAtJob()
    {

        Console.WriteLine(StockName);
       

    }
    //方法多載

    public string PrintInfo(string stockname, string id, string stockprice) {


        return $"{stockname}" + $"{id}" + $"{stockprice}";
    }




}
