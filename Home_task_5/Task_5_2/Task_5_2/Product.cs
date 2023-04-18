using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_2
{
    internal class Product
    {
        public string Name { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }

        public Product(string name, double width, double height, double length)
        {
            Name = name;
            Width = width;
            Height = height;
            Length = length;
        }

        public Box PackProductInBox()
        {
            Box productBox = new Box(Name, Width, Height, Length);
            productBox.AddObject(this);
            return productBox;
        }

        public override string ToString()
        {
            return $"Product: {Name}, Size: {Width} x {Height} x {Length}";
        }
    }
}
