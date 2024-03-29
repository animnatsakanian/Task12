using System;

namespace Task12{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 64, 34, 25, 12, 22, 11, 90 };
            SortTemplate bubbleSort = new BubbleSort();
            SortTemplate insertionSort = new InsertionSort();
            SortTemplate selectionSort = new SelectionSort();

            Console.WriteLine("Original Array:");
            PrintArray(numbers);

            Console.WriteLine("\nSorting using Bubble Sort:");
            bubbleSort.Sort(numbers);
            PrintArray(numbers);

            Console.WriteLine("\nSorting using Insertion Sort:");
            insertionSort.Sort(numbers);
            PrintArray(numbers);

            Console.WriteLine("\nSorting using Selection Sort:");
            selectionSort.Sort(numbers);
            PrintArray(numbers);
        }

        static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    abstract class SortTemplate
    {
        public void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (ShouldSwap(array[j], array[j + 1]))
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
        }

        protected abstract bool ShouldSwap(int a, int b);

        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }

    class BubbleSort : SortTemplate
    {
        protected override bool ShouldSwap(int a, int b)
        {
            return a > b;
        }
    }

    class InsertionSort : SortTemplate
    {
        protected override bool ShouldSwap(int a, int b)
        {
            return a < b;
        }
    }

    class SelectionSort : SortTemplate
    {
        protected override bool ShouldSwap(int a, int b)
        {
            return a > b;
        }
    }
}
