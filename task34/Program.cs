// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] myArray = getArray(5, 100, 999);
System.Console.WriteLine(myArray);
System.Console.WriteLine(FindNumber(myArray));

int[] getArray(int size, int leftRange, int rightRange)
{
    int[] tempArr = new int[size];
    Random Rand = new Random();
    for (int i = 0; i < tempArr.Length; i++)
    {
        tempArr[i] = Rand.Next(leftRange, rightRange + 1);
    }
    foreach (var item in tempArr)
    {
        System.Console.Write(item + " ");
    }
    return tempArr;
}

string FindNumber(int[] arr)
{
    int count = 0;
   for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count += 1;
    }
    return $"Количество четных чисел {count}";
}
