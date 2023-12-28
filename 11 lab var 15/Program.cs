class Car
{
    public string Brand { get; set; }
    public double EnginePower { get; set; }
    public int Seats { get; set; }

    public Car(string brand, double enginePower, int seats)
    {
        Brand = brand;
        EnginePower = enginePower;
        Seats = seats;
    }

    public double CalculateQuality(int headcount, double votePercentage)
    {
        return 0.3 * headcount + 0.7 * votePercentage;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Марка: {Brand}, Мощность двигателя: {EnginePower} кВт, Число мест: {Seats}");
    }
}

class CarLevel2 : Car
{
    public int YearManufactured { get; set; }

    public CarLevel2(string brand, double enginePower, int seats, int yearManufactured)
        : base(brand, enginePower, seats)
    {
        YearManufactured = yearManufactured;
    }

    public double CalculateQualityLevel2(int currentYear)
    {
        double quality = CalculateQuality(100, 85); 
        return quality - 1.5 * (currentYear - YearManufactured);
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car("Toyota", 120, 5);
        car1.DisplayInfo();
        double quality1 = car1.CalculateQuality(120, 85);
        Console.WriteLine($"Качество автомобиля: {quality1}");

        CarLevel2 car2 = new CarLevel2("BMW", 180, 4, 2018);
        car2.DisplayInfo();
        double quality2 = car2.CalculateQualityLevel2(DateTime.Now.Year);
        Console.WriteLine($"Качество автомобиля второго уровня: {quality2}");
    }
}
