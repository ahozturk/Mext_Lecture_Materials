using App.Console;

System.Console.WriteLine(BankGenerator.Generate(BankType.Akbank).GetPaid(1000));
System.Console.WriteLine(BankGenerator.Generate(BankType.Yapikredi).GetPaid(1000));
System.Console.WriteLine(BankGenerator.Generate(BankType.Vakifbank).GetPaid(1000));
System.Console.WriteLine(BankGenerator.Generate(BankType.ZiraatBank).GetPaid(1000));

BankGenerator.Generate(BankType.Akbank);