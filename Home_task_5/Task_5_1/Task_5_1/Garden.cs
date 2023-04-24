using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_1
{
    internal class Garden
    {// цей алгоритм правильний.
        private List<Tree> Trees;

        public Garden(List<Tree> trees)
        {
            Trees = trees;
        }

        public List<Tree> GrahamScan()
        {
            Tree minYPoint = Trees.OrderBy(p => p.Y).First();

            List<Tree> sortedPoints = Trees
                .Where(p => p != minYPoint)
                .OrderBy(p => Math.Atan2(p.Y - minYPoint.Y, p.X - minYPoint.X))
                .ToList();

            sortedPoints.Insert(0, minYPoint);

            Stack<Tree> stack = new Stack<Tree>();
            stack.Push(sortedPoints[0]);
            stack.Push(sortedPoints[1]);

            for (int i = 2; i < sortedPoints.Count; i++)
            {
                Tree top = stack.Pop();
                while (Geometry.CrossProduct(stack.Peek(), top, sortedPoints[i]) <= 0)
                {
                    top = stack.Pop();
                }
                stack.Push(top);
                stack.Push(sortedPoints[i]);
            }

            return stack.Reverse().ToList();
        }

        public double GetPolygonPerimeter(List<Tree> points)
        {
            double perimeter = 0;
            for (int i = 0; i < points.Count; i++)
            {
                Tree current = points[i];
                Tree next = points[(i + 1) % points.Count];
                perimeter += Geometry.Distance(current, next);
            }
            return perimeter;
        }
    }
}
