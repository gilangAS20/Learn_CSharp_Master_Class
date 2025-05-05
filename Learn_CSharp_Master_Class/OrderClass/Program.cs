// See https://aka.ms/new-console-template for more information


using OrderClass;

Order orderOne = new Order("crackers", DateTime.Now);

Console.WriteLine($"OrderDate: {orderOne.Date}");
orderOne.Date = DateTime.Now.AddDays(1);
Console.WriteLine($"OrderDate after changed: {orderOne.Date}");

Console.WriteLine($"OrderItem: {orderOne.Item}");