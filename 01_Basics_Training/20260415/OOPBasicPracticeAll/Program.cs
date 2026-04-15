//computer test

using OOPBasicPracticeAll;
//basic practice
CalculatorBasic micosofteware1 = new("acer", "notebook", "intel5", "windows");
Computer micosofteware2 = new CalculatorBasic("asus", "notbook", "intel7", "windows");
Computer mac1 = new CalculatorBasic("apple", "notbook", "m4", "mac");
micosofteware1.Version = "win11";
micosofteware2.Version = "win10";
mac1.Version = "os26.4";

micosofteware1.PrintInfoWin();
micosofteware2.PrintInfoWin();
mac1.PrintInfoMac();

//use oop encapsulation,inheritance,polymorphism,abstract
CalculatorBasic cb=new CalculatorBasic("dell","notbook","intel9","windows");
cb.Version = "win11";
cb.PrintInfoWin();

cb.Plus(8,9);//17
cb.Minus(10,45);//35
cb.Times(50,78);//3900
cb.Divide(5,78);//15
cb.Mod(9, 67);//4

Computer computer = new CalculatorBasic();
computer.Version = "win12";
computer.GetResult();
computer.RAM(9);
computer.Keyboard = "yellow duck";
computer.Mouse = "razer";
computer.GetResult();
Computer.Open();
