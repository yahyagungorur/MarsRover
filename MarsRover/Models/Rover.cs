using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Enum;

namespace MarsRover.Models
{
    public class Rover
    {
        private Position position;
        private DirectionEnum heading;

        public Rover(Position position, DirectionEnum heading)
        {
            this.position = position;
            this.heading = heading;
        }

        public Position Position
        {
            get { return position; }
            set { position = value; }
        }

        public DirectionEnum Heading
        {
            get { return heading; }
            set { heading = value; }
        }
    }
}
