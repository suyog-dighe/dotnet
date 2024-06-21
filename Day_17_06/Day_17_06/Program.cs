using System;

namespace Day_17_06     
{
    internal class Program
    {
        static void Main()
        {
            Program program = new Program();
            program.TransposeMatrixDemo();
            program.InterchangeColumnsDemo();
            program.ConcatenateStringsDemo();
            program.SortingDemo();
            program.SearchElementDemo();
        }

        // 1. Transpose Matrix
        void TransposeMatrixDemo()
        {
            int[,] matrix = GetMatrixFromUser();
            int[,] transposedMatrix = TransposeMatrix(matrix);

            Console.WriteLine("Original Matrix:");
            PrintMatrix(matrix);

            Console.WriteLine("Transposed Matrix:");
            PrintMatrix(transposedMatrix);
        }

        int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] transposed = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposed[j, i] = matrix[i, j];
                }
            }

            return transposed;
        }

        // 2. Interchange Columns of a Matrix
        void InterchangeColumnsDemo()
        {
            int[,] matrix = GetMatrixFromUser();
            Console.Write("Enter the first column to interchange: ");
            int col1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second column to interchange: ");
            int col2 = int.Parse(Console.ReadLine());

            InterchangeColumns(matrix, col1, col2);

            Console.WriteLine("Matrix after interchanging columns:");
            PrintMatrix(matrix);
        }

        void InterchangeColumns(int[,] matrix, int col1, int col2)
        {
            int rows = matrix.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                int temp = matrix[i, col1];
                matrix[i, col1] = matrix[i, col2];
                matrix[i, col2] = temp;
            }
        }

        // 3. Concatenate Two Strings
        void ConcatenateStringsDemo()
        {
            Console.Write("Enter the first string: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter the second string: ");
            string str2 = Console.ReadLine();

            string result = ConcatenateStrings(str1, str2);

            Console.WriteLine("Concatenated String: " + result);
        }

        string ConcatenateStrings(string str1, string str2)
        {
            return str1 + str2;
        }

        // 4. Sorting Algorithms
        void SortingDemo()
        {
            int[] array = GetArrayFromUser();

            Console.WriteLine("Original Array:");
            PrintArray(array);

            // Bubble Sort
            BubbleSort(array);
            Console.WriteLine("Array after Bubble Sort:");
            PrintArray(array);

            // Quick Sort
            array = GetArrayFromUser();
            QuickSort(array, 0, array.Length - 1);
            Console.WriteLine("Array after Quick Sort:");
            PrintArray(array);

            // Merge Sort
            array = GetArrayFromUser();
            MergeSort(array, 0, array.Length - 1);
            Console.WriteLine("Array after Merge Sort:");
            PrintArray(array);
        }

        void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);

                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }

        int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }

        void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(array, left, mid);
                MergeSort(array, mid + 1, right);

                Merge(array, left, mid, right);
            }
        }

        void Merge(int[] array, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            Array.Copy(array, left, L, 0, n1);
            Array.Copy(array, mid + 1, R, 0, n2);

            int i = 0, j = 0;
            int k = left;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                array[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = R[j];
                j++;
                k++;
            }
        }

        // 5. Search an Element in an Array
        void SearchElementDemo()
        {
            int[] array = GetArrayFromUser();
            Console.Write("Enter the element to search for: ");
            int target = int.Parse(Console.ReadLine());

            int index = SearchElement(array, target);

            if (index != -1)
            {
                Console.WriteLine($"Element {target} found at index {index}.");
            }
            else
            {
                Console.WriteLine($"Element {target} not found in the array.");
            }
        }

        int SearchElement(int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }

        // Utility Methods
        int[] GetArrayFromUser()
        {
            Console.Write("Enter the number of elements in the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;
        }

        int[,] GetMatrixFromUser()
        {
            Console.Write("Enter the number of rows in the matrix: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of columns in the matrix: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter element at ({i}, {j}): ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return matrix;
        }

        void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
