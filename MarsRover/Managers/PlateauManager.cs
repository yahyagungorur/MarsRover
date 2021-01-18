using MarsRover.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Managers
{
    public static class PlateauManager
    {
        public static bool CanMove(Plateau plateau, Rover rover)
        {
            switch (rover.Heading)
            {
                case Enum.DirectionEnum.N:
                    return plateau.MinHeight <= rover.Position.y + 1 && rover.Position.y + 1 <= plateau.MaxHeight;
                case Enum.DirectionEnum.E:
                    return plateau.MinWith <= rover.Position.x + 1 && rover.Position.x + 1 <= plateau.MaxWith;
                case Enum.DirectionEnum.S:
                    return plateau.MinHeight <= rover.Position.y - 1 && rover.Position.y - 1 <= plateau.MaxHeight;
                case Enum.DirectionEnum.W:
                    return plateau.MinWith <= rover.Position.x - 1 && rover.Position.x - 1 <= plateau.MaxWith;
                default:
                    return false;
            }
        }
        public static bool CanLand(Plateau plateau, Position position)
        {
            return plateau.minHeight <= position.y && position.y <= plateau.MaxHeight &&
                   plateau.minWidth <= position.x && position.x <= plateau.maxWidth;
        }
    }
}
