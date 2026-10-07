public class Solution {
    public int[] TwoSum(int[] nums, int target) {
  Dictionary<int, int> pairs = [];

  for (int i = 0; i < nums.Length; i++)
  {
      var needToCheck = target - nums[i];
      if (pairs.TryGetValue(needToCheck, out int value))
          return [value  , i];
      pairs[nums[i]] = i;
  }

  return [-1 ,-1];
    }
}
