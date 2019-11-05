using System;

namespace Structures_Classes.Struct_Samples
{
    public struct PointAdditional
    {
        public int x, y;

        public PointAdditional(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public void Display()
        {
            Console.WriteLine($"X: {x}");
            Console.WriteLine($"Y: {y}");
        }
    }
}
