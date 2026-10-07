public class Solution {
      public List<List<string>> GroupAnagrams(string[] strs)
    {
        var groups = new Dictionary<string, List<string>>();
        foreach (var str in strs)
        {
            int[] count = new int[26];

            foreach (char c in str)
            {
                count[c - 'a']++;
            }

            string key = string.Join("#", count);

            if (!groups.TryGetValue(key, out List<string>? value))
            {
                value = [];
                groups[key] = value;
            }

            value.Add(str);
        }

        return [.. groups.Values.Select(group => group)];
    }
}
