using System;

class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year:{Year}");
    }
}

class Car : Vehicle
{
    public int NumberOfDoor { get; set; }
    public Car(string brand, string model, int year, int numberOfDoors):base(brand, model, year)
    {
        NumberOfDoor = numberOfDoors;
    }

    public void ShowCarInfo()
    {
        ShowInfo();
        Console.WriteLine($"Count: {NumberOfDoor}");
    }

}

class Motorcycle : Vehicle
{
    public bool HasSideCar { get; set; }

    public Motorcycle (string brand, string model, int year, bool hasSideCar): base(brand, model, year)
    {
        HasSideCar = hasSideCar;
    }

    public void ShowMotorcycleInfo()
    {
        ShowInfo ();
        Console.WriteLine($"Side : {(HasSideCar ? "yes" : "no")} ");

    }
}

class Program 
{
    static void Main()
    {
        Car car1 = new Car("Chevrolet", "Camaro", 2022, 4);

        Motorcycle motorcycle1 = new Motorcycle("Honda", "CB500X", 2021, false);

        Console.WriteLine("Car Info: ");
        motorcycle1 .ShowMotorcycleInfo();
    }
}
