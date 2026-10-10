public class Solution {
 
public int LongestConsecutive(int[] nums)
{
    var set = new HashSet<int>(nums);
    int longest = 0;

    foreach (int num in set)
    {
        // Start only if this is the beginning of a sequence.
        if (!set.Contains(num - 1))
        {
            int current = num;
            int count = 1;

            while (set.Contains(current + 1))
            {
                current++;
                count++;
            }

            longest = Math.Max(longest, count);
        }
    }

    return longest;
}

}
