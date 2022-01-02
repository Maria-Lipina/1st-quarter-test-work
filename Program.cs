using System.Diagnostics;

void FillMyArray(int[] collection, int minValue, int maxValue) // А тут войд можно и нужно, потому что метод только заполняет
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(minValue, maxValue + 1);
    }
}

string PrintMyArray(int[] collect)
{
    string outputString = String.Empty;
    for (int i = 0; i < collect.Length; i++) outputString += $"{collect[i]} ";
    return outputString;
}

int [] OnlyEvens(int[] collect)
{
int[] result = new int [collect.Length];
int futureLen = 0;

   for (int i = 0; i < collect.Length; i++)
    {
    if (collect[i] % 2 == 0) 
        {
        result[futureLen] = collect[i];
        futureLen++;
        }
    }
Array.Resize(ref result, futureLen);
return result;
}

Stopwatch sw = new Stopwatch();
sw.Start();

int [] A = new int [20];
FillMyArray(A, 0, 100);
Console.WriteLine("Первоначальный массив");
Console.WriteLine(PrintMyArray(A));

Console.WriteLine();

int [] B = OnlyEvens(A);
Console.WriteLine("Итоговый массив");
Console.WriteLine(PrintMyArray(B));

sw.Stop();
System.Console.WriteLine(sw.ElapsedMilliseconds);