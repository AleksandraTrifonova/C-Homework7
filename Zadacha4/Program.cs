// В прямоугольной матрице найти строку с наименьшей суммой элементов.
void FillArray(int[,] array)
{
    for (int i =0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10); 
        }  
    }
} 
void PrintArray(int[,] array)
{
    for (int i =0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine();    
    }
} 
void FindRowsMinSum(int[,] array)
{
    int minInd = 0;
    int[] sum = new int [array.GetLength(1)];
    for (int i =0; i <  array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum[i] = sum[i] + array[i,j];
        }
        if (sum[i] < sum[minInd]) minInd = i;
    }
    Console.WriteLine($"Минимальная сумма элементов строки равна {sum[minInd]}, номер строки {(minInd + 1)}");
}

Console.WriteLine("Введите количество строк row: ");
int row = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите количество столбцов col: ");
int col = int.Parse(Console.ReadLine()??"0");

int[,] array = new int [row,col];

FillArray(array);
Console.WriteLine("Исходная матрица: ");
PrintArray(array);
FindRowsMinSum(array);