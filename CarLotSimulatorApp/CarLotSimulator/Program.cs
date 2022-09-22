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
                        

            Car rover = new Car(1964, "Land Rover", "Series IIA", "Vroom", "Honk", false);
            Console.WriteLine(rover.MakeEngineNoise(rover.EngineNoise));
            Console.WriteLine(rover.MakeHonkNoise(rover.HonkNoise));
            Console.WriteLine();


            carLot.CarList.Add(mGBGT);
            carLot.CarList.Add(viperGTS);
            carLot.CarList.Add(rover);


            foreach (var Car in carLot.CarList)
            {
                Console.WriteLine($"{Car.Year}, {Car.Make}, {Car.Model}, {Car.EngineNoise}, {Car.HonkNoise}, {Car.IsDriveable}\n");
            }

        }
    }
}
