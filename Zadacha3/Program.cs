// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
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

void ReplacementRowsToColums(int[,] matr)
{
    int[,] NewMatrix = new int[matr.GetLength(0),matr.GetLength(0)];
    for (int i=0; i<matr.GetLength(0); i++)
        for (int j=i; j<matr.GetLength(1); j++)
        {
            int temporary = matr[j,i];
            matr[j,i] = matr[i,j];
            matr[i,j] = temporary;
        }
}
      
Console.WriteLine("Введите количество строк row: ");
int row = int.Parse(Console.ReadLine()??"0");
Console.WriteLine("Введите количество столбцов col: ");
int col = int.Parse(Console.ReadLine()??"0");

int [,] matrix = new int [row, col];

FillArray(matrix);
Console.WriteLine("Исходный маccив: ");
PrintArray(matrix);

if (row != col)
    Console.WriteLine("Массив не является квадратным");
else
{
Console.WriteLine("Массив после замены строк на столбцы: ");
ReplacementRowsToColums(matrix);
PrintArray(matrix);
}
