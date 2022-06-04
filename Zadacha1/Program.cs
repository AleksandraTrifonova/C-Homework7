// Написать программу, которая обменивает элементы первой строки и последней строки
void FillArray(int[,] matr)
{
    for (int i =0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,10); 
        }  
    }
} 
void PrintArray(int[,] matr)
{
    for (int i =0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();    
    }
} 

Console.WriteLine("Введите количество строк row: ");
int row = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите количество столбцов col: ");
int col = int.Parse(Console.ReadLine()??"0");

int[,] matrix = new int [row,col];

FillArray(matrix);
Console.WriteLine("Заданная матрица: ");
PrintArray(matrix);

int tmp = 0;
for (int j=0; j<col; j++)
{
    tmp = matrix[0,j];
    matrix[0,j] = matrix[row-1,j];
    matrix[row-1,j] = tmp;
}

Console.WriteLine("Матрица после обмена строк: ");
PrintArray(matrix);
