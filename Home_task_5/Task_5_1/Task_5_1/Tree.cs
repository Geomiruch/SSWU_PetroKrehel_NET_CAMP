using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_1
{
    internal class Tree
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Tree(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
