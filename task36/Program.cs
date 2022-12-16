// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] myArray = getArray(4, 1, 100);
System.Console.WriteLine(myArray);
System.Console.WriteLine(SumN(myArray));

int[] getArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(leftRange, rightRange + 1);
    }
    foreach (var item in arr)
    {
        System.Console.Write(item + " ");
    }
    return arr;
}

string SumN (int[] arr)
{
    int Sum = 0;

   for (int i = 0; i < arr.Length; i++)
    {
        if (i %2 == 0)
            Sum= Sum + arr[i];
    }
    return $"Сумма элементов на нечетных позициях = {Sum}";
}