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
  int row = triangle.GetLength(0);
  for (int i = 0; i < row; i++)
  {
    for (int j = 0; j < row; j++)
    {
      if (triangle[i, j] != 0)
        Console.Write($"{triangle[i, j],4}");
    }
    Console.WriteLine();
  }
}

int[] GetKoeff(int[,] tr, int pow)
{
  int[] row = new int[pow + 1];
  for (int i = 0; i <= pow; i++)
  {
    row[i] = tr[pow, i];
  }
  return row;
}

string PrintKoeff(int[] array)
{
  string output = String.Empty;
  int size = array.Length;
  for (int i = 0; i < size; i++)
  {
    if (i != 0) { output += " + "; }
    if((size - 1 - i) == 0){output += $"b^{i}"; }
    if(i == 0){output += $"a^{size - 1 - i}"; }
    if(size == 3 && array[i] != 1 && (size - 1 - i) != 0 && i != 0 && (size - 1 - i) == 1 && i == 1) {output += $"{array[i]}ab"; }
    if(size != 3 && array[i] == 1 && (size - 1 - i) != 0 && i != 0 && i != 1) {output += $"a^{size - 1 - i}b^{i}"; }
    if(size != 3 && array[i] != 1 && (size - 1 - i) != 0 && i != 0 && (size - 1 - i) == 1) {output += $"{array[i]}ab^{i}"; }
    if(size != 3 && array[i] != 1 && (size - 1 - i) != 0 && i != 0 && i == 1) {output += $"{array[i]}a^{size - 1 - i}b"; }    
    if(size != 3 && array[i] != 1 && (size - 1 - i) != 0 && i != 0 && (size - 1 - i) == 1 && i == 1) {output += $"{array[i]}ab"; }    
    if(size != 3 && array[i] != 1 && (size - 1 - i) != 0 && i != 0 && (size - 1 - i) != 1 && i != 1) {output += $"{array[i]}a^{size - 1 - i}b^{i}"; }
  }
    return output;
}

int[,] tr = CreateTriangle(10);
PrintTriangle(tr);
int row = 3; 
int[] array = GetKoeff(tr, row);
Console.WriteLine();
Console.WriteLine(String.Join(' ', array));
Console.WriteLine($"(a+b)^{row} = {PrintKoeff(array)}");
Console.WriteLine();int[,] CreateTriangle(int row)
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