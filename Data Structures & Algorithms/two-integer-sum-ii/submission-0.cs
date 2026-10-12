public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {                                          int sum = numbers[left] + numbers[right];

                                                        if (sum == target)
                                                                    {
                                                                                    // Return 1-indexed positions
                                                                                                    return new int[] { left + 1, right + 1 };
                                                                                                                }
                                                                                                                            else if (sum < target)
                                                                                                                                        {
                                                                                                                                                        // Need a larger sum
                                                                                                                                                                        left++;
                                                                                                                                                                                    }
                                                                                                                                                                                                else
                                                                                                                                                                                                            {
                                                                                                                                                                                                                            // Need a smaller sum
                                                                                                                                                                                                                                            right--;
                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                }

                                                                                                                                                                                                                                                                        return Array.Empty<int>();
    }
}
