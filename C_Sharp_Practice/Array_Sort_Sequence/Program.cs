using System.Collections;

namespace Array_Sort_Sequence
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { -1, 0,2, -3 ,93,4973,-893,83};

            ArrayList neg = new ArrayList();
            ArrayList pos = new ArrayList();
            ArrayList zero = new ArrayList();

            foreach (var item in arr)
            {
                if(item < 0)
                    neg.Add(item);
                else if(item > 0) 
                    pos.Add(item);
                else if(item == 0)
                    zero.Add(item);
            }

            ArrayList arrayList = new ArrayList();
            arrayList.AddRange(neg);
            arrayList.AddRange(pos);
            arrayList.AddRange(zero);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}