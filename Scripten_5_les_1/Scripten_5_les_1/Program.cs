using System;

namespace Scripten_5_les_1
{
    class Program
    {
        // part 1
        enum directions { north, south, east, west }

        

        static void Main(string[] args)
        {
            enumber();

            void enumber()
            {
                //part 2
                int ChosenDirection = 0;

                Console.WriteLine("Choose a direction");
                Console.WriteLine("North, South, East , West (0, 1, 2, 3) ");
                ChosenDirection = int.Parse(Console.ReadLine());

                if (ChosenDirection < 0 | ChosenDirection > 3)
                {
                    enumber();
                }
                else
                {
                    var playerDirection = (directions)ChosenDirection;
                    Console.WriteLine((directions)ChosenDirection);

                    Console.WriteLine("Press enter to continue...");

                    Console.ReadLine();

                    Console.Clear();

                    enumber2();
                }
                
                void enumber2()
                {
                    string DirectionChosen;

                    Console.WriteLine("Choose a direction");
                    Console.WriteLine("North, South, East, West");

                    DirectionChosen = Console.ReadLine();

                    
                    DirectionChosen = Console.ReadLine();

                    if (DirectionChosen == directions.north.ToString())
                    {
                        Console.WriteLine("North");
                    }else if (DirectionChosen == directions.north.ToString())
                    {
                        Console.WriteLine("South");
                    }else if (DirectionChosen == directions.north.ToString())
                    {
                        Console.WriteLine("East");
                    }else if (DirectionChosen == directions.north.ToString())
                    {
                        Console.WriteLine("West");
                    }

                }
            }

        }
    }
}
