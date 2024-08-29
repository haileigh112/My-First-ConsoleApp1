// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("What is your name?");
var name = Console.ReadLine();
var CurrentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine} Hello, {name}, on {CurrentDate:d}");
Console.Write($"{Environment.NewLine} Press any key to exit...");
Console.ReadKey(true);