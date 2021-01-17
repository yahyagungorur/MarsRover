using MarsRover.Enum;
using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Managers
{
    public static class RoverManager
    {
        public static void Execute(Rover rover, Plateau plateau,string instructions)
        {
            for(int i = 0;i< instructions.Length;i++)
            {
                ExecuteInstruction(rover,plateau, instructions[i]);
            }
        }

        public static void ExecuteInstruction(Rover rover, Plateau plateau,char instruction)
        {
            switch (instruction)
            {
                case 'L':
                    TurnLeft(rover);
                    break;
                case 'R':
                    TurnRight(rover);
                    break;
                case 'M':
                    Move(rover,plateau);
                    break;
                default:
                    Console.WriteLine("Wrong instruction!..");
                    break;
            }
        }

        public static bool Move(Rover rover,Plateau plateau)
        {
            if (!PlateauManager.CanMove(plateau, rover))
            {
                Console.WriteLine("Can Not Move!..");
                return false;
            }
            switch (rover.Heading)
            {
                case DirectionEnum.N:
                    rover.Position.y += 1;
                    break;
                case DirectionEnum.E:
                    rover.Position.x += 1;
                    break;
                case DirectionEnum.S:
                    rover.Position.y -= 1;
                    break;
                case DirectionEnum.W:
                    rover.Position.x -= 1;
                    break;
                default:
                    return false;
            }

            return true;
        }

        public static void TurnLeft(Rover rover)
        {
            rover.Heading = ((int)rover.Heading - 1) < (int)DirectionEnum.N ? DirectionEnum.W : (DirectionEnum)((int)rover.Heading - 1);
        }

        public static void TurnRight(Rover rover)
        {
            rover.Heading = ((int)rover.Heading + 1) > (int)DirectionEnum.W ? DirectionEnum.N : (DirectionEnum)((int)rover.Heading + 1);
        }

        public static string CurrentPosition(Rover rover)
        {
           return string.Format("{0} {1} {2}", rover.Position.x, rover.Position.y, rover.Heading);
        }

        public static void SetPosition(Rover rover, int x, int y, DirectionEnum direction)
        {
            rover.Position = new Position(x, y);
            rover.Heading = direction;
        }
    }
}
