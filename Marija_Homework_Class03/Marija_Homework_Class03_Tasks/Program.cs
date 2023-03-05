// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region Exercise 4

using System.Diagnostics.CodeAnalysis;

string[] arrayWithWords = new string[] { "Hello", "from", "Marija", "SEDC", "student"};
double[] arrayWithDecimalNumbers = new double[5] { 5.10, 4.2, 3.09, 5.3, 9.8 };
char[] arrayWithCharacters = new char[] { '+', '-', '*', '/', '%' };
bool[] arrayWithBooleans = new bool[5] { true, false, true, false, false };
int[][] nestedArray = new int[][]
{
    new int[] { 1, 2 },
    new int[] { 3,4 },
    new int[] { 5, 6 },
    new int[] { 7, 8 },
    new int[] { 9, 10 }
};

for (int i = 0; i < arrayWithWords.Length; i++)
{
    Console.WriteLine(arrayWithWords[i]);
}
for (int i = 0; i < arrayWithDecimalNumbers.Length; i++)
{
    Console.WriteLine(arrayWithDecimalNumbers[i]);
}
for (int i = 0; i < arrayWithCharacters.Length; i++)
{
    Console.WriteLine(arrayWithCharacters[i]);
}
for (int i = 0; i < arrayWithBooleans.Length; i++)
{
    Console.WriteLine(arrayWithBooleans[i]);
}
for (int i = 0; i < nestedArray.Length; i++)
{
    Console.Write("Element({0}): ", i);

    for (int j = 0; j < nestedArray[i].Length; j++)
    {
        // za ova linija kod malku Google pomogna :D
        Console.Write("{0}{1}", nestedArray[i][j], j == (nestedArray[i].Length - 1) ? "" : " ");
    }
    Console.WriteLine();
}
#endregion
Console.WriteLine("======================================================");
#region Exercise 5

int[] arrayOfIntegers = new int[5];
int sum = 0;
Console.WriteLine("Input 5 numbers: \n");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter a number: ");
    arrayOfIntegers[i] = Convert.ToInt32(Console.ReadLine());
}
for(int i = 0; i < 5; i++)
{
   sum += arrayOfIntegers[i];
}
Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);
#endregion
Console.WriteLine("======================================================");
#region Exercise 6

Console.Write("How many names do you want to enter? ");
int counter = int.Parse(Console.ReadLine());
string[] arrayOfNames = new string[counter];
for (int i = 0; i < counter; i++)
{
    Console.Write($"Enter name {i + 1}: ");
    string name = Console.ReadLine();
    arrayOfNames[i] = name;
    //char choice = '\0';
    Console.Write("Do you want to enter another name? (Y/N) ");
    char choice = char.Parse(Console.ReadLine());
    if (choice == 'Y')
    {
        continue;
    }
    else if (choice == 'N')
    {
        break;
    }
}
Console.WriteLine("The names you entered are:");
for (int i = 0; i < counter; i++)
{
    Console.WriteLine(arrayOfNames[i]);
}

#endregion
