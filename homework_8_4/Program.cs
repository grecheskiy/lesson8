//Сформировать трехмерный массив не повторяющимися двузначными числами 
//показать его построчно на экран выводя индексы соответствующего элемента
Console.Write("Enter x: ");
int x = int.Parse(Console.ReadLine()?? "");
Console.Write("Enter y: ");
int y = int.Parse(Console.ReadLine()?? "");
Console.Write("Enter z: ");
int z = int.Parse(Console.ReadLine()?? "");
Console.WriteLine();
int[,,] matrix3D = new int[x, y, z];
FillMatrix(matrix3D);
PrintMatrix(matrix3D);

void PrintMatrix(int[,,] array3D)
{for (int i = 0; i < array3D.GetLength(0); i++)
{for (int j = 0; j < array3D.GetLength(1); j++)
{Console.Write($"x({i}) y({j}) ");
for (int k = 0; k < array3D.GetLength(2); k++)
{Console.Write( $"z({k})={array3D[i,j,k]}; ");}
Console.WriteLine();}
Console.WriteLine();}}

void FillMatrix(int[,,] matrix3D)
{int[] temp = new int[matrix3D.GetLength(0) * matrix3D.GetLength(1) * matrix3D.GetLength(2)];
int  number;
for (int i = 0; i < temp.GetLength(0); i++)
{temp[i] = new Random().Next(0, 100);
number = temp[i];
if (i >= 1)
{for (int j = 0; j < i; j++)
{while (temp[i] == temp[j])
{temp[i] = new Random().Next(0, 100);
j = 0;
number = temp[i];}
number = temp[i];}}}

int count = 0; 
for (int x = 0; x < matrix3D.GetLength(0); x++)
{for (int y = 0; y < matrix3D.GetLength(1); y++)
{for (int z = 0; z < matrix3D.GetLength(2); z++)
{matrix3D[x, y, z] = temp[count];
count++;}}}}