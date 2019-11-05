using System;

namespace Structures_Classes.Class_Samples
{
    public class PointClass
    {
        public int X { get; set; }

        public int Y { get; set; }

        public void DisplayPoints()
        {
            Console.WriteLine($"X: {X}");
            Console.WriteLine($"Y: {Y}");
            Console.WriteLine(Environment.NewLine);
        }
    }
}
