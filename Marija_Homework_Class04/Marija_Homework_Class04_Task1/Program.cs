// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Please enter the sentence: ");
string userInputString = Convert.ToString(Console.ReadLine());
Console.WriteLine("The result is: ");
string subString = userInputString.Substring(userInputString.Length - 5);
Console.WriteLine(subString);
