
void Output(int[] summ_array, int m, int n)
{
    int min = summ_array[0];
    int number_min = 0;
    for (int i = 1; i < summ_array.Length; i++)
    {
        if (min > summ_array[i])
        {
            min = summ_array[i];
            number_min = i;
        }
    }
    Console.WriteLine("Номер строки с минимальной суммой: " + (number_min + 1));
}
void Summ(int[,] array, int m, int n)
{
    int[] summ_array = new int[m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            summ_array[i] += array[i, j];
        }
    }
    Console.WriteLine();
    Output(summ_array, m, n);
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
    Summ(array, m, n);
}


void Input()
{
    int m = 0;
    int n = 0;
    do
    {
        Console.WriteLine("Введите размер прямоугольного двумерного массива m*n, где m != n:");
        m = Convert.ToInt32(Console.ReadLine());
        n = Convert.ToInt32(Console.ReadLine());
    } while (m == n);

    Create_array(m, n);
}

Input();