using Structures_Classes.Class_Samples;
using Structures_Classes.Struct_Samples;
using System;

namespace Structures_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void StructExample1()
        {
            var p1 = new Point(1, 2);
            p1.DisplayPoints();

            p1 = new Point(4, 5);
            p1.DisplayPoints();

            Console.ReadKey();
        }

        static void StructExample2()
        {
            var p1 = new PointProperties
            {
                X = 10,
                Y = 20
            };

            p1.DisplayPoints();

            var p2 = p1;
            p2.X = 100;
            p2.Y = 200;

            p2.DisplayPoints();

            Console.ReadKey();
        }

        static void StructExample3()
        {
            /*
             * This doesnt work because we dont have access to set
             * values on fields
             */
            //Point p1;
            //p1.DisplayPoints();

            /*
             * This is not possible because the struct
             * does not have an explicit constructor defined
             */
            //PointProperties p2;
            //p2.X = 10;
            //p2.Y = 10;

            PointAdditional p3;
            p3.x = 10;
            p3.y = 20;

            p3.Display();

            Console.ReadKey();
        }

        static void ClassExample1()
        {
            var p1 = new PointClass
            {
                X = 10,
                Y = 20
            };

            Console.WriteLine("--> Show values");
            p1.DisplayPoints();

            /*
             * This does not work because the class is not
             * instanced only declared
             */
            //PointClass p2;
            //p2.X = 100;
            //p2.Y = 200;
            //p2.DisplayPoints();

            var p2 = p1;

            Console.WriteLine("--> p2 is created based on p1");
            p2.DisplayPoints();

            Console.WriteLine("--> update p2.x = 1000");
            p2.X = 1000;

            Console.WriteLine("--> display p1 values");
            p1.DisplayPoints();

            Console.WriteLine("--> display p2 values");
            p2.DisplayPoints();

            Console.ReadKey();
        }

        static void ClassExample2()
        {
            var p1 = new PointClassAdvanced
            {
                Id = 10,
                Name = "Jon",
            };

            var p2 = p1;
            p2.Id = 100;

            Console.WriteLine("--> p1 values");
            p1.Display();

            Console.WriteLine("--> p2 values");
            p2.Display();

            var p3 = (PointClassAdvanced)p1.ShallowCopy();
            p1.Name = "Jon 1";
            p3.Name = "Jon 3";

            Console.WriteLine("--> p1 values from which we created p3");
            p1.Display();

            Console.WriteLine("--> p3 values");
            p3.Display();

            var p4 = new PointClassAdvanced
            {
                Id = 80,
                Name = "Danny"
            };

            var p5 = p4.DeepCopy();

            Console.WriteLine("--> p4 values");
            p4.Display();

            Console.WriteLine("--> p5 values");
            p5.Display();

            p5.Name = "Danny 5";

            Console.WriteLine("--> Update p5.Name to Danny 5");
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("--> p4 values");
            p4.Display();

            Console.WriteLine("--> p5 values");
            p5.Display();

            Console.ReadKey();
        }
    }
}
