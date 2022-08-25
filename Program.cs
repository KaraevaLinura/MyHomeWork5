﻿/*internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear(); // интересная фишка!!! очистка консоли!
        Console.WriteLine($"Задача 34. Количество чётных чисел в массиве:\n");*/

        int[] numbers = new int[10];
 
        void FillArray(int[] array, int min, int max)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(min, max);
            }
        }
 
        void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
 
        int QuantityPositive(int[] array)
        {
            int quantity = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    quantity++;
                }
            }
            return quantity;
        }
 
        FillArray(numbers, 100, 1000);
        WriteArray(numbers);
        Console.WriteLine();
 
        int quantity = QuantityPositive(numbers);
        Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");
    