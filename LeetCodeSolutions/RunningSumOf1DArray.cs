using System;

namespace LeetCodeSolutions
{
    internal class RunningSumOf1DArray
    {
        public void RunningSumOfArray(int[] nums)
        {
            int[] array = new int[nums.Length];
            array[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                array[i] = array[i - 1] + nums[i];

            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


        }
    }


}
