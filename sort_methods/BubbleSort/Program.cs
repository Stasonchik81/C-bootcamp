// Bubble sort
global using My_P;

int len = My_program.InputIntData("Введите длинну массива");
int[] arr = new int[len];
for (int i = 0; i < len; i++)
{
    arr[i] = My_program.InputIntData("Введите число");
}
My_program.PrintArr(arr);
BubbleSort(arr);
My_program.PrintArr(arr);



void BubbleSort(int[] arr)
{
    for (int i = 0; i < arr.Length-1; i++)
    {
        for (int j = 0; j < arr.Length - 1 - i; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                Swap(arr, j);
            }
            Console.Write(j);
        }
        Console.Write($"{i+1} - ");
        My_program.PrintArr(arr);
    }
}

void Swap(int[]arr, int i)
{
    int temp = arr[i];
    arr[i] = arr[i + 1];
    arr[i + 1] = temp;
}
