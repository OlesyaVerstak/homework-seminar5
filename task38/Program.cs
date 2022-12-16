// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] myArray = getArray(4, 1, 10);
System.Console.WriteLine(myArray);
System.Console.WriteLine(Diff(myArray));

double[] getArray(int size, int leftRange, int rightRange)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.Next(leftRange, rightRange + 1)+ rand.NextDouble(), 3);
    }
    foreach (var item in arr)
    {
        System.Console.Write(item + " ");
    }
    return arr;
}

string Diff (double[] arr)
{
    double dif = 0;
    double max = arr[0];
    double min = arr[0];

   for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>= max)
            max= arr[i];
        else if (arr[i]<= min)
        min = arr[i];
    }
    dif = max - min;
    return $"Разница между минимальным и максимальным значением  = {dif}";
}