// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);
Console.WriteLine("The squares of the numbers are: ");
foreach (var square in squares)
{
    Console.WriteLine(square);
}
