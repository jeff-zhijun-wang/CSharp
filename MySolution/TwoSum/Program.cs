using System;
using System.Collections;
using System.Collections.Generic;

namespace TwoSum
{
    //array, arrayList and List<int> example
    class Program
    {
        static public int[] twoSum(ArrayList nums, int target)
        {
            List<int> tempList = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                int x = target - (int)nums[i];
                if (tempList.Contains(x))
                    return new int[] { tempList.IndexOf(x), i };
                else
                    tempList.Add((int)nums[i]);
            }


            throw new  Exception("No two sums solution");
            
        }
        static void Main(string[] args)
        {
            int[] a = new int[4]{ 2, 7, 11, 15 };
            ArrayList b = new ArrayList(a);
            int target = 9;

            int[] result = new int[2];
            result = twoSum(b, target);
            Console.WriteLine($"Hello World {result[0]} and {result[1]}!");
        }
    }
}
