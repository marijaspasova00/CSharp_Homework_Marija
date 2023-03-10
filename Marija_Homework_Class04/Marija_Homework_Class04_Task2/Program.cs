// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Please enter a sentence: ");
string userInput = Convert.ToString(Console.ReadLine());
string[] splittedString = userInput.Split(" ");
for (int i = 0; i < splittedString.Length; i++)
{
    Console.WriteLine(splittedString[i]);
}
