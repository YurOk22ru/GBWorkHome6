int[,] CreateTriangle(int row)
{
  int[,] triangle = new int[row, row];
  for (int i = 0; i < row; i++)
  {
    triangle[i, 0] = 1;
    triangle[i, i] = 1;
  }

  for (int i = 2; i < row; i++)
  {
    for (int j = 1; j <= i; j++)
    {
      triangle[i, j] =
      triangle[i - 1, j - 1] + triangle[i - 1, j];
    }
  }
  return triangle;
}

void PrintTriangle(int[,] triangle)
{
    for (int i = 0; i < triangle.GetLength(0); i++)
  {
    for (int j = 0; j < triangle.GetLength(1); j++)
    {
      if (triangle[i, j] % 2 == 0) Console.Write(" ");
      else Console.Write("*");
    }
    Console.WriteLine();
  }
}

int[,] tr = CreateTriangle(120);           
PrintTriangle(tr);