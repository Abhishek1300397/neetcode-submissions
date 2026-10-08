public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequency = [];

foreach (var num in nums)
{
    frequency[num] = frequency.GetValueOrDefault(num) + 1;  
}


List<int>[] buckets = new List<int>[nums.Length + 1];

foreach (var pair in frequency)
{
    int num = pair.Key;
    int count = pair.Value;

    buckets[count] ??= [];
    buckets[count].Add(num);
}


int[] result = new int[k];
int index = 0;

for (int count = buckets.Length - 1; count >= 0 && index < k; count--)
{
    if (buckets[count] == null)
        continue;

    foreach (var num in buckets[count])
    {
        result[index++] = num;

        if (index == k)
            break;
    }
}

return result;
    }
}
