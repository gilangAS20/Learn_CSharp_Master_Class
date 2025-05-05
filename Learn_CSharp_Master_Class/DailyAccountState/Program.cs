// See https://aka.ms/new-console-template for more information

using DailyAccountStateClass;

DailyAccountState dailyAccountState = new DailyAccountState(2000, -200);

Console.WriteLine(dailyAccountState.EndOfDayState);
Console.WriteLine(dailyAccountState.Report);
