using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Models
{
    public class Plateau
    {
        public int minWidth;
        public int minHeight;
        public int maxWidth;
        public int maxHeight;

        public Plateau(int maxWidth, int maxHeight)
        {
            this.minHeight = 0;
            this.minWidth = 0;
            this.maxHeight = maxHeight;
            this.maxWidth = maxWidth;
        }

        public int MinWith
        {
            get { return minWidth; }
            set { minWidth = value; }
        }

        public int MinHeight
        {
            get { return minHeight; }
            set { minHeight = value; }
        }

        public int MaxWith
        {
            get { return maxWidth; }
            set { maxWidth = value; }
        }

        public int MaxHeight
        {
            get { return maxHeight; }
            set { maxHeight = value; }
        }
    }
}
