public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        int p = 1;
        int zerosCount = 0;
        foreach (int i in nums)
        {
            if (i == 0)
            {
                zerosCount++;
                continue;
            }
            p *= i;
        }

        int[] res = new int[nums.Length];

        if (zerosCount == 1)
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    res[i] = p;
                    continue;
                }
                res[i] = 0;
            }
        else if (zerosCount == 0)
            for (int i = 0; i < nums.Length; i++)
                res[i] = p / nums[i];

        return res;
    }
}