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
    }

}
