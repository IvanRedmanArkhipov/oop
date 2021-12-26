using lesson2;

BankAccount first = new BankAccount(4000111222333444, 3000, "vesa");
BankAccount second = new BankAccount(5412565232787454, 227, "masterguard");

Console.WriteLine($"{first.AccountNum} {first.Balance} {first.Type}");
Console.WriteLine($"{second.AccountNum} {second.Balance} {second.Type}");