
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
#region Task 1

Console.WriteLine("Enter the first number: ");
bool number1 = int.TryParse(Console.ReadLine(), out int number1Result);
Console.WriteLine("Enter the second number: ");
bool number2 = int.TryParse(Console.ReadLine(), out int number2Result);
Console.WriteLine("Enter the operator: ");
bool inputOperator = char.TryParse(Console.ReadLine(), out char inputOperatorResult);
if(number1 && number2 && inputOperator)
{ 
    if(inputOperatorResult == '+')
    {
        int sum = number1Result + number2Result;
        Console.WriteLine("The sum is: " + sum );
    } 
    else if( inputOperatorResult == '-')
    {
        int diff = number1Result - number2Result;
        Console.WriteLine("The difference is: " + diff);
    } 
    else if( inputOperatorResult == '*')
    {
        int multiply = number1Result * number2Result;
        Console.WriteLine("The product is: " + multiply);
    } 
    else if( inputOperatorResult == '/')
    {
        int divide = number1Result / number2Result;
        Console.WriteLine("The quotient is: " + divide);
    }
    else
    {
        Console.WriteLine("You entered wrong operator! Please try again!");
    }
}

#endregion
Console.WriteLine("=========================================================");
#region Task 2

Console.WriteLine("Enter the first number: ");
bool firstNumber = int.TryParse(Console.ReadLine(), out int firstNumberResult);
Console.WriteLine("Enter the second number: ");
bool secondNumber = int.TryParse(Console.ReadLine(), out int secondNumberResult);
Console.WriteLine("Enter the third number: ");
bool thirdNumber = int.TryParse(Console.ReadLine(), out int thirdNumberResult);
Console.WriteLine("Enter the forth number: ");
bool forthNumber = int.TryParse(Console.ReadLine(), out int forthNumberResult);
int sum1 = firstNumberResult + secondNumberResult + thirdNumberResult + forthNumberResult;
int avg = sum1 / 4;
Console.WriteLine("The average of " + firstNumberResult + ", " + secondNumberResult + ", " + thirdNumberResult + " and " + forthNumberResult + " is: " + avg);

#endregion
Console.WriteLine("=========================================================");
#region Task 3

Console.WriteLine("Input the first number: ");
bool firstNumber1 = int.TryParse(Console.ReadLine(), out int firstNumber1Result);
Console.WriteLine("Input the second number: ");
bool secondNumber1 = int.TryParse(Console.ReadLine(), out int secondNumber1Result);
int tmp = 0; // temporary variable 
tmp = firstNumber1Result;
firstNumber1Result = secondNumber1Result;
secondNumber1Result = tmp;
Console.WriteLine("After swaping: ");
Console.WriteLine("First number: " + firstNumber1Result);
Console.WriteLine("Second number: " + secondNumber1Result);

#endregion
