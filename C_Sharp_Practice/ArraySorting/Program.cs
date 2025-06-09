class Program
{
    public static void Main()
    {
        BubbleSort();

        int[] numbers = new int[]
        {
            11,8,98,10,23,3,45,5,66,7
        };

        //Array.Sort(numbers);
        //Array.Reverse(numbers);

        //for (int i = 0; i < numbers.Length; i++) 
        //{ 
        //    Console.WriteLine(numbers[i]);
        //}

        int[] num = new int[numbers.Length];

        int x = 0;

        //Array Reverse
        for (int i = numbers.Length -1 ; i >= 0 ; i--)
        {
            num[x] = numbers[i];
            x++;
        }

        foreach (var item in num)
        {
            Console.WriteLine($"{item}");
        }
    }

    public static void BubbleSort()
    {
        int[] array = new int[] { 93, 29, 57, 38, 96, 63, 13, 09, 76, 100};


        int len = array.Length;

        for (int i = 0; i <= len - 1 ; i++) // 9
        {
            for (int j = 0; j <= len - i - 1; j++) //8
            {
                if(array[j] > array[j+1]) //29 > 93
                {
                    int temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;
                }
            }
        }

        foreach (var item in array)
        {
            Console.WriteLine("Bubble Sort : " + item + "/n");
        }

        Console.ReadLine();
    }
}