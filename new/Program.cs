int[,] GetArray(int m, int n, int minValue, int maxValue) {
  int[,] result = new int[m, n];

  for (int i = 0; i < m; ++i) {
    for (int j = 0; j < n; ++j) {
      result[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }

  return result;
}

void PrintArray(int[,] array) {
  for (int i = 0; i < array.GetLength(0); ++i) {
    for (int j = 0; j < array.GetLength(1); ++j) {
      Console.Write(array[i, j]);
    }
    Console.WriteLine();
  }
}

Console.WriteLine(" Vvedtite kolvo strok");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine(" Vvedtite kolvo stolbcov");
int columns = int.Parse(Console.ReadLine());

int[,] result = GetArray(rows, columns, 0, 9);
PrintArray(result);

//for (int i = 0; i < array.GetLength(0); ++i) {
    for (int j = 0; j < result.GetLength(1); ++j) {
        
        int temp = result[0,j];
        result[0,j] = result[rows - 1,j];
        result[rows - 1,j] = temp;

    }

Console.WriteLine();

PrintArray(result);