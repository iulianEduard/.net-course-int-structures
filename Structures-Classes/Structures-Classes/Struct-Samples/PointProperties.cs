using System;

namespace Structures_Classes.Struct_Samples
{
    public struct PointProperties
    {
        public int X { get; set; }

        public int Y { get; set; }

        /*
         * Structs cannot have empty constructor
         */
        //public PointProperties()
        //{
        //    X = 0;
        //    Y = 0;
        //}

        public void DisplayPoints()
        {
            Console.WriteLine($"X: {X}");
            Console.WriteLine($"Y: {Y}");
        }
    }
}
