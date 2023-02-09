//Найти произведение двух матриц
int[,] MultMatrix = new int[3, 5];
int[,] Matrix1 = new int[3, 5];
int[,] Matrix2 = new int[3, 5];
FillMatrix(Matrix1, Matrix2);
PrintMatrix(Matrix1, Matrix2);
MultiplyMatrix(Matrix1, Matrix2, MultMatrix);
Console.WriteLine();
PrintMultMatrix(MultMatrix);

void FillMatrix(int[,] matr1, int[,] matr2)
{
for (int i = 0; i < matr1.GetLength(0); i++)
{for (int j = 0; j < matr1.GetLength(1); j++)
{matr1[i, j] = new Random().Next(1,10);}
}
for (int i = 0; i < matr2.GetLength(0); i++)
{for (int j = 0; j < matr2.GetLength(1); j++)
{matr2[i, j] = new Random().Next(1,10);}}
}

void PrintMatrix(int[,] matr1, int[,] matr2)
{
for (int i = 0; i < matr1.GetLength(0); i++)
{for (int j = 0; j < matr1.GetLength(1); j++)
{Console.Write($"{matr1[i, j]} ");}
Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < matr2.GetLength(0); i++)
{for (int j = 0; j < matr2.GetLength(1); j++)
{Console.Write($"{matr2[i, j]} ");}
Console.WriteLine();}
}

void MultiplyMatrix(int[,] matr1, int[,] matr2, int[,] multmatr)
{for (int i = 0; i < multmatr.GetLength(0); i++)
{for (int j = 0; j < multmatr.GetLength(1); j++)
{multmatr[i, j] = matr1[i, j] * matr2[i, j];}}}

void PrintMultMatrix(int[,] multmatr)
{for (int i = 0; i < multmatr.GetLength(0); i++)
{for (int j = 0; j < multmatr.GetLength(1); j++)
{Console.Write($"{multmatr[i, j]} ");}
Console.WriteLine();}}