static int[,,] Create(int m, int n, int k)
{
    int[,,] array = new int[m, n, k];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int a = 0; a < array.GetLength(2); a++) { array[i, j, a] = Unique(array, i, j, a); }
        }
    }
    return array;
}
static int Unique(int[,,] array, int i, int j, int a)
{
    int value = default;
    bool exist = true;
    Random rnd = new Random();
    while (exist)
    {
        bool _break = false;
        value = rnd.Next(1000);
        for (int i1 = 0; i1 < array.GetLength(0); i1++)
        {
            if (_break) { break; }
            for (int j1 = 0; j1 < array.GetLength(1); j1++)
            {
                if (_break) { break; }
                for (int a1 = 0; a1 < array.GetLength(2); a1++)
                {
                    if (array[i1, j1, a1] == value) { _break = true; break; }
                    if (i1 == i && j1 == j && a1 == a) { exist = false; }
                }
            }
        }
    }
    return value;
}
static void Output(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(" ");
            for (int k = 0; k < array.GetLength(2); k++) 
            { 
                Console.Write($"{array[i, j, k],1}({i},{j},{k}) "); 
            }
        }
        Console.WriteLine();
    }
}
void Main()
{
    Console.WriteLine("Введите размерность трехмерного массива m*n*k:");
    int m = Int32.Parse(Console.ReadLine());
    int n = Int32.Parse(Console.ReadLine());
    int k = Int32.Parse(Console.ReadLine());
    int[,,] array = Create(m, n, k);
    Output(array);
    Console.ReadLine();
}

Main();