// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

DateTime threedaysfromnow = DateTime.Now.AddDays(3);
Console.WriteLine(threedaysfromnow);
DateTime onemonthfromnow = DateTime.Now.AddMonths(1);
Console.WriteLine(onemonthfromnow);
DateTime onemonthandthreedaysfromnow = DateTime.Now.AddMonths(1).AddDays(3);
Console.WriteLine(onemonthandthreedaysfromnow);
DateTime oneyearandthreemonthsfromnow = DateTime.Now.AddYears(1).AddMonths(3);
Console.WriteLine(oneyearandthreemonthsfromnow);
DateTime currentmonth = DateTime.Now;
Console.WriteLine(currentmonth);
DateTime currentyear = DateTime.Now;
Console.WriteLine(currentyear);