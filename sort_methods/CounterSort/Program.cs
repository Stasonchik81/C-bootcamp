// Counter sort
using My_P;

int[] myArray = My_program.GetRandomArray(9, -20, 20);
My_program.PrintArr(myArray);
int[] newArr = CounterSortExt2(myArray);
My_program.PrintArr(newArr);


void CounterSort(int[] arr)
{
    int[] counters = new int[10];
    for (int i = 0; i < arr.Length; i++)
    {
        counters[arr[i]]++;
    }
    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            arr[index] = i;
            index++;
        }
    }
}
int[] CounterSortExt1(int[] arr)
{
    int max = arr.Max();

    int[] counters = new int[max + 1];
    for (int i = 0; i < arr.Length; i++)
    {
        counters[arr[i]]++;
    }
    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            arr[index] = i;
            index++;
        }
    }
    return arr;
}

int[] CounterSortExt2(int[] arr)
{
    int max = arr.Max();
    int min = arr.Min();

    int offset = - min;

    int[] counters = new int[max + offset + 1];
    for (int i = 0; i < arr.Length; i++)
    {
        counters[arr[i] + offset]++;
    }
    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            arr[index] = i - offset;
            index++;
        }
    }
    return arr;
}



