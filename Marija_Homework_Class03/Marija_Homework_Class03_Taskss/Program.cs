// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region Task 1

int[] arrayOfIntegers = new int[6];
Console.WriteLine("Input 6 numbers: \n");
int sum = 0;
//bool userInput = int.TryParse(Console.ReadLine(), out int userInoutResult);
for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Enter a number: ");
    arrayOfIntegers[i] = Convert.ToInt32(Console.ReadLine());
    if (arrayOfIntegers[i] % 2 == 0)
    {
        sum += arrayOfIntegers[i];
    }
}
for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Inputed numbers are: " + arrayOfIntegers[i]);
}
Console.WriteLine("The sum of the even numbers is: {0}", sum);


#endregion
Console.WriteLine("================================================");
#region Task 2

string[] studentsG1 = new string[5] { "Marija", "Viktor", "Elena", "Monika", "Martin" };
string[] studentsG2 = new string[5] { "Blagoj", "Katerina", "Teo", "Nikola", "Tina" };
Console.WriteLine("From which group do you want to list students?");
bool choice = int.TryParse(Console.ReadLine(), out int choiceResult);
if (choiceResult == 1)
{
    Console.WriteLine("Students from G1 are: \n");
    for (int i = 0;i < studentsG1.Length; i++)
    {
        Console.WriteLine(studentsG1[i]);
    }
} 
else if (choiceResult == 2)
{
    Console.WriteLine("Students from G2 are: \n");
    for (int i = 0; i < studentsG2.Length; i++)
    {
        Console.WriteLine(studentsG2[i]);
    }
}
else
{
    Console.WriteLine("You entered invalid number, you must enter 1 or 2");
}


#endregion
