using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode1
{
    class Program
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] array = new int[2];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        array[0] = i;
                        array[1] = j;
                        break;
                    }
                }
            }
            return array;
        }

    static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}