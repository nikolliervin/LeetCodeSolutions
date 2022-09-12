namespace LeetCodeSolutions
{
    internal class FindPivotIndex
    {
        public int PivotIndex(int[] array)
        {
            int sum = 0;
            int leftSum = 0;
            if (array.Length == 0)
                return -1;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                int rightSum = sum - leftSum - array[i];

                if (rightSum == leftSum)
                    return i;
                leftSum += array[i];
            }
            return -1;


        }
    }
}
