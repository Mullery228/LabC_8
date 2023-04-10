
void Output(int[,] matrix, int m, int n)
{
    Console.WriteLine("Матрица A*B:");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0} ", matrix[i, j]);
        }
        Console.WriteLine();
    }
}
void Composition(int[,] matrixA, int[,] matrixB, int m, int n)
{
    int[,] matrixC = new int[n, m];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    Console.WriteLine();
    Output(matrixC, m, n);
}

void Create_matrixs(int m, int n)
{
    int[,] matrixA = new int[m, n];
    int[,] matrixB = new int[m, n];
    Random rand = new Random();
    Console.WriteLine("Исходная матрица A:");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrixA[i, j] = rand.Next(20);
            Console.Write(matrixA[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Исходная матрица B:");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrixB[i, j] = rand.Next(20);
            Console.Write(matrixB[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    Composition(matrixA, matrixB, m, n);
}


void Input()
{
    Console.WriteLine("Введите размерность для двух матриц m*n:");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    Create_matrixs(m, n);
}

Input();