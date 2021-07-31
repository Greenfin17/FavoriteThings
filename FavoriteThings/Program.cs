using FavoriteThings.MyStuff;
using System;
using System.Collections.Generic;

namespace FavoriteThings
{
    class Program
    {
        static void UseCars()
        {
            Car BMW = new Car("1987", "BMW", "E30", false, 232000, 22.3);
            Car FocusElectric = new Car("2013", "Ford", "Focus Electric", true, 42000);
            List<Car> carList = new List<Car>();
            carList.Add(BMW);
            carList.Add(FocusElectric);
            ConsoleKeyInfo inputKey = new ConsoleKeyInfo();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Select Car");
                Console.WriteLine($"  1) {carList[0].Year} {carList[0].Make}");
                Console.WriteLine($"  2) {carList[1].Year} {carList[1].Make}");
                Console.WriteLine("Enter 'x' to exit");
                inputKey = Console.ReadKey(true);
                Console.Write('\n');
                switch (inputKey.KeyChar)
                {
                    case ('1'):
                        Console.WriteLine($"You selected the {carList[0].Make}");
                        carList[0].Status();
                        carList[0].Drive(200, 3.51);
                        carList[0].Status();
                        carList[0].Repair(250);
                        BMW.Status();
                        break;
                    case ('2'):
                        Console.WriteLine($"You selected the {carList[1].Make}");
                        carList[1].SetElectricCost(.31, .10);
                        carList[1].Status();
                        carList[1].Drive(200);
                        carList[1].Status();
                        carList[1].Repair(250);
                        carList[1].Status();
                        break;
                    case ('x'):
                    case ('X'):
                        exit = true;
                        break;
                    default:
                        break;
                }

            }

        }
        static void UseTools()
        {
            Tool SocketSet = new Tool("Socket Set", "Metric");
            Tool LaserMeasure = new Tool("Laser Measure", "Electronic");

            ConsoleKeyInfo inputKey = new ConsoleKeyInfo();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Select Tool");
                Console.WriteLine("  1) Socket Set");
                Console.WriteLine("  2) Laser Measure");
                Console.WriteLine("Enter 'x' to exit");
                inputKey = Console.ReadKey(true);
                Console.Write('\n');
                switch (inputKey.KeyChar)
                {
                    case ('1'):
                        Console.WriteLine("You selected the socket set");
                        SocketSet.Use();
                        SocketSet.Retrieve();
                        SocketSet.Use();
                        SocketSet.Return();
                        SocketSet.Clean();
                        SocketSet.Return();
                        SocketSet.Status();
                        break;
                    case ('2'):
                        Console.WriteLine("You selected the laser measure");
                        LaserMeasure.Use();
                        LaserMeasure.Retrieve();
                        LaserMeasure.Use();
                        LaserMeasure.Return();
                        LaserMeasure.Clean();
                        LaserMeasure.Return();
                        LaserMeasure.Status();
                        break;
                    case ('x'):
                    case ('X'):
                        exit = true;
                        break;
                    default:
                        break;
                }

            }
        }
        static void UseComputers()
        {
            Computer Bach = new Computer("DIY", "Mid-Tower", "Ryzen 7", "16GB", "2TB");
            Computer Saturn = new Computer("HP", "Laptop", "Intel i5", "16GB", "1TB");
            ConsoleKeyInfo inputKey = new ConsoleKeyInfo();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Select Computer");
                Console.WriteLine("  1) Mid-Tower");
                Console.WriteLine("  2) Laptop");
                Console.WriteLine("Enter 'x' to exit");
                inputKey = Console.ReadKey(true);
                Console.Write('\n');
                switch (inputKey.KeyChar)
                {
                    case ('1'):
                        Console.WriteLine("               You selected the mid-tower");
                        Bach.Info();
                        Bach.Update();
                        Bach.Backup();
                        Bach.Virus();
                        break;
                    case ('2'):
                        Console.WriteLine("               You selected the laptop");
                        Saturn.Info();
                        Saturn.Update();
                        Saturn.Backup();
                        Saturn.Virus();
                        break;
                    case ('x'):
                    case ('X'):
                        exit = true;
                        break;
                    default:
                        break;
                }

            }

        }

        static void PlayViolins()
        {
            Violin Calace = new Violin("Calace", "Late 19th Century","Dark", "Dark and resonant");
            Violin Janzen = new Violin("Hermann Janzen", "2012","Light Tan with a hint of red", "Bright and brilliant");
            ConsoleKeyInfo inputKey = new ConsoleKeyInfo();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Select Violin");
                Console.WriteLine("  1) Calace");
                Console.WriteLine("  2) Janzenn");
                Console.WriteLine("Enter 'x' to exit");
                inputKey = Console.ReadKey(true);
                Console.Write('\n');
                switch (inputKey.KeyChar)
                {
                    case ('1'):
                        Console.WriteLine($"               You selected the {Calace.Maker}");
                        Calace.Status();
                        Calace.Retrieve();
                        Calace.Play();
                        Calace.Tune();
                        Calace.Play();
                        Calace.Return();
                        Calace.Clean();
                        Calace.Return();
                        break;
                    case ('2'):
                        Console.WriteLine($"               You selected the {Janzen.Maker}");
                        Janzen.Status();
                        Janzen.Retrieve();
                        Janzen.Play();
                        Janzen.Tune();
                        Janzen.Play();
                        Janzen.Return();
                        Janzen.Clean();
                        Calace.Return();
                        break;
                    case ('x'):
                    case ('X'):
                        exit = true;
                        break;
                    default:
                        break;
                }

            }

        }
        static void Main(string[] args)
        {
            ConsoleKeyInfo inputKey = new ConsoleKeyInfo();
            bool exit = false;
            while(!exit)
            {
                Console.WriteLine("               My Favorite Things\n");
                Console.WriteLine("Select favorite things");
                Console.WriteLine("  1) Cars");
                Console.WriteLine("  2) Computers");
                Console.WriteLine("  3) Tools");
                Console.WriteLine("  4) Violins");
                Console.WriteLine("Enter 'x' to exit");

                inputKey = Console.ReadKey(true);
                Console.Write('\n');

                switch (inputKey.KeyChar)
                {
                    case ('1'):
                        UseCars();
                        break;
                    case ('2'):
                        UseComputers();
                        break;
                    case ('3'):
                        UseTools();
                        break;
                    case ('4'):
                        PlayViolins();
                        break;
                    case ('x'):
                    case ('X'):
                        exit = true;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
