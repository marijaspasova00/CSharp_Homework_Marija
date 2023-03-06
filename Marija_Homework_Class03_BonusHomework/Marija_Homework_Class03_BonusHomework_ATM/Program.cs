// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");



//bool withdraw = int.TryParse(Console.ReadLine(), out int withdrawResult);
int balance = 100000;
bool choice = int.TryParse(Console.ReadLine(), out int choiceResult);
bool quit = false;


while (!quit)
{
    if (choice && choiceResult == 1 || choiceResult == 2 || choiceResult == 3)
    {
        if (choiceResult == 1)
        {
            Console.WriteLine("You have {0}$ on your account.", balance);
           // break;
        }
        else if (choiceResult == 2)
        {
            Console.WriteLine("What amound of money You need?");
            bool withdraw = int.TryParse(Console.ReadLine(), out int withdrawResult);
            if (withdrawResult < balance)
            {
                Console.WriteLine("You have successfully withdraw {0}$ and you left {1}$ on your balance", withdrawResult, (balance - withdrawResult));
            }
            else if (withdrawResult > balance)
            {
                Console.WriteLine("You cannot withdraw {0}$ because your balance is {1}$. Please try again with appropriate amount!", withdrawResult, balance);
            }

        }
        else if (choiceResult == 3)
        {
            Console.WriteLine("Have a good day/night!");
            quit = true;
            break;
        }
    }
    else
    {
        Console.WriteLine("Invalid input! You must eneter 1, 2 or 3!");
        break;
    }
    Console.WriteLine("Do you want to take some other actions? (Y/N)");
    bool yesOrNoChoice = char.TryParse(Console.ReadLine(), out char yesOrNoChoiceResult);
    if (yesOrNoChoiceResult == 'N')
    {
        quit = true;
    }
    else if (yesOrNoChoiceResult == 'Y') 
    {
        quit = false;
    }
}



