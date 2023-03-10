// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int SumOfNumbersInNumber(int number)
{
    int sum = 0;
    int cifra;
    while (number > 0)
    {
        cifra = number % 10;
        sum += cifra;
        number = number / 10;
    }

    return sum;

}
Console.WriteLine(SumOfNumbersInNumber(123));
Console.WriteLine(SumOfNumbersInNumber(12345));