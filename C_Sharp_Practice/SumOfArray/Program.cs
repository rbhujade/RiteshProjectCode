class Program
{
    static void Main()
    {
        int[] arry = new int[] { 1, 2, 3, 4, 5 };


        int result = SumOfArray(arry);

        if (result > -1)
        {
            Console.WriteLine($"The totl is : {result} ");
        }
        else 
        {
            Console.WriteLine("Can not add up and empty array.");
        }
        

    }

    static int SumOfArray(int[] array)
    {
        if(array.Length >0)
        {
            int total = 0;
            foreach (var item in array)
            {
                total += item;
            }

            return total;
        }
        return -1;
    }
}