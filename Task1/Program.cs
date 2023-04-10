
void Output(int[,] array, int m, int n)
{
    Console.WriteLine();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
void Sort(int[,] array, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        int[] sort_array = new int[n];
        for (int j = 0; j < n; j++)
        {
            sort_array[j] = array[i, j];
        }
        Array.Sort(sort_array);
        Array.Reverse(sort_array);
        for (int j = 0; j < n; ++j)
        {
            array[i, j] = sort_array[j];
        }
    }
    Output(array, m, n);
}

void Create_array(int m, int n)
{
    int[,] array = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rand.Next(100);
            Console.Write(array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
    Sort(array, m, n);
}


void Input()
{
    Console.WriteLine("Введите размер двумерного массива m*n:");
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    Create_array(m, n);
}

Input();