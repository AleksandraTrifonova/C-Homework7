// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
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
Console.WriteLine("Исходный массив: ");
PrintArray(matrix);
 
for (int i = 0; i < row; i++)
    for (int j = 0; j < col; j++)
        for (int a = 0; a < col - 1; a++)
            if(matrix[i, a] < matrix [i, a + 1])
                {
                    int temporary = matrix[i, a];
                    matrix[i, a] = matrix [i, a + 1];
                    matrix [i, a + 1] = temporary;
                }

Console.WriteLine("Mассив после сортировки: ");
PrintArray(matrix);


