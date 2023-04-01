// Але ми домовлялись мислити об'єктно-зорієнтовано!!!!!
static void FillMatrixInClockOrder(int[,] matrix)
{//hfhldfkjhlkf
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);
    int maxRow = rowCount - 1, maxCol = colCount - 1;
    int minRow = 0, minCol = 0;
    int num = 1;

    while (num <= rowCount * colCount)
    {
        for (int i = minCol; i <= maxCol; i++)
        {
            matrix[minRow, i] = num++;
        }
        minRow++;
        for (int i = minRow; i <= maxRow; i++)
        {
            matrix[i, maxCol] = num++;
        }
        maxCol--;
        // Ця умова лишня...ЇЇ можна уникнути
        if (num <= rowCount * colCount)
        {
            for (int i = maxCol; i >= minCol; i--)
            {
                matrix[maxRow, i] = num++;
            }
            maxRow--;
        }
        if (num <= rowCount * colCount)
        {
            for (int i = maxRow; i >= minRow; i--)
            {
                matrix[i, minCol] = num++;
            }
            minCol++;
        }
    }
}

static void FillMatrixInAntiClockOrder(int[,] matrix)
{
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);
    int maxRow = rowCount - 1, maxCol = colCount - 1;
    int minRow = 0, minCol = 0;
    int num = 1;

    while (num <= rowCount * colCount)
    {
        for (int i = minRow; i <= maxRow; i++)
        {
            matrix[i, minCol] = num++;
        }
        minCol++;
        for (int i = minCol; i <= maxCol; i++)
        {
            matrix[maxRow, i] = num++;
        }
        maxRow--;
        if (num <= rowCount * colCount)
        {
            for (int i = maxRow; i >= minRow; i--)
            {
                matrix[i, maxCol] = num++;
            }
            maxCol--;
        }
        if (num <= rowCount * colCount)
        {
            for (int i = maxCol; i >= minCol; i--)
            {
                matrix[minRow, i] = num++;
            }
            minRow++;
        }
    }
}

Console.WriteLine("Введіть n-розмірність матриці: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введіть m-розмірність матриці: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
Console.WriteLine("Введіть 1, щоб рухатись за годинниковою стрілкою, або -1 - щоб проти: ");
int direction = Convert.ToInt32(Console.ReadLine());
if(direction==1)
{
    Console.WriteLine("За годинниковою: ");
    FillMatrixInClockOrder(matrix);
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
if (direction == -1)
{
    Console.WriteLine("Проти годинникової: ");
    FillMatrixInAntiClockOrder(matrix);
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
    
