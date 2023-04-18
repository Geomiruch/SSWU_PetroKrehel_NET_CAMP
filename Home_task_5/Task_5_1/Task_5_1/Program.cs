using System.Drawing;

namespace Task_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tree> trees = new List<Tree>()
            {
                new Tree(0, 0),
                new Tree(0, 1),
                new Tree(1, 1),
                new Tree(1, 0),
                new Tree(0.5, 0.5),
                new Tree(0.25, 0.75),
                new Tree(0, 3),
                new Tree(1, 3)
            };

            Garden garden = new Garden(trees);

            List<Tree> convexHull = garden.GrahamScan();
            double perimeter = garden.GetPolygonPerimeter(convexHull);
            Console.WriteLine($"Fence length: {perimeter}");
        }
    }
}