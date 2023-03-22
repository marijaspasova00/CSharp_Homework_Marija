// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

Queue<int> nums = new Queue<int>();
bool addNumbers = true;
while (addNumbers)
{
    Console.WriteLine("Please enter a number: ");
    bool number = int.TryParse(Console.ReadLine(), out int parsedNumber);
    if (number)
    {
        nums.Enqueue(parsedNumber);
    }
    else
    {
        Console.WriteLine("Invalid input!");
    }
    Console.WriteLine("If you want to continue adding numbers please press Y/y, otherwise press N/n: ");
    char choice = char.Parse(Console.ReadLine().ToLower());
    if (choice == 'n')
    {
        addNumbers = false;
    }
}
Console.WriteLine("The number of the queue are: ");
foreach(int num in nums)
{
    Console.WriteLine(num);
}