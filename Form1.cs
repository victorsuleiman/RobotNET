using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10_Robot
{
    public partial class Form1 : Form
    {

        Robot robot = new Robot();
        Point absolutePosition;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            directionChanged();
            absolutePosition.X = labelArrow.Location.X;
            absolutePosition.Y = labelArrow.Location.Y;

            robot.OutOfBounds += robot =>
            {
                MessageBox.Show("Movement not allowed.\n The max position is 100 units per direction.");
            };

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void directionChanged()
        {
            labelArrow.Text = robot.Direction;
        }

        private void robotMoved()
        {
            labelPos.Text = "{X=" + robot.CurrentPosition.X + ",Y=" + robot.CurrentPosition.Y + "}";
            labelArrow.Location = new Point(absolutePosition.X + robot.CurrentPosition.X,
                absolutePosition.Y - robot.CurrentPosition.Y);
        }

        private void buttonNorth_Click(object sender, EventArgs e)
        {
            robot.Direction = Robot.NORTH;
            directionChanged();
        }

        private void buttonEast_Click(object sender, EventArgs e)
        {
            robot.Direction = Robot.EAST;
            directionChanged();
        }

        private void buttonSouth_Click(object sender, EventArgs e)
        {
            robot.Direction = Robot.SOUTH;
            directionChanged();
        }

        private void buttonWest_Click(object sender, EventArgs e)
        {
            robot.Direction = Robot.WEST;
            directionChanged();
        }

        private void buttonGo10_Click(object sender, EventArgs e)
        {
            robot.move(10);
            robotMoved();
        }

        private void buttonGo1_Click(object sender, EventArgs e)
        {
            robot.move(1);
            robotMoved();
        }
    }
}
