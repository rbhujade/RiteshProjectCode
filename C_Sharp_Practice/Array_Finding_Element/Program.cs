using System;

namespace Array_Finding_Element
{
    class Program
    {
        public static void Main(string[] args)
        {
            //CheckElementExistArray();
            CopyingArray();
        }

        public static void CheckElementExistArray()
        {
            int[] arr = { -1, 0, 2, -3, 93, 4973, -893, 83 };

            //Array.ForEach();

            bool exist = Array.Exists(arr, e => e == 9);

            Console.WriteLine(exist);
            Console.ReadLine();
        }

        //IndexOf
        public static void ArrayIndexOf()
        {
            int[] arr = { -1, 0, 2, -3, 93, 4973, -893, 83 };

            int index = Array.IndexOf(arr, 93);

            Console.WriteLine(index);
            Console.ReadLine();
        }

        //Copying an Array
        public static void CopyingArray()
        {
            int[] arr = { -1, 0, 2, -3, 93, 4973, -893, 83 };

            foreach (int i in arr)
            {
                Console.WriteLine("Source array element : " + i);
            }

            int[] copy = new int[arr.Length];

            Array.Copy(arr,copy,arr.Length);

            foreach (int i in copy)
            {
                Console.WriteLine("Copy array element : " + i);
            }

            Console.ReadLine();
        }
    }
}