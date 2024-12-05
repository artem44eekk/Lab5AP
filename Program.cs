using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5AP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1            Console.WriteLine("// Task 1: Matrix Symmetry Relative to Main Diagonal");
            int size = 8;
            int[,] matrix = new int[size, size]; Random rand = new Random();
            Console.WriteLine("Original Matrix:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rand.Next(0, 101); Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int[,] transposedMatrix = new int[size, size]; for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    transposedMatrix[i, j] = matrix[j, i];
                }
            }
            Console.WriteLine("\nSymmetric Matrix (relative to main diagonal):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(transposedMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            // Task 2            Console.WriteLine("\n// Task 2: Array Rearrangement and Sorting");
            int arraySize = 20;
            int[] array = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = rand.Next(-10, 11);
            }
            Console.WriteLine("Original Array:");
            Console.WriteLine(string.Join(", ", array));
            int[] negatives = Array.FindAll(array, x => x < 0); int[] nonNegatives = Array.FindAll(array, x => x >= 0);
            Array.Sort(negatives);
            int[] rearrangedArray = new int[arraySize];
            negatives.CopyTo(rearrangedArray, 0); nonNegatives.CopyTo(rearrangedArray, negatives.Length);
            Console.WriteLine("Rearranged and Sorted Array:");
            Console.WriteLine(string.Join(", ", rearrangedArray));
        }
    }
}