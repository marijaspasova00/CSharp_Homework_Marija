// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Marija_Homework_Class05_1__Task2.Models;

void RaceCars(Car firstCar, Car secondCar)
{
    if (firstCar.CalculateSpeed(firstCar.CarDriver) > secondCar.CalculateSpeed(secondCar.CarDriver))
    {
        Console.WriteLine($"In the race the winner car was {firstCar.Model}. It was driving with {firstCar.Speed}km/h and the driver was {firstCar.CarDriver.Name}");
    }
    else if (firstCar.CalculateSpeed(firstCar.CarDriver) < secondCar.CalculateSpeed(secondCar.CarDriver))
    {
        Console.WriteLine($"In the race the winner car was {secondCar.Model}. It was driving with {secondCar.Speed}km/h and the driver was {secondCar.CarDriver.Name}");

    }
    else
    {
        Console.WriteLine("They are equal!");
    }
}
List<Car> cars = new List<Car>()
{
    new Car { Model = "Hyundai", Speed = 140},
    new Car { Model = "Mazda", Speed = 200},
    new Car { Model = "Ferrari", Speed = 300},
    new Car { Model = "Porsche", Speed = 280 }
};
List<Driver> drivers = new List<Driver>()
{
    new Driver { Name = "Bob", Level = 3},
    new Driver { Name = "Greg", Level = 5},
    new Driver { Name = "Jill", Level = 3},
    new Driver { Name = "Anne", Level = 2}
};

bool endGame = true;

do
{
    Console.WriteLine($"Please select the first car: \n1.{cars[0].Model}\n2.{cars[1].Model}\n3.{cars[2].Model}\n4.{cars[3].Model}");
    bool canParseFirstCar = int.TryParse(Console.ReadLine(), out int firstCarChoice);

    Console.WriteLine($"Please select the second car: \n1.{cars[0].Model}\n2.{cars[1].Model}\n3.{cars[2].Model}\n4.{cars[3].Model}");
    bool canParseSecondCar = int.TryParse(Console.ReadLine(), out int secondCarChoice);

    Console.WriteLine($"Please select the first driver: \n1.{drivers[0].Name}\n2.{drivers[1].Name}\n3.{drivers[2].Name}\n4.{drivers[3].Name}");
    bool canParseFirstDriver = int.TryParse(Console.ReadLine(), out int firstDriverChoice);

    Console.WriteLine($"Please select the second driver: \n1.{drivers[0].Name}\n2.{drivers[1].Name}\n3.{drivers[2].Name}\n4.{drivers[3].Name}");
    bool canParseSecondDriver = int.TryParse(Console.ReadLine(), out int secondDriverChoice);

    if (canParseFirstCar && canParseSecondCar && canParseFirstDriver && canParseSecondDriver)
    {
        Car firstSelectedCar = cars[firstCarChoice - 1];
        Car secondSelectedCar = cars[secondCarChoice - 1];

        Driver firstSelectedDriver = drivers[firstDriverChoice - 1];
        Driver secondSelectedDriver = drivers[secondDriverChoice - 1];

        firstSelectedCar.CarDriver = firstSelectedDriver;
        secondSelectedCar.CarDriver = secondSelectedDriver;

        RaceCars(firstSelectedCar, secondSelectedCar);

        Console.WriteLine("Do you want to play again! If not please enter n or N otherwise enter y or Y");
        string userInput = Console.ReadLine();
        if (userInput.ToLower() == "n")
        {
            endGame = false;
        }
    }
    else
    {
        Console.WriteLine("Wrong input! Please select using numbers from 1-4");
    }
} while (endGame);

