// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Marija_Homework_Class08_Task3.Models;
using System.Drawing;
using System.Xml.Linq;

List<Animal> animals = new List<Animal>()
{
    new Animal { Name = "Bear", Color = "Black", Age = 5, Gender = Gender.Male },
    new Animal { Name = "Zebra", Color = "Black&White", Age = 3, Gender = Gender.Female },
    new Animal { Name = "Dog", Color = "Brown", Age = 4, Gender = Gender.Male },
    new Animal { Name = "Fox", Color = "Brown", Age = 4, Gender = Gender.Male },
    new Animal { Name = "Cat", Color = "Grey", Age = 2, Gender = Gender.Male },
    new Animal { Name = "Arctic Fox", Color = "White", Age = 4, Gender = Gender.Female },
    new Animal { Name = "Horse", Color = "Black", Age = 5, Gender = Gender.Male },
    new Animal { Name = "Lion", Color = "Terracotta", Age = 7, Gender = Gender.Male },
    new Animal { Name = "Morpho", Color = "Cerulean", Age = 3, Gender = Gender.Female },
    new Animal { Name = "ExampleForLongerThanTen", Color = "Cerulean", Age = 3, Gender = Gender.Female },
};
List<Animal> animalAge = animals.Where(u => u.Age >= 5).ToList();

foreach (var animal in animalAge)
{
    Console.WriteLine($"{animal.Name} - {animal.Age}");
}
Console.WriteLine("==========================================================");
var namesThatStartsWithA = animals.Where(a => a.Name.StartsWith("A")).Select(a => new { Name = a.Name, Age = a.Age }).ToList();
foreach (var animal in namesThatStartsWithA)
{
    Console.WriteLine($"{animal.Name} - {animal.Age}");
}
Console.WriteLine("==========================================================");
var allBrownMales = animals.Where(bm => bm.Gender == Gender.Male && bm.Color == "Brown");
foreach(var bm in allBrownMales)
{
    Console.WriteLine($"{bm.Name} - {bm.Age}");
}
Console.WriteLine("==========================================================");
var nameLongerThanTen = animals.Where(t => t.Name.Length > 10).FirstOrDefault();
if (nameLongerThanTen != null)
{
    Console.WriteLine($"The first animal that has more characters than 10 in the name is {nameLongerThanTen.Name}");
}
else
{
    Console.WriteLine("There is no name that is longer than 10 charatcers!");
}