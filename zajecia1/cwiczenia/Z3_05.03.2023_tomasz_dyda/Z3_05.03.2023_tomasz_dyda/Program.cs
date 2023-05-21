﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 3, 2, 0, 9, 6, 2, 1, 8 };
        int min = FindMinimum(array, 0, array.Length - 1);
        int max = FindMaximum(array, 0, array.Length - 1);

        Console.WriteLine("Minimum: " + min);
        Console.WriteLine("Maximum: " + max);
    }

    static int FindMinimum(int[] array, int left, int right)
    {
        if (left == right) // pojedynczy element w ciągu
            return array[left];

        int mid = (left + right) / 2;

        int leftMin = FindMinimum(array, left, mid);
        int rightMin = FindMinimum(array, mid + 1, right);

        return Math.Min(leftMin, rightMin);
    }

    static int FindMaximum(int[] array, int left, int right)
    {
        if (left == right) // pojedynczy element w ciągu
            return array[left];

        int mid = (left + right) / 2;

        int leftMax = FindMaximum(array, left, mid);
        int rightMax = FindMaximum(array, mid + 1, right);

        return Math.Max(leftMax, rightMax);
    }
}
