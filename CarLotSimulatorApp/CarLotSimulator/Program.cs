using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml;


namespace CarLotSimulator
{
    class Program
    {
        public static void Main(string[] args)
        {
            CarLot carLot = new CarLot();

            Car mGBGT = new Car()
            {
                Year = 1974,
                Make = "MG",
                Model = "BGT",
                EngineNoise = "zoomzoom",
                HonkNoise = "Beepskies",
                IsDriveable = true,
            };
            Console.WriteLine(mGBGT.MakeEngineNoise(mGBGT.EngineNoise));
            Console.WriteLine(mGBGT.MakeHonkNoise(mGBGT.HonkNoise));
            Console.WriteLine();
            Console.WriteLine($"The current number of cars in the CarLot is {CarLot.numberOfCars}");

            Car viperGTS = new Car();
            viperGTS.Year = 2001;
            viperGTS.Make = "Dodge";
            viperGTS.Model = "Viper GTS";
            viperGTS.EngineNoise = "Groooowwwwl";
            viperGTS.HonkNoise = "Beep";
            viperGTS.IsDriveable = true;
            Console.WriteLine(viperGTS.MakeEngineNoise(viperGTS.EngineNoise));
            Console.WriteLine(viperGTS.MakeHonkNoise(viperGTS.HonkNoise));
            Console.WriteLine();
            Console.WriteLine($"The current number of cars in the CarLot is {CarLot.numberOfCars}");

            Car rover = new Car(1964, "Land Rover", "Series IIA", "Vroom", "Honk", false);
            Console.WriteLine(rover.MakeEngineNoise(rover.EngineNoise));
            Console.WriteLine(rover.MakeHonkNoise(rover.HonkNoise));
            Console.WriteLine();
            Console.WriteLine($"The current number of cars in the CarLot is {CarLot.numberOfCars}");

            carLot.CarList.Add(mGBGT);
            carLot.CarList.Add(viperGTS);
            carLot.CarList.Add(rover);

            foreach (var Car in carLot.CarList)
            {
                Console.WriteLine($" Year: {Car.Year}\n Make: {Car.Make}\n Model: {Car.Model}\n Engine Noise: {Car.EngineNoise}\n Honk Noise: {Car.HonkNoise}\n Driveable?: {Car.IsDriveable}\n");
            }

            Car jelloCar = new Car(2022, "Peepster Inc", "Jjype", "Jiggle jiggle jiggle jiggle, wobble wobble wobble wobble", "florm badung dung dung", true);
            Console.WriteLine($"The current number of cars in the CarLot is {CarLot.numberOfCars}");

            Car ssLucky = new Car(1952, "Ham Hoke", "Bug Type", "bizz bizzz bizzzzz", "nerf", true);
            Console.WriteLine($"The current number of cars in the CarLot is {CarLot.numberOfCars}");

            Car patriotP4 = new Car(2020, "Patriot", "Overland2", "schwooooooo", "groannnnn", false);
            Console.WriteLine($"The current number of cars in the CarLot is {CarLot.numberOfCars}");
        }
    }
}
