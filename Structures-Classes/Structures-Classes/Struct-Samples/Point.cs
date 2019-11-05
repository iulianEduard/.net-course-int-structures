using System;

namespace Structures_Classes.Struct_Samples
{
    public struct Point
    {
        private readonly int _x;
        private readonly int _y;

        public Point(int x, int y)
        {
            /*
             * We must assign values to our fields otherwise we get
             * a compilation error when we use constructors
             */
            _x = x;
            _y = y;
        }

        public void DisplayPoints()
        {
            Console.WriteLine($"X: {_x}");
            Console.WriteLine($"Y: {_y}");
            Console.WriteLine(Environment.NewLine);
        }
    }
}
