namespace Left_Circular_Rotation_Array
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bubble Sort :\n");
            BubbleSort();
            ThirdHighestNum();
            //Rotate Left
            int[] ints = { 1, 2, 3 ,4,5};

            foreach (var item in ints)
            {
                Console.Write(item + " , ");
            }
            Console.WriteLine("\n");

            RotateRight();

            int size = ints.Length;
            int temp;

            for (int i = size - 1 ; i > 0; i--) 
            {
                temp = ints[size -1];
                ints[ints.Length - 1] = ints[i - 1];
                ints[i - 1] = temp;
            }
            Console.WriteLine("\n");
            Console.WriteLine("Rotate Left :\n");
            foreach (var item in ints)
            {
                Console.Write(item + " , ");
            }
            Console.ReadLine();
        }

        public static void RotateRight()
        {
            int[] ints = { 1, 2, 3, 4, 5 };

            int size = ints.Length;
            int temp;

            for (int i = 0; i < size - 1; i++) 
            {
                temp = ints[0];
                ints[0] = ints[i + 1];
                ints[i + 1] = temp;
            }
            Console.WriteLine("Rotate Right :\n");
            foreach (var item in ints)
            {
                Console.Write(item + " , ");
            }

        }

        public static void ThirdHighestNum() 
        {
            int[] ints = { 1, 2, 3, 4, 5 };

            var result = ints.OrderByDescending(o=>o).Take(3).Skip(2).FirstOrDefault();
            Console.WriteLine(result.ToString());
        }

        public static void BubbleSort() 
        {
            int[] ints = { 3, 1,5, 2, 3,2, 4,1, 5,4 };

            foreach (var item in ints)
            {
                Console.Write(item + " ");
            }

            int size = ints.Length-1;

            int temp;

            for (int i = 0; i <= size; i++)
            {
                for (int j = 0; j <= size - i - 1; j++)
                {
                    if (ints[j] > ints[j+1])
                    {
                        temp = ints[j];
                        ints[j] = ints[j + 1];
                        ints[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\n");
            foreach (var item in ints)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
        }
    }
}

