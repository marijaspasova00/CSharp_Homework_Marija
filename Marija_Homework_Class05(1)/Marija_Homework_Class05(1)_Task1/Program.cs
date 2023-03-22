// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Marija_Homework_Class05_1__Task1.Models;
using System.Runtime.CompilerServices;

Console.WriteLine("Please enter the first name, last name and the age of the person:");
string firstNameParsed = Convert.ToString(Console.ReadLine());
string lastNameParsed = Convert.ToString(Console.ReadLine());
bool age = int.TryParse(Console.ReadLine(), out int  ageParsed);

Human person = new Human(firstNameParsed, lastNameParsed, ageParsed);
Console.WriteLine("This is {0} ", person.GetPersonDetails());

