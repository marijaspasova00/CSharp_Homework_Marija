// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
string Substrings()
{
    string result = Console.WriteLine("Hello from SEDC Codecademy 2023!");
    return result;
}
string result1 = Substrings();

bool userInputNumber = int.TryParse(Console.ReadLine(), out int userInputNumberResult);
string subString = result1.Substring(userInputNumberResult);
int length = result1.Length;
Console.WriteLine(subString);
Console.WriteLine(length);