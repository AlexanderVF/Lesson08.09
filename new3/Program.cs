/* int[,] GetArray(int m, int n, int minValue, int maxValue) {
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

int[] array2 = new int[rows*columns]; 
int z = 0;

for (int i = 0; i < result.GetLength(0); ++i) {
    for (int j = 0; j < result.GetLength(1); ++j) {
        array2[z] = result[i,j];
        z++;
    }
    while (array2[i] > array2[i + 1]) {
    
    int temp = array2[i];
        array2[i] = array2[i+1];
        array2[i +1] = temp;
        i++;
}
}
Console.WriteLine();
Console.WriteLine(string.Join(", ", array2));

int min = 0;

/* for (int i = 0; i < array2.Length - 1; i++) {
    for (min = 0; array2[i] > array2[i + 1]; i++) {
        int temp = array2[i];
        array2[i] = array2[i+1];
        array2[i +1] = temp;

        Console.WriteLine(string.Join(", ", array2));
    }
} */
/* array2[i] = min;
for (int i = 0; i < array2.Length - 1; i++) {
    if (array2[i] < min) {
        array2[i] = min;
        temp = min;
        array2[i] = array2[i+1];
        array2[i +1] = temp;

        Console.WriteLine(string.Join(", ", array2));
    }
} */
//int i = 0;

Console.WriteLine();
Console.WriteLine(string.Join(", ", array2)); */


/* int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); ++i)
    {
        for (int j = 0; j < arr.GetLength(1); ++j)
        {
            Console.Write("  " + arr[i, j]);
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число строк массива: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n = int.Parse(Console.ReadLine());

int[,] array = GetArray(m, n);
PrintArray(array);
Console.WriteLine();
int[] arrayNew = new int[m * n];

int k = 0;

for (int i = 0; i < array.GetLength(0); ++i)
{
    for (int j = 0; j < array.GetLength(1); ++j)
    {
        arrayNew[k] = array[i, j];
        ++k;
    }

}
Console.WriteLine(string.Join(" ", arrayNew));

for (int i = 0; i < arrayNew.Length; ++i)
{
    for (int j = i + 1; j < arrayNew.Length; ++j)
    {
        if (arrayNew[i] > arrayNew[j])
        {

            int temp = arrayNew[i];
            arrayNew[i] = arrayNew[j];
            arrayNew[j] = temp;
        }
    }
}
Console.Write(string.Join(" ", arrayNew));
int count = 1;
int el = arrayNew[0];
Console.WriteLine();
for (int i = 1; i < arrayNew.Length; ++i)
{
    if (arrayNew[i] == el)
    {
        count++;
    }
    else
    {
        Console.WriteLine(el + " встречается " + count);
        el = arrayNew[i];
        count = 1;
    }
}
Console.WriteLine(el + " встречается " + count); */





Console.WriteLine("Vvedite kol-vo strok");

int rows = int.Parse(Console.ReadLine());

for (int i = 0; i < rows; ++i) {
  for (int  j = 0; j <= (rows - i); ++j) {
    Console.Write(" ");
  }
  for (int j = 0; j <= i; ++j) {
    Console.Write(factorial(i) / (factorial(j)*factorial(i - j)));
    Console.Write(" ");
  }
  Console.WriteLine();
}

double factorial(int a) {
  double x = 1;
  for (int i = 1; i <= a; ++i) {
    x *= i;
  }
  return x;
}
