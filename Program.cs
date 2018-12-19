using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace Turtle1
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
            Turtle.PenUp();
            int x = 200;
            int y = 200;
            int sizeEat = 10;
            GraphicsWindow.BrushColor = "Red";
            var eat = Shapes.AddRectangle(sizeEat, sizeEat);
            Shapes.Move(eat, x, y);

            Random rand = new Random();

            while (true)
            {
                Turtle.Move(10);
                if(x <= Turtle.X && Turtle.X <= x + sizeEat && y <= Turtle.Y && Turtle.Y <= y + sizeEat)
                {
                    x = rand.Next(0, GraphicsWindow.Width);
                    y = rand.Next(0, GraphicsWindow.Height);
                    Shapes.Move(eat, x, y);
                } else if (Turtle.X >= GraphicsWindow.Width)
                {
                    Turtle.Angle = 270;
                } else if (Turtle.X <= 0)
                {
                    Turtle.Angle = 90;
                } else if (Turtle.Y >= GraphicsWindow.Height)
                {
                    Turtle.Angle = 0;
                } else if (Turtle.Y <= 0)
                {
                    Turtle.Angle = 180;
                }
            }

        }

        private static void GraphicsWindow_KeyDown()
        {
            if (GraphicsWindow.LastKey == "Up")
            {
                Turtle.Angle = 0;
            }else if (GraphicsWindow.LastKey == "Down")
            {
                Turtle.Angle = 180;
            } else if (GraphicsWindow.LastKey == "Right")
            {
                Turtle.Angle = 90;
            } else if (GraphicsWindow.LastKey == "Left")
            {
                Turtle.Angle = 270;
            }
        }
    }
}
