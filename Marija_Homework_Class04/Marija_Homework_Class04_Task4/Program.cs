//Console.WriteLine("Hello, World!");
int AgeCalculator(DateTime birthdate)
{
    //DateTime today = DateTime.Today;
    int age = DateTime.Today.Year - birthdate.Year;
    return age;
}
DateTime myBirthday = new DateTime(2000, 4, 23);
DateTime myBirthday1 = new DateTime(1995, 12, 28);
int myCurrentAge = AgeCalculator(myBirthday);
int myCurrentAge1 = AgeCalculator(myBirthday1);
Console.WriteLine("I am {0} years old ", myCurrentAge);
Console.WriteLine("I am {0} years old ", myCurrentAge1);