using System;

namespace Structures_Classes.Class_Samples
{
    public class PointClassAdvanced
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public void Display()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine(Environment.NewLine);
        }

        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        public PointClassAdvanced DeepCopy()
        {
            PointClassAdvanced pointClassAdvanced = new PointClassAdvanced
            {
                Id = this.Id,
                Name = this.Name
            };

            return pointClassAdvanced;
        }
    }
}
