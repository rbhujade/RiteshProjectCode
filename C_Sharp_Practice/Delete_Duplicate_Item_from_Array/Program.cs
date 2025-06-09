namespace Delete_Duplicate_Item_from_Array
{
    class Program
    {
        public static void Main(string[] args)
        {

            int[] arry = { 1, 2, 3 ,2,1,3};

            int[] distinct = arry.Distinct().ToArray();

            foreach(int i in distinct)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}