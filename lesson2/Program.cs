using lesson2;

BankAccount first = new BankAccount(4000111222333444, 3000, "vesa");
BankAccount second = new BankAccount(5412565232787454, 227, "masterguard");

first.ToString();
Console.WriteLine(first == second);