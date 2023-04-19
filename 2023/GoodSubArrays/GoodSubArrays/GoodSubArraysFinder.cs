namespace GoodSubArrays
{
    public class GoodSubArraysFinder
    {
        public int GetSubArraysCount(int[] nums, int k)
        {
            int count = 0;
            
            for (int i = 0; i < nums.Length; i++)
            {
                List<int> curSubArray = new List<int>();
                for (int j = i; j < nums.Length; j++)
                {
                    curSubArray.Add(nums[j]);
                    int curDistinctIntegerCount = curSubArray.Distinct().ToList().Count();
                    if (curDistinctIntegerCount == k)
                    {
                        count++;
                    }
                    else if (curDistinctIntegerCount > k)
                    {
                        break;
                    }
                }
            }

            return count;
        }
    }
}
