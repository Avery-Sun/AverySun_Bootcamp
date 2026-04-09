using OOP_Basics_Class;

//Bank bank = new Bank();
//bank.Name = "taipei bank";
//bank.Tel = "02-2700-2000";
//bank.Number = 1;
//string result = bank.PrintTel(bank.Tel);
//Console.WriteLine(result);

//bank.PrintInfo();



//Branch branch = new Branch();
//branch.Name = "Taichung";
//branch.Tel = "04-0900-0800";
//branch.Number = 2;

//branch.ShowInfo();
//string telNumber = branch.Tel;
//branch.PrintTel(telNumber);

////--------
//Bank bank2 = new Bank();

//bank2.Name = "taipei cityhall";
//bank2.Tel = "02-0900-0800";
//bank2.Number = 15;

//BrokerageFirm bf = new BrokerageFirm();
//bf.DeptNo = 1;
//bf.Name = "taipei";
//bf.Department = "Account";
//bf.Job = "Accountant";
//bf.FindAtJob();
//bf.PrintInfo();

Stock stock = new Stock();
stock.Name = "taiwan";
stock.StockName = "TSMC";
stock.StockPrice = 2000;
stock.StockId = "2330";
stock.PrintInfo();
Stock stock2 = new Stock("0050",80);
stock2.PrintInfo();


