// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
#region Exercise 5

int branches = 12;
//int applesPerBranch = 8;
int applesPerBasket = 5;
int branchesTotal = 0;
int applesTotal = 0;
float basketTotal;
Console.WriteLine("Please insert the number of trees: ");
bool userInputNumOfTrees = int.TryParse(Console.ReadLine(), out int resultInputNumOfTrees);
if (userInputNumOfTrees)
{
    branchesTotal = branches * resultInputNumOfTrees;
    applesTotal = branchesTotal * resultInputNumOfTrees;
    basketTotal = (float)applesTotal / (float)applesPerBasket;
    basketTotal = (float)Math.Ceiling(basketTotal);
    Console.WriteLine("If we have " + resultInputNumOfTrees + " trees, with total of " + applesTotal + " apples, we need " + basketTotal + " to collect all the apples!");
}

#endregion
Console.WriteLine("======================================================");
#region Exercise 6

Console.WriteLine("Please enetr the first number: ");
bool firstNumber = int.TryParse(Console.ReadLine(), out int number1);
Console.WriteLine("Please enter the second number: ");
bool secondNumber = int.TryParse(Console.ReadLine(), out int number2);

if (number1 != 0 && number2 != 0)
{
    if (number1 > number2)
    {
        if (number1 % 2 == 0)
        {
            Console.WriteLine("The first number is even and is larger than the second!");
        }
        else
        {
            Console.WriteLine("The first number is odd and is larger than the second!");
        }
    }
    else if (number2 < number1)
    {
        if (number2 % 2 == 0)
        {
            Console.WriteLine("The second number is even and is larger than the first!");
        }
        else
        {
            Console.WriteLine("The second number is odd and is larger than the first!");
        }
    }
    else
    {
        if(number1 == number2)
        {
            if(number1 % 2 == 0 && number1 % 2 == 0) {
                Console.WriteLine("The nums are even and equal!");
            } else
            {
                Console.WriteLine("The nums are odd and equal!");
            }
        }
    }
}


#endregion
Console.WriteLine("======================================================");
#region Exercise 7

Console.WriteLine("Please enter one of the given numbers: \n 1, 2 or 3");
bool userInputNum = int.TryParse(Console.ReadLine(), out int userInputNumResult);
if(userInputNumResult == 1)
{
    Console.WriteLine("You got a new car!");
} else if(userInputNumResult == 2)
{
    Console.WriteLine("You got a new plane!");
} else if (userInputNumResult == 3)
{
    Console.WriteLine("You got a new bike!");
}
else
{
    Console.WriteLine("Invalid input! Please enter correct number!");
}

#endregion

