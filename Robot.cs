using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Robot
{

    class Robot
    {
        //constants for the direction symbols
        public static string WEST = char.ConvertFromUtf32(231);
        public static string EAST = char.ConvertFromUtf32(232);
        public static string NORTH = char.ConvertFromUtf32(233);
        public static string SOUTH = char.ConvertFromUtf32(234);

        public string direction;
        public Point currentPosition;

        public string Direction
        {
            get { return direction; }
            set { direction = value; }
        }

        public Point CurrentPosition
        {
            get { return currentPosition; }
            set { currentPosition = value; }
        }

        public Robot ()
        {
            direction = NORTH;
            currentPosition.X = 0;
            currentPosition.Y = 0;
        }

        public delegate void OutOfBoundsHandler(Robot robot);
        public event OutOfBoundsHandler OutOfBounds;

        public void move(int units)
        {

            if (direction == NORTH && currentPosition.Y + units <= 100)
            {
                currentPosition.Y += units;
            } 
            else if (direction == SOUTH && currentPosition.Y - units >= -100)
            {
                currentPosition.Y -= units;
            }
            else if (direction == EAST && currentPosition.X + units <= 100)
            {
                currentPosition.X += units;
            }
            else if (direction == WEST && currentPosition.X - units >= -100)
            {
                currentPosition.X -= units;
            }
            else { OutOfBounds(this); }

        }

    }
}
