// Test 3
// ShakerSort

//  Ввод данных в ручном режиме------
int len = InputIntData("Введите длинну массива");
// int[] arr = new int[len];
// for (int i = 0; i < len; i++)
// {
//     arr[i] = InputIntData("Введите число");
// }
int minSize = InputIntData("Введите минимальное число");
int maxSize = InputIntData("Введите максимальное число");

int[] arr = GetRandomArray(len, minSize, maxSize);

// Генератор массива
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

// int[] arr = {0, -5, 2, 3, 5, 9, -1, 7};

PrintArr(arr);
var time1 = DateTime.Now;
int[] result = ShakerSort(arr);
var time2 = DateTime.Now;
var delta = time2 - time1;
Console.Write(delta);
PrintArr(result);

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

/// <summary>
/// Печать массива
/// </summary>
/// <param name="arr">массив</param>
void PrintArr(int[] arr)
{
    Console.WriteLine($"[ {string.Join(", ", arr)} ]");
}

int[] ShakerSort(int[]arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        var swapFlag = false;
        for (int j = i; j < arr.Length - i - 1; j++)
        {
            if(arr[j] > arr[j + 1])
            {
                Swap(ref arr[j], ref arr[j + 1]);
                swapFlag = true;
            }
        }
        for (int j = arr.Length - 2 - i; j > i; j--)
        {
            if(arr[j-1] > arr[j])
            {
                Swap(ref arr[j], ref arr[j - 1]);
                swapFlag = true;
            }
        }
        if(!swapFlag) break;
    }
    return arr;
}

void Swap(ref int e1, ref int e2)
    {
        var temp = e1;
        e1 = e2;
        e2 = temp;
    }