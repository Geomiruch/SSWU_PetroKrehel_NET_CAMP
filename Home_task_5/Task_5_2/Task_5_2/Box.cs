using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_2
{
    internal class Box
    {
        public string Name { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public List<object> Contents { get; set; }

        public Box(string name, double width, double height, double length)
        {
            Name = name;
            Width = width;
            Height = height;
            Length = length;
            Contents = new List<object>();
        }

        public void AddObject(Box box)
        {
            Contents.Add(box);
        }

        public void AddObject(Product product)
        {
            Contents.Add(product);
        }

        public void PrintBoxInfo()
        {
            Console.WriteLine(ToString());
            Console.WriteLine("Contains: ");
            foreach (object obj in Contents)
            {
                Console.WriteLine(obj.ToString());
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            return $"Box: {Name} ({Width}x{Height}x{Length})";
        }
    }
}
