public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder builder = new StringBuilder();
        foreach(var str in strs)
        {
            builder.Append(str.Length);
            builder.Append("#");
            builder.Append(str);
        }
        return builder.ToString();
    }

    public List<string> Decode(string s)
    {
        List<string> result = [];

        int i = 0;

        while(i < s.Length)
        {
            int j = i;
            
            while(s[j] != '#')
            {
                j++;
            }

            var length = int.Parse(s[i..j]);

            i = j + 1;

            result.Add(s.Substring(i, length));

            i += length;
        }
        return result;
    }
}
