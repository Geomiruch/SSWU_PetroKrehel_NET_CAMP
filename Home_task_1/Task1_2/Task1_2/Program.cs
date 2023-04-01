namespace Task1_2
{// Все було б просто чудово, якщо б розділили на методи та поклали у відповідний клас.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { 
                { 1, 1, 1, 2, 3 }, 
                { 1, 2, 3, 3, 3 }, 
                { 2, 2, 2, 3, 3 }, 
                { 3, 3, 3, 3, 4 } };

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int maxLineLength = 0; 
            int startRow = 0; 
            int startCol = 0; 

            for (int i = 0; i < rows; i++)
            {
                int currentLength = 1;
                for (int j = 1; j < columns; j++)
                {
                    if (matrix[i, j] == matrix[i, j - 1]) 
                    {
                        currentLength++;
                    }
                    else 
                    {
                        if (currentLength > maxLineLength) 
                        {
                            maxLineLength = currentLength;
                            startRow = i;
                            startCol = j - currentLength;
                        }
                        currentLength = 1;
                    }
                }
                if (currentLength > maxLineLength) 
                {
                    maxLineLength = currentLength;
                    startRow = i;
                    startCol = columns - currentLength;
                }
            }

            Console.WriteLine("Знайдена найдовша лінія:");
            Console.WriteLine("Початок: ({0}, {1})", startRow, startCol);
            Console.WriteLine("Кінець: ({0}, {1})", startRow, startCol + maxLineLength - 1);
            Console.WriteLine("Довжина: {0}", maxLineLength);
        }
    }
}
