// Test 2
// Quick sort

int len = InputIntData("Введите длинну массива");
int minSize = InputIntData("Введите минимальное число");
int maxSize = InputIntData("Введите максимальное число");

int[] myArray = GetRandomArray(len, minSize, maxSize);

// int[] myArray = {0, -5, 2, 3, 5, 9, -1, 7};
PrintArr(myArray);
var time1 = DateTime.Now;
int[] resultArray = QuickSort(myArray, 0, myArray.Length-1);
var time2 = DateTime.Now;
var delta = time2 - time1;
Console.Write(delta);
PrintArr(resultArray);


int[] QuickSort(int[] arr, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex)
    {
        return arr;
    }
    int indexPiv = GetPivIndex(arr, minIndex, maxIndex);
    QuickSort(arr, minIndex, indexPiv - 1);
    QuickSort(arr, indexPiv + 1, maxIndex);
    return arr;
}

int GetPivIndex(int[] arr, int minIndex, int maxIndex)
{
    int pivIndex = minIndex-1;
    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (arr[i] < arr[maxIndex])
        {
            pivIndex++;
            Swap(arr, pivIndex, i);
        }
    }
    pivIndex++;
    Swap(arr, pivIndex, maxIndex);
    return pivIndex;
}

// Генератор массива
/// <summary>
/// генератор массива случайных целых чисел
/// </summary>
/// <param name="size">размер массива</param>
/// <param name="min">минимальное значение элемента</param>
/// <param name="max">максимальное значение элемента</param>
/// <returns></returns>
int[] GetRandomArray(int size, int min, int max)
{
    Random rnd = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}
// Ввод данных
/// <summary>
/// Ввод целочисленных данных
/// </summary>
/// <param name="message">Выводимое сообщение</param>
/// <returns>целое число (вводимые данные)</returns>
int InputIntData(string message)
{
    Console.Write($"{message} : ");
    int data = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    return data;
}
// Печать массива
/// <summary>
/// Печать массива
/// </summary>
/// <param name="arr">массив</param>
void PrintArr(int[] arr)
{
    Console.WriteLine($"[ {string.Join(", ", arr)} ]");
}

void Swap(int[]arr, int i, int j)
{
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}
