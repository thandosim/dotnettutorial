// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("The current time is " + DateTime.Now);
DateTime christmas = new DateTime(DateTime.Now.Year, 12, 25);
Console.WriteLine("There are " + (christmas - DateTime.Now).Days + " days until Christmas!");