namespace StringTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:");
            Console.WriteLine("Enter your text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Enter your substring: ");
            string subString = Console.ReadLine();
            Console.WriteLine($"Index of second occurance: {StringWorker.FindSecondOccurrence(text, subString)}");

            Console.WriteLine("Task 2:");
            Console.WriteLine("Enter your text: ");
            text = Console.ReadLine();
            Console.WriteLine($"Nubmer of words starting with capital letter: {StringWorker.CountWordsStartingWithCapitalLetter(text)}");

            Console.WriteLine("Task 3:");
            Console.WriteLine("Enter your text: ");
            text = Console.ReadLine();
            Console.WriteLine("Enter your replacing text: ");
            subString = Console.ReadLine();
            Console.WriteLine($"Result: {StringWorker.ReplaceWordsWithDoubleLetters(text, subString)}");

        }
    }
}