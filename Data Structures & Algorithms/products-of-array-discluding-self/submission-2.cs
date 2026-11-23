public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
{
    int[] prefix = new int[nums.Length];
    int[] suffix = new int[nums.Length];
    int[] res = new int[nums.Length];

    prefix[0] = nums[0];
    suffix[nums.Length - 1] = nums[^1];
    for (int i = 1; i < nums.Length; i++)
    {
        prefix[i] = nums[i] * prefix[i - 1];
    }

    for (int i = nums.Length - 2; i >= 0; i--)
    {
        suffix[i] = nums[i] * suffix[i + 1];
    }
    res[^1] = prefix[^2];
    res[0] = suffix[1];
    for (int i = 1; i < nums.Length-1; ++i)
    {
        res[i] = prefix[i-1] * suffix[i+1];
    }

    return res;

}
}