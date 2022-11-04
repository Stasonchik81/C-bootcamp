namespace My_P
{
    class My_program
    {
        /// <summary>
        /// Ввод целочисленных данных
        /// </summary>
        /// <param name="message">Выводимое сообщение</param>
        /// <returns>целое число (вводимые данные)</returns>
        public static int InputIntData(string message)
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
        public static void PrintArr(int[] arr)
        {
            Console.WriteLine($"[ {string.Join(", ", arr)} ]");
        }

        /// <summary>
        /// генератор массива
        /// </summary>
        /// <param name="size">размер массива</param>
        /// <param name="min">минимальное значение элемента</param>
        /// <param name="max">максимальное значение элемента</param>
        /// <returns></returns>
        public static int[] GetRandomArray(int size, int min, int max)
        {
            Random rnd = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(min, max);
            }
            return arr;
        }
        public static bool EqualityArray(int[] first, int[] second, int size)
        {
            bool res = true;
            for (int i = 0; i < size; i++)
            {
                res = res && (first[i] == second[i]);
            }
            return res;
        }
    }

}
