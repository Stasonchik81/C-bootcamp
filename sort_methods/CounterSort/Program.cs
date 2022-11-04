// Counter sort
using My_P;

const int THREADS_NUM = 4; // количество потоков
const int N = 1000; // количество элементов массива


int[] myArray = My_program.GetRandomArray(N, -10, 10);
// My_program.PrintArr(myArray);
int[] resSerial = new int[N];
Array.Copy(myArray, resSerial, N);
int[] resParallel = new int[N];
Array.Copy(myArray, resParallel, N);

CounterSortExt2(resSerial);
PrepareParallelCountingSort(resParallel);
Console.WriteLine(My_program.EqualityArray(resSerial, resParallel, N));

// My_program.PrintArr(resSerial);
// My_program.PrintArr(resParallel);

void PrepareParallelCountingSort(int[] inputArr)
{
    int max = inputArr.Max();
    int min = inputArr.Min();

    int offset = - min;

    int[] counters = new int[max + offset + 1];

    int eachThreadsCalc = N / THREADS_NUM;
    var threadsParallel = new List<Thread>();
    for (int i = 0; i < THREADS_NUM; i++)
    {
        int startPos = i * eachThreadsCalc;
        int endPos = (i + 1) * eachThreadsCalc;
        if(i == THREADS_NUM -1) endPos = N;
        threadsParallel.Add(new Thread(() => ParallelCountSort(inputArr, counters, startPos, endPos, offset)));
        threadsParallel[i].Start();
    }
    foreach (var thread in threadsParallel)
    {
        thread.Join();
    }
}

void ParallelCountSort(int[]arr, int[] counter, int start, int end, int offset)
{
    for (int i = start; i < end; i++)
    {
        counter[arr[i] + offset]++;
    }
    int index = 0;
    for (int i = 0; i < counter.Length; i++)
    {
        for (int j = 0; j < counter[i]; j++)
        {
            arr[index] = i - offset;
            index++;
        }
    }
}

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

void CounterSortExt2(int[] arr)
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
}




