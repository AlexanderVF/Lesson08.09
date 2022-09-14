

int[,] GetArray(int m, int n) {
  int[,] result = new int[m, n];

  for (int i = 0; i < m; ++i) {
    for (int j = 0; j < n; ++j) {
      result[i, j] = new Random().Next(1, 100);
    }
  }

  return result;
}

void PrintArray(int[,] array) {
  for (int i = 0; i < array.GetLength(0); ++i) {
    for (int j = 0; j < array.GetLength(1); ++j) {
      Console.Write($" {array[i, j]}");
    }
    Console.WriteLine();
        
    }
}

Console.WriteLine(" Vvedtite chislo");
int d = int.Parse(Console.ReadLine());
int c = 0;

Console.WriteLine(" Vvedtite kolvo strok");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine(" Vvedtite kolvo stolbcov");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns);
PrintArray(array);
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); ++i) 
{
    for (int j = 0; j < array.GetLength(1); ++j)
    {
        if (array[i,j] == d)
        {
        c = d;
        }
    }
}

Console.WriteLine();

if (c != d)
{
Console.WriteLine(d + " -> takogo chisla v massive net");
}
else
{
    Console.WriteLine(d + " -> takoe chislo v massive est'");
}

