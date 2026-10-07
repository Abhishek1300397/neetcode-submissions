public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> uniqueNumbers = [];

        for (int i = 0; i <= nums.Length - 1; i++)
        {
            if (uniqueNumbers.Contains(nums[i]))
                return true;
            uniqueNumbers.Add(nums[i]);
        }
        return false;
    }
}