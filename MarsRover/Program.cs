using MarsRover.Models;
using MarsRover.Enum;
using System;
using MarsRover.Managers;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the upper-right coordinates of the plateau (Separate them with  a space): ");
                string[] coordinates = Console.ReadLine().Split(' ');
                Plateau plateau = new Plateau(Convert.ToInt32(coordinates[0]), Convert.ToInt32(coordinates[1]));

                Console.Write("Enter the rover's position and heading(N-North E-East S-South W-West) (Separate them with a space): ");
                string[] positions = Console.ReadLine().Split(' ');
                Position position = new Position(Convert.ToInt32(positions[0]), Convert.ToInt32(positions[1]));
                DirectionEnum direction = (DirectionEnum)System.Enum.Parse(typeof(DirectionEnum), positions[2].ToUpper());
                if (!PlateauManager.CanLand(plateau, position))
                {
                    Console.WriteLine("Can Not Land!..");
                }
                else {
                    Console.Write("Enter a series of instructions (M-Move Forward L-Turn Left R-Turn Right): ");
                    string instructions = Console.ReadLine();

                    Rover rover = new Rover(position, direction);
                    RoverManager.Execute(rover, plateau, instructions.ToUpper());
                    Console.WriteLine(RoverManager.CurrentPosition(rover));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("FAILED!.. "+ex.Message);
            }

            Console.ReadLine();
        }
    }
}
