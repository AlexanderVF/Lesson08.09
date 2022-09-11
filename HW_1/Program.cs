/* Console.Clear();
Random rand = new Random();

double[,] GetArray(int m, int n, int minValue, int maxValue) 
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; i++) {
            result[i, j] = rand.NextDouble();
        }
    }
    return result;

}
void PrintArray(double [,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.WriteLine(array[i, j]); 
        }
        Console.WriteLine();
    }
}

Console.WriteLine("stroki");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("stolbci");
int columns = int.Parse(Console.ReadLine());

double[,] result = GetArray(rows, columns, 0, 8); 
PrintArray(result);
 */

/* Console.Clear();
int size = 6;
double n = 0;

Random rand = new Random();
double[] array = new double[size];
double max = 0;
double min = 999;

for (int i = 0; i < array.Length; ++i) {
    
    array[i] = rand.NextDouble()*100;
}
Console.WriteLine(string.Join(", ", array)); */


/* Console.WriteLine(" Vvedtite kolvo strok");
double m = double.Parse(Console.ReadLine());

Console.WriteLine(" Vvedtite kolvo stolbcov");
double n = double.Parse(Console.ReadLine()); */
/* double m = 5;
double n = 5; */

/* double[,] a = new double[5, 5];

Random random = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        a[i, j] = random.NextDouble() * 10; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
} */


Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] twoDimArray = new double[m, n];
Random rnd = new Random();
void PrintArray(double[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { Console.Write($"{matr[i, j]} ");}
 Console.WriteLine();}}

void FillArray(double[,] matr)
{ for (int i = 0; i < m; i++)
 { for (int j = 0; j < n; j++)
 { matr[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);}}}
FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);