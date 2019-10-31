﻿using System;

namespace UnmanagedTypes
{
    public struct Coords<T>
    {
        public T X;
        public T Y;
        public T Z;
    }

    public class UnmanagedTypes
    {
        public static void Main()
        {
            DisplaySize<Coords<int>>();
            DisplaySize<Coords<double>>();
        }

        private unsafe static void DisplaySize<T>() where T : unmanaged
        {
            Console.WriteLine($"{typeof(T)} is unmanaged and its size is {sizeof(T)} bytes");
        }
    }
    // Output:
    // Coords`1[System.Int32] is unmanaged and its size is 8 bytes
    // Coords`1[System.Double] is unmanaged and its size is 16 bytes
}
