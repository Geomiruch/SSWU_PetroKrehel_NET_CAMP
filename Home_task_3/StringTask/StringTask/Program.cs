namespace StringTask
{// В діаграмі користувач, використовуючи воду має можливість міняти вежі. Більш потрібна система, коли  користувач один раз встановлює для себе систему, якою користується.
     //також не зрозуміло, де створюються об'єкти цих класів. Стрілка каже, що насос має вежу. та ще й композиційно. А ще вежу для чогось треба буде клонувати. Ми поки що хотіли з однією розібратись)
     
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
