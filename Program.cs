using System.Diagnostics;
using System.Xml.Serialization;

namespace compare_algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random();
            Stopwatch sw = new Stopwatch();

            Console.WriteLine("How many numbers in the array?");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] Numbers = CreateArray(length);
            int choice;
            menu(int choice);
           if (choice == 3)  //bubble sort
            {
                Numbers = BubbleSort(int[] Numbers)
                    Console.WriteLine("The array is sorted");
            }
           if (choice == 1) // linear search
            {
                Console.WriteLine("What are you searching for?");
                int NumToFind = Convert.ToInt32(Console.ReadLine());
                int index = LinearSearch(Numbers, NumToFind);
                
            }
            bool sorted = false;
        }
        static int[] CreateArray(int size, Random r)
        {
            int[] numbers = new int[size];
            for(int i = 0; i < size; i++)
            {
                numbers[i] = r.Next(0, 999);
            }
            return numbers;
        }
        static void menu(int choice)
        {
            Console.WriteLine("1 - Linear search");
            Console.WriteLine("2 - Binary search");
            Console.WriteLine("3 - Bubble sort");
            Console.WriteLine("4 - Merge sort");
            Console.WriteLine("9 - Quit");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice != 1 || choice != 2 || choice != 3 || choice != 4 || choice != 9)
            {
                Console.WriteLine("Choose an option");
            }
            return choice;
        }
        
        static void BubbleSort(int[] numbers)
        {
            int temp;
            bool swaps;
            int count = 0;
            do
            {
                swaps = false;
                for (int j = 0; j <= numbers.Length - 2; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        swaps = true;
                    }
                    count++;
                }
            } while (swaps);
            return numbers;
        }
        static void Merge(int[] a, int low, int mid, int high)
        {
            int i, j, k;
            int num1 = mid - low + 1;
            int num2 = high - mid;
            int[] L = new int[num1];
            int[] R = new int[num2];
            for (i = 0; i < num1; i++)
            {
                L[i] = a[low + i];
            }
            for (j = 0; j < num2; j++)
            {
                R[j] = a[mid + j + 1];
            }
            i = 0;
            j = 0;
            k = low;
            while (i < num1 && j < num2)
            {
                if (L[i] <= R[j])
                {
                    a[k] = L[i];
                    i++;
                }
                else
                {
                    a[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < num1)
            {
                a[k] = L[i];
                i++;
                k++;
            }
            while (j < num2)
            {
                a[k] = R[j];
                j++; k++;
            }
            
        }
        static void MergeSortRecursive(int[] a, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSortRecursive(a, low, mid);
                MergeSortRecursive(a, mid + 1, high);
                Merge(a, low, mid, high);
            }
        }
        static bool LinearSearch(int[] a, int numToFind)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == numToFind)
                {
                    Console.WriteLine("The number is at index " + i);
                }
                
            }
            Console.WriteLine("The number isn't found");
        }
        static bool BinarySearch(int[] a, int numToFind)
        {
            int midpointIndex = [a.Length % 2];
            int UpperBound = 0;
            int LowerBound = a[0];
            while (a[midpointIndex] != numToFind)
            {
                while (a[midpointIndex] > numToFind)
                {
                    UpperBound = a[midpointIndex];
                    midpointIndex = midpointIndex % 2;
                    if (a[midpointIndex] == numToFind)
                    {
                        Console.WriteLine("The number is at index " + midpointIndex);
                    }

                }
                while (a[midpointIndex] < numToFind)
                {
                    UpperBound = a[midpointIndex];
                    midpointIndex = midpointIndex % 2;
                    if (a[midpointIndex] == numToFind)
                    {
                        Console.WriteLine("The number is at index " + midpointIndex);
                    }
                }
            }
        }
            
    }
}
