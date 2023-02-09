//В двумерном массиве целых чисел. 
//Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
void FillMatrix(int[,] matr)
{for (int i = 0; i < matr.GetLength(0); i++)
{for (int j = 0; j < matr.GetLength(1); j++)
{matr[i,j] = new Random().Next(1,10);}}}

void PrintMatrix(int[,] matr)
{for (int i = 0; i < matr.GetLength(0); i++)
{for (int j = 0; j < matr.GetLength(1); j++)
{Console.Write($"{matr[i,j]} ");}
Console.WriteLine();}}

void MinDelMatrix(int[,] matr)
{
int min = matr[0,0];
int n = 0;
int m = 0;
for (int i = 0; i < matr.GetLength(0); i++)
{for (int j = 0; j < matr.GetLength(1); j++)
{if (matr[i,j] < min)
{min = matr[i,j];
n = i;
m = j;}}}
for (int i = 0; i < matr.GetLength(0); i++)
{for (int j = 0; j < matr.GetLength(1); j++)
{if (i == n || j == m)
continue;
else Console.Write(matr[i,j] + " ");}
Console.WriteLine();}
}

int[,] matrix = new int[5,5];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
MinDelMatrix(matrix);