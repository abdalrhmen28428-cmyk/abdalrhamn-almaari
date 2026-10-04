// See https://aka.ms/new-console-template for more information

class Vehicle
{
    public string Brand;
    public int Year;
    public Vehicle(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }
    public void Start()
    {
        Console.WriteLine(Brand + " is starting.");
    }

    class Car : Vehicle
    {

        public int NumberOfDoors;
        public Car(string brand, int year, int numberOfDoors)
            : base(brand, year)
        {
            NumberOfDoors = numberOfDoors;
        }

    }
    class Bus : Vehicle
    {
        public int Capacity;
        public Bus(string brand, int year, int capacity)
            : base(brand, year)

        {
            Capacity = capacity;
        }

        class Motorcycle : Vehicle
        {

            public bool HasSidecar;
            public Motorcycle(string brand, int year, bool hasSidecar)
            : base(brand, year)
            {
                HasSidecar = hasSidecar;
            }

            class Program
            {
            }
            static void Main()
            {

                Car car1 = new Car("BMW", 2024, 4);
                Bus bus1 = new Bus("Mercedes", 2022, 50);
                Motorcycle moto1 = new Motorcycle("Honda", 2023, false);
                Console.WriteLine("Car: " + car1.Brand);
                Console.WriteLine("Year: " + car1.Year);
                Console.WriteLine("Doors: " +car1.NumberOfDoors);
                car1.Start();
                Console.WriteLine();
                Console.WriteLine("Bus: " + bus1.Brand);
                Console.WriteLine("Year: " + bus1.Year);
                Console.WriteLine("Capacity: " + bus1.Capacity);
                bus1.Start();
                Console.WriteLine();
                Console.WriteLine("Motorcycle: " +moto1.Brand);
                Console.WriteLine("Year: " + moto1.Year);
                Console.WriteLine("Has Sidecar: " + moto1.HasSidecar);
                moto1.Start();
            }
        }
    }
}